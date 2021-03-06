using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace item_box
{
    public partial class item_box : UserControl
    {
        private int harga;
        private string nama;
        private Bitmap bitmap;

        public int HargaBarang
        {
            get
            {
                return this.harga;
            }
            set
            {
                this.harga = value;
                this.lb_harga.Text = "Rp." + value.ToString();
            }
        }

        public string NamaBarang
        {
            get
            {
                return this.nama;
            }
            set
            {
                this.nama = value;
                this.lb_nama.Text = value;
            }
        }

        public Bitmap GambarBarang
        {
            get
            {
                return this.bitmap;
            }

            set
            {
                this.bitmap = value;
                this.pb_item.Image = value;
            }
        }
        public item_box()
        {
            InitializeComponent();
            this.pb_item.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
