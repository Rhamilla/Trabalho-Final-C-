using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criação de uma lista para armazenar as receitas
            List<Receita> listaReceitas = new List<Receita>();

            while (true)
            {
                // Menu principal
                Console.WriteLine("==== Sistema de Gestão de Receitas ====");
                Console.WriteLine("Digite 1 para Adicionar Receita");
                Console.WriteLine("Digite 2 para Listar Todas as Receitas");
                Console.WriteLine("Digite 3 para Listar por Dificuldade");
                Console.WriteLine("Digite 4 para Listar por Tempo de Preparação");
                Console.WriteLine("Digite 5 para Sair");

                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                Console.Clear();

                switch (opcao)
                {
                    case "1":
                        // Adicionar uma nova receita
                        Receita novaReceita = AdicionarReceita();
                        listaReceitas.Add(novaReceita);
                        Console.WriteLine("Receita adicionada com sucesso!");
                        break;

                    case "2":
                        // Listar todas as receitas
                        ListarReceitas(listaReceitas);
                        break;

                    case "3":
                        // Listar por grau de dificuldade
                        ListarPorDificuldade(listaReceitas);
                        break;

                    case "4":
                        // Listar por tempo de preparação
                        ListarPorTempoPreparacao(listaReceitas);
                        break;

                    case "5":
                        // Sair do programa
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Selecione uma das opções disponiveis.");
                        break;
                }
            }
        }

        // Função para adicionar uma nova receita
        static Receita AdicionarReceita()
        {
            Console.Write("Nome da Receita: ");
            string nome = Console.ReadLine();

            Console.Write("Tempo de Preparação (em minutos): ");
            int tempoPreparacao = int.Parse(Console.ReadLine());

            Console.Write("Grau de Dificuldade (Facil, Medio ou Dificil): ");
            string dificuldade = Console.ReadLine();

            Console.Write("Categorias (Doce ou Salgado): ");
            string[] categorias = Console.ReadLine().Split(',');

            // Lista de ingredientes
            List<Ingrediente> ingredientes = new List<Ingrediente>();
            Console.WriteLine("Adicione os Ingredientes um por um (Digite 'Fim' quando terminar):");

            while (true)
            {
                Console.Write("Nome do Ingrediente (ou 'Fim' para encerrar): ");
                string nomeIngrediente = Console.ReadLine();

                if (nomeIngrediente.ToLower() == "fim")
                    break;

                Console.Write("Quantidade: ");
                string quantidade = Console.ReadLine();

                Console.Write("Unidade de Medida: ");
                string unidadeMedida = Console.ReadLine();

                // Adiciona o ingrediente à lista
                ingredientes.Add(new Ingrediente(nomeIngrediente, quantidade, unidadeMedida));
            }

            Console.Write("Descrição do Processo de Preparo: ");
            string descricao = Console.ReadLine();

            Console.Clear();

            // Retorna a nova receita criada
            return new Receita(nome, tempoPreparacao, dificuldade, categorias, descricao, ingredientes);
            
        }

        // Função para listar todas as receitas
        static void ListarReceitas(List<Receita> receitas)
        {
            Console.WriteLine("==== Todas as Receitas ====");
            foreach (var receita in receitas)
            {
                Console.WriteLine(receita);
                Console.WriteLine("-------------------------");
                Console.ReadLine();
            }
            
            Console.Clear();
        }

        // Função para listar por grau de dificuldade
        static void ListarPorDificuldade(List<Receita> receitas)
        {
            Console.Write("Digite o grau de dificuldade desejado (Facil, Medio ou Dificil): ");
            string dificuldade = Console.ReadLine();

            Console.WriteLine($"==== Receitas com Dificuldade '{dificuldade}' ====");
            foreach (var receita in receitas)
            {
                if (receita.Dificuldade.Equals(dificuldade, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(receita);
                    Console.WriteLine("-------------------------");
                }
            }
            
            Console.Clear();
        }

        // Função para listar por tempo de preparação
        static void ListarPorTempoPreparacao(List<Receita> receitas)
        {
            Console.Write("Digite o tempo máximo de preparação (em minutos): ");
            int tempoMaximo = int.Parse(Console.ReadLine());

            Console.WriteLine($"==== Receitas com Tempo de Preparação até {tempoMaximo} minutos ====");
            foreach (var receita in receitas)
            {
                if (receita.TempoPreparacao <= tempoMaximo)
                {
                    Console.WriteLine(receita);
                    Console.WriteLine("-------------------------");
                    Console.ReadLine();
                }
            }

            Console.Clear();
        }
    }
}