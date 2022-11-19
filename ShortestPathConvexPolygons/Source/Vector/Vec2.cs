using System;
using System.Collections.Generic;

public struct Vec2
{
    public float x;
    public float y;

    public Vec2(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public static Vec2 operator *(Vec2 a, float b) => new Vec2(a.x * b, a.y * b);
    public static Vec2 operator /(Vec2 a, float b) => new Vec2(a.x / b, a.y / b);
    public static Vec2 operator +(Vec2 a, Vec2 b) => new Vec2(a.x + b.x, a.y + b.y);
    public static Vec2 operator -(Vec2 a, Vec2 b) => new Vec2(a.x - b.x, a.y - b.y);

    public static bool operator ==(Vec2 a, Vec2 b)
    {
        if (ReferenceEquals(a, b))
            return true;
        if (ReferenceEquals(a, null))
            return false;
        if (ReferenceEquals(b, null))
            return false;
        return a.Equals(b);
    }

    public static bool operator !=(Vec2 a, Vec2 b) => !(a == b);

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        else
        {
            Vec2 p = (Vec2)obj;
            return (x == p.x && y == p.y);
        }
    }

    public override int GetHashCode() => Tuple.Create(x, y).GetHashCode();

    public override string ToString() => $"({x}, {y})";

    public class SortByX : IComparer<Vec2>
    {
        public int Compare(Vec2 a, Vec2 b) => (a.x > b.x) ? 1 : -1;
    }

    public class SortByY : IComparer<Vec2>
    {
        public int Compare(Vec2 a, Vec2 b) => (a.y > b.y) ? 1 : -1;
    }

    public class SortCWAngleToPoint : IComparer<Vec2>
    {
        // Point to pivot rotation around
        Vec2 pivot;

        public SortCWAngleToPoint(Vec2 pivot)
        {
            this.pivot = pivot;
        }

        public int Compare(Vec2 a, Vec2 b)
        {
            var aRelative = a - pivot;
            var bRelative = b - pivot;

            double thetaA = Math.Atan2(aRelative.y, aRelative.x);
            double thetaB = Math.Atan2(bRelative.y, bRelative.x);

            return (thetaA > thetaB) ? 1 : -1;
        }
    }
}