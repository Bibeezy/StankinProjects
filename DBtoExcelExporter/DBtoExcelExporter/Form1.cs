using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBtoExcelExporter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yandexDataSet.Countries". При необходимости она может быть перемещена или удалена.
            this.countriesTableAdapter1.Fill(this.yandexDataSet.Countries);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "yandexDataSet.Cities". При необходимости она может быть перемещена или удалена.
            this.citiesTableAdapter.Fill(this.yandexDataSet.Cities);
            this.companiesTableAdapter.Fill(this.yandexDataSet.Companies);
            


            foreach (DataTable DT in yandexDataSet.Tables)
            {
                comboBox1.Items.Add(DT.TableName);
            }
            
            

        }

        private void Exportbtn_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog sfd=new SaveFileDialog() { Filter="Excel Workbook|*.xlsx"})
            {
                if(sfd.ShowDialog()==DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook woorkbook = new XLWorkbook())
                        {
                            foreach (DataTable dt in yandexDataSet.Tables)
                            {
                                if (dt.TableName == comboBox1.SelectedItem.ToString())
                                {
                                    woorkbook.Worksheets.Add(dt, dt.TableName);
                                    woorkbook.SaveAs(sfd.FileName);

                                    MessageBox.Show($"Kaif {dt.TableName} zakinuli", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }

                        //using (XLWorkbook woorkbook = new XLWorkbook())
                        //{
                        //    woorkbook.Worksheets.Add(this.yandexDataSet.Cities.CopyToDataTable(), yandexDataSet.Cities.TableName);
                        //    woorkbook.SaveAs(sfd.FileName);
                        //}
                        //MessageBox.Show($"Kaif {yandexDataSet.Cities.TableName} zakinuli","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
         
            
        }

        private void dataGridView1_DataMemberChanged(object sender, EventArgs e)
        {
            
        }
    }
}
