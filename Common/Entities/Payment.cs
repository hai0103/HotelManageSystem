using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Payment
    {
        [Key]
        public Guid BillId { get; set; }
        public Guid BookRoomId { get; set; }
        public decimal totalCost { get; set; }
        
    }
}
