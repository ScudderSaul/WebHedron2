 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class TriakisTetrahedronHedron : HedronBase
    {
       public TriakisTetrahedronHedron()
       {
                   Name = "TriakisTetrahedron";

         Vertex.Add(0, new HVector(0, 0, -1.02062072615966));
         Vertex.Add(1, new HVector(0, 0, 0.612372435695794));
         Vertex.Add(2, new HVector(-0.962250448649376, 0, 0.340206908719886));
         Vertex.Add(3, new HVector(-0.288675134594813, -0.5, -0.204124145231932));
         Vertex.Add(4, new HVector(-0.288675134594813, 0.5, -0.204124145231932));
         Vertex.Add(5, new HVector(0.481125224324688, -0.833333333333333, 0.340206908719886));
         Vertex.Add(6, new HVector(0.481125224324688, 0.833333333333333, 0.340206908719886));
         Vertex.Add(7, new HVector(0.577350269189626, 0, -0.204124145231932));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(4);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(5);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(3);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(5);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(2);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(3);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(2);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(6);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(3);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(5);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(1);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(7);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);


       }

       

    }
}
