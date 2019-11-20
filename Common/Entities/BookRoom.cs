using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class BookRoom
    {
        #region Property
        [Key]
        public Guid BookRoomId { get; set; }
        [Key]
        public Guid RoomId { get; set; }
        [Key]
        public Guid CustomerId { get; set; }
        //tiền cọc
        public decimal Deposit { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Room Rooms { get; set; }
        public Customer Customers { get; set; }
        #endregion
    }
}
