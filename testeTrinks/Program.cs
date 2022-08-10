using System.Windows;
using System.Threading;

namespace Bingo_Random
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Clique em <X> para iniciar o Bingo");
            string acesso = Console.ReadLine();



            while (acesso != "x")
            {
                Console.WriteLine("Tecla <x> não identificada");
                Console.WriteLine("Clique em <X> para iniciar o Bingo");
                acesso = Console.ReadLine();
                
            }

            if (acesso == "x")
            {
                Random aleatorio = new Random();

                int inicial = 1;
                int final = 72;
                int Limite = 72;

                int sorteado;
                int[] verificador = new int[Limite];


                int Resultado;

                for (int i = 0; i < Limite; i++)
                {
                Inicio:
                    sorteado = aleatorio.Next(inicial, final + 1);

                    for (int x = 0; x <= Limite - 1; x++)
                    {
                        if (verificador[x] == sorteado)
                        {
                            goto Inicio;
                        }
                    }

                    Resultado = /*Resultado + " " +*/ sorteado;
                    Console.WriteLine(Resultado);
                    verificador[i] = sorteado;
                    //Tempo para aparecer cada número e os jogadores poderem marcar suas cartelas
                    Thread.Sleep(4000);
                }
            }           


        }
    }
}
