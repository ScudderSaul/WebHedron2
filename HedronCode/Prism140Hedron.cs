 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class Prism140Hedron : HedronBase
    {
       public Prism140Hedron()
       {
                   Name = "Prism140";

         Vertex.Add(0, new HVector(0, -1.30656296487638, -0.5));
         Vertex.Add(1, new HVector(0, -1.30656296487638, 0.5));
         Vertex.Add(2, new HVector(0, 1.30656296487638, -0.5));
         Vertex.Add(3, new HVector(0, 1.30656296487638, 0.5));
         Vertex.Add(4, new HVector(-1.30656296487638, 0, -0.5));
         Vertex.Add(5, new HVector(-1.30656296487638, 0, 0.5));
         Vertex.Add(6, new HVector(1.30656296487638, 0, -0.5));
         Vertex.Add(7, new HVector(1.30656296487638, 0, 0.5));
         Vertex.Add(8, new HVector(-0.923879532511287, -0.923879532511287, -0.5));
         Vertex.Add(9, new HVector(-0.923879532511287, -0.923879532511287, 0.5));
         Vertex.Add(10, new HVector(-0.923879532511287, 0.923879532511287, -0.5));
         Vertex.Add(11, new HVector(-0.923879532511287, 0.923879532511287, 0.5));
         Vertex.Add(12, new HVector(0.923879532511287, -0.923879532511287, -0.5));
         Vertex.Add(13, new HVector(0.923879532511287, -0.923879532511287, 0.5));
         Vertex.Add(14, new HVector(0.923879532511287, 0.923879532511287, -0.5));
         Vertex.Add(15, new HVector(0.923879532511287, 0.923879532511287, 0.5));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(1);
         hpoly.AddIndex(9);
         hpoly.AddIndex(5);
         hpoly.AddIndex(11);
         hpoly.AddIndex(3);
         hpoly.AddIndex(15);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(16);
         hpoly.AddIndex(4);
         hpoly.AddIndex(12);
         hpoly.AddIndex(6);
         hpoly.AddIndex(10);
         hpoly.AddIndex(2);
         hpoly.AddIndex(14);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(15);
         hpoly.AddIndex(16);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(15);
         hpoly.AddIndex(3);
         hpoly.AddIndex(4);
         hpoly.AddIndex(16);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(11);
         hpoly.AddIndex(12);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(5);
         hpoly.AddIndex(6);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(9);
         hpoly.AddIndex(10);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(1);
         hpoly.AddIndex(2);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(13);
         hpoly.AddIndex(14);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(7);
         hpoly.AddIndex(8);
         hpoly.AddIndex(14);
         Polygons.Add(hpoly);


       }

       

    }
}
