using AutoMapper;
using Data;
using Data.Interfaces;
using Service.Interfaces;
using Payment = Core.DAO.Payment;
using PaymentDto = Core.DTO.Payment;

namespace Service.c
{
    public class PaymentService:IPaymentService
    {
        private readonly LogiCodeDbContext _context;
        private readonly IMapper _mapper;
        private readonly IPaymentRepository _repository;
        public PaymentService(LogiCodeDbContext context, IMapper mapper, IPaymentRepository repository)
        {
            _context = context;
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<Payment> AddPaymentAsync(PaymentDto payment)
        {
            Payment p = _mapper.Map<Payment>(payment);
            await _repository.AddPaymentAsync(p);
            return p;
        }

        public async Task<List<PaymentDto>> GetPaymentsAsync()
        {
            List<Payment> p = new List<Payment>();
            p =  await _repository.GetPaymentsAsync();
            return _mapper.Map<List<PaymentDto>>(p);
        }
    }
}
