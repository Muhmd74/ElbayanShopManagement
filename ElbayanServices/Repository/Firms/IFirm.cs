using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanServices.Repository.Firms.Dtos;

namespace ElbayanServices.Repository.Firms
{
    public interface IFirm
    {
        bool CreateFirm(FirmDto model);
        bool UpdateFirm(FirmDto model);
        FirmDto Get();
    }
}
