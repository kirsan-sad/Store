using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace Store.Models
{
    [Table(Name = "Mobile_Phone")]
    public class Phones
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Brand")]
        public string Brand { get; set; }

        [Column(Name = "Model")]
        public string Model { get; set; }

        [Column(Name = "System")]
        public string System { get; set; }

        [Column(Name = "Price")]
        public int Price { get; set; }
    }
}
