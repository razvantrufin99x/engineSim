using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engineSim
{
    public  class engine
    {
            public int cux ;
            public int cuy ;
            public int cux2 ;
            public int cuy2 ;

        public engine()
        {

        }

        public engine(int pcux, int pcuy, int pcux2, int pcuy2)
        {
            cux = pcux;
            cuy = pcuy;
            cux2 = pcux2;
            cuy2 = pcuy2;
        }

        public engine(ref engine pe)
        {
            cux = pe.cux;
            cuy = pe.cuy;
            cux2 = pe.cux2;
            cuy2 = pe.cuy2;
        }
    }
   
}
