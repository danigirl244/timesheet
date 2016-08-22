namespace TimeSheetWinforms
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Date1Label = new System.Windows.Forms.Label();
            this.Date2Label = new System.Windows.Forms.Label();
            this.Date3Label = new System.Windows.Forms.Label();
            this.Date4Label = new System.Windows.Forms.Label();
            this.Date5Label = new System.Windows.Forms.Label();
            this.Date6Label = new System.Windows.Forms.Label();
            this.Date7Label = new System.Windows.Forms.Label();
            this.Reg1 = new System.Windows.Forms.TextBox();
            this.Reg2 = new System.Windows.Forms.TextBox();
            this.Reg3 = new System.Windows.Forms.TextBox();
            this.Reg4 = new System.Windows.Forms.TextBox();
            this.Reg5 = new System.Windows.Forms.TextBox();
            this.Reg6 = new System.Windows.Forms.TextBox();
            this.Reg7 = new System.Windows.Forms.TextBox();
            this.Sick1 = new System.Windows.Forms.TextBox();
            this.Sick2 = new System.Windows.Forms.TextBox();
            this.Sick3 = new System.Windows.Forms.TextBox();
            this.Sick4 = new System.Windows.Forms.TextBox();
            this.Sick5 = new System.Windows.Forms.TextBox();
            this.Sick6 = new System.Windows.Forms.TextBox();
            this.Sick7 = new System.Windows.Forms.TextBox();
            this.Vac1 = new System.Windows.Forms.TextBox();
            this.Vac2 = new System.Windows.Forms.TextBox();
            this.Vac3 = new System.Windows.Forms.TextBox();
            this.Vac4 = new System.Windows.Forms.TextBox();
            this.Vac5 = new System.Windows.Forms.TextBox();
            this.Vac6 = new System.Windows.Forms.TextBox();
            this.Vac7 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Date: 7/3/2016";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.radioButton1.Location = new System.Drawing.Point(503, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 23);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Week One";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.radioButton2.Location = new System.Drawing.Point(616, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(100, 23);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Week Two";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(13, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Regular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(13, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sick";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.label4.Location = new System.Drawing.Point(11, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vacation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.label5.Location = new System.Drawing.Point(90, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sun";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.label6.Location = new System.Drawing.Point(174, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.label7.Location = new System.Drawing.Point(276, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tue";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.label8.Location = new System.Drawing.Point(369, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Wed";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.label9.Location = new System.Drawing.Point(460, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Thur";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.label10.Location = new System.Drawing.Point(558, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Fri";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.label11.Location = new System.Drawing.Point(636, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Sat";
            // 
            // Date1Label
            // 
            this.Date1Label.AutoSize = true;
            this.Date1Label.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.Date1Label.Location = new System.Drawing.Point(76, 97);
            this.Date1Label.Name = "Date1Label";
            this.Date1Label.Size = new System.Drawing.Size(69, 19);
            this.Date1Label.TabIndex = 13;
            this.Date1Label.Text = "7/3/2016";
            // 
            // Date2Label
            // 
            this.Date2Label.AutoSize = true;
            this.Date2Label.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.Date2Label.Location = new System.Drawing.Point(160, 97);
            this.Date2Label.Name = "Date2Label";
            this.Date2Label.Size = new System.Drawing.Size(69, 19);
            this.Date2Label.TabIndex = 14;
            this.Date2Label.Text = "7/4/2016";
            // 
            // Date3Label
            // 
            this.Date3Label.AutoSize = true;
            this.Date3Label.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date3Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.Date3Label.Location = new System.Drawing.Point(264, 97);
            this.Date3Label.Name = "Date3Label";
            this.Date3Label.Size = new System.Drawing.Size(69, 19);
            this.Date3Label.TabIndex = 15;
            this.Date3Label.Text = "7/5/2016";
            // 
            // Date4Label
            // 
            this.Date4Label.AutoSize = true;
            this.Date4Label.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date4Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.Date4Label.Location = new System.Drawing.Point(358, 97);
            this.Date4Label.Name = "Date4Label";
            this.Date4Label.Size = new System.Drawing.Size(69, 19);
            this.Date4Label.TabIndex = 16;
            this.Date4Label.Text = "7/6/2016";
            // 
            // Date5Label
            // 
            this.Date5Label.AutoSize = true;
            this.Date5Label.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date5Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.Date5Label.Location = new System.Drawing.Point(448, 97);
            this.Date5Label.Name = "Date5Label";
            this.Date5Label.Size = new System.Drawing.Size(69, 19);
            this.Date5Label.TabIndex = 17;
            this.Date5Label.Text = "7/7/2016";
            // 
            // Date6Label
            // 
            this.Date6Label.AutoSize = true;
            this.Date6Label.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date6Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.Date6Label.Location = new System.Drawing.Point(538, 97);
            this.Date6Label.Name = "Date6Label";
            this.Date6Label.Size = new System.Drawing.Size(69, 19);
            this.Date6Label.TabIndex = 18;
            this.Date6Label.Text = "7/8/2016";
            // 
            // Date7Label
            // 
            this.Date7Label.AutoSize = true;
            this.Date7Label.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date7Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.Date7Label.Location = new System.Drawing.Point(619, 97);
            this.Date7Label.Name = "Date7Label";
            this.Date7Label.Size = new System.Drawing.Size(69, 19);
            this.Date7Label.TabIndex = 19;
            this.Date7Label.Text = "7/9/2016";
            // 
            // Reg1
            // 
            this.Reg1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Reg1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Reg1.Location = new System.Drawing.Point(94, 136);
            this.Reg1.Name = "Reg1";
            this.Reg1.Size = new System.Drawing.Size(29, 22);
            this.Reg1.TabIndex = 20;
            this.Reg1.Text = "0";
            // 
            // Reg2
            // 
            this.Reg2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Reg2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Reg2.Location = new System.Drawing.Point(178, 136);
            this.Reg2.Name = "Reg2";
            this.Reg2.Size = new System.Drawing.Size(29, 22);
            this.Reg2.TabIndex = 21;
            this.Reg2.Text = "0";
            // 
            // Reg3
            // 
            this.Reg3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Reg3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Reg3.Location = new System.Drawing.Point(280, 136);
            this.Reg3.Name = "Reg3";
            this.Reg3.Size = new System.Drawing.Size(29, 22);
            this.Reg3.TabIndex = 22;
            this.Reg3.Text = "0";
            // 
            // Reg4
            // 
            this.Reg4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Reg4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Reg4.Location = new System.Drawing.Point(373, 136);
            this.Reg4.Name = "Reg4";
            this.Reg4.Size = new System.Drawing.Size(29, 22);
            this.Reg4.TabIndex = 23;
            this.Reg4.Text = "0";
            // 
            // Reg5
            // 
            this.Reg5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Reg5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Reg5.Location = new System.Drawing.Point(464, 136);
            this.Reg5.Name = "Reg5";
            this.Reg5.Size = new System.Drawing.Size(29, 22);
            this.Reg5.TabIndex = 24;
            this.Reg5.Text = "0";
            // 
            // Reg6
            // 
            this.Reg6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Reg6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Reg6.Location = new System.Drawing.Point(552, 136);
            this.Reg6.Name = "Reg6";
            this.Reg6.Size = new System.Drawing.Size(29, 22);
            this.Reg6.TabIndex = 25;
            this.Reg6.Text = "0";
            // 
            // Reg7
            // 
            this.Reg7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Reg7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Reg7.Location = new System.Drawing.Point(638, 136);
            this.Reg7.Name = "Reg7";
            this.Reg7.Size = new System.Drawing.Size(29, 22);
            this.Reg7.TabIndex = 26;
            this.Reg7.Text = "0";
            // 
            // Sick1
            // 
            this.Sick1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Sick1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Sick1.Location = new System.Drawing.Point(94, 194);
            this.Sick1.Name = "Sick1";
            this.Sick1.Size = new System.Drawing.Size(29, 22);
            this.Sick1.TabIndex = 27;
            this.Sick1.Text = "0";
            // 
            // Sick2
            // 
            this.Sick2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Sick2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Sick2.Location = new System.Drawing.Point(178, 194);
            this.Sick2.Name = "Sick2";
            this.Sick2.Size = new System.Drawing.Size(29, 22);
            this.Sick2.TabIndex = 28;
            this.Sick2.Text = "0";
            // 
            // Sick3
            // 
            this.Sick3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Sick3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Sick3.Location = new System.Drawing.Point(280, 194);
            this.Sick3.Name = "Sick3";
            this.Sick3.Size = new System.Drawing.Size(29, 22);
            this.Sick3.TabIndex = 29;
            this.Sick3.Text = "0";
            // 
            // Sick4
            // 
            this.Sick4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Sick4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Sick4.Location = new System.Drawing.Point(373, 194);
            this.Sick4.Name = "Sick4";
            this.Sick4.Size = new System.Drawing.Size(29, 22);
            this.Sick4.TabIndex = 30;
            this.Sick4.Text = "0";
            // 
            // Sick5
            // 
            this.Sick5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Sick5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Sick5.Location = new System.Drawing.Point(464, 194);
            this.Sick5.Name = "Sick5";
            this.Sick5.Size = new System.Drawing.Size(29, 22);
            this.Sick5.TabIndex = 31;
            this.Sick5.Text = "0";
            // 
            // Sick6
            // 
            this.Sick6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Sick6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Sick6.Location = new System.Drawing.Point(552, 194);
            this.Sick6.Name = "Sick6";
            this.Sick6.Size = new System.Drawing.Size(29, 22);
            this.Sick6.TabIndex = 32;
            this.Sick6.Text = "0";
            // 
            // Sick7
            // 
            this.Sick7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Sick7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Sick7.Location = new System.Drawing.Point(638, 194);
            this.Sick7.Name = "Sick7";
            this.Sick7.Size = new System.Drawing.Size(29, 22);
            this.Sick7.TabIndex = 33;
            this.Sick7.Text = "0";
            // 
            // Vac1
            // 
            this.Vac1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Vac1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Vac1.Location = new System.Drawing.Point(94, 246);
            this.Vac1.Name = "Vac1";
            this.Vac1.Size = new System.Drawing.Size(29, 22);
            this.Vac1.TabIndex = 34;
            this.Vac1.Text = "0";
            // 
            // Vac2
            // 
            this.Vac2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Vac2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Vac2.Location = new System.Drawing.Point(178, 246);
            this.Vac2.Name = "Vac2";
            this.Vac2.Size = new System.Drawing.Size(29, 22);
            this.Vac2.TabIndex = 35;
            this.Vac2.Text = "0";
            // 
            // Vac3
            // 
            this.Vac3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Vac3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Vac3.Location = new System.Drawing.Point(280, 246);
            this.Vac3.Name = "Vac3";
            this.Vac3.Size = new System.Drawing.Size(29, 22);
            this.Vac3.TabIndex = 36;
            this.Vac3.Text = "0";
            // 
            // Vac4
            // 
            this.Vac4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Vac4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Vac4.Location = new System.Drawing.Point(373, 246);
            this.Vac4.Name = "Vac4";
            this.Vac4.Size = new System.Drawing.Size(29, 22);
            this.Vac4.TabIndex = 37;
            this.Vac4.Text = "0";
            // 
            // Vac5
            // 
            this.Vac5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Vac5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Vac5.Location = new System.Drawing.Point(464, 246);
            this.Vac5.Name = "Vac5";
            this.Vac5.Size = new System.Drawing.Size(29, 22);
            this.Vac5.TabIndex = 38;
            this.Vac5.Text = "0";
            // 
            // Vac6
            // 
            this.Vac6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Vac6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Vac6.Location = new System.Drawing.Point(552, 246);
            this.Vac6.Name = "Vac6";
            this.Vac6.Size = new System.Drawing.Size(29, 22);
            this.Vac6.TabIndex = 39;
            this.Vac6.Text = "0";
            // 
            // Vac7
            // 
            this.Vac7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Vac7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Vac7.Location = new System.Drawing.Point(638, 246);
            this.Vac7.Name = "Vac7";
            this.Vac7.Size = new System.Drawing.Size(29, 22);
            this.Vac7.TabIndex = 40;
            this.Vac7.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.label19.Location = new System.Drawing.Point(12, 300);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 19);
            this.label19.TabIndex = 41;
            this.label19.Text = "Reg. Total: ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.label20.Location = new System.Drawing.Point(12, 319);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 19);
            this.label20.TabIndex = 42;
            this.label20.Text = "Sick Total: ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.label21.Location = new System.Drawing.Point(12, 336);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 19);
            this.label21.TabIndex = 43;
            this.label21.Text = "Vac. Total: ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.label22.Location = new System.Drawing.Point(44, 355);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 19);
            this.label22.TabIndex = 44;
            this.label22.Text = "Overtime: ";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(503, 329);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(175, 31);
            this.SaveButton.TabIndex = 45;
            this.SaveButton.Text = "Save Hours";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(90, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 19);
            this.label12.TabIndex = 46;
            this.label12.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(90, 319);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 19);
            this.label13.TabIndex = 47;
            this.label13.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(90, 336);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 19);
            this.label14.TabIndex = 48;
            this.label14.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(118, 355);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 19);
            this.label15.TabIndex = 49;
            this.label15.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(736, 388);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.Vac7);
            this.Controls.Add(this.Vac6);
            this.Controls.Add(this.Vac5);
            this.Controls.Add(this.Vac4);
            this.Controls.Add(this.Vac3);
            this.Controls.Add(this.Vac2);
            this.Controls.Add(this.Vac1);
            this.Controls.Add(this.Sick7);
            this.Controls.Add(this.Sick6);
            this.Controls.Add(this.Sick5);
            this.Controls.Add(this.Sick4);
            this.Controls.Add(this.Sick3);
            this.Controls.Add(this.Sick2);
            this.Controls.Add(this.Sick1);
            this.Controls.Add(this.Reg7);
            this.Controls.Add(this.Reg6);
            this.Controls.Add(this.Reg5);
            this.Controls.Add(this.Reg4);
            this.Controls.Add(this.Reg3);
            this.Controls.Add(this.Reg2);
            this.Controls.Add(this.Reg1);
            this.Controls.Add(this.Date7Label);
            this.Controls.Add(this.Date6Label);
            this.Controls.Add(this.Date5Label);
            this.Controls.Add(this.Date4Label);
            this.Controls.Add(this.Date3Label);
            this.Controls.Add(this.Date2Label);
            this.Controls.Add(this.Date1Label);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Time Sheet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Date1Label;
        private System.Windows.Forms.Label Date2Label;
        private System.Windows.Forms.Label Date3Label;
        private System.Windows.Forms.Label Date4Label;
        private System.Windows.Forms.Label Date5Label;
        private System.Windows.Forms.Label Date6Label;
        private System.Windows.Forms.Label Date7Label;
        private System.Windows.Forms.TextBox Reg1;
        private System.Windows.Forms.TextBox Reg2;
        private System.Windows.Forms.TextBox Reg3;
        private System.Windows.Forms.TextBox Reg4;
        private System.Windows.Forms.TextBox Reg5;
        private System.Windows.Forms.TextBox Reg6;
        private System.Windows.Forms.TextBox Reg7;
        private System.Windows.Forms.TextBox Sick1;
        private System.Windows.Forms.TextBox Sick2;
        private System.Windows.Forms.TextBox Sick3;
        private System.Windows.Forms.TextBox Sick4;
        private System.Windows.Forms.TextBox Sick5;
        private System.Windows.Forms.TextBox Sick6;
        private System.Windows.Forms.TextBox Sick7;
        private System.Windows.Forms.TextBox Vac1;
        private System.Windows.Forms.TextBox Vac2;
        private System.Windows.Forms.TextBox Vac3;
        private System.Windows.Forms.TextBox Vac4;
        private System.Windows.Forms.TextBox Vac5;
        private System.Windows.Forms.TextBox Vac6;
        private System.Windows.Forms.TextBox Vac7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

