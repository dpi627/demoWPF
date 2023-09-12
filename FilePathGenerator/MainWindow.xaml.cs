using System;
using System.IO;
using System.Text;
using System.Windows;
using Microsoft.Win32;
using Microsoft.Extensions.Configuration;

namespace FilePathGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IConfiguration _configuration;
        private readonly string sqlPattern;

        public MainWindow()
        {
            InitializeComponent();

            // Initialize the configuration
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            _configuration = builder.Build();

            sqlPattern = _configuration["SqlSyntax"]!;
        }

        private void SelectDirectory_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Title = "Select a Directory",
                FileName = "Folder Selection",
                Filter = "Folder|*.thisfolder",
                CheckFileExists = false,
                CheckPathExists = true,
                Multiselect = false
            };

            if (dialog.ShowDialog() == true)
            {
                string selectedDirectory = Path.GetDirectoryName(dialog.FileName)!;
                ScanDirectory(selectedDirectory);
            }
        }

        private void ScanDirectory(string directoryPath)
        {
            FilePathList.Items.Clear();

            try
            {
                string[] filePaths = Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories);

                foreach (string filePath in filePaths)
                {
                    WriteToList(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void WriteToList(string filePath)
        {
            filePath = string.Format(sqlPattern, filePath);
            FilePathList.Items.Add(filePath);
        }

        private void CopyFilePath_Click(object sender, RoutedEventArgs e)
        {
            if (FilePathList.Items.Count > 0)
            {
                StringBuilder allPaths = new StringBuilder();
                foreach (var item in FilePathList.Items)
                {
                    allPaths.AppendLine(item.ToString());
                }
                Clipboard.SetText(allPaths.ToString());
                MessageBox.Show("All paths copied.");
            }
            else
            {
                MessageBox.Show("The path list is empty.");
            }
        }
    }
}
