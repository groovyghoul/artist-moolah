using System;
using ArtistMoolah.Api.Models;
using FluentAssertions;
using Xunit;

namespace ArtistMoolah.Tests
{
    public class ExpenseTests
    {
        [Fact]
        public void Able_To_Create_Expense_And_Set_Amount()
        {
            IExpense expense = new Expense(DateTime.Now, 100.0);
            expense.Amount.Should().Be(100.0);
        }
        
        [Fact]
        public void Able_To_Create_Expense_And_Update_Amount()
        {
            IExpense expense = new Expense(DateTime.Now, 100.0);
            expense.SetAmount(200.50);
            expense.Amount.Should().Be(200.50);
            expense.Category.Should().Be("Default");
            expense.Descrition.Should().BeEmpty();
        }
    }
}