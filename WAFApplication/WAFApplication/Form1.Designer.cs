namespace WAFApplication
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbMasters = new System.Windows.Forms.RadioButton();
            this.rbBachelors = new System.Windows.Forms.RadioButton();
            this.lblProgram = new System.Windows.Forms.Label();
            this.tbdTP = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btClear = new System.Windows.Forms.Button();
            this.olbl2Program = new System.Windows.Forms.Label();
            this.olbl2DoB = new System.Windows.Forms.Label();
            this.olbl2Department = new System.Windows.Forms.Label();
            this.Olbl2Password = new System.Windows.Forms.Label();
            this.olblProgram = new System.Windows.Forms.Label();
            this.olblDoB = new System.Windows.Forms.Label();
            this.olblDepartment = new System.Windows.Forms.Label();
            this.olblPassword = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.otbID = new System.Windows.Forms.TextBox();
            this.olblid = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblProgram);
            this.panel1.Controls.Add(this.tbdTP);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblDepartment);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.tbID);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 584);
            this.panel1.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(206, 389);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(103, 37);
            this.btnShow.TabIndex = 11;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbMasters);
            this.panel3.Controls.Add(this.rbBachelors);
            this.panel3.Location = new System.Drawing.Point(206, 253);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 100);
            this.panel3.TabIndex = 10;
            // 
            // rbMasters
            // 
            this.rbMasters.AutoSize = true;
            this.rbMasters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasters.Location = new System.Drawing.Point(0, 45);
            this.rbMasters.Name = "rbMasters";
            this.rbMasters.Size = new System.Drawing.Size(103, 29);
            this.rbMasters.TabIndex = 1;
            this.rbMasters.TabStop = true;
            this.rbMasters.Text = "Masters";
            this.rbMasters.UseVisualStyleBackColor = true;
            // 
            // rbBachelors
            // 
            this.rbBachelors.AutoSize = true;
            this.rbBachelors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBachelors.Location = new System.Drawing.Point(0, 3);
            this.rbBachelors.Name = "rbBachelors";
            this.rbBachelors.Size = new System.Drawing.Size(120, 29);
            this.rbBachelors.TabIndex = 0;
            this.rbBachelors.TabStop = true;
            this.rbBachelors.Text = "Bachelors";
            this.rbBachelors.UseVisualStyleBackColor = true;
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgram.Location = new System.Drawing.Point(32, 265);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(88, 22);
            this.lblProgram.TabIndex = 9;
            this.lblProgram.Text = "Program";
            // 
            // tbdTP
            // 
            this.tbdTP.CustomFormat = "dd-MM-yyyy";
            this.tbdTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbdTP.Location = new System.Drawing.Point(206, 207);
            this.tbdTP.Name = "tbdTP";
            this.tbdTP.Size = new System.Drawing.Size(237, 30);
            this.tbdTP.TabIndex = 8;
            this.tbdTP.Value = new System.DateTime(2020, 9, 19, 23, 47, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "lblDOB";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CSE",
            "EEE",
            "BBA",
            "ENG"});
            this.comboBox1.Location = new System.Drawing.Point(206, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 33);
            this.comboBox1.TabIndex = 6;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(32, 167);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(116, 22);
            this.lblDepartment.TabIndex = 5;
            this.lblDepartment.Text = "Department";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(206, 119);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '$';
            this.tbPassword.Size = new System.Drawing.Size(237, 30);
            this.tbPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(32, 124);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(94, 22);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(206, 73);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(237, 30);
            this.tbID.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(32, 78);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 22);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Information";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btClear);
            this.panel2.Controls.Add(this.olbl2Program);
            this.panel2.Controls.Add(this.olbl2DoB);
            this.panel2.Controls.Add(this.olbl2Department);
            this.panel2.Controls.Add(this.Olbl2Password);
            this.panel2.Controls.Add(this.olblProgram);
            this.panel2.Controls.Add(this.olblDoB);
            this.panel2.Controls.Add(this.olblDepartment);
            this.panel2.Controls.Add(this.olblPassword);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.otbID);
            this.panel2.Controls.Add(this.olblid);
            this.panel2.Location = new System.Drawing.Point(507, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 584);
            this.panel2.TabIndex = 1;
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(248, 307);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 34);
            this.btClear.TabIndex = 21;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // olbl2Program
            // 
            this.olbl2Program.AutoSize = true;
            this.olbl2Program.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olbl2Program.Location = new System.Drawing.Point(244, 249);
            this.olbl2Program.Name = "olbl2Program";
            this.olbl2Program.Size = new System.Drawing.Size(102, 22);
            this.olbl2Program.TabIndex = 20;
            this.olbl2Program.Text = "OProgram";
            // 
            // olbl2DoB
            // 
            this.olbl2DoB.AutoSize = true;
            this.olbl2DoB.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olbl2DoB.Location = new System.Drawing.Point(244, 212);
            this.olbl2DoB.Name = "olbl2DoB";
            this.olbl2DoB.Size = new System.Drawing.Size(146, 22);
            this.olbl2DoB.TabIndex = 19;
            this.olbl2DoB.Text = "ODate of Birth";
            // 
            // olbl2Department
            // 
            this.olbl2Department.AutoSize = true;
            this.olbl2Department.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olbl2Department.Location = new System.Drawing.Point(244, 167);
            this.olbl2Department.Name = "olbl2Department";
            this.olbl2Department.Size = new System.Drawing.Size(130, 22);
            this.olbl2Department.TabIndex = 18;
            this.olbl2Department.Text = "ODepartment";
            // 
            // Olbl2Password
            // 
            this.Olbl2Password.AutoSize = true;
            this.Olbl2Password.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Olbl2Password.Location = new System.Drawing.Point(244, 124);
            this.Olbl2Password.Name = "Olbl2Password";
            this.Olbl2Password.Size = new System.Drawing.Size(108, 22);
            this.Olbl2Password.TabIndex = 17;
            this.Olbl2Password.Text = "OPassword";
            // 
            // olblProgram
            // 
            this.olblProgram.AutoSize = true;
            this.olblProgram.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olblProgram.Location = new System.Drawing.Point(20, 244);
            this.olblProgram.Name = "olblProgram";
            this.olblProgram.Size = new System.Drawing.Size(88, 22);
            this.olblProgram.TabIndex = 16;
            this.olblProgram.Text = "Program";
            // 
            // olblDoB
            // 
            this.olblDoB.AutoSize = true;
            this.olblDoB.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olblDoB.Location = new System.Drawing.Point(20, 207);
            this.olblDoB.Name = "olblDoB";
            this.olblDoB.Size = new System.Drawing.Size(132, 22);
            this.olblDoB.TabIndex = 15;
            this.olblDoB.Text = "Date of Birth";
            // 
            // olblDepartment
            // 
            this.olblDepartment.AutoSize = true;
            this.olblDepartment.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olblDepartment.Location = new System.Drawing.Point(20, 162);
            this.olblDepartment.Name = "olblDepartment";
            this.olblDepartment.Size = new System.Drawing.Size(116, 22);
            this.olblDepartment.TabIndex = 14;
            this.olblDepartment.Text = "Department";
            // 
            // olblPassword
            // 
            this.olblPassword.AutoSize = true;
            this.olblPassword.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olblPassword.Location = new System.Drawing.Point(20, 119);
            this.olblPassword.Name = "olblPassword";
            this.olblPassword.Size = new System.Drawing.Size(94, 22);
            this.olblPassword.TabIndex = 13;
            this.olblPassword.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(149, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 28);
            this.label8.TabIndex = 12;
            this.label8.Text = "Output";
            // 
            // otbID
            // 
            this.otbID.Enabled = false;
            this.otbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otbID.Location = new System.Drawing.Point(139, 73);
            this.otbID.Name = "otbID";
            this.otbID.Size = new System.Drawing.Size(237, 30);
            this.otbID.TabIndex = 4;
            // 
            // olblid
            // 
            this.olblid.AutoSize = true;
            this.olblid.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olblid.Location = new System.Drawing.Point(20, 78);
            this.olblid.Name = "olblid";
            this.olblid.Size = new System.Drawing.Size(35, 22);
            this.olblid.TabIndex = 3;
            this.olblid.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 608);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "MyFirstFrame";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbMasters;
        private System.Windows.Forms.RadioButton rbBachelors;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.DateTimePicker tbdTP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label olbl2Program;
        private System.Windows.Forms.Label olbl2DoB;
        private System.Windows.Forms.Label olbl2Department;
        private System.Windows.Forms.Label Olbl2Password;
        private System.Windows.Forms.Label olblProgram;
        private System.Windows.Forms.Label olblDoB;
        private System.Windows.Forms.Label olblDepartment;
        private System.Windows.Forms.Label olblPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox otbID;
        private System.Windows.Forms.Label olblid;
        private System.Windows.Forms.Button btClear;
    }
}

