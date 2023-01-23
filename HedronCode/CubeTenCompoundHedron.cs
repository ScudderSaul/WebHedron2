 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class CubeTenCompoundHedron : HedronBase
    {
       public CubeTenCompoundHedron()
       {
                   Name = "CubeTenCompound";

         Vertex.Add(0, new HVector(-0.5, -0.5, -0.5));
         Vertex.Add(1, new HVector(-0.5, -0.5, 0.5));
         Vertex.Add(2, new HVector(-0.5, 0.5, -0.5));
         Vertex.Add(3, new HVector(-0.5, 0.5, 0.5));
         Vertex.Add(4, new HVector(0, -0.809016994374947, -0.309016994374947));
         Vertex.Add(5, new HVector(0, -0.809016994374947, 0.309016994374947));
         Vertex.Add(6, new HVector(0, 0.809016994374947, -0.309016994374947));
         Vertex.Add(7, new HVector(0, 0.809016994374947, 0.309016994374947));
         Vertex.Add(8, new HVector(0, 0.56101634775753, 0.659742872298597));
         Vertex.Add(9, new HVector(0, 0.56101634775753, -0.659742872298597));
         Vertex.Add(10, new HVector(0, -0.56101634775753, 0.659742872298597));
         Vertex.Add(11, new HVector(0, -0.56101634775753, -0.659742872298597));
         Vertex.Add(12, new HVector(0.5, -0.5, -0.5));
         Vertex.Add(13, new HVector(0.5, -0.5, 0.5));
         Vertex.Add(14, new HVector(0.5, 0.5, -0.5));
         Vertex.Add(15, new HVector(0.5, 0.5, 0.5));
         Vertex.Add(16, new HVector(-0.707106781186547, 0.124000323308709, -0.484379933336772));
         Vertex.Add(17, new HVector(-0.707106781186547, 0.124000323308709, 0.484379933336772));
         Vertex.Add(18, new HVector(-0.707106781186547, -0.124000323308709, -0.484379933336772));
         Vertex.Add(19, new HVector(-0.707106781186547, -0.124000323308709, 0.484379933336772));
         Vertex.Add(20, new HVector(0.707106781186547, 0.124000323308709, -0.484379933336772));
         Vertex.Add(21, new HVector(0.707106781186547, 0.124000323308709, 0.484379933336772));
         Vertex.Add(22, new HVector(0.707106781186547, -0.124000323308709, -0.484379933336772));
         Vertex.Add(23, new HVector(0.707106781186547, -0.124000323308709, 0.484379933336772));
         Vertex.Add(24, new HVector(-0.809016994374947, -0.309016994374947, 0));
         Vertex.Add(25, new HVector(-0.809016994374947, 0.309016994374947, 0));
         Vertex.Add(26, new HVector(-0.309016994374947, 0, -0.809016994374947));
         Vertex.Add(27, new HVector(-0.309016994374947, 0, 0.809016994374947));
         Vertex.Add(28, new HVector(0.309016994374947, 0, -0.809016994374947));
         Vertex.Add(29, new HVector(0.309016994374947, 0, 0.809016994374947));
         Vertex.Add(30, new HVector(0.809016994374947, -0.309016994374947, 0));
         Vertex.Add(31, new HVector(0.809016994374947, 0.309016994374947, 0));
         Vertex.Add(32, new HVector(-0.360379610028063, -0.783743195607305, 0.0766364144207578));
         Vertex.Add(33, new HVector(-0.360379610028063, -0.783743195607305, -0.0766364144207579));
         Vertex.Add(34, new HVector(-0.360379610028063, 0.783743195607305, 0.0766364144207578));
         Vertex.Add(35, new HVector(-0.360379610028063, 0.783743195607305, -0.0766364144207579));
         Vertex.Add(36, new HVector(0.360379610028063, -0.783743195607305, 0.0766364144207578));
         Vertex.Add(37, new HVector(0.360379610028063, -0.783743195607305, -0.0766364144207579));
         Vertex.Add(38, new HVector(0.360379610028063, 0.783743195607305, 0.0766364144207578));
         Vertex.Add(39, new HVector(0.360379610028063, 0.783743195607305, -0.0766364144207579));
         Vertex.Add(40, new HVector(0.0766364144207578, -0.360379610028063, -0.783743195607305));
         Vertex.Add(41, new HVector(0.0766364144207578, -0.360379610028063, 0.783743195607305));
         Vertex.Add(42, new HVector(0.0766364144207578, 0.360379610028063, -0.783743195607305));
         Vertex.Add(43, new HVector(0.0766364144207578, 0.360379610028063, 0.783743195607305));
         Vertex.Add(44, new HVector(-0.0766364144207579, -0.360379610028063, -0.783743195607305));
         Vertex.Add(45, new HVector(-0.0766364144207579, -0.360379610028063, 0.783743195607305));
         Vertex.Add(46, new HVector(-0.0766364144207579, 0.360379610028063, -0.783743195607305));
         Vertex.Add(47, new HVector(-0.0766364144207579, 0.360379610028063, 0.783743195607305));
         Vertex.Add(48, new HVector(-0.783743195607305, 0.0766364144207578, -0.360379610028063));
         Vertex.Add(49, new HVector(-0.783743195607305, 0.0766364144207578, 0.360379610028063));
         Vertex.Add(50, new HVector(-0.783743195607305, -0.0766364144207579, -0.360379610028063));
         Vertex.Add(51, new HVector(-0.783743195607305, -0.0766364144207579, 0.360379610028063));
         Vertex.Add(52, new HVector(0.783743195607305, 0.0766364144207578, -0.360379610028063));
         Vertex.Add(53, new HVector(0.783743195607305, 0.0766364144207578, 0.360379610028063));
         Vertex.Add(54, new HVector(0.783743195607305, -0.0766364144207579, -0.360379610028063));
         Vertex.Add(55, new HVector(0.783743195607305, -0.0766364144207579, 0.360379610028063));
         Vertex.Add(56, new HVector(0.56101634775753, 0.659742872298597, 0));
         Vertex.Add(57, new HVector(0.56101634775753, -0.659742872298597, 0));
         Vertex.Add(58, new HVector(0.659742872298597, 0, 0.56101634775753));
         Vertex.Add(59, new HVector(0.659742872298597, 0, -0.56101634775753));
         Vertex.Add(60, new HVector(-0.484379933336772, -0.707106781186547, 0.124000323308709));
         Vertex.Add(61, new HVector(-0.484379933336772, -0.707106781186547, -0.124000323308709));
         Vertex.Add(62, new HVector(-0.484379933336772, 0.707106781186547, 0.124000323308709));
         Vertex.Add(63, new HVector(-0.484379933336772, 0.707106781186547, -0.124000323308709));
         Vertex.Add(64, new HVector(0.124000323308709, -0.484379933336772, -0.707106781186547));
         Vertex.Add(65, new HVector(0.124000323308709, -0.484379933336772, 0.707106781186547));
         Vertex.Add(66, new HVector(0.124000323308709, 0.484379933336772, -0.707106781186547));
         Vertex.Add(67, new HVector(0.124000323308709, 0.484379933336772, 0.707106781186547));
         Vertex.Add(68, new HVector(-0.659742872298597, 0, 0.56101634775753));
         Vertex.Add(69, new HVector(-0.659742872298597, 0, -0.56101634775753));
         Vertex.Add(70, new HVector(-0.56101634775753, 0.659742872298597, 0));
         Vertex.Add(71, new HVector(-0.56101634775753, -0.659742872298597, 0));
         Vertex.Add(72, new HVector(-0.124000323308709, -0.484379933336772, -0.707106781186547));
         Vertex.Add(73, new HVector(-0.124000323308709, -0.484379933336772, 0.707106781186547));
         Vertex.Add(74, new HVector(-0.124000323308709, 0.484379933336772, -0.707106781186547));
         Vertex.Add(75, new HVector(-0.124000323308709, 0.484379933336772, 0.707106781186547));
         Vertex.Add(76, new HVector(0.484379933336772, -0.707106781186547, 0.124000323308709));
         Vertex.Add(77, new HVector(0.484379933336772, -0.707106781186547, -0.124000323308709));
         Vertex.Add(78, new HVector(0.484379933336772, 0.707106781186547, 0.124000323308709));
         Vertex.Add(79, new HVector(0.484379933336772, 0.707106781186547, -0.124000323308709));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(16);
         hpoly.AddIndex(35);
         hpoly.AddIndex(52);
         hpoly.AddIndex(42);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(16);
         hpoly.AddIndex(42);
         hpoly.AddIndex(38);
         hpoly.AddIndex(53);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(16);
         hpoly.AddIndex(53);
         hpoly.AddIndex(47);
         hpoly.AddIndex(35);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(35);
         hpoly.AddIndex(47);
         hpoly.AddIndex(1);
         hpoly.AddIndex(52);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(47);
         hpoly.AddIndex(53);
         hpoly.AddIndex(38);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(52);
         hpoly.AddIndex(1);
         hpoly.AddIndex(38);
         hpoly.AddIndex(42);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(30);
         hpoly.AddIndex(79);
         hpoly.AddIndex(64);
         hpoly.AddIndex(69);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(30);
         hpoly.AddIndex(69);
         hpoly.AddIndex(62);
         hpoly.AddIndex(77);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(30);
         hpoly.AddIndex(77);
         hpoly.AddIndex(60);
         hpoly.AddIndex(79);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(79);
         hpoly.AddIndex(60);
         hpoly.AddIndex(27);
         hpoly.AddIndex(64);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(27);
         hpoly.AddIndex(60);
         hpoly.AddIndex(77);
         hpoly.AddIndex(62);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(64);
         hpoly.AddIndex(27);
         hpoly.AddIndex(62);
         hpoly.AddIndex(69);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(32);
         hpoly.AddIndex(68);
         hpoly.AddIndex(74);
         hpoly.AddIndex(58);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(32);
         hpoly.AddIndex(58);
         hpoly.AddIndex(73);
         hpoly.AddIndex(67);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(32);
         hpoly.AddIndex(67);
         hpoly.AddIndex(71);
         hpoly.AddIndex(68);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(68);
         hpoly.AddIndex(71);
         hpoly.AddIndex(25);
         hpoly.AddIndex(74);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(25);
         hpoly.AddIndex(71);
         hpoly.AddIndex(67);
         hpoly.AddIndex(73);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(74);
         hpoly.AddIndex(25);
         hpoly.AddIndex(73);
         hpoly.AddIndex(58);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(31);
         hpoly.AddIndex(57);
         hpoly.AddIndex(76);
         hpoly.AddIndex(66);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(31);
         hpoly.AddIndex(66);
         hpoly.AddIndex(72);
         hpoly.AddIndex(65);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(31);
         hpoly.AddIndex(65);
         hpoly.AddIndex(75);
         hpoly.AddIndex(57);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(57);
         hpoly.AddIndex(75);
         hpoly.AddIndex(26);
         hpoly.AddIndex(76);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(26);
         hpoly.AddIndex(75);
         hpoly.AddIndex(65);
         hpoly.AddIndex(72);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(76);
         hpoly.AddIndex(26);
         hpoly.AddIndex(72);
         hpoly.AddIndex(66);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(15);
         hpoly.AddIndex(54);
         hpoly.AddIndex(37);
         hpoly.AddIndex(41);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(15);
         hpoly.AddIndex(41);
         hpoly.AddIndex(51);
         hpoly.AddIndex(36);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(15);
         hpoly.AddIndex(36);
         hpoly.AddIndex(48);
         hpoly.AddIndex(54);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(54);
         hpoly.AddIndex(48);
         hpoly.AddIndex(2);
         hpoly.AddIndex(37);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(48);
         hpoly.AddIndex(36);
         hpoly.AddIndex(51);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(37);
         hpoly.AddIndex(2);
         hpoly.AddIndex(51);
         hpoly.AddIndex(41);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(29);
         hpoly.AddIndex(80);
         hpoly.AddIndex(59);
         hpoly.AddIndex(78);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(29);
         hpoly.AddIndex(78);
         hpoly.AddIndex(61);
         hpoly.AddIndex(70);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(29);
         hpoly.AddIndex(70);
         hpoly.AddIndex(63);
         hpoly.AddIndex(80);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(80);
         hpoly.AddIndex(63);
         hpoly.AddIndex(28);
         hpoly.AddIndex(59);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(28);
         hpoly.AddIndex(63);
         hpoly.AddIndex(70);
         hpoly.AddIndex(61);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(59);
         hpoly.AddIndex(28);
         hpoly.AddIndex(61);
         hpoly.AddIndex(78);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(21);
         hpoly.AddIndex(12);
         hpoly.AddIndex(17);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(17);
         hpoly.AddIndex(20);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(9);
         hpoly.AddIndex(24);
         hpoly.AddIndex(21);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(21);
         hpoly.AddIndex(24);
         hpoly.AddIndex(6);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(24);
         hpoly.AddIndex(9);
         hpoly.AddIndex(20);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(6);
         hpoly.AddIndex(20);
         hpoly.AddIndex(17);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(40);
         hpoly.AddIndex(55);
         hpoly.AddIndex(45);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(45);
         hpoly.AddIndex(33);
         hpoly.AddIndex(50);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(50);
         hpoly.AddIndex(44);
         hpoly.AddIndex(40);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(40);
         hpoly.AddIndex(44);
         hpoly.AddIndex(14);
         hpoly.AddIndex(55);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(44);
         hpoly.AddIndex(50);
         hpoly.AddIndex(33);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(55);
         hpoly.AddIndex(14);
         hpoly.AddIndex(33);
         hpoly.AddIndex(45);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(10);
         hpoly.AddIndex(19);
         hpoly.AddIndex(18);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(18);
         hpoly.AddIndex(11);
         hpoly.AddIndex(22);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(22);
         hpoly.AddIndex(23);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(10);
         hpoly.AddIndex(23);
         hpoly.AddIndex(5);
         hpoly.AddIndex(19);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(23);
         hpoly.AddIndex(22);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(19);
         hpoly.AddIndex(5);
         hpoly.AddIndex(11);
         hpoly.AddIndex(18);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(39);
         hpoly.AddIndex(43);
         hpoly.AddIndex(49);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(49);
         hpoly.AddIndex(34);
         hpoly.AddIndex(46);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(46);
         hpoly.AddIndex(56);
         hpoly.AddIndex(39);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(39);
         hpoly.AddIndex(56);
         hpoly.AddIndex(13);
         hpoly.AddIndex(43);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(56);
         hpoly.AddIndex(46);
         hpoly.AddIndex(34);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(43);
         hpoly.AddIndex(13);
         hpoly.AddIndex(34);
         hpoly.AddIndex(49);
         Polygons.Add(hpoly);


       }

       

    }
}
