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

            // Параметры масштабирования и смещения
            float scale = 50f;   // сколько пикселей на единицу
            float offsetX = 20f;   // отступ слева
            float offsetY = 20f;   // отступ сверху

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

                // Рисуем только контур
                g.DrawPolygon(pen, pts);
            }

            string displayText = "Triangles is intersect: ";

            const int margin = 5;
            using (var font = new Font(new FontFamily("Segoe UI"), 16)) // можно заменить на любой другой шрифт
            using (var brush = Brushes.White)
            {
                // Вычисляем размер текста
                var textSize = g.MeasureString(displayText, font);

                // Позиция: margin от левого края, margin от низа
                float x = margin;
                float y = pictureBox1.ClientSize.Height - textSize.Height - margin;

                // Рисуем строку
                g.DrawString(displayText + (isIntersect ? "Yes" : "No"), font, brush, new PointF(x, y));
            }
        }
    }
}
