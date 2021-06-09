
namespace CurrencyConverterApp
{
    partial class AddExchangeRateForm
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
            this.newCurrencyTextBox = new System.Windows.Forms.TextBox();
            this.addExchangeRateButton = new System.Windows.Forms.Button();
            this.newExchangeRateComboBox = new System.Windows.Forms.ComboBox();
            this.changeCurrencyLabel = new System.Windows.Forms.Label();
            this.changeToLabel = new System.Windows.Forms.Label();
            this.currentRateLabel = new System.Windows.Forms.Label();
            this.currentRateValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newCurrencyTextBox
            // 
            this.newCurrencyTextBox.Location = new System.Drawing.Point(159, 54);
            this.newCurrencyTextBox.Name = "newCurrencyTextBox";
            this.newCurrencyTextBox.Size = new System.Drawing.Size(100, 23);
            this.newCurrencyTextBox.TabIndex = 2;
            // 
            // addExchangeRateButton
            // 
            this.addExchangeRateButton.Location = new System.Drawing.Point(283, 54);
            this.addExchangeRateButton.Name = "addExchangeRateButton";
            this.addExchangeRateButton.Size = new System.Drawing.Size(75, 23);
            this.addExchangeRateButton.TabIndex = 4;
            this.addExchangeRateButton.Text = "save";
            this.addExchangeRateButton.UseVisualStyleBackColor = true;
            this.addExchangeRateButton.Click += new System.EventHandler(this.addExchangeRateButton_Click);
            // 
            // newExchangeRateComboBox
            // 
            this.newExchangeRateComboBox.FormattingEnabled = true;
            this.newExchangeRateComboBox.Location = new System.Drawing.Point(12, 54);
            this.newExchangeRateComboBox.Name = "newExchangeRateComboBox";
            this.newExchangeRateComboBox.Size = new System.Drawing.Size(121, 23);
            this.newExchangeRateComboBox.TabIndex = 5;
            this.newExchangeRateComboBox.SelectedValueChanged += new System.EventHandler(this.newExchangeRateComboBox_SelectedValueChanged);
            // 
            // changeCurrencyLabel
            // 
            this.changeCurrencyLabel.AutoSize = true;
            this.changeCurrencyLabel.Location = new System.Drawing.Point(12, 36);
            this.changeCurrencyLabel.Name = "changeCurrencyLabel";
            this.changeCurrencyLabel.Size = new System.Drawing.Size(91, 15);
            this.changeCurrencyLabel.TabIndex = 6;
            this.changeCurrencyLabel.Text = "Change Rate of:";
            // 
            // changeToLabel
            // 
            this.changeToLabel.AutoSize = true;
            this.changeToLabel.Location = new System.Drawing.Point(159, 36);
            this.changeToLabel.Name = "changeToLabel";
            this.changeToLabel.Size = new System.Drawing.Size(65, 15);
            this.changeToLabel.TabIndex = 7;
            this.changeToLabel.Text = "Change to:";
            // 
            // currentRateLabel
            // 
            this.currentRateLabel.AutoSize = true;
            this.currentRateLabel.Location = new System.Drawing.Point(3, 90);
            this.currentRateLabel.Name = "currentRateLabel";
            this.currentRateLabel.Size = new System.Drawing.Size(76, 15);
            this.currentRateLabel.TabIndex = 8;
            this.currentRateLabel.Text = "Current Rate:";
            // 
            // currentRateValueLabel
            // 
            this.currentRateValueLabel.AutoSize = true;
            this.currentRateValueLabel.Location = new System.Drawing.Point(75, 90);
            this.currentRateValueLabel.Name = "currentRateValueLabel";
            this.currentRateValueLabel.Size = new System.Drawing.Size(76, 15);
            this.currentRateValueLabel.TabIndex = 9;
            this.currentRateValueLabel.Text = "current value";
            // 
            // AddExchangeRateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 161);
            this.Controls.Add(this.currentRateValueLabel);
            this.Controls.Add(this.currentRateLabel);
            this.Controls.Add(this.changeToLabel);
            this.Controls.Add(this.changeCurrencyLabel);
            this.Controls.Add(this.newExchangeRateComboBox);
            this.Controls.Add(this.addExchangeRateButton);
            this.Controls.Add(this.newCurrencyTextBox);
            this.Name = "AddExchangeRateForm";
            this.Text = "Exchange Rate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox newCurrencyTextBox;
        private System.Windows.Forms.Button addExchangeRateButton;
        private System.Windows.Forms.ComboBox newExchangeRateComboBox;
        private System.Windows.Forms.Label changeCurrencyLabel;
        private System.Windows.Forms.Label changeToLabel;
        private System.Windows.Forms.Label currentRateLabel;
        private System.Windows.Forms.Label currentRateValueLabel;
    }
}