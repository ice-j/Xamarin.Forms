﻿using System.ComponentModel;
using WRectangle = System.Windows.Shapes.Rectangle;

namespace Xamarin.Forms.Platform.WPF
{
	public class BoxViewRenderer : ViewRenderer<BoxView, WRectangle>
	{
		protected override void OnElementChanged(ElementChangedEventArgs<BoxView> e)
		{
			if (e.NewElement != null)
			{
				if (Control == null) // construct and SetNativeControl and suscribe control event
				{
					SetNativeControl(new WRectangle());
				}

				UpdateColor();
				UpdateCornerRadius();
			}

			base.OnElementChanged(e);
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			if (e.PropertyName == BoxView.ColorProperty.PropertyName)
				UpdateColor();
			else if (e.PropertyName == BoxView.CornerRadiusProperty.PropertyName)
				UpdateCornerRadius();
		}

		void UpdateColor()
		{
			Color color = Element.Color != Color.Default ? Element.Color : Element.BackgroundColor;
			Control.UpdateDependencyColor(WRectangle.FillProperty, color);
		}

		void UpdateCornerRadius()
		{
			var cornerRadius = Element.CornerRadius;
			Control.RadiusX = cornerRadius.TopLeft;
			Control.RadiusY = cornerRadius.BottomRight;
		}
	}
}
