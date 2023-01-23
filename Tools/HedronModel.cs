using System.Collections.Generic;

namespace WebHedron2.Tools
{
    public class HedronModelText
    {
        private SortedList<double, PolygonText> _polygonText = new SortedList<double, PolygonText>();
 
        public IList<PolygonText> PolygonTextList
        {
            get { return (PolygonText.Values); }
        }

        public SortedList<double, PolygonText> PolygonText
        {
            get { return _polygonText; }
            set { _polygonText = value; }
        }
    }

    public class PolygonText
    {
        private List<PointText> _points = new List<PointText>();

        public List<PointText> Points
        {
            get { return _points; }
            set { _points = value; }
        }

        public string Fill { get; set; }
        public string StrokeColor { get; set; }
        public string StrokeThick { get; set; }
        public string AllPoints { get; set; } 
    }

    public class PointText
    {
        public string X { get; set; }
        public string Y { get; set; }
 
    }
}