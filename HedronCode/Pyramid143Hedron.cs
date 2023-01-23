 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class Pyramid143Hedron : HedronBase
    {
       public Pyramid143Hedron()
       {
                   Name = "Pyramid143";

         Vertex.Add(0, new HVector(0, 0, 0.707106781186547));
         Vertex.Add(1, new HVector(0, -0.707106781186547, 0));
         Vertex.Add(2, new HVector(0, 0.707106781186547, 0));
         Vertex.Add(3, new HVector(-0.707106781186547, 0, 0));
         Vertex.Add(4, new HVector(0.707106781186547, 0, 0));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(4);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(2);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(5);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(3);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(2);
         hpoly.AddIndex(4);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);


       }

       

    }
}
