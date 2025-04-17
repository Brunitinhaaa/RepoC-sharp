using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        enum CoresPrimarias { Azul, Vermelho, Amarelo }
        enum Opcao { Criar, Excluir }

        static void Main(string[] args)
        {
            var qlqr_coisa = "asb123truefalse"; //var não especifica o tipo

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

            Console.WriteLine(num_inteiro + "\n");

            Console.WriteLine("Digite um numero inteiro:");
            int num = int.Parse(Console.ReadLine());        //espera o usuário dar enter (recebe valor digitado), parse (converte para inteiro) = CAST

            if (num < 3)
            {
                Console.WriteLine("número menor que 3");
            }
            else if (num == 3)
            {

                Console.WriteLine("número é 3");
            }
            else if ((num > 3) && (num < 7))
            {

                Console.WriteLine("número 4,5 ou 6");
            } 

                Console.WriteLine("\n");

            static void Msg_Oi()
            {
                Console.WriteLine("Oie, tudo bem?");
            }

            // duas maneiras de criar array: 

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

            Console.WriteLine("\nO arrey a seguir tem esse tanto de palavras:" + Array_texto.Length);

            Console.WriteLine("\n" + Array_texto[0]);
            Console.WriteLine(Array_texto[1]);
            Console.WriteLine(Array_texto[2]);
            Console.WriteLine(Array_texto[3]);
            Console.WriteLine(Array_texto[4]);

            string cor = "Azul";
            Console.WriteLine("\n" + cor);

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
            Console.WriteLine("\nChamada da função cor:");

            static void funcao_cor()
            {
                CoresPrimarias corfavorita = CoresPrimarias.Amarelo;
                Console.WriteLine((int)corfavorita); //2
                Console.WriteLine((CoresPrimarias)2 + "\n"); //Amarelo
            }

            funcao_cor();

            static void funcao_menu()
            {
                Console.WriteLine("Digite 1 para Criar ou 2 para Excluir:");

                int index = int.Parse(Console.ReadLine());

                Opcao opcaoSelecionada = (Opcao)index;

                switch (opcaoSelecionada)
                {
                    case Opcao.Criar:
                        Console.WriteLine("criado com sucesso");
                        break;
                    case Opcao.Excluir:
                        Console.WriteLine("excluido com sucesso");
                        break;
                }
            }

            //Console.WriteLine("\n Chamada da funcao menu:");
            //funcao_menu();

            //estruturas de REPETIÇÃO

            //while repete até a condição ser falsa

            int i = 0;
            while (i<2)
            {
                Console.WriteLine(i);
                i += 1; //msm q i++
            }

            //do while roda uma vez, e repete até ser falso

            int d = 2;
            do
            {
                Console.WriteLine("\n" + i);
                d += 1; //msm q i++
            } while (d < 2);

            //para condição verdadeira repete quantidade do contador

            Console.WriteLine("\n");

            for (int c = 0; c <= 2; c++)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("\n");

            for (int e = 3; e <= 0; e--)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("\n");

            string[] palavras = { "palavra1", "palavra2", "palavra3" };

            for (int p = palavras.Length -1; p >= 0; p--)
            {
                Console.WriteLine(palavras[p]);
            }

            Console.WriteLine("\n");

            for (int x = 0; x < palavras.Length; x++)
            {
                Console.WriteLine(palavras[x]);
            }

            //foreach usada pra percorrer array

            Console.WriteLine("\n");

            foreach (string palavra in palavras)
            {
                Console.WriteLine(palavra);
            }

            //quando a variável é declarada dentro de uma função, estamos declarando dentro de um escopo local, portanto
            // só poderemos acessa-la de dentro desse escopo local

            //quando a variável é declarada detro da classe, estamos declarando dentro de um escopo global, portanto
            //poderemos acessa-la de dentro de todo o escopo global

            //É uma estrutura que define um objeto: seus atributos (dados) e métodos (ações)

            //poderia adicionar outras pessoas na classe pessoa? 

     class Bolo
        {
            public string Sabor;
            public string Farinha;
            public int Ovos;

            public void Fazer()
            {
                Console.WriteLine($"Fazendo bolo de {Sabor} com {Farinha} e {Ovos} ovos.");
            }
        }

        class Bolos
        {
            public List<Bolo> ListaDeBolos = new List<Bolo>();

            public void AdicionarBolo(string sabor, string farinha, int ovos)
            {
                Bolo novo = new Bolo();
                novo.Sabor = sabor;
                novo.Farinha = farinha;
                novo.Ovos = ovos;

                ListaDeBolos.Add(novo);
            }

            public void MostrarTodos()
            {
                foreach (Bolo b in ListaDeBolos)
                {
                    Console.WriteLine($"Fazendo bolo de {b.Sabor} com {b.Farinha} e {b.Ovos} ovos.");
                }
            }
        }

        class Program
        {
            static void Main()
            {
                Bolos meusBolos = new Bolos();

                meusBolos.AdicionarBolo("Laranja", "250g", 3);
                meusBolos.AdicionarBolo("Chocolate", "300g", 4);
                meusBolos.AdicionarBolo("Fubá", "200g", 2);

                meusBolos.MostrarTodos();
            }
        }

        //criação d euma lista, e adicionando cada pessoa dentro dessa lista
        //decimal maneira que não preciso usar:
        /*Pessoa bruna = new Pessoa("Bruna");
        Pessoa joao = new Pessoa("João");
        Pessoa maria = new Pessoa("Maria");*/

        List<Pessoa> pessoas = new List<Pessoa>();

        pessoas.Add(new Pessoa("Bruna"));
        pessoas.Add(new Pessoa("João"));
        pessoas.Add(new Pessoa("Maria"));

        foreach (Pessoa p in pessoas)
        {
            p.Falar();
        }

    //encapsulamento:
    //private: guarda um segredo na classe
    //get: forma de pegar o segredo
    //set: forma de mudar o segredo
       private int idade; // segredo guardado

        public int Idade   // porta de acesso com regras
        {
            get { return idade; }     // pegar idade
            set { idade = value; }    // mudar idade
        }

        //atributo: local da classe (private)
        //propriedade: global, fora da classe (public)

        //construtor: Construtor é tipo uma forma que já vem com tudo dentro, pronta pra usar quando você cria o objeto.

        //sem construtor:
        Bolo bolo = new Bolo();
        bolo.Sabor = "Laranja";
        bolo.Ovos = 3;

        //com construtor:
        Bolo bolo = new Bolo("Laranja", 3);
        //na classe:
        public Bolo(string sabor, int ovos)
        {
            Sabor = sabor;
            Ovos = ovos;
    }

//herança: aquilo que é passado de uma classe pai sendo reescrito numa classe filho
/*class Animal
{
    public virtual void FazerSom()
    {
        Console.WriteLine("Som genérico");
    }
}

class Cachorro : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("Au Au");
    }
}*/

//this:this é como se a classe falasse: ‘estou falando do meu próprio atributo’
class Pessoa
{
    private string nome;

public void DefinirNome(string nome) //recebe o nome q foi adicionado pelo usuário
{
    this.nome = nome; // "this.nome" é o atributo
}

    //static -> função fica global, não rpecisa criar objeto
    //não static ->
    Classe n = new Classe();
                  n.Funcao();
    // Chamada:             // criando objeto
    Classe.Funcao();        // sem criar objeto
     // Chamada:             // criando objeto   
    List<tipo> item = new List<tipo>();
     item.Add(new item("ITEM1"));

    ///“Em C#, uma classe define atributos e métodos, 
    ///e o objeto é a instância dessa classe. 
    ///encapsulamento: public/ private
    ///herança:classe Animal -> Classe Animal : Cachorro (pd chamar o método do pai)
    ///propriedades com get/set: get pega a variável privada e o set muda seu valor
    ///métodos públicos e privados: acesso global, acesso só dentro da classe
    ///Sei usar this: "atributo é public ou private mas pertence a própria classe"
    ///
    ///🔧 Uso de construtores: serve para criar o objeto já com valores iniciais. 
    ///Ex: Pessoa p = new Pessoa("Bruna");
    ///
    ///⚙️ Métodos static e instanciados: 
    ///
    ///- static: pertence à classe. Pode ser chamado direto, sem usar "new".
    ///  Ex: Pessoa.Falar();
    ///
    ///- instanciado: pertence ao objeto. Só funciona depois de criar com "new".
    ///  Ex: Pessoa bruna = new Pessoa(); bruna.Falar();
    ///
    ///criar listas:     
    ///List<tipo/classe> nomeDaLista = new List<tipo/classe>();
    ///     classe:  nomeDaLista.Add(new tipo/classe("valor"));
    /// declaração:  nomeDaLista.Add("valor);
    ///     remove:  nomeDaLista.Remove("valor";
    ///nomeDaLista.Contains("valor");  // retorna true ou false
    ///nomeDaLista.Count;              // retorna um número inteiro

    ///🟡 Array (ex: string[])
    ///- Tamanho fixo
    ///- sem métodos prontos

    ///🟢 List (ex: List<string>)
    ///- Tamanho dinâmico 
    ///- Possui métodos úteis: Add(), Remove(), Contains(), Count...
    ///
    ///- Tratamento de erros:
    ///try  código que pode dar erro (evita que quebre com erro)
    ///catch (Exception e) o que fazer se der erro (ex: 10/0)
    ///finally sempre executa (mesmo com erro ou não)
    ///throw new Exception("Algo deu errado!");
