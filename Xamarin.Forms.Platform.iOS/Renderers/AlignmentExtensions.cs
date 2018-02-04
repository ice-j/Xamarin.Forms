using UIKit;
using Xamarin.Forms.Internals;

namespace Xamarin.Forms.Platform.iOS
{
	internal static class AlignmentExtensions
	{
		internal static UITextAlignment ToNativeTextAlignment(this TextAlignment alignment, EffectiveFlowDirection flowDirection)
		{
			var isLtr = flowDirection.IsLeftToRight();
			switch (alignment)
			{
				case TextAlignment.Center:
					return UITextAlignment.Center;
				case TextAlignment.End:
					if (isLtr)
						return UITextAlignment.Right;
					else
						return UITextAlignment.Left;
				default:
					if (isLtr)
						return UITextAlignment.Left;
					else
						return UITextAlignment.Natural;
			}
		}


		internal static UIControlContentHorizontalAlignment ToNativeControlContentHorizontalAlignment(this TextAlignment alignment, EffectiveFlowDirection flowDirection)
		{
			var isLtr = flowDirection.IsLeftToRight();
			switch (alignment)
			{
				case TextAlignment.Start:
					return isLtr ? UIControlContentHorizontalAlignment.Left : UIControlContentHorizontalAlignment.Right;
				case TextAlignment.End:
					return isLtr ? UIControlContentHorizontalAlignment.Right : UIControlContentHorizontalAlignment.Left;
				default:
					return UIControlContentHorizontalAlignment.Center;
			}
		}

		internal static UIControlContentVerticalAlignment ToNativeControlContentVerticalAlignment(this TextAlignment alignment)
		{
			switch (alignment)
			{
				case TextAlignment.Start:
					return UIControlContentVerticalAlignment.Top;
				case TextAlignment.End:
					return UIControlContentVerticalAlignment.Bottom;
				default:
					return UIControlContentVerticalAlignment.Center;
			}
		}
	}
}