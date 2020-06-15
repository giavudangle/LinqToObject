namespace LinqToObject
{
    partial class MainForm
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
            this.dataDisplay = new System.Windows.Forms.DataGridView();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnLesser = new System.Windows.Forms.Button();
            this.btnGreater = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStandardID = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGroupStudentName_Descending = new System.Windows.Forms.Button();
            this.btnGroupStudentName_Ascending = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGroupStudentAge_Descending = new System.Windows.Forms.Button();
            this.btnGroupStudentAge_Ascending = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnGroupStudentID_Descending = new System.Windows.Forms.Button();
            this.btnGroupStudentID_Ascending = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGroupByStandardID_Descending = new System.Windows.Forms.Button();
            this.btnGroupStandardID_Ascending = new System.Windows.Forms.Button();
            this.dataResult = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btn_Select_StudentAge = new System.Windows.Forms.Button();
            this.btn_Select_StudentName = new System.Windows.Forms.Button();
            this.btn_Select_StandardID = new System.Windows.Forms.Button();
            this.btn_Select_ID = new System.Windows.Forms.Button();
            this.txtStudentAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStdardID = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnGroupName = new System.Windows.Forms.RadioButton();
            this.btnGroupStanID = new System.Windows.Forms.RadioButton();
            this.btnGroupAge = new System.Windows.Forms.RadioButton();
            this.btnGroupStuID = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Join = new System.Windows.Forms.GroupBox();
            this.btnLeftJoin = new System.Windows.Forms.Button();
            this.btnRightJoin = new System.Windows.Forms.Button();
            this.btnInnerJoin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDisplay)).BeginInit();
            this.groupbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataResult)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.Join.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataDisplay
            // 
            this.dataDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataDisplay.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDisplay.Location = new System.Drawing.Point(0, 12);
            this.dataDisplay.Name = "dataDisplay";
            this.dataDisplay.Size = new System.Drawing.Size(468, 304);
            this.dataDisplay.TabIndex = 0;
            // 
            // groupbox
            // 
            this.groupbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupbox.Controls.Add(this.btnEqual);
            this.groupbox.Controls.Add(this.btnLesser);
            this.groupbox.Controls.Add(this.btnGreater);
            this.groupbox.Controls.Add(this.label2);
            this.groupbox.Controls.Add(this.label1);
            this.groupbox.Controls.Add(this.txtStandardID);
            this.groupbox.Controls.Add(this.txtAge);
            this.groupbox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupbox.Location = new System.Drawing.Point(518, 198);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(472, 107);
            this.groupbox.TabIndex = 5;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "Multi Select - Where Operator";
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(316, 69);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(67, 23);
            this.btnEqual.TabIndex = 6;
            this.btnEqual.Text = "Equal";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnLesser
            // 
            this.btnLesser.Location = new System.Drawing.Point(316, 41);
            this.btnLesser.Name = "btnLesser";
            this.btnLesser.Size = new System.Drawing.Size(67, 23);
            this.btnLesser.TabIndex = 5;
            this.btnLesser.Text = "Lesser";
            this.btnLesser.UseVisualStyleBackColor = true;
            this.btnLesser.Click += new System.EventHandler(this.btnLesser_Click);
            // 
            // btnGreater
            // 
            this.btnGreater.Location = new System.Drawing.Point(316, 12);
            this.btnGreater.Name = "btnGreater";
            this.btnGreater.Size = new System.Drawing.Size(67, 23);
            this.btnGreater.TabIndex = 4;
            this.btnGreater.Text = "Greater";
            this.btnGreater.UseVisualStyleBackColor = true;
            this.btnGreater.Click += new System.EventHandler(this.btnGreater_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Standard ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Age :";
            // 
            // txtStandardID
            // 
            this.txtStandardID.Location = new System.Drawing.Point(106, 63);
            this.txtStandardID.Name = "txtStandardID";
            this.txtStandardID.Size = new System.Drawing.Size(166, 20);
            this.txtStandardID.TabIndex = 1;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(106, 19);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(166, 20);
            this.txtAge.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(518, 430);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 216);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorting";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox4.Controls.Add(this.btnGroupStudentName_Descending);
            this.groupBox4.Controls.Add(this.btnGroupStudentName_Ascending);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Location = new System.Drawing.Point(33, 117);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(187, 90);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Student Name";
            // 
            // btnGroupStudentName_Descending
            // 
            this.btnGroupStudentName_Descending.Location = new System.Drawing.Point(97, 28);
            this.btnGroupStudentName_Descending.Name = "btnGroupStudentName_Descending";
            this.btnGroupStudentName_Descending.Size = new System.Drawing.Size(85, 45);
            this.btnGroupStudentName_Descending.TabIndex = 4;
            this.btnGroupStudentName_Descending.Text = "Descending";
            this.btnGroupStudentName_Descending.UseVisualStyleBackColor = true;
            this.btnGroupStudentName_Descending.Click += new System.EventHandler(this.btnGroupStudentName_Descending_Click);
            // 
            // btnGroupStudentName_Ascending
            // 
            this.btnGroupStudentName_Ascending.Location = new System.Drawing.Point(6, 28);
            this.btnGroupStudentName_Ascending.Name = "btnGroupStudentName_Ascending";
            this.btnGroupStudentName_Ascending.Size = new System.Drawing.Size(85, 45);
            this.btnGroupStudentName_Ascending.TabIndex = 4;
            this.btnGroupStudentName_Ascending.Text = "Ascending";
            this.btnGroupStudentName_Ascending.UseVisualStyleBackColor = true;
            this.btnGroupStudentName_Ascending.Click += new System.EventHandler(this.btnGroupStudentName_Ascending_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.btnGroupStudentAge_Descending);
            this.groupBox3.Controls.Add(this.btnGroupStudentAge_Ascending);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(242, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 90);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student Age";
            // 
            // btnGroupStudentAge_Descending
            // 
            this.btnGroupStudentAge_Descending.Location = new System.Drawing.Point(105, 28);
            this.btnGroupStudentAge_Descending.Name = "btnGroupStudentAge_Descending";
            this.btnGroupStudentAge_Descending.Size = new System.Drawing.Size(85, 45);
            this.btnGroupStudentAge_Descending.TabIndex = 4;
            this.btnGroupStudentAge_Descending.Text = "Descending";
            this.btnGroupStudentAge_Descending.UseVisualStyleBackColor = true;
            this.btnGroupStudentAge_Descending.Click += new System.EventHandler(this.btnGroupStudentAge_Descending_Click);
            // 
            // btnGroupStudentAge_Ascending
            // 
            this.btnGroupStudentAge_Ascending.Location = new System.Drawing.Point(6, 28);
            this.btnGroupStudentAge_Ascending.Name = "btnGroupStudentAge_Ascending";
            this.btnGroupStudentAge_Ascending.Size = new System.Drawing.Size(85, 45);
            this.btnGroupStudentAge_Ascending.TabIndex = 4;
            this.btnGroupStudentAge_Ascending.Text = "Ascending";
            this.btnGroupStudentAge_Ascending.UseVisualStyleBackColor = true;
            this.btnGroupStudentAge_Ascending.Click += new System.EventHandler(this.btnGroupStudentAge_Ascending_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox5.Controls.Add(this.btnGroupStudentID_Descending);
            this.groupBox5.Controls.Add(this.btnGroupStudentID_Ascending);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox5.Location = new System.Drawing.Point(242, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(196, 92);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Student ID";
            // 
            // btnGroupStudentID_Descending
            // 
            this.btnGroupStudentID_Descending.Location = new System.Drawing.Point(105, 29);
            this.btnGroupStudentID_Descending.Name = "btnGroupStudentID_Descending";
            this.btnGroupStudentID_Descending.Size = new System.Drawing.Size(85, 45);
            this.btnGroupStudentID_Descending.TabIndex = 3;
            this.btnGroupStudentID_Descending.Text = "Descending";
            this.btnGroupStudentID_Descending.UseVisualStyleBackColor = true;
            this.btnGroupStudentID_Descending.Click += new System.EventHandler(this.btnGroupStudentID_Descending_Click);
            // 
            // btnGroupStudentID_Ascending
            // 
            this.btnGroupStudentID_Ascending.Location = new System.Drawing.Point(6, 29);
            this.btnGroupStudentID_Ascending.Name = "btnGroupStudentID_Ascending";
            this.btnGroupStudentID_Ascending.Size = new System.Drawing.Size(85, 45);
            this.btnGroupStudentID_Ascending.TabIndex = 2;
            this.btnGroupStudentID_Ascending.Text = "Ascending";
            this.btnGroupStudentID_Ascending.UseVisualStyleBackColor = true;
            this.btnGroupStudentID_Ascending.Click += new System.EventHandler(this.btnGroupStudentID_Ascending_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.btnGroupByStandardID_Descending);
            this.groupBox2.Controls.Add(this.btnGroupStandardID_Ascending);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(33, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 92);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Standard ID";
            // 
            // btnGroupByStandardID_Descending
            // 
            this.btnGroupByStandardID_Descending.Location = new System.Drawing.Point(97, 29);
            this.btnGroupByStandardID_Descending.Name = "btnGroupByStandardID_Descending";
            this.btnGroupByStandardID_Descending.Size = new System.Drawing.Size(84, 45);
            this.btnGroupByStandardID_Descending.TabIndex = 1;
            this.btnGroupByStandardID_Descending.Text = "Descending";
            this.btnGroupByStandardID_Descending.UseVisualStyleBackColor = true;
            this.btnGroupByStandardID_Descending.Click += new System.EventHandler(this.btnGroupByStandardID_Descending_Click);
            // 
            // btnGroupStandardID_Ascending
            // 
            this.btnGroupStandardID_Ascending.Location = new System.Drawing.Point(6, 29);
            this.btnGroupStandardID_Ascending.Name = "btnGroupStandardID_Ascending";
            this.btnGroupStandardID_Ascending.Size = new System.Drawing.Size(85, 45);
            this.btnGroupStandardID_Ascending.TabIndex = 0;
            this.btnGroupStandardID_Ascending.Text = "Ascending";
            this.btnGroupStandardID_Ascending.UseVisualStyleBackColor = true;
            this.btnGroupStandardID_Ascending.Click += new System.EventHandler(this.btnGroupStandardID_Ascending_Click);
            // 
            // dataResult
            // 
            this.dataResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataResult.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResult.Location = new System.Drawing.Point(12, 346);
            this.dataResult.Name = "dataResult";
            this.dataResult.Size = new System.Drawing.Size(456, 300);
            this.dataResult.TabIndex = 7;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox7.Controls.Add(this.btn_Select_StudentAge);
            this.groupBox7.Controls.Add(this.btn_Select_StudentName);
            this.groupBox7.Controls.Add(this.btn_Select_StandardID);
            this.groupBox7.Controls.Add(this.btn_Select_ID);
            this.groupBox7.Controls.Add(this.txtStudentAge);
            this.groupBox7.Controls.Add(this.txtName);
            this.groupBox7.Controls.Add(this.txtStdardID);
            this.groupBox7.Controls.Add(this.txtStudentID);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox7.Location = new System.Drawing.Point(518, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(472, 180);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Single Select -Where Operator";
            // 
            // btn_Select_StudentAge
            // 
            this.btn_Select_StudentAge.Location = new System.Drawing.Point(316, 140);
            this.btn_Select_StudentAge.Name = "btn_Select_StudentAge";
            this.btn_Select_StudentAge.Size = new System.Drawing.Size(111, 23);
            this.btn_Select_StudentAge.TabIndex = 18;
            this.btn_Select_StudentAge.Text = "Filter StudentAge";
            this.btn_Select_StudentAge.UseVisualStyleBackColor = true;
            this.btn_Select_StudentAge.Click += new System.EventHandler(this.btn_Select_StudentAge_Click);
            // 
            // btn_Select_StudentName
            // 
            this.btn_Select_StudentName.Location = new System.Drawing.Point(316, 101);
            this.btn_Select_StudentName.Name = "btn_Select_StudentName";
            this.btn_Select_StudentName.Size = new System.Drawing.Size(111, 23);
            this.btn_Select_StudentName.TabIndex = 17;
            this.btn_Select_StudentName.Text = "Filter StudentName";
            this.btn_Select_StudentName.UseVisualStyleBackColor = true;
            this.btn_Select_StudentName.Click += new System.EventHandler(this.btn_Select_StudentName_Click);
            // 
            // btn_Select_StandardID
            // 
            this.btn_Select_StandardID.Location = new System.Drawing.Point(316, 63);
            this.btn_Select_StandardID.Name = "btn_Select_StandardID";
            this.btn_Select_StandardID.Size = new System.Drawing.Size(111, 23);
            this.btn_Select_StandardID.TabIndex = 16;
            this.btn_Select_StandardID.Text = "Filter StandardID";
            this.btn_Select_StandardID.UseVisualStyleBackColor = true;
            this.btn_Select_StandardID.Click += new System.EventHandler(this.btn_Select_StandardID_Click);
            // 
            // btn_Select_ID
            // 
            this.btn_Select_ID.Location = new System.Drawing.Point(316, 27);
            this.btn_Select_ID.Name = "btn_Select_ID";
            this.btn_Select_ID.Size = new System.Drawing.Size(111, 23);
            this.btn_Select_ID.TabIndex = 15;
            this.btn_Select_ID.Text = "Filter StudentID";
            this.btn_Select_ID.UseVisualStyleBackColor = true;
            this.btn_Select_ID.Click += new System.EventHandler(this.btn_Select_ID_Click);
            // 
            // txtStudentAge
            // 
            this.txtStudentAge.Location = new System.Drawing.Point(106, 143);
            this.txtStudentAge.Name = "txtStudentAge";
            this.txtStudentAge.Size = new System.Drawing.Size(166, 20);
            this.txtStudentAge.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 103);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 20);
            this.txtName.TabIndex = 13;
            // 
            // txtStdardID
            // 
            this.txtStdardID.Location = new System.Drawing.Point(106, 66);
            this.txtStdardID.Name = "txtStdardID";
            this.txtStdardID.Size = new System.Drawing.Size(166, 20);
            this.txtStdardID.TabIndex = 12;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(106, 29);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(166, 20);
            this.txtStudentID.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Age :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Standard ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Student ID :";
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox8.Controls.Add(this.btnGroupName);
            this.groupBox8.Controls.Add(this.btnGroupStanID);
            this.groupBox8.Controls.Add(this.btnGroupAge);
            this.groupBox8.Controls.Add(this.btnGroupStuID);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox8.Location = new System.Drawing.Point(518, 311);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(301, 113);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Group by";
            // 
            // btnGroupName
            // 
            this.btnGroupName.AutoSize = true;
            this.btnGroupName.Location = new System.Drawing.Point(227, 35);
            this.btnGroupName.Name = "btnGroupName";
            this.btnGroupName.Size = new System.Drawing.Size(14, 13);
            this.btnGroupName.TabIndex = 11;
            this.btnGroupName.TabStop = true;
            this.btnGroupName.UseVisualStyleBackColor = true;
            this.btnGroupName.CheckedChanged += new System.EventHandler(this.btnGroupName_CheckedChanged);
            // 
            // btnGroupStanID
            // 
            this.btnGroupStanID.AutoSize = true;
            this.btnGroupStanID.Location = new System.Drawing.Point(99, 76);
            this.btnGroupStanID.Name = "btnGroupStanID";
            this.btnGroupStanID.Size = new System.Drawing.Size(14, 13);
            this.btnGroupStanID.TabIndex = 10;
            this.btnGroupStanID.TabStop = true;
            this.btnGroupStanID.UseVisualStyleBackColor = true;
            this.btnGroupStanID.CheckedChanged += new System.EventHandler(this.btnGroupStanID_CheckedChanged);
            // 
            // btnGroupAge
            // 
            this.btnGroupAge.AutoSize = true;
            this.btnGroupAge.Location = new System.Drawing.Point(227, 76);
            this.btnGroupAge.Name = "btnGroupAge";
            this.btnGroupAge.Size = new System.Drawing.Size(14, 13);
            this.btnGroupAge.TabIndex = 9;
            this.btnGroupAge.TabStop = true;
            this.btnGroupAge.UseVisualStyleBackColor = true;
            this.btnGroupAge.CheckedChanged += new System.EventHandler(this.btnGroupAge_CheckedChanged);
            // 
            // btnGroupStuID
            // 
            this.btnGroupStuID.AutoSize = true;
            this.btnGroupStuID.Location = new System.Drawing.Point(99, 35);
            this.btnGroupStuID.MaximumSize = new System.Drawing.Size(50, 50);
            this.btnGroupStuID.Name = "btnGroupStuID";
            this.btnGroupStuID.Size = new System.Drawing.Size(14, 13);
            this.btnGroupStuID.TabIndex = 8;
            this.btnGroupStuID.TabStop = true;
            this.btnGroupStuID.UseVisualStyleBackColor = true;
            this.btnGroupStuID.CheckedChanged += new System.EventHandler(this.btnGroupStuID_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(133, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Student Age :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(133, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Student Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Standard ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Student ID :";
            // 
            // Join
            // 
            this.Join.Controls.Add(this.btnInnerJoin);
            this.Join.Controls.Add(this.btnRightJoin);
            this.Join.Controls.Add(this.btnLeftJoin);
            this.Join.ForeColor = System.Drawing.Color.BlueViolet;
            this.Join.Location = new System.Drawing.Point(834, 311);
            this.Join.Name = "Join";
            this.Join.Size = new System.Drawing.Size(156, 113);
            this.Join.TabIndex = 11;
            this.Join.TabStop = false;
            this.Join.Text = "Join";
            // 
            // btnLeftJoin
            // 
            this.btnLeftJoin.Location = new System.Drawing.Point(6, 19);
            this.btnLeftJoin.Name = "btnLeftJoin";
            this.btnLeftJoin.Size = new System.Drawing.Size(144, 23);
            this.btnLeftJoin.TabIndex = 0;
            this.btnLeftJoin.Text = "Left Join";
            this.btnLeftJoin.UseVisualStyleBackColor = true;
            this.btnLeftJoin.Click += new System.EventHandler(this.btnLeftJoin_Click);
            // 
            // btnRightJoin
            // 
            this.btnRightJoin.Location = new System.Drawing.Point(6, 48);
            this.btnRightJoin.Name = "btnRightJoin";
            this.btnRightJoin.Size = new System.Drawing.Size(144, 23);
            this.btnRightJoin.TabIndex = 1;
            this.btnRightJoin.Text = "Right Join";
            this.btnRightJoin.UseVisualStyleBackColor = true;
            this.btnRightJoin.Click += new System.EventHandler(this.btnRightJoin_Click);
            // 
            // btnInnerJoin
            // 
            this.btnInnerJoin.Location = new System.Drawing.Point(6, 76);
            this.btnInnerJoin.Name = "btnInnerJoin";
            this.btnInnerJoin.Size = new System.Drawing.Size(144, 23);
            this.btnInnerJoin.TabIndex = 2;
            this.btnInnerJoin.Text = "Inner Join";
            this.btnInnerJoin.UseVisualStyleBackColor = true;
            this.btnInnerJoin.Click += new System.EventHandler(this.btnInnerJoin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 672);
            this.Controls.Add(this.Join);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.dataDisplay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupbox);
            this.Controls.Add(this.dataResult);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataDisplay)).EndInit();
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataResult)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.Join.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dataDisplay;
        private System.Windows.Forms.TextBox txtStandardID;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGreater;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnLesser;
        public System.Windows.Forms.DataGridView dataResult;
        private System.Windows.Forms.Button btnGroupStandardID_Ascending;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnGroupByStandardID_Descending;
        private System.Windows.Forms.Button btnGroupStudentName_Descending;
        private System.Windows.Forms.Button btnGroupStudentName_Ascending;
        private System.Windows.Forms.Button btnGroupStudentAge_Descending;
        private System.Windows.Forms.Button btnGroupStudentAge_Ascending;
        private System.Windows.Forms.Button btnGroupStudentID_Descending;
        private System.Windows.Forms.Button btnGroupStudentID_Ascending;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Select_StudentAge;
        private System.Windows.Forms.Button btn_Select_StudentName;
        private System.Windows.Forms.Button btn_Select_StandardID;
        private System.Windows.Forms.Button btn_Select_ID;
        private System.Windows.Forms.TextBox txtStudentAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStdardID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton btnGroupStuID;
        private System.Windows.Forms.RadioButton btnGroupName;
        private System.Windows.Forms.RadioButton btnGroupStanID;
        private System.Windows.Forms.RadioButton btnGroupAge;
        private System.Windows.Forms.GroupBox Join;
        private System.Windows.Forms.Button btnInnerJoin;
        private System.Windows.Forms.Button btnRightJoin;
        private System.Windows.Forms.Button btnLeftJoin;
    }
}

