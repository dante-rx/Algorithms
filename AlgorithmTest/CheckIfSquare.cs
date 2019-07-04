using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORITHME
{

    class CheckIfSquare
    {
        public class Point
        {
            int X;
            int Y;
            public Point(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public static int DistanceTwoPoints(Point P1, Point P2)
            {
                return ((P2.X - P1.X) * (P2.X - P1.X) + (P2.Y - P1.Y) * (P2.Y - P1.Y));
            }
        }

        public static bool IsSquare(Point P1, Point P2, Point P3, Point P4)
        {
            int dist1 = Point.DistanceTwoPoints(P1, P2);
            int dist2 = Point.DistanceTwoPoints(P2, P3);
            int dist3 = Point.DistanceTwoPoints(P3, P4);
            int dist4 = Point.DistanceTwoPoints(P4, P1);

            if (dist1 == dist2)
                if (dist2 == dist3)
                    if (dist3 == dist4)
                        return true;
            return false;
        }

        public static void CallIsSquare()
        {
            Point P1 = new Point(10, 20);
            Point P2 = new Point(20, 20);
            Point P3 = new Point(20, 10);
            Point P4 = new Point(10, 10);

            if (IsSquare(P1,P2,P3,P4))
                Console.WriteLine("E um quadrado");
            else
                Console.WriteLine("Não é um quadrado");
        }

    }
}
