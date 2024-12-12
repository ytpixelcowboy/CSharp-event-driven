namespace FrmClubRegistration
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
            tbox_studentId = new TextBox();
            tbox_lastName = new TextBox();
            tbox_firstName = new TextBox();
            tbox_middleName = new TextBox();
            tbox_age = new TextBox();
            btn_register = new Button();
            btn_update = new Button();
            btn_refresh = new Button();
            cbox_program = new ComboBox();
            dataGridView = new DataGridView();
            label8 = new Label();
            cbox_gender = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(10, 74);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(276, 62);
            label3.Name = "label3";
            label3.Size = new Size(86, 21);
            label3.TabIndex = 2;
            label3.Text = "First Name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 134);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 3;
            label4.Text = "Age";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(543, 9);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 4;
            label5.Text = "Program";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(543, 62);
            label6.Name = "label6";
            label6.Size = new Size(104, 21);
            label6.TabIndex = 5;
            label6.Text = "Middle Name";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(12, 221);
            label7.Name = "label7";
            label7.Size = new Size(158, 21);
            label7.TabIndex = 6;
            label7.Text = "List of Club Members";
            label7.Click += label7_Click;
            // 
            // tbox_studentId
            // 
            tbox_studentId.Location = new Point(12, 36);
            tbox_studentId.Name = "tbox_studentId";
            tbox_studentId.Size = new Size(243, 23);
            tbox_studentId.TabIndex = 7;
            // 
            // tbox_lastName
            // 
            tbox_lastName.Location = new Point(12, 98);
            tbox_lastName.Name = "tbox_lastName";
            tbox_lastName.Size = new Size(243, 23);
            tbox_lastName.TabIndex = 8;
            // 
            // tbox_firstName
            // 
            tbox_firstName.Location = new Point(276, 98);
            tbox_firstName.Name = "tbox_firstName";
            tbox_firstName.Size = new Size(243, 23);
            tbox_firstName.TabIndex = 9;
            tbox_firstName.TextChanged += textBox3_TextChanged;
            // 
            // tbox_middleName
            // 
            tbox_middleName.Location = new Point(545, 98);
            tbox_middleName.Name = "tbox_middleName";
            tbox_middleName.Size = new Size(243, 23);
            tbox_middleName.TabIndex = 10;
            tbox_middleName.TextChanged += textBox4_TextChanged;
            // 
            // tbox_age
            // 
            tbox_age.Location = new Point(12, 158);
            tbox_age.Name = "tbox_age";
            tbox_age.Size = new Size(243, 23);
            tbox_age.TabIndex = 11;
            tbox_age.TextChanged += textBox5_TextChanged;
            // 
            // btn_register
            // 
            btn_register.BackColor = SystemColors.Control;
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.Location = new Point(818, 20);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(146, 39);
            btn_register.TabIndex = 12;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.Control;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Location = new Point(818, 74);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(146, 39);
            btn_update.TabIndex = 13;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_refresh
            // 
            btn_refresh.FlatStyle = FlatStyle.Flat;
            btn_refresh.Location = new Point(818, 256);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(146, 39);
            btn_refresh.TabIndex = 14;
            btn_refresh.Text = "Refresh";
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // cbox_program
            // 
            cbox_program.FormattingEnabled = true;
            cbox_program.Items.AddRange(new object[] { "Bachelor of Information Technology", "Bachelor of Computer Science", "Bachelor of Information Systems", "Bachelor of Computer Engineering" });
            cbox_program.Location = new Point(548, 38);
            cbox_program.Name = "cbox_program";
            cbox_program.Size = new Size(240, 23);
            cbox_program.TabIndex = 16;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(15, 256);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(773, 228);
            dataGridView.TabIndex = 17;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(276, 134);
            label8.Name = "label8";
            label8.Size = new Size(61, 21);
            label8.TabIndex = 18;
            label8.Text = "Gender";
            // 
            // cbox_gender
            // 
            cbox_gender.FormattingEnabled = true;
            cbox_gender.Items.AddRange(new object[] { "Male", "Female" });
            cbox_gender.Location = new Point(279, 158);
            cbox_gender.Name = "cbox_gender";
            cbox_gender.Size = new Size(240, 23);
            cbox_gender.TabIndex = 19;
            cbox_gender.SelectedIndexChanged += cbox_gender_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 496);
            Controls.Add(cbox_gender);
            Controls.Add(label8);
            Controls.Add(dataGridView);
            Controls.Add(cbox_program);
            Controls.Add(btn_refresh);
            Controls.Add(btn_update);
            Controls.Add(btn_register);
            Controls.Add(tbox_age);
            Controls.Add(tbox_middleName);
            Controls.Add(tbox_firstName);
            Controls.Add(tbox_lastName);
            Controls.Add(tbox_studentId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "FrmClubRegistration";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
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
        private TextBox tbox_studentId;
        private TextBox tbox_lastName;
        private TextBox tbox_firstName;
        private TextBox tbox_middleName;
        private TextBox tbox_age;
        private Button btn_register;
        private Button btn_update;
        private Button btn_refresh;
        private ComboBox cbox_program;
        private DataGridView dataGridView;
        private Label label8;
        private ComboBox cbox_gender;
    }
}
