namespace Calculator.WinForms
{
    partial class Main_Form
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
            this.appTabs = new System.Windows.Forms.TabControl();
            this.calculatorTab = new System.Windows.Forms.TabPage();
            this.historyTab = new System.Windows.Forms.TabPage();
            this.convertLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.appTabs.SuspendLayout();
            this.calculatorTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // appTabs
            // 
            this.appTabs.Controls.Add(this.calculatorTab);
            this.appTabs.Controls.Add(this.historyTab);
            this.appTabs.Location = new System.Drawing.Point(10, 11);
            this.appTabs.Name = "appTabs";
            this.appTabs.SelectedIndex = 0;
            this.appTabs.Size = new System.Drawing.Size(437, 476);
            this.appTabs.TabIndex = 0;
            // 
            // calculatorTab
            // 
            this.calculatorTab.Controls.Add(this.textBox1);
            this.calculatorTab.Controls.Add(this.convertLabel);
            this.calculatorTab.Location = new System.Drawing.Point(4, 24);
            this.calculatorTab.Name = "calculatorTab";
            this.calculatorTab.Padding = new System.Windows.Forms.Padding(3);
            this.calculatorTab.Size = new System.Drawing.Size(429, 448);
            this.calculatorTab.TabIndex = 0;
            this.calculatorTab.Text = "Calculator";
            this.calculatorTab.UseVisualStyleBackColor = true;
            // 
            // historyTab
            // 
            this.historyTab.Location = new System.Drawing.Point(4, 24);
            this.historyTab.Name = "historyTab";
            this.historyTab.Padding = new System.Windows.Forms.Padding(3);
            this.historyTab.Size = new System.Drawing.Size(777, 404);
            this.historyTab.TabIndex = 1;
            this.historyTab.Text = "History";
            this.historyTab.UseVisualStyleBackColor = true;
            // 
            // convertLabel
            // 
            this.convertLabel.AutoSize = true;
            this.convertLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.convertLabel.Location = new System.Drawing.Point(23, 25);
            this.convertLabel.Name = "convertLabel";
            this.convertLabel.Size = new System.Drawing.Size(72, 21);
            this.convertLabel.TabIndex = 0;
            this.convertLabel.Text = "Convert: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 23);
            this.textBox1.TabIndex = 1;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 499);
            this.Controls.Add(this.appTabs);
            this.Name = "Main_Form";
            this.Text = "Unit Calculator";
            this.appTabs.ResumeLayout(false);
            this.calculatorTab.ResumeLayout(false);
            this.calculatorTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl appTabs;
        private System.Windows.Forms.TabPage calculatorTab;
        private System.Windows.Forms.TabPage historyTab;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label convertLabel;
    }
}