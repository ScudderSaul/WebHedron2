 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class DuerersSolidHedron : HedronBase
    {
       public DuerersSolidHedron()
       {
                   Name = "DuerersSolid";

         Vertex.Add(0, new HVector(0, -1.77690141866861, 0.961343241847463));
         Vertex.Add(1, new HVector(0, 1.77690141866861, -0.961343241847463));
         Vertex.Add(2, new HVector(0, -1.09818547139511, 1.6957441289089));
         Vertex.Add(3, new HVector(0, 1.09818547139511, -1.6957441289089));
         Vertex.Add(4, new HVector(-1.53884176858763, -0.888450709334306, -0.961343241847463));
         Vertex.Add(5, new HVector(-1.53884176858763, 0.888450709334306, 0.961343241847463));
         Vertex.Add(6, new HVector(1.53884176858763, -0.888450709334306, -0.961343241847463));
         Vertex.Add(7, new HVector(1.53884176858763, 0.888450709334306, 0.961343241847463));
         Vertex.Add(8, new HVector(-0.951056516295154, -0.549092735697555, -1.6957441289089));
         Vertex.Add(9, new HVector(-0.951056516295154, 0.549092735697555, 1.6957441289089));
         Vertex.Add(10, new HVector(0.951056516295154, -0.549092735697555, -1.6957441289089));
         Vertex.Add(11, new HVector(0.951056516295154, 0.549092735697555, 1.6957441289089));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(7);
         hpoly.AddIndex(8);
         hpoly.AddIndex(12);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(11);
         hpoly.AddIndex(7);
         hpoly.AddIndex(1);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(2);
         hpoly.AddIndex(6);
         hpoly.AddIndex(10);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(9);
         hpoly.AddIndex(5);
         hpoly.AddIndex(6);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(5);
         hpoly.AddIndex(1);
         hpoly.AddIndex(3);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(4);
         hpoly.AddIndex(2);
         hpoly.AddIndex(8);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(9);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(10);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);


       }

       

    }
}
