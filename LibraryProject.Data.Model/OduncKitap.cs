using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Data.Model
{
   public class OduncKitap:BaseEntity
    {
        [Required]
        public int KitapId { get; set; }
        [Required]
        public int UyeId { get; set; }
        [Required]
        public DateTime AlisTarihi { get; set; }
        [Required]
        public DateTime GetirecegiTarihi { get; set; }
        public DateTime? GetirdigiTarih { get; set; }


    }
}
