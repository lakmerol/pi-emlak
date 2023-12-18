using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Estate : IModelBase
    {
        public int Price { get; set; }
        [MaxLength(25)]
        public string EstateType { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        [MaxLength(25)]
        public string AdType { get; set; }
        public DateTime AdDate { get; set; }
        [MaxLength(4)]
        public Int16 SquareMeter { get; set; }
        [MaxLength(2)]
        public Int16 RoomCount { get; set; }
        [MaxLength(2)]
        public Int16 SaloonCount { get; set; }
        [MaxLength(2)]
        public Int16 Floor { get; set; }
        [MaxLength(3)]
        public Int16? BuildingTotalFloor { get; set; }
        [MaxLength(3)]
        public Int16? BuldingAge { get; set; }
        [MaxLength(25)]
        public string? HeatingType { get; set; }
        public string? ImgUrl { get; set; }
        public bool Credible { get; set; }
        public int AgentNo { get; set; }
        public int? CustomerNo { get; set; }
    }
}
