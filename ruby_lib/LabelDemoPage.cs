using System;
using Xamarin.Forms;

namespace ruby_lib
{
    // code from: https://github.com/xamarin/xamarin-forms-samples/blob/98c8154787cf3f157f1af9d8ab03368eddc831e9/FormsGallery/FormsGallery/FormsGallery/LabelDemoPage.cs
    class LabelDemoPage : ContentPage
    {
        public LabelDemoPage ()
        {
            Label header = new Label {
                Text = "Label",
                Font = Font.SystemFontOfSize(50, FontAttributes.Bold),
                HorizontalOptions = LayoutOptions.Center
            };

            Label label = new Label {
                Text =
                    "Xamarin.Forms is a cross-platform natively " +
                "backed UI toolkit abstraction that allows " +
                "developers to easily create user interfaces " +
                "that can be shared across Android, iOS, and " +
                "Windows Phone.",

                Font = Font.SystemFontOfSize (NamedSize.Large),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Accomodate iPhone status bar.
            this.Padding = new Thickness (10, Device.OnPlatform (20, 0, 0), 10, 5);

            // Build the page.
            this.Content = new StackLayout {
                Children = {
                    header,
                    label
                }
            };
        }
    }
}