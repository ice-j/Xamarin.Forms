using Xamarin.Forms.CustomAttributes;

namespace Xamarin.Forms.Controls
{
	internal class ButtonCoreGalleryPage : CoreGalleryPage<Button>
	{
		protected override bool SupportsTapGestureRecognizer {
			get { return false; }
		}

		protected override bool SupportsFocus {
			get { return false; }
		}

		protected override void InitializeElement (Button element)
		{
			element.Text = "Button";
		}

		protected override void Build (StackLayout stackLayout)
		{
			base.Build (stackLayout);

			IsEnabledStateViewContainer.View.Clicked += (sender, args) => IsEnabledStateViewContainer.TitleLabel.Text += " (Tapped)";

			var borderButtonContainer = new ViewContainer<Button> (Test.Button.BorderColor, 
				new Button {
					Text = "BorderColor",
					BackgroundColor = Color.Transparent, 
					BorderColor = Color.Red, 
					BorderWidth = 1,
				}
			);

			var borderRadiusContainer = new ViewContainer<Button> (Test.Button.BorderRadius, 
				new Button {
					Text = "BorderRadius",
					BackgroundColor = Color.Transparent,
					BorderColor = Color.Red,
					BorderRadius = 20,
					BorderWidth = 1,
				}
			);
		
			var borderWidthContainer = new ViewContainer<Button> (Test.Button.BorderWidth,
				new Button {
					Text = "BorderWidth",
					BackgroundColor = Color.Transparent,
					BorderColor = Color.Red,
					BorderWidth = 15,
				}
			);

			var clickedContainer = new EventViewContainer<Button> (Test.Button.Clicked, 
				new Button {
					Text = "Clicked"
				}
			);
			clickedContainer.View.Clicked += (sender, args) => clickedContainer.EventFired ();

			var commandContainer = new ViewContainer<Button> (Test.Button.Command, 
				new Button {
					Text = "Command", 
					Command = new Command (() => DisplayActionSheet ("Hello Command", "Cancel", "Destroy"))
				}
			);

			var fontContainer = new ViewContainer<Button> (Test.Button.Font,
				new Button {
					Text = "Font", 
					Font = Font.SystemFontOfSize (NamedSize.Large, FontAttributes.Bold) 
				}
			);

			var imageContainer = new ViewContainer<Button> (Test.Button.Image, 
				new Button {
					Text = "Image", 
					Image = new FileImageSource { File = "bank.png" }
				}
			)
			;
			var textContainer = new ViewContainer<Button> (Test.Button.Text, 
				new Button {
					Text = "Text"
				}
			);

			var textColorContainer = new ViewContainer<Button> (Test.Button.TextColor, 
				new Button {
					Text = "TextColor", TextColor = Color.Pink
				}
			);

			const int alignmentTestsHeightRequest = 200;
			const int alignmentTestsWidthRequest = 400;

			var xAlignCenterContainer = new ViewContainer<Button>(Test.Button.HorizontalTextAlignmentCenter,
				new Button
				{
					Text = "HTA - Center",
					HorizontalTextAlignment = TextAlignment.Center,
					HeightRequest = alignmentTestsHeightRequest,
					WidthRequest = alignmentTestsWidthRequest,
					BorderColor = Color.Red,
					BorderWidth = 3
				}
			);

			var xAlignEndContainer = new ViewContainer<Button>(Test.Button.HorizontalTextAlignmentEnd,
				new Button
				{
					Text = "HTA - End",
					HorizontalTextAlignment = TextAlignment.End,
					HeightRequest = alignmentTestsHeightRequest,
					WidthRequest = alignmentTestsWidthRequest,
					BorderColor = Color.Red,
					BorderWidth = 3
				}
			);

			var xAlignStartContainer = new ViewContainer<Button>(Test.Button.HorizontalTextAlignmentStart,
				new Button
				{
					Text = "HTA - Start",
					HorizontalTextAlignment = TextAlignment.Start,
					HeightRequest = alignmentTestsHeightRequest,
					WidthRequest = alignmentTestsWidthRequest,
					BorderColor = Color.Red,
					BorderWidth = 3
				}
			);

			var RTLxAlignCenterContainer = new ViewContainer<Button>(Test.Button.RTLHorizontalTextAlignmentCenter,
				new Button
				{
					Text = "HTA - Center(RTL)",
					HorizontalTextAlignment = TextAlignment.Center,
					HeightRequest = alignmentTestsHeightRequest,
					WidthRequest = alignmentTestsWidthRequest,
					FlowDirection = FlowDirection.RightToLeft,
					BorderColor = Color.Red,
					BorderWidth = 3
				}
			);

			var RTLxAlignEndContainer = new ViewContainer<Button>(Test.Button.RTLHorizontalTextAlignmentEnd,
				new Button
				{
					Text = "HTA - End(RTL)",
					HorizontalTextAlignment = TextAlignment.End,
					HeightRequest = alignmentTestsHeightRequest,
					WidthRequest = alignmentTestsWidthRequest,
					FlowDirection = FlowDirection.RightToLeft,
					BorderColor = Color.Red,
					BorderWidth = 3
				}
			);

			var RTLxAlignStartContainer = new ViewContainer<Button>(Test.Button.RTLHorizontalTextAlignmentStart,
				new Button
				{
					Text = "HTA - Start(RTL)",
					HorizontalTextAlignment = TextAlignment.Start,
					HeightRequest = alignmentTestsHeightRequest,
					WidthRequest = alignmentTestsWidthRequest,
					FlowDirection = FlowDirection.RightToLeft,
					BorderColor = Color.Red,
					BorderWidth = 3
				}
			);

			var yAlignCenterContainer = new ViewContainer<Button>(Test.Button.VerticalTextAlignmentCenter,
				new Button
				{
					Text = "VTA - Center",
					VerticalTextAlignment = TextAlignment.Center,
					HeightRequest = alignmentTestsHeightRequest,
					WidthRequest = alignmentTestsWidthRequest,
					BorderColor = Color.Red,
					BorderWidth = 3
				}
			);

			var yAlignEndContainer = new ViewContainer<Button>(Test.Button.VerticalTextAlignmentEnd,
				new Button
				{
					Text = "VTA - End",
					VerticalTextAlignment = TextAlignment.End,
					HeightRequest = alignmentTestsHeightRequest,
					WidthRequest = alignmentTestsWidthRequest,
					BorderColor = Color.Red,
					BorderWidth = 3
				}
			);

			var yAlignStartContainer = new ViewContainer<Button>(Test.Button.VerticalTextAlignmentStart,
				new Button
				{
					Text = "VTA - Start",
					VerticalTextAlignment = TextAlignment.Start,
					HeightRequest = alignmentTestsHeightRequest,
					WidthRequest = alignmentTestsWidthRequest,
					BorderColor = Color.Red,
					BorderWidth = 3
				}
			);


			

			Add (borderButtonContainer);
			Add (borderRadiusContainer);
			Add (borderWidthContainer);
			Add (clickedContainer);
			Add (commandContainer);
			Add (fontContainer);
			Add (imageContainer);
			Add (textContainer);
			Add (textColorContainer);
			Add (xAlignCenterContainer);
			Add (xAlignEndContainer);
			Add (xAlignStartContainer);
			Add (RTLxAlignCenterContainer);
			Add (RTLxAlignEndContainer);
			Add (RTLxAlignStartContainer);
			Add (yAlignCenterContainer);
			Add (yAlignEndContainer);
			Add (yAlignStartContainer);
			//stackLayout.Children.Add (textColorContainer);
		}
	}
}