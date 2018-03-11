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
    }
}
