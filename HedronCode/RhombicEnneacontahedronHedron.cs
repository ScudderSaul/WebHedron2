 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class RhombicEnneacontahedronHedron : HedronBase
    {
       public RhombicEnneacontahedronHedron()
       {
                   Name = "RhombicEnneacontahedron";

         Vertex.Add(0, new HVector(-2.4120226591666, 0, -0.842621348333473));
         Vertex.Add(1, new HVector(-2.4120226591666, 0, 0.157378651666527));
         Vertex.Add(2, new HVector(-2.28470065541656, -0.934172358962716, -0.50928801500014));
         Vertex.Add(3, new HVector(-2.28470065541656, -0.934172358962716, 0.49071198499986));
         Vertex.Add(4, new HVector(-2.28470065541656, 0.934172358962716, -0.50928801500014));
         Vertex.Add(5, new HVector(-2.28470065541656, 0.934172358962716, 0.49071198499986));
         Vertex.Add(6, new HVector(-2.15737865166653, 0, 0.824045318333193));
         Vertex.Add(7, new HVector(-2.07868932583326, -0.577350269189626, -1.5879773408334));
         Vertex.Add(8, new HVector(-2.07868932583326, 0.577350269189626, -1.5879773408334));
         Vertex.Add(9, new HVector(-1.95136732208323, -1.51152262815234, -1.25464400750007));
         Vertex.Add(10, new HVector(-1.95136732208323, -1.51152262815234, -0.25464400750007));
         Vertex.Add(11, new HVector(-1.95136732208323, 1.51152262815234, -1.25464400750007));
         Vertex.Add(12, new HVector(-1.95136732208323, 1.51152262815234, -0.25464400750007));
         Vertex.Add(13, new HVector(-1.74535599249993, 0, -2.33333333333333));
         Vertex.Add(14, new HVector(-1.61803398874989, -0.934172358962716, -2));
         Vertex.Add(15, new HVector(-1.61803398874989, -0.934172358962716, 1.23606797749979));
         Vertex.Add(16, new HVector(-1.61803398874989, 0.934172358962716, -2));
         Vertex.Add(17, new HVector(-1.61803398874989, 0.934172358962716, 1.23606797749979));
         Vertex.Add(18, new HVector(-1.53934466291663, -1.51152262815234, 0.824045318333193));
         Vertex.Add(19, new HVector(-1.53934466291663, 1.51152262815234, 0.824045318333193));
         Vertex.Add(20, new HVector(-1.49071198499986, 0, 1.56940131083312));
         Vertex.Add(21, new HVector(-1.2060113295833, -2.08887289734197, -0.921310674166737));
         Vertex.Add(22, new HVector(-1.2060113295833, -2.08887289734197, 0.0786893258332633));
         Vertex.Add(23, new HVector(-1.2060113295833, 2.08887289734197, -0.921310674166737));
         Vertex.Add(24, new HVector(-1.2060113295833, 2.08887289734197, 0.0786893258332633));
         Vertex.Add(25, new HVector(-1.07868932583326, -1.86834471792543, -1.5879773408334));
         Vertex.Add(26, new HVector(-1.07868932583326, 1.86834471792543, -1.5879773408334));
         Vertex.Add(27, new HVector(-0.872677996249965, -1.51152262815234, 1.56940131083312));
         Vertex.Add(28, new HVector(-0.872677996249965, -0.35682208977309, -2.66666666666667));
         Vertex.Add(29, new HVector(-0.872677996249965, 0.35682208977309, -2.66666666666667));
         Vertex.Add(30, new HVector(-0.872677996249965, 1.51152262815234, 1.56940131083312));
         Vertex.Add(31, new HVector(-0.74535599249993, -1.29099444873581, -2.33333333333333));
         Vertex.Add(32, new HVector(-0.74535599249993, -0.577350269189626, 1.90273464416646));
         Vertex.Add(33, new HVector(-0.74535599249993, 0.577350269189626, 1.90273464416646));
         Vertex.Add(34, new HVector(-0.74535599249993, 1.29099444873581, -2.33333333333333));
         Vertex.Add(35, new HVector(-0.539344662916632, -2.08887289734197, 0.824045318333193));
         Vertex.Add(36, new HVector(-0.539344662916632, 2.08887289734197, 0.824045318333193));
         Vertex.Add(37, new HVector(-0.333333333333333, -2.44569498711506, -1.25464400750007));
         Vertex.Add(38, new HVector(-0.333333333333333, -2.44569498711506, -0.25464400750007));
         Vertex.Add(39, new HVector(-0.333333333333333, 2.44569498711506, -1.25464400750007));
         Vertex.Add(40, new HVector(-0.333333333333333, 2.44569498711506, -0.25464400750007));
         Vertex.Add(41, new HVector(-0.127322003750035, -0.934172358962716, 1.90273464416646));
         Vertex.Add(42, new HVector(-0.127322003750035, 0.934172358962716, 1.90273464416646));
         Vertex.Add(43, new HVector(0, -1.86834471792543, -2));
         Vertex.Add(44, new HVector(0, -1.86834471792543, 1.23606797749979));
         Vertex.Add(45, new HVector(0, 0, -3));
         Vertex.Add(46, new HVector(0, 0, 2.23606797749979));
         Vertex.Add(47, new HVector(0, 1.86834471792543, -2));
         Vertex.Add(48, new HVector(0, 1.86834471792543, 1.23606797749979));
         Vertex.Add(49, new HVector(0.127322003750035, -0.934172358962716, -2.66666666666667));
         Vertex.Add(50, new HVector(0.127322003750035, 0.934172358962716, -2.66666666666667));
         Vertex.Add(51, new HVector(0.333333333333333, -2.44569498711506, -0.50928801500014));
         Vertex.Add(52, new HVector(0.333333333333333, -2.44569498711506, 0.49071198499986));
         Vertex.Add(53, new HVector(0.333333333333333, 2.44569498711506, -0.50928801500014));
         Vertex.Add(54, new HVector(0.333333333333333, 2.44569498711506, 0.49071198499986));
         Vertex.Add(55, new HVector(0.539344662916632, -2.08887289734197, -1.5879773408334));
         Vertex.Add(56, new HVector(0.539344662916632, 2.08887289734197, -1.5879773408334));
         Vertex.Add(57, new HVector(0.74535599249993, -1.29099444873581, 1.56940131083312));
         Vertex.Add(58, new HVector(0.74535599249993, -0.577350269189626, -2.66666666666667));
         Vertex.Add(59, new HVector(0.74535599249993, 0.577350269189626, -2.66666666666667));
         Vertex.Add(60, new HVector(0.74535599249993, 1.29099444873581, 1.56940131083312));
         Vertex.Add(61, new HVector(0.872677996249965, -1.51152262815234, -2.33333333333333));
         Vertex.Add(62, new HVector(0.872677996249965, -0.35682208977309, 1.90273464416646));
         Vertex.Add(63, new HVector(0.872677996249965, 0.35682208977309, 1.90273464416646));
         Vertex.Add(64, new HVector(0.872677996249965, 1.51152262815234, -2.33333333333333));
         Vertex.Add(65, new HVector(1.07868932583326, -1.86834471792543, 0.824045318333193));
         Vertex.Add(66, new HVector(1.07868932583326, 1.86834471792543, 0.824045318333193));
         Vertex.Add(67, new HVector(1.2060113295833, -2.08887289734197, -0.842621348333473));
         Vertex.Add(68, new HVector(1.2060113295833, -2.08887289734197, 0.157378651666527));
         Vertex.Add(69, new HVector(1.2060113295833, 2.08887289734197, -0.842621348333473));
         Vertex.Add(70, new HVector(1.2060113295833, 2.08887289734197, 0.157378651666527));
         Vertex.Add(71, new HVector(1.49071198499986, 0, -2.33333333333333));
         Vertex.Add(72, new HVector(1.53934466291663, -1.51152262815234, -1.5879773408334));
         Vertex.Add(73, new HVector(1.53934466291663, 1.51152262815234, -1.5879773408334));
         Vertex.Add(74, new HVector(1.61803398874989, -0.934172358962716, -2));
         Vertex.Add(75, new HVector(1.61803398874989, -0.934172358962716, 1.23606797749979));
         Vertex.Add(76, new HVector(1.61803398874989, 0.934172358962716, -2));
         Vertex.Add(77, new HVector(1.61803398874989, 0.934172358962716, 1.23606797749979));
         Vertex.Add(78, new HVector(1.74535599249993, 0, 1.56940131083312));
         Vertex.Add(79, new HVector(1.95136732208323, -1.51152262815234, -0.50928801500014));
         Vertex.Add(80, new HVector(1.95136732208323, -1.51152262815234, 0.49071198499986));
         Vertex.Add(81, new HVector(1.95136732208323, 1.51152262815234, -0.50928801500014));
         Vertex.Add(82, new HVector(1.95136732208323, 1.51152262815234, 0.49071198499986));
         Vertex.Add(83, new HVector(2.07868932583326, -0.577350269189626, 0.824045318333193));
         Vertex.Add(84, new HVector(2.07868932583326, 0.577350269189626, 0.824045318333193));
         Vertex.Add(85, new HVector(2.15737865166653, 0, -1.5879773408334));
         Vertex.Add(86, new HVector(2.28470065541656, -0.934172358962716, -1.25464400750007));
         Vertex.Add(87, new HVector(2.28470065541656, -0.934172358962716, -0.25464400750007));
         Vertex.Add(88, new HVector(2.28470065541656, 0.934172358962716, -1.25464400750007));
         Vertex.Add(89, new HVector(2.28470065541656, 0.934172358962716, -0.25464400750007));
         Vertex.Add(90, new HVector(2.4120226591666, 0, -0.921310674166737));
         Vertex.Add(91, new HVector(2.4120226591666, 0, 0.0786893258332633));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(1);
         hpoly.AddIndex(3);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(92);
         hpoly.AddIndex(91);
         hpoly.AddIndex(89);
         hpoly.AddIndex(90);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(88);
         hpoly.AddIndex(87);
         hpoly.AddIndex(91);
         hpoly.AddIndex(92);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(5);
         hpoly.AddIndex(1);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(87);
         hpoly.AddIndex(86);
         hpoly.AddIndex(89);
         hpoly.AddIndex(91);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(6);
         hpoly.AddIndex(2);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(3);
         hpoly.AddIndex(10);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(90);
         hpoly.AddIndex(89);
         hpoly.AddIndex(82);
         hpoly.AddIndex(83);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(1);
         hpoly.AddIndex(8);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(92);
         hpoly.AddIndex(90);
         hpoly.AddIndex(83);
         hpoly.AddIndex(85);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(79);
         hpoly.AddIndex(76);
         hpoly.AddIndex(81);
         hpoly.AddIndex(84);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(17);
         hpoly.AddIndex(14);
         hpoly.AddIndex(9);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(81);
         hpoly.AddIndex(80);
         hpoly.AddIndex(87);
         hpoly.AddIndex(88);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(12);
         hpoly.AddIndex(5);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(10);
         hpoly.AddIndex(8);
         hpoly.AddIndex(14);
         hpoly.AddIndex(15);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(85);
         hpoly.AddIndex(83);
         hpoly.AddIndex(78);
         hpoly.AddIndex(79);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(84);
         hpoly.AddIndex(81);
         hpoly.AddIndex(88);
         hpoly.AddIndex(92);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(9);
         hpoly.AddIndex(1);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(1);
         hpoly.AddIndex(9);
         hpoly.AddIndex(14);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(92);
         hpoly.AddIndex(85);
         hpoly.AddIndex(79);
         hpoly.AddIndex(84);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(10);
         hpoly.AddIndex(22);
         hpoly.AddIndex(23);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(83);
         hpoly.AddIndex(82);
         hpoly.AddIndex(70);
         hpoly.AddIndex(71);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(50);
         hpoly.AddIndex(46);
         hpoly.AddIndex(59);
         hpoly.AddIndex(62);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(47);
         hpoly.AddIndex(43);
         hpoly.AddIndex(31);
         hpoly.AddIndex(34);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(21);
         hpoly.AddIndex(16);
         hpoly.AddIndex(28);
         hpoly.AddIndex(33);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(77);
         hpoly.AddIndex(72);
         hpoly.AddIndex(60);
         hpoly.AddIndex(65);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(74);
         hpoly.AddIndex(70);
         hpoly.AddIndex(82);
         hpoly.AddIndex(89);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(23);
         hpoly.AddIndex(19);
         hpoly.AddIndex(4);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(55);
         hpoly.AddIndex(49);
         hpoly.AddIndex(61);
         hpoly.AddIndex(67);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(44);
         hpoly.AddIndex(38);
         hpoly.AddIndex(26);
         hpoly.AddIndex(32);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(69);
         hpoly.AddIndex(68);
         hpoly.AddIndex(80);
         hpoly.AddIndex(81);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(25);
         hpoly.AddIndex(24);
         hpoly.AddIndex(12);
         hpoly.AddIndex(13);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(62);
         hpoly.AddIndex(59);
         hpoly.AddIndex(72);
         hpoly.AddIndex(75);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(34);
         hpoly.AddIndex(31);
         hpoly.AddIndex(18);
         hpoly.AddIndex(21);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(33);
         hpoly.AddIndex(28);
         hpoly.AddIndex(42);
         hpoly.AddIndex(47);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(65);
         hpoly.AddIndex(60);
         hpoly.AddIndex(46);
         hpoly.AddIndex(51);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(35);
         hpoly.AddIndex(27);
         hpoly.AddIndex(40);
         hpoly.AddIndex(48);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(66);
         hpoly.AddIndex(58);
         hpoly.AddIndex(45);
         hpoly.AddIndex(53);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(6);
         hpoly.AddIndex(20);
         hpoly.AddIndex(25);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(87);
         hpoly.AddIndex(80);
         hpoly.AddIndex(68);
         hpoly.AddIndex(73);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(59);
         hpoly.AddIndex(46);
         hpoly.AddIndex(60);
         hpoly.AddIndex(72);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(47);
         hpoly.AddIndex(34);
         hpoly.AddIndex(21);
         hpoly.AddIndex(33);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(41);
         hpoly.AddIndex(40);
         hpoly.AddIndex(24);
         hpoly.AddIndex(25);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(53);
         hpoly.AddIndex(52);
         hpoly.AddIndex(68);
         hpoly.AddIndex(69);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(64);
         hpoly.AddIndex(61);
         hpoly.AddIndex(43);
         hpoly.AddIndex(47);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(32);
         hpoly.AddIndex(29);
         hpoly.AddIndex(46);
         hpoly.AddIndex(50);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(35);
         hpoly.AddIndex(30);
         hpoly.AddIndex(14);
         hpoly.AddIndex(17);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(63);
         hpoly.AddIndex(58);
         hpoly.AddIndex(76);
         hpoly.AddIndex(79);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(81);
         hpoly.AddIndex(76);
         hpoly.AddIndex(58);
         hpoly.AddIndex(66);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(17);
         hpoly.AddIndex(12);
         hpoly.AddIndex(27);
         hpoly.AddIndex(35);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(62);
         hpoly.AddIndex(56);
         hpoly.AddIndex(38);
         hpoly.AddIndex(44);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(37);
         hpoly.AddIndex(31);
         hpoly.AddIndex(49);
         hpoly.AddIndex(55);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(61);
         hpoly.AddIndex(49);
         hpoly.AddIndex(31);
         hpoly.AddIndex(43);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(44);
         hpoly.AddIndex(32);
         hpoly.AddIndex(50);
         hpoly.AddIndex(62);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(40);
         hpoly.AddIndex(27);
         hpoly.AddIndex(12);
         hpoly.AddIndex(24);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(66);
         hpoly.AddIndex(53);
         hpoly.AddIndex(69);
         hpoly.AddIndex(81);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(71);
         hpoly.AddIndex(70);
         hpoly.AddIndex(54);
         hpoly.AddIndex(55);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(23);
         hpoly.AddIndex(22);
         hpoly.AddIndex(38);
         hpoly.AddIndex(39);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(79);
         hpoly.AddIndex(78);
         hpoly.AddIndex(61);
         hpoly.AddIndex(64);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(15);
         hpoly.AddIndex(14);
         hpoly.AddIndex(29);
         hpoly.AddIndex(32);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(51);
         hpoly.AddIndex(46);
         hpoly.AddIndex(30);
         hpoly.AddIndex(35);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(47);
         hpoly.AddIndex(42);
         hpoly.AddIndex(58);
         hpoly.AddIndex(63);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(53);
         hpoly.AddIndex(45);
         hpoly.AddIndex(28);
         hpoly.AddIndex(36);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(48);
         hpoly.AddIndex(40);
         hpoly.AddIndex(57);
         hpoly.AddIndex(65);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(32);
         hpoly.AddIndex(26);
         hpoly.AddIndex(10);
         hpoly.AddIndex(15);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(67);
         hpoly.AddIndex(61);
         hpoly.AddIndex(78);
         hpoly.AddIndex(83);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(83);
         hpoly.AddIndex(71);
         hpoly.AddIndex(55);
         hpoly.AddIndex(67);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(22);
         hpoly.AddIndex(10);
         hpoly.AddIndex(26);
         hpoly.AddIndex(38);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(65);
         hpoly.AddIndex(51);
         hpoly.AddIndex(35);
         hpoly.AddIndex(48);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(42);
         hpoly.AddIndex(28);
         hpoly.AddIndex(45);
         hpoly.AddIndex(58);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(63);
         hpoly.AddIndex(79);
         hpoly.AddIndex(64);
         hpoly.AddIndex(47);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(30);
         hpoly.AddIndex(46);
         hpoly.AddIndex(29);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(55);
         hpoly.AddIndex(54);
         hpoly.AddIndex(40);
         hpoly.AddIndex(41);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(39);
         hpoly.AddIndex(38);
         hpoly.AddIndex(52);
         hpoly.AddIndex(53);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(21);
         hpoly.AddIndex(18);
         hpoly.AddIndex(6);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(75);
         hpoly.AddIndex(72);
         hpoly.AddIndex(86);
         hpoly.AddIndex(87);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(89);
         hpoly.AddIndex(86);
         hpoly.AddIndex(72);
         hpoly.AddIndex(77);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(4);
         hpoly.AddIndex(16);
         hpoly.AddIndex(21);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(36);
         hpoly.AddIndex(28);
         hpoly.AddIndex(19);
         hpoly.AddIndex(23);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(65);
         hpoly.AddIndex(57);
         hpoly.AddIndex(70);
         hpoly.AddIndex(74);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(73);
         hpoly.AddIndex(68);
         hpoly.AddIndex(56);
         hpoly.AddIndex(62);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(25);
         hpoly.AddIndex(20);
         hpoly.AddIndex(31);
         hpoly.AddIndex(37);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(28);
         hpoly.AddIndex(16);
         hpoly.AddIndex(4);
         hpoly.AddIndex(19);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(77);
         hpoly.AddIndex(65);
         hpoly.AddIndex(74);
         hpoly.AddIndex(89);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(87);
         hpoly.AddIndex(73);
         hpoly.AddIndex(62);
         hpoly.AddIndex(75);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(6);
         hpoly.AddIndex(18);
         hpoly.AddIndex(31);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(37);
         hpoly.AddIndex(55);
         hpoly.AddIndex(41);
         hpoly.AddIndex(25);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(38);
         hpoly.AddIndex(56);
         hpoly.AddIndex(68);
         hpoly.AddIndex(52);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(54);
         hpoly.AddIndex(70);
         hpoly.AddIndex(57);
         hpoly.AddIndex(40);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(23);
         hpoly.AddIndex(39);
         hpoly.AddIndex(53);
         hpoly.AddIndex(36);
         Polygons.Add(hpoly);


       }

       

    }
}
