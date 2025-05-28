using Payment = Core.DAO.Payment;
using Data.Interfaces;


namespace Data.Repository
{
    public class PaymentRepository:IPaymentRepository
    {
        private readonly LogiCodeDbContext _context;
        public PaymentRepository(LogiCodeDbContext context)
        {
            _context = context;
        }

        public async Task<Payment> AddPaymentAsync(Payment payment)
        {
            _context.payment.Add(payment);
            await _context.SaveChangesAsync();
            return payment;
        }

        public async Task<List<Payment>> GetPaymentsAsync()
        {
            return _context.payment.ToList();
        }
    }
}
