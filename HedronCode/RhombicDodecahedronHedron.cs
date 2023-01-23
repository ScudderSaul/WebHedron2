 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class RhombicDodecahedronHedron : HedronBase
    {
       public RhombicDodecahedronHedron()
       {
                   Name = "RhombicDodecahedron";

         Vertex.Add(0, new HVector(-0.816496580927726, -0.816496580927726, 0));
         Vertex.Add(1, new HVector(-0.816496580927726, 0, -0.577350269189626));
         Vertex.Add(2, new HVector(-0.816496580927726, 0, 0.577350269189626));
         Vertex.Add(3, new HVector(-0.816496580927726, 0.816496580927726, 0));
         Vertex.Add(4, new HVector(0, -0.816496580927726, -0.577350269189626));
         Vertex.Add(5, new HVector(0, -0.816496580927726, 0.577350269189626));
         Vertex.Add(6, new HVector(0, 0, -1.15470053837925));
         Vertex.Add(7, new HVector(0, 0, 1.15470053837925));
         Vertex.Add(8, new HVector(0, 0.816496580927726, -0.577350269189626));
         Vertex.Add(9, new HVector(0, 0.816496580927726, 0.577350269189626));
         Vertex.Add(10, new HVector(0.816496580927726, -0.816496580927726, 0));
         Vertex.Add(11, new HVector(0.816496580927726, 0, -0.577350269189626));
         Vertex.Add(12, new HVector(0.816496580927726, 0, 0.577350269189626));
         Vertex.Add(13, new HVector(0.816496580927726, 0.816496580927726, 0));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(1);
         hpoly.AddIndex(3);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(2);
         hpoly.AddIndex(7);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(8);
         hpoly.AddIndex(3);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(4);
         hpoly.AddIndex(9);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(10);
         hpoly.AddIndex(4);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(6);
         hpoly.AddIndex(1);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(4);
         hpoly.AddIndex(10);
         hpoly.AddIndex(14);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(7);
         hpoly.AddIndex(12);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(13);
         hpoly.AddIndex(8);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(9);
         hpoly.AddIndex(14);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(14);
         hpoly.AddIndex(10);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(13);
         hpoly.AddIndex(11);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);


       }

       

    }
}
