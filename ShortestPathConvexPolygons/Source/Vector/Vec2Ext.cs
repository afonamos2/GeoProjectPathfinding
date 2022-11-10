using System;
using System.Collections.Generic;

public static class Vec2Ext {

    public enum Orientation {
        Collinear = 0, Clockwise = 1, Counterclockwise = 2
    }

    public static bool IsOrientation(Vec2 a, Vec2 b, Vec2 c, Orientation orientation) => FindOrientation(a, b, c) == orientation;
    public static bool IsClockwise(Vec2 a, Vec2 b, Vec2 c) => IsOrientation(a, b, c, Orientation.Clockwise);
    public static bool IsCollinear(Vec2 a, Vec2 b, Vec2 c) => IsOrientation(a, b, c, Orientation.Collinear);
    public static bool IsCounterClockwise(Vec2 a, Vec2 b, Vec2 c) => IsOrientation(a, b, c, Orientation.Counterclockwise);

    public static Orientation FindOrientation(Vec2 a, Vec2 b, Vec2 c) {
        var val = (b.y - a.y) * (c.x - b.x) - (b.x - a.x) * (c.y - b.y);
        if (Math.Abs(val) < float.Epsilon) {
            return Orientation.Collinear;    
        } else if (val > 0.0f) {
            return Orientation.Clockwise;
        } else {
            return Orientation.Counterclockwise;
        }
    }

    //Finds if point p is on segment ab
    public static bool OnLineSegment(Vec2 p, Vec2 a, Vec2 b) {
        if (p.x <= Math.Max(a.x, b.x) 
            && p.x >= Math.Min(a.x, b.x)
            && p.y <= Math.Max(a.y, b.y)
            && p.y >= Math.Min(a.y, b.y)    
        ) {
            return true;
        } else {
            return false;
        }
    }

    public static bool Intersect(Vec2 a, Vec2 b, Vec2 c, Vec2 d) {
        if (a == c || b == c || a == d || b == d) {
            return false;
        }

        Orientation o1 = FindOrientation(a, b, c);
        Orientation o2 = FindOrientation(a, b, d);
        Orientation o3 = FindOrientation(c, d, a);
        Orientation o4 = FindOrientation(c, d, b);

        if (o1 != o2 && o3 != o4) {
            return true;
        }
        if (o1 == Orientation.Collinear && OnLineSegment(c, a, b)) {
            return true;
        }
        if (o2 == Orientation.Collinear && OnLineSegment(d, a, b)) {
            return true;
        }
        if (o3 == Orientation.Collinear && OnLineSegment(a, c, d)) {
            return true;
        }
        if (o4 == Orientation.Collinear && OnLineSegment(b, c, d)) {
            return true;
        }
        
        return false;
    }

    public static void SwapByIndex(int a, int b, ref Vec2[] array) {
        Vec2 temp = array[a];
        array[a] = array[b];
        array[b] = temp;
    }

    public static float SqrDist(Vec2 a, Vec2 b) {
        return (a.x - b.x) * (a.x - b.x) 
            + (a.y - b.y) * (a.y - b.y);
    }

    public static float Distance(Vec2 a, Vec2 b) {
        return (float)Math.Sqrt(SqrDist(a, b));
    }
}
