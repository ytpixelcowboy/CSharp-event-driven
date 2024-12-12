namespace FrmClubRegistration
{
    partial class FrmUpdateMember
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
            tbox_lastName = new TextBox();
            label6 = new Label();
            tbox_middleName = new TextBox();
            label3 = new Label();
            tbox_firstName = new TextBox();
            label4 = new Label();
            tbox_age = new TextBox();
            label8 = new Label();
            btn_update = new Button();
            cbox_studentIds = new ComboBox();
            cbox_gender = new ComboBox();
            label5 = new Label();
            cbox_program = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 1;
            label1.Text = "Student ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 9;
            label2.Text = "Last Name";
            // 
            // tbox_lastName
            // 
            tbox_lastName.Location = new Point(12, 95);
            tbox_lastName.Name = "tbox_lastName";
            tbox_lastName.Size = new Size(243, 23);
            tbox_lastName.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 199);
            label6.Name = "label6";
            label6.Size = new Size(104, 21);
            label6.TabIndex = 11;
            label6.Text = "Middle Name";
            // 
            // tbox_middleName
            // 
            tbox_middleName.Location = new Point(12, 223);
            tbox_middleName.Name = "tbox_middleName";
            tbox_middleName.Size = new Size(243, 23);
            tbox_middleName.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 137);
            label3.Name = "label3";
            label3.Size = new Size(86, 21);
            label3.TabIndex = 13;
            label3.Text = "First Name";
            // 
            // tbox_firstName
            // 
            tbox_firstName.Location = new Point(12, 161);
            tbox_firstName.Name = "tbox_firstName";
            tbox_firstName.Size = new Size(243, 23);
            tbox_firstName.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 261);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 15;
            label4.Text = "Age";
            // 
            // tbox_age
            // 
            tbox_age.Location = new Point(12, 285);
            tbox_age.Name = "tbox_age";
            tbox_age.Size = new Size(243, 23);
            tbox_age.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(12, 321);
            label8.Name = "label8";
            label8.Size = new Size(61, 21);
            label8.TabIndex = 19;
            label8.Text = "Gender";
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.Control;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Location = new Point(65, 481);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(146, 39);
            btn_update.TabIndex = 21;
            btn_update.Text = "Confirm";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // cbox_studentIds
            // 
            cbox_studentIds.FormattingEnabled = true;
            cbox_studentIds.Location = new Point(12, 33);
            cbox_studentIds.Name = "cbox_studentIds";
            cbox_studentIds.Size = new Size(240, 23);
            cbox_studentIds.TabIndex = 22;
            cbox_studentIds.SelectedIndexChanged += cbox_studentIds_SelectedIndexChanged;
            // 
            // cbox_gender
            // 
            cbox_gender.FormattingEnabled = true;
            cbox_gender.Items.AddRange(new object[] { "Male", "Female" });
            cbox_gender.Location = new Point(12, 345);
            cbox_gender.Name = "cbox_gender";
            cbox_gender.Size = new Size(240, 23);
            cbox_gender.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 380);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 24;
            label5.Text = "Program";
            label5.Click += label5_Click;
            // 
            // cbox_program
            // 
            cbox_program.FormattingEnabled = true;
            cbox_program.Items.AddRange(new object[] { "Bachelor of Information Technology", "Bachelor of Computer Science", "Bachelor of Information Systems", "Bachelor of Computer Engineering" });
            cbox_program.Location = new Point(12, 404);
            cbox_program.Name = "cbox_program";
            cbox_program.Size = new Size(240, 23);
            cbox_program.TabIndex = 25;
            // 
            // FrmUpdateMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 532);
            Controls.Add(cbox_program);
            Controls.Add(label5);
            Controls.Add(cbox_gender);
            Controls.Add(cbox_studentIds);
            Controls.Add(btn_update);
            Controls.Add(label8);
            Controls.Add(tbox_age);
            Controls.Add(label4);
            Controls.Add(tbox_firstName);
            Controls.Add(label3);
            Controls.Add(tbox_middleName);
            Controls.Add(label6);
            Controls.Add(tbox_lastName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmUpdateMember";
            Text = "FrmUpdateMember";
            Load += FrmUpdateMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbox_lastName;
        private Label label6;
        private TextBox tbox_middleName;
        private Label label3;
        private TextBox tbox_firstName;
        private Label label4;
        private TextBox tbox_age;
        private Label label8;
        private Button btn_update;
        private ComboBox cbox_studentIds;
        private ComboBox cbox_gender;
        private Label label5;
        private ComboBox cbox_program;
    }
}