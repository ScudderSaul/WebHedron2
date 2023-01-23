 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class SphenocoronaHedron : HedronBase
    {
       public SphenocoronaHedron()
       {
                   Name = "Sphenocorona";

         Vertex.Add(0, new HVector(0, -0.5, 0));
         Vertex.Add(1, new HVector(0, 0.5, 0));
         Vertex.Add(2, new HVector(-0.852726942846417, 0.5, 0.522356928683638));
         Vertex.Add(3, new HVector(-0.5, 0, 1.31329542426355));
         Vertex.Add(4, new HVector(-0.852726942846417, -0.5, 0.522356928683638));
         Vertex.Add(5, new HVector(0.852726942846417, 0.5, 0.522356928683638));
         Vertex.Add(6, new HVector(0.5, 0, 1.31329542426355));
         Vertex.Add(7, new HVector(0.852726942846417, -0.5, 0.522356928683638));
         Vertex.Add(8, new HVector(0, 0.789427626660872, 0.957199900190893));
         Vertex.Add(9, new HVector(0, -0.789427626660872, 0.957199900190893));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(2);
         hpoly.AddIndex(1);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(6);
         hpoly.AddIndex(8);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(9);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(6);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(3);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(9);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(5);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(7);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(7);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(10);
         hpoly.AddIndex(7);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(10);
         hpoly.AddIndex(8);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(10);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(8);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(1);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);


       }

       

    }
}
