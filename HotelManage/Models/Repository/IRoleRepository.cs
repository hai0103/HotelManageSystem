using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManage.Models.Repository
{
    interface IRoleRepository
    {
        IEnumerable<IdentityRole> Get();
        int Create();
        int Edit();
        int Delete();
    }
}
