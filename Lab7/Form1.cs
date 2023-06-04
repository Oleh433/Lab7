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
            g = CreateGraphics();

            Point[] points = {new Point(50, 100), new Point(75, 57), new Point(100, 100)};
            g.DrawPolygon(Pens.Green, points);

            Point[] points2 = 
                {
                    new Point(150, 187), new Point(200, 100), new Point(300, 100), 
                    new Point(350, 187), new Point(300, 273), new Point(200, 273)
                };
            g.DrawPolygon(Pens.Blue, points2);

            g.DrawArc(Pens.Red, 100, 200, 200, 100, 30, 180);
        }
    }
}