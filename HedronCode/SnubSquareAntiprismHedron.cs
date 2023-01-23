 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class SnubSquareAntiprismHedron : HedronBase
    {
       public SnubSquareAntiprismHedron()
       {
                   Name = "SnubSquareAntiprism";

         Vertex.Add(0, new HVector(-1.09317473726932, 0.431564979871093, -0.353605535467089));
         Vertex.Add(1, new HVector(-1.00569851831064, -0.562189241148482, -0.422882915441872));
         Vertex.Add(2, new HVector(-0.859632785110133, -0.107436601939283, 0.45567528809614));
         Vertex.Add(3, new HVector(-0.719876874783049, 0.882748335041893, 0.456999565652224));
         Vertex.Add(4, new HVector(-0.363678250343604, 0.0313033242895731, -0.90824520310839));
         Vertex.Add(5, new HVector(-0.309622137606263, -0.905008837569266, 0.207952021961193));
         Vertex.Add(6, new HVector(-0.197089128480653, 0.873473448456289, -0.395412339069872));
         Vertex.Add(7, new HVector(-0.149505251973747, -0.936854697955166, -0.778631745708178));
         Vertex.Add(8, new HVector(-0.0740301260211397, 0.286000192302476, 0.933206387574562));
         Vertex.Add(9, new HVector(0.254707793084953, 1.10659540685702, 0.465710275768041));
         Vertex.Add(10, new HVector(0.475980521482731, -0.511572043327506, 0.685483121439615));
         Vertex.Add(11, new HVector(0.580742480607223, -0.254464735446295, -0.745745667770276));
         Vertex.Add(12, new HVector(0.614673621317622, -1.05248908827741, -0.144078359251022));
         Vertex.Add(13, new HVector(0.747331602470174, 0.587705388720422, -0.232912803731759));
         Vertex.Add(14, new HVector(0.900495264845216, 0.392448487912967, 0.735804121843074));
         Vertex.Add(15, new HVector(1.19837727838052, -0.261824270969244, 0.0406840655269513));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(12);
         hpoly.AddIndex(5);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(10);
         hpoly.AddIndex(15);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(10);
         hpoly.AddIndex(14);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(10);
         hpoly.AddIndex(7);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(16);
         hpoly.AddIndex(13);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(16);
         hpoly.AddIndex(12);
         hpoly.AddIndex(14);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(16);
         hpoly.AddIndex(14);
         hpoly.AddIndex(15);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(8);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(5);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(12);
         hpoly.AddIndex(13);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(1);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(7);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(5);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(6);
         hpoly.AddIndex(11);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(4);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(3);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(9);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(2);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(6);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(3);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(13);
         hpoly.AddIndex(16);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(11);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(6);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(15);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(15);
         hpoly.AddIndex(9);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(15);
         hpoly.AddIndex(11);
         hpoly.AddIndex(16);
         Polygons.Add(hpoly);


       }

       

    }
}
