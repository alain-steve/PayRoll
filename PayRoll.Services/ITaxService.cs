using System;
using System.Collections.Generic;
using System.Text;

namespace PayRoll.Services
{
    public interface ITaxService
    {
        decimal TaxAmount(decimal totalAmount);
    }
}
