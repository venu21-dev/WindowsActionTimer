namespace WindowsActionTimer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnStart = new Button();
            btnStop = new Button();
            groupBox1 = new GroupBox();
            lblTimer = new Label();
            groupBox2 = new GroupBox();
            txtSeconds = new TextBox();
            txtMinutes = new TextBox();
            txtHours = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            rbSleep = new RadioButton();
            rbReboot = new RadioButton();
            rbShutdown = new RadioButton();
            timer = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(12, 117);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(108, 66);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(126, 117);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(108, 66);
            btnStop.TabIndex = 1;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTimer);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(222, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Timer";
            // 
            // lblTimer
            // 
            lblTimer.Font = new Font("Segoe UI", 20F);
            lblTimer.Location = new Point(53, 34);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(119, 41);
            lblTimer.TabIndex = 3;
            lblTimer.Text = "00:00:00";
            lblTimer.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSeconds);
            groupBox2.Controls.Add(txtMinutes);
            groupBox2.Controls.Add(txtHours);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(240, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(185, 171);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Set Timer";
            // 
            // txtSeconds
            // 
            txtSeconds.Location = new Point(80, 121);
            txtSeconds.Name = "txtSeconds";
            txtSeconds.Size = new Size(81, 23);
            txtSeconds.TabIndex = 5;
            // 
            // txtMinutes
            // 
            txtMinutes.Location = new Point(80, 77);
            txtMinutes.Name = "txtMinutes";
            txtMinutes.Size = new Size(81, 23);
            txtMinutes.TabIndex = 4;
            // 
            // txtHours
            // 
            txtHours.Location = new Point(80, 41);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(81, 23);
            txtHours.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 124);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Seconds";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 85);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Minutes";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 44);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Hours";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbSleep);
            groupBox3.Controls.Add(rbReboot);
            groupBox3.Controls.Add(rbShutdown);
            groupBox3.Location = new Point(431, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(149, 171);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Actions";
            // 
            // rbSleep
            // 
            rbSleep.AutoSize = true;
            rbSleep.Location = new Point(28, 123);
            rbSleep.Name = "rbSleep";
            rbSleep.Size = new Size(87, 19);
            rbSleep.TabIndex = 2;
            rbSleep.TabStop = true;
            rbSleep.Text = "Sleep Mode";
            rbSleep.UseVisualStyleBackColor = true;
            // 
            // rbReboot
            // 
            rbReboot.AutoSize = true;
            rbReboot.Location = new Point(28, 82);
            rbReboot.Name = "rbReboot";
            rbReboot.Size = new Size(63, 19);
            rbReboot.TabIndex = 1;
            rbReboot.TabStop = true;
            rbReboot.Text = "Reboot";
            rbReboot.UseVisualStyleBackColor = true;
            // 
            // rbShutdown
            // 
            rbShutdown.AutoSize = true;
            rbShutdown.Location = new Point(28, 43);
            rbShutdown.Name = "rbShutdown";
            rbShutdown.Size = new Size(79, 19);
            rbShutdown.TabIndex = 0;
            rbShutdown.TabStop = true;
            rbShutdown.Text = "Shutdown";
            rbShutdown.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 195);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "WindowsActionTimer";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private GroupBox groupBox1;
        private Label lblTimer;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtSeconds;
        private TextBox txtMinutes;
        private TextBox txtHours;
        private GroupBox groupBox3;
        private RadioButton rbSleep;
        private RadioButton rbReboot;
        private RadioButton rbShutdown;
        private System.Windows.Forms.Timer timer;
    }
}
