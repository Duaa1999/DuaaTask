using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiApp.Models
{
    public class User : IModelBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Dob { get; set; }
        public int Age { get; set; }

          public ICollection<Post> Posts { get; set; }
     //   public ICollection<Post> RPosts { get; set; }
    }
}
