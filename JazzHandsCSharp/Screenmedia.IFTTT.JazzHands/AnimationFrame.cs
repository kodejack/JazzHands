using System;
using UIKit;
using CoreGraphics;

namespace Screenmedia.IFTTT.JazzHands
{
	public class AnimationFrame
	{
		public CGRect Frame = new CGRect();
		public nfloat Alpha;
		public bool Hidden = false;
		public UIColor Color;
        public nfloat Angle;
		public Transform3D Transform = new Transform3D();
        public nfloat Scale;
		public nfloat constraintConstant;
	}
}

