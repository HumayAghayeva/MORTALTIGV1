using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mortaltig.Domain.Models
{
    public  class test
    {
        public string PhotoUrl { get; set; }
        public IFormFile Photo { get; set; }
    }
}
