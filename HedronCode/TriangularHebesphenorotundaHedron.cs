 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class TriangularHebesphenorotundaHedron : HedronBase
    {
       public TriangularHebesphenorotundaHedron()
       {
                   Name = "TriangularHebesphenorotunda";

         Vertex.Add(0, new HVector(-0.960132915439875, 0.715228827607169, -0.0389403404782184));
         Vertex.Add(1, new HVector(-0.818728299285049, 0.161305176726768, -0.85941174371262));
         Vertex.Add(2, new HVector(-0.761114436024437, 0.332433689594001, 0.863201293171764));
         Vertex.Add(3, new HVector(-0.547942421155495, 1.12392492796643, -0.853229290404914));
         Vertex.Add(4, new HVector(-0.47830520371479, -0.775413612166797, -0.777741513297054));
         Vertex.Add(5, new HVector(-0.420691340454176, -0.604285099299567, 0.944871523587333));
         Vertex.Add(6, new HVector(-0.279286724299352, -1.15820875017997, 0.124400120352919));
         Vertex.Add(7, new HVector(-0.181569190501294, 1.3360624277576, 0.0527339041791358));
         Vertex.Add(8, new HVector(-0.0269051487262014, 0.121753997933153, 1.50860875359247));
         Vertex.Add(9, new HVector(0.0174493405995583, 0.953266774132298, 0.954875825916969));
         Vertex.Add(10, new HVector(0.0472285345873375, 0.439793757399038, -1.27481800917725));
         Vertex.Add(11, new HVector(0.343297034139564, -1.32843730609312, -0.639413798399411));
         Vertex.Add(12, new HVector(0.387651912799042, -0.496925454469065, -1.19314808327477));
         Vertex.Add(13, new HVector(0.568266260917956, -0.562377720801387, 1.08702156514613));
         Vertex.Add(14, new HVector(0.64003380133315, 0.783039175487508, 0.191062039329932));
         Vertex.Add(15, new HVector(0.709670704151374, -1.11630142339366, 0.266549597158736));
         Vertex.Add(16, new HVector(0.781438678155783, 0.229114255652424, -0.629410794485927));
         Vertex.Add(17, new HVector(0.980456971861652, -0.153681591405035, 0.272732700352056));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(13);
         hpoly.AddIndex(17);
         hpoly.AddIndex(18);
         hpoly.AddIndex(16);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(12);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(7);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(12);
         hpoly.AddIndex(16);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(16);
         hpoly.AddIndex(14);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(16);
         hpoly.AddIndex(18);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(14);
         hpoly.AddIndex(18);
         hpoly.AddIndex(15);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(14);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(6);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(9);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(10);
         hpoly.AddIndex(15);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(10);
         hpoly.AddIndex(8);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(17);
         hpoly.AddIndex(15);
         hpoly.AddIndex(18);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(17);
         hpoly.AddIndex(11);
         hpoly.AddIndex(4);
         hpoly.AddIndex(8);
         hpoly.AddIndex(15);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(1);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(2);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(4);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(5);
         hpoly.AddIndex(2);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(11);
         hpoly.AddIndex(17);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(5);
         hpoly.AddIndex(7);
         hpoly.AddIndex(6);
         hpoly.AddIndex(3);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);


       }

       

    }
}
