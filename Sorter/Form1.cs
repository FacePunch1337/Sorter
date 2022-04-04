using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorter
{
    public partial class Sort : Form
    {

        private int num = 0;
        private string filename = string.Empty;

        private string search_path = "C:\\Users\\KLA\\OneDrive\\Рабочий стол";
        public string screenshots_path = "C:\\Users\\KLA\\OneDrive\\Рабочий стол\\Images\\Screenshots";
        private string pictures_path = "C:\\Users\\KLA\\OneDrive\\Рабочий стол\\Images\\Pictures";
        public Sort()
        {
            InitializeComponent();

        }


        private void buttonSort_Click(object sender, EventArgs e)
        {



            try
            {

                IEnumerable<string> pics = Directory.EnumerateFiles(search_path);

                foreach (string filename in pics)
                {

                    Path.GetFileName(filename);
                    if (filename.Contains(".png"))
                    {
                        if (filename.Contains($"Screenshot") || filename.Contains($"Screen"))
                        {

                            File.Move(filename, Path.Combine(screenshots_path, Path.GetFileName(filename)));
                            AnalizeFolder();

                        }

                        else
                        {
                            File.Move(filename, Path.Combine(pictures_path, Path.GetFileName(filename)));
                        }
                    }
                    else if (filename.Contains(".jpg"))
                    {
                        File.Move(filename, Path.Combine(pictures_path, Path.GetFileName(filename)));
                    }

                }

                labelDisplay.Text = "ГОТОВО";
                labelDisplay.ForeColor = Color.Green;

            }
            catch
            {
                labelDisplay.Text = "ОШИБКА";
                MessageBox.Show("Что-то пошло не так! Свяжитесь со Стасом.");
            }
        }


        void AnalizeFolder()
        {
            IEnumerable<string> pics = Directory.EnumerateFiles(screenshots_path);
            foreach (string filename in pics)
            {
                
                Path.GetFileName(filename);

                FileSystem.RenameFile(filename, ReName());

                listboxConsole.Items.Add(filename);

            }
        }
        String ReName()
        {
            num++;
            String name = $"Screen_{num.ToString()}.png";
            return name;
        }
    }
}
