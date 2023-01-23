 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class OctahedronTenCompoundHedron : HedronBase
    {
       public OctahedronTenCompoundHedron()
       {
                   Name = "OctahedronTenCompound";

         Vertex.Add(0, new HVector(-0.685016671066239, 0, -0.175362938961825));
         Vertex.Add(1, new HVector(-0.685016671066239, 0, 0.175362938961825));
         Vertex.Add(2, new HVector(-0.608380256645481, -0.200636737729467, -0.299363262270533));
         Vertex.Add(3, new HVector(-0.608380256645481, -0.200636737729467, 0.299363262270533));
         Vertex.Add(4, new HVector(-0.608380256645481, 0.200636737729467, -0.299363262270533));
         Vertex.Add(5, new HVector(-0.608380256645481, 0.200636737729467, 0.299363262270533));
         Vertex.Add(6, new HVector(-0.5, -0.484379933336772, -0.124000323308709));
         Vertex.Add(7, new HVector(-0.5, -0.484379933336772, 0.124000323308709));
         Vertex.Add(8, new HVector(-0.5, 0.484379933336772, -0.124000323308709));
         Vertex.Add(9, new HVector(-0.5, 0.484379933336772, 0.124000323308709));
         Vertex.Add(10, new HVector(-0.484379933336772, -0.124000323308709, -0.5));
         Vertex.Add(11, new HVector(-0.484379933336772, -0.124000323308709, 0.5));
         Vertex.Add(12, new HVector(-0.484379933336772, 0.124000323308709, -0.5));
         Vertex.Add(13, new HVector(-0.484379933336772, 0.124000323308709, 0.5));
         Vertex.Add(14, new HVector(-0.299363262270533, -0.608380256645481, -0.200636737729467));
         Vertex.Add(15, new HVector(-0.299363262270533, -0.608380256645481, 0.200636737729467));
         Vertex.Add(16, new HVector(-0.299363262270533, 0.608380256645481, -0.200636737729467));
         Vertex.Add(17, new HVector(-0.299363262270533, 0.608380256645481, 0.200636737729467));
         Vertex.Add(18, new HVector(-0.200636737729467, -0.299363262270533, -0.608380256645481));
         Vertex.Add(19, new HVector(-0.200636737729467, -0.299363262270533, 0.608380256645481));
         Vertex.Add(20, new HVector(-0.200636737729467, 0.299363262270533, -0.608380256645481));
         Vertex.Add(21, new HVector(-0.200636737729467, 0.299363262270533, 0.608380256645481));
         Vertex.Add(22, new HVector(-0.175362938961825, -0.685016671066239, 0));
         Vertex.Add(23, new HVector(-0.175362938961825, 0.685016671066239, 0));
         Vertex.Add(24, new HVector(-0.124000323308709, -0.5, -0.484379933336772));
         Vertex.Add(25, new HVector(-0.124000323308709, -0.5, 0.484379933336772));
         Vertex.Add(26, new HVector(-0.124000323308709, 0.5, -0.484379933336772));
         Vertex.Add(27, new HVector(-0.124000323308709, 0.5, 0.484379933336772));
         Vertex.Add(28, new HVector(0, -0.175362938961825, -0.685016671066239));
         Vertex.Add(29, new HVector(0, -0.175362938961825, 0.685016671066239));
         Vertex.Add(30, new HVector(0, 0.175362938961825, -0.685016671066239));
         Vertex.Add(31, new HVector(0, 0.175362938961825, 0.685016671066239));
         Vertex.Add(32, new HVector(0.124000323308709, -0.5, -0.484379933336772));
         Vertex.Add(33, new HVector(0.124000323308709, -0.5, 0.484379933336772));
         Vertex.Add(34, new HVector(0.124000323308709, 0.5, -0.484379933336772));
         Vertex.Add(35, new HVector(0.124000323308709, 0.5, 0.484379933336772));
         Vertex.Add(36, new HVector(0.175362938961825, -0.685016671066239, 0));
         Vertex.Add(37, new HVector(0.175362938961825, 0.685016671066239, 0));
         Vertex.Add(38, new HVector(0.200636737729467, -0.299363262270533, -0.608380256645481));
         Vertex.Add(39, new HVector(0.200636737729467, -0.299363262270533, 0.608380256645481));
         Vertex.Add(40, new HVector(0.200636737729467, 0.299363262270533, -0.608380256645481));
         Vertex.Add(41, new HVector(0.200636737729467, 0.299363262270533, 0.608380256645481));
         Vertex.Add(42, new HVector(0.299363262270533, -0.608380256645481, -0.200636737729467));
         Vertex.Add(43, new HVector(0.299363262270533, -0.608380256645481, 0.200636737729467));
         Vertex.Add(44, new HVector(0.299363262270533, 0.608380256645481, -0.200636737729467));
         Vertex.Add(45, new HVector(0.299363262270533, 0.608380256645481, 0.200636737729467));
         Vertex.Add(46, new HVector(0.484379933336772, -0.124000323308709, -0.5));
         Vertex.Add(47, new HVector(0.484379933336772, -0.124000323308709, 0.5));
         Vertex.Add(48, new HVector(0.484379933336772, 0.124000323308709, -0.5));
         Vertex.Add(49, new HVector(0.484379933336772, 0.124000323308709, 0.5));
         Vertex.Add(50, new HVector(0.5, -0.484379933336772, -0.124000323308709));
         Vertex.Add(51, new HVector(0.5, -0.484379933336772, 0.124000323308709));
         Vertex.Add(52, new HVector(0.5, 0.484379933336772, -0.124000323308709));
         Vertex.Add(53, new HVector(0.5, 0.484379933336772, 0.124000323308709));
         Vertex.Add(54, new HVector(0.608380256645481, -0.200636737729467, -0.299363262270533));
         Vertex.Add(55, new HVector(0.608380256645481, -0.200636737729467, 0.299363262270533));
         Vertex.Add(56, new HVector(0.608380256645481, 0.200636737729467, -0.299363262270533));
         Vertex.Add(57, new HVector(0.608380256645481, 0.200636737729467, 0.299363262270533));
         Vertex.Add(58, new HVector(0.685016671066239, 0, -0.175362938961825));
         Vertex.Add(59, new HVector(0.685016671066239, 0, 0.175362938961825));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(39);
         hpoly.AddIndex(16);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(22);
         hpoly.AddIndex(56);
         hpoly.AddIndex(45);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(22);
         hpoly.AddIndex(45);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(16);
         hpoly.AddIndex(39);
         hpoly.AddIndex(56);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(16);
         hpoly.AddIndex(56);
         hpoly.AddIndex(22);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(39);
         hpoly.AddIndex(5);
         hpoly.AddIndex(45);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(22);
         hpoly.AddIndex(5);
         hpoly.AddIndex(16);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(39);
         hpoly.AddIndex(45);
         hpoly.AddIndex(56);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(35);
         hpoly.AddIndex(33);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(28);
         hpoly.AddIndex(26);
         hpoly.AddIndex(60);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(33);
         hpoly.AddIndex(35);
         hpoly.AddIndex(60);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(33);
         hpoly.AddIndex(26);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(28);
         hpoly.AddIndex(35);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(26);
         hpoly.AddIndex(28);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(33);
         hpoly.AddIndex(60);
         hpoly.AddIndex(26);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(28);
         hpoly.AddIndex(60);
         hpoly.AddIndex(35);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(13);
         hpoly.AddIndex(23);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(48);
         hpoly.AddIndex(47);
         hpoly.AddIndex(38);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(23);
         hpoly.AddIndex(47);
         hpoly.AddIndex(48);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(38);
         hpoly.AddIndex(47);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(48);
         hpoly.AddIndex(38);
         hpoly.AddIndex(14);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(14);
         hpoly.AddIndex(38);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(23);
         hpoly.AddIndex(13);
         hpoly.AddIndex(47);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(48);
         hpoly.AddIndex(14);
         hpoly.AddIndex(23);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(24);
         hpoly.AddIndex(11);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(50);
         hpoly.AddIndex(37);
         hpoly.AddIndex(49);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(50);
         hpoly.AddIndex(49);
         hpoly.AddIndex(24);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(49);
         hpoly.AddIndex(37);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(37);
         hpoly.AddIndex(50);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(11);
         hpoly.AddIndex(37);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(24);
         hpoly.AddIndex(49);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(50);
         hpoly.AddIndex(24);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(40);
         hpoly.AddIndex(6);
         hpoly.AddIndex(15);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(55);
         hpoly.AddIndex(21);
         hpoly.AddIndex(46);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(46);
         hpoly.AddIndex(21);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(55);
         hpoly.AddIndex(40);
         hpoly.AddIndex(15);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(15);
         hpoly.AddIndex(21);
         hpoly.AddIndex(55);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(40);
         hpoly.AddIndex(46);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(15);
         hpoly.AddIndex(6);
         hpoly.AddIndex(21);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(55);
         hpoly.AddIndex(46);
         hpoly.AddIndex(40);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(36);
         hpoly.AddIndex(2);
         hpoly.AddIndex(34);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(59);
         hpoly.AddIndex(25);
         hpoly.AddIndex(27);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(59);
         hpoly.AddIndex(36);
         hpoly.AddIndex(34);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(34);
         hpoly.AddIndex(2);
         hpoly.AddIndex(25);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(36);
         hpoly.AddIndex(27);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(27);
         hpoly.AddIndex(25);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(34);
         hpoly.AddIndex(25);
         hpoly.AddIndex(59);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(59);
         hpoly.AddIndex(27);
         hpoly.AddIndex(36);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(51);
         hpoly.AddIndex(30);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(31);
         hpoly.AddIndex(10);
         hpoly.AddIndex(54);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(30);
         hpoly.AddIndex(54);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(31);
         hpoly.AddIndex(51);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(10);
         hpoly.AddIndex(31);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(30);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(31);
         hpoly.AddIndex(54);
         hpoly.AddIndex(51);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(30);
         hpoly.AddIndex(51);
         hpoly.AddIndex(54);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(41);
         hpoly.AddIndex(3);
         hpoly.AddIndex(18);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(58);
         hpoly.AddIndex(20);
         hpoly.AddIndex(43);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(43);
         hpoly.AddIndex(20);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(41);
         hpoly.AddIndex(18);
         hpoly.AddIndex(58);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(58);
         hpoly.AddIndex(18);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(43);
         hpoly.AddIndex(3);
         hpoly.AddIndex(41);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(18);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(41);
         hpoly.AddIndex(58);
         hpoly.AddIndex(43);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(29);
         hpoly.AddIndex(52);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(32);
         hpoly.AddIndex(53);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(53);
         hpoly.AddIndex(29);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(52);
         hpoly.AddIndex(32);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(32);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(29);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(52);
         hpoly.AddIndex(53);
         hpoly.AddIndex(32);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(52);
         hpoly.AddIndex(29);
         hpoly.AddIndex(53);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(17);
         hpoly.AddIndex(4);
         hpoly.AddIndex(42);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(57);
         hpoly.AddIndex(44);
         hpoly.AddIndex(19);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(19);
         hpoly.AddIndex(44);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(17);
         hpoly.AddIndex(42);
         hpoly.AddIndex(57);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(17);
         hpoly.AddIndex(57);
         hpoly.AddIndex(19);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(44);
         hpoly.AddIndex(42);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(19);
         hpoly.AddIndex(4);
         hpoly.AddIndex(17);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(44);
         hpoly.AddIndex(57);
         hpoly.AddIndex(42);
         Polygons.Add(hpoly);


       }

       

    }
}
