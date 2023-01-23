 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class TetrahedronFourCompound171Hedron : HedronBase
    {
       public TetrahedronFourCompound171Hedron()
       {
                   Name = "TetrahedronFourCompound171";

         Vertex.Add(0, new HVector(-0.5, -0.288675134594813, -0.204124145231932));
         Vertex.Add(1, new HVector(-0.403774955135062, 0.45534180126148, 0.0680413817439772));
         Vertex.Add(2, new HVector(-0.359116756396542, 0.288675134594813, -0.403363139047055));
         Vertex.Add(3, new HVector(-0.288675134594813, -0.5, -0.204124145231932));
         Vertex.Add(4, new HVector(-0.288675134594813, 0.5, -0.204124145231932));
         Vertex.Add(5, new HVector(-0.237108288468396, -0.166666666666667, 0.539445902535009));
         Vertex.Add(6, new HVector(-0.192450089729875, -0.577350269189626, 0.0680413817439772));
         Vertex.Add(7, new HVector(-0.070441621801729, -0.45534180126148, -0.403363139047055));
         Vertex.Add(8, new HVector(-0.0257834230632086, 0.288675134594813, 0.539445902535009));
         Vertex.Add(9, new HVector(0, 0, 0.612372435695794));
         Vertex.Add(10, new HVector(0, 0.577350269189626, -0.204124145231932));
         Vertex.Add(11, new HVector(0.262891711531604, -0.122008467928146, 0.539445902535009));
         Vertex.Add(12, new HVector(0.429558378198271, 0.166666666666667, -0.403363139047055));
         Vertex.Add(13, new HVector(0.5, -0.288675134594813, -0.204124145231932));
         Vertex.Add(14, new HVector(0.577350269189626, 0, -0.204124145231932));
         Vertex.Add(15, new HVector(0.596225044864938, 0.122008467928146, 0.0680413817439772));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(1);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(14);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(11);
         hpoly.AddIndex(10);
         hpoly.AddIndex(14);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(10);
         hpoly.AddIndex(11);
         hpoly.AddIndex(1);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(9);
         hpoly.AddIndex(15);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(3);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(15);
         hpoly.AddIndex(7);
         hpoly.AddIndex(3);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(7);
         hpoly.AddIndex(15);
         hpoly.AddIndex(9);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(5);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(5);
         hpoly.AddIndex(6);
         hpoly.AddIndex(16);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(8);
         hpoly.AddIndex(16);
         hpoly.AddIndex(6);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(16);
         hpoly.AddIndex(8);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(4);
         hpoly.AddIndex(13);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(13);
         hpoly.AddIndex(4);
         hpoly.AddIndex(2);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(12);
         hpoly.AddIndex(2);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(12);
         hpoly.AddIndex(13);
         Polygons.Add(hpoly);


       }

       

    }
}
