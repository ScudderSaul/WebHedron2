 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class PyramidHedron : HedronBase
    {
       public PyramidHedron()
       {
                   Name = "Pyramid";

         Vertex.Add(0, new HVector(0, 0, 0.525731112119134));
         Vertex.Add(1, new HVector(0.85065080835204, 0, 0));
         Vertex.Add(2, new HVector(0.262865556059567, -0.809016994374947, 0));
         Vertex.Add(3, new HVector(0.262865556059567, 0.809016994374947, 0));
         Vertex.Add(4, new HVector(-0.688190960235587, -0.5, 0));
         Vertex.Add(5, new HVector(-0.688190960235587, 0.5, 0));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(6);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(5);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(3);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(2);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(4);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(3);
         hpoly.AddIndex(5);
         hpoly.AddIndex(6);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);


       }

       

    }
}
