using System;

namespace supplierservice.Models.Api
{
    public class SupplierDto
    {
        public Guid Id { get; set; }
        public string SupplierName { get; set; }
        public string SupplierNumber { get; set; }
    }
}