using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    public class HVector
    {
        public HVector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public HVector()
        {

        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    public class HPolygon
    {
        private Dictionary<int, int> _polyIndexs;
        private int _index;

        public HPolygon()
        {
            _index = 0;
            _polyIndexs = new Dictionary<int, int>();
        }

        public int Index
        {
            get { return _index; }

        }

        public Dictionary<int, int> PolyIndexs
        {
            get { return _polyIndexs; }
        }

        public void AddIndex(int nn)
        {
            PolyIndexs.Add(Index, nn);
            _index++;
        }
    }
}
