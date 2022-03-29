using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ImageToASCIIConverter
{
    public partial class Form1 : Form
    {
        private readonly string CONFIG_PATH = $"{Environment.CurrentDirectory}\\SavePath.config";
        private const string NAME_OF_FILE = "\\ConvertedImage.txt";
        private string SAVE_PATH = "ConvertedImage.txt"; //Def save_path near .exe
        
        private const double WIDTH_OFFSET = 2;
        private const int MAX_WIDTH = 500;

        static Bitmap ResizeBitMap(Bitmap bitmap)
        {
            var newHeight = bitmap.Height / WIDTH_OFFSET * MAX_WIDTH / bitmap.Width;

            if (bitmap.Width > MAX_WIDTH || bitmap.Height > newHeight)
            {
                bitmap = new Bitmap(bitmap, new Size(MAX_WIDTH, (int)newHeight));
            }
            return bitmap;
        }

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Images | *.bmp; *.png; *.jpg; *.JPEG; *.gif";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(CONFIG_PATH))
                File.WriteAllText(CONFIG_PATH, "");

            if (!(File.ReadAllText(CONFIG_PATH) == ""))
            {
                SAVE_PATH = File.ReadAllText(CONFIG_PATH);
                FileInfo obj = new FileInfo(SAVE_PATH);
                textBox1.Text = obj.DirectoryName;
            }
        }

        private void bOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                MessageBox.Show("You have not selected a file!", caption: "Warning");
            else
            {
                FileInfo obj = new FileInfo(openFileDialog1.FileName);
                label_NameOfFile.Text = obj.Name;
            }
        }

        private void bConvert_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "")
            {
                MessageBox.Show("Please choose a picture first!", caption: "Warning");
                return;
            }

            var bitmap = new Bitmap(openFileDialog1.FileName); //Создаем Bitmap для нашей картинки
            
            bitmap = ResizeBitMap(bitmap);

            bitmap.ToGrayScale();

            BitmapToASCIIConverter converter = new BitmapToASCIIConverter(bitmap);
            var ResultToFile = converter.ConvertToFile();
            File.WriteAllLines(SAVE_PATH, ResultToFile.Select(r => new string(r)));

            label_NameOfFile.Text = "";
            openFileDialog1.FileName = "";

            MessageBox.Show(text: "Successfully converted!", caption: "Success");
        }

        private void bBrowseFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK)
                MessageBox.Show("Path not selected!", caption: "Warning");
            else
            {
                File.WriteAllText(CONFIG_PATH, folderBrowserDialog1.SelectedPath + NAME_OF_FILE);
                SAVE_PATH = folderBrowserDialog1.SelectedPath + NAME_OF_FILE;
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Author_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/SushkoTech");
        }
    }
}
