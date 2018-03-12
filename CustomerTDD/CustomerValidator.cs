using System;

namespace CustomerTDD
{
    public class CustomerValidator
    {
        public bool Validate(ICustomer customer)
        {
            if (customer == null) throw new ArgumentNullException(nameof(customer));
            throw new NotImplementedException();
        }

        internal class CustomerMock : ICustomer
        {
            private readonly int _expectedAge;

            public CustomerMock(int expectedAge)
            {
                _expectedAge = expectedAge;
            }

            public int GetAge() => _expectedAge;
        }
    }
}
