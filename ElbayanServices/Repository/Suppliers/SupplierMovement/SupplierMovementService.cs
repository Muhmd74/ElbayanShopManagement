using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ElbayanDatabase.ConnectionTools;
using ElbayanDatabase.DataClasses.Clints.Sales;
using ElbayanServices.Repository.Suppliers.SupplierMovement.Dto;

namespace ElbayanServices.Repository.Suppliers.SupplierMovement
{
    public class SupplierMovementService : ISupplierMovement, IDisposable
    {
        private readonly ConnectionOption _context;
        public SupplierMovementService(ConnectionOption context)
        {
            _context = context;
        }
        public Guid CreatePayment(SupplierMovementCreateDto model)
        {
            var payment = _context.DeferredPayments.Add(new DeferredPayment()
            {
                Payment = model.Payment,
                Balance = model.Balance  /* model.Balance - model.Payment */,
                Description = model.Description,
                ClintId = model.ClintId,
                CreatedDate = DateTime.Now,
                DueDatePayingOff = model.DueDatePayingOff,
                PaymentType = model.PaymentType,
                TotalPayment = model.TotalPayment,
                DepositNumber = model.DepositNumber
            });
            return payment.Id;
        }
        public Guid PaymentAllDeferred(PaymentAllDeferredDto model)
        {
            var payment = _context.DeferredPayments.Add(new DeferredPayment()
            {
                Payment = GetBalance(model.ClintId),
                Balance = 0,
                Description = model.Description,
                ClintId = model.ClintId,
                CreatedDate = DateTime.Now,
                DueDatePayingOff = DateTime.Now,
                PaymentType = model.PaymentType,
                TotalPayment = model.TotalPayment,
                DepositNumber = model.DepositNumber
            });
            return payment.Id;
        }
        public decimal GetBalance(Guid? clintId)
        {
            var model = _context.DeferredPayments.OrderByDescending(d => d.CreatedDate)
                .FirstOrDefault(d => d.ClintId == clintId);
            if (model != null)
            {
                return model.Balance;
            }
            return 0;
        }
        public GetSupplierPaymentByUserDto GetLastPaymentByUserId(Guid clintId)
        {
            var model = _context.DeferredPayments
                .Include(d => d.Clint)
                .OrderByDescending(d => d.CreatedDate)
                .FirstOrDefault(d => d.ClintId == clintId);
            if (model != null)
            {
                return new GetSupplierPaymentByUserDto()
                {
                    Balance = model.Balance,
                    Payment = model.Payment,
                    ClintName = model.Clint.Name
                };
            }
            return null;
        }
        public PrintInvoicePaymentOnceDto PrintInvoicePaymentOnce(Guid id)
        {
            var firm = _context.Firms.FirstOrDefault();
            var deferredPayments = _context.DeferredPayments
                .Include(d => d.Clint)
                .FirstOrDefault(d => d.Id == id);
            if (deferredPayments != null)
            {
                return new PrintInvoicePaymentOnceDto()
                {
                    FirmName = firm?.Name,
                    LogoInvoice = firm?.LogoInvoice,
                    MessageInvoice = firm?.MessageInvoice,
                    Mobile = firm?.Mobile,
                    ClintId = deferredPayments.ClintId,
                    ClintMobile = deferredPayments.Clint.Mobile,
                    ClintName = deferredPayments.Clint.Name,
                    Balance = deferredPayments.Balance,
                    Payment = deferredPayments.Payment,
                    PaymentType = deferredPayments.PaymentType,
                    TotalPayment = deferredPayments.TotalPayment,
                    DueDatePayingOff = deferredPayments.DueDatePayingOff,
                    CollectingPaymentDate = deferredPayments.CreatedDate,
                    Description = deferredPayments.Description,
                    LastBalance = 0m
                };
            }

            return null;
        }
        public List<SupplierMovementDto> GetAllSupplierMovement()
        {
            try
            {
                return _context.DeferredPayments
                    .Include(d => d.Clint)
                    .Include(d => d.Order)
                    .OrderByDescending(d => d.CreatedDate)
                    .Select(d => new SupplierMovementDto()
                    {
                        Balance = d.Balance,
                        Payment = d.Payment,
                        PaymentType = d.PaymentType,
                        ClintName = d.Clint.Name,
                        CollectingPaymentDate = d.CreatedDate,
                        DepositNumber = d.DepositNumber,
                        ClintId = d.ClintId,
                        DueDatePayingOff = d.DueDatePayingOff,
                       OrderNumber = d.Order.OrderNumber
                    }).ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public List<GetAllMovementOrderInOneDayDto> GetAllMovementOrderInOneDay()
        {
            return _context.ProductStocks
                .Include(d => d.Product.LargeUnit)
                .Include(d => d.Product.SmallUnit)
                .Include(d => d.Order.Clint)
                .OrderByDescending(d => d.DateTime)
                .Where(d=>d.DateTime==DateTime.Today)
                .Select(d =>  new GetAllMovementOrderInOneDayDto
                {
                    DateTime = d.DateTime,
                    Quantity = d.Stock,
                    OrderNumber = d.Order.OrderNumber,
                    OrderType = d.Order.OrderType,
                    ProductName = d.Product.Name,
                    UnitName = d.Product.IsUnitSale ? d.Product.LargeUnit.Name : d.Product.SmallUnit.Name,
                    UserName = d.Order.Clint.Name,
                    BarCode = d.Product.BarCode,
                    ProductNumber = d.Product.ProductNumber,
                    Deferred = d.Order.Deferred,
                    Payment = d.Order.Payment

                }).ToList();
        }
        public List<SupplierMovementDto> GetAllSupplierMovementByClintId(Guid clintId)
        {
            try
            {
                return _context.DeferredPayments
                    .Include(d => d.Clint)
                    .OrderByDescending(d => d.CreatedDate)
                    .Where(d => d.ClintId == clintId)
                    .Select(d => new SupplierMovementDto()
                    {
                        Balance = d.Balance,
                        Payment = d.Payment,
                        PaymentType = d.PaymentType,
                        ClintName = d.Clint.Name,
                        CollectingPaymentDate = d.CreatedDate,
                        DepositNumber = d.DepositNumber,
                        ClintId = d.ClintId,
                        DueDatePayingOff = d.DueDatePayingOff
                    }).ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public List<SupplierMovementDto> FilterPaymentsByDate(DateTime firstDate, DateTime lastDate, Guid? clintId, string paymentType)
        {
            try
            {
                return _context.DeferredPayments
                    .Include(d => d.Clint)
                    .OrderByDescending(d => d.CreatedDate)
                    .Where(d =>( d.CreatedDate >= firstDate && d.CreatedDate <= lastDate )
                                || d.ClintId == clintId
                                || d.PaymentType == paymentType)
                    .Select(d => new SupplierMovementDto()
                    {
                        Balance = d.Balance,
                        Payment = d.Payment,
                        PaymentType = d.PaymentType,
                        ClintName = d.Clint.Name,
                        CollectingPaymentDate = d.CreatedDate,
                        DepositNumber = d.DepositNumber,
                        ClintId = d.ClintId,
                        DueDatePayingOff = d.DueDatePayingOff
                    }).ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
