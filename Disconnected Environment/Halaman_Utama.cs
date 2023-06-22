using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconnected_Environment
{
    public partial class Halaman_Utama : Form
    {
        public Halaman_Utama()
        {
            InitializeComponent();
        }

        private void Halaman_Utama_Load(object sender, EventArgs e)
        {

        }

        private void dataProdiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Halaman_prodi hp = new Halaman_prodi();
            hp.Show();
            this.Hide();
        }

        private void dataMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Halaman_mahasiswa hm = new Halaman_mahasiswa();
            hm.Show();
            this.Hide();
        }

        private void dataStatusMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Halaman_Status_Mahasiswa hs = new Halaman_Status_Mahasiswa();
            hs.Show();
            this.Hide();
        }
    }
}
