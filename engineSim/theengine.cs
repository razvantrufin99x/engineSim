using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engineSim
{
    public class theengine
    {
        public float rad = (float)(180 / Math.PI);
        public Graphics g;
        public Form1 f;
        public engine e = new engine();

        public theengine() { }
   
   

        public theengine(Graphics gr, Form1 pf)
        {
            g = gr;
            f = pf;
        
        }
        
        public void addengine(ref engine pe)
        {
            e = new engine(ref pe);
        }

        public void drawCircle()
        {

            float px, py, cx, cy, cx2, cy2;
            cx = (float)Math.Cos(0 / rad) * (100) + e.cux;
            cy = (float)Math.Sin(0 / rad) * (100) + e.cuy;
            cx2 = (float)Math.Cos(0 / rad) * (1) + e.cux2;
            cy2 = (float)Math.Sin(0 / rad) * (90) + e.cuy2;
            px = cx;
            py = cy;



            for (int j = 0; j < 1; j += 1)
            {
                for (int i = 0; i < 360; i += 5)
                {

                    g.Clear(f.BackColor);

                    px = cx;
                    py = cy;
                    cx = (float)Math.Cos(i / rad) * (100) + e.cux;
                    cy = (float)Math.Sin(i / rad) * (100) + e.cuy;
                    cx2 = (float)Math.Cos(i / rad) * (1) + e.cux2;
                    cy2 = (float)Math.Sin(i / rad) * (90) + e.cuy2;


                    g.DrawRectangle(f.pen2, cx, cy, 1, 1);
                    g.DrawLine(f.pen2, e.cux, e.cuy, cx, cy);
                    //g.DrawLine(f.pen2, e.cux2, e.cuy2, cx2, cy2);
                    g.DrawLine(f.pen2, cx, cy, cx2, cy2);
                    // g.DrawLine(f.pen2, e.cux2, e.cuy2, e.cux, e.cuy);


                    Thread.Sleep(1);

                }
            }
        }


    }
}
