using System;
using Foundation;

namespace Screenmedia.IFTTT.JazzHands
{
    public class Transform3D : NSObject
    {
        public nfloat M34;
        public Transform3DScale Scale;
        public Transform3DRotate Rotate;
        public Transform3DTranslate Translate;

        public Transform3D()
		{
			Scale = new Transform3DScale()
			{
				Sx = 1.0f,
				Sy = 1.0f,
				Sz = 1.0f
			};
			Rotate = new Transform3DRotate()
			{
				Angle = 0.0f,
				X = 1.0f,
				Y = 1.0f,
				Z = -1.0f
			};
			Translate = new Transform3DTranslate()
			{
				Tx = 0.0f,
				Ty = 0.0f,
				Tz = 50.0f
			};
			M34 = 0.3f;
        }
    }

    public class Transform3DTranslate
    {
        public nfloat Tx, Ty, Tz = 0.0f;
    }

    public class Transform3DRotate
    {
        public nfloat Angle = 0.0f;
        public nfloat X, Y, Z = 0.0f;
    }

    public class Transform3DScale
    {
        public nfloat Sx, Sy, Sz = 0.0f;

    }
}

