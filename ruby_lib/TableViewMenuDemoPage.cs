using System;
using Xamarin.Forms;

namespace ruby_lib
{
    // code from: https://github.com/xamarin/xamarin-forms-samples/blob/98c8154787cf3f157f1af9d8ab03368eddc831e9/FormsGallery/FormsGallery/FormsGallery/TableViewMenuDemoPage.cs
    class TableViewMenuDemoPage : ContentPage
    {
        public TableViewMenuDemoPage ()
        {
            Label header = new Label {
                Text = "Test Launcher",
                Font = Font.SystemFontOfSize(40, FontAttributes.Bold),
                HorizontalOptions = LayoutOptions.Center
            };

            TableView tableView = new TableView {
                BackgroundColor = Color.White,
                Intent = TableIntent.Menu,
                Root = new TableRoot {
                    new TableSection () {
                        new TextCell {
                            Text = "Label",
                            Command = new Command (async () => 
                                await Navigation.PushAsync (new LabelDemoPage ()))
                        },

                        new TextCell {
                            Text = "Image",
                            Command = new Command (async () => 
                                await Navigation.PushAsync (new ImageDemoPage ()))
                        },
                    }
                }
            };

            // Accomodate iPhone status bar.
            this.Padding = new Thickness (10, Device.OnPlatform (20, 0, 0), 10, 5);

            // Build the page.
            this.Content = new StackLayout {
                Children = {
                    header,
                    tableView
                }
            };
        }
    }
}