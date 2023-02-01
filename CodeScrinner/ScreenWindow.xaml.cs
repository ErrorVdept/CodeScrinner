using CodeScrinner.Generators;
using CoreHtmlToImage;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace CodeScrinner
{
    /// <summary>
    /// Логика взаимодействия для ScreenWindow.xaml
    /// </summary>
    public partial class ScreenWindow : Window
    {
        public HtmlGenerator htmlGenerator;
        private string TextCode = "";
        public ScreenWindow(string text)
        {
            InitializeComponent();
            TextCode = text;

            htmlGenerator = new HtmlGenerator();
            GeneratePreview();
        }
        public void InitWindow(string text)
        {
            TextCode = text;

            htmlGenerator = new HtmlGenerator();
            GeneratePreview();
        }
        private string HtmlView = "";
        private HtmlConverter converter = new HtmlConverter();

        static ImageSourceConverter imageSourceConverter = new ImageSourceConverter();
        private void GeneratePreview()
        {
            ImgPreview.Source = null;
            
            
            string path = Environment.CurrentDirectory + "\\preview.jpg";
            //if (File.Exists(path))
            //{
            //    File.Delete(path);
            //}
            //else
            //{

            //}
            
            
            HtmlView = htmlGenerator.GenerateHtml(TextCode);
            var imageBytes = converter.FromHtmlString(HtmlView, 724, ImageFormat.Jpg, 70);
            //using (var file = File.OpenWrite(path))
            //{
            //    file.Write(imageBytes);
            //}
            //File.WriteAllBytes("preview.jpg", imageBytes);
            //File.Copy("preview.jpg", "preview_copy.jpg", true);

            //BitmapImage bitmap = new BitmapImage();
            //bitmap.BeginInit();

            ////stream = File.Open("preview_copy.jpg", FileMode.Open);

            //bitmap.StreamSource = stream;
            //bitmap.EndInit();
            var image = new BitmapImage();
            using (var mem = new MemoryStream(imageBytes))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            ImgPreview.Source = image;  
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG image (*.png)|*.png";
            
            var imageBytes = converter.FromHtmlString(HtmlView, 724, ImageFormat.Png, 100);
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllBytes(saveFileDialog.FileName, imageBytes);
        }
        private void Github_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/ErrorVdept") { UseShellExecute = true });

        }
        private void Web_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://errorvdept.github.io") { UseShellExecute = true });

        }
        private void Donate_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://donate.stream/errorvdept_soft") { UseShellExecute = true });

        }
    }
}
