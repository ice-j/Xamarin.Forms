using Android.Views;
using ATextAlignment = Android.Views.TextAlignment;

namespace Xamarin.Forms.Platform.Android
{
	internal static class AlignmentExtensions
	{
		internal static ATextAlignment ToTextAlignment(this TextAlignment alignment)
		{
			switch (alignment)
			{
				case TextAlignment.Center:
					return ATextAlignment.Center;
				case TextAlignment.End:
					return ATextAlignment.ViewEnd;
				default:
					return ATextAlignment.ViewStart;
			}
		}

		internal static GravityFlags ToHorizontalGravityFlags(this TextAlignment alignment, EffectiveFlowDirection flowDirection = default(EffectiveFlowDirection))
		{
			var isLtr = flowDirection.IsLeftToRight();
			switch (alignment)
			{
				case TextAlignment.Center:
					return GravityFlags.CenterHorizontal;
				case TextAlignment.End:
					return isLtr ? GravityFlags.End : GravityFlags.Start;
				default:
					return isLtr ? GravityFlags.Start : GravityFlags.End;
			}
		}

		internal static GravityFlags ToVerticalGravityFlags(this TextAlignment alignment)
		{
			switch (alignment)
			{
				case TextAlignment.Start:
					return GravityFlags.Top;
				case TextAlignment.End:
					return GravityFlags.Bottom;
				default:
					return GravityFlags.CenterVertical;
			}
		}
	}
}