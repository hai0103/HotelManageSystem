using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManage.Models.Repository
{
    public interface IRoomRepository
    {
        IEnumerable<Room> GetAll();
        Room GetDetail(Guid id);
        int Add(Room room);
        int Edit();

    }
}
