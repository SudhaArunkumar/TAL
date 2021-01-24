using System;
using System.Collections.Generic;
using CodingTAL.ViewModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTAL.Services
{
    public interface IPremiumCalculationService
    {
        double GetSumInsured(HomeViewModel model);
    }
}
