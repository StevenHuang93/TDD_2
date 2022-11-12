using NUnit.Framework;
using NSubstitute;
using System.Collections.Generic;

namespace TestProject2
{
    public class Tests
    {
        IBudgetRepo _budgetRepo;
        BudgetService service;

        [SetUp]
        public void Setup()
        {
            _budgetRepo = NSubstitute.Substitute.For<IBudgetRepo>();
        }

        [Test]
        public void Test1()
        {
            var a = new List<Budget>()
            {
                new Budget()
                {
                     YearMonth="202212", Amount=3000
                },
            };

            _budgetRepo.GetAll().Returns(a);

            var service =


            Assert.Pass();
        }
    }
}