 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class Antiprism2Hedron : HedronBase
    {
       public Antiprism2Hedron()
       {
                   Name = "Antiprism2";

         Vertex.Add(0, new HVector(-0.5, -0.5, -0.420448207626857));
         Vertex.Add(1, new HVector(-0.5, 0.5, -0.420448207626857));
         Vertex.Add(2, new HVector(0, -0.707106781186547, 0.420448207626857));
         Vertex.Add(3, new HVector(0, 0.707106781186547, 0.420448207626857));
         Vertex.Add(4, new HVector(0.5, -0.5, -0.420448207626857));
         Vertex.Add(5, new HVector(0.5, 0.5, -0.420448207626857));
         Vertex.Add(6, new HVector(-0.707106781186547, 0, 0.420448207626857));
         Vertex.Add(7, new HVector(0.707106781186547, 0, 0.420448207626857));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(1);
         hpoly.AddIndex(2);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(4);
         hpoly.AddIndex(7);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(4);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(7);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(3);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(8);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(2);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(1);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(5);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(6);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);


       }

       

    }
}
