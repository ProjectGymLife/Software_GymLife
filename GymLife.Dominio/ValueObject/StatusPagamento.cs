using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymLife.Dominio.ValueObject
{
    internal class StatusPagamento
    {
        public int ID_STATUS { get; private set; }
        public string DESCRICAO { get; private set; }
    }
}
