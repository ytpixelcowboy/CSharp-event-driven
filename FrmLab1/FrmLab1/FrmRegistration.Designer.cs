namespace FrmLab1
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
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            label4 = new Label();
            txtAge = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtFirstName = new TextBox();
            txtGender = new TextBox();
            txtMI = new TextBox();
            cbProgram = new ComboBox();
            dtpBirthday = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            txtContact = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(197, 40);
            label1.TabIndex = 0;
            label1.Text = "Resgistration";
            label1.Click += this.label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 1;
            label2.Text = "Student No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            label3.Click += label3_Click;
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(109, 75);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(227, 23);
            txtStudentNo.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(109, 110);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(227, 23);
            txtLastName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(59, 145);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 5;
            label4.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(109, 147);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(69, 23);
            txtAge.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(372, 77);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 7;
            label5.Text = "Program";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(357, 108);
            label6.Name = "label6";
            label6.Size = new Size(86, 21);
            label6.TabIndex = 8;
            label6.Text = "First Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(382, 145);
            label7.Name = "label7";
            label7.Size = new Size(61, 21);
            label7.TabIndex = 9;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(686, 108);
            label8.Name = "label8";
            label8.Size = new Size(31, 21);
            label8.TabIndex = 10;
            label8.Text = "M.I";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(456, 106);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(224, 23);
            txtFirstName.TabIndex = 11;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(456, 147);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(176, 23);
            txtGender.TabIndex = 13;
            // 
            // txtMI
            // 
            txtMI.Location = new Point(723, 108);
            txtMI.Name = "txtMI";
            txtMI.Size = new Size(69, 23);
            txtMI.TabIndex = 14;
            // 
            // cbProgram
            // 
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "BS - Information Technology", "BS - Accountancy", "BS - Maritime", "BS - Computer Science" });
            cbProgram.Location = new Point(456, 77);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(336, 23);
            cbProgram.TabIndex = 15;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(109, 183);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(200, 23);
            dtpBirthday.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(28, 183);
            label9.Name = "label9";
            label9.Size = new Size(68, 21);
            label9.TabIndex = 17;
            label9.Text = "Birthday";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(380, 183);
            label10.Name = "label10";
            label10.Size = new Size(63, 21);
            label10.TabIndex = 18;
            label10.Text = "Contact";
            label10.Click += label10_Click;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(456, 185);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(176, 23);
            txtContact.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(299, 268);
            button1.Name = "button1";
            button1.Size = new Size(171, 36);
            button1.TabIndex = 20;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 335);
            Controls.Add(button1);
            Controls.Add(txtContact);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dtpBirthday);
            Controls.Add(cbProgram);
            Controls.Add(txtMI);
            Controls.Add(txtGender);
            Controls.Add(txtFirstName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtAge);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
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
        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private Label label4;
        private TextBox txtAge;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtFirstName;
        private TextBox txtGender;
        private TextBox txtMI;
        private ComboBox cbProgram;
        private DateTimePicker dtpBirthday;
        private Label label9;
        private Label label10;
        private TextBox txtContact;
        private Button button1;
    }
}