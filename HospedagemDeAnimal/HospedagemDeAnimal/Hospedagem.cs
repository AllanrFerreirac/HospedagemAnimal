using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospedagemDeAnimal
{
    public class Hospedagem
    {
        public int Id { get; set; }
        public int id_animal { get; set; }
        public DateTime checkin { get; set; }
        public DateTime checkout { get; set; }
        public string status { get; set; }
    }
}
