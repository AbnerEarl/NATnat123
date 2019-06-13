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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.AutoScroll = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.nat123.com/UsersReg.jsp");
            this.AutoScroll = true;
        }

        
    }
}
