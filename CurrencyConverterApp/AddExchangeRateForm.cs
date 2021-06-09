using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverterApp
{
    public partial class AddExchangeRateForm : Form
    {
        public List<ExchangeRate> NewValues { get; set; } = new List<ExchangeRate>();      

        //string currentDollar;
        //string currentPfund;
        public AddExchangeRateForm(List<ExchangeRate> exchangeRates)
        {                      
            InitializeComponent();
            

            foreach (ExchangeRate er in exchangeRates)
            {
                NewValues.Add(er);
                if (er.DisplayCurrency != "EUR")
                {
                    newExchangeRateComboBox.Items.Add(er.DisplayCurrency);
                }
                
                
            }
            newExchangeRateComboBox.Text = exchangeRates.ElementAt(1).DisplayCurrency; 

            //currentDollar = exchangeRates.ElementAt(1).CurrencyValue.ToString();
            //currentPfund = exchangeRates.ElementAt(2).CurrencyValue.ToString();

            //euroToDollarTextBox.Text = currentDollar;
            //euroToPfundTextBox.Text = currentPfund;
        }

        public void addExchangeRateButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                foreach (ExchangeRate er in NewValues)
                {
                    if (er.DisplayCurrency == NewValues.ElementAt(newExchangeRateComboBox.SelectedIndex + 1).DisplayCurrency)
                    {
                        er.CurrencyValue = Convert.ToDecimal(newCurrencyTextBox.Text);
                    }
                }
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Please enter valid numbers!");
                newCurrencyTextBox.Text = "";
            }

            //if (ValidateForm())
            //{
            //    NewValueDollar = euroToDollarTextBox.Text;
            //    NewValuePfund = euroToPfundTextBox.Text;
            //    this.DialogResult = DialogResult.OK;
            //}
            //else
            //{
            //    MessageBox.Show("Please enter valid numbers!");
            //    euroToDollarTextBox.Text = currentDollar;
            //    euroToPfundTextBox.Text = currentPfund;

            //}

        }
        public bool ValidateForm()
        {
            bool valid = true;
            decimal temp;
            if (!decimal.TryParse(newCurrencyTextBox.Text, out temp))
            {
                valid = false;
            }
            return valid;
        }

        private void newExchangeRateComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            currentRateValueLabel.Text = NewValues.ElementAt(newExchangeRateComboBox.SelectedIndex +1 ).CurrencyValue.ToString();
        }
    }
}
