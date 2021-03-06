using System.Drawing;
using System.Windows.Forms;

namespace TP1
{
    public partial class item_box : UserControl
    {
        private int harga;
        private string nama;
        private Bitmap bitmap;
        private int jenis;
        private int id;
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

        public int JenisBarang
        {
            get
            {
                return this.jenis;
            }
            set
            {
                this.jenis = value;
            }
        }

        public int IdBarang
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public item_box()
        {
            InitializeComponent();
            this.pb_item.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
