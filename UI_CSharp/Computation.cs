using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midas_challenge
{

    public class Computation
    {
        public static bool onSegment(Point p, Point q, Point r)
        {
            if (q.X <= Math.Max(p.X, r.X) && q.X >= Math.Min(p.X, r.X) &&
                q.Y <= Math.Max(p.Y, r.Y) && q.Y >= Math.Min(p.Y, r.Y))
                return true;

            return false;
        }

        public static int orientation(Point p, Point q, Point r)
        {
            int val = (q.Y - p.Y) * (r.X - q.X) -
                      (q.X - p.X) * (r.Y - q.Y);

            if (val == 0) return 0;  // colinear

            return (val > 0) ? 1 : 2; // clock or counterclock wise
        }

        public static bool DoIntersect_easy(Line line1, Line line2)
        {
            return DoIntersect_easy(line1.StartPoint, line1.EndPoint, line2.StartPoint, line2.EndPoint);
        }

        public static bool DoIntersect_strict(Line line1, Line line2)
        {
            return DoIntersect_strict(line1.StartPoint, line1.EndPoint, line2.StartPoint, line2.EndPoint);
        }

        public static bool DoIntersect_easy(Point p1, Point q1, Point p2, Point q2)
        {
            // Find the four orientations needed for general and
            // special cases
            int o1 = orientation(p1, q1, p2);
            int o2 = orientation(p1, q1, q2);
            int o3 = orientation(p2, q2, p1);
            int o4 = orientation(p2, q2, q1);

            if (o1 == 0 || o2 == 0 || o3 == 0 || 04 == 0)
                return false;
            // General case
            if (o1 != o2 && o3 != o4)
                return true;

            return false;
        }

        public static bool DoIntersect_strict(Point p1, Point q1, Point p2, Point q2)
        {
            // Find the four orientations needed for general and
            // special cases
            int o1 = orientation(p1, q1, p2);
            int o2 = orientation(p1, q1, q2);
            int o3 = orientation(p2, q2, p1);
            int o4 = orientation(p2, q2, q1);

            // General case
            if (o1 != o2 && o3 != o4)
                return true;

            // Special Cases
            // p1, q1 and p2 are colinear and p2 lies on segment p1q1
            if (o1 == 0 && onSegment(p1, p2, q1)) return true;

            // p1, q1 and q2 are colinear and q2 lies on segment p1q1
            if (o2 == 0 && onSegment(p1, q2, q1)) return true;

            // p2, q2 and p1 are colinear and p1 lies on segment p2q2
            if (o3 == 0 && onSegment(p2, p1, q2)) return true;

            // p2, q2 and q1 are colinear and q1 lies on segment p2q2
            if (o4 == 0 && onSegment(p2, q1, q2)) return true;

            return false; // Doesn't fall in any of the above cases
        }
        public static double EuclideanDist(Point coord1, Point coord2)
        {
            return Math.Sqrt(Math.Pow((double)(coord1.X - coord2.X), 2.0) + Math.Pow((double)(coord2.Y - coord1.Y), 2.0));
        }

        internal static double EuclideanDist(Wall wall, Point center, out Point closest)
        {
            Point pt = center;
            Point p1 = wall.StartPoint;
            Point p2 = wall.EndPoint;
            double dx = (double)(p2.X - p1.X);
            double dy = (double)(p2.Y - p1.Y);
            // Calculate the t that minimizes the distance.
            double t = ((pt.X - p1.X) * dx + (pt.Y - p1.Y) * dy) / (dx * dx + dy * dy);

            // See if this represents one of the segment's
            // end points or a point in the middle.
            if (t < 0)
            {
                closest = new Point(p1.X, p1.Y);
                dx = pt.X - p1.X;
                dy = pt.Y - p1.Y;
            }
            else if (t > 1)
            {
                closest = new Point(p2.X, p2.Y);
                dx = pt.X - p2.X;
                dy = pt.Y - p2.Y;
            }
            else
            {
                closest = new Point((int)Math.Round((double)p1.X + t * dx), (int)Math.Round((double)p1.Y + t * dy));
                double closest_X = p1.X + t * dx;
                double closest_Y = p1.Y + t * dy;
                dx = pt.X - closest_X;
                dy = pt.Y - closest_Y;
            }

            return Math.Sqrt(dx * dx + dy * dy);
        }

        public static bool IsPointInLine(Point pt, Line wall)
        {
            return (pt.X <= wall.EndPoint.X && pt.X >= wall.StartPoint.X) && (pt.Y <= wall.EndPoint.Y && pt.Y >= wall.StartPoint.Y);
        }
    }
}
