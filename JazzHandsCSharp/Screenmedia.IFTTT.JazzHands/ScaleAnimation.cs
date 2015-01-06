using System;
using UIKit;
using System.Linq;
using CoreGraphics;

namespace Screenmedia.IFTTT.JazzHands
{
	public class ScaleAnimation : Animation
	{
		public ScaleAnimation (UIView view) : base(view)
		{
		}

		public override void Animate(nint time)
		{
			if (KeyFrames.Count <= 1) return;

			AnimationFrame animationFrame = AnimationFrameForTime(time);
			nfloat scale = animationFrame.Scale;
			View.Transform = CGAffineTransform.MakeScale (scale, scale);
		}

		public override AnimationFrame FrameForTime(nint time,
			AnimationKeyFrame startKeyFrame,
			AnimationKeyFrame endKeyFrame)
		{
			AnimationFrame animationFrame = new AnimationFrame ();
			animationFrame.Scale = TweenValueForStartTime (startKeyFrame.Time,
				endKeyFrame.Time,
				startKeyFrame.Scale,
				endKeyFrame.Scale,
				time);

			return animationFrame;
		}
	}
}

