using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class Customer
    {
        #region Property
        [Key]
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; }
        //Mức độ thân thiết
        public int Closed { get; set; }
        public DateTime Dob { get; set; }
        public int Gender { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string IdentityCard { get; set; }
        public string Nationality { get; set; }
        public Guid CustomerType { get; set; }
        public CustomerType CustomerTypes { get; set; }
        #endregion
        #region Method
        #endregion
    }
}
