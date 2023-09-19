using GymLife.Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymLife.Dominio.Entities
{
    internal class Treinamento
    {
        public int ID_TREINAMENTO { get; private set; }
        public DateTime DATA_INICIO { get; private set; }
        public DateTime DATA_TERMINO { get; private set; }
        public string EXERCICIOS { get; private set; }
        public int ID_SERIES { get; private set; }
        public int ID_INSTRUTOR { get; private set; }
       
    }
}
