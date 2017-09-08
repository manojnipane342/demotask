using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace logictast.Entities
{
    [Table("customer")]
    public class Customer
    {
        [Key]
        public int c_id { set; get; }
        public string c_name { set; get; }
        public string c_mobile { set; get; }
        public string c_email { set; get; }
        public string c_gender { set; get; }
        public string c_age { set; get; }
    }
}
