using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MethodManager.Interop;
using MethodMgr4Client;

namespace mm4clientTest
{
    public partial class Form1 : Form
    {
        MM4Client _myClient = new MM4Client();
        MM4RemoteError _myError;
        MM4RemoteMethodState _methodState = MM4RemoteMethodState.Unknown;
        MM4RemoteApplicationState _applicationState = MM4RemoteApplicationState.None;
        string _mmMethodName = "";

        private delegate void SetTextBoxTextHandler(TextBox ctrl, string value);
        private void SetTextBoxText(TextBox ctrl, String text)
        {
            try
            {
                if (!ctrl.IsDisposed)
                {
                    if (ctrl.InvokeRequired)
                    {
                        ctrl.Invoke(new SetTextBoxTextHandler(SetTextBoxText), new object[] { ctrl, text });
                    }
                    else
                    {
                        ctrl.Text = text;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private delegate void SetControlEnableHandler(Control ctrl, bool value);
        private void SetControlEnable(Control ctrl, bool value)
        {
            try
            {
                if (!ctrl.IsDisposed)
                {
                    if (ctrl.InvokeRequired)
                    {
                        ctrl.Invoke(new SetControlEnableHandler(SetControlEnable), new object[] { ctrl, value });
                    }
                    else
                    {
                        ctrl.Enabled = value;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Form1()
        {
            InitializeComponent();

            LoadSettings();
            EnableButtons(false);
        }

        private void LoadSettings()
        {
            txtLynxIP.Text = Settings1.Default.LynxIP;
            txtLynxPort.Text = Settings1.Default.LynxPort;
            txtClientIP.Text = Settings1.Default.ClientIP;
            txtClientPort.Text = Settings1.Default.ClientPort;
            txtUser.Text = Settings1.Default.User;
            txtMethodName.Text = Settings1.Default.LastMethod;
            txtVariableName.Text = Settings1.Default.LastVariable;
        }

        private void SaveSettings()
        {
            Settings1.Default.LynxIP = txtLynxIP.Text;
            Settings1.Default.LynxPort = txtLynxPort.Text;
            Settings1.Default.ClientIP = txtClientIP.Text;
            Settings1.Default.ClientPort = txtClientPort.Text;
            Settings1.Default.User = txtUser.Text;
            Settings1.Default.LastMethod = txtMethodName.Text;
            Settings1.Default.LastVariable = txtVariableName.Text;
            Settings1.Default.Save();
        }

        private void EnableButtons(bool enable)
        {
            btnReadVariable.Enabled = btnWriteVariable.Enabled = btnStartMethod.Enabled = enable;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "Connect")
            {
                SaveSettings();

                string error = "";
                if (!_myClient.Connect(Settings1.Default.LynxIP, Convert.ToInt32(Settings1.Default.LynxPort), Settings1.Default.ClientIP,
                    Convert.ToInt32(Settings1.Default.ClientPort), Settings1.Default.User, out error))
                    MessageBox.Show("Failed to connect to MM4 - " + error);
                else
                {
                    statusLabel.Text = "Connected";
                    EnableButtons(true);

                    _myClient.OnInitializationComplete += myClient_OnInitializationComplete;
                    _myClient.OnConnectionComplete += myClient_OnConnectionComplete;

                    _myClient.MethodWatch(true);
                    _myClient.OnMethodComplete += myClient_OnMethodComplete;
                }
            }
            else
            {
                if (_myClient.IsConnected)
                {
                    _myClient.Disconnect();
                    statusLabel.Text = "Disconnected";
                    EnableButtons(false);
                }
            }

            btnConnect.Text = _myClient.IsConnected ? "Disconnect" : "Connect";
            btnReadVariable.Enabled = btnWriteVariable.Enabled = _myClient.IsConnected;
        }

        void myClient_OnMethodComplete(string methodName, bool error, MM4RemoteApplicationState applicationState)
        {
            MessageBox.Show("Method - [" + methodName + "] completed");
        }

        void myClient_OnConnectionComplete(bool error, string errorMessages, MM4RemoteApplicationState applicationState)
        {
            if (!error)
                SetTextBoxText(txtEventMessage, "Connect Hardware Complete");
            else
                SetTextBoxText(txtEventMessage, errorMessages + " - " + applicationState.ToString());
            SetControlEnable(btnConnectHardware, true);
        }

        void myClient_OnInitializationComplete(bool error, string errorMessages, MM4RemoteApplicationState applicationState)
        {
            if (!error)
                SetTextBoxText(txtEventMessage, "Initialize Hardware Complete");
            else
                SetTextBoxText(txtEventMessage, errorMessages + " - " + applicationState.ToString());
            SetControlEnable(btnInitHardware, true);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _myClient.OnInitializationComplete -= myClient_OnInitializationComplete;
            _myClient.OnConnectionComplete -= myClient_OnConnectionComplete;

            _myClient.MethodWatch(false);
            _myClient.OnMethodComplete -= myClient_OnMethodComplete;

            if (_myClient.IsConnected)
                _myClient.Disconnect();

            SaveSettings();
        }

        private void btnReadVariable_Click(object sender, EventArgs e)
        {
            if (txtVariableName.Text != "")
            {
                Settings1.Default.LastVariable = txtVariableName.Text;

                string value = "";
                _myError = _myClient.GetVariable(txtVariableName.Text, out value);
                if (_myError != MM4RemoteError.OK)
                    MessageBox.Show(_myError.ToString());
                else
                    txtVariableValue.Text = value;
            }
            else
            {
                MessageBox.Show("Please enter a valid MM4 variable name");
                txtVariableName.Focus();
            }
        }

        private void btnWriteVariable_Click(object sender, EventArgs e)
        {
            if (txtVariableName.Text != "")
            {
                if (txtVariableValue.Text != "")
                {
                    Settings1.Default.LastVariable = txtVariableName.Text;

                    _myError = _myClient.SetVariable(txtVariableName.Text, txtVariableValue.Text);
                    if (_myError != MM4RemoteError.OK)
                        MessageBox.Show(_myError.ToString());
                    else
                        MessageBox.Show("Value in variable [" + txtVariableName.Text + "] has been updated to [" + txtVariableValue.Text + "].");
                }
                else
                {
                    MessageBox.Show("Please enter a valid MM4 variable value");
                    txtVariableValue.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid MM4 variable name");
                txtVariableName.Focus();
            }
        }

        private void btnStartMethod_Click(object sender, EventArgs e)
        {
            btnStartMethod.Enabled = btnJump.Enabled = btnStep.Enabled = false;
            Settings1.Default.LastMethod = txtMethodName.Text;
            _myError = _myClient.StartMethod(Settings1.Default.LastMethod);

            if (_myError == MM4RemoteError.OK)
            {
                _myError = _myClient.GetMethodState(out _mmMethodName, out _methodState);
                txtActiveMethod.Text = _mmMethodName;
                txtActiveMethodState.Text = _methodState.ToString();

                timer1.Start();
            }
            else
            {
                MessageBox.Show(_myError.ToString());
                btnStartMethod.Enabled = btnJump.Enabled = btnStep.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _myError = _myClient.GetMethodState(out _mmMethodName, out _methodState);

            txtActiveMethod.Text = _mmMethodName;
            txtActiveMethodState.Text = _methodState.ToString();

            if (_methodState != MM4RemoteMethodState.Busy)
            {
                timer1.Stop();
                btnStartMethod.Enabled = btnJump.Enabled = btnStep.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statusLabel.Text = "Disconnected";
        }

        private void btnInitHardware_Click(object sender, EventArgs e)
        {
            SetTextBoxText(txtEventMessage, "");
            SetControlEnable(btnInitHardware, false);
            _myError = _myClient.InitializeHardware();

            ProcessError();
        }

        private void btnStopMethod_Click(object sender, EventArgs e)
        {
            _myError = _myClient.StopMethod();

            ProcessError();
        }

        private void btnClearError_Click(object sender, EventArgs e)
        {
            _myError = _myClient.ClearErrors();

            ProcessError();
        }

        private void btnConnectHardware_Click(object sender, EventArgs e)
        {
            SetTextBoxText(txtEventMessage, "");
            SetControlEnable(btnConnectHardware, false);
            _myError = _myClient.ConnectHardware();

            ProcessError();
        }

        private void btnGetLastErrorMessage_Click(object sender, EventArgs e)
        {
            string errorString;
            _myError = _myClient.GetLastErrorMessage(out errorString);

            ProcessError();

            MessageBox.Show(errorString);
        }

        private void btnGetMethodState_Click(object sender, EventArgs e)
        {
            _myError = _myClient.GetMethodState(out _mmMethodName, out _methodState);

            ProcessError();

            txtActiveMethod.Text = _mmMethodName;
            txtActiveMethodState.Text = _methodState.ToString();
        }

        private void btnGetLastError_Click(object sender, EventArgs e)
        {
            string errorString;
            _myError = _myClient.GetLastError(out errorString);

            ProcessError();

            if (errorString != "")
                MessageBox.Show("Error Result = [" + errorString + "]");
        }

        private void btnGetApplicationState_Click(object sender, EventArgs e)
        {
            string workspaceName;
            string worktableNames;

            _myError = _myClient.GetApplicationState(out _applicationState, out workspaceName, out worktableNames);

            ProcessError();

            MessageBox.Show("Application State = [" + _applicationState.ToString() + "]" + Environment.NewLine +
                "Workspace Name = [" + workspaceName + "]" + Environment.NewLine +
                "Worktable Names = [" + worktableNames + "]");
        }

        private void btnToExecuteMode_Click(object sender, EventArgs e)
        {
            _myError = _myClient.SetExecuteMode(true);

            ProcessError();
        }

        private void ProcessError()
        {
            if (_myError != MM4RemoteError.OK)
                MessageBox.Show("Error - " + _myError.ToString());
        }

        private void btnToTestMode_Click(object sender, EventArgs e)
        {
            _myError = _myClient.SetExecuteMode(false);

            ProcessError();
        }

        private void btnToPersistMode_Click(object sender, EventArgs e)
        {
            _myError = _myClient.SetWorktablePersistModeOn(true);

            ProcessError();
        }

        private void btnToResetMode_Click(object sender, EventArgs e)
        {
            _myError = _myClient.SetWorktablePersistModeOn(false);

            ProcessError();
        }

        private void btnGetExecuteMode_Click(object sender, EventArgs e)
        {
            bool executeMode;
            _myError = _myClient.GetExecuteMode(out executeMode);

            ProcessError();

            MessageBox.Show(executeMode ? "Execute Mode" : "Test Mode");
        }

        private void btnGetWorktablePersistMode_Click(object sender, EventArgs e)
        {
            bool worktablePersistMode;
            _myError = _myClient.GetWorktablePersistModeOn(out worktablePersistMode);

            ProcessError();

            MessageBox.Show(worktablePersistMode ? "Worktable Persist Mode" : "Worktable Reset Mode");
        }

        private void btnJump_Click(object sender, EventArgs e)
        {
            btnStartMethod.Enabled = btnJump.Enabled = btnStep.Enabled = false;
            Settings1.Default.LastMethod = txtMethodName.Text;
            _myError = _myClient.StartMethodAtStep(Settings1.Default.LastMethod, Convert.ToInt32(txtStepNumber.Text));

            if (_myError == MM4RemoteError.OK)
            {
                _myError = _myClient.GetMethodState(out _mmMethodName, out _methodState);
                txtActiveMethod.Text = _mmMethodName;
                txtActiveMethodState.Text = _methodState.ToString();

                timer1.Start();
            }
            else
            {
                MessageBox.Show(_myError.ToString());
                btnStartMethod.Enabled = btnJump.Enabled = btnStep.Enabled = true;
            }
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            btnStartMethod.Enabled = btnJump.Enabled = btnStep.Enabled = false;
            Settings1.Default.LastMethod = txtMethodName.Text;
            _myError = _myClient.StartMethodSingleStep(Settings1.Default.LastMethod, Convert.ToInt32(txtStepNumber.Text));

            if (_myError == MM4RemoteError.OK)
            {
                _myError = _myClient.GetMethodState(out _mmMethodName, out _methodState);
                txtActiveMethod.Text = _mmMethodName;
                txtActiveMethodState.Text = _methodState.ToString();

                timer1.Start();
            }
            else
            {
                MessageBox.Show(_myError.ToString());
                btnStartMethod.Enabled = btnJump.Enabled = btnStep.Enabled = true;
            }
        }

        private void btnGetLastMethodResult_Click(object sender, EventArgs e)
        {
            string lastMethodName;
            MM4RemoteLastMethodResult  methodResult;
            _myError = _myClient.GetLastMethodResult(out lastMethodName, out methodResult);
        }

        private void btnGetProcessPausedFormActive_Click(object sender, EventArgs e)
        {
            bool processFormActive;
            _myError = _myClient.GetProcessPausedFormActive(out processFormActive);

            ProcessError();

            MessageBox.Show(processFormActive ? "Active" : "Inactive");
        }

        private void btnCloseActiveProcessPausedForm_Click(object sender, EventArgs e)
        {
            _myError = _myClient.CloseActiveProcessPausedForm();

            ProcessError();
        }
    }
}
