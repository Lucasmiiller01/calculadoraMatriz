﻿namespace MatrizCalculator
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Draw3 = new System.Windows.Forms.Button();
            this.Draw2 = new System.Windows.Forms.Button();
            this.Draw1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Operation = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.M3L = new System.Windows.Forms.TextBox();
            this.M3C = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.M2L = new System.Windows.Forms.NumericUpDown();
            this.M2C = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.M1L = new System.Windows.Forms.NumericUpDown();
            this.M1C = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.M2L)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M2C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M1L)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M1C)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1342, 519);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.Clear);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.Draw3);
            this.tabPage1.Controls.Add(this.Draw2);
            this.tabPage1.Controls.Add(this.Draw1);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.B);
            this.tabPage1.Controls.Add(this.A);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.Operation);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.M3L);
            this.tabPage1.Controls.Add(this.M3C);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.M2L);
            this.tabPage1.Controls.Add(this.M2C);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.M1L);
            this.tabPage1.Controls.Add(this.M1C);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1334, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Operacoes Basicas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Draw3
            // 
            this.Draw3.Location = new System.Drawing.Point(1046, 44);
            this.Draw3.Name = "Draw3";
            this.Draw3.Size = new System.Drawing.Size(44, 23);
            this.Draw3.TabIndex = 56;
            this.Draw3.Text = "Draw";
            this.Draw3.UseVisualStyleBackColor = true;
            this.Draw3.Click += new System.EventHandler(this.draw);
            // 
            // Draw2
            // 
            this.Draw2.Location = new System.Drawing.Point(582, 44);
            this.Draw2.Name = "Draw2";
            this.Draw2.Size = new System.Drawing.Size(44, 23);
            this.Draw2.TabIndex = 55;
            this.Draw2.Text = "Draw";
            this.Draw2.UseVisualStyleBackColor = true;
            this.Draw2.Click += new System.EventHandler(this.draw);
            // 
            // Draw1
            // 
            this.Draw1.Location = new System.Drawing.Point(125, 42);
            this.Draw1.Name = "Draw1";
            this.Draw1.Size = new System.Drawing.Size(44, 23);
            this.Draw1.TabIndex = 54;
            this.Draw1.Text = "Draw";
            this.Draw1.UseVisualStyleBackColor = true;
            this.Draw1.Click += new System.EventHandler(this.draw);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(535, 461);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 53;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Clear);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(563, 4);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(75, 23);
            this.B.TabIndex = 52;
            this.B.Text = "Transpor";
            this.B.UseVisualStyleBackColor = true;
            this.B.Click += new System.EventHandler(this.Transpor);
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(111, 4);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(75, 23);
            this.A.TabIndex = 51;
            this.A.Text = "Transpor";
            this.A.UseVisualStyleBackColor = true;
            this.A.Click += new System.EventHandler(this.Transpor);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(243, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Operation";
            // 
            // Operation
            // 
            this.Operation.Location = new System.Drawing.Point(256, 44);
            this.Operation.Name = "Operation";
            this.Operation.ReadOnly = true;
            this.Operation.Size = new System.Drawing.Size(20, 20);
            this.Operation.TabIndex = 49;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(753, 38);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(43, 33);
            this.button5.TabIndex = 48;
            this.button5.Text = "=";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Solution);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(174, 456);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 33);
            this.button4.TabIndex = 47;
            this.button4.Text = "Deter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ChangeOperation);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(125, 456);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 33);
            this.button3.TabIndex = 46;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ChangeOperation);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 33);
            this.button2.TabIndex = 45;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ChangeOperation);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 33);
            this.button1.TabIndex = 44;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ChangeOperation);
            // 
            // M3L
            // 
            this.M3L.Location = new System.Drawing.Point(930, 44);
            this.M3L.Name = "M3L";
            this.M3L.ReadOnly = true;
            this.M3L.Size = new System.Drawing.Size(44, 20);
            this.M3L.TabIndex = 43;
            // 
            // M3C
            // 
            this.M3C.Location = new System.Drawing.Point(996, 46);
            this.M3C.Name = "M3C";
            this.M3C.ReadOnly = true;
            this.M3C.Size = new System.Drawing.Size(44, 20);
            this.M3C.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(950, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "MATRIZ C";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(995, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Colunas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(936, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Linhas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(487, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "MATRIZ B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Colunas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(475, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Linhas";
            // 
            // M2L
            // 
            this.M2L.Location = new System.Drawing.Point(472, 45);
            this.M2L.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.M2L.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.M2L.Name = "M2L";
            this.M2L.Size = new System.Drawing.Size(41, 20);
            this.M2L.TabIndex = 35;
            this.M2L.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.M2L.ValueChanged += new System.EventHandler(this.ChangeLengthB);
            // 
            // M2C
            // 
            this.M2C.Location = new System.Drawing.Point(535, 46);
            this.M2C.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.M2C.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.M2C.Name = "M2C";
            this.M2C.Size = new System.Drawing.Size(41, 20);
            this.M2C.TabIndex = 34;
            this.M2C.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.M2C.ValueChanged += new System.EventHandler(this.ChangeLengthB);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "MATRIZ A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Colunas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Linhas";
            // 
            // M1L
            // 
            this.M1L.Location = new System.Drawing.Point(15, 46);
            this.M1L.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.M1L.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.M1L.Name = "M1L";
            this.M1L.Size = new System.Drawing.Size(41, 20);
            this.M1L.TabIndex = 30;
            this.M1L.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.M1L.ValueChanged += new System.EventHandler(this.ChangeLengthA);
            // 
            // M1C
            // 
            this.M1C.Location = new System.Drawing.Point(78, 46);
            this.M1C.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.M1C.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.M1C.Name = "M1C";
            this.M1C.Size = new System.Drawing.Size(41, 20);
            this.M1C.TabIndex = 29;
            this.M1C.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.M1C.ValueChanged += new System.EventHandler(this.ChangeLengthA);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1334, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grafico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(616, 461);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 23);
            this.button7.TabIndex = 57;
            this.button7.Text = "Draw ALL";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.draw);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 523);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.M2L)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M2C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M1L)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M1C)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Operation;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox M3L;
        private System.Windows.Forms.TextBox M3C;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown M2L;
        private System.Windows.Forms.NumericUpDown M2C;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown M1L;
        private System.Windows.Forms.NumericUpDown M1C;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Draw1;
        private System.Windows.Forms.Button Draw3;
        private System.Windows.Forms.Button Draw2;
        private System.Windows.Forms.Button button7;

    }
}

