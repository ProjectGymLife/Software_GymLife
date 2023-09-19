using GymLife.Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymLife.Dominio.Entities
{
    internal class AlertaPagamento
    {
        public int ID_ALERTA { get; private set; }
        public int ID_ALUNO { get; private set; }
        public DateTime DATA_ALERTA { get; private set; }
        public decimal VALOR_DEVOLVIDO { get; private set; }
        public int ID_STATUS { get; private set; }

    }
}
