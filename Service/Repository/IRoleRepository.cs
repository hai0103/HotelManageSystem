using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Repository
{
    interface IRoleRepository
    {
        IEnumerable<IdentityRole> Get();
    }
}
