namespace VMK_Graphics2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            //Pen p = new Pen(Color.Blue, 3);
            Brush b = new SolidBrush(Color.Red);
            //g.FillEllipse(b, 50, 50, 250, 250);
            //g.DrawEllipse(p, 50, 50, 250, 250);
            var ballSz = 50;
            Brush c = new SolidBrush(Color.White);
            for (int i = 0; i < panel1.Width - ballSz; i++)
            {
                g.FillEllipse(b, i, 350, ballSz, ballSz);
                Thread.Sleep(30);
                g.FillEllipse(c, i, 350, ballSz, ballSz);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Blue, 3);
            Brush b = new SolidBrush(Color.Green);
            g.FillEllipse(b, 50, 50, 250, 250);
            g.DrawEllipse(p, 50, 50, 250, 250);
        }
    }
}