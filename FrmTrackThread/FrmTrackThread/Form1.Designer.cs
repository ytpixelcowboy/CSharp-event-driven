namespace FrmTrackThread
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
            txtState = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtState
            // 
            txtState.Font = new Font("Segoe UI", 18F);
            txtState.Location = new Point(1, 83);
            txtState.Name = "txtState";
            txtState.Size = new Size(377, 36);
            txtState.TabIndex = 0;
            txtState.Text = "-Thread Starts-";
            txtState.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(140, 139);
            button1.Name = "button1";
            button1.Size = new Size(104, 41);
            button1.TabIndex = 1;
            button1.Text = "Run";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 228);
            Controls.Add(button1);
            Controls.Add(txtState);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label txtState;
        private Button button1;
    }
}
