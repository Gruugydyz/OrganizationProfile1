namespace OrganizationProfile1
{
    partial class frmRegsitration
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
            btnRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleInitial = new TextBox();
            txtContactNo = new TextBox();
            cbPrograms = new ComboBox();
            cbGender = new ComboBox();
            datePickerBirthday = new DateTimePicker();
            label11 = new Label();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.ButtonFace;
            btnRegister.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = SystemColors.ActiveCaptionText;
            btnRegister.Location = new Point(299, 315);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 38);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(39, 20);
            label1.Name = "label1";
            label1.Size = new Size(174, 38);
            label1.TabIndex = 1;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(20, 92);
            label2.Name = "label2";
            label2.Size = new Size(108, 19);
            label2.TabIndex = 2;
            label2.Text = "Student No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(20, 147);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(326, 92);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 4;
            label4.Text = "Program";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(299, 147);
            label5.Name = "label5";
            label5.Size = new Size(99, 19);
            label5.TabIndex = 5;
            label5.Text = "First Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(566, 147);
            label6.Name = "label6";
            label6.Size = new Size(45, 19);
            label6.TabIndex = 6;
            label6.Text = "M.I.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(326, 203);
            label7.Name = "label7";
            label7.Size = new Size(72, 19);
            label7.TabIndex = 7;
            label7.Text = "Gender:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(29, 264);
            label8.Name = "label8";
            label8.Size = new Size(81, 19);
            label8.TabIndex = 8;
            label8.Text = "Birthday";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(404, 264);
            label9.Name = "label9";
            label9.Size = new Size(108, 19);
            label9.TabIndex = 9;
            label9.Text = "Contact No.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(74, 203);
            label10.Name = "label10";
            label10.Size = new Size(36, 19);
            label10.TabIndex = 10;
            label10.Text = "Age";
            // 
            // txtStudentNo
            // 
            txtStudentNo.BackColor = SystemColors.Window;
            txtStudentNo.Location = new Point(131, 88);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(147, 23);
            txtStudentNo.TabIndex = 11;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(131, 143);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(147, 23);
            txtLastName.TabIndex = 12;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(131, 203);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(101, 23);
            txtAge.TabIndex = 13;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(404, 143);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(147, 23);
            txtFirstName.TabIndex = 14;
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Location = new Point(617, 143);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(58, 23);
            txtMiddleInitial.TabIndex = 15;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(518, 260);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(147, 23);
            txtContactNo.TabIndex = 16;
            // 
            // cbPrograms
            // 
            cbPrograms.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbPrograms.FormattingEnabled = true;
            cbPrograms.Location = new Point(404, 88);
            cbPrograms.Name = "cbPrograms";
            cbPrograms.Size = new Size(271, 25);
            cbPrograms.TabIndex = 17;
            // 
            // cbGender
            // 
            cbGender.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(404, 201);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(123, 25);
            cbGender.TabIndex = 18;
            // 
            // datePickerBirthday
            // 
            datePickerBirthday.Location = new Point(123, 261);
            datePickerBirthday.Name = "datePickerBirthday";
            datePickerBirthday.Size = new Size(255, 23);
            datePickerBirthday.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(29, 20);
            label11.Name = "label11";
            label11.Size = new Size(84, 38);
            label11.TabIndex = 20;
            label11.Text = "Regis";
            // 
            // frmRegsitration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(689, 365);
            Controls.Add(datePickerBirthday);
            Controls.Add(cbGender);
            Controls.Add(cbPrograms);
            Controls.Add(txtContactNo);
            Controls.Add(txtMiddleInitial);
            Controls.Add(txtFirstName);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRegister);
            Controls.Add(label11);
            Controls.Add(label1);
            Name = "frmRegsitration";
            Text = "Organization Profile";
            Load += frmRegsitration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private TextBox txtAge;
        private TextBox txtFirstName;
        private TextBox txtMiddleInitial;
        private TextBox txtContactNo;
        private ComboBox cbPrograms;
        private ComboBox cbGender;
        private DateTimePicker datePickerBirthday;
        private Label label11;
    }
}