using System;

namespace Store.Core.EntityLayer.Sales
{
    public class OrderSummary : IEntity
    {
        public OrderSummary()
        {
        }

        public Int32? OrderID { get; set; }

        public DateTime? OrderDate { get; set; }

        public String CustomerName { get; set; }

        public String EmployeeName { get; set; }

        public String ShipperName { get; set; }

        public Int32? OrderLines { get; set; }
    }
}
