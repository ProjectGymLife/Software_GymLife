using GymLife.Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymLife.Dominio.ValueObject
{
    internal class Exercicios
    {

        public int ID_EXERCICIO { get; private set; }
        public string NOME_EXERCICIO { get; private set; }
        public string DESCRICAO { get; private set; }
        public string ALVO_MUSCULAR { get; private set; }
        public string EQUIPAMENTO { get; private set; }

    }
}