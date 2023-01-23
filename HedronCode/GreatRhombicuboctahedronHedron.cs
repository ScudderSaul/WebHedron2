 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class GreatRhombicuboctahedronHedron : HedronBase
    {
       public GreatRhombicuboctahedronHedron()
       {
                   Name = "GreatRhombicuboctahedron";

         Vertex.Add(0, new HVector(-0.5, 1.20710678118655, -1.9142135623731));
         Vertex.Add(1, new HVector(-0.5, 1.20710678118655, 1.9142135623731));
         Vertex.Add(2, new HVector(-0.5, -1.20710678118655, -1.9142135623731));
         Vertex.Add(3, new HVector(-0.5, -1.20710678118655, 1.9142135623731));
         Vertex.Add(4, new HVector(-0.5, -1.9142135623731, 1.20710678118655));
         Vertex.Add(5, new HVector(-0.5, -1.9142135623731, -1.20710678118655));
         Vertex.Add(6, new HVector(-0.5, 1.9142135623731, 1.20710678118655));
         Vertex.Add(7, new HVector(-0.5, 1.9142135623731, -1.20710678118655));
         Vertex.Add(8, new HVector(0.5, 1.20710678118655, -1.9142135623731));
         Vertex.Add(9, new HVector(0.5, 1.20710678118655, 1.9142135623731));
         Vertex.Add(10, new HVector(0.5, -1.20710678118655, -1.9142135623731));
         Vertex.Add(11, new HVector(0.5, -1.20710678118655, 1.9142135623731));
         Vertex.Add(12, new HVector(0.5, -1.9142135623731, 1.20710678118655));
         Vertex.Add(13, new HVector(0.5, -1.9142135623731, -1.20710678118655));
         Vertex.Add(14, new HVector(0.5, 1.9142135623731, 1.20710678118655));
         Vertex.Add(15, new HVector(0.5, 1.9142135623731, -1.20710678118655));
         Vertex.Add(16, new HVector(1.20710678118655, -0.5, -1.9142135623731));
         Vertex.Add(17, new HVector(1.20710678118655, -0.5, 1.9142135623731));
         Vertex.Add(18, new HVector(1.20710678118655, 0.5, -1.9142135623731));
         Vertex.Add(19, new HVector(1.20710678118655, 0.5, 1.9142135623731));
         Vertex.Add(20, new HVector(1.20710678118655, -1.9142135623731, -0.5));
         Vertex.Add(21, new HVector(1.20710678118655, -1.9142135623731, 0.5));
         Vertex.Add(22, new HVector(1.20710678118655, 1.9142135623731, -0.5));
         Vertex.Add(23, new HVector(1.20710678118655, 1.9142135623731, 0.5));
         Vertex.Add(24, new HVector(-1.20710678118655, -0.5, -1.9142135623731));
         Vertex.Add(25, new HVector(-1.20710678118655, -0.5, 1.9142135623731));
         Vertex.Add(26, new HVector(-1.20710678118655, 0.5, -1.9142135623731));
         Vertex.Add(27, new HVector(-1.20710678118655, 0.5, 1.9142135623731));
         Vertex.Add(28, new HVector(-1.20710678118655, -1.9142135623731, -0.5));
         Vertex.Add(29, new HVector(-1.20710678118655, -1.9142135623731, 0.5));
         Vertex.Add(30, new HVector(-1.20710678118655, 1.9142135623731, -0.5));
         Vertex.Add(31, new HVector(-1.20710678118655, 1.9142135623731, 0.5));
         Vertex.Add(32, new HVector(-1.9142135623731, -0.5, 1.20710678118655));
         Vertex.Add(33, new HVector(-1.9142135623731, -0.5, -1.20710678118655));
         Vertex.Add(34, new HVector(-1.9142135623731, 0.5, 1.20710678118655));
         Vertex.Add(35, new HVector(-1.9142135623731, 0.5, -1.20710678118655));
         Vertex.Add(36, new HVector(-1.9142135623731, 1.20710678118655, -0.5));
         Vertex.Add(37, new HVector(-1.9142135623731, 1.20710678118655, 0.5));
         Vertex.Add(38, new HVector(-1.9142135623731, -1.20710678118655, -0.5));
         Vertex.Add(39, new HVector(-1.9142135623731, -1.20710678118655, 0.5));
         Vertex.Add(40, new HVector(1.9142135623731, -0.5, 1.20710678118655));
         Vertex.Add(41, new HVector(1.9142135623731, -0.5, -1.20710678118655));
         Vertex.Add(42, new HVector(1.9142135623731, 0.5, 1.20710678118655));
         Vertex.Add(43, new HVector(1.9142135623731, 0.5, -1.20710678118655));
         Vertex.Add(44, new HVector(1.9142135623731, 1.20710678118655, -0.5));
         Vertex.Add(45, new HVector(1.9142135623731, 1.20710678118655, 0.5));
         Vertex.Add(46, new HVector(1.9142135623731, -1.20710678118655, -0.5));
         Vertex.Add(47, new HVector(1.9142135623731, -1.20710678118655, 0.5));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(44);
         hpoly.AddIndex(42);
         hpoly.AddIndex(17);
         hpoly.AddIndex(19);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(6);
         hpoly.AddIndex(3);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(34);
         hpoly.AddIndex(36);
         hpoly.AddIndex(27);
         hpoly.AddIndex(25);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(16);
         hpoly.AddIndex(9);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(18);
         hpoly.AddIndex(41);
         hpoly.AddIndex(43);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(4);
         hpoly.AddIndex(5);
         hpoly.AddIndex(13);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(26);
         hpoly.AddIndex(28);
         hpoly.AddIndex(35);
         hpoly.AddIndex(33);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(10);
         hpoly.AddIndex(15);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(45);
         hpoly.AddIndex(23);
         hpoly.AddIndex(24);
         hpoly.AddIndex(46);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(39);
         hpoly.AddIndex(29);
         hpoly.AddIndex(30);
         hpoly.AddIndex(40);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(48);
         hpoly.AddIndex(22);
         hpoly.AddIndex(21);
         hpoly.AddIndex(47);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(38);
         hpoly.AddIndex(32);
         hpoly.AddIndex(31);
         hpoly.AddIndex(37);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(19);
         hpoly.AddIndex(17);
         hpoly.AddIndex(11);
         hpoly.AddIndex(3);
         hpoly.AddIndex(25);
         hpoly.AddIndex(27);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(28);
         hpoly.AddIndex(26);
         hpoly.AddIndex(4);
         hpoly.AddIndex(12);
         hpoly.AddIndex(18);
         hpoly.AddIndex(20);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(41);
         hpoly.AddIndex(48);
         hpoly.AddIndex(47);
         hpoly.AddIndex(42);
         hpoly.AddIndex(44);
         hpoly.AddIndex(45);
         hpoly.AddIndex(46);
         hpoly.AddIndex(43);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(35);
         hpoly.AddIndex(38);
         hpoly.AddIndex(37);
         hpoly.AddIndex(36);
         hpoly.AddIndex(34);
         hpoly.AddIndex(39);
         hpoly.AddIndex(40);
         hpoly.AddIndex(33);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(15);
         hpoly.AddIndex(24);
         hpoly.AddIndex(23);
         hpoly.AddIndex(16);
         hpoly.AddIndex(8);
         hpoly.AddIndex(31);
         hpoly.AddIndex(32);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(30);
         hpoly.AddIndex(29);
         hpoly.AddIndex(6);
         hpoly.AddIndex(14);
         hpoly.AddIndex(21);
         hpoly.AddIndex(22);
         hpoly.AddIndex(13);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(46);
         hpoly.AddIndex(24);
         hpoly.AddIndex(15);
         hpoly.AddIndex(10);
         hpoly.AddIndex(20);
         hpoly.AddIndex(43);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(35);
         hpoly.AddIndex(28);
         hpoly.AddIndex(2);
         hpoly.AddIndex(7);
         hpoly.AddIndex(32);
         hpoly.AddIndex(38);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(41);
         hpoly.AddIndex(18);
         hpoly.AddIndex(12);
         hpoly.AddIndex(13);
         hpoly.AddIndex(22);
         hpoly.AddIndex(48);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(40);
         hpoly.AddIndex(30);
         hpoly.AddIndex(5);
         hpoly.AddIndex(4);
         hpoly.AddIndex(26);
         hpoly.AddIndex(33);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(44);
         hpoly.AddIndex(19);
         hpoly.AddIndex(9);
         hpoly.AddIndex(16);
         hpoly.AddIndex(23);
         hpoly.AddIndex(45);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(37);
         hpoly.AddIndex(31);
         hpoly.AddIndex(8);
         hpoly.AddIndex(1);
         hpoly.AddIndex(27);
         hpoly.AddIndex(36);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(47);
         hpoly.AddIndex(21);
         hpoly.AddIndex(14);
         hpoly.AddIndex(11);
         hpoly.AddIndex(17);
         hpoly.AddIndex(42);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(34);
         hpoly.AddIndex(25);
         hpoly.AddIndex(3);
         hpoly.AddIndex(6);
         hpoly.AddIndex(29);
         hpoly.AddIndex(39);
         Polygons.Add(hpoly);


       }

       

    }
}
