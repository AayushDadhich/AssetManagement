using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagement.Models
{
    public class Users
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int uid { get; set; }

        public string uname { get; set; }
        public string pass{ get; set; }
        public int type { get; set; }
    }
}