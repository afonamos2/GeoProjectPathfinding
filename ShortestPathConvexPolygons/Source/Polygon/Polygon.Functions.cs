using System;
using System.Collections.Generic;

public partial class Polygon {
    
    public static Polygon GenerateRegularPolygon(int numVertices, float radius, Vec2 origin, float rotation=0f) {
        var poly = new Polygon();
        var anglePerVertex = (Math.PI * 2f) / numVertices;

        //Sampling points in a circle
        for (int i = 0; i < numVertices; i++) {
            poly._vertices.Add(new Vec2(
                x: (float)Math.Cos(anglePerVertex * i + rotation), 
                y: (float)Math.Sin(anglePerVertex * i + rotation)
            ) * radius + origin);
        }
        
        poly.GenerateEdges();
        return poly;
    }
}
