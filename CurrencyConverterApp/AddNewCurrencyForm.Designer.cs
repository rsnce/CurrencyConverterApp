
namespace CurrencyConverterApp
{
    partial class AddNewCurrencyForm
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
            this.currencyNameLabel = new System.Windows.Forms.Label();
            this.currencyRateLabel = new System.Windows.Forms.Label();
            this.currencyNameTextBox = new System.Windows.Forms.TextBox();
            this.currencyRateTextBox = new System.Windows.Forms.TextBox();
            this.saveCurrencyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currencyNameLabel
            // 
            this.currencyNameLabel.AutoSize = true;
            this.currencyNameLabel.Location = new System.Drawing.Point(40, 24);
            this.currencyNameLabel.Name = "currencyNameLabel";
            this.currencyNameLabel.Size = new System.Drawing.Size(93, 15);
            this.currencyNameLabel.TabIndex = 0;
            this.currencyNameLabel.Text = "Currency Name:";
            // 
            // currencyRateLabel
            // 
            this.currencyRateLabel.AutoSize = true;
            this.currencyRateLabel.Location = new System.Drawing.Point(219, 24);
            this.currencyRateLabel.Name = "currencyRateLabel";
            this.currencyRateLabel.Size = new System.Drawing.Size(33, 15);
            this.currencyRateLabel.TabIndex = 1;
            this.currencyRateLabel.Text = "Rate:";
            // 
            // currencyNameTextBox
            // 
            this.currencyNameTextBox.Location = new System.Drawing.Point(40, 56);
            this.currencyNameTextBox.Name = "currencyNameTextBox";
            this.currencyNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.currencyNameTextBox.TabIndex = 2;
            // 
            // currencyRateTextBox
            // 
            this.currencyRateTextBox.Location = new System.Drawing.Point(186, 56);
            this.currencyRateTextBox.Name = "currencyRateTextBox";
            this.currencyRateTextBox.Size = new System.Drawing.Size(100, 23);
            this.currencyRateTextBox.TabIndex = 3;
            // 
            // saveCurrencyButton
            // 
            this.saveCurrencyButton.Location = new System.Drawing.Point(128, 103);
            this.saveCurrencyButton.Name = "saveCurrencyButton";
            this.saveCurrencyButton.Size = new System.Drawing.Size(75, 23);
            this.saveCurrencyButton.TabIndex = 4;
            this.saveCurrencyButton.Text = "Add";
            this.saveCurrencyButton.UseVisualStyleBackColor = true;
            this.saveCurrencyButton.Click += new System.EventHandler(this.saveCurrencyButton_Click);
            // 
            // AddNewCurrencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 160);
            this.Controls.Add(this.saveCurrencyButton);
            this.Controls.Add(this.currencyRateTextBox);
            this.Controls.Add(this.currencyNameTextBox);
            this.Controls.Add(this.currencyRateLabel);
            this.Controls.Add(this.currencyNameLabel);
            this.Name = "AddNewCurrencyForm";
            this.Text = "Add New Currency";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currencyNameLabel;
        private System.Windows.Forms.Label currencyRateLabel;
        private System.Windows.Forms.TextBox currencyNameTextBox;
        private System.Windows.Forms.TextBox currencyRateTextBox;
        private System.Windows.Forms.Button saveCurrencyButton;
    }
}