using LandlordStudio.Recruitment.Backend.Payments.Data;
using LandlordStudio.Recruitment.Backend.Payments.Model;
using LandlordStudio.Recruitment.Core.Exceptions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LandlordStudio.Recruitment.Backend.Payments.Service
{
    public class PaymentService: IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;
        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }
           
        public async Task<IEnumerable<Payment>> GetPaymentsAsync() {
            // validation goes here

            return await _paymentRepository.GetPaymentsAsync();
        }

        public async Task<Payment> MarkPaymentAsPaid(string id)
        {
            var payments = await _paymentRepository.GetPaymentsAsync();
            var paymentToUpdate = payments.FirstOrDefault(x => x.Id == id);
            if (paymentToUpdate == null)
                throw new BaseException(Core.Enums.StatusCode.NotFound, "Payment doesn't exist");

            paymentToUpdate.Status = "Paid";

            return await _paymentRepository.UpdatePayment(paymentToUpdate);
        }
    }
}
