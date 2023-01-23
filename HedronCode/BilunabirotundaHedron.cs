 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class BilunabirotundaHedron : HedronBase
    {
       public BilunabirotundaHedron()
       {
                   Name = "Bilunabirotunda";

         Vertex.Add(0, new HVector(-1.06895328371448, -0.0819798983889878, 0.0715677667265998));
         Vertex.Add(1, new HVector(-1.02037614864754, 0.821387248939251, 0.497668717224061));
         Vertex.Add(2, new HVector(-0.554083485896695, 0.0438357228392169, 0.919550080990949));
         Vertex.Add(3, new HVector(-0.550126784331064, -0.915153228100033, -0.119826576135318));
         Vertex.Add(4, new HVector(-0.416538777402747, -0.101788774911802, -0.686033282038494));
         Vertex.Add(5, new HVector(-0.33793768322563, 1.35989298775656, 0.00341239690855697));
         Vertex.Add(6, new HVector(-0.035254832189356, -0.789335906926284, 0.728154177859092));
         Vertex.Add(7, new HVector(0.0352550645800756, 0.789337155338695, -0.728156612193921));
         Vertex.Add(8, new HVector(0.33793377783694, -1.35989212880376, -0.00340905989137731));
         Vertex.Add(9, new HVector(0.416539776379359, 0.101789991954662, 0.686033062285479));
         Vertex.Add(10, new HVector(0.55012588935291, 0.915156492941764, 0.119827779220723));
         Vertex.Add(11, new HVector(0.55408453116418, -0.043839746893883, -0.919552103755707));
         Vertex.Add(12, new HVector(1.02037482123179, -0.821391379491601, -0.497667256868211));
         Vertex.Add(13, new HVector(1.06895535593701, 0.0819795907091864, -0.0715677123410622));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(12);
         hpoly.AddIndex(8);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(14);
         hpoly.AddIndex(13);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(12);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(8);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(11);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(14);
         hpoly.AddIndex(10);
         hpoly.AddIndex(7);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(13);
         hpoly.AddIndex(9);
         hpoly.AddIndex(4);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(8);
         hpoly.AddIndex(5);
         hpoly.AddIndex(1);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(6);
         hpoly.AddIndex(2);
         hpoly.AddIndex(3);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(9);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(4);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(2);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(10);
         hpoly.AddIndex(3);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(3);
         hpoly.AddIndex(1);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);


       }

       

    }
}
