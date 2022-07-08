using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engineSim
{
    public  class engine
    {



            public float rad = (float)(180 / Math.PI);
            public int cux ;
            public int cuy ;
            public int cux2 ;
            public int cuy2 ;
            public Graphics g;
            public Form1 f; 

        public  engine(Graphics gr, Form1 pf)
        {
            g = gr;
            f = pf;
        }
        public void drawCircle()
            {

                float px, py, cx, cy, cx2, cy2;
                cx = (float)Math.Cos(0 / rad) * (100) + cux;
                cy = (float)Math.Sin(0 / rad) * (100) + cuy;
                cx2 = (float)Math.Cos(0 / rad) * (1) + cux2;
                cy2 = (float)Math.Sin(0 / rad) * (90) + cuy2;
                px = cx;
                py = cy;
                


                for (int j = 0; j < 1; j += 1)
                {
                    for (int i = 0; i < 360; i += 5)
                    {

                        //g.Clear(f.BackColor);

                        px = cx;
                        py = cy;
                        cx = (float)Math.Cos(i / rad) * (100) + cux;
                        cy = (float)Math.Sin(i / rad) * (100) + cuy;
                        cx2 = (float)Math.Cos(i / rad) * (1) + cux2;
                        cy2 = (float)Math.Sin(i / rad) * (90) + cuy2;


                        g.DrawRectangle(f.pen2, cx, cy, 1, 1);
                        g.DrawLine(f.pen2, cux, cuy, cx, cy);
                    //g.DrawLine(f.pen2, cux2, cuy2, cx2, cy2);
                    g.DrawLine(f.pen2, cx, cy, cx2, cy2);
                    // g.DrawLine(f.pen2, cux2, cuy2, cux, cuy);


                    Thread.Sleep(1);

                    }
                }
            }



        }
    
}
