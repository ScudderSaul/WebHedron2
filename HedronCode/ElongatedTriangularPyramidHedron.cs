 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class ElongatedTriangularPyramidHedron : HedronBase
    {
       public ElongatedTriangularPyramidHedron()
       {
                   Name = "ElongatedTriangularPyramid";

         Vertex.Add(0, new HVector(0, 0, 1.81649658092773));
         Vertex.Add(1, new HVector(-0.288675134594813, -0.5, 0));
         Vertex.Add(2, new HVector(-0.288675134594813, -0.5, 1));
         Vertex.Add(3, new HVector(-0.288675134594813, 0.5, 0));
         Vertex.Add(4, new HVector(-0.288675134594813, 0.5, 1));
         Vertex.Add(5, new HVector(0.577350269189626, 0, 0));
         Vertex.Add(6, new HVector(0.577350269189626, 0, 1));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(3);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(7);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(5);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(2);
         hpoly.AddIndex(3);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(6);
         hpoly.AddIndex(7);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(4);
         hpoly.AddIndex(5);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(2);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);


       }

       

    }
}
