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
        int cuy = 650;
        int cux2 = 350;
        int cuy2 = 340;

        void drawCircle()
        {

            float px, py, cx, cy,cx2, cy2;
            cx = (float)Math.Cos(0 / rad) * (100 ) + cux;
            cy = (float)Math.Sin(0 / rad) * (100 ) + cuy;
            cx2 = (float)Math.Cos(0 / rad) * (1 ) + cux2;
            cy2 = (float)Math.Sin(0 / rad) * (90) + cuy2;
            px = cx;
            py = cy;



            for (int j = 0; j < 2 ; j += 1) {
                for (int i = 0; i < 360; i += 1) {

                    g.Clear(this.BackColor);

                    px = cx;
                    py = cy;
                    cx = (float)Math.Cos(i / rad) * (100) + cux;
                    cy = (float)Math.Sin(i / rad) * (100) + cuy;
                    cx2 = (float)Math.Cos(i / rad) * (1) + cux2;
                    cy2 = (float)Math.Sin(i / rad) * (90) + cuy2;


                    g.DrawRectangle(pen2, cx, cy, 1, 1);
                    g.DrawLine(pen2, cux, cuy, cx, cy);
                    //g.DrawLine(pen2, cux2, cuy2, cx2, cy2);
                    g.DrawLine(pen2, cx, cy, cx2, cy2);
                    // g.DrawLine(pen2, cux2, cuy2, cux, cuy);


                    Thread.Sleep(1);

                }
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