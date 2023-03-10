using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] semana = { "domingo", "segunda", "terça", "quarta", "quinta", "sexta" };
            string[] newSemana = 
            foreach (string s in semana)
            {
                Console.WriteLine(s);
            }
            for(int i = semana.Length - 1; i >= 0; i--)
            {
                newSemana.Append(semana[i]);

            }
            foreach(string s in newSemana)
            {
                Console.WriteLine(s);
            }
            
        }
    }
}
