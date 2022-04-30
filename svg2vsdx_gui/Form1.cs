using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace svg2vsdx_gui
{
    public partial class Svg2Vsdx : Form
    {
        public Svg2Vsdx()
        {
            InitializeComponent();
        }
        private string[] path;
        private int path_length = 0;
        private void Button_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Files (*.svg)|*.svg"//需要筛选svg文件
            };
            openFileDialog.Multiselect = true;
            string text = string.Empty;
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openFileDialog.FileNames;
                path_length = path.Length;
                runprocess.Text = "(0/" + path_length.ToString() + ")";
                for (int i = 0; i < path_length; i++)
                {
                    if (i == 0)
                        text = path[0];
                    else
                        text += (", " + path[i]);
                }
                textBox1.Text = text;
            }
        }

        private void Button_Run_Click(object sender, EventArgs e)
        {
            if (path_length <= 0)
                MessageBox.Show("文件为空或者已经转换完成！");
            else
            {
                progressBar1.Maximum = path_length;
                progressBar1.Value = 0;
                for (int i = 0; i < path_length; i++)
                {
                    int b = path[i].LastIndexOf('.');
                    string des = path[i].Substring(0, b);
                    des += ".vsdx";
                    try
                    {
                        VisioComObj.Svg2Vsd(path[i], des);
                    }
                    catch
                    {
                        MessageBox.Show(path[i] + "转换失败，是否继续", "错误", MessageBoxButtons.OKCancel);
                    }
                    progressBar1.Value += 1;
                    runprocess.Text = "(" + progressBar1.Value.ToString() + "/ " + path_length.ToString() + ")";
                }
                path_length = 0;
                MessageBox.Show("转换完成！");
            }
        }

        private void About1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("GUI作者：Kinglonh");
        }
    }
}
