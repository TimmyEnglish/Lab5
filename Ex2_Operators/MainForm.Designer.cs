namespace Ex2_Operators
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
            txtAge = new TextBox();
            btnCheck = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtAge
            // 
            txtAge.ForeColor = Color.Silver;
            txtAge.Location = new Point(29, 29);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(150, 31);
            txtAge.TabIndex = 0;
            txtAge.Text = "Введіть ваш вік";
            txtAge.Enter += txtAge_Enter;
            txtAge.Leave += txtAge_Leave;
            // 
            // btnCheck
            // 
            btnCheck.FlatStyle = FlatStyle.Flat;
            btnCheck.Location = new Point(29, 96);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(150, 34);
            btnCheck.TabIndex = 1;
            btnCheck.Text = "Перевірити";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 12F);
            lblResult.Location = new Point(29, 171);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 32);
            lblResult.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 340);
            Controls.Add(lblResult);
            Controls.Add(btnCheck);
            Controls.Add(txtAge);
            Name = "Form2";
            Text = "AgeCategory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAge;
        private Button btnCheck;
        private Label lblResult;
    }
}
