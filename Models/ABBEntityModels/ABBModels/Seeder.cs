using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB_Portal.Models.ABBEntityModels.ABBModels
{
    public class Seeder
    {
        [Key]
        public int SeederId { get; set; }

        public string SeederName { get; set; }

    }
}
