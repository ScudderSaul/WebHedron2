using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using HedronClasses;
using Microsoft.Ajax.Utilities;
using WebHedron2.Tools;


namespace WebHedron2.Controllers
{
    public class HomeController : Controller
    {
        Random rnd = new Random();
        Mv spinaround;
        private static  HedronClasses.HedronList _hedronList;
        private static double spincnt = 0.0;

        public HomeController()
        {
            MakeSpinAround();
            _hedronList = new HedronList();
        }

        private void GenChoiceList(int choice = -1)
        {  
            List<string> il = new List<string>();
            for (int ii = 0; ii < _hedronList.FullList.Count; ii++)
            {
               // il.Add(ii);
                il.Add(_hedronList.FullList[ii].Name);
            }
            List<double> dl = new List<double>();
            for (double dr = 0.5; dr < 1.05; dr += 0.05)
            {
                dl.Add(dr);
            }

            if(choice != -1)
            {
                SelectList sl = new SelectList(il, il[choice]);
                ViewData["SelectHedron"] = sl;
            }
            else
            {
                ViewData["SelectHedron"] = new SelectList(il);
            }
            
            
            ViewData["Opacity"] = new SelectList(dl, dl[8]);
            ViewData["ang"] = .1;
            ViewData["itspins"] = false;
        }

        public ActionResult Index()
        {
            GenChoiceList(-1);

            return View();
        }

        private void MakeSpinAround()
        {
            spinaround = new Mv();
            spinaround[Mv.MVI] = (rnd.NextDouble() * 2.0) - 1.0;
            spinaround[Mv.MVJ] = (rnd.NextDouble() * 2.0) - 1.0;
            spinaround[Mv.MVK] = (rnd.NextDouble() * 2.0) - 1.0;

            ViewData["MVI"] = spinaround[Mv.MVI];
            ViewData["MVJ"] = spinaround[Mv.MVJ];
            ViewData["MVK"] = spinaround[Mv.MVK];

            ViewData["ang"] = .1;
         // ViewData["holdcnt"] = 1.0; // (double)rnd.Next(50);
            ViewData["toggle"] = 1;
        }

        // http://hedron.azurewebsites.net/Home/ShowHedron

        public ActionResult ShowHedron()
        {
            int cn = _hedronList.FullList.Count;

            int hedchosen = rnd.Next(cn);
            GenChoiceList(hedchosen);

            MakeSpinAround();
            HedronBase hedron = _hedronList.FullList[hedchosen];
         
            int hedtype;

            double cnt = spincnt;
            double ang = (double) ViewData["ang"];

            spinaround = new Mv();
            spinaround[Mv.MVI] = (double)ViewData["MVI"];
            spinaround[Mv.MVJ] = (double)ViewData["MVJ"];
            spinaround[Mv.MVK] = (double)ViewData["MVK"];
      
            ViewBag.HedronName = hedron.Name;
            ViewBag.HedronCode = hedchosen;
            double ww0 = 450.0;
            double ww = 450.0 / (hedron.MaxRadius * 2.0);

            Mv spin = new Mv(ang * cnt, spinaround[Mv.MVI], spinaround[Mv.MVJ], spinaround[Mv.MVK]);
            
            HedronModelText hedronModel = new HedronModelText();

       //     List<HedronVertex> hvl = hedron.Vertexs;

            foreach (HPolygon hfl in hedron.Polygons)
            {
               // List<Int32> verts = hfl.PolyIndexs.Values;
                PolygonText polygonText = new PolygonText();

                double avz = 0.0;
                polygonText.AllPoints = string.Empty;

                double xx = 0.0;
                double yy = 0.0;
                double zz = 0.0;

                foreach (int kk in hfl.PolyIndexs.Values)
                {
                    Mv va = new Mv();
                    va[Mv.MVI] = hedron.Vertex[kk - 1].X;
                    va[Mv.MVJ] = hedron.Vertex[kk - 1].Y;
                    va[Mv.MVK] = hedron.Vertex[kk - 1].Z;
                    Mv vua = spin.Spin(va);

                    PointText pp = new PointText();

                    xx += (vua[Mv.MVI] * ww) + ww0;
                    yy += (vua[Mv.MVJ] * ww) + ww0;
                    zz += (vua[Mv.MVK] * ww) + ww0;

                    pp.X = ((vua[Mv.MVI] * ww) + ww0).ToString("F4");
                    pp.Y = ((vua[Mv.MVJ] * ww) + ww0).ToString("F4");
                    avz += (vua[Mv.MVK] * ww) + ww0;

                    polygonText.Points.Add(pp);
                    polygonText.AllPoints += string.Format("{0},{1} ", pp.X, pp.Y);
                }

                xx = xx/((double)hfl.PolyIndexs.Values.Count);
                yy = yy / ((double)hfl.PolyIndexs.Values.Count);
                zz = zz / ((double)hfl.PolyIndexs.Values.Count);
                double vxx = 800.0 - xx;
                double vyy = 800.0 - yy;
                double vzz = -800.0 - zz;

                double cdist = Math.Sqrt(vxx*vxx + vyy*vyy + vzz*vzz)/800.0;

                double exx = 0 - xx;
                double eyy = 0 - yy;
                double ezz = 800.0 - zz;


                double edist = Math.Sqrt(exx * exx + eyy * eyy + ezz * ezz);


           //     double facez = avz / verts.Count;
          //      int zIndex = -(int)((facez / ww) * (int.MaxValue / 200.0));
           //    ViewBag.Zindex = zIndex;
                int st = 2;
                polygonText.StrokeThick = st.ToString();
                polygonText.StrokeColor = "black";

                polygonText.Fill = LocalPallete.Css3ColorLookup(hfl.PolyIndexs.Values.Count, cdist, 0.8);

                if (hedronModel.PolygonText.ContainsKey(edist))
                {
                    edist += (rnd.NextDouble() / 20.0);
                }

                hedronModel.PolygonText.Add(edist, polygonText);
            }

            return (View(hedronModel));
        }

        [HttpPost]
        public ActionResult ShowHedron(string selecthedron, double opacity, 
            int? Valuex, int? Valuey, int? Valuez, bool spinner = false, int toggle = 0)
        {
            int cn = _hedronList.FullList.Count;

            if (Valuex != null && Valuey != null && Valuez != null)
            {
                ViewData["MVI"] = ((double) Valuex)/100.0;
                ViewData["MVJ"] = ((double) Valuey)/100.0;
                ViewData["MVK"] = ((double) Valuez)/100.0;
            }
            else
            {
                MakeSpinAround();
            }

            GenChoiceList(-1);

            HedronBase hedron = null;
            for (int ii = 0; ii < _hedronList.FullList.Count; ii++)
            {
                if (selecthedron == _hedronList.FullList[ii].Name)
                {
                    hedron = _hedronList.FullList[ii];
                    break;
                }
            }
       

            int hedtype;
            ViewData["itspins"] = spinner;
            ViewData["toggle"] = toggle;
          
            double cnt = spincnt;
            spincnt += 1.0;
            
            double ang = (double)ViewData["ang"];

            spinaround = new Mv();
            spinaround[Mv.MVI] = (double)ViewData["MVI"];
            spinaround[Mv.MVJ] = (double)ViewData["MVJ"];
            spinaround[Mv.MVK] = (double)ViewData["MVK"];


            ViewBag.HedronName = hedron.Name;
         
            double ww0 = 450.0;
            double ww = 450.0 / (hedron.MaxRadius * 2.0);

            Mv spin = new Mv(ang * cnt, spinaround[Mv.MVI], spinaround[Mv.MVJ], spinaround[Mv.MVK]);

            HedronModelText hedronModel = new HedronModelText();

            foreach (HPolygon hfl in hedron.Polygons)
            {
                // List<Int32> verts = hfl.PolyIndexs.Values;
                PolygonText polygonText = new PolygonText();

                double avz = 0.0;
                polygonText.AllPoints = string.Empty;

                double xx = 0.0;
                double yy = 0.0;
                double zz = 0.0;

                foreach (int kk in hfl.PolyIndexs.Values)
                {
                    Mv va = new Mv();
                    va[Mv.MVI] = hedron.Vertex[kk - 1].X;
                    va[Mv.MVJ] = hedron.Vertex[kk - 1].Y;
                    va[Mv.MVK] = hedron.Vertex[kk - 1].Z;
                    Mv vua = spin.Spin(va);

                    PointText pp = new PointText();

                    xx += (vua[Mv.MVI] * ww) + ww;
                    yy += (vua[Mv.MVJ] * ww) + ww;
                    zz += (vua[Mv.MVK] * ww) + ww;

                    pp.X = ((vua[Mv.MVI] * ww) + ww0).ToString("F4");
                    pp.Y = ((vua[Mv.MVJ] * ww) + ww0).ToString("F4");
                    avz += (vua[Mv.MVK] * ww) + ww0;

                    polygonText.Points.Add(pp);
                    polygonText.AllPoints += string.Format("{0},{1} ", pp.X, pp.Y);
                }

                xx = xx / ((double)hfl.PolyIndexs.Values.Count);
                yy = yy / ((double)hfl.PolyIndexs.Values.Count);
                zz = zz / ((double)hfl.PolyIndexs.Values.Count);
                double vxx = 800.0 - xx;
                double vyy = 800.0 - yy;
                double vzz = -800.0 - zz;

                double cdist = Math.Sqrt(vxx * vxx + vyy * vyy + vzz * vzz) / 800.0;

                double exx = 0 - xx;
                double eyy = 0 - yy;
                double ezz = 800.0 - zz;

                double edist = Math.Sqrt(exx * exx + eyy * eyy + ezz * ezz);

                //     double facez = avz / verts.Count;
                //      int zIndex = -(int)((facez / ww) * (int.MaxValue / 200.0));
                //    ViewBag.Zindex = zIndex;
                int st = 2;
                polygonText.StrokeThick = st.ToString();
                polygonText.StrokeColor = "black";

                polygonText.Fill = LocalPallete.Css3ColorLookup(hfl.PolyIndexs.Values.Count, cdist, opacity);

                if (hedronModel.PolygonText.ContainsKey(edist))
                {
                    edist += (rnd.NextDouble() / 20.0);
                }

                hedronModel.PolygonText.Add(edist, polygonText);
            }

            return (View(hedronModel));

           
        }

        [HttpGet]
        public PartialViewResult _CreateHedron()
        {

            int cn = _hedronList.FullList.Count;
            int hedchosen = rnd.Next(cn);
            GenChoiceList(hedchosen);
            HedronBase hedron = _hedronList.FullList[hedchosen];


            MakeSpinAround();

            ViewBag.HedronName = hedron.Name;
            ViewBag.HedronCode = hedchosen;

            double ww0 = 450.0;
            double ww = 450.0 / (hedron.MaxRadius * 2.0);

            double cnt = spincnt;
            double ang = (double)ViewData["ang"];
            Mv spin = new Mv(ang * cnt, spinaround[Mv.MVI], spinaround[Mv.MVJ], spinaround[Mv.MVK]);

            HedronModelText hedronModel = new HedronModelText();
         

            foreach (HPolygon hfl in hedron.Polygons)
            {
                // List<Int32> verts = hfl.PolyIndexs.Values;
                PolygonText polygonText = new PolygonText();

                double avz = 0.0;
                polygonText.AllPoints = string.Empty;

                double xx = 0.0;
                double yy = 0.0;
                double zz = 0.0;

                foreach (int kk in hfl.PolyIndexs.Values)
                {
                    Mv va = new Mv();
                    va[Mv.MVI] = hedron.Vertex[kk - 1].X;
                    va[Mv.MVJ] = hedron.Vertex[kk - 1].Y;
                    va[Mv.MVK] = hedron.Vertex[kk - 1].Z;
                    Mv vua = spin.Spin(va);

                    PointText pp = new PointText();

                    xx += (vua[Mv.MVI]*ww) + ww0;
                    yy += (vua[Mv.MVJ]*ww) + ww0;
                    zz += (vua[Mv.MVK]*ww) + ww0;

                    pp.X = ((vua[Mv.MVI]*ww) + ww0).ToString("F4");
                    pp.Y = ((vua[Mv.MVJ]*ww) + ww0).ToString("F4");
                    avz += (vua[Mv.MVK]*ww) + ww0;

                    polygonText.Points.Add(pp);
                    polygonText.AllPoints += string.Format("{0},{1} ", pp.X, pp.Y);
                }
                xx = xx/((double) hfl.PolyIndexs.Values.Count);
                yy = yy/((double) hfl.PolyIndexs.Values.Count);
                zz = zz/((double) hfl.PolyIndexs.Values.Count);
                double vxx = 800.0 - xx;
                double vyy = 800.0 - yy;
                double vzz = -800.0 - zz;

                double cdist = Math.Sqrt(vxx*vxx + vyy*vyy + vzz*vzz)/800.0;

                double exx = 0 - xx;
                double eyy = 0 - yy;
                double ezz = 800.0 - zz;


                double edist = Math.Sqrt(exx*exx + eyy*eyy + ezz*ezz);


                //     double facez = avz / verts.Count;
                //      int zIndex = -(int)((facez / ww) * (int.MaxValue / 200.0));
                //    ViewBag.Zindex = zIndex;
                int st = 2;
                polygonText.StrokeThick = st.ToString();
                polygonText.StrokeColor = "black";

                polygonText.Fill = LocalPallete.Css3ColorLookup(hfl.PolyIndexs.Values.Count, cdist, 0.8);

                if (hedronModel.PolygonText.ContainsKey(edist))
                {
                    edist += (rnd.NextDouble()/20.0);
                }

                hedronModel.PolygonText.Add(edist, polygonText);

                ViewData["instancemodel"] = hedronModel;
            }
            return PartialView(hedronModel);
        }


       public  ActionResult ShowHedrons()
        {
            return (View());
        }


        public ActionResult About()
        {
            //   ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            // ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}