 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class RhombicHexecontahedronHedron : HedronBase
    {
       public RhombicHexecontahedronHedron()
       {
                   Name = "RhombicHexecontahedron";

         Vertex.Add(0, new HVector(-2.34164078649987, 0, -0.447213595499958));
         Vertex.Add(1, new HVector(-1.89442719099992, -1.37638192047117, 0.447213595499958));
         Vertex.Add(2, new HVector(-1.89442719099992, 1.37638192047117, 0.447213595499958));
         Vertex.Add(3, new HVector(-1.61803398874989, -0.525731112119134, 0));
         Vertex.Add(4, new HVector(-1.61803398874989, 0.525731112119134, 0));
         Vertex.Add(5, new HVector(-1.44721359549996, 0, -1.89442719099992));
         Vertex.Add(6, new HVector(-1.44721359549996, 0, -0.894427190999916));
         Vertex.Add(7, new HVector(-1.17082039324994, -0.85065080835204, 0.894427190999916));
         Vertex.Add(8, new HVector(-1.17082039324994, -0.85065080835204, 1.89442719099992));
         Vertex.Add(9, new HVector(-1.17082039324994, 0.85065080835204, 0.894427190999916));
         Vertex.Add(10, new HVector(-1.17082039324994, 0.85065080835204, 1.89442719099992));
         Vertex.Add(11, new HVector(-1, -1.37638192047117, 0));
         Vertex.Add(12, new HVector(-1, 1.37638192047117, 0));
         Vertex.Add(13, new HVector(-0.894427190999916, 0, 0.447213595499958));
         Vertex.Add(14, new HVector(-0.894427190999916, 0, 1.44721359549996));
         Vertex.Add(15, new HVector(-0.723606797749979, -2.22703272882321, -0.447213595499958));
         Vertex.Add(16, new HVector(-0.723606797749979, -0.525731112119134, -1.44721359549996));
         Vertex.Add(17, new HVector(-0.723606797749979, -0.525731112119134, -0.447213595499958));
         Vertex.Add(18, new HVector(-0.723606797749979, 0.525731112119134, -1.44721359549996));
         Vertex.Add(19, new HVector(-0.723606797749979, 0.525731112119134, -0.447213595499958));
         Vertex.Add(20, new HVector(-0.723606797749979, 2.22703272882321, -0.447213595499958));
         Vertex.Add(21, new HVector(-0.447213595499958, -1.37638192047117, -1.89442719099992));
         Vertex.Add(22, new HVector(-0.447213595499958, -1.37638192047117, -0.894427190999916));
         Vertex.Add(23, new HVector(-0.447213595499958, 1.37638192047117, -1.89442719099992));
         Vertex.Add(24, new HVector(-0.447213595499958, 1.37638192047117, -0.894427190999916));
         Vertex.Add(25, new HVector(-0.276393202250021, -0.85065080835204, 0.447213595499958));
         Vertex.Add(26, new HVector(-0.276393202250021, -0.85065080835204, 1.44721359549996));
         Vertex.Add(27, new HVector(-0.276393202250021, 0.85065080835204, 0.447213595499958));
         Vertex.Add(28, new HVector(-0.276393202250021, 0.85065080835204, 1.44721359549996));
         Vertex.Add(29, new HVector(0, -1.70130161670408, 0));
         Vertex.Add(30, new HVector(0, 0, -1));
         Vertex.Add(31, new HVector(0, 0, 1));
         Vertex.Add(32, new HVector(0, 1.70130161670408, 0));
         Vertex.Add(33, new HVector(0.276393202250021, -0.85065080835204, -1.44721359549996));
         Vertex.Add(34, new HVector(0.276393202250021, -0.85065080835204, -0.447213595499958));
         Vertex.Add(35, new HVector(0.276393202250021, 0.85065080835204, -1.44721359549996));
         Vertex.Add(36, new HVector(0.276393202250021, 0.85065080835204, -0.447213595499958));
         Vertex.Add(37, new HVector(0.447213595499958, -1.37638192047117, 0.894427190999916));
         Vertex.Add(38, new HVector(0.447213595499958, -1.37638192047117, 1.89442719099992));
         Vertex.Add(39, new HVector(0.447213595499958, 1.37638192047117, 0.894427190999916));
         Vertex.Add(40, new HVector(0.447213595499958, 1.37638192047117, 1.89442719099992));
         Vertex.Add(41, new HVector(0.723606797749979, -2.22703272882321, 0.447213595499958));
         Vertex.Add(42, new HVector(0.723606797749979, -0.525731112119134, 0.447213595499958));
         Vertex.Add(43, new HVector(0.723606797749979, -0.525731112119134, 1.44721359549996));
         Vertex.Add(44, new HVector(0.723606797749979, 0.525731112119134, 0.447213595499958));
         Vertex.Add(45, new HVector(0.723606797749979, 0.525731112119134, 1.44721359549996));
         Vertex.Add(46, new HVector(0.723606797749979, 2.22703272882321, 0.447213595499958));
         Vertex.Add(47, new HVector(0.894427190999916, 0, -1.44721359549996));
         Vertex.Add(48, new HVector(0.894427190999916, 0, -0.447213595499958));
         Vertex.Add(49, new HVector(1, -1.37638192047117, 0));
         Vertex.Add(50, new HVector(1, 1.37638192047117, 0));
         Vertex.Add(51, new HVector(1.17082039324994, -0.85065080835204, -1.89442719099992));
         Vertex.Add(52, new HVector(1.17082039324994, -0.85065080835204, -0.894427190999916));
         Vertex.Add(53, new HVector(1.17082039324994, 0.85065080835204, -1.89442719099992));
         Vertex.Add(54, new HVector(1.17082039324994, 0.85065080835204, -0.894427190999916));
         Vertex.Add(55, new HVector(1.44721359549996, 0, 0.894427190999916));
         Vertex.Add(56, new HVector(1.44721359549996, 0, 1.89442719099992));
         Vertex.Add(57, new HVector(1.61803398874989, -0.525731112119134, 0));
         Vertex.Add(58, new HVector(1.61803398874989, 0.525731112119134, 0));
         Vertex.Add(59, new HVector(1.89442719099992, -1.37638192047117, -0.447213595499958));
         Vertex.Add(60, new HVector(1.89442719099992, 1.37638192047117, -0.447213595499958));
         Vertex.Add(61, new HVector(2.34164078649987, 0, 0.447213595499958));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(35);
         hpoly.AddIndex(34);
         hpoly.AddIndex(52);
         hpoly.AddIndex(53);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(27);
         hpoly.AddIndex(9);
         hpoly.AddIndex(8);
         hpoly.AddIndex(26);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(28);
         hpoly.AddIndex(10);
         hpoly.AddIndex(11);
         hpoly.AddIndex(29);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(55);
         hpoly.AddIndex(54);
         hpoly.AddIndex(36);
         hpoly.AddIndex(37);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(18);
         hpoly.AddIndex(23);
         hpoly.AddIndex(16);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(21);
         hpoly.AddIndex(25);
         hpoly.AddIndex(20);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(45);
         hpoly.AddIndex(51);
         hpoly.AddIndex(47);
         hpoly.AddIndex(40);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(38);
         hpoly.AddIndex(42);
         hpoly.AddIndex(50);
         hpoly.AddIndex(43);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(18);
         hpoly.AddIndex(4);
         hpoly.AddIndex(1);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(53);
         hpoly.AddIndex(60);
         hpoly.AddIndex(50);
         hpoly.AddIndex(35);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(7);
         hpoly.AddIndex(1);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(51);
         hpoly.AddIndex(61);
         hpoly.AddIndex(55);
         hpoly.AddIndex(37);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(43);
         hpoly.AddIndex(58);
         hpoly.AddIndex(62);
         hpoly.AddIndex(56);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(2);
         hpoly.AddIndex(12);
         hpoly.AddIndex(26);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(45);
         hpoly.AddIndex(56);
         hpoly.AddIndex(62);
         hpoly.AddIndex(59);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(3);
         hpoly.AddIndex(10);
         hpoly.AddIndex(28);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(26);
         hpoly.AddIndex(30);
         hpoly.AddIndex(42);
         hpoly.AddIndex(38);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(10);
         hpoly.AddIndex(3);
         hpoly.AddIndex(5);
         hpoly.AddIndex(14);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(28);
         hpoly.AddIndex(40);
         hpoly.AddIndex(47);
         hpoly.AddIndex(33);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(2);
         hpoly.AddIndex(8);
         hpoly.AddIndex(14);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(35);
         hpoly.AddIndex(30);
         hpoly.AddIndex(16);
         hpoly.AddIndex(23);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(55);
         hpoly.AddIndex(61);
         hpoly.AddIndex(59);
         hpoly.AddIndex(49);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(37);
         hpoly.AddIndex(25);
         hpoly.AddIndex(21);
         hpoly.AddIndex(33);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(58);
         hpoly.AddIndex(60);
         hpoly.AddIndex(53);
         hpoly.AddIndex(49);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(26);
         hpoly.AddIndex(38);
         hpoly.AddIndex(39);
         hpoly.AddIndex(27);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(6);
         hpoly.AddIndex(17);
         hpoly.AddIndex(18);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(19);
         hpoly.AddIndex(6);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(29);
         hpoly.AddIndex(41);
         hpoly.AddIndex(40);
         hpoly.AddIndex(28);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(43);
         hpoly.AddIndex(56);
         hpoly.AddIndex(57);
         hpoly.AddIndex(44);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(23);
         hpoly.AddIndex(22);
         hpoly.AddIndex(34);
         hpoly.AddIndex(35);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(37);
         hpoly.AddIndex(36);
         hpoly.AddIndex(24);
         hpoly.AddIndex(25);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(46);
         hpoly.AddIndex(57);
         hpoly.AddIndex(56);
         hpoly.AddIndex(45);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(32);
         hpoly.AddIndex(44);
         hpoly.AddIndex(57);
         hpoly.AddIndex(46);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(1);
         hpoly.AddIndex(4);
         hpoly.AddIndex(14);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(31);
         hpoly.AddIndex(17);
         hpoly.AddIndex(6);
         hpoly.AddIndex(19);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(59);
         hpoly.AddIndex(62);
         hpoly.AddIndex(58);
         hpoly.AddIndex(49);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(32);
         hpoly.AddIndex(46);
         hpoly.AddIndex(41);
         hpoly.AddIndex(29);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(16);
         hpoly.AddIndex(30);
         hpoly.AddIndex(26);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(28);
         hpoly.AddIndex(33);
         hpoly.AddIndex(21);
         hpoly.AddIndex(13);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(27);
         hpoly.AddIndex(39);
         hpoly.AddIndex(44);
         hpoly.AddIndex(32);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(35);
         hpoly.AddIndex(50);
         hpoly.AddIndex(42);
         hpoly.AddIndex(30);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(19);
         hpoly.AddIndex(24);
         hpoly.AddIndex(36);
         hpoly.AddIndex(31);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(31);
         hpoly.AddIndex(34);
         hpoly.AddIndex(22);
         hpoly.AddIndex(17);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(33);
         hpoly.AddIndex(47);
         hpoly.AddIndex(51);
         hpoly.AddIndex(37);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(18);
         hpoly.AddIndex(12);
         hpoly.AddIndex(2);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(36);
         hpoly.AddIndex(54);
         hpoly.AddIndex(48);
         hpoly.AddIndex(31);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(5);
         hpoly.AddIndex(3);
         hpoly.AddIndex(13);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(48);
         hpoly.AddIndex(52);
         hpoly.AddIndex(34);
         hpoly.AddIndex(31);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(43);
         hpoly.AddIndex(50);
         hpoly.AddIndex(60);
         hpoly.AddIndex(58);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(29);
         hpoly.AddIndex(11);
         hpoly.AddIndex(15);
         hpoly.AddIndex(32);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(45);
         hpoly.AddIndex(59);
         hpoly.AddIndex(61);
         hpoly.AddIndex(51);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(15);
         hpoly.AddIndex(9);
         hpoly.AddIndex(27);
         hpoly.AddIndex(32);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(18);
         hpoly.AddIndex(17);
         hpoly.AddIndex(22);
         hpoly.AddIndex(23);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(15);
         hpoly.AddIndex(11);
         hpoly.AddIndex(10);
         hpoly.AddIndex(14);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(8);
         hpoly.AddIndex(9);
         hpoly.AddIndex(15);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(25);
         hpoly.AddIndex(24);
         hpoly.AddIndex(19);
         hpoly.AddIndex(20);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(49);
         hpoly.AddIndex(48);
         hpoly.AddIndex(54);
         hpoly.AddIndex(55);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(44);
         hpoly.AddIndex(39);
         hpoly.AddIndex(38);
         hpoly.AddIndex(43);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(45);
         hpoly.AddIndex(40);
         hpoly.AddIndex(41);
         hpoly.AddIndex(46);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(53);
         hpoly.AddIndex(52);
         hpoly.AddIndex(48);
         hpoly.AddIndex(49);
         Polygons.Add(hpoly);


       }

       

    }
}
