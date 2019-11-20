using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class CustomerType
    {
        #region Property
        [Key]
        public Guid CustomerTypeId { get; set; }
        public string CustomerTypeName { get; set; }
        public List<Customer> Customers { get; set; }
        #endregion
    }
}
