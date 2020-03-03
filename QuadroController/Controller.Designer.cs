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
            this.btn_connect = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.ListBox();
            this.yprDisplay = new System.Windows.Forms.TextBox();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.outDisplay = new System.Windows.Forms.TextBox();
            this.setDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.speedDisplay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(18, 142);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(65, 28);
            this.btn_connect.TabIndex = 2;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.ConnectClick);
            // 
            // log
            // 
            this.log.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.log.FormattingEnabled = true;
            this.log.Location = new System.Drawing.Point(0, 194);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(668, 199);
            this.log.TabIndex = 4;
            // 
            // yprDisplay
            // 
            this.yprDisplay.Location = new System.Drawing.Point(56, 26);
            this.yprDisplay.Name = "yprDisplay";
            this.yprDisplay.Size = new System.Drawing.Size(120, 20);
            this.yprDisplay.TabIndex = 6;
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(96, 142);
            this.btn_disconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(80, 28);
            this.btn_disconnect.TabIndex = 2;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.DisconnectClick);
            // 
            // outDisplay
            // 
            this.outDisplay.Location = new System.Drawing.Point(56, 52);
            this.outDisplay.Name = "outDisplay";
            this.outDisplay.Size = new System.Drawing.Size(120, 20);
            this.outDisplay.TabIndex = 6;
            // 
            // setDisplay
            // 
            this.setDisplay.Location = new System.Drawing.Point(56, 78);
            this.setDisplay.Name = "setDisplay";
            this.setDisplay.Size = new System.Drawing.Size(120, 20);
            this.setDisplay.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ypr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "out";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "set";
            // 
            // speedDisplay
            // 
            this.speedDisplay.Location = new System.Drawing.Point(56, 104);
            this.speedDisplay.Name = "speedDisplay";
            this.speedDisplay.Size = new System.Drawing.Size(120, 20);
            this.speedDisplay.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "speed";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(342, 145);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 9;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.StartClick);
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 393);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speedDisplay);
            this.Controls.Add(this.setDisplay);
            this.Controls.Add(this.outDisplay);
            this.Controls.Add(this.yprDisplay);
            this.Controls.Add(this.log);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_connect);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Controller";
            this.Text = "Controller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.ListBox log;
        private System.Windows.Forms.TextBox yprDisplay;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.TextBox outDisplay;
        private System.Windows.Forms.TextBox setDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox speedDisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_start;
    }
}

