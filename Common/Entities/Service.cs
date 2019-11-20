using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Service
    {
        [Key]
        public Guid ServiceId { get; set; }
        public string ServiceName { get; set; }
        public decimal ServicePrice { get; set; }
        public string ServiceDescription { get; set; }
        public Guid ServiceTypeId { get; set; }
        public ServiceType ServiceTypes { get; set; }
    }
}
