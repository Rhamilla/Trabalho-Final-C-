using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    internal class Ingrediente
    {
        public string Nome { get; }
        public string Quantidade { get; }
        public string UnidadeMedida { get; }

        public Ingrediente(string nome, string quantidade, string unidadeMedida)
        {
            Nome = nome;
            Quantidade = quantidade;
            UnidadeMedida = unidadeMedida;
        }

        public override string ToString()
        {
            return $"{Quantidade} {UnidadeMedida} de {Nome}";
        }
    }
}
