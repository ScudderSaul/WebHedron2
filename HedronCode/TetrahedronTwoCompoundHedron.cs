 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class TetrahedronTwoCompoundHedron : HedronBase
    {
       public TetrahedronTwoCompoundHedron()
       {
                   Name = "TetrahedronTwoCompound";

         Vertex.Add(0, new HVector(-0.411954134627224, 0.404508497187474, 0.204124145231932));
         Vertex.Add(1, new HVector(-0.288675134594813, -0.5, -0.204124145231932));
         Vertex.Add(2, new HVector(-0.288675134594813, 0.5, -0.204124145231932));
         Vertex.Add(3, new HVector(-0.144337567297406, -0.559016994374947, 0.204124145231932));
         Vertex.Add(4, new HVector(0, 0, -0.612372435695794));
         Vertex.Add(5, new HVector(0, 0, 0.612372435695794));
         Vertex.Add(6, new HVector(0.55629170192463, 0.154508497187474, 0.204124145231932));
         Vertex.Add(7, new HVector(0.577350269189626, 0, -0.204124145231932));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(3);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(2);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(6);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(8);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(1);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(4);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(5);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(7);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);


       }

       

    }
}
