using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using Emgu.Util;

namespace TextEye
{
    public partial class Form1 : Form
    {
        private string filepath = string.Empty;
        private string lang = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if(res==DialogResult.OK)
            {
                filepath = openFileDialog1.FileName;

                pictureBox1.Image = Image.FromFile(filepath);
            }
            else
            {
                MessageBox.Show("Картинку бы выбрать", "Выберите картинку", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrEmpty(filepath)|| String.IsNullOrWhiteSpace(filepath))
                {
                    throw new Exception("Картинка не выбрана");
                }
                else if(toolStripComboBox1.SelectedItem==null)
                {
                    throw new Exception("Язык не выбран");
                }
                else
                {
                    Tesseract tesseract = new Tesseract(@"C:\Users\bibik\source\repos\TextEye\TestData", lang, OcrEngineMode.TesseractLstmCombined);
                    tesseract.SetImage(new Image<Bgr, byte>(filepath));
                    tesseract.Recognize();

                    richTextBox1.Text = tesseract.GetUTF8Text()+ $"\n Братик, а ты хорооооош <3";
                    tesseract.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedIndex == 0)
                lang = "rus";
            else if (toolStripComboBox1.SelectedIndex == 1)
                lang = "eng";
        }
    }
}
