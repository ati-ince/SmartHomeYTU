﻿namespace SmartHomeFrameworkV2._1
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
            this.Connect_RemoteCOMM = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Disconnect_RemoteCOMM = new System.Windows.Forms.Button();
            this.ComboBox__RemoteCOMM = new System.Windows.Forms.ComboBox();
            this.Connect_ModBus4Noks = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Disconnect_ModBus4Noks = new System.Windows.Forms.Button();
            this.ComboBox_Modbus4Noks = new System.Windows.Forms.ComboBox();
            this.Connect_Xtender = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Disconnect_Xtender = new System.Windows.Forms.Button();
            this.ComboBox_Xtender = new System.Windows.Forms.ComboBox();
            this.Connect_Ammonit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Disconnect_Ammonit = new System.Windows.Forms.Button();
            this.Start_Algorithm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Stop_Algorithm = new System.Windows.Forms.Button();
            this.TextBox_AmmonitTest = new System.Windows.Forms.TextBox();
            this.TimerAlgorithm = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Connect_RemoteCOMM
            // 
            this.Connect_RemoteCOMM.BackColor = System.Drawing.Color.SeaGreen;
            this.Connect_RemoteCOMM.Location = new System.Drawing.Point(9, 148);
            this.Connect_RemoteCOMM.Name = "Connect_RemoteCOMM";
            this.Connect_RemoteCOMM.Size = new System.Drawing.Size(75, 23);
            this.Connect_RemoteCOMM.TabIndex = 45;
            this.Connect_RemoteCOMM.Text = "Connect";
            this.Connect_RemoteCOMM.UseVisualStyleBackColor = false;
            this.Connect_RemoteCOMM.Click += new System.EventHandler(this.Connect_RemoteCOMM_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "RemoteCOMM";
            // 
            // Disconnect_RemoteCOMM
            // 
            this.Disconnect_RemoteCOMM.BackColor = System.Drawing.Color.Red;
            this.Disconnect_RemoteCOMM.Location = new System.Drawing.Point(102, 148);
            this.Disconnect_RemoteCOMM.Name = "Disconnect_RemoteCOMM";
            this.Disconnect_RemoteCOMM.Size = new System.Drawing.Size(75, 23);
            this.Disconnect_RemoteCOMM.TabIndex = 46;
            this.Disconnect_RemoteCOMM.Text = "Disconnect";
            this.Disconnect_RemoteCOMM.UseVisualStyleBackColor = false;
            this.Disconnect_RemoteCOMM.Click += new System.EventHandler(this.Disconnect_RemoteCOMM_Click);
            // 
            // ComboBox__RemoteCOMM
            // 
            this.ComboBox__RemoteCOMM.BackColor = System.Drawing.Color.Ivory;
            this.ComboBox__RemoteCOMM.FormattingEnabled = true;
            this.ComboBox__RemoteCOMM.Location = new System.Drawing.Point(9, 122);
            this.ComboBox__RemoteCOMM.Name = "ComboBox__RemoteCOMM";
            this.ComboBox__RemoteCOMM.Size = new System.Drawing.Size(84, 21);
            this.ComboBox__RemoteCOMM.TabIndex = 44;
            // 
            // Connect_ModBus4Noks
            // 
            this.Connect_ModBus4Noks.BackColor = System.Drawing.Color.SeaGreen;
            this.Connect_ModBus4Noks.Location = new System.Drawing.Point(9, 92);
            this.Connect_ModBus4Noks.Name = "Connect_ModBus4Noks";
            this.Connect_ModBus4Noks.Size = new System.Drawing.Size(75, 23);
            this.Connect_ModBus4Noks.TabIndex = 41;
            this.Connect_ModBus4Noks.Text = "Connect";
            this.Connect_ModBus4Noks.UseVisualStyleBackColor = false;
            this.Connect_ModBus4Noks.Click += new System.EventHandler(this.Connect_ModBus4Noks_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "4Noks";
            // 
            // Disconnect_ModBus4Noks
            // 
            this.Disconnect_ModBus4Noks.BackColor = System.Drawing.Color.Red;
            this.Disconnect_ModBus4Noks.Location = new System.Drawing.Point(102, 92);
            this.Disconnect_ModBus4Noks.Name = "Disconnect_ModBus4Noks";
            this.Disconnect_ModBus4Noks.Size = new System.Drawing.Size(75, 23);
            this.Disconnect_ModBus4Noks.TabIndex = 42;
            this.Disconnect_ModBus4Noks.Text = "Disconnect";
            this.Disconnect_ModBus4Noks.UseVisualStyleBackColor = false;
            this.Disconnect_ModBus4Noks.Click += new System.EventHandler(this.Disconnect_ModBus4Noks_Click);
            // 
            // ComboBox_Modbus4Noks
            // 
            this.ComboBox_Modbus4Noks.BackColor = System.Drawing.Color.Ivory;
            this.ComboBox_Modbus4Noks.FormattingEnabled = true;
            this.ComboBox_Modbus4Noks.Location = new System.Drawing.Point(9, 66);
            this.ComboBox_Modbus4Noks.Name = "ComboBox_Modbus4Noks";
            this.ComboBox_Modbus4Noks.Size = new System.Drawing.Size(84, 21);
            this.ComboBox_Modbus4Noks.TabIndex = 40;
            // 
            // Connect_Xtender
            // 
            this.Connect_Xtender.BackColor = System.Drawing.Color.SeaGreen;
            this.Connect_Xtender.Location = new System.Drawing.Point(9, 36);
            this.Connect_Xtender.Name = "Connect_Xtender";
            this.Connect_Xtender.Size = new System.Drawing.Size(75, 23);
            this.Connect_Xtender.TabIndex = 37;
            this.Connect_Xtender.Text = "Connect";
            this.Connect_Xtender.UseVisualStyleBackColor = false;
            this.Connect_Xtender.Click += new System.EventHandler(this.Connect_Xtender_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Xtender";
            // 
            // Disconnect_Xtender
            // 
            this.Disconnect_Xtender.BackColor = System.Drawing.Color.Red;
            this.Disconnect_Xtender.Location = new System.Drawing.Point(102, 36);
            this.Disconnect_Xtender.Name = "Disconnect_Xtender";
            this.Disconnect_Xtender.Size = new System.Drawing.Size(75, 23);
            this.Disconnect_Xtender.TabIndex = 38;
            this.Disconnect_Xtender.Text = "Disconnect";
            this.Disconnect_Xtender.UseVisualStyleBackColor = false;
            this.Disconnect_Xtender.Click += new System.EventHandler(this.Disconnect_Xtender_Click);
            // 
            // ComboBox_Xtender
            // 
            this.ComboBox_Xtender.BackColor = System.Drawing.Color.Ivory;
            this.ComboBox_Xtender.FormattingEnabled = true;
            this.ComboBox_Xtender.Location = new System.Drawing.Point(9, 9);
            this.ComboBox_Xtender.Name = "ComboBox_Xtender";
            this.ComboBox_Xtender.Size = new System.Drawing.Size(84, 21);
            this.ComboBox_Xtender.TabIndex = 36;
            // 
            // Connect_Ammonit
            // 
            this.Connect_Ammonit.BackColor = System.Drawing.Color.SeaGreen;
            this.Connect_Ammonit.Location = new System.Drawing.Point(9, 202);
            this.Connect_Ammonit.Name = "Connect_Ammonit";
            this.Connect_Ammonit.Size = new System.Drawing.Size(75, 23);
            this.Connect_Ammonit.TabIndex = 48;
            this.Connect_Ammonit.Text = "Connect";
            this.Connect_Ammonit.UseVisualStyleBackColor = false;
            this.Connect_Ammonit.Click += new System.EventHandler(this.Connect_Ammonit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Ammonit";
            // 
            // Disconnect_Ammonit
            // 
            this.Disconnect_Ammonit.BackColor = System.Drawing.Color.Red;
            this.Disconnect_Ammonit.Location = new System.Drawing.Point(102, 202);
            this.Disconnect_Ammonit.Name = "Disconnect_Ammonit";
            this.Disconnect_Ammonit.Size = new System.Drawing.Size(75, 23);
            this.Disconnect_Ammonit.TabIndex = 49;
            this.Disconnect_Ammonit.Text = "Disconnect";
            this.Disconnect_Ammonit.UseVisualStyleBackColor = false;
            this.Disconnect_Ammonit.Click += new System.EventHandler(this.Disconnect_Ammonit_Click);
            // 
            // Start_Algorithm
            // 
            this.Start_Algorithm.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Start_Algorithm.Location = new System.Drawing.Point(9, 255);
            this.Start_Algorithm.Name = "Start_Algorithm";
            this.Start_Algorithm.Size = new System.Drawing.Size(75, 23);
            this.Start_Algorithm.TabIndex = 51;
            this.Start_Algorithm.Text = "Start";
            this.Start_Algorithm.UseVisualStyleBackColor = false;
            this.Start_Algorithm.Click += new System.EventHandler(this.Start_Algorithm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Algorithm";
            // 
            // Stop_Algorithm
            // 
            this.Stop_Algorithm.BackColor = System.Drawing.Color.LightPink;
            this.Stop_Algorithm.Location = new System.Drawing.Point(102, 255);
            this.Stop_Algorithm.Name = "Stop_Algorithm";
            this.Stop_Algorithm.Size = new System.Drawing.Size(75, 23);
            this.Stop_Algorithm.TabIndex = 52;
            this.Stop_Algorithm.Text = "Stop";
            this.Stop_Algorithm.UseVisualStyleBackColor = false;
            this.Stop_Algorithm.Click += new System.EventHandler(this.Stop_Algorithm_Click);
            // 
            // TextBox_AmmonitTest
            // 
            this.TextBox_AmmonitTest.Location = new System.Drawing.Point(251, 205);
            this.TextBox_AmmonitTest.Name = "TextBox_AmmonitTest";
            this.TextBox_AmmonitTest.Size = new System.Drawing.Size(100, 20);
            this.TextBox_AmmonitTest.TabIndex = 54;
            // 
            // TimerAlgorithm
            // 
            this.TimerAlgorithm.Interval = 1000;
            this.TimerAlgorithm.Tick += new System.EventHandler(this.TimerAlgorithm_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 294);
            this.Controls.Add(this.TextBox_AmmonitTest);
            this.Controls.Add(this.Start_Algorithm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Stop_Algorithm);
            this.Controls.Add(this.Connect_Ammonit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Disconnect_Ammonit);
            this.Controls.Add(this.Connect_RemoteCOMM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Disconnect_RemoteCOMM);
            this.Controls.Add(this.ComboBox__RemoteCOMM);
            this.Controls.Add(this.Connect_ModBus4Noks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Disconnect_ModBus4Noks);
            this.Controls.Add(this.ComboBox_Modbus4Noks);
            this.Controls.Add(this.Connect_Xtender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Disconnect_Xtender);
            this.Controls.Add(this.ComboBox_Xtender);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "ShFramework";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect_RemoteCOMM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Disconnect_RemoteCOMM;
        private System.Windows.Forms.ComboBox ComboBox__RemoteCOMM;
        private System.Windows.Forms.Button Connect_ModBus4Noks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Disconnect_ModBus4Noks;
        private System.Windows.Forms.ComboBox ComboBox_Modbus4Noks;
        private System.Windows.Forms.Button Connect_Xtender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Disconnect_Xtender;
        private System.Windows.Forms.ComboBox ComboBox_Xtender;
        private System.Windows.Forms.Button Connect_Ammonit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Disconnect_Ammonit;
        private System.Windows.Forms.Button Start_Algorithm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Stop_Algorithm;
        private System.Windows.Forms.TextBox TextBox_AmmonitTest;
        private System.Windows.Forms.Timer TimerAlgorithm;
    }
}

