using System;
using Xunit;
using FluentAssertions;

namespace CustomerValidator.Tests
{
    public class CustomerValidatorTests
    {
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
