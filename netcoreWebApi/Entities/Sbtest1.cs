using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreWebApi.Entities
{
    [Table("sbtest1")]
    public class Sbtest1
    {
        [Column("id")]
        public int id { get; set; }
        [Column("k")]
        public int k { get; set; }
        [Column("c")]
        public string c { get; set; }
        [Column("pad")]
        public string pad { get; set; }
    }
}
