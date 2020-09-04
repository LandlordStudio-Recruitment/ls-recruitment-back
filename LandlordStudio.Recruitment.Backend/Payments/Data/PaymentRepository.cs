using LandlordStudio.Recruitment.Backend.Payments.Model;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace LandlordStudio.Recruitment.Backend.Payments.Data
{
    public class PaymentRepository : IPaymentRepository
    {
        public async Task<IEnumerable<Payment>> GetPayments()
        {
            return await JsonSerializer
                .DeserializeAsync<IEnumerable<Payment>>(File.OpenRead("Payments/Data/payments.json"));
        }
    }
}
