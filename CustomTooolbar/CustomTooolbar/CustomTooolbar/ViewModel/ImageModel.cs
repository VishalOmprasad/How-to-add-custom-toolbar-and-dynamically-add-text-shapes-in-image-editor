namespace CustomTooolbar
{
    using System.Reflection;
    using Xamarin.Forms;

    internal class ImageModel
    {
        public ImageSource Image { get; set; }

        public ImageModel()
        {
            Assembly assembly = typeof(ImageModel).GetTypeInfo().Assembly;
            Image = ImageSource.FromResource("CustomTooolbar.Images.Skyscraper.png", assembly);
        }
    }
}
