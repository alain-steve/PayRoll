using System;
using System.Collections.Generic;
using System.Text;

namespace PayRoll.Services
{
    public interface INationalInsuranceContributionService
    {
        decimal NIContribution(decimal totalAmount);
    }
}
