 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class TridiminishedRhombicosidodecahedronHedron : HedronBase
    {
       public TridiminishedRhombicosidodecahedronHedron()
       {
                   Name = "TridiminishedRhombicosidodecahedron";

         Vertex.Add(0, new HVector(-2.09188715146742, 0.457125203532576, 0.461282714264026));
         Vertex.Add(1, new HVector(-2.06839474701325, 0.57334426377505, -0.531663022908613));
         Vertex.Add(2, new HVector(-2.04520498139417, -0.52202261148032, 0.65899546385983));
         Vertex.Add(3, new HVector(-2.00719347250985, -0.333976221867414, -0.947624487869823));
         Vertex.Add(4, new HVector(-1.99286140916613, -1.010950180926, -0.211757074053406));
         Vertex.Add(5, new HVector(-1.615394602404, 1.32897026034489, 0.574601060523477));
         Vertex.Add(6, new HVector(-1.60106253906027, 0.651996301286306, 1.31046847433989));
         Vertex.Add(7, new HVector(-1.59190219794983, 1.44518932058737, -0.418344676649161));
         Vertex.Add(8, new HVector(-1.55438036898702, -0.327151513726582, 1.5081812239357));
         Vertex.Add(9, new HVector(-1.43167518114514, -0.930206549513673, -1.50734592992781));
         Vertex.Add(10, new HVector(-1.41734311780141, -1.60718050857226, -0.771478516111389));
         Vertex.Add(11, new HVector(-0.797731292560062, 1.76049738017791, 0.955666745916001));
         Vertex.Add(12, new HVector(-0.783399229216328, 1.08352342111933, 1.69153415973241));
         Vertex.Add(13, new HVector(-0.759719783675744, 1.94854376979081, -0.650953205813646));
         Vertex.Add(14, new HVector(-0.707865891369199, -0.500771023581725, 2.01144010858762));
         Vertex.Add(15, new HVector(-0.561668299073161, -0.98760699912634, -1.99703278244852));
         Vertex.Add(16, new HVector(-0.538478533454082, -2.08297387438171, -0.806374295680075));
         Vertex.Add(17, new HVector(-0.268895171268594, 2.14341486754454, 0.198232554262218));
         Vertex.Add(18, new HVector(-0.23137334230578, 0.371074033230592, 2.12475845484706));
         Vertex.Add(19, new HVector(-0.00964241216262056, -1.70005638701507, -1.56380848733387));
         Vertex.Add(20, new HVector(0.0487831850577503, 1.58687787032277, 1.45892563056792));
         Vertex.Add(21, new HVector(0.110287098396245, 1.89114332017814, -1.14064005833436));
         Vertex.Add(22, new HVector(0.170998692978132, -0.976564389391179, 1.97654432901893));
         Vertex.Add(23, new HVector(0.270514115200916, -0.484252549922898, -2.22964131161301));
         Vertex.Add(24, new HVector(0.308035944163736, -2.25659338423686, -0.303115411028155));
         Vertex.Add(25, new HVector(0.577619306349214, 1.9697953576894, 0.701491438914146));
         Vertex.Add(26, new HVector(0.600809071968294, 0.874428482434029, 1.89214992568257));
         Vertex.Add(27, new HVector(0.601111710803396, 2.08601441793187, -0.291454298258495));
         Vertex.Add(28, new HVector(0.64749124204155, -0.104719332578863, 2.08986267527838));
         Vertex.Add(29, new HVector(0.685805389760955, 1.29491299253189, -1.70036150039234));
         Vertex.Add(30, new HVector(0.74651698434285, -1.57279471703744, 1.41682288696094));
         Vertex.Add(31, new HVector(0.747006664264334, 0.387592506889417, -2.11632296535356));
         Vertex.Add(32, new HVector(0.798860556570886, -2.06172228648312, 0.546070349047704));
         Vertex.Add(33, new HVector(0.822540002111458, -1.19670193781163, -1.79641701649836));
         Vertex.Add(34, new HVector(0.836872065455195, -1.87367589687022, -1.06054960268195));
         Vertex.Add(35, new HVector(1.45648389069655, 1.49400199187994, 0.666595659345457));
         Vertex.Add(36, new HVector(1.47081595404028, 0.817028032821362, 1.40246307316187));
         Vertex.Add(37, new HVector(1.47997629515072, 1.61022105212242, -0.326350077827182));
         Vertex.Add(38, new HVector(1.51749812411353, -0.16211978219153, 1.60017582275766));
         Vertex.Add(39, new HVector(1.53231986737876, 1.12129348267674, -1.19710261574042));
         Vertex.Add(40, new HVector(1.57869939861692, -1.069440267834, 1.18421435779645));
         Vertex.Add(41, new HVector(1.59352114188214, 0.213972997034277, -1.61306408070164));
         Vertex.Add(42, new HVector(1.63104297084497, -1.55836783727968, 0.31346181988321));
         Vertex.Add(43, new HVector(1.6402033119554, -0.765174817978608, -1.41535133110584));
         Vertex.Add(44, new HVector(1.65453537529914, -1.4421487770372, -0.679483917289428));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(36);
         hpoly.AddIndex(38);
         hpoly.AddIndex(28);
         hpoly.AddIndex(26);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(26);
         hpoly.AddIndex(28);
         hpoly.AddIndex(18);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(28);
         hpoly.AddIndex(22);
         hpoly.AddIndex(14);
         hpoly.AddIndex(18);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(38);
         hpoly.AddIndex(40);
         hpoly.AddIndex(30);
         hpoly.AddIndex(22);
         hpoly.AddIndex(28);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(8);
         hpoly.AddIndex(14);
         hpoly.AddIndex(22);
         hpoly.AddIndex(30);
         hpoly.AddIndex(32);
         hpoly.AddIndex(24);
         hpoly.AddIndex(16);
         hpoly.AddIndex(10);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(26);
         hpoly.AddIndex(18);
         hpoly.AddIndex(12);
         hpoly.AddIndex(21);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(21);
         hpoly.AddIndex(12);
         hpoly.AddIndex(13);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(6);
         hpoly.AddIndex(7);
         hpoly.AddIndex(13);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(18);
         hpoly.AddIndex(14);
         hpoly.AddIndex(8);
         hpoly.AddIndex(6);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(1);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(1);
         hpoly.AddIndex(3);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(2);
         hpoly.AddIndex(1);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(4);
         hpoly.AddIndex(5);
         hpoly.AddIndex(3);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(10);
         hpoly.AddIndex(11);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(21);
         hpoly.AddIndex(13);
         hpoly.AddIndex(19);
         hpoly.AddIndex(27);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(27);
         hpoly.AddIndex(19);
         hpoly.AddIndex(29);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(19);
         hpoly.AddIndex(15);
         hpoly.AddIndex(23);
         hpoly.AddIndex(29);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(7);
         hpoly.AddIndex(9);
         hpoly.AddIndex(15);
         hpoly.AddIndex(19);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(33);
         hpoly.AddIndex(31);
         hpoly.AddIndex(23);
         hpoly.AddIndex(15);
         hpoly.AddIndex(9);
         hpoly.AddIndex(3);
         hpoly.AddIndex(5);
         hpoly.AddIndex(11);
         hpoly.AddIndex(17);
         hpoly.AddIndex(25);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(27);
         hpoly.AddIndex(29);
         hpoly.AddIndex(39);
         hpoly.AddIndex(37);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(37);
         hpoly.AddIndex(39);
         hpoly.AddIndex(41);
         hpoly.AddIndex(43);
         hpoly.AddIndex(45);
         hpoly.AddIndex(44);
         hpoly.AddIndex(42);
         hpoly.AddIndex(40);
         hpoly.AddIndex(38);
         hpoly.AddIndex(36);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(29);
         hpoly.AddIndex(23);
         hpoly.AddIndex(31);
         hpoly.AddIndex(41);
         hpoly.AddIndex(39);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(31);
         hpoly.AddIndex(33);
         hpoly.AddIndex(43);
         hpoly.AddIndex(41);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(33);
         hpoly.AddIndex(25);
         hpoly.AddIndex(35);
         hpoly.AddIndex(45);
         hpoly.AddIndex(43);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(25);
         hpoly.AddIndex(17);
         hpoly.AddIndex(20);
         hpoly.AddIndex(35);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(40);
         hpoly.AddIndex(42);
         hpoly.AddIndex(32);
         hpoly.AddIndex(30);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(45);
         hpoly.AddIndex(35);
         hpoly.AddIndex(34);
         hpoly.AddIndex(44);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(44);
         hpoly.AddIndex(34);
         hpoly.AddIndex(24);
         hpoly.AddIndex(32);
         hpoly.AddIndex(42);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(35);
         hpoly.AddIndex(20);
         hpoly.AddIndex(34);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(34);
         hpoly.AddIndex(20);
         hpoly.AddIndex(16);
         hpoly.AddIndex(24);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(36);
         hpoly.AddIndex(26);
         hpoly.AddIndex(21);
         hpoly.AddIndex(27);
         hpoly.AddIndex(37);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(17);
         hpoly.AddIndex(11);
         hpoly.AddIndex(10);
         hpoly.AddIndex(16);
         Polygons.Add(hpoly);


       }

       

    }
}
