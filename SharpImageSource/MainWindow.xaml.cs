using System;
using System.Reflection;
using System.Windows.Media;
using ImageSharp.WpfImageSource;
using ImageSharp;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Processing.Filters;

namespace SharpImageSource
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var stream = assembly.GetManifestResourceStream("SharpImageSource.AutoTranslateWindowsStore.png");
            var image = Image.Load<Rgba32>(stream);
            this.ImageSharpSource = new ImageSharpImageSource<SixLabors.ImageSharp.PixelFormats.Rgba32>()
            {
                Source = image
            };

            InitializeComponent();
        }

        public ImageSource ImageSharpSource { get; }
    }
}