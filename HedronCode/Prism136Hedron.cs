 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class Prism136Hedron : HedronBase
    {
       public Prism136Hedron()
       {
                   Name = "Prism136";

         Vertex.Add(0, new HVector(-0.288675134594813, -0.5, -0.5));
         Vertex.Add(1, new HVector(-0.288675134594813, -0.5, 0.5));
         Vertex.Add(2, new HVector(-0.288675134594813, 0.5, -0.5));
         Vertex.Add(3, new HVector(-0.288675134594813, 0.5, 0.5));
         Vertex.Add(4, new HVector(0.577350269189626, 0, -0.5));
         Vertex.Add(5, new HVector(0.577350269189626, 0, 0.5));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(3);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(4);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(3);
         hpoly.AddIndex(4);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(1);
         hpoly.AddIndex(2);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(5);
         hpoly.AddIndex(6);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);


       }

       

    }
}
