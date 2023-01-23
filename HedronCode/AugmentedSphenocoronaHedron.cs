 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class AugmentedSphenocoronaHedron : HedronBase
    {
       public AugmentedSphenocoronaHedron()
       {
                   Name = "AugmentedSphenocorona";

         Vertex.Add(0, new HVector(-0.80975821355475, -0.747109130442617, 0.403072469274973));
         Vertex.Add(1, new HVector(-0.74188821355475, 0.0483708695573836, -0.199087530725027));
         Vertex.Add(2, new HVector(-0.50559821355475, 0.132450869557383, 0.768952469274974));
         Vertex.Add(3, new HVector(-0.22206821355475, 0.840100869557384, 0.121772469274973));
         Vertex.Add(4, new HVector(-0.20559821355475, 0.590100869557383, -0.846327530725027));
         Vertex.Add(5, new HVector(-0.0921482135547494, -0.706059130442617, -0.292167530725027));
         Vertex.Add(6, new HVector(0.14414178644525, -0.621989130442617, 0.675872469274974));
         Vertex.Add(7, new HVector(0.444141786445251, -0.164339130442616, -0.939407530725026));
         Vertex.Add(8, new HVector(0.466241786445251, 0.323660869557384, 0.631202469274974));
         Vertex.Add(9, new HVector(0.64214578644525, 0.592010869557383, -0.315927530725027));
         Vertex.Add(10, new HVector(0.80377578644525, -0.351049130442617, -0.0251775307250264));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(1);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(2);
         hpoly.AddIndex(5);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(10);
         hpoly.AddIndex(4);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(7);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(4);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(3);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(6);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(6);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(2);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(4);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(10);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(5);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(10);
         hpoly.AddIndex(5);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(10);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(1);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(3);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(3);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);


       }

       

    }
}
