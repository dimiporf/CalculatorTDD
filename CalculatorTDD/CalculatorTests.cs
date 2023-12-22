
using Domain;
using FluentAssertions;
using System.Reflection;

namespace CalculatorTDD
{
    public class CalculatorTests
    {
        [Fact]
        public void Sum_of_2_and_2_should_be_4()
            => new Calculator()
            .Sum(2, 2)
            .Should().Be(4);

        [Fact]
        public void Minus_of_10_and_5_should_be_5()
            => new Calculator()
            .Minus(10, 5)
            .Should().Be(5);
        

     
 
        
    }
}