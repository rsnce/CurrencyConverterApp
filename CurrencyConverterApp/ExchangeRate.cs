using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverterApp
{
    public class ExchangeRate
    {
        // Base Currence = 1 Euro
        public string DisplayCurrency { get; }
        public decimal CurrencyValue { get; set; }

        // Funktion, die den Wert der eingegebenen Währung in die Grundwährung umrechnet
        public decimal ToBaseCurrency ( decimal value )
        {
            return value * (1 / CurrencyValue);
        }

        // Funktion, die den Wert der Grundwähung in dir Zielwährung umrechnet
        public decimal ToTargetCurrency (decimal value)
        {
            return value * CurrencyValue;
        }

        public ExchangeRate( string currencyname, decimal value )
        {
            DisplayCurrency = currencyname;
            CurrencyValue = value;
        }     
    }
}
