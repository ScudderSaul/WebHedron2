 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class AcuteGoldenRhombohedronHedron : HedronBase
    {
       public AcuteGoldenRhombohedronHedron()
       {
                   Name = "AcuteGoldenRhombohedron";

         Vertex.Add(0, new HVector(-0.947213595499958, -0.585410196624969, -0.42532540417602));
         Vertex.Add(1, new HVector(-0.5, -0.309016994374947, 0.42532540417602));
         Vertex.Add(2, new HVector(-0.5, 0.309016994374947, -0.42532540417602));
         Vertex.Add(3, new HVector(-0.0527864045000421, 0.585410196624969, 0.42532540417602));
         Vertex.Add(4, new HVector(0.0527864045000421, -0.585410196624969, -0.42532540417602));
         Vertex.Add(5, new HVector(0.5, -0.309016994374947, 0.42532540417602));
         Vertex.Add(6, new HVector(0.5, 0.309016994374947, -0.42532540417602));
         Vertex.Add(7, new HVector(0.947213595499958, 0.585410196624969, 0.42532540417602));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(3);
         hpoly.AddIndex(7);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(8);
         hpoly.AddIndex(4);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(6);
         hpoly.AddIndex(2);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(4);
         hpoly.AddIndex(8);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(2);
         hpoly.AddIndex(4);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(8);
         hpoly.AddIndex(6);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);


       }

       

    }
}
