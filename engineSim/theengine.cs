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
        public engine e1 = new engine();
        public engine e2 = new engine();
        public engine e3 = new engine();
        public engine e4 = new engine();

        public theengine() { }
   
   

        public theengine(Graphics gr, Form1 pf)
        {
            g = gr;
            f = pf;
        
        }
        
       

        public void drawCircle()
        {

            float pxA, pyA, cxA, cyA, cx2A, cy2A;
            float pxB, pyB, cxB, cyB, cx2B, cy2B;
            float pxC, pyC, cxC, cyC, cx2C, cy2C;
            float pxD, pyD, cxD, cyD, cx2D, cy2D;

            cxA = (float)Math.Cos(0 / rad) * (100) + e1.cux;
            cyA = (float)Math.Sin(0 / rad) * (100) + e1.cuy;
            cx2A = (float)Math.Cos(0 / rad) * (1) + e1.cux2;
            cy2A = (float)Math.Sin(0 / rad) * (90) + e1.cuy2;
            pxA = cxA;
            pyA = cyA;


            cxB = (float)Math.Cos(0 / rad) * (100) + e2.cux;
            cyB = (float)Math.Sin(0 / rad) * (100) + e2.cuy;
            cx2B = (float)Math.Cos(0 / rad) * (1) + e2.cux2;
            cy2B = (float)Math.Sin(0 / rad) * (90) + e2.cuy2;
            pxB = cxB;
            pyB = cyB;

            cxC = (float)Math.Cos(0 / rad) * (100) + e3.cux;
            cyC = (float)Math.Sin(0 / rad) * (100) + e3.cuy;
            cx2C = (float)Math.Cos(0 / rad) * (1) + e3.cux2;
            cy2C = (float)Math.Sin(0 / rad) * (90) + e3.cuy2;
            pxC = cxC;
            pyC = cyC;


            cxD = (float)Math.Cos(0 / rad) * (100) + e4.cux;
            cyD= (float)Math.Sin(0 / rad) * (100) + e4.cuy;
            cx2D = (float)Math.Cos(0 / rad) * (1) + e4.cux2;
            cy2D = (float)Math.Sin(0 / rad) * (90) + e4.cuy2;
            pxD = cxD;
            pyD = cyD;

            for (int j = 0; j < 10; j += 1)
            {
                for (int i = 0; i < 360; i += 5)
                {

                    g.Clear(f.BackColor);




                    //A

                    pxA = cxA;
                    pyA = cyA;
                    cxA = (float)Math.Cos((i+0) / rad) * (100) + e1.cux;
                    cyA = (float)Math.Sin((i + 0) / rad) * (100) + e1.cuy;
                    cx2A = (float)Math.Cos((i + 0) / rad) * (1) + e1.cux2;
                    cy2A = (float)Math.Sin((i + 0) / rad) * (90) + e1.cuy2;


                    g.DrawRectangle(f.pen2, cxA, cyA, 1, 1);
                    g.DrawLine(f.pen2, e1.cux, e1.cuy, cxA, cyA);
                    //g.DrawLine(f.pen2, e1.cux2, e1.cuy2, cx2A, cy2A);
                    g.DrawLine(f.pen2, cxA, cyA, cx2A, cy2A);
                    // g.DrawLine(f.pen2, e1.cux2, e1.cuy2, e1.cux, e1.cuy);





                    //B
                    pxB = cxB;
                    pyB = cyB;
                    cxB = (float)Math.Cos((i + 45) / rad) * (100) + e2.cux;
                    cyB = (float)Math.Sin((i + 45) / rad) * (100) + e2.cuy;
                    cx2B = (float)Math.Cos((i + 45) / rad) * (1) + e2.cux2;
                    cy2B = (float)Math.Sin((i + 45) / rad) * (90) + e2.cuy2;


                    g.DrawRectangle(f.pen2, cxB, cyB, 1, 1);
                    g.DrawLine(f.pen2, e2.cux, e2.cuy, cxB, cyB);
                    //g.DrawLine(f.pen2, e2.cux2, e2.cuy2, cx2B, cy2B);
                    g.DrawLine(f.pen2, cxB, cyB, cx2B, cy2B);
                    // g.DrawLine(f.pen2, e2.cux2, e2.cuy2, e2.cux, e2.cuy);






                    //C
                    pxC = cxC;
                    pyC = cyC;
                    cxC = (float)Math.Cos((i + 45) / rad) * (100) + e3.cux;
                    cyC = (float)Math.Sin((i + 45) / rad) * (100) + e3.cuy;
                    cx2C = (float)Math.Cos((i + 45) / rad) * (1) + e3.cux2;
                    cy2C = (float)Math.Sin((i + 45) / rad) * (90) + e3.cuy2;


                    g.DrawRectangle(f.pen2, cxC, cyC, 1, 1);
                    g.DrawLine(f.pen2, e3.cux, e3.cuy, cxC, cyC);
                    //g.DrawLine(f.pen2, e3.cux2, e3.cuy2, cx2C, cy2C);
                    g.DrawLine(f.pen2, cxC, cyC, cx2C, cy2C);
                    // g.DrawLine(f.pen2, e3.cux2, e3.cuy2, e3.cux, e3.cuy);





                    //D
                    pxD = cxD;
                    pyD = cyD;
                    cxD = (float)Math.Cos((i + 0) / rad) * (100) + e4.cux;
                    cyD = (float)Math.Sin((i + 0) / rad) * (100) + e4.cuy;
                    cx2D = (float)Math.Cos((i + 0) / rad) * (1) + e4.cux2;
                    cy2D = (float)Math.Sin((i + 0) / rad) * (90) + e4.cuy2;


                    g.DrawRectangle(f.pen2, cxD, cyD, 1, 1);
                    g.DrawLine(f.pen2, e4.cux, e4.cuy, cxD, cyD);
                    //g.DrawLine(f.pen2, e4.cux2, e4.cuy2, cx2D, cy2D);
                    g.DrawLine(f.pen2, cxD, cyD, cx2D, cy2D);
                    // g.DrawLine(f.pen2, e4.cux2, e4.cuy2, e4.cux, e4.cuy);




                    Thread.Sleep(1);

                }
            }
        }


    }
}
