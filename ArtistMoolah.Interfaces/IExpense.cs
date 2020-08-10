using System;

namespace ArtistMoolah.Api.Models
{
    public interface IExpense
    {
        DateTime Date { get; }
        double Amount { get; }
        string Category { get; }
        string Descrition { get; }
        void SetDate(DateTime date);
        void SetAmount(double amount);
        void SetCategory(string category);
        void SetDescription(string description);
    }
}