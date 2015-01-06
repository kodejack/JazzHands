using System;
using System.Collections.Generic;
using UIKit;
using CoreGraphics;

namespace Screenmedia.IFTTT.JazzHands
{
	public class AnimationKeyFrame : AnimationFrame
	{
		public nint Time { get; set; }

		public AnimationKeyFrame ()//AnimationType type, nint time, T2 value2)
		{
//			Time = time;
//			switch (type) {
//			case AnimationType.Frame:
//				Frame = (RectangleF)value2;
//				break;
//			case AnimationType.Alpha:
//				Alpha = value2;
//				break;
//			case AnimationType.Hidden:
//				Hidden = value2;
//				break;
//			case AnimationType.Color:
//				Color = value2;
//				break;
//			case AnimationType.Angle:
//				Angle = value2;
//				break;
//			case AnimationType.Transform:
//				Transform = value2;
//				break;
//			case AnimationType.Scale:
//				Scale = value2;
//				break;
//			default:
//				throw new ArgumentOutOfRangeException ("type");
//			}
		}


//         These methods dont seem to do anything, in .net we can do all this stuff by sending in the values a construction.
//		public List<AnimationKeyFrame> KeyFramesWithTimesAndAlphas(params Tuple<nint, nfloat>[] pairCount)
//		{
//            if (pairCount.Length > 0)
//            {
//                var keyFrames = new List<AnimationKeyFrame>();
//                for (nint i = 0; i < pairCount.Length; i++)
//                {
//                    var keyFrame = new AnimationKeyFrame()
//                    {
//                        Time = pairCount[i].Item1,
//                        Alpha = pairCount[i].Item2
//                    };
//                    keyFrames.Add(keyFrame);
//                }
//                return keyFrames;
//            }
//		    return null;
//		}

//        private static List<AnimationKeyFrame> KeyFramesGeneric<T1, T2>(AnimationType animationType, Tuple<T1, T2>[] pairCount)
//	    {
//	        T1 time;
//	        T2 item2; // This is the varying type
//	        if (pairCount.Length > 0)
//	        {
//	            var keyFrames = new List<AnimationKeyFrame>();
//
//	            for (nint i = 0; i < pairCount.Length; i++)
//	            {
//	                time = pairCount[i].Item1;
//	                item2 = pairCount[i].Item2; // use double to suppress a va_arg conversion warning
//                    var keyFrame = new AnimationKeyFrame();
//	                // TODO: Add the method required for this
//	                keyFrames.Add(keyFrame);
//	            }
//	            return keyFrames;
//	        }
//	        else
//	        {
//	            return null;
//	        }
//	    }

//        public List<AnimationKeyFrame> KeyFramesWithTimesAndFrames(AnimationType animationType, params Tuple<nint, RectangleF>[] pairCount)
//		{
////            return KeyFramesGeneric(animationType, pairCount);
////			va_list argumentList;
////			nint time;
////			RectangleF frame;
////			if (pairCount > 0) {
////				NSMutableArray *keyFrames = [NSMutableArray arrayWithCapacity:(NSUInteger)pairCount];
////
////				va_start(argumentList, pairCount);
////
////				for (nint i=0; i<pairCount; i++) {
////					time = va_arg(argumentList, NSInteger);
////					frame = va_arg(argumentList, CGRect);
////					IFTTTAnimationKeyFrame *keyFrame = [IFTTTAnimationKeyFrame keyFrameWithTime:time
////						andFrame:frame];
////					[keyFrames addObject:keyFrame];
////				}
////
////				va_end(argumentList);
////
////				return [NSArray arrayWithArray:keyFrames];
////			}
////			else {
////				return nil;
////			}
//		}
////
//        public List<AnimationKeyFrame> KeyFramesWithTimesAndHiddens(AnimationType animationType, params Tuple<nint, bool>[] pairCount)
//		{
////            return KeyFramesGeneric(animationType, pairCount);
////			va_list argumentList;
////			NSInteger time;
////			BOOL hidden;
////			if (pairCount > 0) {
////				NSMutableArray *keyFrames = [NSMutableArray arrayWithCapacity:(NSUInteger)pairCount];
////
////				va_start(argumentList, pairCount);
////
////				for (nint i=0; i<pairCount; i++) {
////					time = va_arg(argumentList, NSInteger);
////					hidden = (BOOL)va_arg(argumentList, nint); // use nint to suppress a va_arg conversion warning
////					IFTTTAnimationKeyFrame *keyFrame = [IFTTTAnimationKeyFrame keyFrameWithTime:time
////						andHidden:hidden];
////					[keyFrames addObject:keyFrame];
////				}
////
////				va_end(argumentList);
////
////				return [NSArray arrayWithArray:keyFrames];
////			}
////			else {
////				return nil;
////			}
//		}
//
//        public List<AnimationKeyFrame> KeyFramesWithTimesAndColors(AnimationType animationType, params Tuple<nint, UIColor>[] pairCount)
//		{
////            return KeyFramesGeneric(animationType, pairCount);
////			va_list argumentList;
////			NSInteger time;
////			UIColor *color;
////			if (pairCount > 0) {
////				NSMutableArray *keyFrames = [NSMutableArray arrayWithCapacity:(NSUInteger)pairCount];
////
////				va_start(argumentList, pairCount);
////
////				for (nint i=0; i<pairCount; i++) {
////					time = va_arg(argumentList, NSInteger);
////					color = va_arg(argumentList, id);
////					IFTTTAnimationKeyFrame *keyFrame = [IFTTTAnimationKeyFrame keyFrameWithTime:time
////						andColor:color];
////					[keyFrames addObject:keyFrame];
////				}
////
////				va_end(argumentList);
////
////				return [NSArray arrayWithArray:keyFrames];
////			}
////			else {
////				return nil;
////			}
//		}
//
//        public List<AnimationKeyFrame> KeyFramesWithTimesAndAngles(AnimationType animationType, params Tuple<nint, nfloat>[] pairCount)
//	    {
////            return KeyFramesGeneric(animationType, pairCount);
////			va_list argumentList;
////			NSInteger time;
////			CGFloat angle;
////			if (pairCount > 0) {
////				NSMutableArray *keyFrames = [NSMutableArray arrayWithCapacity:(NSUInteger)pairCount];
////
////				va_start(argumentList, pairCount);
////
////				for (nint i=0; i<pairCount; i++) {
////					time = va_arg(argumentList, NSInteger);
////					angle = (CGFloat)va_arg(argumentList, double);
////					IFTTTAnimationKeyFrame *keyFrame = [IFTTTAnimationKeyFrame keyFrameWithTime:time
////						andAngle:angle];
////					[keyFrames addObject:keyFrame];
////				}
////
////				va_end(argumentList);
////
////				return [NSArray arrayWithArray:keyFrames];
////			}
////			else {
////				return nil;
////			}
//		}
//
//        public List<AnimationKeyFrame> KeyFramesWithTimesAndTransform3D(AnimationType animationType, params Tuple<nint, object>[] pairCount)
//        {
////            return KeyFramesGeneric(animationType, pairCount);
////			va_list argumentList;
////			NSInteger time;
////			IFTTTTransform3D * transform;
////			if (pairCount > 0) {
////				NSMutableArray *keyFrames = [NSMutableArray arrayWithCapacity:(NSUInteger)pairCount];
////
////				va_start(argumentList, pairCount);
////
////				for (nint i=0; i<pairCount; i++) {
////					time = va_arg(argumentList, NSInteger);
////					transform = va_arg(argumentList, id);
////					IFTTTAnimationKeyFrame *keyFrame = [IFTTTAnimationKeyFrame keyFrameWithTime:time
////						andTransform3D:transform];
////					[keyFrames addObject:keyFrame];
////				}
////
////				va_end(argumentList);
////
////				return [NSArray arrayWithArray:keyFrames];
////			} else {
////				return nil;
////			}
//		}
//
//        public List<AnimationKeyFrame> KeyFramesWithTimesAndScales(AnimationType animationType, params Tuple<nint, nfloat>[] pairCount)
//        {
////            return KeyFramesGeneric(animationType, pairCount);
////			va_list argumentList;
////			NSInteger time;
////			CGFloat scale;
////			if (pairCount > 0) {
////				NSMutableArray *keyFrames = [NSMutableArray arrayWithCapacity:(NSUInteger)pairCount];
////
////				va_start(argumentList, pairCount);
////
////				for (nint i=0; i<pairCount; i++) {
////					time = va_arg(argumentList, NSInteger);
////					scale = (CGFloat)va_arg(argumentList, double);
////					IFTTTAnimationKeyFrame *keyFrame = [IFTTTAnimationKeyFrame keyFrameWithTime: time
////						andScale: scale];
////					[keyFrames addObject:keyFrame];
////				}
////
////				va_end(argumentList);
////
////				return [NSArray arrayWithArray:keyFrames];
////			} else {
////				return nil;
////			}
//		}
	}

    public enum AnimationType
    {
        Frame,
        Alpha,
        Hidden,
        Color,
        Angle,
        Transform,
        Scale,
		constraintConstant
    }
}

