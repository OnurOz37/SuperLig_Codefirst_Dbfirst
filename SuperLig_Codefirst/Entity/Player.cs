using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLig_Codefirst.Entity
{
    public class Player
    {
        [Key]
        public int  PlayerId { get; set; }
        
        public string  Name { get; set; }
        public string  Country { get; set; }
        
        public string  OynadigiTakim { get; set; }
        public int  Yas { get; set; }
        public int  FormaNumarasi { get; set; }
        public Takim Takims { get; set; }
    }
}
