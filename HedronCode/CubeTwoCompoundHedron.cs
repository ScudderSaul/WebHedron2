 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class CubeTwoCompoundHedron : HedronBase
    {
       public CubeTwoCompoundHedron()
       {
                   Name = "CubeTwoCompound";

         Vertex.Add(0, new HVector(-0.707106781186547, -0.408248290463863, -0.288675134594813));
         Vertex.Add(1, new HVector(-0.707106781186547, -0.408248290463863, 0.288675134594813));
         Vertex.Add(2, new HVector(-0.707106781186547, 0.408248290463863, -0.288675134594813));
         Vertex.Add(3, new HVector(-0.707106781186547, 0.408248290463863, 0.288675134594813));
         Vertex.Add(4, new HVector(0, -0.816496580927726, -0.288675134594813));
         Vertex.Add(5, new HVector(0, -0.816496580927726, 0.288675134594813));
         Vertex.Add(6, new HVector(0, 0, -0.866025403784439));
         Vertex.Add(7, new HVector(0, 0, 0.866025403784439));
         Vertex.Add(8, new HVector(0, 0.816496580927726, -0.288675134594813));
         Vertex.Add(9, new HVector(0, 0.816496580927726, 0.288675134594813));
         Vertex.Add(10, new HVector(0.707106781186547, -0.408248290463863, -0.288675134594813));
         Vertex.Add(11, new HVector(0.707106781186547, -0.408248290463863, 0.288675134594813));
         Vertex.Add(12, new HVector(0.707106781186547, 0.408248290463863, -0.288675134594813));
         Vertex.Add(13, new HVector(0.707106781186547, 0.408248290463863, 0.288675134594813));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(12);
         hpoly.AddIndex(13);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(5);
         hpoly.AddIndex(12);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(10);
         hpoly.AddIndex(3);
         hpoly.AddIndex(2);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(2);
         hpoly.AddIndex(3);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(3);
         hpoly.AddIndex(10);
         hpoly.AddIndex(13);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(13);
         hpoly.AddIndex(12);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(6);
         hpoly.AddIndex(11);
         hpoly.AddIndex(14);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(1);
         hpoly.AddIndex(6);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(9);
         hpoly.AddIndex(4);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(4);
         hpoly.AddIndex(9);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(9);
         hpoly.AddIndex(14);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(11);
         hpoly.AddIndex(6);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);


       }

       

    }
}
