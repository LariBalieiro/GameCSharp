using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLabirinto {

    class Program
    {
        //titulo.
        static string tituloDoJogo = "Meu Game";
        static string[,] labirinto = new string[10, 17]
        {
            //Linha {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#"},
            {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#"},
            {"#"," "," "," "," "," "," "," "," "," "," "," ","#","#","#","#","#"},
            {"#"," ","#","#","#","#","#","#","#","#","#"," ","#","#","#","#","#"},
            {"#"," "," "," "," "," "," "," "," "," ","#"," "," "," ","#","#","#"},
            {"#","#","#","#","#","#","#","#","#"," ","#","#","#"," ","#","#","#"},
            {"#","#","#"," "," "," "," "," ","#"," ","#","#","#"," ","#"," ","F"},
            {"#"," "," "," ","#","#","#"," ","#"," ","#"," "," "," ","#"," ","#"},
            {"#"," ","#","#","#","#","#"," "," "," ","#"," ","#","#","#"," ","#"},
            {"#"," ","#","#","#","#","#","#","#","#","#"," "," "," "," "," ","#"},
            {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#"},
        };

        static string jogador = "o";
        static int posLinha = 8;
        static int posColuna = 1;
        static void Main(string[] args)
        {
            Console.Title = tituloDoJogo;
            bool fimDeJogo = false;
            labirinto[8, 1] = jogador;

            while (!fimDeJogo) 
            {
                Console.Clear();
                //A Linha
                for(int linha = 0; linha < 10; linha++)
                {   //Coluna
                    for(int coluna = 0; coluna <17; coluna++)
                    {
                        Console.Write(labirinto[linha,coluna]);
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Para onde você deseja ir?");
                Console.WriteLine("> W = Cima");
                Console.WriteLine("> A = Esquerda");
                Console.WriteLine("> S = Baixo");
                Console.WriteLine("> D = Direita");
                Console.WriteLine();
                Console.Write("Meu Comando é: ");

                string comando = Console.ReadLine().ToUpper();

                //instruçao de if e else
            
                if (comando == "W")
                {
                    if (labirinto[posLinha - 1,posColuna] != "#")
                    {
                        labirinto[posLinha,posColuna] = " ";
                        posLinha--;
                    }
                }
                else if (comando == "A")
                {
                    if (labirinto[posLinha , posColuna - 1] != "#")
                    {
                        labirinto[posLinha, posColuna] = " ";
                        posColuna--;
                    }
                }
                else if (comando == "S")
                {
                    if (labirinto[posLinha + 1, posColuna  ] != "#")
                    {
                        labirinto[posLinha, posColuna] = " ";
                        posLinha++;
                    }
                }
                else if (comando == "D")
                {
                    if (labirinto[posLinha, posColuna + 1] != "#")
                    {
                        labirinto[posLinha, posColuna] = " ";
                        posColuna++;
                    }
                }

                labirinto[posLinha, posColuna] = jogador;

                if (labirinto[5, 16] == jogador)
                    fimDeJogo = true;
            }

            Console.Clear();
            Console.WriteLine("PARABÉNS VOÇÊ CHEGOU AO FIM DO LABIRINTO!");
            Console.WriteLine("Tecle ENTER  para finalizar");
            Console.ReadKey();

        }
    }
}