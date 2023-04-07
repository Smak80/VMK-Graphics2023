namespace VMK_Graphics2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics g;
        private Brush b;
        private Brush c;
        private int ballSz;
        private int i;

        private void panel1_Click(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
            b = new SolidBrush(Color.Red);
            ballSz = 50;
            c = new SolidBrush(Color.White);
            i = 0;
            timer1.Enabled = true;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Blue, 3);
            Brush b = new SolidBrush(Color.Green);
            g.FillEllipse(b, 50, 50, 250, 250);
            g.DrawEllipse(p, 50, 50, 250, 250);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.FillEllipse(b, i, 350, ballSz, ballSz);
            Thread.Sleep(30);
            g.FillEllipse(c, i, 350, ballSz, ballSz);
            i++;
            if (i > panel1.Width - ballSz) timer1.Enabled = false;
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
        }
    }
}