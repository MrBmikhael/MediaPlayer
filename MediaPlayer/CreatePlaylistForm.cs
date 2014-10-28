using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class CreatePlaylistForm : Form
    {
        public CreatePlaylistForm()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;

            Playlist.createPlaylist(textBox1.Text);
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
