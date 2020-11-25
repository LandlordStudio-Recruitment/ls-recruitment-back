using LandlordStudio.Recruitment.Backend.Payments.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LandlordStudio.Recruitment.Backend.Payments.Service
{
    public interface IPaymentService
    {
        Task<IEnumerable<Payment>> GetPaymentsAsync();
        Task<Payment> MarkPaymentAsPaid(string id);
    }
}
