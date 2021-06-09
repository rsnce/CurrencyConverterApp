using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CurrencyConverterApp
{
    
    public partial class CurrencyConverterForm : Form
    {
        
        List<ExchangeRate> exchangeRates = new List<ExchangeRate>();
        string filePath = @"C:\ExchangeRates.csv";

        public CurrencyConverterForm()
        {
            // if file doesnt exists, create and add base currency
            if (!File.Exists(filePath))  
            {
                File.WriteAllText(filePath, $"EUR;{1}");
            }

            // Datei einlesen
            ReadDataFromFile();
                         
            //Form wird geladen
            InitializeComponent();

            // Combo Box wird befüllt
            foreach (ExchangeRate er in exchangeRates)
            {
                firstCurrencyComboBox.Items.Add(er.DisplayCurrency);
                secondCurrencyComboBox.Items.Add(er.DisplayCurrency);
            }
            // combo box zeigt erstes element an statt null
            firstCurrencyComboBox.Text = exchangeRates.ElementAt(0).DisplayCurrency;
            secondCurrencyComboBox.Text = exchangeRates.ElementAt(0).DisplayCurrency;
        }
        // umrechnen button
        private void exchangeButton_Click(object sender, EventArgs e)
        {
         
            if (ValidateForm())
            {
             
              decimal temp = exchangeRates.ElementAt(firstCurrencyComboBox.SelectedIndex).ToBaseCurrency(Convert.ToDecimal(firstCurrencyTextBox.Text));
              secondCurrencyTextBox.Text = exchangeRates.ElementAt(secondCurrencyComboBox.SelectedIndex).ToTargetCurrency(temp).ToString(); ;
   
            }
            else
            {
                MessageBox.Show("Please choose a currency from and to convert to and enter a Value!");
            }
            
            bool ValidateForm()
            {
                decimal a;
                bool output = true;
                if (firstCurrencyComboBox.SelectedItem == null || secondCurrencyComboBox.SelectedItem == null
                    || firstCurrencyTextBox.Text.Length == 0 ||!decimal.TryParse(firstCurrencyTextBox.Text, out a))
                {
                    output = false;
                }

                return output;
            }
        }

        // change Conversion Rate button 
        private void changeConversionButton_Click(object sender, EventArgs e)
        {
            AddExchangeRateForm form = new AddExchangeRateForm(exchangeRates);
    
            if(form.ShowDialog() == DialogResult.OK)
            {
                int index = 0;
                foreach (ExchangeRate er in form.NewValues)
                {
                    if (er.CurrencyValue != exchangeRates.ElementAt(index).CurrencyValue)
                    {
                        exchangeRates.ElementAt(index).CurrencyValue = er.CurrencyValue;
                    }
                    index++;
                }
            }            
        }
        // add new currency button
        private void addCurrencyButton_Click(object sender, EventArgs e)
        {
            AddNewCurrencyForm form = new AddNewCurrencyForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                // combobox und liste werden geleert und wieder befüllt
                exchangeRates.Clear();
                firstCurrencyComboBox.Items.Clear();
                secondCurrencyComboBox.Items.Clear();
                ReadDataFromFile();

                foreach (ExchangeRate er in exchangeRates)
                {
                    firstCurrencyComboBox.Items.Add(er.DisplayCurrency);
                    secondCurrencyComboBox.Items.Add(er.DisplayCurrency);
                }
                // combo box zeigt erstes element an statt null
                firstCurrencyComboBox.Text = exchangeRates.ElementAt(0).DisplayCurrency;
                secondCurrencyComboBox.Text = exchangeRates.ElementAt(0).DisplayCurrency;
            }
        }
        private void ReadDataFromFile()
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();

            // if file is exist but is empty
            if (lines.Count == 0||lines.ElementAt(0)=="")
            {
                File.WriteAllText(filePath, $"EUR;{1}");
                exchangeRates.Add(new ExchangeRate("EUR", 1));
            }

            foreach (var line in lines)
            {
                string[] entries = line.Split(";");

                if (entries.Length == 2)
                {
                    ExchangeRate newEntry = new ExchangeRate(entries[0], Convert.ToDecimal(entries[1]));
                    exchangeRates.Add(newEntry);
                }

            }
        }
    }
}
