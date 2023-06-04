using System.Drawing;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Graphics g;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.White);

            Point[] points = { new Point(50, 100), new Point(75, 57), new Point(100, 100) };
            g.DrawPolygon(Pens.Green, points);

            Point[] points2 =
                {
                    new Point(150, 187), new Point(200, 100), new Point(300, 100),
                    new Point(350, 187), new Point(300, 273), new Point(200, 273)
                };
            g.DrawPolygon(Pens.Blue, points2);

            g.DrawArc(Pens.Red, 100, 200, 200, 100, 30, 180);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //reset
            g = CreateGraphics();
            g.Clear(Color.White);

            g.DrawEllipse(Pens.Yellow, 150, 150, 100, 120);

            //eyes
            g.DrawEllipse(Pens.Black, 170, 200, 20, 10);
            g.DrawEllipse(Pens.Black, 210, 200, 20, 10);

            g.DrawEllipse(Pens.Black, 176, 202, 5, 5);
            g.DrawEllipse(Pens.Black, 216, 202, 5, 5);

            //mouth
            Point[] points = { new Point(180, 240), new Point(220, 240), new Point(200, 250) };
            g.DrawClosedCurve(Pens.Red, points);

            //nose
            g.DrawLine(Pens.Black, 196, 210, 193, 225 );
            g.DrawLine(Pens.Black, 193, 225, 197, 226);

        }
    }
}