using System;

public static class Util {
    public static int CeilToInt(float a) => (int)Math.Ceiling(a);

    public static int FloorToInt(float a) => (int)Math.Floor(a);

    //A version of modulo that always stays positive
    public static int Mod(int a, int b) => ((a % b) + b) % b;
}
