using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markoGalavićObjektnoOrijentiranje
{
    class Program
    {
        static void Main(string[] args)
        {
            float ProsječnaVisinaKata;
           
            Neboder Tower = new Neboder(200, 100);

            Tower.setVisina(Tower.getVisina() + 10);
            Tower.setBrojKatova(Tower.getBrojKatova() + 1);

            ProsječnaVisinaKata = Tower.getVisina() / Tower.getBrojKatova();
            Console.WriteLine("Prosjecna visina kata je:" + ProsječnaVisinaKata);
            Console.ReadKey();
        }
    }
}



