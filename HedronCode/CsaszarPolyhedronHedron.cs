 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class CsaszarPolyhedronHedron : HedronBase
    {
       public CsaszarPolyhedronHedron()
       {
                   Name = "CsaszarPolyhedron";

         Vertex.Add(0, new HVector(-1.22474487139159, -1.22474487139159, 0.408248290463863));
         Vertex.Add(1, new HVector(-1.22474487139159, 1.22474487139159, 0));
         Vertex.Add(2, new HVector(-0.408248290463863, -0.816496580927726, 0.816496580927726));
         Vertex.Add(3, new HVector(0, 0, 6.12372435695795));
         Vertex.Add(4, new HVector(0.408248290463863, 0.816496580927726, 0.816496580927726));
         Vertex.Add(5, new HVector(1.22474487139159, -1.22474487139159, 0));
         Vertex.Add(6, new HVector(1.22474487139159, 1.22474487139159, 0.408248290463863));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(6);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(2);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(5);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(3);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(2);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(6);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(7);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(1);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(2);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(6);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(4);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(4);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(4);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(4);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);


       }

       

    }
}
