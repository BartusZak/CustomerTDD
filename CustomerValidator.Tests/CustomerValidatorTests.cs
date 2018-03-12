using System;
using Xunit;
using FluentAssertions;

namespace CustomerValidator.Tests
{ 
    public class CustomerValidatorTests
    {
        [Theory]
        [InlineData(18)]
        [InlineData(19)]
        public void WhenCustomerHasAgeGreaterThanOrEqualTo18_ThenValidationPasses(int expectedAge)
        {
            var validator = new CustomerTDD.CustomerValidator();
            var customer = new CustomerTDD.CustomerMock(expectedAge: expectedAge);

            bool validate = validator.Validate(customer);

            validate.Should().BeTrue();
        }

        [Fact]
        public void WhenCustomerIsNull_ThenArgumentNullExceptionIsThrown()
        {
            var validator = new CustomerTDD.CustomerValidator();

            Action action = () => validator.Validate(null);

            action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void WhenCustomerHasAgeLessThan18_ThenValidationFails()
        {
            var validator = new CustomerTDD.CustomerValidator();
            var customer = new CustomerTDD.CustomerMock(expectedAge: 16);

            bool validate = validator.Validate(customer);

            validate.Should().BeFalse();
        }
    }
}
