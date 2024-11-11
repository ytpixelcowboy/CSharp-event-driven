namespace FrmLab1
{
    partial class FrmLab1
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
            txtInput = new TextBox();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(81, 42);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(250, 121);
            txtInput.TabIndex = 3;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(149, 208);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(110, 35);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // FrmLab1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 283);
            Controls.Add(btnCreate);
            Controls.Add(txtInput);
            Name = "FrmLab1";
            Text = "FrmLab1";
            Load += FrmLab1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtInput;
        private Button btnCreate;
    }
}
