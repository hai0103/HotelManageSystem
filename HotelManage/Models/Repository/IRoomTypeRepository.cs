using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManage.Models
{
    public interface IRoomTypeRepository
    {
        IEnumerable<RoomType> GetAll();
        int Add();
        int Edit();
        int Delete();
    }
}
