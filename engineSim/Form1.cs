namespace engineSim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Graphics g;
        public Pen pen0 = new Pen(Color.Black, 1);
        public Pen pen2 = new Pen(Color.Red, 1);
        public Pen pen1 = new Pen(Color.Silver, 1);

        

        public List<engine> engines = new List<engine>();
        
        private void button1_Click(object sender, EventArgs e)
        {
            engines.Add(new engine(this.g, this ));
            engines.Add(new engine(this.g, this));
            engines.Add(new engine(this.g, this));
            engines.Add(new engine(this.g, this));

            engines[0].cux = 350;
            engines[0].cuy = 650;
            engines[0].cux2 = 350;
            engines[0].cuy2 = 340;
            engines[0].drawCircle();

            engines[1].cux = 450;
            engines[1].cuy = 650;
            engines[1].cux2 = 450;
            engines[1].cuy2 = 340;
            engines[1].drawCircle();

            engines[2].cux = 550;
            engines[2].cuy = 650;
            engines[2].cux2 = 550;
            engines[2].cuy2 = 340;
            engines[2].drawCircle();

            engines[3].cux = 650;
            engines[3].cuy = 650;
            engines[3].cux2 = 650;
            engines[3].cuy2 = 340;
            engines[3].drawCircle();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 1600;
            this.Height = 900;
            this.Left = 0;
            this.Top = 0;

            g = CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

    }
}