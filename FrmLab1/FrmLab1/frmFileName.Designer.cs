namespace FrmLab1
{
    partial class frmFileName
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
            txtFileName = new TextBox();
            btnOkay = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 3;
            label1.Text = "Enter File Name";
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(12, 53);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(361, 23);
            txtFileName.TabIndex = 2;
            // 
            // btnOkay
            // 
            btnOkay.Location = new Point(130, 105);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(110, 35);
            btnOkay.TabIndex = 4;
            btnOkay.Text = "Okay";
            btnOkay.UseVisualStyleBackColor = true;
            btnOkay.Click += btnOkay_Click;
            // 
            // frmFileName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 168);
            Controls.Add(btnOkay);
            Controls.Add(label1);
            Controls.Add(txtFileName);
            Name = "frmFileName";
            Text = "frmFileName";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtFileName;
        private Button btnOkay;
    }
}