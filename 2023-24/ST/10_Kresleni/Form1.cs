namespace _10_Kresleni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Here you can paste the same as below and it will draw in the main window

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // getting drawing field object
            // e - link to drawing field
            Graphics drawingField = e.Graphics;
            // drawing functions
            // Black line from (0,0) to (200, 100)
            drawingField.DrawLine(Pens.Black, 0, 0, 200, 100);
            // Creating pen
            Pen p = new(Color.Sienna, 5);
            drawingField.DrawLine(p, 100, 100, 300, 200);
            drawingField.DrawLine(new Pen(Color.DarkBlue, 2), 100, 0, 300, 100);
            // rectangle
            drawingField.DrawRectangle(p, 200, 100, 50, 100);
            drawingField.DrawRectangle(p, Left, Top, Right, Bottom);
            // ellipse
            drawingField.DrawEllipse(p, Left, Top, Right, Bottom);
            // filling a shape
            // creating a brush
            SolidBrush s = new(Color.DarkCyan);
            drawingField.FillPie(s, 100, 200, 100, 100, 20, 150);

            // Spline
            Pen splineP = new(Color.LawnGreen);
            Point P1 = new(100, 200);
            Point P2 = new(30, 342);
            Point P3 = new(234, 304);
            Point P4 = new(404, 404);
            Point P5 = new(203, 3);
            Point P6 = new(232, 600);
            Point P7 = new(324, 345);
            Point P8 = new(500, 20);
            Point[] pointArray = new Point[]{ P1, P2, P3, P4, P5, P6, P7, P8};
            drawingField.DrawCurve(splineP, pointArray);
        }
    }
}