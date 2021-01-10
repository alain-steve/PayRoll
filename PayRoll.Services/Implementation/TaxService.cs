using System;
using System.Collections.Generic;
using System.Text;

namespace PayRoll.Services.Implementation
{
    public class TaxService : ITaxService
    {
        private decimal taxRate;
        private decimal tax;

        public decimal TaxAmount(decimal totalAmount)
        {
            if (totalAmount <= 300)
            {
                //Tax Free Rate
                taxRate = .0m;
                tax = totalAmount * taxRate;
            }
            else if (totalAmount > 300 && totalAmount <= 1000)
            {
                //Basic Tax Rate
                taxRate = .20m;
                //Income Tax
                tax = (300 * .0m)+((totalAmount-300)*taxRate);
            }
            else if (totalAmount > 1000)
            {
                //higher tax rate
                taxRate = 0.30m;
                //Income Tax
                tax = (300 * .0m) + ((1000 - 300) * .20m) + ((totalAmount - 1000) * taxRate);
            }
            return tax;
        }
    }
}
