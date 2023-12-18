using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Agent : IModelBase
    {
        [MaxLength(100)]
        public string AgentName { get; set; }
        [MaxLength(50)]
        public string AuthorizedPerson { get; set; }
        [MaxLength(250)]
        public string Adress { get; set; }
        [MaxLength(100)]

        [EmailAddress]
        public string MailAdress { get; set; }
        [MaxLength(10)]
        public int? PostalCode { get; set; }
        [MaxLength(11)]
        public int Phone { get; set; }
        [MaxLength(11)]
        public int? FaxNumber { get; set; }
        public DateTime SignInDate { get; set; }
        public string? ImgUrl { get; set; }
        [MinLength(3)]
        [MaxLength(11)]
        public string Password { get; set; }
    }
}
