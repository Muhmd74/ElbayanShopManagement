using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanDatabase.ConnectionTools;
using ElbayanDatabase.DataClasses.Firms;
using ElbayanServices.Repository.Firms.Dtos;

namespace ElbayanServices.Repository.Firms
{
    public class FirmService : IFirm, IDisposable
    {
        private readonly ConnectionOption _context;

        public FirmService(ConnectionOption context)
        {
            _context = context;
        }

        public bool CreateFirm(FirmDto model)
        {
            _context.Firms.Add(new Firm
            {
                Email = model.Email,
                Address=model.Address,
                Name = model.Name,
                End = model.End,
                LogoInvoice = model.LogoInvoice,
                MessageInvoice = model.MessageInvoice,
                Mobile = model.Mobile,
                NatureWork = model.NatureWork,
                Phone = model.Phone,
                Start = model.Start
            });
            _context.SaveChanges();
            return true;
        }

        public bool UpdateFirm(FirmDto model)
        {
            var firm = _context.Firms.FirstOrDefault(d => d.Id == model.Id);
            if (firm!=null)
            {
                firm.Address = model.Address;
                firm.Email = model.Email;
                firm.End = model.End;
                firm.LogoInvoice = model.LogoInvoice;
                firm.MessageInvoice = model.MessageInvoice;
                firm.Mobile = model.Mobile;
                firm.NatureWork = model.NatureWork;
                firm.Name = model.Name;
                firm.Start = model.Start;
                _context.SaveChanges();
                return true;
            }

            return false;
        }
        public FirmDto Get()
        {
            var model = _context.Firms.FirstOrDefault();
            if(model != null)
            {
                return new FirmDto()
                {
                    Id = model.Id,
                    Name = model.Name,
                    Address = model.Address,
                    Email = model.Email,
                    End = model.End,
                    Start = model.Start,
                    LogoInvoice = model.LogoInvoice,
                    MessageInvoice = model.MessageInvoice,
                    Mobile = model.Mobile,
                    NatureWork = model.NatureWork,
                    Phone = model.Phone
                };
            }
            return null;
        }
        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
