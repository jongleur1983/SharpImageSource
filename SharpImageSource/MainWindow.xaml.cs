using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Input;
using System.Windows.Media;
using ImageSharp.WpfImageSource;
using ImageSharp;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace SharpImageSource
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var imageRgba32 = Image.Load<Rgba32>(assembly.GetManifestResourceStream("SharpImageSource.AutoTranslateWindowsStore.png"));

            this.ImageSharpSources = new ImageSource[]
            {
                new ImageSharpImageSource<Rgba32>(imageRgba32),
            };

            this.InitializeComponent();
        }

        public ImageSource[] ImageSharpSources { get; }
    }
}