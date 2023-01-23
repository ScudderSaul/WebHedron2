 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class ElongatedPentagonalPyramidHedron : HedronBase
    {
       public ElongatedPentagonalPyramidHedron()
       {
                   Name = "ElongatedPentagonalPyramid";

         Vertex.Add(0, new HVector(0, 0, 1.52573111211913));
         Vertex.Add(1, new HVector(0.85065080835204, 0, 0));
         Vertex.Add(2, new HVector(0.85065080835204, 0, 1));
         Vertex.Add(3, new HVector(0.262865556059567, -0.809016994374947, 0));
         Vertex.Add(4, new HVector(0.262865556059567, -0.809016994374947, 1));
         Vertex.Add(5, new HVector(0.262865556059567, 0.809016994374947, 0));
         Vertex.Add(6, new HVector(0.262865556059567, 0.809016994374947, 1));
         Vertex.Add(7, new HVector(-0.688190960235587, -0.5, 0));
         Vertex.Add(8, new HVector(-0.688190960235587, -0.5, 1));
         Vertex.Add(9, new HVector(-0.688190960235587, 0.5, 0));
         Vertex.Add(10, new HVector(-0.688190960235587, 0.5, 1));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(11);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(9);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
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
         hpoly.AddIndex(7);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(10);
         hpoly.AddIndex(11);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(10);
         hpoly.AddIndex(8);
         hpoly.AddIndex(9);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(4);
         hpoly.AddIndex(5);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(2);
         hpoly.AddIndex(3);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(6);
         hpoly.AddIndex(7);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(4);
         hpoly.AddIndex(8);
         hpoly.AddIndex(10);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);


       }

       

    }
}
