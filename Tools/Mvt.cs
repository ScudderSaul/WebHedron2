using System;
using System.Collections.Generic;

namespace WebHedron2.Tools
{

    public class Mv
    {
        List<double> mv;
        //string ls;
        //static double PI = 3.1415926535;
        //static double MSMALL = 0.001;
        //static double MVSMALL = 0.000001;
        static double MLARGE = 9999.9999;
        public static int MVS = 0;
        public static int MVI = 1;
        public static int MVJ = 2;
        public static int MVK = 3;
        public static int MVIJ = 4;
        public static int MVJK = 5;
        public static int MVKI = 6;
        public static int MVP = 7;

        //private static void MNA(double r, double s, double t)
        //{
        //    r = (t * s);
        //}
        //private static void MS(double r, double s, double t)
        //{
        //    r -= (t * s);
        //}
        //private static void MA(double r, double s, double t)
        //{
        //    r += (t * s);
        //}

        private static double MNA(double r, double s, double t)
        {
            double tr = (t * s);
            return (tr);
        }
        private static double MS(double r, double s, double t)
        {
            double tr = r;
            tr -= (t * s);
            return (tr);
        }
        private static double MA(double r, double s, double t)
        {
            double tr = r;
            tr += (t * s);
            return (tr);
        }

        public Mv()
        {
            mv = new List<double>();
            for (int ii = 0; ii < 8; ii++)
            {
                mv.Add(0.0);
            }
        }

        public Mv(double[] mn)
        {
            mv = new List<double>();
            for (int ii = 0; ii < 8; ii++)
            {
                mv.Add(mn[ii]);
            }
        }

        public Mv(Mv mm)
        {

            mv = new List<double>();

            for (int qq = 0; qq < 8; qq++)
            {
                mv.Add(mm.mv[qq]);
            }
        }

        public Mv(double ang, double xx, double yy, double zz)
        {
            double ang2;
            double sang;
            double den;
            Mv q = new Mv();

            mv = new List<double>();
            for (int ii = 0; ii < 8; ii++)
            {
                mv.Add(0.0);
            }

            ang2 = ang / 2.0;
            sang = Math.Sin(ang2);
            den = Math.Sqrt((xx * xx) + (yy * yy) + (zz * zz));

            q.mv[MVIJ] = (xx * sang) / den;
            q.mv[MVJK] = (yy * sang) / den;
            q.mv[MVKI] = (zz * sang) / den;
            q.mv[MVS] = Math.Cos(ang2);


            mv[MVS] = q.mv[MVS];
            mv[MVI] = 0.0;
            mv[MVJ] = 0.0;
            mv[MVK] = 0.0;
            mv[MVIJ] = q.mv[MVIJ];
            mv[MVJK] = q.mv[MVJK];
            mv[MVKI] = q.mv[MVKI];
            mv[MVP] = 0.0;
        }

      public  Mv(double ang, Mv vv)
        {
            double ang2;
            double sang;
            double den;
            Mv q = new Mv();

            mv = new List<double>();
            for (int ii = 0; ii < 8; ii++)
            {
                mv.Add(0.0);
            }

            ang2 = ang / 2.0;
            sang = Math.Sin(ang2);
            den = vv.Mag();

            q.mv[MVIJ] = (vv[MVI] * sang) / den;
            q.mv[MVJK] = (vv[MVJ] * sang) / den;
            q.mv[MVKI] = (vv[MVK] * sang) / den;

            q.mv[0] = Math.Cos(ang2);

            mv[MVS] = q.mv[MVS];
            mv[MVI] = 0.0;
            mv[MVJ] = 0.0;
            mv[MVK] = 0.0;
            mv[MVIJ] = q.mv[MVIJ];
            mv[MVJK] = q.mv[MVJK];
            mv[MVKI] = q.mv[MVKI];
            mv[MVP] = 0.0;
        }


        public Mv Inverse()
        {
            Mv r = new Mv();
            Mv t = new Mv();
            Mv q = new Mv();
            int ii;

            for (ii = 0; ii < 8; ii++)
            {
                r.mv[ii] = mv[ii];
            }

            t = Conj(r);             // t = conj r
            q = (r * t);          // q = r * conj r

            if (q.mv[0] != 0.0)
            {
                for (ii = 0; ii < 8; ii++)
                {
                    r.mv[ii] = t.mv[ii] / q.mv[0];
                }
            }
            else
            {
                for (ii = 0; ii < 8; ii++)
                {
                    r.mv[ii] = MLARGE;
                }
            }
            return (r);
        }


        public Mv Conj(Mv m)            // conj
        {
            double a;
            Mv vv = new Mv();

            for (int ii = 0; ii < 8; ii++)
            {
                if (ii < 4)
                {
                    vv.mv[ii] = m.mv[ii];
                }
                else
                {
                    a = m.mv[ii];
                    vv.mv[ii] = (-a);
                }
            }
            return (vv);
        }

        public double Mag()
        {
            Mv r = new Mv();
            Mv t = new Mv();
            Mv q = new Mv();
            double rt;
            int ii;

            for (ii = 0; ii < 8; ii++)
            {
                r.mv[ii] = mv[ii];
            }

            t = Conj(r);
            q = (r * t);

            if (q.mv[0] != 0.0)
            {
                rt = q.mv[0];
                rt = Math.Sqrt(Math.Abs(rt));
            }
            else
            {
                rt = 0.0;
            }
            return (rt);
        }

        public double MagSq()
        {
            Mv r = new Mv();
            Mv t = new Mv();
            Mv q = new Mv();
            int ii;

            for (ii = 0; ii < 8; ii++)
            {
                r.mv[ii] = mv[ii];
            }

            t = Conj(r);
            q = (r * t);

            return (q.mv[0]);
        }

        public static Mv operator *(double a, Mv b)
        {
            Mv vv = new Mv();

            vv.mv[MVS] = b.mv[MVS] * a;
            vv.mv[MVS] = b.mv[MVI] * a;
            vv.mv[MVS] = b.mv[MVJ] * a;
            vv.mv[MVS] = b.mv[MVK] * a;
            vv.mv[MVS] = b.mv[MVIJ] * a;
            vv.mv[MVS] = b.mv[MVJK] * a;
            vv.mv[MVS] = b.mv[MVKI] * a;
            vv.mv[MVS] = b.mv[MVP] * a;
            return (vv);
        }

        public static Mv operator /(Mv b, double a)
        {
            Mv vv = new Mv();

            vv.mv[MVS] = b.mv[MVS] / a;
            vv.mv[MVS] = b.mv[MVI] / a;
            vv.mv[MVS] = b.mv[MVJ] / a;
            vv.mv[MVS] = b.mv[MVK] / a;
            vv.mv[MVS] = b.mv[MVIJ] / a;
            vv.mv[MVS] = b.mv[MVJK] / a;
            vv.mv[MVS] = b.mv[MVKI] / a;
            vv.mv[MVS] = b.mv[MVP] / a;
            return (vv);
        }

        public Mv UnitMv()
        {
            Mv nv = new Mv();
            Mv qv = new Mv();
            double db;
            double a;
            int ii;

            for (ii = 0; ii < 8; ii++)
            {
                qv.mv[ii] = mv[ii];
            }

            db = qv.Mag();

            if (db != 0.0)
            {
                for (ii = 0; ii < 8; ii++)
                {
                    a = mv[ii];
                    nv.mv[ii] = a / db;
                }
            }
            else
            {
                for (ii = 0; ii < 8; ii++)
                {
                    nv.mv[ii] = MLARGE;
                }
            }
            return (nv);
        }

        public double this[int index]
        {
            get
            {
                return mv[index];
            }

            set
            {
                mv[index] = value;
            }
        }


        public static Mv operator *(Mv a, Mv m)
        {
            Mv nv = new Mv();

            nv.mv[MVS]  = MNA( nv.mv[MVS], a.mv[MVS], m.mv[MVS]);
            nv.mv[MVI]  = MNA( nv.mv[MVI], a.mv[MVI], m.mv[MVS]);
            nv.mv[MVJ]  = MNA( nv.mv[MVJ], a.mv[MVJ], m.mv[MVS]);
            nv.mv[MVK]  = MNA( nv.mv[MVK], a.mv[MVK], m.mv[MVS]);
            nv.mv[MVIJ] = MNA( nv.mv[MVIJ], a.mv[MVIJ], m.mv[MVS]);
            nv.mv[MVJK] = MNA( nv.mv[MVJK], a.mv[MVJK], m.mv[MVS]);
            nv.mv[MVKI] = MNA( nv.mv[MVKI], a.mv[MVKI], m.mv[MVS]);
            nv.mv[MVP]  = MNA( nv.mv[MVP], a.mv[MVP], m.mv[MVS]);

            nv.mv[MVI]  = MA( nv.mv[MVI],  a.mv[MVS], m.mv[MVI]);
            nv.mv[MVS]  = MA( nv.mv[MVS],  a.mv[MVI], m.mv[MVI]);
            nv.mv[MVIJ] = MS( nv.mv[MVIJ], a.mv[MVJ], m.mv[MVI]);
            nv.mv[MVKI] = MA( nv.mv[MVKI], a.mv[MVK], m.mv[MVI]);
            nv.mv[MVJ]  = MS( nv.mv[MVJ],  a.mv[MVIJ], m.mv[MVI]);
            nv.mv[MVP]  = MA( nv.mv[MVP],  a.mv[MVJK], m.mv[MVI]);
            nv.mv[MVK]  = MA( nv.mv[MVK],  a.mv[MVKI], m.mv[MVI]);
            nv.mv[MVJK] = MA( nv.mv[MVJK], a.mv[MVP], m.mv[MVI]);

            nv.mv[MVJ]  =  MA( nv.mv[MVJ],  a.mv[MVS], m.mv[MVJ]);
            nv.mv[MVIJ] =  MA( nv.mv[MVIJ], a.mv[MVI], m.mv[MVJ]);
            nv.mv[MVS]  =  MA( nv.mv[MVS],  a.mv[MVJ], m.mv[MVJ]);
            nv.mv[MVJK] =  MS( nv.mv[MVJK], a.mv[MVK], m.mv[MVJ]);
            nv.mv[MVI]  =  MA( nv.mv[MVI],  a.mv[MVIJ], m.mv[MVJ]);
            nv.mv[MVK]  =  MS( nv.mv[MVK],  a.mv[MVJK], m.mv[MVJ]);
            nv.mv[MVP]  =  MA( nv.mv[MVP],  a.mv[MVKI], m.mv[MVJ]);
            nv.mv[MVKI] =  MA( nv.mv[MVKI], a.mv[MVP], m.mv[MVJ]);

          nv.mv[MVK] =     MA( nv.mv[MVK],  a.mv[MVS], m.mv[MVK]);
          nv.mv[MVKI] =    MS( nv.mv[MVKI], a.mv[MVI], m.mv[MVK]);
          nv.mv[MVJK] =    MA( nv.mv[MVJK], a.mv[MVJ], m.mv[MVK]);
          nv.mv[MVS] =     MA( nv.mv[MVS],  a.mv[MVK], m.mv[MVK]);
          nv.mv[MVP] =     MA( nv.mv[MVP],  a.mv[MVIJ], m.mv[MVK]);
          nv.mv[MVJ] =     MA( nv.mv[MVJ],  a.mv[MVJK], m.mv[MVK]);
          nv.mv[MVI] =     MS( nv.mv[MVI],  a.mv[MVKI], m.mv[MVK]);
          nv.mv[MVIJ] =    MA( nv.mv[MVIJ], a.mv[MVP], m.mv[MVK]);

            nv.mv[MVIJ] =     MA( nv.mv[MVIJ], a.mv[MVS], m.mv[MVIJ]);
            nv.mv[MVJ]  =     MA( nv.mv[MVJ],  a.mv[MVI], m.mv[MVIJ]);
            nv.mv[MVI]  =     MS( nv.mv[MVI],  a.mv[MVJ], m.mv[MVIJ]);
            nv.mv[MVP]  =     MA( nv.mv[MVP],  a.mv[MVK], m.mv[MVIJ]);
            nv.mv[MVS]  =     MS( nv.mv[MVS],  a.mv[MVIJ], m.mv[MVIJ]);
            nv.mv[MVKI] =     MA( nv.mv[MVKI], a.mv[MVJK], m.mv[MVIJ]);
            nv.mv[MVJK] =     MS( nv.mv[MVJK], a.mv[MVKI], m.mv[MVIJ]);
            nv.mv[MVK]  =     MS( nv.mv[MVK], a.mv[MVP], m.mv[MVIJ]);

            nv.mv[MVJK] =    MA( nv.mv[MVJK], a.mv[MVS], m.mv[MVJK]);
            nv.mv[MVP]  =    MA( nv.mv[MVP],  a.mv[MVI], m.mv[MVJK]);
            nv.mv[MVK]  =    MA( nv.mv[MVK],  a.mv[MVJ], m.mv[MVJK]);
            nv.mv[MVJ]  =    MS( nv.mv[MVJ],  a.mv[MVK], m.mv[MVJK]);
            nv.mv[MVKI] =    MS( nv.mv[MVKI], a.mv[MVIJ], m.mv[MVJK]);
            nv.mv[MVS]  =    MS( nv.mv[MVS],  a.mv[MVJK], m.mv[MVJK]);
            nv.mv[MVIJ] =    MA( nv.mv[MVIJ], a.mv[MVKI], m.mv[MVJK]);
            nv.mv[MVI]  =    MS( nv.mv[MVI], a.mv[MVP], m.mv[MVJK]);

           nv.mv[MVKI] =    MA( nv.mv[MVKI], a.mv[MVS], m.mv[MVKI]);
           nv.mv[MVK] =     MS( nv.mv[MVK],  a.mv[MVI], m.mv[MVKI]);
           nv.mv[MVP] =     MA( nv.mv[MVP],  a.mv[MVJ], m.mv[MVKI]);
           nv.mv[MVI] =     MA( nv.mv[MVI],  a.mv[MVK], m.mv[MVKI]);
           nv.mv[MVJK] =    MA( nv.mv[MVJK], a.mv[MVIJ], m.mv[MVKI]);
           nv.mv[MVIJ] =    MS( nv.mv[MVIJ], a.mv[MVJK], m.mv[MVKI]);
           nv.mv[MVS] =     MS( nv.mv[MVS],  a.mv[MVKI], m.mv[MVKI]);
           nv.mv[MVJ] =     MS( nv.mv[MVJ], a.mv[MVP], m.mv[MVKI]);

           nv.mv[MVP]   =   MA( nv.mv[MVP],  a.mv[MVS], m.mv[MVP]);
           nv.mv[MVJK]  =   MA( nv.mv[MVJK], a.mv[MVI], m.mv[MVP]);
           nv.mv[MVKI]  =   MA( nv.mv[MVKI], a.mv[MVJ], m.mv[MVP]);
           nv.mv[MVIJ]  =   MA( nv.mv[MVIJ], a.mv[MVK], m.mv[MVP]);
           nv.mv[MVK]   =   MS( nv.mv[MVK],  a.mv[MVIJ], m.mv[MVP]);
           nv.mv[MVI]   =   MS( nv.mv[MVI],  a.mv[MVJK], m.mv[MVP]);
           nv.mv[MVJ]   =   MS( nv.mv[MVJ],  a.mv[MVKI], m.mv[MVP]);
           nv.mv[MVS]   =   MS(nv.mv[MVS], a.mv[MVP], m.mv[MVP]);
            return (nv);

        }

        public static Mv operator /(Mv a, Mv m)
        {
            Mv nv = new Mv();
            Mv av = new Mv();
            Mv tv = new Mv();
            Mv qv = new Mv();
            int ii;

            for (ii = 0; ii < 8; ii++)
            {
                qv.mv[ii] = a.mv[ii];
                av.mv[ii] = m.mv[ii];
            }

            tv = av.Inverse();
            nv = (qv * tv);
            return (nv);
        }

        public void Clear()
        {
            for (int ii = 0; ii < 8; ii++)
            {
                mv[ii] = 0.0;
            }
        }

        public static Mv operator +(Mv a, Mv m)
        {
            Mv nv = new Mv();

            for (int ii = 0; ii < 8; ii++)
            {
                nv.mv[ii] = a.mv[ii] + m.mv[ii];
            }
            return nv;
        }

        public static Mv operator -(Mv a, Mv m)
        {
            Mv nv = new Mv();

            for (int ii = 0; ii < 8; ii++)
            {
                nv.mv[ii] = a.mv[ii] - m.mv[ii];
            }
            return nv;
        }

        public static bool operator ==(Mv a, Mv m)
        {
            for (int ii = 0; ii < 8; ii++)
            {
                if (a.mv[ii] != m.mv[ii])
                {
                    return (false);
                }
            }
            return (true);
        }

        public static bool operator !=(Mv a, Mv m)
        {
            for (int ii = 0; ii < 8; ii++)
            {
                if (a.mv[ii] != m.mv[ii])
                {
                    return (true);
                }
            }
            return (false);
        }

        public override bool Equals(object obj)
        {
            return (this == (Mv)obj);
        }

        public override int GetHashCode()
        {
            int ii = mv[0].GetHashCode();
            for (int kk = 1; kk < 8; kk++)
            {
                ii ^= (int)mv[kk].GetHashCode();
            }

            return ii;
        }

        public Mv VectorOf()
        {
            Mv vv = new Mv();

            vv[MVI] = mv[MVI];
            vv[MVJ] = mv[MVJ];
            vv[MVK] = mv[MVK];
            return (vv);
        }

        public double AngVect(Mv va, Mv vb)
        {
            double dotvect = (va[MVI] * vb[MVI]) + (va[MVJ] * vb[MVJ]) + (va[MVK] * vb[MVK]);
            double vamag = Math.Sqrt(va[MVI] * va[MVI]) + (va[MVJ] * va[MVJ]) + (va[MVK] * va[MVK]);
            double vbmag = Math.Sqrt(vb[MVI] * vb[MVI]) + (vb[MVJ] * vb[MVJ]) + (vb[MVK] * vb[MVK]);
            double ang = Math.Acos(dotvect / (vamag * vbmag));
            return (ang);
        }

        public Mv VectCross(Mv a, Mv b)
        {
            Mv vv = new Mv();

            vv.mv[MVI] = (a.mv[MVJ] * b.mv[MVK]) - (b.mv[MVJ] * a.mv[MVK]);
            vv.mv[MVJ] = -(a.mv[MVI] * b.mv[MVK]) + (b.mv[MVI] * a.mv[MVK]);
            vv.mv[MVK] = (a.mv[MVI] * b.mv[MVJ]) - (b.mv[MVI] * a.mv[MVJ]);

            return (vv);
        }

        public Mv GetSpinor(Mv va, Mv vb)
        {
            double ang;
            double ang2;
            double sang;
            double den;
            Mv vv = new Mv();
            Mv q = new Mv();

            ang = AngVect(va, vb);
            ang2 = ang / 2.0;
            sang = Math.Sin(ang2);
            vv = VectCross(va, vb);
            den = vv.Mag();

            q.mv[MVIJ] = (vv[MVI] * sang) / den;
            q.mv[MVJK] = (vv[MVJ] * sang) / den;
            q.mv[MVKI] = (vv[MVK] * sang) / den;
            q.mv[MVS] = Math.Cos(ang2);

            return (q);
        }

        public Mv Spin(Mv vv)
        {
            Mv rmv = new Mv();
            Mv conjth = Conj(this);
            rmv = this * (vv * conjth);
            return (rmv.VectorOf());
        }


        public override string ToString()
        {
            string rt = "";
            for (int ii = 0; ii < 8; ii++)
            {
                rt += (mv[ii].ToString() + " ");
            }
            return (rt);
        }



        // end
    }
}
