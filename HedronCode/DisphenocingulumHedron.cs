 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class DisphenocingulumHedron : HedronBase
    {
       public DisphenocingulumHedron()
       {
                   Name = "Disphenocingulum";

         Vertex.Add(0, new HVector(-1.17114430798631, 0.293688010117329, 0.109311620942383));
         Vertex.Add(1, new HVector(-0.838770109006246, -0.457649278990017, 0.679416584829081));
         Vertex.Add(2, new HVector(-0.814439295237653, -0.537542457316097, -0.317088946470923));
         Vertex.Add(3, new HVector(-0.666584701742075, 0.849234121460219, -0.551587858493375));
         Vertex.Add(4, new HVector(-0.460440194989972, 0.461075430935963, 0.792598614175662));
         Vertex.Add(5, new HVector(-0.309879688993417, 0.0180036540267924, -0.977988425906681));
         Vertex.Add(6, new HVector(-0.117266802395478, -0.991154239777274, 0.238053327714762));
         Vertex.Add(7, new HVector(0.0104824537353455, -0.901366982255388, -0.749679195243698));
         Vertex.Add(8, new HVector(0.0441194112542626, 1.01662154227885, 0.131699134739904));
         Vertex.Add(9, new HVector(0.113461327898817, -0.340276891038159, 0.961324741469029));
         Vertex.Add(10, new HVector(0.297984598887359, 0.793976354087126, -0.809565848692642));
         Vertex.Add(11, new HVector(0.530305255838696, 0.565039657247773, 0.879827212050437));
         Vertex.Add(12, new HVector(0.656860515235515, -0.1388023951752, -0.775935857350927));
         Vertex.Add(13, new HVector(0.803498927576702, -0.896900744199463, -0.14049521817658));
         Vertex.Add(14, new HVector(0.887588020481509, 0.512075342293933, -0.0526645940229777));
         Vertex.Add(15, new HVector(1.03422558783194, -0.246022529044432, 0.582777038504172));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(7);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(10);
         hpoly.AddIndex(7);
         hpoly.AddIndex(14);
         hpoly.AddIndex(16);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(10);
         hpoly.AddIndex(16);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(14);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(16);
         hpoly.AddIndex(14);
         hpoly.AddIndex(13);
         hpoly.AddIndex(15);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(16);
         hpoly.AddIndex(15);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(11);
         hpoly.AddIndex(15);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(8);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(6);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(6);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(3);
         hpoly.AddIndex(1);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(7);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(8);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(7);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(2);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(1);
         hpoly.AddIndex(5);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(4);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(9);
         hpoly.AddIndex(15);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(12);
         hpoly.AddIndex(15);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(5);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(5);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(10);
         hpoly.AddIndex(2);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(2);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(2);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);


       }

       

    }
}
