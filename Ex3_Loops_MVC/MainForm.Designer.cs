namespace Ex3_Loops_MVC
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
            txtInput = new TextBox();
            btnGenerate = new Button();
            lbTable = new ListBox();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.ForeColor = Color.Silver;
            txtInput.Location = new Point(53, 113);
            txtInput.Margin = new Padding(4);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(215, 35);
            txtInput.TabIndex = 5;
            txtInput.Text = "Введіть число";
            txtInput.Enter += txtInput_Enter;
            txtInput.Leave += txtInput_Leave;
            // 
            // btnGenerate
            // 
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Location = new Point(53, 260);
            btnGenerate.Margin = new Padding(4);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(216, 38);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "Створити таблицю";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += new EventHandler(btnGenerate_Click);
            // 
            // lbTable
            // 
            lbTable.FormattingEnabled = true;
            lbTable.ItemHeight = 30;
            lbTable.Location = new Point(348, 43);
            lbTable.Margin = new Padding(4);
            lbTable.Name = "lbTable";
            lbTable.Size = new Size(446, 454);
            lbTable.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 540);
            Controls.Add(txtInput);
            Controls.Add(btnGenerate);
            Controls.Add(lbTable);
            Name = "MainForm";
            Text = "MultiplicationTable";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnGenerate;
        private ListBox lbTable;
    }
}
