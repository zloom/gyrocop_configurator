namespace QuadroController
{
    partial class Controller
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
            this.button1 = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.motor1 = new System.Windows.Forms.TextBox();
            this.motor2 = new System.Windows.Forms.TextBox();
            this.motor3 = new System.Windows.Forms.TextBox();
            this.motor4 = new System.Windows.Forms.TextBox();
            this.baseSpeed = new System.Windows.Forms.TextBox();
            this.yprDisplay = new System.Windows.Forms.TextBox();
            this.startLog = new System.Windows.Forms.CheckBox();
            this.MPULog = new System.Windows.Forms.CheckBox();
            this.READLog = new System.Windows.Forms.CheckBox();
            this.disconnect = new System.Windows.Forms.Button();
            this.outDisplay = new System.Windows.Forms.TextBox();
            this.setDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.speedDisplay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 167);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // log
            // 
            this.log.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.log.FormattingEnabled = true;
            this.log.Location = new System.Drawing.Point(0, 277);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(668, 199);
            this.log.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // motor1
            // 
            this.motor1.Location = new System.Drawing.Point(12, 10);
            this.motor1.Name = "motor1";
            this.motor1.Size = new System.Drawing.Size(128, 20);
            this.motor1.TabIndex = 6;
            // 
            // motor2
            // 
            this.motor2.Location = new System.Drawing.Point(12, 36);
            this.motor2.Name = "motor2";
            this.motor2.Size = new System.Drawing.Size(128, 20);
            this.motor2.TabIndex = 6;
            // 
            // motor3
            // 
            this.motor3.Location = new System.Drawing.Point(12, 62);
            this.motor3.Name = "motor3";
            this.motor3.Size = new System.Drawing.Size(128, 20);
            this.motor3.TabIndex = 6;
            // 
            // motor4
            // 
            this.motor4.Location = new System.Drawing.Point(12, 85);
            this.motor4.Name = "motor4";
            this.motor4.Size = new System.Drawing.Size(128, 20);
            this.motor4.TabIndex = 6;
            // 
            // baseSpeed
            // 
            this.baseSpeed.Location = new System.Drawing.Point(12, 111);
            this.baseSpeed.Name = "baseSpeed";
            this.baseSpeed.Size = new System.Drawing.Size(128, 20);
            this.baseSpeed.TabIndex = 6;
            // 
            // yprDisplay
            // 
            this.yprDisplay.Location = new System.Drawing.Point(192, 12);
            this.yprDisplay.Name = "yprDisplay";
            this.yprDisplay.Size = new System.Drawing.Size(120, 20);
            this.yprDisplay.TabIndex = 6;
            // 
            // startLog
            // 
            this.startLog.AutoSize = true;
            this.startLog.Location = new System.Drawing.Point(12, 235);
            this.startLog.Name = "startLog";
            this.startLog.Size = new System.Drawing.Size(62, 17);
            this.startLog.TabIndex = 7;
            this.startLog.Text = "START";
            this.startLog.UseVisualStyleBackColor = true;
            // 
            // MPULog
            // 
            this.MPULog.AutoSize = true;
            this.MPULog.Location = new System.Drawing.Point(98, 235);
            this.MPULog.Name = "MPULog";
            this.MPULog.Size = new System.Drawing.Size(50, 17);
            this.MPULog.TabIndex = 7;
            this.MPULog.Text = "MPU";
            this.MPULog.UseVisualStyleBackColor = true;
            // 
            // READLog
            // 
            this.READLog.AutoSize = true;
            this.READLog.Location = new System.Drawing.Point(184, 235);
            this.READLog.Name = "READLog";
            this.READLog.Size = new System.Drawing.Size(56, 17);
            this.READLog.TabIndex = 7;
            this.READLog.Text = "READ";
            this.READLog.UseVisualStyleBackColor = true;
            // 
            // disconnect
            // 
            this.disconnect.Location = new System.Drawing.Point(336, 167);
            this.disconnect.Margin = new System.Windows.Forms.Padding(2);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(120, 28);
            this.disconnect.TabIndex = 2;
            this.disconnect.Text = "Disconnect";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // outDisplay
            // 
            this.outDisplay.Location = new System.Drawing.Point(192, 38);
            this.outDisplay.Name = "outDisplay";
            this.outDisplay.Size = new System.Drawing.Size(120, 20);
            this.outDisplay.TabIndex = 6;
            // 
            // setDisplay
            // 
            this.setDisplay.Location = new System.Drawing.Point(192, 64);
            this.setDisplay.Name = "setDisplay";
            this.setDisplay.Size = new System.Drawing.Size(120, 20);
            this.setDisplay.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ypr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "out";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "set";
            // 
            // speedDisplay
            // 
            this.speedDisplay.Location = new System.Drawing.Point(192, 90);
            this.speedDisplay.Name = "speedDisplay";
            this.speedDisplay.Size = new System.Drawing.Size(120, 20);
            this.speedDisplay.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "speed";
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 476);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.READLog);
            this.Controls.Add(this.MPULog);
            this.Controls.Add(this.startLog);
            this.Controls.Add(this.speedDisplay);
            this.Controls.Add(this.setDisplay);
            this.Controls.Add(this.outDisplay);
            this.Controls.Add(this.yprDisplay);
            this.Controls.Add(this.baseSpeed);
            this.Controls.Add(this.motor4);
            this.Controls.Add(this.motor3);
            this.Controls.Add(this.motor2);
            this.Controls.Add(this.motor1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.log);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Controller";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox log;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox motor1;
        private System.Windows.Forms.TextBox motor2;
        private System.Windows.Forms.TextBox motor3;
        private System.Windows.Forms.TextBox motor4;
        private System.Windows.Forms.TextBox baseSpeed;
        private System.Windows.Forms.TextBox yprDisplay;
        private System.Windows.Forms.CheckBox startLog;
        private System.Windows.Forms.CheckBox MPULog;
        private System.Windows.Forms.CheckBox READLog;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.TextBox outDisplay;
        private System.Windows.Forms.TextBox setDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox speedDisplay;
        private System.Windows.Forms.Label label4;
    }
}

