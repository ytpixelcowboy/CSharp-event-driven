namespace FrmRegistration
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_studentNo = new TextBox();
            txt_lastName = new TextBox();
            txt_age = new TextBox();
            txt_contactNo = new TextBox();
            txt_firstName = new TextBox();
            txt_middleName = new TextBox();
            cbox_program = new ComboBox();
            label8 = new Label();
            txt_address = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 0;
            label1.Text = "Student No : ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 1;
            label2.Text = "Last Name : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(151, 9);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 2;
            label3.Text = "Program : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(151, 60);
            label4.Name = "label4";
            label4.Size = new Size(97, 21);
            label4.TabIndex = 3;
            label4.Text = "First Name : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(293, 60);
            label5.Name = "label5";
            label5.Size = new Size(115, 21);
            label5.TabIndex = 4;
            label5.Text = "Middle Name : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 109);
            label6.Name = "label6";
            label6.Size = new Size(44, 21);
            label6.TabIndex = 5;
            label6.Text = "Age :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(151, 109);
            label7.Name = "label7";
            label7.Size = new Size(99, 21);
            label7.TabIndex = 6;
            label7.Text = "Contact No : ";
            // 
            // txt_studentNo
            // 
            txt_studentNo.Location = new Point(12, 33);
            txt_studentNo.Name = "txt_studentNo";
            txt_studentNo.Size = new Size(131, 23);
            txt_studentNo.TabIndex = 7;
            // 
            // txt_lastName
            // 
            txt_lastName.Location = new Point(12, 84);
            txt_lastName.Name = "txt_lastName";
            txt_lastName.Size = new Size(131, 23);
            txt_lastName.TabIndex = 8;
            // 
            // txt_age
            // 
            txt_age.Location = new Point(12, 133);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(131, 23);
            txt_age.TabIndex = 9;
            // 
            // txt_contactNo
            // 
            txt_contactNo.Location = new Point(151, 133);
            txt_contactNo.Name = "txt_contactNo";
            txt_contactNo.Size = new Size(131, 23);
            txt_contactNo.TabIndex = 10;
            // 
            // txt_firstName
            // 
            txt_firstName.Location = new Point(151, 83);
            txt_firstName.Name = "txt_firstName";
            txt_firstName.Size = new Size(131, 23);
            txt_firstName.TabIndex = 11;
            // 
            // txt_middleName
            // 
            txt_middleName.Location = new Point(293, 84);
            txt_middleName.Name = "txt_middleName";
            txt_middleName.Size = new Size(204, 23);
            txt_middleName.TabIndex = 12;
            // 
            // cbox_program
            // 
            cbox_program.FormattingEnabled = true;
            cbox_program.Items.AddRange(new object[] { "BS in Computer Science", "BS in Information Technology", "BS in Computer Engineering" });
            cbox_program.Location = new Point(151, 33);
            cbox_program.Name = "cbox_program";
            cbox_program.Size = new Size(346, 23);
            cbox_program.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(12, 189);
            label8.Name = "label8";
            label8.Size = new Size(77, 21);
            label8.TabIndex = 14;
            label8.Text = "Address : ";
            // 
            // txt_address
            // 
            txt_address.Location = new Point(12, 213);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(485, 178);
            txt_address.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(182, 465);
            button1.Name = "button1";
            button1.Size = new Size(139, 35);
            button1.TabIndex = 16;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 512);
            Controls.Add(button1);
            Controls.Add(txt_address);
            Controls.Add(label8);
            Controls.Add(cbox_program);
            Controls.Add(txt_middleName);
            Controls.Add(txt_firstName);
            Controls.Add(txt_contactNo);
            Controls.Add(txt_age);
            Controls.Add(txt_lastName);
            Controls.Add(txt_studentNo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
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
        private TextBox txt_studentNo;
        private TextBox txt_lastName;
        private TextBox txt_age;
        private TextBox txt_contactNo;
        private TextBox txt_firstName;
        private TextBox txt_middleName;
        private ComboBox cbox_program;
        private Label label8;
        private TextBox txt_address;
        private Button button1;
    }
}
