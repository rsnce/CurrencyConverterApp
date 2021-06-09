
namespace CurrencyConverterApp
{
    partial class CurrencyConverterForm
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
            this.mainLabel = new System.Windows.Forms.Label();
            this.firstCurrencyLabel = new System.Windows.Forms.Label();
            this.secondCurrencyLabel = new System.Windows.Forms.Label();
            this.firstCurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.secondCurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.firstCurrencyTextBox = new System.Windows.Forms.TextBox();
            this.secondCurrencyTextBox = new System.Windows.Forms.TextBox();
            this.exchangeButton = new System.Windows.Forms.Button();
            this.changeConversionButton = new System.Windows.Forms.Button();
            this.addCurrencyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Location = new System.Drawing.Point(268, 9);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(234, 30);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Currency Exchange App";
            // 
            // firstCurrencyLabel
            // 
            this.firstCurrencyLabel.AutoSize = true;
            this.firstCurrencyLabel.Location = new System.Drawing.Point(172, 90);
            this.firstCurrencyLabel.Name = "firstCurrencyLabel";
            this.firstCurrencyLabel.Size = new System.Drawing.Size(112, 30);
            this.firstCurrencyLabel.TabIndex = 1;
            this.firstCurrencyLabel.Text = "Currency 1";
            // 
            // secondCurrencyLabel
            // 
            this.secondCurrencyLabel.AutoSize = true;
            this.secondCurrencyLabel.Location = new System.Drawing.Point(455, 90);
            this.secondCurrencyLabel.Name = "secondCurrencyLabel";
            this.secondCurrencyLabel.Size = new System.Drawing.Size(112, 30);
            this.secondCurrencyLabel.TabIndex = 2;
            this.secondCurrencyLabel.Text = "Currency 2";
            // 
            // firstCurrencyComboBox
            // 
            this.firstCurrencyComboBox.FormattingEnabled = true;
            this.firstCurrencyComboBox.Location = new System.Drawing.Point(163, 136);
            this.firstCurrencyComboBox.Name = "firstCurrencyComboBox";
            this.firstCurrencyComboBox.Size = new System.Drawing.Size(130, 38);
            this.firstCurrencyComboBox.TabIndex = 3;
            // 
            // secondCurrencyComboBox
            // 
            this.secondCurrencyComboBox.FormattingEnabled = true;
            this.secondCurrencyComboBox.Location = new System.Drawing.Point(446, 136);
            this.secondCurrencyComboBox.Name = "secondCurrencyComboBox";
            this.secondCurrencyComboBox.Size = new System.Drawing.Size(130, 38);
            this.secondCurrencyComboBox.TabIndex = 4;
            // 
            // firstCurrencyTextBox
            // 
            this.firstCurrencyTextBox.Location = new System.Drawing.Point(184, 203);
            this.firstCurrencyTextBox.Name = "firstCurrencyTextBox";
            this.firstCurrencyTextBox.Size = new System.Drawing.Size(100, 35);
            this.firstCurrencyTextBox.TabIndex = 5;
            // 
            // secondCurrencyTextBox
            // 
            this.secondCurrencyTextBox.Location = new System.Drawing.Point(455, 203);
            this.secondCurrencyTextBox.Name = "secondCurrencyTextBox";
            this.secondCurrencyTextBox.Size = new System.Drawing.Size(100, 35);
            this.secondCurrencyTextBox.TabIndex = 6;
            // 
            // exchangeButton
            // 
            this.exchangeButton.Location = new System.Drawing.Point(300, 269);
            this.exchangeButton.Name = "exchangeButton";
            this.exchangeButton.Size = new System.Drawing.Size(139, 38);
            this.exchangeButton.TabIndex = 7;
            this.exchangeButton.Text = "umrechnen";
            this.exchangeButton.UseVisualStyleBackColor = true;
            this.exchangeButton.Click += new System.EventHandler(this.exchangeButton_Click);
            // 
            // changeConversionButton
            // 
            this.changeConversionButton.Location = new System.Drawing.Point(35, 372);
            this.changeConversionButton.Name = "changeConversionButton";
            this.changeConversionButton.Size = new System.Drawing.Size(168, 41);
            this.changeConversionButton.TabIndex = 8;
            this.changeConversionButton.Text = "Enter Manually";
            this.changeConversionButton.UseVisualStyleBackColor = true;
            this.changeConversionButton.Click += new System.EventHandler(this.changeConversionButton_Click);
            // 
            // addCurrencyButton
            // 
            this.addCurrencyButton.Location = new System.Drawing.Point(580, 372);
            this.addCurrencyButton.Name = "addCurrencyButton";
            this.addCurrencyButton.Size = new System.Drawing.Size(208, 40);
            this.addCurrencyButton.TabIndex = 9;
            this.addCurrencyButton.Text = "Add New Currency";
            this.addCurrencyButton.UseVisualStyleBackColor = true;
            this.addCurrencyButton.Click += new System.EventHandler(this.addCurrencyButton_Click);
            // 
            // CurrencyConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addCurrencyButton);
            this.Controls.Add(this.changeConversionButton);
            this.Controls.Add(this.exchangeButton);
            this.Controls.Add(this.secondCurrencyTextBox);
            this.Controls.Add(this.firstCurrencyTextBox);
            this.Controls.Add(this.secondCurrencyComboBox);
            this.Controls.Add(this.firstCurrencyComboBox);
            this.Controls.Add(this.secondCurrencyLabel);
            this.Controls.Add(this.firstCurrencyLabel);
            this.Controls.Add(this.mainLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "CurrencyConverterForm";
            this.Text = "Currency Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label firstCurrencyLabel;
        private System.Windows.Forms.Label secondCurrencyLabel;
        private System.Windows.Forms.ComboBox firstCurrencyComboBox;
        private System.Windows.Forms.ComboBox secondCurrencyComboBox;
        private System.Windows.Forms.TextBox firstCurrencyTextBox;
        private System.Windows.Forms.TextBox secondCurrencyTextBox;
        private System.Windows.Forms.Button exchangeButton;
        private System.Windows.Forms.Button changeConversionButton;
        private System.Windows.Forms.Button addCurrencyButton;
    }
}

