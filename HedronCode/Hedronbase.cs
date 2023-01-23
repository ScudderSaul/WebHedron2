using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{


    public class HedronBase
    {
        private Dictionary<int, HVector> _vertex;
        private List<HPolygon> _polygons;
        private double _maxRadius;

        public HedronBase()
        {
            _vertex = new Dictionary<int, HVector>();
            _polygons = new List<HPolygon>();
        }

        public Dictionary<int, HVector> Vertex
        {
            get { return _vertex; }
            set { _vertex = value; }
        }

        public List<HPolygon> Polygons
        {
            get { return _polygons; }
            set { _polygons = value; }
        }

        public string Name { get; set; }

        public double MaxRadius
        {
            get
            {
                if (_maxRadius == 0.0)
                {
                    FindMaxRadius();
                }

                return _maxRadius;
            }
            set
            {
                _maxRadius = value;
            }
        }

        public double FindMaxRadius()
        {
            if (Vertex == null)
            {
                return (0.0);
            }

            foreach (HVector vc in _vertex.Values)
            {
                double dd = Math.Sqrt(vc.X * vc.X + vc.Y * vc.Y + vc.Z * vc.Z);
                if (dd > _maxRadius)
                {
                    _maxRadius = dd;
                }
            }
            return (_maxRadius);
        }


    }
}


