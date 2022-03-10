using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtChooseFile.Text == "")
            {
                return;
            }
            listStatus.Text = "";
            txtThongKe.Text = "";
            string[] listUrlImage = File.ReadLines(txtChooseFile.Text).ToArray();
            DateTime dt = DateTime.Now;
            Random rd = new Random();
            var successCount = 0;
            var failCount = 0;
            var count = listUrlImage.Length;
            //string result = "";
            using (WebClient webClient = new WebClient())
            {

                try
                {
                    //listStatus.View = View.List;
                    for (int j = 0; j < listUrlImage.Length; j++)
                    {
                        try
                        {
                            var sleepRandom = rd.Next(1, 10) * 100;
                            string fileName = Path.GetFileName(new UriBuilder(listUrlImage[j].ToString()).Path);
                            webClient.DownloadFile(listUrlImage[j].ToString(), "images\\" + fileName);
                            //listStatus.Items.Add(j+1 + "/" + count + " - " + listUrlImage[j].ToString() + " - download thành công");
                            //listStatus.Items[j].ForeColor = Color.Green;
                            listStatus.Text += j + 1 + "/" + count + " - " + listUrlImage[j].ToString() + " - download thành công\n";
                            successCount++;
                            Thread.Sleep(sleepRandom);
                        }
                        catch (Exception ex)
                        {
                            failCount++;
                            //listStatus.Items.Add(j+1 + "/" + count + " - " + listUrlImage[j].ToString() + " - bị lỗi " + ex.Message);
                            //listStatus.Items[j].ForeColor = Color.Red;
                            listStatus.Text += j + 1 + "/" + count + " - " + listUrlImage[j].ToString() + " - Lỗi " + ex.Message + "\n";
                            continue;
                        }
                    }
                    txtThongKe.Text = "Successed: " + successCount + "\tFailed: " + failCount + "\tTotal: "+count;
                    //listStatus.Text = result;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = openFileDialog.FileName;
                txtChooseFile.Text = fileName;
            }
        }
    }
}
