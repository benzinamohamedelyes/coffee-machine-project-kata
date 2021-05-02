using coffee_machine_project_kata.Domain;
using FluentAssertions;
using System;
using Xunit;

namespace Tests
{
    public class CoffeeMachineTests
    {
        [Fact]
        public void ExpressoShouldHaveTheRightPrice()
        {
            var expresso = Recipe.EXPRESSO;
            expresso.GetPrice().Should().Be(1.56);
        }
        [Fact]
        public void LungoShouldHaveTheRightPrice()
        {
            var lungo = Recipe.LUNGO;
            lungo.GetPrice().Should().Be(1.82);
        }
        [Fact]
        public void CapuccinoShouldHaveTheRightPrice()
        {
            var capuccino = Recipe.CAPUCCINO;
            capuccino.GetPrice().Should().Be(3.51);
        }
        [Fact]
        public void ChocolatShouldHaveTheRightPrice()
        {
            var chocolat = Recipe.CHOCOLAT;
            chocolat.GetPrice().Should().Be(5.33);
        }
        [Fact]
        public void TeaShouldHaveTheRightPrice()
        {
            var tea = Recipe.TEA;
            tea.GetPrice().Should().Be(5.72);
        }
        
    }
}
