namespace Navigation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startBtn = new System.Windows.Forms.Button();
            this.numN = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numM = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numF = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numB = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numT = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.d0Label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.d1Label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.d2Label = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.d3Label = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.d4Label = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.d5Label = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.d6Label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.d7Label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.azLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.leLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.reLabel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.cLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.tLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.l0Label = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.l1Label = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.l2Label = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.l3Label = new System.Windows.Forms.Label();
            this.l4Label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.moveBtn = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.sendBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startBtn.Location = new System.Drawing.Point(225, 12);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(165, 33);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start UDP Connection";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // numN
            // 
            this.numN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numN.ForeColor = System.Drawing.SystemColors.Control;
            this.numN.Location = new System.Drawing.Point(31, 23);
            this.numN.Name = "numN";
            this.numN.Size = new System.Drawing.Size(67, 19);
            this.numN.TabIndex = 1;
            this.numN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numN.ValueChanged += new System.EventHandler(this.Num_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "N";
            // 
            // numM
            // 
            this.numM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numM.Enabled = false;
            this.numM.ForeColor = System.Drawing.SystemColors.Control;
            this.numM.Location = new System.Drawing.Point(31, 52);
            this.numM.Name = "numM";
            this.numM.Size = new System.Drawing.Size(67, 19);
            this.numM.TabIndex = 1;
            this.numM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numM.ValueChanged += new System.EventHandler(this.Num_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "M";
            // 
            // numF
            // 
            this.numF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numF.ForeColor = System.Drawing.SystemColors.Control;
            this.numF.Location = new System.Drawing.Point(31, 81);
            this.numF.Name = "numF";
            this.numF.Size = new System.Drawing.Size(67, 19);
            this.numF.TabIndex = 1;
            this.numF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numF.ValueChanged += new System.EventHandler(this.Num_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "F";
            // 
            // numB
            // 
            this.numB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numB.ForeColor = System.Drawing.SystemColors.Control;
            this.numB.Location = new System.Drawing.Point(31, 110);
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(67, 19);
            this.numB.TabIndex = 1;
            this.numB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numB.ValueChanged += new System.EventHandler(this.Num_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "B";
            // 
            // numT
            // 
            this.numT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numT.ForeColor = System.Drawing.SystemColors.Control;
            this.numT.Location = new System.Drawing.Point(31, 139);
            this.numT.Name = "numT";
            this.numT.Size = new System.Drawing.Size(67, 19);
            this.numT.TabIndex = 1;
            this.numT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numT.ValueChanged += new System.EventHandler(this.Num_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "T";
            // 
            // resetBtn
            // 
            this.resetBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resetBtn.Location = new System.Drawing.Point(140, 47);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(20, 112);
            this.resetBtn.TabIndex = 0;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.ResetNums);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resetBtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numN);
            this.groupBox1.Controls.Add(this.sendBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numT);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 169);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "d0: ";
            // 
            // d0Label
            // 
            this.d0Label.AutoSize = true;
            this.d0Label.Location = new System.Drawing.Point(37, 24);
            this.d0Label.Name = "d0Label";
            this.d0Label.Size = new System.Drawing.Size(16, 16);
            this.d0Label.TabIndex = 2;
            this.d0Label.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "d1: ";
            // 
            // d1Label
            // 
            this.d1Label.AutoSize = true;
            this.d1Label.Location = new System.Drawing.Point(38, 42);
            this.d1Label.Name = "d1Label";
            this.d1Label.Size = new System.Drawing.Size(16, 16);
            this.d1Label.TabIndex = 2;
            this.d1Label.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "d2: ";
            // 
            // d2Label
            // 
            this.d2Label.AutoSize = true;
            this.d2Label.Location = new System.Drawing.Point(38, 60);
            this.d2Label.Name = "d2Label";
            this.d2Label.Size = new System.Drawing.Size(16, 16);
            this.d2Label.TabIndex = 2;
            this.d2Label.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "d3: ";
            // 
            // d3label
            // 
            this.d3Label.AutoSize = true;
            this.d3Label.Location = new System.Drawing.Point(38, 78);
            this.d3Label.Name = "d3Label";
            this.d3Label.Size = new System.Drawing.Size(16, 16);
            this.d3Label.TabIndex = 2;
            this.d3Label.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "d4: ";
            // 
            // d4Label
            // 
            this.d4Label.AutoSize = true;
            this.d4Label.Location = new System.Drawing.Point(38, 95);
            this.d4Label.Name = "d4Label";
            this.d4Label.Size = new System.Drawing.Size(16, 16);
            this.d4Label.TabIndex = 2;
            this.d4Label.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "d5: ";
            // 
            // d5Label
            // 
            this.d5Label.AutoSize = true;
            this.d5Label.Location = new System.Drawing.Point(38, 112);
            this.d5Label.Name = "d5Label";
            this.d5Label.Size = new System.Drawing.Size(16, 16);
            this.d5Label.TabIndex = 2;
            this.d5Label.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 130);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 16);
            this.label18.TabIndex = 2;
            this.label18.Text = "d6: ";
            // 
            // d6Label
            // 
            this.d6Label.AutoSize = true;
            this.d6Label.Location = new System.Drawing.Point(38, 130);
            this.d6Label.Name = "d6Label";
            this.d6Label.Size = new System.Drawing.Size(16, 16);
            this.d6Label.TabIndex = 2;
            this.d6Label.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "d7: ";
            // 
            // d7Label
            // 
            this.d7Label.AutoSize = true;
            this.d7Label.Location = new System.Drawing.Point(38, 148);
            this.d7Label.Name = "d7Label";
            this.d7Label.Size = new System.Drawing.Size(16, 16);
            this.d7Label.TabIndex = 2;
            this.d7Label.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "az: ";
            // 
            // azLabel
            // 
            this.azLabel.AutoSize = true;
            this.azLabel.Location = new System.Drawing.Point(109, 24);
            this.azLabel.Name = "azLabel";
            this.azLabel.Size = new System.Drawing.Size(16, 16);
            this.azLabel.TabIndex = 2;
            this.azLabel.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(80, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "le: ";
            // 
            // leLabel
            // 
            this.leLabel.AutoSize = true;
            this.leLabel.Location = new System.Drawing.Point(109, 42);
            this.leLabel.Name = "leLabel";
            this.leLabel.Size = new System.Drawing.Size(16, 16);
            this.leLabel.TabIndex = 2;
            this.leLabel.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(80, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 16);
            this.label17.TabIndex = 2;
            this.label17.Text = "re: ";
            // 
            // reLabel
            // 
            this.reLabel.AutoSize = true;
            this.reLabel.Location = new System.Drawing.Point(109, 60);
            this.reLabel.Name = "reLabel";
            this.reLabel.Size = new System.Drawing.Size(16, 16);
            this.reLabel.TabIndex = 2;
            this.reLabel.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(80, 78);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(22, 16);
            this.label20.TabIndex = 2;
            this.label20.Text = "c: ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(80, 95);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 16);
            this.label21.TabIndex = 2;
            this.label21.Text = "b: ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(80, 112);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(21, 16);
            this.label22.TabIndex = 2;
            this.label22.Text = "x: ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(80, 130);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(21, 16);
            this.label23.TabIndex = 2;
            this.label23.Text = "y: ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(80, 148);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(19, 16);
            this.label24.TabIndex = 2;
            this.label24.Text = "t: ";
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Location = new System.Drawing.Point(109, 78);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(16, 16);
            this.cLabel.TabIndex = 2;
            this.cLabel.Text = "0";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(109, 95);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(16, 16);
            this.bLabel.TabIndex = 2;
            this.bLabel.Text = "0";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(109, 112);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(16, 16);
            this.xLabel.TabIndex = 2;
            this.xLabel.Text = "0";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(109, 130);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(16, 16);
            this.yLabel.TabIndex = 2;
            this.yLabel.Text = "0";
            // 
            // tLabel
            // 
            this.tLabel.AutoSize = true;
            this.tLabel.Location = new System.Drawing.Point(109, 148);
            this.tLabel.Name = "tLabel";
            this.tLabel.Size = new System.Drawing.Size(16, 16);
            this.tLabel.TabIndex = 2;
            this.tLabel.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(145, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "l0: ";
            // 
            // l0Label
            // 
            this.l0Label.AutoSize = true;
            this.l0Label.Location = new System.Drawing.Point(169, 51);
            this.l0Label.Name = "l0Label";
            this.l0Label.Size = new System.Drawing.Size(16, 16);
            this.l0Label.TabIndex = 2;
            this.l0Label.Text = "0";
            this.l0Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(145, 68);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(22, 16);
            this.label19.TabIndex = 2;
            this.label19.Text = "l1: ";
            // 
            // l1Label
            // 
            this.l1Label.AutoSize = true;
            this.l1Label.Location = new System.Drawing.Point(169, 69);
            this.l1Label.Name = "l1Label";
            this.l1Label.Size = new System.Drawing.Size(16, 16);
            this.l1Label.TabIndex = 2;
            this.l1Label.Text = "0";
            this.l1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(145, 86);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(24, 16);
            this.label26.TabIndex = 2;
            this.label26.Text = "l2: ";
            // 
            // l2Label
            // 
            this.l2Label.AutoSize = true;
            this.l2Label.Location = new System.Drawing.Point(169, 87);
            this.l2Label.Name = "l2Label";
            this.l2Label.Size = new System.Drawing.Size(16, 16);
            this.l2Label.TabIndex = 2;
            this.l2Label.Text = "0";
            this.l2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(145, 104);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(24, 16);
            this.label28.TabIndex = 2;
            this.label28.Text = "l3: ";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(145, 121);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(25, 16);
            this.label29.TabIndex = 2;
            this.label29.Text = "l4: ";
            // 
            // l3Label
            // 
            this.l3Label.AutoSize = true;
            this.l3Label.Location = new System.Drawing.Point(169, 105);
            this.l3Label.Name = "l3Label";
            this.l3Label.Size = new System.Drawing.Size(16, 16);
            this.l3Label.TabIndex = 2;
            this.l3Label.Text = "0";
            this.l3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l4Label
            // 
            this.l4Label.AutoSize = true;
            this.l4Label.Location = new System.Drawing.Point(169, 122);
            this.l4Label.Name = "l4Label";
            this.l4Label.Size = new System.Drawing.Size(16, 16);
            this.l4Label.TabIndex = 2;
            this.l4Label.Text = "0";
            this.l4Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.d0Label);
            this.groupBox2.Controls.Add(this.tLabel);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.d7Label);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.yLabel);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.d6Label);
            this.groupBox2.Controls.Add(this.azLabel);
            this.groupBox2.Controls.Add(this.xLabel);
            this.groupBox2.Controls.Add(this.d1Label);
            this.groupBox2.Controls.Add(this.d5Label);
            this.groupBox2.Controls.Add(this.l0Label);
            this.groupBox2.Controls.Add(this.l4Label);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.bLabel);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.d4Label);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.l3Label);
            this.groupBox2.Controls.Add(this.leLabel);
            this.groupBox2.Controls.Add(this.cLabel);
            this.groupBox2.Controls.Add(this.d2Label);
            this.groupBox2.Controls.Add(this.d3Label);
            this.groupBox2.Controls.Add(this.l1Label);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.reLabel);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.l2Label);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(403, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 173);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Monitoring";
            // 
            // moveBtn
            // 
            this.moveBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.moveBtn.Location = new System.Drawing.Point(264, 79);
            this.moveBtn.Name = "moveBtn";
            this.moveBtn.Size = new System.Drawing.Size(89, 33);
            this.moveBtn.TabIndex = 0;
            this.moveBtn.Text = "Slalom";
            this.moveBtn.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox.ForeColor = System.Drawing.SystemColors.Control;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(12, 248);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(586, 152);
            this.listBox.TabIndex = 5;
            // 
            // sendBtn
            // 
            this.sendBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sendBtn.Location = new System.Drawing.Point(110, 23);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(80, 21);
            this.sendBtn.TabIndex = 0;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(610, 416);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.moveBtn);
            this.Controls.Add(this.startBtn);
            this.Font = new System.Drawing.Font("Gilroy", 10F);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = new Icon("D:/Other/Desktop/Ucheba/Happrinn.ico");
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "IoT_LR1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.NumericUpDown numN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label d0Label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label d1Label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label d2Label;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label d3Label;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label d4Label;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label d5Label;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label d6Label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label d7Label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label azLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label leLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label reLabel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label tLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label l0Label;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label l1Label;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label l2Label;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label l3Label;
        private System.Windows.Forms.Label l4Label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button moveBtn;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button sendBtn;
    }
}