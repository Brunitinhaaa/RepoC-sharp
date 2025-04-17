using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        enum CoresPrimarias { Azul, Vermelho, Amarelo }
        enum Opcao { Criar = 1, Excluir }

        static void Main(string[] args)
        {
            var qlqr_coisa = "asb123truefalse"; //var não especifica o texto

            dynamic qlqr_coisa2 = "asb123truefalse"; //único tipo q pode ser alterado posteriormente (não são boas práticas)

            int num_inteiro = 1;
            float num_flutuante = 1.5f; // necessário colocar f
            bool ved_ou_falso = true;
            string A = "Jubileu";       // texto usa "
            char carac_uinico = 'A';    // caractere usa '
            const string C = "C";       //constante não pode ter tipo nem valor alterado posteriormente

            Console.WriteLine(num_inteiro);

            // quando referencia uma variável já criada não declara seu tipo

            num_inteiro = 2;

            Console.WriteLine(num_inteiro);

            int num = int.Parse(Console.ReadLine());        //espera o usuário dar enter (recebe valor digitado), parse (converte para inteiro) = CAST

            if (num < 3)
            {
                Console.WriteLine("número menor que 3");
            }
            else if (num == 4)
            {

                Console.WriteLine("número é 4");
            }
            else if ((num > 4) && (num < 7))
            {

                Console.WriteLine("número 5 ou 6");
            }

            static void Msg_Oi()
            {
                Console.WriteLine("Oie, tudo bem?");
            }

            for (int i = 0; i <= 5; i++)
            {
                Msg_Oi();
            }

            string[] Array_texto = new string[5]{
                "oi",
                "tudo",
                "bem",
                "com",
                "voce?"
            };

            string[] Array_texto2 = {
                "oi",
                "tudo",
                "bem",
                "com",
                "voce?"
            };

            Console.WriteLine(Array_texto.Length);

            Console.WriteLine(Array_texto[0]);

            string cor = "Azul";

            switch (cor)
            { //só trabalha com valor = , não faz comparações

                case "Vermelho":
                    Console.WriteLine(cor);
                    break;
                case "Roxo":
                    Console.WriteLine(cor);
                    break;
                default:
                    Console.WriteLine("Não é vermelho nem roxo");
                    break;
            }

            static void funcao_cor()
            {
                CoresPrimarias corfavorita = CoresPrimarias.Amarelo;
                Console.WriteLine((int)corfavorita); //3
                Console.WriteLine((CoresPrimarias)3); //Amarelo
            }

            static void funcao_menu()
            {
                Console.WriteLine("Digite 1 para Criar ou 2 para Excluir:");

                int index = int.Parse(Console.ReadLine());

                Opcao opcaoSelecionada = (Opcao)index;

                switch (opcaoSelecionada)
                {
                    case Opcao.Criar:
                        break;
                    case Opcao.Excluir:
                        break;
                }
            }

            funcao_menu();
        }
    }
}
