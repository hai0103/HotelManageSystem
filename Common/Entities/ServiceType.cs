using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class ServiceType
    {
        [Key]
        public Guid ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public decimal ServicePrice { get; set; }
        public List<Service> Services { get; set; }
    }
}
