 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class EchidnahedronHedron : HedronBase
    {
       public EchidnahedronHedron()
       {
                   Name = "Echidnahedron";

         Vertex.Add(0, new HVector(0, 0, -2.48989828488278));
         Vertex.Add(1, new HVector(0, 0, 2.48989828488278));
         Vertex.Add(2, new HVector(0, -4.23606797749979, -2.48989828488278));
         Vertex.Add(3, new HVector(0, -4.23606797749979, 2.48989828488278));
         Vertex.Add(4, new HVector(0, 4.23606797749979, -2.48989828488278));
         Vertex.Add(5, new HVector(0, 4.23606797749979, 2.48989828488278));
         Vertex.Add(6, new HVector(-4.02874005347041, -1.30901699437495, -2.48989828488278));
         Vertex.Add(7, new HVector(-4.02874005347041, -1.30901699437495, 2.48989828488278));
         Vertex.Add(8, new HVector(-4.02874005347041, 1.30901699437495, -2.48989828488278));
         Vertex.Add(9, new HVector(-4.02874005347041, 1.30901699437495, 2.48989828488278));
         Vertex.Add(10, new HVector(4.02874005347041, -1.30901699437495, -2.48989828488278));
         Vertex.Add(11, new HVector(4.02874005347041, -1.30901699437495, 2.48989828488278));
         Vertex.Add(12, new HVector(4.02874005347041, 1.30901699437495, -2.48989828488278));
         Vertex.Add(13, new HVector(4.02874005347041, 1.30901699437495, 2.48989828488278));
         Vertex.Add(14, new HVector(-2.48989828488278, -3.42705098312484, -2.48989828488278));
         Vertex.Add(15, new HVector(-2.48989828488278, -3.42705098312484, 2.48989828488278));
         Vertex.Add(16, new HVector(-2.48989828488278, 3.42705098312484, -2.48989828488278));
         Vertex.Add(17, new HVector(-2.48989828488278, 3.42705098312484, 2.48989828488278));
         Vertex.Add(18, new HVector(2.48989828488278, -3.42705098312484, -2.48989828488278));
         Vertex.Add(19, new HVector(2.48989828488278, -3.42705098312484, 2.48989828488278));
         Vertex.Add(20, new HVector(2.48989828488278, 3.42705098312484, -2.48989828488278));
         Vertex.Add(21, new HVector(2.48989828488278, 3.42705098312484, 2.48989828488278));
         Vertex.Add(22, new HVector(-4.71693101370599, -0.809016994374947, -1.11351636441161));
         Vertex.Add(23, new HVector(-4.71693101370599, 0.809016994374947, -1.11351636441161));
         Vertex.Add(24, new HVector(4.71693101370599, -0.809016994374947, 1.11351636441161));
         Vertex.Add(25, new HVector(4.71693101370599, 0.809016994374947, 1.11351636441161));
         Vertex.Add(26, new HVector(-4.29160560952997, -2.11803398874989, 1.11351636441161));
         Vertex.Add(27, new HVector(-4.29160560952997, 2.11803398874989, 1.11351636441161));
         Vertex.Add(28, new HVector(4.29160560952997, -2.11803398874989, -1.11351636441161));
         Vertex.Add(29, new HVector(4.29160560952997, 2.11803398874989, -1.11351636441161));
         Vertex.Add(30, new HVector(-3.60341464929439, 0, -3.34054909323482));
         Vertex.Add(31, new HVector(3.60341464929439, 0, 3.34054909323482));
         Vertex.Add(32, new HVector(-3.34054909323482, -3.42705098312484, 1.11351636441161));
         Vertex.Add(33, new HVector(-3.34054909323482, 3.42705098312484, 1.11351636441161));
         Vertex.Add(34, new HVector(3.34054909323482, -3.42705098312484, -1.11351636441161));
         Vertex.Add(35, new HVector(3.34054909323482, 3.42705098312484, -1.11351636441161));
         Vertex.Add(36, new HVector(-2.9152236890588, -2.11803398874989, 3.34054909323482));
         Vertex.Add(37, new HVector(-2.9152236890588, 2.11803398874989, 3.34054909323482));
         Vertex.Add(38, new HVector(2.9152236890588, -2.11803398874989, -3.34054909323482));
         Vertex.Add(39, new HVector(2.9152236890588, 2.11803398874989, -3.34054909323482));
         Vertex.Add(40, new HVector(-2.22703272882321, 0, -1.11351636441161));
         Vertex.Add(41, new HVector(-2.22703272882321, -4.23606797749979, -1.11351636441161));
         Vertex.Add(42, new HVector(-2.22703272882321, 4.23606797749979, -1.11351636441161));
         Vertex.Add(43, new HVector(2.22703272882321, 0, 1.11351636441161));
         Vertex.Add(44, new HVector(2.22703272882321, -4.23606797749979, 1.11351636441161));
         Vertex.Add(45, new HVector(2.22703272882321, 4.23606797749979, 1.11351636441161));
         Vertex.Add(46, new HVector(-1.80170732464719, -1.30901699437495, 1.11351636441161));
         Vertex.Add(47, new HVector(-1.80170732464719, 1.30901699437495, 1.11351636441161));
         Vertex.Add(48, new HVector(1.80170732464719, -1.30901699437495, -1.11351636441161));
         Vertex.Add(49, new HVector(1.80170732464719, 1.30901699437495, -1.11351636441161));
         Vertex.Add(50, new HVector(-1.37638192047117, 0, -4.71693101370599));
         Vertex.Add(51, new HVector(-1.37638192047117, 0, 0.262865556059567));
         Vertex.Add(52, new HVector(1.37638192047117, 0, 4.71693101370599));
         Vertex.Add(53, new HVector(1.37638192047117, 0, -0.262865556059567));
         Vertex.Add(54, new HVector(-1.11351636441161, -3.42705098312484, -3.34054909323482));
         Vertex.Add(55, new HVector(-1.11351636441161, -0.809016994374947, 4.71693101370599));
         Vertex.Add(56, new HVector(-1.11351636441161, -0.809016994374947, -0.262865556059567));
         Vertex.Add(57, new HVector(-1.11351636441161, 0.809016994374947, 4.71693101370599));
         Vertex.Add(58, new HVector(-1.11351636441161, 0.809016994374947, -0.262865556059567));
         Vertex.Add(59, new HVector(-1.11351636441161, 3.42705098312484, -3.34054909323482));
         Vertex.Add(60, new HVector(1.11351636441161, -3.42705098312484, 3.34054909323482));
         Vertex.Add(61, new HVector(1.11351636441161, -0.809016994374947, -4.71693101370599));
         Vertex.Add(62, new HVector(1.11351636441161, -0.809016994374947, 0.262865556059567));
         Vertex.Add(63, new HVector(1.11351636441161, 0.809016994374947, -4.71693101370599));
         Vertex.Add(64, new HVector(1.11351636441161, 0.809016994374947, 0.262865556059567));
         Vertex.Add(65, new HVector(1.11351636441161, 3.42705098312484, 3.34054909323482));
         Vertex.Add(66, new HVector(-0.85065080835204, 0, 1.11351636441161));
         Vertex.Add(67, new HVector(0.85065080835204, 0, -1.11351636441161));
         Vertex.Add(68, new HVector(-0.688190960235587, -0.5, -1.11351636441161));
         Vertex.Add(69, new HVector(-0.688190960235587, 0.5, -1.11351636441161));
         Vertex.Add(70, new HVector(-0.688190960235587, -4.73606797749979, -1.11351636441161));
         Vertex.Add(71, new HVector(-0.688190960235587, -2.11803398874989, -1.11351636441161));
         Vertex.Add(72, new HVector(-0.688190960235587, 2.11803398874989, -1.11351636441161));
         Vertex.Add(73, new HVector(-0.688190960235587, 4.73606797749979, -1.11351636441161));
         Vertex.Add(74, new HVector(0.688190960235587, -0.5, 1.11351636441161));
         Vertex.Add(75, new HVector(0.688190960235587, 0.5, 1.11351636441161));
         Vertex.Add(76, new HVector(0.688190960235587, -4.73606797749979, 1.11351636441161));
         Vertex.Add(77, new HVector(0.688190960235587, -2.11803398874989, 1.11351636441161));
         Vertex.Add(78, new HVector(0.688190960235587, 2.11803398874989, 1.11351636441161));
         Vertex.Add(79, new HVector(0.688190960235587, 4.73606797749979, 1.11351636441161));
         Vertex.Add(80, new HVector(-0.42532540417602, -1.30901699437495, -4.71693101370599));
         Vertex.Add(81, new HVector(-0.42532540417602, -1.30901699437495, 0.262865556059567));
         Vertex.Add(82, new HVector(-0.42532540417602, 1.30901699437495, -4.71693101370599));
         Vertex.Add(83, new HVector(-0.42532540417602, 1.30901699437495, 0.262865556059567));
         Vertex.Add(84, new HVector(-0.262865556059567, -0.809016994374947, 1.11351636441161));
         Vertex.Add(85, new HVector(-0.262865556059567, 0.809016994374947, 1.11351636441161));
         Vertex.Add(86, new HVector(0.262865556059567, -0.809016994374947, -1.11351636441161));
         Vertex.Add(87, new HVector(0.262865556059567, 0.809016994374947, -1.11351636441161));
         Vertex.Add(88, new HVector(0.42532540417602, -1.30901699437495, 4.71693101370599));
         Vertex.Add(89, new HVector(0.42532540417602, -1.30901699437495, -0.262865556059567));
         Vertex.Add(90, new HVector(0.42532540417602, 1.30901699437495, 4.71693101370599));
         Vertex.Add(91, new HVector(0.42532540417602, 1.30901699437495, -0.262865556059567));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(10);
         hpoly.AddIndex(67);
         hpoly.AddIndex(48);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(45);
         hpoly.AddIndex(63);
         hpoly.AddIndex(78);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(21);
         hpoly.AddIndex(92);
         hpoly.AddIndex(50);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(34);
         hpoly.AddIndex(48);
         hpoly.AddIndex(84);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(78);
         hpoly.AddIndex(85);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(50);
         hpoly.AddIndex(54);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(37);
         hpoly.AddIndex(85);
         hpoly.AddIndex(67);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(29);
         hpoly.AddIndex(54);
         hpoly.AddIndex(63);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(74);
         hpoly.AddIndex(84);
         hpoly.AddIndex(92);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(16);
         hpoly.AddIndex(85);
         hpoly.AddIndex(47);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(26);
         hpoly.AddIndex(65);
         hpoly.AddIndex(44);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(17);
         hpoly.AddIndex(59);
         hpoly.AddIndex(73);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(27);
         hpoly.AddIndex(47);
         hpoly.AddIndex(52);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(44);
         hpoly.AddIndex(75);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(73);
         hpoly.AddIndex(92);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(61);
         hpoly.AddIndex(75);
         hpoly.AddIndex(85);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(36);
         hpoly.AddIndex(92);
         hpoly.AddIndex(65);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(24);
         hpoly.AddIndex(52);
         hpoly.AddIndex(59);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(75);
         hpoly.AddIndex(78);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(80);
         hpoly.AddIndex(84);
         hpoly.AddIndex(79);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(57);
         hpoly.AddIndex(41);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(77);
         hpoly.AddIndex(78);
         hpoly.AddIndex(82);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(22);
         hpoly.AddIndex(79);
         hpoly.AddIndex(76);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(41);
         hpoly.AddIndex(59);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(32);
         hpoly.AddIndex(76);
         hpoly.AddIndex(75);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(43);
         hpoly.AddIndex(59);
         hpoly.AddIndex(84);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(42);
         hpoly.AddIndex(82);
         hpoly.AddIndex(57);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(76);
         hpoly.AddIndex(44);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(28);
         hpoly.AddIndex(52);
         hpoly.AddIndex(48);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(90);
         hpoly.AddIndex(72);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(25);
         hpoly.AddIndex(44);
         hpoly.AddIndex(63);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(18);
         hpoly.AddIndex(48);
         hpoly.AddIndex(86);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(15);
         hpoly.AddIndex(72);
         hpoly.AddIndex(57);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(66);
         hpoly.AddIndex(86);
         hpoly.AddIndex(76);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(23);
         hpoly.AddIndex(57);
         hpoly.AddIndex(52);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(35);
         hpoly.AddIndex(63);
         hpoly.AddIndex(90);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(86);
         hpoly.AddIndex(79);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(33);
         hpoly.AddIndex(82);
         hpoly.AddIndex(47);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(54);
         hpoly.AddIndex(49);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(46);
         hpoly.AddIndex(79);
         hpoly.AddIndex(65);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(47);
         hpoly.AddIndex(67);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(19);
         hpoly.AddIndex(49);
         hpoly.AddIndex(90);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(38);
         hpoly.AddIndex(67);
         hpoly.AddIndex(86);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(71);
         hpoly.AddIndex(90);
         hpoly.AddIndex(82);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(30);
         hpoly.AddIndex(65);
         hpoly.AddIndex(54);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(89);
         hpoly.AddIndex(75);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(39);
         hpoly.AddIndex(68);
         hpoly.AddIndex(49);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(43);
         hpoly.AddIndex(84);
         hpoly.AddIndex(73);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(58);
         hpoly.AddIndex(2);
         hpoly.AddIndex(86);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(35);
         hpoly.AddIndex(49);
         hpoly.AddIndex(63);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(60);
         hpoly.AddIndex(73);
         hpoly.AddIndex(88);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(63);
         hpoly.AddIndex(75);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(64);
         hpoly.AddIndex(88);
         hpoly.AddIndex(68);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(18);
         hpoly.AddIndex(86);
         hpoly.AddIndex(84);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(53);
         hpoly.AddIndex(76);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(40);
         hpoly.AddIndex(88);
         hpoly.AddIndex(50);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(23);
         hpoly.AddIndex(52);
         hpoly.AddIndex(41);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(56);
         hpoly.AddIndex(2);
         hpoly.AddIndex(67);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(30);
         hpoly.AddIndex(50);
         hpoly.AddIndex(65);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(31);
         hpoly.AddIndex(41);
         hpoly.AddIndex(70);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(65);
         hpoly.AddIndex(76);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(83);
         hpoly.AddIndex(70);
         hpoly.AddIndex(88);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(67);
         hpoly.AddIndex(52);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(91);
         hpoly.AddIndex(86);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(60);
         hpoly.AddIndex(70);
         hpoly.AddIndex(73);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(71);
         hpoly.AddIndex(82);
         hpoly.AddIndex(72);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(89);
         hpoly.AddIndex(2);
         hpoly.AddIndex(85);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(74);
         hpoly.AddIndex(73);
         hpoly.AddIndex(84);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(55);
         hpoly.AddIndex(72);
         hpoly.AddIndex(69);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(84);
         hpoly.AddIndex(86);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(51);
         hpoly.AddIndex(69);
         hpoly.AddIndex(70);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(85);
         hpoly.AddIndex(82);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(58);
         hpoly.AddIndex(67);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(31);
         hpoly.AddIndex(69);
         hpoly.AddIndex(41);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(29);
         hpoly.AddIndex(63);
         hpoly.AddIndex(49);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(53);
         hpoly.AddIndex(2);
         hpoly.AddIndex(75);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(24);
         hpoly.AddIndex(41);
         hpoly.AddIndex(52);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(39);
         hpoly.AddIndex(49);
         hpoly.AddIndex(87);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(10);
         hpoly.AddIndex(52);
         hpoly.AddIndex(67);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(81);
         hpoly.AddIndex(87);
         hpoly.AddIndex(69);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(75);
         hpoly.AddIndex(63);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(56);
         hpoly.AddIndex(85);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(55);
         hpoly.AddIndex(87);
         hpoly.AddIndex(72);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(36);
         hpoly.AddIndex(65);
         hpoly.AddIndex(50);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(91);
         hpoly.AddIndex(2);
         hpoly.AddIndex(76);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(42);
         hpoly.AddIndex(72);
         hpoly.AddIndex(82);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(40);
         hpoly.AddIndex(50);
         hpoly.AddIndex(68);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(16);
         hpoly.AddIndex(82);
         hpoly.AddIndex(85);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(62);
         hpoly.AddIndex(68);
         hpoly.AddIndex(87);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(22);
         hpoly.AddIndex(76);
         hpoly.AddIndex(65);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(25);
         hpoly.AddIndex(54);
         hpoly.AddIndex(44);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(51);
         hpoly.AddIndex(70);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(38);
         hpoly.AddIndex(86);
         hpoly.AddIndex(48);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(32);
         hpoly.AddIndex(44);
         hpoly.AddIndex(76);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(62);
         hpoly.AddIndex(1);
         hpoly.AddIndex(68);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(28);
         hpoly.AddIndex(48);
         hpoly.AddIndex(59);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(68);
         hpoly.AddIndex(54);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(59);
         hpoly.AddIndex(70);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(91);
         hpoly.AddIndex(76);
         hpoly.AddIndex(86);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(46);
         hpoly.AddIndex(92);
         hpoly.AddIndex(79);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(81);
         hpoly.AddIndex(69);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(37);
         hpoly.AddIndex(67);
         hpoly.AddIndex(47);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(66);
         hpoly.AddIndex(79);
         hpoly.AddIndex(86);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(64);
         hpoly.AddIndex(1);
         hpoly.AddIndex(88);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(33);
         hpoly.AddIndex(47);
         hpoly.AddIndex(57);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(21);
         hpoly.AddIndex(88);
         hpoly.AddIndex(92);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(15);
         hpoly.AddIndex(57);
         hpoly.AddIndex(69);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(58);
         hpoly.AddIndex(86);
         hpoly.AddIndex(67);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(34);
         hpoly.AddIndex(59);
         hpoly.AddIndex(48);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(62);
         hpoly.AddIndex(87);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(61);
         hpoly.AddIndex(85);
         hpoly.AddIndex(78);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(38);
         hpoly.AddIndex(48);
         hpoly.AddIndex(67);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(83);
         hpoly.AddIndex(1);
         hpoly.AddIndex(70);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(45);
         hpoly.AddIndex(78);
         hpoly.AddIndex(90);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(17);
         hpoly.AddIndex(70);
         hpoly.AddIndex(59);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(19);
         hpoly.AddIndex(90);
         hpoly.AddIndex(87);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(56);
         hpoly.AddIndex(67);
         hpoly.AddIndex(85);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(27);
         hpoly.AddIndex(57);
         hpoly.AddIndex(47);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(64);
         hpoly.AddIndex(68);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(32);
         hpoly.AddIndex(75);
         hpoly.AddIndex(44);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(37);
         hpoly.AddIndex(47);
         hpoly.AddIndex(85);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(51);
         hpoly.AddIndex(1);
         hpoly.AddIndex(69);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(26);
         hpoly.AddIndex(44);
         hpoly.AddIndex(54);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(69);
         hpoly.AddIndex(57);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(54);
         hpoly.AddIndex(68);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(89);
         hpoly.AddIndex(85);
         hpoly.AddIndex(75);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(77);
         hpoly.AddIndex(90);
         hpoly.AddIndex(78);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(83);
         hpoly.AddIndex(88);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(66);
         hpoly.AddIndex(76);
         hpoly.AddIndex(79);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(61);
         hpoly.AddIndex(78);
         hpoly.AddIndex(75);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(81);
         hpoly.AddIndex(1);
         hpoly.AddIndex(87);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(80);
         hpoly.AddIndex(79);
         hpoly.AddIndex(92);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(87);
         hpoly.AddIndex(90);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(92);
         hpoly.AddIndex(88);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(53);
         hpoly.AddIndex(75);
         hpoly.AddIndex(76);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(22);
         hpoly.AddIndex(65);
         hpoly.AddIndex(79);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(19);
         hpoly.AddIndex(87);
         hpoly.AddIndex(49);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(24);
         hpoly.AddIndex(59);
         hpoly.AddIndex(41);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(79);
         hpoly.AddIndex(84);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(29);
         hpoly.AddIndex(49);
         hpoly.AddIndex(54);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(41);
         hpoly.AddIndex(69);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(26);
         hpoly.AddIndex(54);
         hpoly.AddIndex(65);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(55);
         hpoly.AddIndex(69);
         hpoly.AddIndex(87);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(34);
         hpoly.AddIndex(84);
         hpoly.AddIndex(59);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(18);
         hpoly.AddIndex(84);
         hpoly.AddIndex(48);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(68);
         hpoly.AddIndex(50);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(42);
         hpoly.AddIndex(57);
         hpoly.AddIndex(72);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(10);
         hpoly.AddIndex(48);
         hpoly.AddIndex(52);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(36);
         hpoly.AddIndex(50);
         hpoly.AddIndex(92);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(72);
         hpoly.AddIndex(87);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(80);
         hpoly.AddIndex(92);
         hpoly.AddIndex(84);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(39);
         hpoly.AddIndex(87);
         hpoly.AddIndex(68);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(27);
         hpoly.AddIndex(52);
         hpoly.AddIndex(57);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(52);
         hpoly.AddIndex(47);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(88);
         hpoly.AddIndex(73);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(35);
         hpoly.AddIndex(90);
         hpoly.AddIndex(49);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(16);
         hpoly.AddIndex(47);
         hpoly.AddIndex(82);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(43);
         hpoly.AddIndex(73);
         hpoly.AddIndex(59);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(49);
         hpoly.AddIndex(68);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(28);
         hpoly.AddIndex(59);
         hpoly.AddIndex(52);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(40);
         hpoly.AddIndex(68);
         hpoly.AddIndex(88);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(77);
         hpoly.AddIndex(82);
         hpoly.AddIndex(90);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(82);
         hpoly.AddIndex(78);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(70);
         hpoly.AddIndex(41);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(30);
         hpoly.AddIndex(54);
         hpoly.AddIndex(50);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(78);
         hpoly.AddIndex(63);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(23);
         hpoly.AddIndex(41);
         hpoly.AddIndex(57);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(21);
         hpoly.AddIndex(50);
         hpoly.AddIndex(88);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(33);
         hpoly.AddIndex(57);
         hpoly.AddIndex(82);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(60);
         hpoly.AddIndex(88);
         hpoly.AddIndex(70);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(25);
         hpoly.AddIndex(63);
         hpoly.AddIndex(54);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(63);
         hpoly.AddIndex(44);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(15);
         hpoly.AddIndex(69);
         hpoly.AddIndex(72);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(74);
         hpoly.AddIndex(92);
         hpoly.AddIndex(73);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(44);
         hpoly.AddIndex(65);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(71);
         hpoly.AddIndex(72);
         hpoly.AddIndex(90);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(17);
         hpoly.AddIndex(73);
         hpoly.AddIndex(70);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(45);
         hpoly.AddIndex(90);
         hpoly.AddIndex(63);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(31);
         hpoly.AddIndex(70);
         hpoly.AddIndex(69);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(46);
         hpoly.AddIndex(65);
         hpoly.AddIndex(92);
         Polygons.Add(hpoly);


       }

       

    }
}
