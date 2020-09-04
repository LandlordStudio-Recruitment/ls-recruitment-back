using LandlordStudio.Recruitment.Backend.Payments.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LandlordStudio.Recruitment.Backend.Payments.Data
{
    public interface IPaymentRepository
    {
        Task<IEnumerable<Payment>> GetPayments();
    }
}
