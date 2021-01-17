using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Notebooks
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string System { get; set; }
        public int Price { get; set; }
    }
}
