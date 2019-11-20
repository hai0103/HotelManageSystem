using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ModelBinding;

namespace HotelManage.Models.Dictionary
{
    public class UserBL
    {
        public ApplicationDbContext context = new ApplicationDbContext();

        public IEnumerable<ApplicationUser> GetAll()
        {
            return context.Users.ToList();
        }
        public ApplicationUser GetDetail(Guid Id)
        {
            return context.Users.FirstOrDefault(x=>x.Id==Id.ToString());
        }
        public int Create(ApplicationUser user)
        {
            if (user != null)
            {
                context.Users.Add(user);
                return 1;
            }
            return 0;
        }
        //public int UpdateUser(Guid Id)
        //{
        //    var user = context.Users.FirstOrDefault(x => x.Id == Id.ToString());
        //    if (user != null)
        //    {
                
        //        return 1;
        //    }
        //}
    }
}