namespace Ex3_Loops
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
            lbTable = new ListBox();
            btnGenerate = new Button();
            txtInput = new TextBox();
            SuspendLayout();
            // 
            // lbTable
            // 
            lbTable.FormattingEnabled = true;
            lbTable.ItemHeight = 25;
            lbTable.Location = new Point(304, 38);
            lbTable.Name = "lbTable";
            lbTable.Size = new Size(372, 379);
            lbTable.TabIndex = 0;
            // 
            // btnGenerate
            // 
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Location = new Point(58, 219);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(180, 32);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Створити таблицю";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtInput
            // 
            txtInput.ForeColor = Color.Silver;
            txtInput.Location = new Point(58, 97);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(180, 31);
            txtInput.TabIndex = 2;
            txtInput.Text = "Введіть число";
            txtInput.Enter += txtInput_Enter;
            txtInput.Leave += txtInput_Leave;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 450);
            Controls.Add(txtInput);
            Controls.Add(btnGenerate);
            Controls.Add(lbTable);
            Name = "Form3";
            Text = "MultiplicationTable";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbTable;
        private Button btnGenerate;
        private TextBox txtInput;
    }
}
