using System.Numerics;

namespace TrianglesIntersect
{
    public partial class Form1 : Form
    {
        bool isIntersect;

        List<Vector2[]> triangles = TriangleStorage.IntersectTriangles;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Invalidate();

            isIntersect = Triangle2DSAT.TrianglesIntersect(triangles[0], triangles[1]);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Scale and offset parameters
            float scale = 50f;   // scales of each real pixel
            float offsetX = 20f;   // left offset
            float offsetY = 20f;   // top offset

            foreach (var tri in triangles)
            {
                var pts = new PointF[3];
                for (int i = 0; i < 3; i++)
                {
                    pts[i] = new PointF(
                        tri[i].X * scale + offsetX,
                        tri[i].Y * scale + offsetY
                    );
                }

                Pen pen = new Pen(Color.White, 2);

                // only lines (contour)
                g.DrawPolygon(pen, pts);
            }

            string displayText = "Triangles is intersect: ";

            const int margin = 5;
            using (var font = new Font(new FontFamily("Segoe UI"), 16))
            using (var brush = Brushes.White)
            {
                // calculate size of string
                var textSize = g.MeasureString(displayText, font);

                // Position: x - margin from left, y - margin from bottom
                float x = margin;
                float y = pictureBox1.ClientSize.Height - textSize.Height - margin;

                // draw string
                g.DrawString(displayText + (isIntersect ? "Yes" : "No"), font, brush, new PointF(x, y));
            }
        }
    }
}
