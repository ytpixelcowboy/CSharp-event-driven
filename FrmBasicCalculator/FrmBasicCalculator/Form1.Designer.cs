namespace FrmBasicCalculator
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
            tboxNum1 = new TextBox();
            tboxNum2 = new TextBox();
            cboxOperations = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            txtResult = new Label();
            button1 = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(163, 30);
            label1.TabIndex = 0;
            label1.Text = "Basic Calculator";
            // 
            // tboxNum1
            // 
            tboxNum1.Font = new Font("Segoe UI", 12F);
            tboxNum1.Location = new Point(12, 56);
            tboxNum1.Name = "tboxNum1";
            tboxNum1.Size = new Size(289, 29);
            tboxNum1.TabIndex = 1;
            // 
            // tboxNum2
            // 
            tboxNum2.Font = new Font("Segoe UI", 12F);
            tboxNum2.Location = new Point(12, 142);
            tboxNum2.Name = "tboxNum2";
            tboxNum2.Size = new Size(289, 29);
            tboxNum2.TabIndex = 2;
            // 
            // cboxOperations
            // 
            cboxOperations.FormattingEnabled = true;
            cboxOperations.Location = new Point(123, 101);
            cboxOperations.Name = "cboxOperations";
            cboxOperations.Size = new Size(63, 23);
            cboxOperations.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(txtResult);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(12, 191);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(289, 93);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(8, 5);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 5;
            label2.Text = "Total";
            // 
            // txtResult
            // 
            txtResult.AutoSize = true;
            txtResult.Font = new Font("Segoe UI", 24F);
            txtResult.ForeColor = Color.ForestGreen;
            txtResult.Location = new Point(8, 30);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(33, 45);
            txtResult.TabIndex = 6;
            txtResult.Text = "-";
            // 
            // button1
            // 
            button1.Location = new Point(105, 294);
            button1.Name = "button1";
            button1.Size = new Size(96, 34);
            button1.TabIndex = 5;
            button1.Text = "Compute";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 340);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(cboxOperations);
            Controls.Add(tboxNum2);
            Controls.Add(tboxNum1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "FrmBasicCalculator";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tboxNum1;
        private TextBox tboxNum2;
        private ComboBox cboxOperations;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Label txtResult;
        private Button button1;
    }
}
