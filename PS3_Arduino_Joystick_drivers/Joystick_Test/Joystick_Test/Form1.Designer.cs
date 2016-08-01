namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.Capturecmd = new System.Windows.Forms.Button();
            this.prgY1 = new System.Windows.Forms.ProgressBar();
            this.prgY2 = new System.Windows.Forms.ProgressBar();
            this.prgX1 = new System.Windows.Forms.ProgressBar();
            this.prgX2 = new System.Windows.Forms.ProgressBar();
            this.prgZ = new System.Windows.Forms.ProgressBar();
            this.chkTrigger = new System.Windows.Forms.CheckBox();
            this.chkButton2 = new System.Windows.Forms.CheckBox();
            this.chkButton3 = new System.Windows.Forms.CheckBox();
            this.chkButton4 = new System.Windows.Forms.CheckBox();
            this.chkButton5 = new System.Windows.Forms.CheckBox();
            this.chkButton6 = new System.Windows.Forms.CheckBox();
            this.chkButtonLeft = new System.Windows.Forms.CheckBox();
            this.chkButtonRight = new System.Windows.Forms.CheckBox();
            this.chkButtonP1 = new System.Windows.Forms.CheckBox();
            this.chkButtonP2 = new System.Windows.Forms.CheckBox();
            this.chkButtonP3 = new System.Windows.Forms.CheckBox();
            this.chkButtonP4 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(35, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open Joystick";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Capturecmd
            // 
            this.Capturecmd.BackColor = System.Drawing.Color.Red;
            this.Capturecmd.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.Capturecmd.FlatAppearance.BorderSize = 0;
            this.Capturecmd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Capturecmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Capturecmd.ForeColor = System.Drawing.Color.Lime;
            this.Capturecmd.Location = new System.Drawing.Point(239, 42);
            this.Capturecmd.Name = "Capturecmd";
            this.Capturecmd.Size = new System.Drawing.Size(191, 60);
            this.Capturecmd.TabIndex = 2;
            this.Capturecmd.Text = "Start Capture";
            this.Capturecmd.UseVisualStyleBackColor = false;
            this.Capturecmd.Click += new System.EventHandler(this.button2_Click);
            // 
            // prgY1
            // 
            this.prgY1.Location = new System.Drawing.Point(35, 458);
            this.prgY1.Maximum = 31767;
            this.prgY1.Name = "prgY1";
            this.prgY1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.prgY1.RightToLeftLayout = true;
            this.prgY1.Size = new System.Drawing.Size(362, 55);
            this.prgY1.TabIndex = 3;
            // 
            // prgY2
            // 
            this.prgY2.Location = new System.Drawing.Point(403, 458);
            this.prgY2.Maximum = 65535;
            this.prgY2.Minimum = 33767;
            this.prgY2.Name = "prgY2";
            this.prgY2.Size = new System.Drawing.Size(362, 55);
            this.prgY2.TabIndex = 4;
            this.prgY2.Value = 33767;
            // 
            // prgX1
            // 
            this.prgX1.Location = new System.Drawing.Point(35, 331);
            this.prgX1.MarqueeAnimationSpeed = 1;
            this.prgX1.Maximum = 31767;
            this.prgX1.Name = "prgX1";
            this.prgX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.prgX1.RightToLeftLayout = true;
            this.prgX1.Size = new System.Drawing.Size(362, 58);
            this.prgX1.Step = 1;
            this.prgX1.TabIndex = 5;
            // 
            // prgX2
            // 
            this.prgX2.Location = new System.Drawing.Point(403, 331);
            this.prgX2.Maximum = 65535;
            this.prgX2.Minimum = 33767;
            this.prgX2.Name = "prgX2";
            this.prgX2.Size = new System.Drawing.Size(362, 58);
            this.prgX2.Step = 1;
            this.prgX2.TabIndex = 6;
            this.prgX2.Value = 33767;
            // 
            // prgZ
            // 
            this.prgZ.Location = new System.Drawing.Point(35, 577);
            this.prgZ.MarqueeAnimationSpeed = 1;
            this.prgZ.Maximum = 65535;
            this.prgZ.Name = "prgZ";
            this.prgZ.Size = new System.Drawing.Size(730, 58);
            this.prgZ.Step = 1;
            this.prgZ.TabIndex = 8;
            // 
            // chkTrigger
            // 
            this.chkTrigger.AutoSize = true;
            this.chkTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTrigger.ForeColor = System.Drawing.Color.Red;
            this.chkTrigger.Location = new System.Drawing.Point(35, 134);
            this.chkTrigger.Name = "chkTrigger";
            this.chkTrigger.Size = new System.Drawing.Size(97, 28);
            this.chkTrigger.TabIndex = 9;
            this.chkTrigger.Text = "Trigger";
            this.chkTrigger.UseVisualStyleBackColor = true;
            // 
            // chkButton2
            // 
            this.chkButton2.AutoSize = true;
            this.chkButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkButton2.ForeColor = System.Drawing.Color.Red;
            this.chkButton2.Location = new System.Drawing.Point(35, 178);
            this.chkButton2.Name = "chkButton2";
            this.chkButton2.Size = new System.Drawing.Size(105, 28);
            this.chkButton2.TabIndex = 10;
            this.chkButton2.Text = "Button 2";
            this.chkButton2.UseVisualStyleBackColor = true;
            // 
            // chkButton3
            // 
            this.chkButton3.AutoSize = true;
            this.chkButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkButton3.ForeColor = System.Drawing.Color.Red;
            this.chkButton3.Location = new System.Drawing.Point(35, 223);
            this.chkButton3.Name = "chkButton3";
            this.chkButton3.Size = new System.Drawing.Size(105, 28);
            this.chkButton3.TabIndex = 11;
            this.chkButton3.Text = "Button 3";
            this.chkButton3.UseVisualStyleBackColor = true;
            // 
            // chkButton4
            // 
            this.chkButton4.AutoSize = true;
            this.chkButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkButton4.ForeColor = System.Drawing.Color.Red;
            this.chkButton4.Location = new System.Drawing.Point(221, 134);
            this.chkButton4.Name = "chkButton4";
            this.chkButton4.Size = new System.Drawing.Size(105, 28);
            this.chkButton4.TabIndex = 12;
            this.chkButton4.Text = "Button 4";
            this.chkButton4.UseVisualStyleBackColor = true;
            // 
            // chkButton5
            // 
            this.chkButton5.AutoSize = true;
            this.chkButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkButton5.ForeColor = System.Drawing.Color.Red;
            this.chkButton5.Location = new System.Drawing.Point(221, 178);
            this.chkButton5.Name = "chkButton5";
            this.chkButton5.Size = new System.Drawing.Size(105, 28);
            this.chkButton5.TabIndex = 13;
            this.chkButton5.Text = "Button 5";
            this.chkButton5.UseVisualStyleBackColor = true;
            // 
            // chkButton6
            // 
            this.chkButton6.AutoSize = true;
            this.chkButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkButton6.ForeColor = System.Drawing.Color.Red;
            this.chkButton6.Location = new System.Drawing.Point(221, 223);
            this.chkButton6.Name = "chkButton6";
            this.chkButton6.Size = new System.Drawing.Size(105, 28);
            this.chkButton6.TabIndex = 14;
            this.chkButton6.Text = "Button 6";
            this.chkButton6.UseVisualStyleBackColor = true;
            // 
            // chkButtonLeft
            // 
            this.chkButtonLeft.AutoSize = true;
            this.chkButtonLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkButtonLeft.ForeColor = System.Drawing.Color.Red;
            this.chkButtonLeft.Location = new System.Drawing.Point(433, 134);
            this.chkButtonLeft.Name = "chkButtonLeft";
            this.chkButtonLeft.Size = new System.Drawing.Size(123, 28);
            this.chkButtonLeft.TabIndex = 15;
            this.chkButtonLeft.Text = "Left Arrow";
            this.chkButtonLeft.UseVisualStyleBackColor = true;
            // 
            // chkButtonRight
            // 
            this.chkButtonRight.AutoSize = true;
            this.chkButtonRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkButtonRight.ForeColor = System.Drawing.Color.Red;
            this.chkButtonRight.Location = new System.Drawing.Point(433, 178);
            this.chkButtonRight.Name = "chkButtonRight";
            this.chkButtonRight.Size = new System.Drawing.Size(138, 28);
            this.chkButtonRight.TabIndex = 16;
            this.chkButtonRight.Text = "Right Arrow";
            this.chkButtonRight.UseVisualStyleBackColor = true;
            // 
            // chkButtonP1
            // 
            this.chkButtonP1.AutoSize = true;
            this.chkButtonP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkButtonP1.ForeColor = System.Drawing.Color.Red;
            this.chkButtonP1.Location = new System.Drawing.Point(433, 223);
            this.chkButtonP1.Name = "chkButtonP1";
            this.chkButtonP1.Size = new System.Drawing.Size(118, 28);
            this.chkButtonP1.TabIndex = 17;
            this.chkButtonP1.Text = "Button P1";
            this.chkButtonP1.UseVisualStyleBackColor = true;
            // 
            // chkButtonP2
            // 
            this.chkButtonP2.AutoSize = true;
            this.chkButtonP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkButtonP2.ForeColor = System.Drawing.Color.Red;
            this.chkButtonP2.Location = new System.Drawing.Point(622, 134);
            this.chkButtonP2.Name = "chkButtonP2";
            this.chkButtonP2.Size = new System.Drawing.Size(118, 28);
            this.chkButtonP2.TabIndex = 18;
            this.chkButtonP2.Text = "Button P2";
            this.chkButtonP2.UseVisualStyleBackColor = true;
            // 
            // chkButtonP3
            // 
            this.chkButtonP3.AutoSize = true;
            this.chkButtonP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkButtonP3.ForeColor = System.Drawing.Color.Red;
            this.chkButtonP3.Location = new System.Drawing.Point(622, 178);
            this.chkButtonP3.Name = "chkButtonP3";
            this.chkButtonP3.Size = new System.Drawing.Size(118, 28);
            this.chkButtonP3.TabIndex = 19;
            this.chkButtonP3.Text = "Button P3";
            this.chkButtonP3.UseVisualStyleBackColor = true;
            // 
            // chkButtonP4
            // 
            this.chkButtonP4.AutoSize = true;
            this.chkButtonP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkButtonP4.ForeColor = System.Drawing.Color.Red;
            this.chkButtonP4.Location = new System.Drawing.Point(622, 223);
            this.chkButtonP4.Name = "chkButtonP4";
            this.chkButtonP4.Size = new System.Drawing.Size(118, 28);
            this.chkButtonP4.TabIndex = 20;
            this.chkButtonP4.Text = "Button P4";
            this.chkButtonP4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(343, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "X-Axis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(343, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 37);
            this.label2.TabIndex = 22;
            this.label2.Text = "Y-Axis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(343, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 37);
            this.label3.TabIndex = 23;
            this.label3.Text = "Z-Axis";
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1460, 682);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkButtonP4);
            this.Controls.Add(this.chkButtonP3);
            this.Controls.Add(this.chkButtonP2);
            this.Controls.Add(this.chkButtonP1);
            this.Controls.Add(this.chkButtonRight);
            this.Controls.Add(this.chkButtonLeft);
            this.Controls.Add(this.chkButton6);
            this.Controls.Add(this.chkButton5);
            this.Controls.Add(this.chkButton4);
            this.Controls.Add(this.chkButton3);
            this.Controls.Add(this.chkButton2);
            this.Controls.Add(this.chkTrigger);
            this.Controls.Add(this.prgZ);
            this.Controls.Add(this.prgX2);
            this.Controls.Add(this.prgX1);
            this.Controls.Add(this.prgY2);
            this.Controls.Add(this.prgY1);
            this.Controls.Add(this.Capturecmd);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Joystick Tester";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Capturecmd;
        private System.Windows.Forms.ProgressBar prgY1;
        private System.Windows.Forms.ProgressBar prgY2;
        private System.Windows.Forms.ProgressBar prgX1;
        private System.Windows.Forms.ProgressBar prgX2;
        private System.Windows.Forms.ProgressBar prgZ;
        private System.Windows.Forms.CheckBox chkTrigger;
        private System.Windows.Forms.CheckBox chkButton2;
        private System.Windows.Forms.CheckBox chkButton3;
        private System.Windows.Forms.CheckBox chkButton4;
        private System.Windows.Forms.CheckBox chkButton5;
        private System.Windows.Forms.CheckBox chkButton6;
        private System.Windows.Forms.CheckBox chkButtonLeft;
        private System.Windows.Forms.CheckBox chkButtonRight;
        private System.Windows.Forms.CheckBox chkButtonP1;
        private System.Windows.Forms.CheckBox chkButtonP2;
        private System.Windows.Forms.CheckBox chkButtonP3;
        private System.Windows.Forms.CheckBox chkButtonP4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

