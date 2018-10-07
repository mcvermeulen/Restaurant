using System;
using Restaurant;
using Xunit;

namespace RestaurantTests
{
    public class CookTests
    {
        private readonly Cook cook;

        public CookTests() 
        {
            this.cook = new Cook("Marcel", new SimplePreparationStrategy());
        }

        [Fact]
        public void ShouldReturnSimplePreparationType()
        {
            Assert.True(cook.GetPreparation() is SimplePreparationStrategy, "Cook doesn't have a simple preparation");
        }
    }
}
