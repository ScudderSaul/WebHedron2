 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class SmallStellatedDodecahedronHedron : HedronBase
    {
       public SmallStellatedDodecahedronHedron()
       {
                   Name = "SmallStellatedDodecahedron";

         Vertex.Add(0, new HVector(-0.577350269189626, 0, -0.110264089708268));
         Vertex.Add(1, new HVector(-0.288675134594813, -0.5, 0.110264089708268));
         Vertex.Add(2, new HVector(-0.288675134594813, 0.5, 0.110264089708268));
         Vertex.Add(3, new HVector(0.288675134594813, -0.5, -0.110264089708268));
         Vertex.Add(4, new HVector(0.288675134594813, 0.5, -0.110264089708268));
         Vertex.Add(5, new HVector(0.577350269189626, 0, 0.110264089708268));
         Vertex.Add(6, new HVector(-0.35682208977309, 0, 0.467086179481358));
         Vertex.Add(7, new HVector(0.35682208977309, 0, -0.467086179481358));
         Vertex.Add(8, new HVector(-0.178411044886545, -0.309016994374947, -0.467086179481358));
         Vertex.Add(9, new HVector(-0.178411044886545, 0.309016994374947, -0.467086179481358));
         Vertex.Add(10, new HVector(0.178411044886545, -0.309016994374947, 0.467086179481358));
         Vertex.Add(11, new HVector(0.178411044886545, 0.309016994374947, 0.467086179481358));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(12);
         hpoly.AddIndex(1);
         hpoly.AddIndex(11);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(10);
         hpoly.AddIndex(4);
         hpoly.AddIndex(1);
         hpoly.AddIndex(8);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(8);
         hpoly.AddIndex(1);
         hpoly.AddIndex(5);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(11);
         hpoly.AddIndex(1);
         hpoly.AddIndex(4);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(5);
         hpoly.AddIndex(1);
         hpoly.AddIndex(12);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(10);
         hpoly.AddIndex(2);
         hpoly.AddIndex(3);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(12);
         hpoly.AddIndex(2);
         hpoly.AddIndex(6);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(6);
         hpoly.AddIndex(2);
         hpoly.AddIndex(8);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(6);
         hpoly.AddIndex(3);
         hpoly.AddIndex(11);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(8);
         hpoly.AddIndex(3);
         hpoly.AddIndex(6);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(5);
         hpoly.AddIndex(4);
         hpoly.AddIndex(10);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(12);
         hpoly.AddIndex(4);
         hpoly.AddIndex(5);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);


       }

       

    }
}
