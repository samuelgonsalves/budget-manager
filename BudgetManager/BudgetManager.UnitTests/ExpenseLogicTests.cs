using Autofac;
using BudgetManager.Data;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace BudgetManager.UnitTests
{
    public class ExpenseLogicTests
    {
        [Fact]
        public void Test1()
        {
            var container = new ContainerBuilder();
            container.RegisterInstance(new DbContextOptionsBuilder<BudgetManagerContext>()
                 .UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BudgetManager;Trusted_Connection=True;").Options);
            container.RegisterType<BudgetManagerContext>();
            container.Build().Resolve<BudgetManagerContext>().Database.EnsureCreated();
        }
    }
}
