 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class HebesphenomegacoronaHedron : HedronBase
    {
       public HebesphenomegacoronaHedron()
       {
                   Name = "Hebesphenomegacorona";

         Vertex.Add(0, new HVector(-0.871505812169143, 0.140534498263872, -0.0100135010142378));
         Vertex.Add(1, new HVector(-0.734052444698458, -0.844455299072871, -0.114408798378845));
         Vertex.Add(2, new HVector(-0.661762502745297, -0.422531452655503, 0.789335255881815));
         Vertex.Add(3, new HVector(-0.604132534339433, -0.235754095842338, -0.897097727143961));
         Vertex.Add(4, new HVector(-0.468061202583064, 0.558417070950564, 0.803993011515417));
         Vertex.Add(5, new HVector(-0.181065254246463, 0.857521029025558, -0.106045530471817));
         Vertex.Add(6, new HVector(0.0863080235832462, 0.481232434919349, -0.993129756601539));
         Vertex.Add(7, new HVector(0.110015439817932, -0.890189815917122, -0.648689677159408));
         Vertex.Add(8, new HVector(0.152356596264704, -0.797719416565912, 0.346125105458231));
         Vertex.Add(9, new HVector(0.246081935742992, -0.0960142944774633, 1.05239880567973));
         Vertex.Add(10, new HVector(0.49218253717003, 0.775780322869132, 0.628835292787257));
         Vertex.Add(11, new HVector(0.786706053405006, 0.734773132933092, -0.325928129350839));
         Vertex.Add(12, new HVector(0.800455997740612, -0.173203285155437, -0.744721706616986));
         Vertex.Add(13, new HVector(0.842797154187383, -0.0807328858042264, 0.250093076000651));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(8);
         hpoly.AddIndex(13);
         hpoly.AddIndex(14);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(10);
         hpoly.AddIndex(9);
         hpoly.AddIndex(14);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(9);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(8);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(12);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(13);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(9);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(10);
         hpoly.AddIndex(14);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(7);
         hpoly.AddIndex(13);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(7);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(8);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(7);
         hpoly.AddIndex(4);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(6);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(6);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(7);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(2);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(4);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(5);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(6);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(3);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(1);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);


       }

       

    }
}
