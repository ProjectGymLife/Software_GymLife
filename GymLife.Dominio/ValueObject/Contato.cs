using GymLife.Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymLife.Dominio.ValueObject
{
    internal class Contato
    {

        public int ID_CONTATO { get; private set; }
        public string TELEFONE { get; private set; }
        public string EMAIL { get; private set; }

    }
}