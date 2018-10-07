using System;
using Restaurant;
using Xunit;

namespace RestaurantTests
{
    public class CookTests
    {
        private Cook cook;

        CookTests() 
        {
            this.cook = new Cook("Marcel", new SimplePreparationStrategy());
        }

        [Fact]
        public void shouldReturnSimplePreparationType()
        {
            Assert.True(cook.getPreparation() is SimplePreparationStrategy, "jupz");
        }
    }
}
