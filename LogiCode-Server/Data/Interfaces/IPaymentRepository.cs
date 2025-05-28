using Payment = Core.DAO.Payment;
using PaymentDto = Core.DTO.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IPaymentRepository
    {
        Task<Payment> AddPaymentAsync(Payment payment);
        Task<List<Payment>> GetPaymentsAsync();
    }
}
