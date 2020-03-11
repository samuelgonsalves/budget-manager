using System;

namespace BudgetManager.Business.Shared
{
    public class Expense
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}
