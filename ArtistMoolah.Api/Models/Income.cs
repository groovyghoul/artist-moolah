using System;

namespace ArtistMoolah.Api.Models
{
    public class Income : IIncome
    {
        private DateTime _date;
        private double _amount;
        private string _category;
        private string _description;
        
        public Income(DateTime date, double amount, string category = "Default", string description = "")
        {
            _date = date;
            _amount = amount;
            _category = category;
            _description = description;
        }

        public DateTime Date => _date;
        public double Amount => _amount;
        public string Category => _category;
        public string Descrition => _description;

        public void SetDate(DateTime date)
        {
            _date = date;
        }
        
        public void SetAmount(double amount)
        {
            _amount = amount;
        }

        public void SetCategory(string category)
        {
            _category = category;
        }

        public void SetDescription(string description)
        {
            _description = description;
        }
    }
}