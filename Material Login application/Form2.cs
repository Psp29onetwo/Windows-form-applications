using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Material_Login_application
{
    public partial class Welcome : MaterialForm
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            materialLabel1.BackColor = Color.Transparent;
            materialLabel1.ForeColor = Color.FromArgb(26, 49 ,70);
            materialLabel1.Font = new Font(FontFamily.GenericSansSerif, 24.0F, FontStyle.Bold);
        }
    }
}
