using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class UsingService
    {
        [Key]
        public Guid CustomerId { get; set; }
        [Key]
        public Guid ServiceId { get; set; }
        public Guid BookRoomId { get; set; }
        public Service Services { get; set; }
        public BookRoom BookRooms { get; set; }
    }
}
