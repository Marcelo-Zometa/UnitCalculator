namespace Calculator.WinForms._2
{
    partial class MainForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCalculator = new System.Windows.Forms.TabPage();
            this.textAnswer = new System.Windows.Forms.TextBox();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.comboConvertTo = new System.Windows.Forms.ComboBox();
            this.ToLabel = new System.Windows.Forms.Label();
            this.comboOriginalUnit = new System.Windows.Forms.ComboBox();
            this.numToConvert = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.gridHistory = new System.Windows.Forms.DataGridView();
            this.OriginalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConvertedValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConvertedUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabCalculator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numToConvert)).BeginInit();
            this.tabHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCalculator);
            this.tabControl.Controls.Add(this.tabHistory);
            this.tabControl.Location = new System.Drawing.Point(16, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(403, 420);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.gridHistoryTabIndexChanged);
            this.tabControl.TabIndexChanged += new System.EventHandler(this.gridHistoryTabIndexChanged);
            // 
            // tabCalculator
            // 
            this.tabCalculator.BackColor = System.Drawing.Color.Linen;
            this.tabCalculator.Controls.Add(this.textAnswer);
            this.tabCalculator.Controls.Add(this.labelAnswer);
            this.tabCalculator.Controls.Add(this.buttonCalculate);
            this.tabCalculator.Controls.Add(this.comboConvertTo);
            this.tabCalculator.Controls.Add(this.ToLabel);
            this.tabCalculator.Controls.Add(this.comboOriginalUnit);
            this.tabCalculator.Controls.Add(this.numToConvert);
            this.tabCalculator.Controls.Add(this.label1);
            this.tabCalculator.Location = new System.Drawing.Point(4, 22);
            this.tabCalculator.Name = "tabCalculator";
            this.tabCalculator.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalculator.Size = new System.Drawing.Size(395, 394);
            this.tabCalculator.TabIndex = 0;
            this.tabCalculator.Text = "Calculator";
            // 
            // textAnswer
            // 
            this.textAnswer.AllowDrop = true;
            this.textAnswer.Location = new System.Drawing.Point(107, 219);
            this.textAnswer.Name = "textAnswer";
            this.textAnswer.ReadOnly = true;
            this.textAnswer.Size = new System.Drawing.Size(242, 20);
            this.textAnswer.TabIndex = 7;
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer.Location = new System.Drawing.Point(30, 221);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(61, 18);
            this.labelAnswer.TabIndex = 6;
            this.labelAnswer.Text = "Answer:";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(28, 152);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(321, 38);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.CalculateBtnClicked);
            // 
            // comboConvertTo
            // 
            this.comboConvertTo.BackColor = System.Drawing.SystemColors.Control;
            this.comboConvertTo.FormattingEnabled = true;
            this.comboConvertTo.Items.AddRange(new object[] {
            "cm",
            "ft",
            "in",
            "km",
            "m",
            "miles"});
            this.comboConvertTo.Location = new System.Drawing.Point(89, 96);
            this.comboConvertTo.Name = "comboConvertTo";
            this.comboConvertTo.Size = new System.Drawing.Size(60, 21);
            this.comboConvertTo.TabIndex = 4;
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.Location = new System.Drawing.Point(25, 95);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(30, 18);
            this.ToLabel.TabIndex = 3;
            this.ToLabel.Text = "To:";
            // 
            // comboOriginalUnit
            // 
            this.comboOriginalUnit.BackColor = System.Drawing.SystemColors.Control;
            this.comboOriginalUnit.FormattingEnabled = true;
            this.comboOriginalUnit.Items.AddRange(new object[] {
            "cm",
            "ft",
            "in",
            "km",
            "m",
            "mile"});
            this.comboOriginalUnit.Location = new System.Drawing.Point(186, 44);
            this.comboOriginalUnit.Name = "comboOriginalUnit";
            this.comboOriginalUnit.Size = new System.Drawing.Size(47, 21);
            this.comboOriginalUnit.TabIndex = 2;
            // 
            // numToConvert
            // 
            this.numToConvert.BackColor = System.Drawing.SystemColors.Control;
            this.numToConvert.DecimalPlaces = 3;
            this.numToConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numToConvert.Location = new System.Drawing.Point(89, 43);
            this.numToConvert.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numToConvert.Name = "numToConvert";
            this.numToConvert.Size = new System.Drawing.Size(91, 23);
            this.numToConvert.TabIndex = 1;
            this.numToConvert.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convert:";
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.gridHistory);
            this.tabHistory.Location = new System.Drawing.Point(4, 22);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistory.Size = new System.Drawing.Size(395, 394);
            this.tabHistory.TabIndex = 1;
            this.tabHistory.Text = "History";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // gridHistory
            // 
            this.gridHistory.AllowUserToAddRows = false;
            this.gridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OriginalValue,
            this.OriginalUnit,
            this.ConvertedValue,
            this.ConvertedUnit});
            this.gridHistory.Location = new System.Drawing.Point(0, 6);
            this.gridHistory.Name = "gridHistory";
            this.gridHistory.Size = new System.Drawing.Size(395, 374);
            this.gridHistory.TabIndex = 1;
            this.gridHistory.TabIndexChanged += new System.EventHandler(this.gridHistoryTabIndexChanged);
            // 
            // OriginalValue
            // 
            this.OriginalValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OriginalValue.HeaderText = "Original Value";
            this.OriginalValue.Name = "OriginalValue";
            this.OriginalValue.ReadOnly = true;
            // 
            // OriginalUnit
            // 
            this.OriginalUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OriginalUnit.HeaderText = "Unit";
            this.OriginalUnit.Name = "OriginalUnit";
            this.OriginalUnit.ReadOnly = true;
            // 
            // ConvertedValue
            // 
            this.ConvertedValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ConvertedValue.HeaderText = "Converted Value";
            this.ConvertedValue.Name = "ConvertedValue";
            this.ConvertedValue.ReadOnly = true;
            // 
            // ConvertedUnit
            // 
            this.ConvertedUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ConvertedUnit.HeaderText = "Unit";
            this.ConvertedUnit.Name = "ConvertedUnit";
            this.ConvertedUnit.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 457);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Distance Unit Converter";
            this.tabControl.ResumeLayout(false);
            this.tabCalculator.ResumeLayout(false);
            this.tabCalculator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numToConvert)).EndInit();
            this.tabHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCalculator;
        private System.Windows.Forms.ComboBox comboOriginalUnit;
        private System.Windows.Forms.NumericUpDown numToConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.TextBox textAnswer;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.ComboBox comboConvertTo;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.DataGridView gridHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConvertedValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConvertedUnit;
    }
}

