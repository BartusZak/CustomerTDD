using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerTDD
{
    public class CustomerMock : ICustomer
    {
        private readonly int _expectedAge;

        public CustomerMock(int expectedAge)
        {
            _expectedAge = expectedAge;
        }

        public int GetAge() => _expectedAge;
    }
}
