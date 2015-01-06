using System;
using System.Linq;
using UIKit;

namespace Screenmedia.IFTTT.JazzHands
{
	public class AlphaAnimation : Animation
	{
	    public AlphaAnimation(UIView view) : base(view)
	    {
	    }

	    public override void Animate(nint time)
		{
			if (KeyFrames.Count() <= 1) return;

			AnimationFrame animationFrame = AnimationFrameForTime(time);
			View.Alpha = animationFrame.Alpha;
		}

		public override AnimationFrame FrameForTime(nint time,
			AnimationKeyFrame startKeyFrame,
			AnimationKeyFrame endKeyFrame)
		{
			AnimationFrame animationFrame = new AnimationFrame ();
			animationFrame.Alpha = TweenValueForStartTime (startKeyFrame.Time,
				endKeyFrame.Time,
				startKeyFrame.Alpha,
				endKeyFrame.Alpha,
				time);

			return animationFrame;
		}
	}
}

