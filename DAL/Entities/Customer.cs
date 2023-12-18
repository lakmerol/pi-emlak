using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Customer : IModelBase
    {
        [MaxLength(25)]
        public string Name { get; set; }
        [MaxLength(25)]
        public string Surname { get; set; }
        [MinLength(3)]
        [MaxLength(11)]
        public string Password { get; set; }
        [MaxLength(11)]
        public int? HomeNumber { get; set; }
        [MaxLength(11)]
        public int PhoneNumber { get; set; }
        [MaxLength(50)]
        public string MailAdress { get; set; }
        public string? ImgUrl { get; set; }
        public Int16? AdCount { get; set; }
        public string? Estates { get; set; }
    }
}
