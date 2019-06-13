using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NATnat123
{
    public partial class Form1 : Form
    {
        private static System.Diagnostics.Process process;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "/NAT123/nat123client.exe";
            try
            {
                if (process == null)
                {
                    process = new System.Diagnostics.Process();
                    process.StartInfo.FileName =path;
                    process.Start();
                }
                else
                {
                    if (process.HasExited) //是否正在运行
                    {
                        process.Start();
                    }
                }
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
