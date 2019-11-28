using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManage.Models.Dictionary
{
    public class RoomTypeBL:IRoomTypeRepository
    {
        public ApplicationDbContext context = new ApplicationDbContext();

        public IEnumerable<RoomType> GetAll()
        {
            return context.RoomTypes.ToList();
        }
        public RoomType GetDetail(Guid id)
        {
            return context.RoomTypes.SingleOrDefault(r => r.RoomTypeId == id);
        }
        public int Add(RoomType roomType)
        {
            if (roomType != null)
            {
                context.RoomTypes.Add(roomType);
                context.SaveChanges();
                return 1;
            }
            return 0;
        }

        public int Edit()
        {
            return 0;
        }
        public int Delete(Guid id)
        {
            if(id != null)
            {
                RoomType rt = context.RoomTypes.FirstOrDefault(r => r.RoomTypeId == id);
                context.RoomTypes.Remove(rt);
                context.SaveChanges();
                return 1;
            }
            return 0;
        }
    }
}