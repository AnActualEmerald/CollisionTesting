using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CollisionTesting
{
    class PhysBody
    {
        private PointF verts;
        private int _type;

        public PhysBody(int body_type, float width , float height)
        {
            _type = body_type;
            
        }

        private void _init_constructor()
        {

        }


        public void Init()
        {

        }


    }

    class BodyFactory
    {
        public static readonly int RECT = 1;
        public static readonly int CIRCLE = 2;
        public static readonly int POLYGON = 3;

        public static PointF[] MakeRectBody(float width, float height)
        {
            List<PointF> verts = new List<PointF>();

            verts.Add(new PointF(0, 0));
            verts.Add(new PointF(width, 0));
            verts.Add(new PointF(width, height));
            verts.Add(new PointF(0, height));

            return verts.ToArray();
        }



    }
    
}
