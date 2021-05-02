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
            Math.Round(expresso.GetPrice(), 2).Should().Be(1.56);
        }
        [Fact]
        public void LungoShouldHaveTheRightPrice()
        {
            var lungo = Recipe.LUNGO;
            Math.Round(lungo.GetPrice(), 2).Should().Be(1.82);
        }
        [Fact]
        public void CapuccinoShouldHaveTheRightPrice()
        {
            var capuccino = Recipe.CAPUCCINO;
            Math.Round(capuccino.GetPrice(), 2).Should().Be(3.51);
        }
        [Fact]
        public void ChocolatShouldHaveTheRightPrice()
        {
            var chocolat = Recipe.CHOCOLAT;
            Math.Round(chocolat.GetPrice(), 2).Should().Be(5.33);
        }
        [Fact]
        public void TeaShouldHaveTheRightPrice()
        {
            var tea = Recipe.TEA;
            Math.Round(tea.GetPrice(), 2).Should().Be(3.12);
        }

    }
}
