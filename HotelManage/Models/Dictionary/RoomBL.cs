using Common.Entities;
using HotelManage.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManage.Models.Dictionary
{
    public class RoomBL:IRoomRepository
    {
        public ApplicationDbContext context = new ApplicationDbContext();

        public IEnumerable<Room> GetAll()
        {
            return context.Rooms.ToList();
        }
        public Room GetDetail(Guid id)
        {
            return context.Rooms.SingleOrDefault(r => r.RoomId == id);
        }
        public int Add(Room room)
        {
            if(room != null)
            {
                context.Rooms.Add(room);
                context.SaveChanges();
                return 1;
            }
            return 0;
        }

        public int Edit()
        {
            return 0;
        }

    }
}