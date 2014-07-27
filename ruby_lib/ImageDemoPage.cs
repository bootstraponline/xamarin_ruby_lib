using System;
using Xamarin.Forms;

namespace ruby_lib
{
    // code from: https://github.com/xamarin/xamarin-forms-samples/blob/98c8154787cf3f157f1af9d8ab03368eddc831e9/FormsGallery/FormsGallery/FormsGallery/ImageDemoPage.cs
    class ImageDemoPage : ContentPage
    {
        public ImageDemoPage ()
        {
            Label header = new Label {
                Text = "Image",
                Font = Font.SystemFontOfSize(50, FontAttributes.Bold),
                HorizontalOptions = LayoutOptions.Center
            };

            Image image = new Image {
                // Some differences with loading images in initial release.
                Source =
                    Device.OnPlatform (ImageSource.FromUri (new Uri ("http://xamarin.com/images/index/ide-xamarin-studio.png")),
                    ImageSource.FromFile ("ide_xamarin_studio.png"),
                    ImageSource.FromUri (new Uri ("http://xamarin.com/images/index/ide-xamarin-studio.png"))),



                //Source = new UriImageSource
                //{
                //    Uri = new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")
                //},
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Accomodate iPhone status bar.
            this.Padding = new Thickness (10, Device.OnPlatform (20, 0, 0), 10, 5);

            // Build the page.
            this.Content = new StackLayout {
                Children = {
                    header,
                    image
                }
            };
        }
    }
}