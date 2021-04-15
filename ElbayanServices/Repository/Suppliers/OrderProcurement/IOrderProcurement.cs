using System;
using System.Collections.Generic;
using ElbayanServices.Repository.Suppliers.OrderProcurement.Dtos;

//using OrderDto = ElbayanServices.Repository.Clints.Orders.Dtos.OrderDto;

namespace ElbayanServices.Repository.Suppliers.OrderProcurement
{
   public interface IOrderProcurement
   {
       Guid CreateSupplierOrder(OrderDto model);
       List<InvoiceDetailsDto> PrintInvoice(Guid orderId);

   }
}
