using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mortaltig.Domain.Models
{
    public  class RoadMap
    {
        [Key]
        public int Id { get; set; }
        public int Index { get; set; }
        public string IndexName { get; set; }
        public string Text { get; set; }
    }
}
