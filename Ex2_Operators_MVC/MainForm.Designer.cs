namespace Ex2_Operators_MVC
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
            lblResult = new Label();
            btnCheck = new Button();
            txtAge = new TextBox();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 12F);
            lblResult.Location = new Point(35, 205);
            lblResult.Margin = new Padding(4, 0, 4, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 38);
            lblResult.TabIndex = 5;
            // 
            // btnCheck
            // 
            btnCheck.FlatStyle = FlatStyle.Flat;
            btnCheck.Location = new Point(35, 115);
            btnCheck.Margin = new Padding(4);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(180, 41);
            btnCheck.TabIndex = 4;
            btnCheck.Text = "Перевірити";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // txtAge
            // 
            txtAge.ForeColor = Color.Silver;
            txtAge.Location = new Point(35, 35);
            txtAge.Margin = new Padding(4);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(179, 35);
            txtAge.TabIndex = 3;
            txtAge.Text = "Введіть ваш вік";
            txtAge.Enter += txtAge_Enter;
            txtAge.Leave += txtAge_Leave;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(613, 408);
            Controls.Add(lblResult);
            Controls.Add(btnCheck);
            Controls.Add(txtAge);
            Name = "MainForm";
            Text = "AgeCategory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private Button btnCheck;
        private TextBox txtAge;
    }
}
