using LandlordStudio.Recruitment.Backend.Payments.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace LandlordStudio.Recruitment.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentController: BaseController
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetPaymentsAsync()
        {
            try
            {
                var payments = await _paymentService.GetPaymentsAsync();
                return new JsonResult(payments);
            } catch(Exception e)
            {
                return HandleException(e);
            }
    
        }

        [HttpPatch]
        [Route("{id}/pay")]
        public async Task<IActionResult> MarkAsPaidAsync(string id)
        {
            try
            {
                var updatedPayment = await _paymentService.MarkPaymentAsPaid(id);
                return new JsonResult(updatedPayment);
            }
            catch (Exception e)
            {
                return HandleException(e);
            }         
        }
    }
}
