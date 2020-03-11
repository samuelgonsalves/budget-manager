using BudgetManager.Business.Shared;
using Microsoft.EntityFrameworkCore;
using System;

namespace BudgetManager.Data
{
    public class BudgetManagerContext : DbContext
    {
        public BudgetManagerContext(DbContextOptions<BudgetManagerContext> options) : base(options)
        {
        }

        public DbSet<Expense> Expenses { get; set; }
    }
}
