namespace mm4clientTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnReadVariable = new System.Windows.Forms.Button();
            this.btnWriteVariable = new System.Windows.Forms.Button();
            this.txtLynxIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLynxPort = new System.Windows.Forms.TextBox();
            this.txtClientPort = new System.Windows.Forms.TextBox();
            this.txtClientIP = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVariableName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVariableValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStartMethod = new System.Windows.Forms.Button();
            this.txtMethodName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtActiveMethodState = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtActiveMethod = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnGetLastMethodResult = new System.Windows.Forms.Button();
            this.lblStepNumber = new System.Windows.Forms.Label();
            this.txtStepNumber = new System.Windows.Forms.TextBox();
            this.btnStep = new System.Windows.Forms.Button();
            this.btnJump = new System.Windows.Forms.Button();
            this.btnStopMethod = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnInitHardware = new System.Windows.Forms.Button();
            this.txtEventMessage = new System.Windows.Forms.TextBox();
            this.btnClearError = new System.Windows.Forms.Button();
            this.btnConnectHardware = new System.Windows.Forms.Button();
            this.btnGetLastErrorMessage = new System.Windows.Forms.Button();
            this.btnGetMethodState = new System.Windows.Forms.Button();
            this.btnGetLastError = new System.Windows.Forms.Button();
            this.btnGetApplicationState = new System.Windows.Forms.Button();
            this.btnToTestMode = new System.Windows.Forms.Button();
            this.btnToExecuteMode = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGetExecuteMode = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGetWorktablePersistMode = new System.Windows.Forms.Button();
            this.btnToPersistMode = new System.Windows.Forms.Button();
            this.btnToResetMode = new System.Windows.Forms.Button();
            this.btnCloseActiveProcessPausedForm = new System.Windows.Forms.Button();
            this.btnGetProcessPausedFormActive = new System.Windows.Forms.Button();
            this.chkRetry = new System.Windows.Forms.CheckBox();
            this.chkContinue = new System.Windows.Forms.CheckBox();
            this.btnWatchVariable = new System.Windows.Forms.Button();
            this.btnUnwatchVariable = new System.Windows.Forms.Button();
            this.btnUnwatchMethod = new System.Windows.Forms.Button();
            this.btnWatchMethod = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 38);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnReadVariable
            // 
            this.btnReadVariable.Location = new System.Drawing.Point(18, 26);
            this.btnReadVariable.Name = "btnReadVariable";
            this.btnReadVariable.Size = new System.Drawing.Size(75, 23);
            this.btnReadVariable.TabIndex = 1;
            this.btnReadVariable.Text = "Read";
            this.btnReadVariable.UseVisualStyleBackColor = true;
            this.btnReadVariable.Click += new System.EventHandler(this.btnReadVariable_Click);
            // 
            // btnWriteVariable
            // 
            this.btnWriteVariable.Location = new System.Drawing.Point(18, 55);
            this.btnWriteVariable.Name = "btnWriteVariable";
            this.btnWriteVariable.Size = new System.Drawing.Size(75, 23);
            this.btnWriteVariable.TabIndex = 2;
            this.btnWriteVariable.Text = "Write";
            this.btnWriteVariable.UseVisualStyleBackColor = true;
            this.btnWriteVariable.Click += new System.EventHandler(this.btnWriteVariable_Click);
            // 
            // txtLynxIP
            // 
            this.txtLynxIP.Location = new System.Drawing.Point(93, 40);
            this.txtLynxIP.Name = "txtLynxIP";
            this.txtLynxIP.Size = new System.Drawing.Size(87, 20);
            this.txtLynxIP.TabIndex = 3;
            this.txtLynxIP.Text = "192.168.1.190";
            this.txtLynxIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server IP (MM4)";
            // 
            // txtLynxPort
            // 
            this.txtLynxPort.Location = new System.Drawing.Point(186, 40);
            this.txtLynxPort.Name = "txtLynxPort";
            this.txtLynxPort.Size = new System.Drawing.Size(87, 20);
            this.txtLynxPort.TabIndex = 5;
            this.txtLynxPort.Text = "47000";
            this.txtLynxPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtClientPort
            // 
            this.txtClientPort.Location = new System.Drawing.Point(372, 40);
            this.txtClientPort.Name = "txtClientPort";
            this.txtClientPort.Size = new System.Drawing.Size(87, 20);
            this.txtClientPort.TabIndex = 7;
            this.txtClientPort.Text = "47001";
            this.txtClientPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtClientIP
            // 
            this.txtClientIP.Location = new System.Drawing.Point(279, 40);
            this.txtClientIP.Name = "txtClientIP";
            this.txtClientIP.Size = new System.Drawing.Size(87, 20);
            this.txtClientIP.TabIndex = 6;
            this.txtClientIP.Text = "192.168.1.190";
            this.txtClientIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(465, 40);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(87, 20);
            this.txtUser.TabIndex = 8;
            this.txtUser.Text = "Remote";
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Server Port (MM4)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Client Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(303, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Client IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(491, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "User";
            // 
            // txtVariableName
            // 
            this.txtVariableName.Location = new System.Drawing.Point(141, 48);
            this.txtVariableName.Name = "txtVariableName";
            this.txtVariableName.Size = new System.Drawing.Size(180, 20);
            this.txtVariableName.TabIndex = 13;
            this.txtVariableName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Variable Name";
            // 
            // txtVariableValue
            // 
            this.txtVariableValue.Location = new System.Drawing.Point(327, 48);
            this.txtVariableValue.Name = "txtVariableValue";
            this.txtVariableValue.Size = new System.Drawing.Size(180, 20);
            this.txtVariableValue.TabIndex = 15;
            this.txtVariableValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Value";
            // 
            // btnStartMethod
            // 
            this.btnStartMethod.Location = new System.Drawing.Point(18, 26);
            this.btnStartMethod.Name = "btnStartMethod";
            this.btnStartMethod.Size = new System.Drawing.Size(75, 23);
            this.btnStartMethod.TabIndex = 17;
            this.btnStartMethod.Text = "Start";
            this.btnStartMethod.UseVisualStyleBackColor = true;
            this.btnStartMethod.Click += new System.EventHandler(this.btnStartMethod_Click);
            // 
            // txtMethodName
            // 
            this.txtMethodName.Location = new System.Drawing.Point(187, 28);
            this.txtMethodName.Name = "txtMethodName";
            this.txtMethodName.Size = new System.Drawing.Size(320, 20);
            this.txtMethodName.TabIndex = 18;
            this.txtMethodName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(381, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Method State";
            // 
            // txtActiveMethodState
            // 
            this.txtActiveMethodState.Location = new System.Drawing.Point(327, 76);
            this.txtActiveMethodState.Name = "txtActiveMethodState";
            this.txtActiveMethodState.ReadOnly = true;
            this.txtActiveMethodState.Size = new System.Drawing.Size(180, 20);
            this.txtActiveMethodState.TabIndex = 23;
            this.txtActiveMethodState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(196, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Active Method";
            // 
            // txtActiveMethod
            // 
            this.txtActiveMethod.Location = new System.Drawing.Point(141, 76);
            this.txtActiveMethod.Name = "txtActiveMethod";
            this.txtActiveMethod.ReadOnly = true;
            this.txtActiveMethod.Size = new System.Drawing.Size(180, 20);
            this.txtActiveMethod.TabIndex = 21;
            this.txtActiveMethod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUnwatchVariable);
            this.groupBox1.Controls.Add(this.btnWatchVariable);
            this.groupBox1.Controls.Add(this.btnReadVariable);
            this.groupBox1.Controls.Add(this.btnWriteVariable);
            this.groupBox1.Controls.Add(this.txtVariableName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtVariableValue);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 118);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Variable";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUnwatchMethod);
            this.groupBox2.Controls.Add(this.btnWatchMethod);
            this.groupBox2.Controls.Add(this.btnPause);
            this.groupBox2.Controls.Add(this.btnGetLastMethodResult);
            this.groupBox2.Controls.Add(this.lblStepNumber);
            this.groupBox2.Controls.Add(this.txtStepNumber);
            this.groupBox2.Controls.Add(this.btnStep);
            this.groupBox2.Controls.Add(this.btnJump);
            this.groupBox2.Controls.Add(this.btnStopMethod);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtMethodName);
            this.groupBox2.Controls.Add(this.btnStartMethod);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtActiveMethod);
            this.groupBox2.Controls.Add(this.txtActiveMethodState);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(12, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 229);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Method";
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(18, 84);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 42;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnGetLastMethodResult
            // 
            this.btnGetLastMethodResult.Location = new System.Drawing.Point(327, 154);
            this.btnGetLastMethodResult.Name = "btnGetLastMethodResult";
            this.btnGetLastMethodResult.Size = new System.Drawing.Size(142, 23);
            this.btnGetLastMethodResult.TabIndex = 41;
            this.btnGetLastMethodResult.Text = "Get Last Method Result";
            this.btnGetLastMethodResult.UseVisualStyleBackColor = true;
            this.btnGetLastMethodResult.Click += new System.EventHandler(this.btnGetLastMethodResult_Click);
            // 
            // lblStepNumber
            // 
            this.lblStepNumber.AutoSize = true;
            this.lblStepNumber.Location = new System.Drawing.Point(151, 138);
            this.lblStepNumber.Name = "lblStepNumber";
            this.lblStepNumber.Size = new System.Drawing.Size(69, 13);
            this.lblStepNumber.TabIndex = 35;
            this.lblStepNumber.Text = "Step Number";
            // 
            // txtStepNumber
            // 
            this.txtStepNumber.Location = new System.Drawing.Point(141, 154);
            this.txtStepNumber.Name = "txtStepNumber";
            this.txtStepNumber.Size = new System.Drawing.Size(87, 20);
            this.txtStepNumber.TabIndex = 34;
            this.txtStepNumber.Text = "0";
            this.txtStepNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStep
            // 
            this.btnStep.Location = new System.Drawing.Point(18, 164);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(106, 38);
            this.btnStep.TabIndex = 33;
            this.btnStep.Text = "Run a Single Step (Step)";
            this.btnStep.UseVisualStyleBackColor = true;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // btnJump
            // 
            this.btnJump.Location = new System.Drawing.Point(18, 120);
            this.btnJump.Name = "btnJump";
            this.btnJump.Size = new System.Drawing.Size(106, 38);
            this.btnJump.TabIndex = 32;
            this.btnJump.Text = "Start At Step (Jump)";
            this.btnJump.UseVisualStyleBackColor = true;
            this.btnJump.Click += new System.EventHandler(this.btnJump_Click);
            // 
            // btnStopMethod
            // 
            this.btnStopMethod.Location = new System.Drawing.Point(18, 55);
            this.btnStopMethod.Name = "btnStopMethod";
            this.btnStopMethod.Size = new System.Drawing.Size(75, 23);
            this.btnStopMethod.TabIndex = 31;
            this.btnStopMethod.Text = "Stop";
            this.btnStopMethod.UseVisualStyleBackColor = true;
            this.btnStopMethod.Click += new System.EventHandler(this.btnStopMethod_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(138, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Method";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 635);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(578, 22);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // btnInitHardware
            // 
            this.btnInitHardware.Location = new System.Drawing.Point(12, 67);
            this.btnInitHardware.Name = "btnInitHardware";
            this.btnInitHardware.Size = new System.Drawing.Size(107, 23);
            this.btnInitHardware.TabIndex = 29;
            this.btnInitHardware.Text = "Initialize Hardware";
            this.btnInitHardware.UseVisualStyleBackColor = true;
            this.btnInitHardware.Click += new System.EventHandler(this.btnInitHardware_Click);
            // 
            // txtEventMessage
            // 
            this.txtEventMessage.Location = new System.Drawing.Point(10, 610);
            this.txtEventMessage.Name = "txtEventMessage";
            this.txtEventMessage.ReadOnly = true;
            this.txtEventMessage.Size = new System.Drawing.Size(556, 20);
            this.txtEventMessage.TabIndex = 30;
            this.txtEventMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClearError
            // 
            this.btnClearError.Location = new System.Drawing.Point(12, 125);
            this.btnClearError.Name = "btnClearError";
            this.btnClearError.Size = new System.Drawing.Size(75, 23);
            this.btnClearError.TabIndex = 31;
            this.btnClearError.Text = "Clear Errors";
            this.btnClearError.UseVisualStyleBackColor = true;
            this.btnClearError.Click += new System.EventHandler(this.btnClearError_Click);
            // 
            // btnConnectHardware
            // 
            this.btnConnectHardware.Location = new System.Drawing.Point(12, 96);
            this.btnConnectHardware.Name = "btnConnectHardware";
            this.btnConnectHardware.Size = new System.Drawing.Size(107, 23);
            this.btnConnectHardware.TabIndex = 32;
            this.btnConnectHardware.Text = "Connect Hardware";
            this.btnConnectHardware.UseVisualStyleBackColor = true;
            this.btnConnectHardware.Click += new System.EventHandler(this.btnConnectHardware_Click);
            // 
            // btnGetLastErrorMessage
            // 
            this.btnGetLastErrorMessage.Location = new System.Drawing.Point(111, 518);
            this.btnGetLastErrorMessage.Name = "btnGetLastErrorMessage";
            this.btnGetLastErrorMessage.Size = new System.Drawing.Size(125, 23);
            this.btnGetLastErrorMessage.TabIndex = 33;
            this.btnGetLastErrorMessage.Text = "GetLastErrorMessage";
            this.btnGetLastErrorMessage.UseVisualStyleBackColor = true;
            this.btnGetLastErrorMessage.Click += new System.EventHandler(this.btnGetLastErrorMessage_Click);
            // 
            // btnGetMethodState
            // 
            this.btnGetMethodState.Location = new System.Drawing.Point(242, 518);
            this.btnGetMethodState.Name = "btnGetMethodState";
            this.btnGetMethodState.Size = new System.Drawing.Size(118, 23);
            this.btnGetMethodState.TabIndex = 34;
            this.btnGetMethodState.Text = "Get Method State";
            this.btnGetMethodState.UseVisualStyleBackColor = true;
            this.btnGetMethodState.Click += new System.EventHandler(this.btnGetMethodState_Click);
            // 
            // btnGetLastError
            // 
            this.btnGetLastError.Location = new System.Drawing.Point(30, 518);
            this.btnGetLastError.Name = "btnGetLastError";
            this.btnGetLastError.Size = new System.Drawing.Size(75, 23);
            this.btnGetLastError.TabIndex = 35;
            this.btnGetLastError.Text = "GetLastError";
            this.btnGetLastError.UseVisualStyleBackColor = true;
            this.btnGetLastError.Click += new System.EventHandler(this.btnGetLastError_Click);
            // 
            // btnGetApplicationState
            // 
            this.btnGetApplicationState.Location = new System.Drawing.Point(366, 518);
            this.btnGetApplicationState.Name = "btnGetApplicationState";
            this.btnGetApplicationState.Size = new System.Drawing.Size(118, 23);
            this.btnGetApplicationState.TabIndex = 36;
            this.btnGetApplicationState.Text = "Get Aplication State";
            this.btnGetApplicationState.UseVisualStyleBackColor = true;
            this.btnGetApplicationState.Click += new System.EventHandler(this.btnGetApplicationState_Click);
            // 
            // btnToTestMode
            // 
            this.btnToTestMode.Location = new System.Drawing.Point(8, 51);
            this.btnToTestMode.Name = "btnToTestMode";
            this.btnToTestMode.Size = new System.Drawing.Size(107, 23);
            this.btnToTestMode.TabIndex = 38;
            this.btnToTestMode.Text = "To Test Mode";
            this.btnToTestMode.UseVisualStyleBackColor = true;
            this.btnToTestMode.Click += new System.EventHandler(this.btnToTestMode_Click);
            // 
            // btnToExecuteMode
            // 
            this.btnToExecuteMode.Location = new System.Drawing.Point(8, 22);
            this.btnToExecuteMode.Name = "btnToExecuteMode";
            this.btnToExecuteMode.Size = new System.Drawing.Size(107, 23);
            this.btnToExecuteMode.TabIndex = 37;
            this.btnToExecuteMode.Text = "To Execute Mode";
            this.btnToExecuteMode.UseVisualStyleBackColor = true;
            this.btnToExecuteMode.Click += new System.EventHandler(this.btnToExecuteMode_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGetExecuteMode);
            this.groupBox3.Controls.Add(this.btnToExecuteMode);
            this.groupBox3.Controls.Add(this.btnToTestMode);
            this.groupBox3.Location = new System.Drawing.Point(234, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 86);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Execution Mode";
            // 
            // btnGetExecuteMode
            // 
            this.btnGetExecuteMode.Location = new System.Drawing.Point(120, 37);
            this.btnGetExecuteMode.Name = "btnGetExecuteMode";
            this.btnGetExecuteMode.Size = new System.Drawing.Size(35, 23);
            this.btnGetExecuteMode.TabIndex = 42;
            this.btnGetExecuteMode.Text = "Get";
            this.btnGetExecuteMode.UseVisualStyleBackColor = true;
            this.btnGetExecuteMode.Click += new System.EventHandler(this.btnGetExecuteMode_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGetWorktablePersistMode);
            this.groupBox4.Controls.Add(this.btnToPersistMode);
            this.groupBox4.Controls.Add(this.btnToResetMode);
            this.groupBox4.Location = new System.Drawing.Point(404, 67);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(164, 86);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Worktable Mode";
            // 
            // btnGetWorktablePersistMode
            // 
            this.btnGetWorktablePersistMode.Location = new System.Drawing.Point(120, 37);
            this.btnGetWorktablePersistMode.Name = "btnGetWorktablePersistMode";
            this.btnGetWorktablePersistMode.Size = new System.Drawing.Size(35, 23);
            this.btnGetWorktablePersistMode.TabIndex = 41;
            this.btnGetWorktablePersistMode.Text = "Get";
            this.btnGetWorktablePersistMode.UseVisualStyleBackColor = true;
            this.btnGetWorktablePersistMode.Click += new System.EventHandler(this.btnGetWorktablePersistMode_Click);
            // 
            // btnToPersistMode
            // 
            this.btnToPersistMode.Location = new System.Drawing.Point(8, 22);
            this.btnToPersistMode.Name = "btnToPersistMode";
            this.btnToPersistMode.Size = new System.Drawing.Size(107, 23);
            this.btnToPersistMode.TabIndex = 39;
            this.btnToPersistMode.Text = "To Persist Mode";
            this.btnToPersistMode.UseVisualStyleBackColor = true;
            this.btnToPersistMode.Click += new System.EventHandler(this.btnToPersistMode_Click);
            // 
            // btnToResetMode
            // 
            this.btnToResetMode.Location = new System.Drawing.Point(8, 51);
            this.btnToResetMode.Name = "btnToResetMode";
            this.btnToResetMode.Size = new System.Drawing.Size(107, 23);
            this.btnToResetMode.TabIndex = 40;
            this.btnToResetMode.Text = "To Reset Mode";
            this.btnToResetMode.UseVisualStyleBackColor = true;
            this.btnToResetMode.Click += new System.EventHandler(this.btnToResetMode_Click);
            // 
            // btnCloseActiveProcessPausedForm
            // 
            this.btnCloseActiveProcessPausedForm.Enabled = false;
            this.btnCloseActiveProcessPausedForm.Location = new System.Drawing.Point(134, 547);
            this.btnCloseActiveProcessPausedForm.Name = "btnCloseActiveProcessPausedForm";
            this.btnCloseActiveProcessPausedForm.Size = new System.Drawing.Size(98, 53);
            this.btnCloseActiveProcessPausedForm.TabIndex = 46;
            this.btnCloseActiveProcessPausedForm.Text = "Close Active ProcessPaused Form";
            this.btnCloseActiveProcessPausedForm.UseVisualStyleBackColor = true;
            this.btnCloseActiveProcessPausedForm.Click += new System.EventHandler(this.btnCloseActiveProcessPausedForm_Click);
            // 
            // btnGetProcessPausedFormActive
            // 
            this.btnGetProcessPausedFormActive.Location = new System.Drawing.Point(30, 547);
            this.btnGetProcessPausedFormActive.Name = "btnGetProcessPausedFormActive";
            this.btnGetProcessPausedFormActive.Size = new System.Drawing.Size(98, 53);
            this.btnGetProcessPausedFormActive.TabIndex = 45;
            this.btnGetProcessPausedFormActive.Text = "Get Process Paused Form Active";
            this.btnGetProcessPausedFormActive.UseVisualStyleBackColor = true;
            this.btnGetProcessPausedFormActive.Click += new System.EventHandler(this.btnGetProcessPausedFormActive_Click);
            // 
            // chkRetry
            // 
            this.chkRetry.AutoSize = true;
            this.chkRetry.Enabled = false;
            this.chkRetry.Location = new System.Drawing.Point(245, 578);
            this.chkRetry.Name = "chkRetry";
            this.chkRetry.Size = new System.Drawing.Size(51, 17);
            this.chkRetry.TabIndex = 48;
            this.chkRetry.Text = "Retry";
            this.chkRetry.UseVisualStyleBackColor = true;
            // 
            // chkContinue
            // 
            this.chkContinue.AutoSize = true;
            this.chkContinue.Enabled = false;
            this.chkContinue.Location = new System.Drawing.Point(245, 555);
            this.chkContinue.Name = "chkContinue";
            this.chkContinue.Size = new System.Drawing.Size(68, 17);
            this.chkContinue.TabIndex = 47;
            this.chkContinue.Text = "Continue";
            this.chkContinue.UseVisualStyleBackColor = true;
            // 
            // btnWatchVariable
            // 
            this.btnWatchVariable.Location = new System.Drawing.Point(18, 84);
            this.btnWatchVariable.Name = "btnWatchVariable";
            this.btnWatchVariable.Size = new System.Drawing.Size(75, 23);
            this.btnWatchVariable.TabIndex = 17;
            this.btnWatchVariable.Text = "Watch";
            this.btnWatchVariable.UseVisualStyleBackColor = true;
            this.btnWatchVariable.Click += new System.EventHandler(this.btnWatchVariable_Click);
            // 
            // btnUnwatchVariable
            // 
            this.btnUnwatchVariable.Location = new System.Drawing.Point(104, 84);
            this.btnUnwatchVariable.Name = "btnUnwatchVariable";
            this.btnUnwatchVariable.Size = new System.Drawing.Size(75, 23);
            this.btnUnwatchVariable.TabIndex = 18;
            this.btnUnwatchVariable.Text = "Unwatch";
            this.btnUnwatchVariable.UseVisualStyleBackColor = true;
            this.btnUnwatchVariable.Click += new System.EventHandler(this.btnUnwatchVariable_Click);
            // 
            // btnUnwatchMethod
            // 
            this.btnUnwatchMethod.Location = new System.Drawing.Point(227, 191);
            this.btnUnwatchMethod.Name = "btnUnwatchMethod";
            this.btnUnwatchMethod.Size = new System.Drawing.Size(75, 23);
            this.btnUnwatchMethod.TabIndex = 44;
            this.btnUnwatchMethod.Text = "Unwatch";
            this.btnUnwatchMethod.UseVisualStyleBackColor = true;
            this.btnUnwatchMethod.Click += new System.EventHandler(this.btnUnwatchMethod_Click);
            // 
            // btnWatchMethod
            // 
            this.btnWatchMethod.Location = new System.Drawing.Point(141, 191);
            this.btnWatchMethod.Name = "btnWatchMethod";
            this.btnWatchMethod.Size = new System.Drawing.Size(75, 23);
            this.btnWatchMethod.TabIndex = 43;
            this.btnWatchMethod.Text = "Watch";
            this.btnWatchMethod.UseVisualStyleBackColor = true;
            this.btnWatchMethod.Click += new System.EventHandler(this.btnWatchMethod_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(326, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 12);
            this.label11.TabIndex = 49;
            this.label11.Text = "(For Notification)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 657);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chkRetry);
            this.Controls.Add(this.chkContinue);
            this.Controls.Add(this.btnCloseActiveProcessPausedForm);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnGetProcessPausedFormActive);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnGetApplicationState);
            this.Controls.Add(this.btnGetLastError);
            this.Controls.Add(this.btnGetMethodState);
            this.Controls.Add(this.btnGetLastErrorMessage);
            this.Controls.Add(this.btnConnectHardware);
            this.Controls.Add(this.btnClearError);
            this.Controls.Add(this.txtEventMessage);
            this.Controls.Add(this.btnInitHardware);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtClientPort);
            this.Controls.Add(this.txtClientIP);
            this.Controls.Add(this.txtLynxPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLynxIP);
            this.Controls.Add(this.btnConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Method Manager 4 - Remote Client Example ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnReadVariable;
        private System.Windows.Forms.Button btnWriteVariable;
        private System.Windows.Forms.TextBox txtLynxIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLynxPort;
        private System.Windows.Forms.TextBox txtClientPort;
        private System.Windows.Forms.TextBox txtClientIP;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVariableName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVariableValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnStartMethod;
        private System.Windows.Forms.TextBox txtMethodName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtActiveMethodState;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtActiveMethod;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnInitHardware;
        private System.Windows.Forms.TextBox txtEventMessage;
        private System.Windows.Forms.Button btnStopMethod;
        private System.Windows.Forms.Button btnClearError;
        private System.Windows.Forms.Button btnConnectHardware;
        private System.Windows.Forms.Button btnGetLastErrorMessage;
        private System.Windows.Forms.Button btnGetMethodState;
        private System.Windows.Forms.Button btnGetLastError;
        private System.Windows.Forms.Label lblStepNumber;
        private System.Windows.Forms.TextBox txtStepNumber;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.Button btnJump;
        private System.Windows.Forms.Button btnGetApplicationState;
        private System.Windows.Forms.Button btnToTestMode;
        private System.Windows.Forms.Button btnToExecuteMode;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGetExecuteMode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnGetWorktablePersistMode;
        private System.Windows.Forms.Button btnToPersistMode;
        private System.Windows.Forms.Button btnToResetMode;
        private System.Windows.Forms.Button btnGetLastMethodResult;
        private System.Windows.Forms.Button btnCloseActiveProcessPausedForm;
        private System.Windows.Forms.Button btnGetProcessPausedFormActive;
        private System.Windows.Forms.CheckBox chkRetry;
        private System.Windows.Forms.CheckBox chkContinue;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnWatchVariable;
        private System.Windows.Forms.Button btnUnwatchVariable;
        private System.Windows.Forms.Button btnUnwatchMethod;
        private System.Windows.Forms.Button btnWatchMethod;
        private System.Windows.Forms.Label label11;
    }
}

