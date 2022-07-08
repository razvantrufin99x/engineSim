namespace engineSim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        Pen pen0 = new Pen(Color.Black, 1);
        Pen pen2 = new Pen(Color.Red, 1);
        Pen pen1 = new Pen(Color.Silver, 1);
        float rad = (float)(180 / Math.PI);
        int cux = 350;
        int cuy = 350;

        void drawCircle()
        {

            float px, py, cx, cy;
            cx = (float)Math.Cos(0 / rad) * (200 + 0) + cux;
            cy = (float)Math.Sin(0 / rad) * (200 + 0) + cuy;
            px = cx;
            py = cy;
            int p = 0;
          


            for(int i = 0; i< 360; i++) {
                
                g.Clear(this.BackColor);
               
                px = cx;
                        py = cy;
                        cx = (float)Math.Cos(i / rad) * (200 ) + cux;
                        cy = (float)Math.Sin(i / rad) * (200 ) + cuy;
                      
                        g.DrawRectangle(pen2, cx, cy, 1, 1);
                        
                        g.DrawLine(pen2, cux, cuy, cx, cy);
                        g.DrawLine(pen2, cx, cy, 700, 800);
                        g.DrawLine(pen2, cux, cuy, 700, 800);
                        g.DrawLine(pen2, cux, cuy, (700-cx)/2, (800-cy)/2);
                g.DrawLine(pen2, cx,cy, (700 - cx) / 2, (800 - cy) / 2);
                g.DrawLine(pen2, 700,800, (700 - cx) / 2, (800 - cy) / 2);
                Thread.Sleep(2);
                    }
               

           


        }






        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 10000;
            this.Height = 10000;
            this.Left = 0;
            this.Top = 0;

            g = CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawCircle();
        }
    }
}