using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLig_Codefirst.Entity
{
    public class Antrenor

    {
        [Key]
        public int AntrenorId { get; set; }
       
        public string  AntrenorAdi { get; set; }
       
        public string TakimI { get; set; }
        public int  Yas { get; set; }
        public string  Ulke { get; set; }


    }
}
