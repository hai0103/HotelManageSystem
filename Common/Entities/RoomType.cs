using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class RoomType
    {
        // RoomType
        [Key]
        public Guid RoomTypeId { get; set; }
        public string RoomTypeName { get; set; }
        public decimal RoomTypePrice { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
