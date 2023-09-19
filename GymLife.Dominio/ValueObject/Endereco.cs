using GymLife.Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace GymLife.Dominio.ValueObject
{
    internal class Endereco
    {
        public int ID_ENDERCO { get; private set; }
        public string RUA { get; private set; }
        public int NUMERO { get; private set; }
        public string COMPLEMENTO { get; private set; }
        public string CIDADE { get; private set; }
        public string ESTADO { get; private set; }
        public string CEP { get; private set; }


    }
}



