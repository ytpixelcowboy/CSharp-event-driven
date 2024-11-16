namespace FrmOpenTextFile
{
    partial class FrmStudentRecord
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
            listView1 = new ListView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(134, 30);
            label1.TabIndex = 0;
            label1.Text = "View Record";
            // 
            // listView1
            // 
            listView1.HoverSelection = true;
            listView1.ImeMode = ImeMode.NoControl;
            listView1.LabelWrap = false;
            listView1.Location = new Point(12, 42);
            listView1.Name = "listView1";
            listView1.Size = new Size(530, 320);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(559, 42);
            button1.Name = "button1";
            button1.Size = new Size(152, 41);
            button1.TabIndex = 2;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(559, 89);
            button2.Name = "button2";
            button2.Size = new Size(152, 41);
            button2.TabIndex = 3;
            button2.Text = "Find";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(559, 136);
            button3.Name = "button3";
            button3.Size = new Size(152, 41);
            button3.TabIndex = 4;
            button3.Text = "Upload";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FrmStudentRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 374);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "FrmStudentRecord";
            Text = "FrmStudentRecord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}