using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCSharp1
{
    public abstract class OperacaoMatematica
    {
        public abstract double calcular(double x, double y);
    }
    public class Soma : OperacaoMatematica
    {
        public override double calcular(double x, double y)
        {
            return x + y;
        }
    }
    public class Subtracao : OperacaoMatematica
    {
        public override double calcular(double x, double y)
        {
            return x - y;
        }
    }
    public class Contas
    {
        public static void mostrarCalculo(OperacaoMatematica operacao, double x, double y)
        {
            Console.WriteLine("O resultado é: " + operacao.calcular(x, y).ToString());
        }
    }
}
