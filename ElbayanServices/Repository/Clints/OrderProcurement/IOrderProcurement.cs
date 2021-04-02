using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanServices.Repository.Clints.OrderProcurement.Dtos;
//using OrderDto = ElbayanServices.Repository.Clints.Orders.Dtos.OrderDto;

namespace ElbayanServices.Repository.Clints.OrderProcurement
{
   public interface IOrderProcurement
   {
       Guid CreateSupplierOrder(Dtos.OrderDto model);
       List<InvoiceDetailsDto> PrintInvoice(Guid orderId);

   }
}
