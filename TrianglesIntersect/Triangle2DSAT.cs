using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TrianglesIntersect
{
    public static class Triangle2DSAT
    {
        // Проекция точки p на ось axis
        private static float Project(Vector2 p, Vector2 axis)
            => Vector2.Dot(p, axis);

        // Проверка пересечения интервалов [minA, maxA] и [minB, maxB]
        private static bool OverlapInterval(float minA, float maxA, float minB, float maxB)
            => !(maxA < minB || maxB < minA);

        // Возвращает нормализованный перпендикуляр (ось) к ребру e = (x,y)
        private static Vector2 Perp(Vector2 e)
        {
            var perp = new Vector2(-e.Y, e.X);
            return Vector2.Normalize(perp);
        }

        // Основная функция: проверяет пересечение треугольников A и B
        // A и B — массивы по 3 вершины
        public static bool TrianglesIntersect(Vector2[] A, Vector2[] B)
        {
            if (A.Length != 3 || B.Length != 3)
                throw new ArgumentException("Каждый треугольник задаётся тремя точками.");

            // Вычисляем рёбра
            Vector2[] eA = 
            {
                A[1] - A[0],
                A[2] - A[1],
                A[0] - A[2]
            };

            Vector2[] eB = 
            {
                B[1] - B[0],
                B[2] - B[1],
                B[0] - B[2]
            };

            // Собираем оси (перпендикуляры к рёбрам обоих треугольников)
            Vector2[] axes = new Vector2[6];
            for (int i = 0; i < 3; i++)
            {
                axes[i] = Perp(eA[i]);
                axes[i + 3] = Perp(eB[i]);
            }

            // Проверяем каждую ось
            foreach (var axis in axes)
            {
                // Проецируем все вершины A
                float minA = float.PositiveInfinity, maxA = float.NegativeInfinity;
                foreach (var p in A)
                {
                    float proj = Project(p, axis);
                    minA = Math.Min(minA, proj);
                    maxA = Math.Max(maxA, proj);
                }

                // Проецируем все вершины B
                float minB = float.PositiveInfinity, maxB = float.NegativeInfinity;
                foreach (var p in B)
                {
                    float proj = Project(p, axis);
                    minB = Math.Min(minB, proj);
                    maxB = Math.Max(maxB, proj);
                }

                // Если интервалы не пересекаются — есть разделяющая ось
                if (!OverlapInterval(minA, maxA, minB, maxB))
                    return false;
            }

            // По всем осям пересечения есть — треугольники пересекаются
            return true;
        }
    }
}
