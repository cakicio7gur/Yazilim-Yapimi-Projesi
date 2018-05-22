using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YY_Proje
{
   public class Kullanici
    {
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Yazar { get; set; }
        public string Tarih { get; set; }
        public string Story { get; set; }
        public string Task { get; set; }
        public string Gorevli { get; set; }
        public string TeslimTarihi { get; set; }
        public string NotStarted { get; set; }
    }
}