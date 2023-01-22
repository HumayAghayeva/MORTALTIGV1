using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mortaltig.Domain.Models
{
    public class TeamMembers
    {
        [Key]
        public int Id { get;set; }  
        public string  FirstName { get;set; }  
        public string LastName { get;set; }  
        public string Position { get;set; }  
        public string PhotoUrl { get;set; }
        [NotMapped]
        public IFormFile Photo { get;set; }  
    }
}
