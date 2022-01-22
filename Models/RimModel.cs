﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using proiect_daw.Entities;
namespace proiect_daw.Models
{
    public class RimModel
    {
        [Key]
        public int RimID { get; set; }
        [Required(ErrorMessage = "Dimensiunea este obligatorie!")]
        public ushort Size { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public float ET { get; set; }
        public float J { get; set; }
        public float HubSize { get; set; }
        public virtual ICollection<CarRim> CarRims { get; set; }
    }
}
