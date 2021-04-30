﻿
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LibraryProject.Data.Model
{
   public class Kategori:BaseEntity
    {
        [Required]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public string Ad { get; set; }
        public List<Kitap> Kitaplar { get; set; }

    }
}