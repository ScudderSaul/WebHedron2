 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class MathematicaPolyhedronHedron : HedronBase
    {
       public MathematicaPolyhedronHedron()
       {
                   Name = "MathematicaPolyhedron";

         Vertex.Add(0, new HVector(0, 0, -0.951056516295154));
         Vertex.Add(1, new HVector(0, 0, 0.951056516295154));
         Vertex.Add(2, new HVector(-0.85065080835204, 0, -0.42532540417602));
         Vertex.Add(3, new HVector(0.85065080835204, 0, 0.42532540417602));
         Vertex.Add(4, new HVector(-0.688190960235587, -0.5, 0.42532540417602));
         Vertex.Add(5, new HVector(-0.688190960235587, 0.5, 0.42532540417602));
         Vertex.Add(6, new HVector(0.688190960235587, -0.5, -0.42532540417602));
         Vertex.Add(7, new HVector(0.688190960235587, 0.5, -0.42532540417602));
         Vertex.Add(8, new HVector(-0.262865556059567, -0.809016994374947, -0.42532540417602));
         Vertex.Add(9, new HVector(-0.262865556059567, 0.809016994374947, -0.42532540417602));
         Vertex.Add(10, new HVector(0.262865556059567, -0.809016994374947, 0.42532540417602));
         Vertex.Add(11, new HVector(0.262865556059567, 0.809016994374947, 0.42532540417602));
         Vertex.Add(12, new HVector(-1.54434551628447, 0, 0.294943748423581));
         Vertex.Add(13, new HVector(1.54434551628447, 0, -0.294943748423581));
         Vertex.Add(14, new HVector(-0.954458019437307, 0, 1.24940176786088));
         Vertex.Add(15, new HVector(0.954458019437307, 0, -1.24940176786088));
         Vertex.Add(16, new HVector(-1.24940176786088, 0.907743518916014, -0.294943748423581));
         Vertex.Add(17, new HVector(-1.24940176786088, -0.907743518916014, -0.294943748423581));
         Vertex.Add(18, new HVector(1.24940176786088, 0.907743518916014, 0.294943748423581));
         Vertex.Add(19, new HVector(1.24940176786088, -0.907743518916014, 0.294943748423581));
         Vertex.Add(20, new HVector(-0.294943748423581, 0.907743518916014, 1.24940176786088));
         Vertex.Add(21, new HVector(-0.294943748423581, -0.907743518916014, 1.24940176786088));
         Vertex.Add(22, new HVector(0.294943748423581, 0.907743518916014, -1.24940176786088));
         Vertex.Add(23, new HVector(0.294943748423581, -0.907743518916014, -1.24940176786088));
         Vertex.Add(24, new HVector(-0.772172758142233, 0.56101634775753, -1.24940176786088));
         Vertex.Add(25, new HVector(-0.772172758142233, -0.56101634775753, -1.24940176786088));
         Vertex.Add(26, new HVector(0.772172758142233, 0.56101634775753, 1.24940176786088));
         Vertex.Add(27, new HVector(0.772172758142233, -0.56101634775753, 1.24940176786088));
         Vertex.Add(28, new HVector(-0.477229009718651, 1.46875986667354, 0.294943748423581));
         Vertex.Add(29, new HVector(-0.477229009718651, -1.46875986667354, 0.294943748423581));
         Vertex.Add(30, new HVector(0.477229009718652, 1.46875986667354, -0.294943748423581));
         Vertex.Add(31, new HVector(0.477229009718652, -1.46875986667354, -0.294943748423581));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(21);
         hpoly.AddIndex(2);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(21);
         hpoly.AddIndex(12);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(21);
         hpoly.AddIndex(6);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(15);
         hpoly.AddIndex(2);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(15);
         hpoly.AddIndex(6);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(15);
         hpoly.AddIndex(5);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(22);
         hpoly.AddIndex(2);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(22);
         hpoly.AddIndex(5);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(22);
         hpoly.AddIndex(11);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(28);
         hpoly.AddIndex(2);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(28);
         hpoly.AddIndex(11);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(28);
         hpoly.AddIndex(4);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(27);
         hpoly.AddIndex(2);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(27);
         hpoly.AddIndex(4);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(27);
         hpoly.AddIndex(12);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(24);
         hpoly.AddIndex(7);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(24);
         hpoly.AddIndex(9);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(24);
         hpoly.AddIndex(1);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(16);
         hpoly.AddIndex(8);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(16);
         hpoly.AddIndex(7);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(16);
         hpoly.AddIndex(1);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(23);
         hpoly.AddIndex(10);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(23);
         hpoly.AddIndex(8);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(23);
         hpoly.AddIndex(1);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(25);
         hpoly.AddIndex(3);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(25);
         hpoly.AddIndex(10);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(25);
         hpoly.AddIndex(1);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(26);
         hpoly.AddIndex(9);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(26);
         hpoly.AddIndex(3);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(26);
         hpoly.AddIndex(1);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(29);
         hpoly.AddIndex(12);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(29);
         hpoly.AddIndex(10);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(29);
         hpoly.AddIndex(6);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(6);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(3);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(5);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(30);
         hpoly.AddIndex(5);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(30);
         hpoly.AddIndex(9);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(30);
         hpoly.AddIndex(11);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(11);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(7);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(4);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(19);
         hpoly.AddIndex(4);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(19);
         hpoly.AddIndex(8);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(19);
         hpoly.AddIndex(12);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(32);
         hpoly.AddIndex(7);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(32);
         hpoly.AddIndex(11);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(32);
         hpoly.AddIndex(9);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(8);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(4);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(7);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(31);
         hpoly.AddIndex(10);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(31);
         hpoly.AddIndex(12);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(31);
         hpoly.AddIndex(8);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(17);
         hpoly.AddIndex(3);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(17);
         hpoly.AddIndex(6);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(17);
         hpoly.AddIndex(10);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(18);
         hpoly.AddIndex(9);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(18);
         hpoly.AddIndex(5);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(18);
         hpoly.AddIndex(3);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);


       }

       

    }
}
