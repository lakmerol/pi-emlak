using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class MemberDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public int? HomeNumber { get; set; }
        public int PhoneNumber { get; set; }
        public string MailAdress { get; set; }
        public string? ImgUrl { get; set; }
        public Int16? AdCount { get; set; }
        public string? Estates { get; set; }
    }
}
