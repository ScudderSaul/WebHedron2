 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class Dipyramid42Hedron : HedronBase
    {
       public Dipyramid42Hedron()
       {
                   Name = "Dipyramid42";

         Vertex.Add(0, new HVector(0, 0, -0.816496580927726));
         Vertex.Add(1, new HVector(0, 0, 0.816496580927726));
         Vertex.Add(2, new HVector(-0.288675134594813, -0.5, 0));
         Vertex.Add(3, new HVector(-0.288675134594813, 0.5, 0));
         Vertex.Add(4, new HVector(0.577350269189626, 0, 0));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(3);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(5);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(4);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(3);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(5);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(4);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);


       }

       

    }
}
