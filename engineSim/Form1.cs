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


        public theengine theengineMotor;
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            theengineMotor= new theengine(g, this);
            theengineMotor.e = new engine(350,650,350,240);
            theengineMotor.drawCircle();

            theengineMotor.e = new engine(550, 650, 550, 240);
            theengineMotor.drawCircle();

            theengineMotor.e = new engine(750, 650, 750, 240);
            theengineMotor.drawCircle();

            theengineMotor.e = new engine(950, 650, 950, 240);
            theengineMotor.drawCircle();




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