 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class GyroelongatedTriangularBicupolaHedron : HedronBase
    {
       public GyroelongatedTriangularBicupolaHedron()
       {
                   Name = "GyroelongatedTriangularBicupola";

         Vertex.Add(0, new HVector(-1, 0, 0.427799838583676));
         Vertex.Add(1, new HVector(-0.5, -0.866025403784439, 0.427799838583676));
         Vertex.Add(2, new HVector(-0.5, 0.866025403784439, 0.427799838583676));
         Vertex.Add(3, new HVector(-0.5, -0.288675134594813, 1.2442964195114));
         Vertex.Add(4, new HVector(0, -1, -0.427799838583676));
         Vertex.Add(5, new HVector(0, 1, -0.427799838583676));
         Vertex.Add(6, new HVector(0, 0.577350269189626, 1.2442964195114));
         Vertex.Add(7, new HVector(0.5, -0.288675134594813, 1.2442964195114));
         Vertex.Add(8, new HVector(0.5, -0.866025403784439, 0.427799838583676));
         Vertex.Add(9, new HVector(0.5, 0.866025403784439, 0.427799838583676));
         Vertex.Add(10, new HVector(1, 0, 0.427799838583676));
         Vertex.Add(11, new HVector(-0.577350269189626, 0, -1.2442964195114));
         Vertex.Add(12, new HVector(0.288675134594813, -0.5, -1.2442964195114));
         Vertex.Add(13, new HVector(0.288675134594813, 0.5, -1.2442964195114));
         Vertex.Add(14, new HVector(-0.866025403784439, -0.5, -0.427799838583676));
         Vertex.Add(15, new HVector(-0.866025403784439, 0.5, -0.427799838583676));
         Vertex.Add(16, new HVector(0.866025403784439, -0.5, -0.427799838583676));
         Vertex.Add(17, new HVector(0.866025403784439, 0.5, -0.427799838583676));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(18);
         hpoly.AddIndex(10);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(3);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(16);
         hpoly.AddIndex(1);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(15);
         hpoly.AddIndex(2);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(9);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(17);
         hpoly.AddIndex(11);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(18);
         hpoly.AddIndex(6);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(16);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(16);
         hpoly.AddIndex(15);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(15);
         hpoly.AddIndex(5);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(17);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(17);
         hpoly.AddIndex(18);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(4);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(7);
         hpoly.AddIndex(3);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(4);
         hpoly.AddIndex(2);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(8);
         hpoly.AddIndex(11);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(10);
         hpoly.AddIndex(3);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(2);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(11);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(14);
         hpoly.AddIndex(13);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(18);
         hpoly.AddIndex(17);
         hpoly.AddIndex(13);
         hpoly.AddIndex(14);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(16);
         hpoly.AddIndex(6);
         hpoly.AddIndex(14);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(15);
         hpoly.AddIndex(12);
         hpoly.AddIndex(13);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(17);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(6);
         hpoly.AddIndex(18);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(15);
         hpoly.AddIndex(16);
         Polygons.Add(hpoly);


       }

       

    }
}
