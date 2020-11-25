using LandlordStudio.Recruitment.Backend.Payments.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LandlordStudio.Recruitment.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentController: ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet]
        [Route("")]
        public async Task<JsonResult> GetPaymentsAsync()
        {
            var payments = await _paymentService.GetPaymentsAsync();
            return new JsonResult(payments);
        }

        [HttpPatch]
        [Route("{id}/pay")]
        public async Task<JsonResult> MarkAsPaidAsync(string id)
        {
            var updatedPayment = await _paymentService.MarkPaymentAsPaid(id);
            return new JsonResult(updatedPayment);
        }
    }
}
