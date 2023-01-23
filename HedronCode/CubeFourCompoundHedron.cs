 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class CubeFourCompoundHedron : HedronBase
    {
       public CubeFourCompoundHedron()
       {
                   Name = "CubeFourCompound";

         Vertex.Add(0, new HVector(-0.707106781186547, -0.5, 0));
         Vertex.Add(1, new HVector(-0.707106781186547, 0, -0.5));
         Vertex.Add(2, new HVector(-0.707106781186547, 0, 0.5));
         Vertex.Add(3, new HVector(-0.707106781186547, 0.5, 0));
         Vertex.Add(4, new HVector(-0.5, -0.707106781186547, 0));
         Vertex.Add(5, new HVector(-0.5, -0.5, -0.5));
         Vertex.Add(6, new HVector(-0.5, -0.5, 0.5));
         Vertex.Add(7, new HVector(-0.5, 0, -0.707106781186547));
         Vertex.Add(8, new HVector(-0.5, 0, 0.707106781186547));
         Vertex.Add(9, new HVector(-0.5, 0.5, -0.5));
         Vertex.Add(10, new HVector(-0.5, 0.5, 0.5));
         Vertex.Add(11, new HVector(-0.5, 0.707106781186547, 0));
         Vertex.Add(12, new HVector(0, -0.707106781186547, -0.5));
         Vertex.Add(13, new HVector(0, -0.707106781186547, 0.5));
         Vertex.Add(14, new HVector(0, -0.5, -0.707106781186547));
         Vertex.Add(15, new HVector(0, -0.5, 0.707106781186547));
         Vertex.Add(16, new HVector(0, 0.5, -0.707106781186547));
         Vertex.Add(17, new HVector(0, 0.5, 0.707106781186547));
         Vertex.Add(18, new HVector(0, 0.707106781186547, -0.5));
         Vertex.Add(19, new HVector(0, 0.707106781186547, 0.5));
         Vertex.Add(20, new HVector(0.5, -0.707106781186547, 0));
         Vertex.Add(21, new HVector(0.5, -0.5, -0.5));
         Vertex.Add(22, new HVector(0.5, -0.5, 0.5));
         Vertex.Add(23, new HVector(0.5, 0, -0.707106781186547));
         Vertex.Add(24, new HVector(0.5, 0, 0.707106781186547));
         Vertex.Add(25, new HVector(0.5, 0.5, -0.5));
         Vertex.Add(26, new HVector(0.5, 0.5, 0.5));
         Vertex.Add(27, new HVector(0.5, 0.707106781186547, 0));
         Vertex.Add(28, new HVector(0.707106781186547, -0.5, 0));
         Vertex.Add(29, new HVector(0.707106781186547, 0, -0.5));
         Vertex.Add(30, new HVector(0.707106781186547, 0, 0.5));
         Vertex.Add(31, new HVector(0.707106781186547, 0.5, 0));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(30);
         hpoly.AddIndex(19);
         hpoly.AddIndex(2);
         hpoly.AddIndex(13);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(31);
         hpoly.AddIndex(20);
         hpoly.AddIndex(3);
         hpoly.AddIndex(14);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(3);
         hpoly.AddIndex(14);
         hpoly.AddIndex(13);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(19);
         hpoly.AddIndex(20);
         hpoly.AddIndex(3);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(30);
         hpoly.AddIndex(31);
         hpoly.AddIndex(14);
         hpoly.AddIndex(13);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(19);
         hpoly.AddIndex(20);
         hpoly.AddIndex(31);
         hpoly.AddIndex(30);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(29);
         hpoly.AddIndex(16);
         hpoly.AddIndex(1);
         hpoly.AddIndex(15);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(32);
         hpoly.AddIndex(18);
         hpoly.AddIndex(4);
         hpoly.AddIndex(17);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(17);
         hpoly.AddIndex(4);
         hpoly.AddIndex(1);
         hpoly.AddIndex(15);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(18);
         hpoly.AddIndex(16);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(17);
         hpoly.AddIndex(32);
         hpoly.AddIndex(29);
         hpoly.AddIndex(15);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(32);
         hpoly.AddIndex(18);
         hpoly.AddIndex(16);
         hpoly.AddIndex(29);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(24);
         hpoly.AddIndex(21);
         hpoly.AddIndex(5);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(21);
         hpoly.AddIndex(25);
         hpoly.AddIndex(9);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(24);
         hpoly.AddIndex(28);
         hpoly.AddIndex(12);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(28);
         hpoly.AddIndex(25);
         hpoly.AddIndex(9);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(9);
         hpoly.AddIndex(5);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(28);
         hpoly.AddIndex(25);
         hpoly.AddIndex(21);
         hpoly.AddIndex(24);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(22);
         hpoly.AddIndex(26);
         hpoly.AddIndex(10);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(23);
         hpoly.AddIndex(27);
         hpoly.AddIndex(11);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(22);
         hpoly.AddIndex(23);
         hpoly.AddIndex(7);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(26);
         hpoly.AddIndex(27);
         hpoly.AddIndex(11);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(10);
         hpoly.AddIndex(11);
         hpoly.AddIndex(7);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(26);
         hpoly.AddIndex(27);
         hpoly.AddIndex(23);
         hpoly.AddIndex(22);
         Polygons.Add(hpoly);


       }

       

    }
}
