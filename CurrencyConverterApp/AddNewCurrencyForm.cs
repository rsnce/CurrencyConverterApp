using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverterApp
{
    public partial class AddNewCurrencyForm : Form
    {
        public AddNewCurrencyForm()
        {
            InitializeComponent();
        }
        private bool ValidateForm()
        {
            decimal temp;

            if (currencyNameTextBox.Text.Length <= 0 || !decimal.TryParse(currencyRateTextBox.Text, out temp))
            {
                return false;
            }
            return true;
        }

        private void saveCurrencyButton_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\ExchangeRates.csv";
            // .csv einlesen

            List<ExchangeRate> exchangeRates = new List<ExchangeRate>();
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(";");
                if (entries.Length == 2)
                {

                    ExchangeRate newEntry = new ExchangeRate(entries[0], Convert.ToDecimal(entries[1])); 
                    exchangeRates.Add(newEntry);
                }               
            }
            // in .csv speichern 
            List<string> output = new List<string>();
            if (ValidateForm())
            {
                foreach (ExchangeRate er in exchangeRates)
                {
                    output.Add($"{er.DisplayCurrency};{er.CurrencyValue}");
                }

                ExchangeRate eRate = new ExchangeRate(currencyNameTextBox.Text, Convert.ToDecimal(currencyRateTextBox.Text));
                output.Add($"{eRate.DisplayCurrency};{eRate.CurrencyValue}");
                File.WriteAllLines(filePath, output);
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Please enter a valid name and value!");
                File.WriteAllLines(filePath, output);
            }
        }
    }
}
