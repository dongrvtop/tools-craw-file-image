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
            string[] listUrlImage = File.ReadLines(@"E:\Tools Crawl file image\ListLink.txt").ToArray();
            DateTime dt = DateTime.Now;
            Random rd = new Random();
            var i = 0;
            var count = listUrlImage.Length;
            
            using (WebClient webClient = new WebClient())
            {

                try
                {
                    foreach (var item in listUrlImage)
                    {
                        i++;
                        try
                        {
                            var sleepRandom = rd.Next(1, 10)*100;
                            string fileName = Path.GetFileName(new UriBuilder(item.ToString()).Path);
                            webClient.DownloadFile(item.ToString(), "images\\" + fileName);
                            status.Items.Add(i + "/" + count + " - " + item.ToString() + " - download thành công");
                            Thread.Sleep(sleepRandom);
                        }
                        catch (Exception ex)
                        {
                            status.Items.Add(i +"/" + count + " - " + item.ToString() + " - bị lỗi "+ex.Message);
                            continue;
                        }
                       
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void status_DrawItem(object sender, DrawItemEventArgs e)
        {
            //e.DrawBackground();
            //Graphics g = e.Graphics;
            //Brush myBrush = Brushes.Black;
            //Brush myBrush2 = Brushes.Red;
            //g.FillRectangle(new SolidBrush(Color.Silver), e.Bounds);
            //e.Graphics.DrawString(status.Items[e.Index].ToString(), e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            //for (int i = 0; i < status.Items.Count; i++)
            //{
            //    if (listBox1.Items[i].ToString().Contains(existingStudents[j]))
            //    {
            //        e.Graphics.DrawString(listBox1.Items[i].ToString(),
            //        e.Font, myBrush2, e.Bounds, StringFormat.GenericDefault);
            //    }
            //}
        }
    }
}
