namespace Ex1_Calculator
{
    partial class MainForm
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
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnAdd = new Button();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // txtNumber1
            // 
            txtNumber1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtNumber1.ForeColor = Color.Silver;
            txtNumber1.Location = new Point(296, 71);
            txtNumber1.Margin = new Padding(4, 4, 4, 4);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(368, 51);
            txtNumber1.TabIndex = 0;
            txtNumber1.Text = "Перше число";
            txtNumber1.Enter += txtNumber1_Enter;
            txtNumber1.Leave += txtNumber1_Leave;
            // 
            // txtNumber2
            // 
            txtNumber2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtNumber2.ForeColor = Color.Silver;
            txtNumber2.Location = new Point(296, 166);
            txtNumber2.Margin = new Padding(4, 4, 4, 4);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(368, 51);
            txtNumber2.TabIndex = 1;
            txtNumber2.Text = "Друге число";
            txtNumber2.Enter += txtNumber2_Enter;
            txtNumber2.Leave += txtNumber2_Leave;
            // 
            // btnSubtract
            // 
            btnSubtract.FlatStyle = FlatStyle.Flat;
            btnSubtract.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSubtract.Location = new Point(397, 355);
            btnSubtract.Margin = new Padding(4, 4, 4, 4);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(66, 66);
            btnSubtract.TabIndex = 4;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.FlatStyle = FlatStyle.Flat;
            btnMultiply.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnMultiply.Location = new Point(498, 355);
            btnMultiply.Margin = new Padding(4, 4, 4, 4);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(66, 66);
            btnMultiply.TabIndex = 5;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.FlatStyle = FlatStyle.Flat;
            btnDivide.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDivide.Location = new Point(599, 355);
            btnDivide.Margin = new Padding(4, 4, 4, 4);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(66, 66);
            btnDivide.TabIndex = 6;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAdd.Location = new Point(296, 355);
            btnAdd.Margin = new Padding(4, 4, 4, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(66, 66);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtResult.ForeColor = Color.Silver;
            txtResult.Location = new Point(296, 260);
            txtResult.Margin = new Padding(4, 4, 4, 4);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(368, 51);
            txtResult.TabIndex = 8;
            txtResult.Text = "Результат";
            txtResult.TextChanged += txtResult_TextChanged;
            txtResult.Enter += txtResult_Enter;
            txtResult.Leave += txtResult_Leave;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 540);
            Controls.Add(txtResult);
            Controls.Add(btnAdd);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "MainForm";
            Text = "BadCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnAdd;
        private TextBox txtResult;
    }
}
