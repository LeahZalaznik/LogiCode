using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentDto = Core.DTO.Payment;
using Payment = Core.DAO.Payment;
namespace Service.Interfaces
{
    public interface IPaymentService
    {
        Task<Payment> AddPaymentAsync(PaymentDto payment);
        Task<List<PaymentDto>> GetPaymentsAsync();
    }
}
