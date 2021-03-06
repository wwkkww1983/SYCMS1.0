﻿
using System.ComponentModel.DataAnnotations;

namespace SyZero.Domain.Model
{
    public class User : EntityRoot
    {
      
        [MaxLength(200)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Paw { get; set; }
        [MaxLength(200)]
        public string Mail { get; set; }
        [MaxLength(200)]
        public string Phone { get; set; }
        [MaxLength(1000)]
        public string Headimg { get; set; }
        public int Utype { get; set; }
        [MaxLength(200)]
        public string Sex { get; set; }
        public System.DateTime AddTime { get; set; }
        public System.DateTime LastTime { get; set; }
        public int State { get; set; }
        public string L01 { get; set; }

        public string L02 { get; set; }

        public string L03 { get; set; }
    }
}
