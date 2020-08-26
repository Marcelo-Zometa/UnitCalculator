namespace Calculator.WinForms
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
            this.lbl_enterAmount = new System.Windows.Forms.Label();
            this.txt_EnterAmount = new System.Windows.Forms.TextBox();
            this.lbl_ConvertTo = new System.Windows.Forms.Label();
            this.combo_Units = new System.Windows.Forms.ComboBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_enterAmount
            // 
            this.lbl_enterAmount.AutoSize = true;
            this.lbl_enterAmount.Location = new System.Drawing.Point(23, 141);
            this.lbl_enterAmount.Name = "lbl_enterAmount";
            this.lbl_enterAmount.Size = new System.Drawing.Size(139, 15);
            this.lbl_enterAmount.TabIndex = 0;
            this.lbl_enterAmount.Text = "Enter amount to convert:";
            this.lbl_enterAmount.Click += new System.EventHandler(this.label_Click);
            // 
            // txt_EnterAmount
            // 
            this.txt_EnterAmount.Location = new System.Drawing.Point(182, 138);
            this.txt_EnterAmount.Name = "txt_EnterAmount";
            this.txt_EnterAmount.Size = new System.Drawing.Size(100, 23);
            this.txt_EnterAmount.TabIndex = 1;
            // 
            // lbl_ConvertTo
            // 
            this.lbl_ConvertTo.AutoSize = true;
            this.lbl_ConvertTo.Location = new System.Drawing.Point(23, 185);
            this.lbl_ConvertTo.Name = "lbl_ConvertTo";
            this.lbl_ConvertTo.Size = new System.Drawing.Size(132, 15);
            this.lbl_ConvertTo.TabIndex = 2;
            this.lbl_ConvertTo.Text = "Enter unit to convert to:";
            // 
            // combo_Units
            // 
            this.combo_Units.FormattingEnabled = true;
            this.combo_Units.Items.AddRange(new object[] {
            "to Inches",
            "to feet",
            "to meter",
            "to kilometers"});
            this.combo_Units.Location = new System.Drawing.Point(182, 185);
            this.combo_Units.Name = "combo_Units";
            this.combo_Units.Size = new System.Drawing.Size(100, 23);
            this.combo_Units.TabIndex = 3;
            this.combo_Units.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(23, 249);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(288, 23);
            this.btn_Calculate.TabIndex = 4;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.combo_Units);
            this.Controls.Add(this.lbl_ConvertTo);
            this.Controls.Add(this.txt_EnterAmount);
            this.Controls.Add(this.lbl_enterAmount);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_enterAmount;
        private System.Windows.Forms.TextBox txt_EnterAmount;
        private System.Windows.Forms.Label lbl_ConvertTo;
        private System.Windows.Forms.ComboBox combo_Units;
        private System.Windows.Forms.Button btn_Calculate;
    }
}

