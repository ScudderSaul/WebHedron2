 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class ParabiaugmentedDodecahedronHedron : HedronBase
    {
       public ParabiaugmentedDodecahedronHedron()
       {
                   Name = "ParabiaugmentedDodecahedron";

         Vertex.Add(0, new HVector(0, 0, 1.40125853844407));
         Vertex.Add(1, new HVector(0, 0, -1.40125853844407));
         Vertex.Add(2, new HVector(0.178411044886545, -1.30901699437495, 0.467086179481358));
         Vertex.Add(3, new HVector(0.178411044886545, 1.30901699437495, 0.467086179481358));
         Vertex.Add(4, new HVector(0.467086179481358, -0.809016994374947, -1.04443644867098));
         Vertex.Add(5, new HVector(0.467086179481358, 0.809016994374947, -1.04443644867098));
         Vertex.Add(6, new HVector(1.04443644867098, -0.809016994374947, 0.467086179481358));
         Vertex.Add(7, new HVector(1.04443644867098, 0.809016994374947, 0.467086179481358));
         Vertex.Add(8, new HVector(-1.22284749355753, -0.5, 0.467086179481358));
         Vertex.Add(9, new HVector(-1.22284749355753, 0.5, 0.467086179481358));
         Vertex.Add(10, new HVector(1.22284749355753, -0.5, -0.467086179481358));
         Vertex.Add(11, new HVector(1.22284749355753, 0.5, -0.467086179481358));
         Vertex.Add(12, new HVector(-0.934172358962716, 0, -1.04443644867098));
         Vertex.Add(13, new HVector(-0.467086179481358, -0.809016994374947, 1.04443644867098));
         Vertex.Add(14, new HVector(-0.467086179481358, 0.809016994374947, 1.04443644867098));
         Vertex.Add(15, new HVector(0.934172358962716, 0, 1.04443644867098));
         Vertex.Add(16, new HVector(-1.04443644867098, -0.809016994374947, -0.467086179481358));
         Vertex.Add(17, new HVector(-1.04443644867098, 0.809016994374947, -0.467086179481358));
         Vertex.Add(18, new HVector(0.995124848658019, 0, -1.30263533841814));
         Vertex.Add(19, new HVector(-0.995124848658019, 0, 1.30263533841814));
         Vertex.Add(20, new HVector(-0.178411044886545, -1.30901699437495, -0.467086179481358));
         Vertex.Add(21, new HVector(-0.178411044886545, 1.30901699437495, -0.467086179481358));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(11);
         hpoly.AddIndex(7);
         hpoly.AddIndex(3);
         hpoly.AddIndex(21);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(12);
         hpoly.AddIndex(8);
         hpoly.AddIndex(16);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(6);
         hpoly.AddIndex(22);
         hpoly.AddIndex(4);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(2);
         hpoly.AddIndex(13);
         hpoly.AddIndex(18);
         hpoly.AddIndex(22);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(5);
         hpoly.AddIndex(21);
         hpoly.AddIndex(17);
         hpoly.AddIndex(13);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(22);
         hpoly.AddIndex(18);
         hpoly.AddIndex(10);
         hpoly.AddIndex(15);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(18);
         hpoly.AddIndex(13);
         hpoly.AddIndex(17);
         hpoly.AddIndex(9);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(17);
         hpoly.AddIndex(21);
         hpoly.AddIndex(3);
         hpoly.AddIndex(14);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(7);
         hpoly.AddIndex(16);
         hpoly.AddIndex(1);
         hpoly.AddIndex(14);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(16);
         hpoly.AddIndex(8);
         hpoly.AddIndex(4);
         hpoly.AddIndex(15);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(15);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(10);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(9);
         hpoly.AddIndex(14);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(14);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(1);
         hpoly.AddIndex(15);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(19);
         hpoly.AddIndex(2);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(19);
         hpoly.AddIndex(6);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(19);
         hpoly.AddIndex(12);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(19);
         hpoly.AddIndex(11);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(19);
         hpoly.AddIndex(5);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);


       }

       

    }
}
