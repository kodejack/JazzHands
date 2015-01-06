using System;
using CoreGraphics;
using Foundation;
using UIKit;
using System.Linq;
using CoreGraphics;

namespace Screenmedia.IFTTT.JazzHands
{
    public class FrameAnimation : Animation
    {
        public FrameAnimation(UIView view) : base(view)
        {
        }

		public override void Animate(nint time)
        {
            if (KeyFrames.Count() <= 1)
                return;

			  AnimationFrame animationFrame = AnimationFrameForTime(time);

            // Store the current transform
            CGAffineTransform tempTransform = View.Transform;

            // Reset rotation to 0 to avoid warping
            View.Transform = CGAffineTransform.MakeRotation(0);
            View.Frame = animationFrame.Frame;

            // Return to original transform
            View.Transform = tempTransform;
        }

		public override AnimationFrame FrameForTime(nint time,
            AnimationKeyFrame startKeyFrame,
            AnimationKeyFrame endKeyFrame)
        {
            nint startTime = startKeyFrame.Time;
            nint endTime = endKeyFrame.Time;
            CGRect startLocation = startKeyFrame.Frame;
            CGRect endLocation = endKeyFrame.Frame;

            CGRect frame = View.Frame;
            frame.Location =
                new CGPoint(
                    TweenValueForStartTime(startTime, endTime, startLocation.GetMinX(), endLocation.GetMinX(), time),
                    TweenValueForStartTime(startTime, endTime, startLocation.GetMinY(), endLocation.GetMinY(), time));
            frame.Size =
                new CGSize(TweenValueForStartTime(startTime, endTime, startLocation.Width, endLocation.Width, time), TweenValueForStartTime(startTime, endTime, startLocation.Height, endLocation.Height, time));

            AnimationFrame animationFrame = new AnimationFrame();
            animationFrame.Frame = frame;

            return animationFrame;
        }
    }
}

