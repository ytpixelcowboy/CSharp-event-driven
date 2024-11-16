namespace FrmOpenTextFile
{
    partial class FrmRegistration
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            label8 = new Label();
            cboxProgram = new ComboBox();
            txtFirstName = new TextBox();
            label9 = new Label();
            txtMiddleName = new TextBox();
            cboxGender = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            txtContactNo = new TextBox();
            btnRegister = new Button();
            btnRecords = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(136, 30);
            label1.TabIndex = 1;
            label1.Text = "Resgistration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 2;
            label2.Text = "Student No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(19, 100);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(66, 133);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 4;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(357, 67);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 5;
            label5.Text = "Program";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(342, 100);
            label6.Name = "label6";
            label6.Size = new Size(86, 21);
            label6.TabIndex = 6;
            label6.Text = "First Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(367, 133);
            label7.Name = "label7";
            label7.Size = new Size(61, 21);
            label7.TabIndex = 7;
            label7.Text = "Gender";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(109, 69);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(222, 23);
            txtStudentNo.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(109, 102);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(222, 23);
            txtLastName.TabIndex = 9;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(109, 135);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(120, 23);
            txtAge.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(35, 170);
            label8.Name = "label8";
            label8.Size = new Size(68, 21);
            label8.TabIndex = 11;
            label8.Text = "Birthday";
            // 
            // cboxProgram
            // 
            cboxProgram.FormattingEnabled = true;
            cboxProgram.Items.AddRange(new object[] { "BS - Information Technology", "BS - Accountancy", "BS - Maritime", "BS - Computer Science" });
            cboxProgram.Location = new Point(434, 67);
            cboxProgram.Name = "cboxProgram";
            cboxProgram.Size = new Size(328, 23);
            cboxProgram.TabIndex = 12;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(434, 102);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(222, 23);
            txtFirstName.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(662, 104);
            label9.Name = "label9";
            label9.Size = new Size(31, 21);
            label9.TabIndex = 14;
            label9.Text = "M.I";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(701, 106);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(61, 23);
            txtMiddleName.TabIndex = 15;
            // 
            // cboxGender
            // 
            cboxGender.FormattingEnabled = true;
            cboxGender.Items.AddRange(new object[] { "Male", "Female" });
            cboxGender.Location = new Point(434, 135);
            cboxGender.Name = "cboxGender";
            cboxGender.Size = new Size(161, 23);
            cboxGender.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(109, 170);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(319, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(434, 172);
            label10.Name = "label10";
            label10.Size = new Size(91, 21);
            label10.TabIndex = 18;
            label10.Text = "Contact No.";
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(531, 174);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(222, 23);
            txtContactNo.TabIndex = 19;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 12F);
            btnRegister.Location = new Point(327, 236);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(152, 41);
            btnRegister.TabIndex = 20;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnRecords
            // 
            btnRecords.Font = new Font("Segoe UI", 12F);
            btnRecords.Location = new Point(617, 236);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(152, 41);
            btnRecords.TabIndex = 21;
            btnRecords.Text = "Records";
            btnRecords.UseVisualStyleBackColor = true;
            btnRecords.Click += btnRecords_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 289);
            Controls.Add(btnRecords);
            Controls.Add(btnRegister);
            Controls.Add(txtContactNo);
            Controls.Add(label10);
            Controls.Add(dateTimePicker1);
            Controls.Add(cboxGender);
            Controls.Add(txtMiddleName);
            Controls.Add(label9);
            Controls.Add(txtFirstName);
            Controls.Add(cboxProgram);
            Controls.Add(label8);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegistration";
            Text = "FrmRegistration";
            Load += FrmRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private TextBox txtAge;
        private Label label8;
        private ComboBox cboxProgram;
        private TextBox txtFirstName;
        private Label label9;
        private TextBox txtMiddleName;
        private ComboBox cboxGender;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private TextBox txtContactNo;
        private Button btnRegister;
        private Button btnRecords;
    }
}