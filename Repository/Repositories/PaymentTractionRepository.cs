using DataAccessObject.Models;
using Repository.GenericRepository;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class PaymentTractionRepository : GenericRepository<PaymentPhase>, IPaymentPhaseRepository
    {
        public PaymentTractionRepository(HomeDecorDBContext context) : base(context)
        {
        }
    }
}
