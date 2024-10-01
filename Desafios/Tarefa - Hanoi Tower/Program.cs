using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Tarefa___Hanoi_Tower
{
    class Program
    {
        private const int DISCS_COUNT = 10; // Número de discos
        private const int DELAY_MS = 250; // Delay entre os movimentos
        private static int _columnSize = 30; // Largura da coluna para visualização

        static void Main(string[] args)
        {
            // Ajusta a largura da coluna com base no número de discos
            _columnSize = Math.Max(6, GetDiscWidth(DISCS_COUNT) + 2);
            HanoiTower algorithm = new HanoiTower(DISCS_COUNT);

            // Registra o evento para visualização após cada movimento
            algorithm.MoveCompleted += Algorithm_Visualize;

            // Mostra o estado inicial das torres sem discos
            Algorithm_Visualize(algorithm, EventArgs.Empty);
            algorithm.Start();
        }

        private static void Algorithm_Visualize(object sender, EventArgs e)
        {
            Console.Clear();
            // Acessa propriedades e métodos da classe
            HanoiTower algorithm = (HanoiTower)sender;
            if (algorithm.DiscsCount <= 0)
            {
                return;
            }

            char[][] visualization = InitializeVisualization(algorithm);
            PrepareColumn(visualization, 1, algorithm.DiscsCount, algorithm.From);
            PrepareColumn(visualization, 2, algorithm.DiscsCount, algorithm.To);
            PrepareColumn(visualization, 3, algorithm.DiscsCount, algorithm.Auxiliary);

            // Exibe o cabeçalho
            Console.WriteLine(Center("FROM") + Center("TO") + Center("AUXILIARY"));
            DrawVisualization(visualization);
            Console.WriteLine();
            Console.WriteLine($"Number of moves: {algorithm.MovesCount}");
            Console.WriteLine($"Number of discs: {algorithm.DiscsCount}");

            // Pequeno delay para visualização
            Thread.Sleep(DELAY_MS);
        }

        private static char[][] InitializeVisualization(HanoiTower algorithm)
        {
            // Criando matriz para a visualização
            char[][] visualization = new char[algorithm.DiscsCount][];
            for (int y = 0; y < visualization.Length; y++)
            {
                visualization[y] = new char[_columnSize * 3];
                // Preenche a linha com espaços
                for (int x = 0; x < _columnSize * 3; x++)
                {
                    visualization[y][x] = ' ';
                }
            }
            return visualization;
        }

        private static void PrepareColumn(char[][] visualization, int column, int discsCount, Stack<int> stack)
        {
            int margin = _columnSize * (column - 1);    
            for (int y = 0; y < stack.Count; y++)
            {
                int size = stack.ElementAt(y);
                // Ajusta para que os discos maiores estejam na base e os menores no topo
                int row = discsCount - (stack.Count - y);
                int columnStart = margin + discsCount - size; // Posição inicial do disco
                int columnEnd = columnStart + GetDiscWidth(size); // Posição final do disco

                // Preenche a linha com o caractere de disco
                for (int x = columnStart; x <= columnEnd; x++)
                {
                    visualization[row][x] = '\u2580'; // Caractere para o disco
                }
            }
        }

        private static void DrawVisualization(char[][] visualization)
        {
            // Exibe a visualização da torre
            for (int y = 0; y < visualization.Length; y++)
            {
                Console.WriteLine(new string(visualization[y]));
            }
        }

        private static string Center(string text)
        {
            // Retorna o texto centralizado com base na largura da coluna
            int margin = (_columnSize - text.Length) / 2;
            return text.PadLeft(margin + text.Length).PadRight(_columnSize);
        }

        private static int GetDiscWidth(int size)
        {
            // Garante que cada disco tenha um espaço maior que o anterior
            return 2 * size - 1;
        }
    }
}