 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class GyroelongatedPentagonalRotundaHedron : HedronBase
    {
       public GyroelongatedPentagonalRotundaHedron()
       {
                   Name = "GyroelongatedPentagonalRotunda";

         Vertex.Add(0, new HVector(0, -1.61803398874989, 0));
         Vertex.Add(1, new HVector(0, 1.61803398874989, 0));
         Vertex.Add(2, new HVector(-1.61803398874989, 0, -0.862397003859459));
         Vertex.Add(3, new HVector(1.61803398874989, 0, -0.862397003859459));
         Vertex.Add(4, new HVector(-0.951056516295154, -1.30901699437495, 0));
         Vertex.Add(5, new HVector(-0.951056516295154, 1.30901699437495, 0));
         Vertex.Add(6, new HVector(0.951056516295154, -1.30901699437495, 0));
         Vertex.Add(7, new HVector(0.951056516295154, 1.30901699437495, 0));
         Vertex.Add(8, new HVector(-0.5, -1.53884176858763, -0.862397003859459));
         Vertex.Add(9, new HVector(-0.5, 1.53884176858763, -0.862397003859459));
         Vertex.Add(10, new HVector(0.5, -1.53884176858763, -0.862397003859459));
         Vertex.Add(11, new HVector(0.5, 1.53884176858763, -0.862397003859459));
         Vertex.Add(12, new HVector(-1.30901699437495, -0.951056516295154, -0.862397003859459));
         Vertex.Add(13, new HVector(-1.30901699437495, 0.951056516295154, -0.862397003859459));
         Vertex.Add(14, new HVector(1.30901699437495, -0.951056516295154, -0.862397003859459));
         Vertex.Add(15, new HVector(1.30901699437495, 0.951056516295154, -0.862397003859459));
         Vertex.Add(16, new HVector(-1.53884176858763, -0.5, 0));
         Vertex.Add(17, new HVector(-1.53884176858763, 0.5, 0));
         Vertex.Add(18, new HVector(1.53884176858763, -0.5, 0));
         Vertex.Add(19, new HVector(1.53884176858763, 0.5, 0));
         Vertex.Add(20, new HVector(1.37638192047117, 0, 0.85065080835204));
         Vertex.Add(21, new HVector(0.42532540417602, -1.30901699437495, 0.85065080835204));
         Vertex.Add(22, new HVector(0.42532540417602, 1.30901699437495, 0.85065080835204));
         Vertex.Add(23, new HVector(-1.11351636441161, -0.809016994374947, 0.85065080835204));
         Vertex.Add(24, new HVector(-1.11351636441161, 0.809016994374947, 0.85065080835204));
         Vertex.Add(25, new HVector(-0.85065080835204, 0, 1.37638192047117));
         Vertex.Add(26, new HVector(-0.262865556059567, -0.809016994374947, 1.37638192047117));
         Vertex.Add(27, new HVector(-0.262865556059567, 0.809016994374947, 1.37638192047117));
         Vertex.Add(28, new HVector(0.688190960235587, -0.5, 1.37638192047117));
         Vertex.Add(29, new HVector(0.688190960235587, 0.5, 1.37638192047117));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(10);
         hpoly.AddIndex(12);
         hpoly.AddIndex(16);
         hpoly.AddIndex(4);
         hpoly.AddIndex(15);
         hpoly.AddIndex(11);
         hpoly.AddIndex(9);
         hpoly.AddIndex(13);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(13);
         hpoly.AddIndex(17);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(9);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(11);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(15);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(15);
         hpoly.AddIndex(4);
         hpoly.AddIndex(19);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(16);
         hpoly.AddIndex(20);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(16);
         hpoly.AddIndex(12);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(10);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(10);
         hpoly.AddIndex(14);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(3);
         hpoly.AddIndex(18);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(5);
         hpoly.AddIndex(17);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(1);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(7);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(15);
         hpoly.AddIndex(19);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(20);
         hpoly.AddIndex(19);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(16);
         hpoly.AddIndex(8);
         hpoly.AddIndex(20);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(2);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(10);
         hpoly.AddIndex(6);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(18);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(17);
         hpoly.AddIndex(18);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(28);
         hpoly.AddIndex(26);
         hpoly.AddIndex(27);
         hpoly.AddIndex(29);
         hpoly.AddIndex(30);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(25);
         hpoly.AddIndex(26);
         hpoly.AddIndex(28);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(24);
         hpoly.AddIndex(27);
         hpoly.AddIndex(26);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(22);
         hpoly.AddIndex(29);
         hpoly.AddIndex(27);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(21);
         hpoly.AddIndex(30);
         hpoly.AddIndex(29);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(23);
         hpoly.AddIndex(28);
         hpoly.AddIndex(30);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(2);
         hpoly.AddIndex(23);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(18);
         hpoly.AddIndex(25);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(17);
         hpoly.AddIndex(5);
         hpoly.AddIndex(24);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(7);
         hpoly.AddIndex(22);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(19);
         hpoly.AddIndex(20);
         hpoly.AddIndex(21);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(6);
         hpoly.AddIndex(25);
         hpoly.AddIndex(28);
         hpoly.AddIndex(23);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(18);
         hpoly.AddIndex(17);
         hpoly.AddIndex(24);
         hpoly.AddIndex(26);
         hpoly.AddIndex(25);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(1);
         hpoly.AddIndex(22);
         hpoly.AddIndex(27);
         hpoly.AddIndex(24);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(19);
         hpoly.AddIndex(21);
         hpoly.AddIndex(29);
         hpoly.AddIndex(22);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(8);
         hpoly.AddIndex(23);
         hpoly.AddIndex(30);
         hpoly.AddIndex(21);
         Polygons.Add(hpoly);


       }

       

    }
}
