using System;
using System.Collections.Generic;
using System.Text;

namespace PayRoll.Services.Implementation
{
    public class NationalInsuranceContributionService : INationalInsuranceContributionService
    {
        private decimal NIRate;
        private decimal NIC;

        public decimal NIContribution(decimal totalAmount)
        {
            NIRate = .075m;
            NIC = (totalAmount * NIRate);
            return NIC;
        }
    }
}
