 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class SnubDisphenoidHedron : HedronBase
    {
       public SnubDisphenoidHedron()
       {
                   Name = "SnubDisphenoid";

         Vertex.Add(0, new HVector(-0.5, 0, 0));
         Vertex.Add(1, new HVector(0, -0.5, 1.56786184846513));
         Vertex.Add(2, new HVector(0, 0.5, 1.56786184846513));
         Vertex.Add(3, new HVector(0, -0.644584273224155, 0.578369358379304));
         Vertex.Add(4, new HVector(0, 0.644584273224155, 0.578369358379304));
         Vertex.Add(5, new HVector(0.5, 0, 0));
         Vertex.Add(6, new HVector(-0.644584273224155, 0, 0.989492490085823));
         Vertex.Add(7, new HVector(0.644584273224155, 0, 0.989492490085823));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(3);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(2);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(2);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(4);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(8);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(1);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(1);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(5);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(5);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(8);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(6);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(1);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);


       }

       

    }
}
