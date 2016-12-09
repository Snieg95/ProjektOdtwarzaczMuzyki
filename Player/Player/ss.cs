using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player
{
    public partial class ss : Form
    {
        public ss()
        {
            InitializeComponent();
        }

        private void ss_Load(object sender, EventArgs e)
        {

        }

        public static implicit operator Thread(ss v)
        {
            throw new NotImplementedException();
        }
    }
}
