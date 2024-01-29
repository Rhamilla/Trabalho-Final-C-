using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    internal class Receita
    {
        public string Nome { get; }
        public int TempoPreparacao { get; }
        public string Dificuldade { get; }
        public string[] Categorias { get; }
        public string Descricao { get; }
        public List<Ingrediente> Ingredientes { get; }

        public Receita(string nome, int tempoPreparacao, string dificuldade, string[] categorias, string descricao, List<Ingrediente> ingredientes)
        {
            Nome = nome;
            TempoPreparacao = tempoPreparacao;
            Dificuldade = dificuldade;
            Categorias = categorias;
            Descricao = descricao;
            Ingredientes = ingredientes;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\nTempo de Preparação: {TempoPreparacao} minutos\nGrau de Dificuldade: {Dificuldade}\nCategorias: {string.Join(", ", Categorias)}\nDescrição: {Descricao}\nIngredientes:\n{string.Join("\n", Ingredientes)}";
        }
    }
}
