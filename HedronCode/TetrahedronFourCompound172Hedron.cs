 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class TetrahedronFourCompound172Hedron : HedronBase
    {
       public TetrahedronFourCompound172Hedron()
       {
                   Name = "TetrahedronFourCompound172";

         Vertex.Add(0, new HVector(-0.557677535825205, 0.149429245361342, -0.204124145231932));
         Vertex.Add(1, new HVector(-0.411642742506487, -0.402368927062182, 0.208924625347435));
         Vertex.Add(2, new HVector(-0.37834260167161, -0.149429245361342, -0.457742041319231));
         Vertex.Add(3, new HVector(-0.325369727472313, 0.25293968170084, 0.452941561203728));
         Vertex.Add(4, new HVector(-0.288675134594813, -0.5, -0.204124145231932));
         Vertex.Add(5, new HVector(-0.288675134594813, 0.5, -0.204124145231932));
         Vertex.Add(6, new HVector(-0.142640341276095, 0.557677535825205, 0.208924625347435));
         Vertex.Add(7, new HVector(-0.0563673262419209, -0.408248290463863, 0.452941561203728));
         Vertex.Add(8, new HVector(0, 0, 0.612372435695794));
         Vertex.Add(9, new HVector(0.0597617782845448, 0.402368927062182, -0.457742041319231));
         Vertex.Add(10, new HVector(0.149429245361342, -0.557677535825205, -0.204124145231932));
         Vertex.Add(11, new HVector(0.318580823387066, -0.25293968170084, -0.457742041319231));
         Vertex.Add(12, new HVector(0.381737053714234, 0.155308608763023, 0.452941561203728));
         Vertex.Add(13, new HVector(0.408248290463863, 0.408248290463863, -0.204124145231932));
         Vertex.Add(14, new HVector(0.554283083782581, -0.155308608763023, 0.208924625347435));
         Vertex.Add(15, new HVector(0.577350269189626, 0, -0.204124145231932));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(1);
         hpoly.AddIndex(14);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(11);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(9);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(14);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(7);
         hpoly.AddIndex(16);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(3);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(16);
         hpoly.AddIndex(8);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(16);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(6);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(2);
         hpoly.AddIndex(13);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(13);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(12);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(10);
         hpoly.AddIndex(15);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(10);
         hpoly.AddIndex(5);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(15);
         hpoly.AddIndex(4);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(15);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);


       }

       

    }
}
