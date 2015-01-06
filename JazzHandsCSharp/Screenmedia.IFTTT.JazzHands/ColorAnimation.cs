using System;
using UIKit;
using System.Linq;

namespace Screenmedia.IFTTT.JazzHands
{
	public class ColorAnimation : Animation
	{
		public ColorAnimation (UIView view) : base(view)
		{

		}

		public override void Animate(nint time)
		{
			if (KeyFrames.Count() <= 1) return;

			AnimationFrame animationFrame = AnimationFrameForTime(time);
			View.BackgroundColor = animationFrame.Color;
		}

		public override AnimationFrame FrameForTime(nint time,
			AnimationKeyFrame startKeyFrame,
			AnimationKeyFrame endKeyFrame)
		{
			AnimationFrame animationFrame = new AnimationFrame ();
			nfloat startRed = 0.0f, startBlue = 0.0f, startGreen = 0.0f, startAlpha = 0.0f;
			nfloat endRed = 0.0f, endBlue = 0.0f, endGreen = 0.0f, endAlpha = 0.0f;

			if (GetRed (startRed, startGreen, startBlue, startAlpha, startKeyFrame.Color) &&
			    GetRed (endRed, endGreen, endBlue, endAlpha, endKeyFrame.Color)) {
				nfloat red = TweenValueForStartTime (startKeyFrame.Time, endKeyFrame.Time, startRed, endRed, time);
				nfloat green = TweenValueForStartTime (startKeyFrame.Time, endKeyFrame.Time, startGreen, endGreen, time);
				nfloat blue = TweenValueForStartTime (startKeyFrame.Time, endKeyFrame.Time, startBlue, endBlue, time);
				nfloat alpha = TweenValueForStartTime (startKeyFrame.Time, endKeyFrame.Time, startAlpha, endAlpha, time);
				animationFrame.Color = UIColor.FromRGBA (red, green, blue, alpha);
			}

			return animationFrame;
		}

		private bool GetRed(nfloat red, nfloat green, nfloat blue, nfloat alpha, UIColor color) {
			nfloat white;

			color.GetRGBA (out red, out green, out blue, out alpha);

			if (red != null && green != null && blue != null && alpha != null) {
				return true;
			} else if (color.GetWhite (out white, out alpha)) {
				// Redundant?
				red = white;
				green = white;
				blue = white;
				return true;
			}

			return false;
		}
	}
}

