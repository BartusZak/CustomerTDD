using System;

namespace CustomerTDD
{
    public class CustomerValidator
    {
        public bool Validate(ICustomer customer)
        {
            if (customer == null) throw new ArgumentNullException(nameof(customer));
            return false;
        }
    }
}
