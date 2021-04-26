using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using supplierservice.Models.Api;

namespace supplierservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SupplierController : ControllerBase
    {
        private readonly ILogger<SupplierController> _logger;

        public SupplierController(ILogger<SupplierController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<SupplierDto> Get()
        {
            return new List<SupplierDto>() {
                new SupplierDto() {SupplierName="Fischer GmbH", SupplierNumber="4455"},
                new SupplierDto() {SupplierName="Müller GmbH", SupplierNumber="3344"},
            }; 
        }
    }
}
