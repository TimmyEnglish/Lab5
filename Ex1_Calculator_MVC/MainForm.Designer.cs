namespace Ex1_Calculator_MVC
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
            txtResult = new TextBox();
            btnAdd = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btnSubtract = new Button();
            txtNumber2 = new TextBox();
            txtNumber1 = new TextBox();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtResult.ForeColor = Color.Silver;
            txtResult.Location = new Point(296, 259);
            txtResult.Margin = new Padding(4);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(368, 51);
            txtResult.TabIndex = 16;
            txtResult.Text = "Результат";
            txtResult.Enter += txtResult_Enter;
            txtResult.Leave += txtResult_Leave;
            txtResult.TextChanged += txtResult_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAdd.Location = new Point(296, 354);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(66, 66);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDivide
            // 
            btnDivide.FlatStyle = FlatStyle.Flat;
            btnDivide.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDivide.Location = new Point(599, 354);
            btnDivide.Margin = new Padding(4);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(66, 66);
            btnDivide.TabIndex = 14;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.FlatStyle = FlatStyle.Flat;
            btnMultiply.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnMultiply.Location = new Point(498, 354);
            btnMultiply.Margin = new Padding(4);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(66, 66);
            btnMultiply.TabIndex = 13;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.FlatStyle = FlatStyle.Flat;
            btnSubtract.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSubtract.Location = new Point(397, 354);
            btnSubtract.Margin = new Padding(4);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(66, 66);
            btnSubtract.TabIndex = 12;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // txtNumber2
            // 
            txtNumber2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtNumber2.ForeColor = Color.Silver;
            txtNumber2.Location = new Point(296, 165);
            txtNumber2.Margin = new Padding(4);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(368, 51);
            txtNumber2.TabIndex = 10;
            txtNumber2.Text = "Друге число";
            txtNumber2.Enter += txtNumber2_Enter;
            txtNumber2.Leave += txtNumber2_Leave;
            // 
            // txtNumber1
            // 
            txtNumber1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtNumber1.ForeColor = Color.Silver;
            txtNumber1.Location = new Point(296, 70);
            txtNumber1.Margin = new Padding(4);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(368, 51);
            txtNumber1.TabIndex = 9;
            txtNumber1.Text = "Перше число";
            txtNumber1.Enter += txtNumber1_Enter;
            txtNumber1.Leave += txtNumber1_Leave;
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
            Name = "MainForm";
            Text = "BetterCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResult;
        private Button btnAdd;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnSubtract;
        private TextBox txtNumber2;
        private TextBox txtNumber1;
    }
}
