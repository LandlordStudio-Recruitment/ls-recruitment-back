using LandlordStudio.Recruitment.Backend.Payments.Model;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace LandlordStudio.Recruitment.Backend.Payments.Data
{
    public class PaymentRepository : IPaymentRepository
    {
        private const string DATA_FILE_PATH = "Payments/Data/payments.json";

        public async Task<IEnumerable<Payment>> GetPaymentsAsync()
        { 
            return await GetDeserializedPaymentsAsync();               
        }

        public async Task<Payment> UpdatePayment(Payment payment)
        {
            var payments = (await GetDeserializedPaymentsAsync()).ToList();

            // update
            var indexToUpdate = payments.FindIndex(x => x.Id == payment.Id);
            payments[indexToUpdate] = payment;

            // persist to file
            using (FileStream fs = File.Create(DATA_FILE_PATH))
            {
                await JsonSerializer.SerializeAsync(fs, payments);
            }              

            return payment;
        }

        private async Task<IEnumerable<Payment>> GetDeserializedPaymentsAsync()
        {
            IEnumerable<Payment> payments;
            using (FileStream fs = File.OpenRead(DATA_FILE_PATH))
            {
                payments = await JsonSerializer.DeserializeAsync<IEnumerable<Payment>>(fs);
            }
            return payments;
        }
    }
}
