using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IAbrivel
    {
        void Abrir();
    }

    public class Porta : IAbrivel
    {
        private bool aberta;

        public bool Aberta
        {
            get { return this.aberta; }
            set { this.aberta = value; }
        }

        public void Abrir()
        {
            Console.WriteLine("A porta está sendo aberta!");
            this.Aberta = true;
        }
    }

    public class Garrafa :IAbrivel
    {
        private bool aberta;

        public bool Aberta
        {
            get { return this.aberta; }
            set { this.aberta = value; }
        }

        public void Abrir()
        {
            Console.WriteLine("A garrafa está sendo aberta!");
            this.Aberta = true;
        }
    }

    public static class AbridorUniversal
    {
        public static void Abridor(IAbrivel abrivel)
        {
            abrivel.Abrir();
        }
    }
}
