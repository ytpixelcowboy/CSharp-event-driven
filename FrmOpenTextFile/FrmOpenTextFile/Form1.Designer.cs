namespace FrmOpenTextFile
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
            lvShowText = new ListView();
            btnOpen = new Button();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            button1 = new Button();
            SuspendLayout();
            // 
            // lvShowText
            // 
            lvShowText.Location = new Point(12, 12);
            lvShowText.Name = "lvShowText";
            lvShowText.Size = new Size(421, 235);
            lvShowText.TabIndex = 0;
            lvShowText.UseCompatibleStateImageBehavior = false;
            lvShowText.View = View.List;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(170, 266);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(104, 35);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // button1
            // 
            button1.Location = new Point(318, 266);
            button1.Name = "button1";
            button1.Size = new Size(104, 35);
            button1.TabIndex = 2;
            button1.Text = "_regis";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 313);
            Controls.Add(button1);
            Controls.Add(btnOpen);
            Controls.Add(lvShowText);
            Name = "Form1";
            Text = "FrmOpenTextFile";
            ResumeLayout(false);
        }

        #endregion

        private ListView lvShowText;
        private Button btnOpen;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private Button button1;
    }
}
