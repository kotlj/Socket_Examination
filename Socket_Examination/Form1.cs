using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socket_Examination
{
    public partial class Form1 : Form
    {
        List<Task> tasks = new List<Task>();
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private async void Dowload_Click(object sender, EventArgs e)
        {
            if (LocAddrBox.Text != null && URLBox.Text != null)
            {
                tasks.Add(preStart(URLBox.Text, LocAddrBox.Text));
                DowloadList.Items.Add($"{tasks.LastOrDefault().ToString()} status: {tasks.LastOrDefault().Status}");
            }
        }

        async Task preStart(string Url, string savePath)
        {
            /* URL файлу для завантаження */
            string fileUrl = Url;
            // Локальний шлях та ім'я файлу для збереження
            string filePath = savePath; // Замініть на потрібне ім'я файлу із вказівкою розширення

            try
            {
                await DownloadFileAsync(fileUrl, filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні: {ex.Message}");
            }
        }
        async Task DownloadFileAsync(string fileUrl, string filePath)
        {
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(fileUrl, HttpCompletionOption.ResponseHeadersRead))
            using (Stream streamToReadFrom = await response.Content.ReadAsStreamAsync())
            {
                if (response.IsSuccessStatusCode)
                {
                    using (Stream streamToWriteTo = File.Open(filePath, FileMode.Create))
                    {
                        await streamToReadFrom.CopyToAsync(streamToWriteTo);
                    }
                    fileList1.Items.Add(filePath);
                }
                else
                {
                    throw new HttpRequestException($"Помилка при завантаженні. Статус код: {response.StatusCode}");
                }
            }
        }

        private void change_Click(object sender, EventArgs e)
        {
            if (FileName != null)
            {
                if (Change.Text != null)
                {
                    if (fileList1.SelectedItem != null && fileList1.Items.Count > 0)
                    {
                        if (File.Exists(fileList1.SelectedItem.ToString()))
                        File.Move(fileList1.SelectedItem.ToString(), FileName.Text);
                        int indx = fileList1.Items.IndexOf(fileList1.SelectedItem.ToString());
                        fileList1.Items.RemoveAt(indx);
                        fileList1.Items.Insert(indx, FileName.Text);
                    }
                }
            }
        }

        private void LocAddrBox_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LocAddrBox.Text = saveFileDialog1.FileName;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DowloadList.Items.Clear();
            foreach(var tsk in tasks)
            {
                DowloadList.Items.Add($"{tsk.ToString()} Status: {tsk.Status}");
            }
        }

        private void FileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fileList1 != null && fileList1.Items.Count != 0)
            {
                FileName.Text = fileList1.SelectedItem.ToString();
            }
        }

        private void FileToList(string filePath)
        {
            if (File.Exists(filePath))
            {
                fileList1.Items.Add(filePath);
            }
        }
    }
}
