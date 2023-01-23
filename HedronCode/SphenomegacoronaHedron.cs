 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class SphenomegacoronaHedron : HedronBase
    {
       public SphenomegacoronaHedron()
       {
                   Name = "Sphenomegacorona";

         Vertex.Add(0, new HVector(-0.707413848678493, -0.299887246801118, -0.15479434163251));
         Vertex.Add(1, new HVector(-0.648092504100264, -0.108705063850282, 0.824965759829574));
         Vertex.Add(2, new HVector(-0.61835996573011, 0.643013506606444, 0.16615359052358));
         Vertex.Add(3, new HVector(-0.61120674885737, -1.0525251057015, 0.496573471565774));
         Vertex.Add(4, new HVector(-0.164694606667498, 0.357204838375813, -0.677944239796359));
         Vertex.Add(5, new HVector(-0.000816218247557355, -0.993805657670411, -0.293347680553015));
         Vertex.Add(6, new HVector(0.166715484324897, 0.467520423049674, 0.760171553745122));
         Vertex.Add(7, new HVector(0.22643953922699, -0.509057645696038, 0.551267134366522));
         Vertex.Add(8, new HVector(0.279677641967616, 1.01458368778071, -0.0693508957516873));
         Vertex.Add(9, new HVector(0.541903023763438, -0.336713572493481, -0.816497578716863));
         Vertex.Add(10, new HVector(0.769158781237986, 0.148034439480891, 0.0281172362026734));
         Vertex.Add(11, new HVector(0.781521476760963, 0.633707154030647, -0.845935827906212));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(6);
         hpoly.AddIndex(10);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(8);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(8);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(6);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(12);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(10);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(8);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(11);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(10);
         hpoly.AddIndex(6);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(5);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(5);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(10);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(4);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(6);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(3);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(5);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(2);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(1);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);


       }

       

    }
}
