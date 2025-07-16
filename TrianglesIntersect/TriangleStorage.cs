using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace TrianglesIntersect
{
    
    public static class TriangleStorage
    {
        private static readonly Random _rand = new Random();

        // Non intersect triangles, each triangle is Vector2[] {x, y}
        public static List<Vector2[]> NonIntersectTriangles { get; } = new List<Vector2[]>
        {
            new[]
            {
                new Vector2(0.0f, 0.0f),
                new Vector2(5.0f, 0.0f),
                new Vector2(0.0f, 5.0f)
            },
            new[]
            {
                new Vector2(5.0f, 1.0f),
                new Vector2(11.0f, 6.0f),
                new Vector2(5.0f, 6.0f)
            }
        };

        // Intersect triangles, each triangle is Vector2[] {x, y}
        public static List<Vector2[]> IntersectTriangles { get; } = new List<Vector2[]>
        {
            new[]
            {
                new Vector2(0.0f, 0.0f),
                new Vector2(5.0f, 0.0f),
                new Vector2(0.0f, 5.0f)
            },
            new[]
            {
                new Vector2(3.0f, 1.0f),
                new Vector2(8.0f, 6.0f),
                new Vector2(3.0f, 6.0f)
            }
        };

        // Get a two random triangles bounded by x and y
        public static List<Vector2[]> GetRandomTriangles(float maxX, float maxY)
        {
            var triangles = new List<Vector2[]>(2);

            for (int t = 0; t < 2; t++)
            {
                var tri = new Vector2[3];
                for (int i = 0; i < 3; i++)
                {
                    float x = (float)(_rand.NextDouble() * maxX);
                    float y = (float)(_rand.NextDouble() * maxY);
                    tri[i] = new Vector2(x, y);
                }
                triangles.Add(tri);
            }

            return triangles;
        }
    }
}
