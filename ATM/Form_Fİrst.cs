using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form_First : Form
    {
        public Form_First()
        {
            InitializeComponent();
        }

        private void btn_With_Card_Click(object sender, EventArgs e)
        {
            Form_With_Card formWithCard = new Form_With_Card();
            formWithCard.Show();
            ///asas
        }
    }
}
