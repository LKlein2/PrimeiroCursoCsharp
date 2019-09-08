using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using Exercicio5;
using ClassesPessoa;
using Persistencia.cs;
using ClassesMoeda;
using Interfaces;
using System.Collections;

namespace ProjetoCSharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Aula1
            #region RegionParteNome
            //String nome;
            //int um, dois = 0, soma = 0;
            //float tres = 90.5F;
            //um = 10;
            //dois = 5;

            //soma = (int)tres;
            //Console.WriteLine("Hello World");
            //Console.WriteLine("Qual o seu nome? ");
            //nome = Console.ReadLine();
            //Console.WriteLine("Bem vindo, {0}!", nome);
            #endregion

            #region RegionLacoFor
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("{0}, {1}", nome, i);
            //}
            //Console.WriteLine("O resultado de 10 / 5 é: {0}", (um / dois));
            //Console.WriteLine("Float virou {0}", soma);
            #endregion

            #region RegionIfElse
            //if (soma > 90)
            //{
            //    Console.WriteLine("É maior que 90");
            //}
            //else
            //{
            //    Console.WriteLine("É menor ou igual a 90");
            //}
            #endregion

            #region RegionCalculoFloat
            //int a = 35, b = 5, c = 7;
            //float resultado;
            //resultado = (a + b) / c;

            //var resultado2 = resultado; //A Variavel do tipo var recebe qualquer tipo de dado;

            //Console.WriteLine("Resultado final: {0}",((35.0 + 5.0) / 7.0));
            //Console.WriteLine("Resultado final por variavel é: {0}", resultado);
            //Console.WriteLine("Resultado final por variavel var é: {0}", resultado2);
            #endregion

            #region RegionExemploLinq
            ////var retorno = from a2 in args where a2 == "bool" select a2;
            #endregion

            #region RegionParse
            //string valor = "90";
            //int val1, val2;
            //int result;

            //val1 = int.Parse(valor);
            //object o = "qualquer coisa"; //Classe object recebe qualquer valor, não usar object, pq complica d+
            //o = Convert.ToString(val1); //Convert.toInt32 etc...
            //int.TryParse(valor, out result); //Tenta atribuir o valor "valor" para a variavel "result".
            #endregion

            #region RegionConversaoReal
            //ConversaoReal conversao = new ConversaoReal();
            //Console.WriteLine("Informe o valor em real:");
            //conversao.setReal(Convert.ToSingle(Console.ReadLine()));
            //Console.WriteLine("Informe o valor em dolar:");
            //conversao.setDolar(Convert.ToSingle(Console.ReadLine()));

            //Console.WriteLine("O valor convertido é: {0}", conversao.getValorConvertido());
            #endregion

            #region RegionStringForEach
            //String conca, concb;
            //conca = "dia ";
            //concb = "chuvoso";
            //conca += concb;
            //Console.WriteLine(conca);

            //conca = conca.Substring(0, 3);
            //Console.WriteLine(conca);
            //char letra = conca[0];
            //foreach(char valor in conca) {
            //    Console.Write(valor);
            //}

            #endregion

            #region RegionData
            //DateTime hoje = DateTime.Now.Date;
            //Console.WriteLine("O dia é {0}", (hoje.ToString("dd/MM/yyyy")));
            //if (hoje.Day > 25)
            //{
            //    Console.WriteLine("Caixa está fechado!");
            //}
            //else
            //{
            //    Console.WriteLine("Caixa ainda está aberto!");
            //}
            #endregion

            #region RegionParImparIfElse
            //int num1;
            //Console.WriteLine("Informe um número");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //if (num1 % 2 == 0)
            //{
            //    Console.WriteLine("É par!");
            //}
            //else
            //{
            //    Console.WriteLine("É ímpar!");
            //}
            #endregion

            #region RegionLacosRepeticao
            //for (int i = 0; i < 10; i++) //Dois tabs ele monta o for for + tab + tab
            //{
            //    Console.WriteLine(i);
            //}

            //int i2 = 0;
            //while (true)
            //{
            //    if (i2 == 3) continue; //Pula pra proxima execução.
            //    Console.WriteLine(i2);
            //    if (i2 > 9) break;
            //    i2++;
            //}

            //i2 = 0;
            //do
            //{
            //    Console.WriteLine(i2);
            //    if (i2 > 9) break;
            //    i2++;
            //} while (true);
            #endregion

            #region RegionArray
            //string[] cursos = new string[5];
            //string[] cursos2 = { "Curso1", "Curso2", "Curso3", "Curso4", "Curso5" };

            //foreach (var curso in cursos2)
            //{
            //    Console.WriteLine(curso);
            //}

            //object[] vetorEstranho = { 1, "teste", 12.5f, new conversaoreal(), new DateTime() };
            //foreach (var obj in vetorEstranho)
            //{
            //    if (obj.GetType() == typeof(int))
            //    {

            //    }
            //}
            #endregion

            #region RegionUExercicioArray
            //int[] valores = new int[5];

            //for (int i = 0; i < valores.Length; i++)
            //{
            //    Console.Write("Informe um valor: \t");
            //    valores[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < valores.Length; i++)
            //{
            //    //Console.WriteLine(valores[i]);
            //    Console.WriteLine("Valor: {0}, Posição: {1}, Quadrado: {2}, Cubo: {3}!", valores[i], i, (Math.Pow(valores[i], 2)), (Math.Pow(valores[i], 3)));
            //}

            #endregion

            #region RegionMatriz
            //int[,] matriz = new int[5, 5];

            //matriz[0, 0] = 10;
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        matriz[i, j] = i * j;
            //    }
            //}
            #endregion

            #region RegionPrimeiroMetodo
            //Metodos publicos começam com letra maiuscula, privados com minuscula.
            //int[] i;

            //i = PrimeiroMetodo("teste");
            //Console.WriteLine(i[0] + ", " + i[1]);

            #endregion

            #region RegionMetodoParametrosOpcionais

            //ParametrosOpcionais(10);
            //ParametrosOpcionais(10, 5);

            #endregion

            #region RegionCalculadora

            //Calculadora c = new Calculadora(10, 5);
            //Console.WriteLine(c.Soma());
            //Console.WriteLine(c.Subtrair());


            #endregion

            #region ProcuraMaior

            //int[] vetor = { 10, 11, 13, 15, 12, 20 };
            //Console.WriteLine(ProcuraMaior.GetMaior(vetor[0], vetor[1]));
            //Console.WriteLine(ProcuraMaior.GetMaior(vetor[0], vetor[1], vetor[2], vetor[3]));
            //Console.WriteLine(ProcuraMaior.GetMaior(vetor));
            #endregion

            #region RegionTryParseOut
            //string valor = "10";
            //int nro;

            //if (int.TryParse(valor, out nro))
            //{
            //    Console.WriteLine("NRO: " + nro);
            //}
            //else
            //{
            //    Console.WriteLine("Erro!");
            //}
            #endregion

            #region RetornoObjeto
            //Não é recomendado;
            //Object objeto = CriarObjeto();
            #endregion

            #endregion

            #region Aula2

            #region InstanciaçãoObjetos
            //Classes.Veiculo v = new Veiculo();
            //Veiculo v = new Veiculo();
            //Automovel a = new Automovel();
            //Veiculo va = new Automovel();

            //Automovel carro = new Automovel();
            //carro.Nome = "Gol";
            //carro.Ano = 2009;
            //carro.Portas = 4;

            //Motocicleta moto = new Motocicleta();
            //moto.Nome = "CG";
            //moto.Ano = 2008;
            //moto.Cilindrada = 125;

            //MostraCaracteristicas(moto);
            //MostraCaracteristicas(carro);
            #endregion

            #region Exercicio5ProdutoAlmoxarifado
            //CentroCusto cc = new CentroCusto(1, "CentroCusto_1");
            //Almoxarifado a = new Almoxarifado(1, "Almoxarifado_1", "João da silva", cc);
            //Produto p = new Produto(1, "Produto_1", "Roberval de souza");
            //ProdutoAlmoxarifado pa = new ProdutoAlmoxarifado(p, a, 10);







            #endregion

            #region OperaçãoMatematicaAbstração
            //OperacaoMatematica op = new Soma();
            //Contas.mostrarCalculo(op, 10, 11);

            //op = new Subtracao();
            //Contas.mostrarCalculo(op, 10, 11);
            #endregion

            #endregion

            #region Aula3

            #region Pessoa

            //Não pode-se instanciar uma classe abstrata.
            //Pessoa p = new Pessoa(1, DateTime.Now);
            //p.GerarId();

            //PessoaFisica pf = new PessoaFisica(2, DateTime.Now);
            //pf.GerarId();
            //pf.Cpf = "0010020";
            //pf.Nome = "Joao da silva";

            //PessoaJuridica pj = new PessoaJuridica(3, DateTime.Now);
            //pj.GerarId();
            //pj.Cnpj = "020980980070";
            //pj.RazaoSocial = "Empresa software solutions";

            //PessoaPersistencia pp = new PessoaPersistencia();
            ////pp.Salvar(p);
            //try
            //{
            //    pp.Salvar(pf);
            //}
            //catch (DocumentoInvalidoException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //try
            //{
            //    pp.Salvar(pj);
            //}
            //catch (DocumentoInvalidoException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally // Executa sempre, com erro ou não!
            //{
            //    Console.WriteLine("Obrigado por utilizar esse programa!");
            //}


            //Console.WriteLine(pf);
            //Console.WriteLine(pj);

            #endregion

            #region Cofre

            //Real r = new Real("Real", 1000.0, 1.04);
            //Euro e = new Euro("Euro", 590.0, 3.75);

            //Cofre c = new Cofre();
            //c.Add(new Real("Real", 1000.0, 1.04));
            //c.Add(new Euro("Euro", 590.0, 3.75));
            //c.Add(new Real("Real", 1200.5, 1.01));
            //c.ValorAcumuladoEmReais();
            //Console.WriteLine("O valor final é: " + c.ValorFinal);


            #endregion

            #region Interface

            //Porta porta = new Porta();
            //Garrafa garrafa = new Garrafa();

            //AbridorUniversal.Abridor(porta);
            //AbridorUniversal.Abridor(garrafa);

            #endregion

            #region ENUM

            //não entendi

            #endregion

            #region ArrayList



            #endregion



            #endregion

            #region Aula4

            #region ArrayList

            ArrayList lista = new ArrayList();
            lista.Add(1);
            lista.Add("@");

            ////lista todos
            //foreach (var item in lista)
            //{
            //    Console.WriteLine(item);
            //}

            ////Lista somente as strings
            //foreach (String item in lista)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < lista.Count; i++)
            //{
            //    Console.WriteLine(lista[i]);
            //}

            //lista.RemoveAt(1);

            #endregion

            #region HashTable

            //Arraylist é por posição, hash é por chave valor;

            //Hashtable hash = new Hashtable();
            //hash.Add("Chave_1", "Valor_1");
            //hash.Add("Chave_2", "Valor_2");
            //hash.Add(3, lista);
            //hash.Add("Chave_4", 4);
            //hash.Add(5, 50000);

            //hash["Chave_1"] = "novoValor";

            //ArrayList lista2 = (ArrayList) hash[3];

            //foreach (object o in hash.Values)
            //{
            //    Console.WriteLine("Valor: " + o);
            //}

            //foreach (object o in hash.Keys)
            //{
            //    Console.WriteLine("Chave: " + o);
            //}

            #endregion

            #region Queue

            //Queue q = new Queue();
            //q.Enqueue(6);
            //q.Enqueue(3);

            //var primeiroEntrar = q.Dequeue(); //Remove o 6 e atribui ao primeiroEntrar



            #endregion

            #region StackPilha

            //Stack s = new Stack();
            //s.Push(1);
            //s.Push(2);

            //var ultimoEntrar = s.Pop();

            #endregion

            #region List<>

            List<Localizacao> local = new List<Localizacao>();

            local.Add(new Localizacao(1, 2));

            #endregion

            #region Dictionary

            //Parecido com hash mas podemos especificar objetos.
            //Dictionary<String, Localizacao> chavesLocais = new Dictionary<string, Localizacao>();

            //chavesLocais.Add("sul", new Localizacao(100, 500));
            //chavesLocais.Add("leste", new Localizacao(150, 320));

            //Console.WriteLine("X do sul: " + chavesLocais["sul"].X); // Mostra 100
            //Console.WriteLine("Y do sul: " + chavesLocais["sul"].Y + "\n"); // Mostra 500

            //foreach (string chave in chavesLocais.Keys)
            //{
            //    Console.WriteLine(chavesLocais[chave]); //Mostra o toString que ta como override;
            //    Console.WriteLine("Localização X: " + chave + " : " + chavesLocais[chave].X);
            //    Console.WriteLine("Localização Y: " + chave + " : " + chavesLocais[chave].Y + "\n");

            //}
            #endregion

            #region ExercicioLista + conversão + tryParse + List

            //list<int> l = new list<int>();

            //do
            //{
            //    int i;
            //    console.write("informe um número: \t");
            //    if (int.tryparse(console.readline(), out i))
            //    {
            //        if (!(l.contains(i)))
            //        {
            //            l.add(i);
            //        }
            //        else
            //        {
            //            console.writeline("valor já está no vetor!");
            //        }
            //    }
            //    else
            //    {
            //        console.writeline("erro de covnersão, insira valores to tipo inteiro!");
            //    }
            //} while (l.count < 10);

            //console.writeline("o vetor está cheio!");
            //foreach (int valor in l)
            //{
            //    console.write(valor + "\t");
            //}
            #endregion

            #region ExercicioDictionary

            //Dictionary<string, Veiculo> veiculos = new Dictionary<string, Veiculo>();
            //veiculos.Add("AAA1111", new Veiculo("Gol", 2009));
            //veiculos.Add("BBB2222", new Automovel("Astra", 2006, 4));
            //veiculos.Add("CCC3333", new Caminhao("Scania", 2018, 2, 6));

            //foreach (var chave in veiculos.Keys)
            //{
            //    Console.Write("\nVeiculo " + veiculos[chave].Nome + " - Ano: " + veiculos[chave].Ano);
            //    if (veiculos[chave] is Caminhao)
            //    {
            //        Caminhao c = veiculos[chave] as Caminhao;
            //        Console.Write(" é um caminhão e possui: " + c.Portas + " portas e " + c.Eixos + " eixos.");
            //    }
            //    else if (veiculos[chave] is Automovel)
            //    {
            //        Automovel a = veiculos[chave] as Automovel;
            //        Console.Write(" é um automovel e possui: " + a.Portas + " portas.");
            //    }
            //}


            #endregion

            #region LINQ básico

            //List<int> numeros = new List<int>();
            //for (int i = 0; i < 100; i++)
            //{
            //    Random rand = new Random(i);
            //    numeros.Add(rand.Next(1000));
            //}
            //var numerosMaioresQue100 = numeros.Where(n => n > 100).ToList(); //to list força o retorno de uma List<>
            //var numerosMenoresQue100 = numeros.Where(n => n < 100).First(); //retorna o primeiro menor que cem.
            //var existeCem = numeros.Exists(n => n == 100); //Retorna boolean se existe 100
            //var maiores500 = from numero
            //                 in numeros
            //                 where numero > 500
            //                 orderby numero
            //                 select numero;

            //foreach (var n in maiores500)
            //{
            //    Console.WriteLine(n);
            //}




            #endregion

            #endregion

            Console.ReadKey();
        }
        #region EnumMethods
        static void TestDia(DiaDaSemana dia)
        {

        }

        public enum DiaDaSemana
        {
            Segunda = 2,
            Terça = 3,
            Quarta = 4
        }
        #endregion

        #region ConceitosBasicosMethods
        #region MethodPrimeiroMetodo
        static int[] PrimeiroMetodo(string palavra)
        {
            return new int[] {palavra.Length, 2};
        }
        #endregion

        #region MethodParametrosOpcionais1
        //Os parametros opcionais devem estar depois dos parametros obrigatorios, esses devem ter valor default definido.
        static void ParametrosOpcionais (int parametroObrigatorio, int parametroOpcional = 0)
        {
            Console.WriteLine(parametroObrigatorio);
            Console.WriteLine(parametroOpcional);
        }
        #endregion

        #region MethodRetornaObjeto
        static Object CriarObjeto()
        {
            return new
            {
                Nome = "lucas",
                Idade = 33
            };
        }
        #endregion
        #endregion

        #region OrientaçãoObjetosMethods

        #region MethodMostrarCaracteristicasPolimorfismo
        public static void MostraCaracteristicas(Veiculo veiculo)
        {
            Console.WriteLine("Modelo: " + veiculo.Nome);
            Console.WriteLine("Ano " + veiculo.Ano);
            if (veiculo is Automovel)
            {
                Console.WriteLine("Portas: " + (veiculo as Automovel).Portas);
                if (veiculo is Caminhao)
                {
                    Console.WriteLine("Eixos: " + (veiculo as Caminhao).Eixos);
                }
            }
            if (veiculo is Motocicleta)
            {
                Console.WriteLine("Cilindrada: " + (veiculo as Motocicleta).Cilindrada);
            }
        }
        #endregion
        
        

        #endregion

    }
    #region ConceitosBasicosClasses
    #region ClasseConversaoReal
    class conversaoreal
    {
        private float real;
        private float dolar;

        public void setreal(float real)
        {
            this.real = real;
        }

        public void setdolar(float dolar)
        {
            this.dolar = dolar;
        }

        public float getvalorconvertido()
        {
            return (real * dolar);
        }
    }
    #endregion

    #region ClasseCalculadora
    class Calculadora
    {
        private double valor1;
        private double valor2;

        public Calculadora() {}
        public Calculadora (double valor1, double valor2)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
        }
        //Não se usa getters ans setters em c#, se usam propertys.
        public void SetValor1(double valor1)
        {
            this.valor1 = valor1;
        }
        public double GetValor1()
        {
            return this.valor1;
        }
        public void SetValor2(double valor2)
        {
            this.valor2 = valor2;
        }
        public double GetValor2()
        {
            return this.valor1;
        }
        //Metodos
        public double Soma()
        {
            return this.valor1 + this.valor2;
        }
        public double Subtrair()
        {
            return this.valor1 = this.valor2;
        }
    }
    #endregion

    #region ClasseProcuraMaior
    class ProcuraMaior
    {
        public static int GetMaior (int valor1, int valor2)
        {
            int maior;
            maior = valor1;
            if (valor2 > maior)
            {
                maior = valor2;
            }
            return maior;
        }

        public static int GetMaior (int valor1, int valor2, int valor3, int valor4)
        {
            int maior;
            maior = valor1;
            maior = GetMaior(maior, valor2);
            maior = GetMaior(maior, valor3);
            maior = GetMaior(maior, valor4);
            return maior;
        }

        public static int GetMaior (int[] vetor)
        {
            int maior;
            maior = vetor[0];
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                }
            }
            return maior;
        }
    }
    #endregion
    #endregion

    public class Localizacao
    {
        int x, y;

        public Localizacao(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public override string ToString()
        {
            return "X: " + X + " Y: " + Y;
        }
    }

}