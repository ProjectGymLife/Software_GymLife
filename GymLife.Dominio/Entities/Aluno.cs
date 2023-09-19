using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymLife.Dominio.Entities
{
    internal class Aluno
    {
        public int ID_ALUNO { get; private set; }
        public string NOME { get; private set; }
        public DateTime DATA_NASCIMENTO { get; private set; }
        public int ID_ENDERECO { get; private set; }
        public int ID_CONTATO { get; private set; }
        public DateTime DATA_INSCRICAO { get; private set; }
        public int ID_TREINAMENTO { get; private set; }



    }
}
