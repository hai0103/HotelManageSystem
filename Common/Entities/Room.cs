using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Room
    {
        [Key]
        public Guid RoomId { get; set; }
        public string RoomName { get; set; }
        public int RoomState { get; set; }
        public int MaxPeople { get; set; }
        public int BedNum { get; set; }
        public int BathRooms { get; set; }
        public Guid RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }
    }
}
