using Payment = Core.DAO.Payment;
using PaymentDto = Core.DTO.Payment;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost]
        public async Task<Payment> AddPaymentAsync(PaymentDto payment) 
        {
            return await _paymentService.AddPaymentAsync(payment);
        }

        [HttpGet]
        public async Task<List<PaymentDto>> GetPaymentsAsync()
        {
            return await _paymentService.GetPaymentsAsync();
        }

    }
}
