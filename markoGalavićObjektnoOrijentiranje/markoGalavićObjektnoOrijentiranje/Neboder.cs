using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markoGalavićObjektnoOrijentiranje
{
    class Neboder
    {
        private int visina;
        private int BrojKatova;

        public override string ToString()
        {
            string ispis = "\nVisina: " + visina + "\nBroj katova: " + BrojKatova;
            return ispis;
        }
        public Neboder()
        {

        }

        public Neboder(int visina, int BrojKatova)
        {
            this.visina = visina;
            this.BrojKatova = BrojKatova;
        }
    

      

        public int getVisina()
        {
            return visina;
        }
        public void setVisina(int visina)
        {
            this.visina = visina;
        }
        public int getBrojKatova()
        {
            return BrojKatova;
        }
        public void setBrojKatova(int BrojKatova)
        {
            this.BrojKatova = BrojKatova;
        }
       
        
    }
}
        
    

