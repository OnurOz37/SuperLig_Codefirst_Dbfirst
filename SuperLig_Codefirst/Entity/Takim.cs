using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperLig_Codefirst.Entity; 

namespace SuperLig_Codefirst.Entity
{
    public class Takim
    {
        [Key]
        public int TakimId { get; set; }
        
        public string TakimAd { get; set; }
        public string KurulusTarihi { get; set; }
        

        public string AntrenorAdi { get; set; }
        public ICollection<Player> Players { get; set;  }
       
            
            

    }
}
