
using Domain;
using FluentAssertions;
using System.Reflection;

namespace CalculatorTDD
{
    public class UnitTest1
    {
        [Fact]
        public void Sum_of_2_and_2_should_be_4()
        {
            var calculator = new Calculator();

            var result = calculator.Sum(2, 2);

            result.Should().Be(4);
        }

     
 
        
    }
}