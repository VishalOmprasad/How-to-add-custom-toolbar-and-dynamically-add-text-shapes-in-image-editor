namespace CustomTooolbar
{
    using Syncfusion.SfImageEditor.XForms;
    using Xamarin.Forms;
    using static Xamarin.Forms.Internals.GIFBitmap;


    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            imageEditor.SetToolbarItemVisibility("text,transform,shape,path", false);
            imageEditor.ToolbarSettings.FooterToolbarHeight = 60;
            imageEditor.ToolbarSettings.HeaderToolbarHeight = 60;
            imageEditor.ToolbarSettings.ToolbarItems.Add(new FooterToolbarItem() { Name = "AddText", Text = "AddText", Icon = ImageSource.FromResource("CustomTooolbar.Icons.textpic.png") });
            imageEditor.ToolbarSettings.ToolbarItems.Add(new FooterToolbarItem() { Name = "AddPath", Icon = ImageSource.FromResource("CustomTooolbar.Icons.pathpic.png") });
            imageEditor.ToolbarSettings.ToolbarItems.Add(new FooterToolbarItem() { Name = "AddShape", Text = "AddShape" });
            imageEditor.ToolbarSettings.ToolbarItems.Add(new FooterToolbarItem() { Name = "RotateImage", Icon = ImageSource.FromResource("CustomTooolbar.Icons.rotatepic.png") });
            imageEditor.ToolbarSettings.ToolbarItems.Add(new FooterToolbarItem() { Name = "FlipImage", Text = "Flip" });
            imageEditor.ToolbarSettings.ToolbarItems.Add(new FooterToolbarItem() { Name = "CropImage", Text = "Crop" });

            imageEditor.ToolbarSettings.ToolbarItemSelected += ToolbarSettings_ToolbarItemSelected;
        }

        private void ToolbarSettings_ToolbarItemSelected(object sender, ToolbarItemSelectedEventArgs e)
        {
            var toolbarItem = e.ToolbarItem;
            if (toolbarItem.Name == "AddText")
            {
                imageEditor.AddText("ImageEditor", new TextSettings() { Color = Color.Green, FontSize = 20, TextEffects = TextEffects.Italic });
            }
            else if (toolbarItem.Name == "AddPath")
            {
                imageEditor.AddShape(ShapeType.Path, new PenSettings() { Color = Color.Blue });
            }
            else if (toolbarItem.Name == "AddShape")
            {
                imageEditor.AddShape(ShapeType.Circle, new PenSettings() { Color = Color.Black, Mode = Mode.Fill });
            }
            else if (toolbarItem.Name == "FlipImage")
            {
                imageEditor.Flip(FlipDirection.Horizontal);
            }
            else if (toolbarItem.Name == "RotateImage")
            {
                imageEditor.Rotate();
            }
        }

    }
}
