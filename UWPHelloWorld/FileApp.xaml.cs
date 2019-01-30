using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPHelloWorld
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FileApp : Page
    {
        const string TEXT_FILE_NAME = "SampleTextFile.txt";

        public FileApp()
        {
            this.InitializeComponent();
        }

        private async void ReadFile_Click(object sender, RoutedEventArgs e)
        {
            string str = await FileHelper.ReadTextFile(TEXT_FILE_NAME);
            textBlock.Text = str;
        }

        private async void WriteFile_Click(object sender, RoutedEventArgs e)
        {
            string textFilePath = await FileHelper.WriteTextToFile(TEXT_FILE_NAME, textBox.Text);
        }

        public static class FileHelper
        {
            public static async Task<string> WriteTextToFile(string filename, string contents)
            {
                StorageFolder localFolder = ApplicationData.Current.LocalFolder;
                StorageFile textFile = await localFolder.CreateFileAsync(filename, CreationCollisionOption.ReplaceExisting);
                using (IRandomAccessStream textStream = await textFile.OpenAsync(FileAccessMode.ReadWrite))
                {
                    using(DataWriter textWriter = new DataWriter(textStream))
                    {
                        textWriter.WriteString(contents);
                        await textWriter.StoreAsync();
                    }
                }

                return textFile.Path;
            }

            public static async Task<string> ReadTextFile(string filename)
            {
                StorageFolder localFolder = ApplicationData.Current.LocalFolder;
                StorageFile textFile = await localFolder.GetFileAsync(filename);

                string contents;

                using(IRandomAccessStream textStream = await textFile.OpenReadAsync())
                {
                    using(DataReader reader = new DataReader(textStream))
                    {
                        uint textLength = (uint)textStream.Size;
                        await reader.LoadAsync(textLength);
                        contents = reader.ReadString(textLength);
                    }
                }

                return contents;
            }
        }
    }
}
