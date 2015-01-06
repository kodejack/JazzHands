using System;
using System.Linq;
using UIKit;

namespace Screenmedia.IFTTT.JazzHands
{
	public class HideAnimation : Animation
	{
		public HideAnimation (UIView view, nint time) : base(view)
		{
		}

		public override void Animate(nint time)
		{
			if (KeyFrames.Count <= 1) return;

			AnimationFrame animationFrame = AnimationFrameForTime(time);
			View.Hidden = animationFrame.Hidden;
		}

		public override AnimationFrame FrameForTime(nint time,
			AnimationKeyFrame startKeyFrame,
			AnimationKeyFrame endKeyFrame)
		{
			AnimationFrame animationFrame = new AnimationFrame ();
			animationFrame.Hidden = (time == startKeyFrame.Time ? startKeyFrame : endKeyFrame).Hidden;

			return animationFrame;
		}
	}
}

