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
                     YearMonth="202212", Amount=3100
                },
            };

            _budgetRepo.GetAll().Returns(a);

            var service = new BudgetService(_budgetRepo);

            var result = service.Query(new System.DateTime(2022, 12, 01), new System.DateTime(2022, 12, 31));

            Assert.AreEqual(3100m, result);
        }

        [Test]
        public void ¸ó¦~()
        {
            var a = new List<Budget>()
            {
                new Budget()
                {
                     YearMonth="202212", Amount=3100
                },
                new Budget()
                {
                     YearMonth="202301", Amount=310
                },
                               new Budget()
                {
                     YearMonth="202302", Amount=28
                },
            };

            _budgetRepo.GetAll().Returns(a);

            var service = new BudgetService(_budgetRepo);

            var result = service.Query(new System.DateTime(2022, 12, 23), new System.DateTime(2023, 2, 12));

            Assert.AreEqual(1222m, result);
        }

    }
}