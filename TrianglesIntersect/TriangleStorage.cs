using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TrianglesIntersect
{
    // Non intersect triangles, each triangle is Vector2[] {x, y}
    public static class TriangleStorage
    {       
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
    }
}
