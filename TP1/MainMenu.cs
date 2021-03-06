using Svg;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace TP1
{
    public partial class MainMenu : Form
    {
        private item_box[] items;
        private int itemNum;
        private object viewedItemBtn;
        private object viewedItemBox;
        private void items_showDetails(object sender, EventArgs e)
        {
            //track the event trigger
            this.viewedItemBtn = sender;
            this.viewedItemBox = ((Button)this.viewedItemBtn).Parent.Parent;
            // hide sidebar combo boxes
            this.cb_harga.Visible = false;
            this.cb_jenis.Visible = false;
            //repurpose search button for back
            this.bt_search.Text = "Kembali";
            this.bt_search.Click -= bt_searchClick;
            this.bt_search.Click += showHome;
            //change menu lable
            this.lb_menuDetail.Text = "Detail barang:";
            //disable the trigger button (beli)
            ((Button)this.viewedItemBtn).Enabled = false;
            // undock and unanchor it's parent
            ((item_box)this.viewedItemBox).Dock = DockStyle.None;
            ((item_box)this.viewedItemBox).Anchor = AnchorStyles.None;
            //remove the viewed item from the item table
            this.item_table.Controls.Clear();
            // replace where the item table was with the parent of the sender object
            this.menu_table.Controls.Remove(this.item_table);
            this.menu_table.Controls.Add(((Button)this.viewedItemBtn).Parent.Parent);
        }

        private void showHome(object sender, EventArgs e)
        {
            if (this.viewedItemBtn != null)
            {
                // unhide item table
                this.item_table.Visible = true;
                // unhide sidebar combo boxes
                this.cb_harga.Visible = true;
                this.cb_jenis.Visible = true;
                //repurpose  back button for search
                this.bt_search.Text = "Cari";
                this.bt_search.Click -= showHome;
                this.bt_search.Click += bt_searchClick;
                //reenable the detailed item's buy button
                ((Button)this.viewedItemBtn).Enabled = true;
                //redock and reanchor the viewed item
                ((item_box)this.viewedItemBox).ResumeLayout();
                ((item_box)this.viewedItemBox).Dock = DockStyle.Fill;
                //remove the viewed item from the menu table
                this.menu_table.Controls.Clear();
                //readd the viewed item to the item table
                this.item_table.Controls.Clear();
                foreach (item_box item in this.items)
                {
                    this.item_table.Controls.Add(item);
                }
                // readd the item table to the menu table
                this.menu_table.Controls.Add(this.lb_menuDetail);
                this.menu_table.Controls.Add(this.item_table);
                this.lb_menuDetail.Text = "Semua Barang:";
                this.viewedItemBox = null;
                this.viewedItemBtn = null;
            }
        }

        private void bt_catalougeClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.amazon.com");
        }

        private void bt_logoutClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_searchClick(object sender, EventArgs e)
        {
            this.item_table.Controls.Clear();
            List<int> idx = new List<int>();
            // Filter harga
            switch (this.cb_harga.SelectedIndex)
            {
                case 0:
                    for (int i = 0; i < this.itemNum; ++i)
                    {
                        if (this.items[i].HargaBarang >= 100000 && this.items[i].HargaBarang <= 200000) idx.Add(i);
                    }
                    break;
                case 1:
                    for (int i = 0; i < this.itemNum; ++i)
                    {
                        if (this.items[i].HargaBarang >= 200000 && this.items[i].HargaBarang <= 500000) idx.Add(i);
                    }
                    break;
                case 2:
                    for (int i = 0; i < this.itemNum; ++i)
                    {
                        if (this.items[i].HargaBarang >= 500000 && this.items[i].HargaBarang <= 1000000) idx.Add(i);
                    }
                    break;
                default:
                    // No filter selection, show all
                    for (int i = 0; i < this.itemNum; ++i)
                    {
                        idx.Add(i);
                    }
                    break;
            }
            // Filter jenis
            if (this.cb_jenis.SelectedIndex == -1 || this.cb_jenis.SelectedIndex == 3)
            {
                // No filter selection, show all
                foreach (var item in idx)
                {
                    this.item_table.Controls.Add(items[item]);
                }
            }
            else
            {
                foreach (var item in idx)
                {
                    if (this.items[item].JenisBarang == this.cb_jenis.SelectedIndex) this.item_table.Controls.Add(items[item]);
                }
            }
        }

        public MainMenu()
        {
            InitializeComponent();
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase).Replace("\\bin\\Debug", "").Replace("\\bin\\Release", "");
            this.bt_logo.Image = SvgDocument.Open<SvgDocument>(Path.Combine(outPutDirectory, "Resources\\face-24px.svg").Replace("file:\\", "")).Draw();
            this.bt_home.Image = SvgDocument.Open<SvgDocument>(Path.Combine(outPutDirectory, "Resources\\home-24px.svg").Replace("file:\\", "")).Draw();
            this.bt_catalouge.Image = SvgDocument.Open<SvgDocument>(Path.Combine(outPutDirectory, "Resources\\dashboard-24px.svg").Replace("file:\\", "")).Draw();
            this.bt_logout.Image = SvgDocument.Open<SvgDocument>(Path.Combine(outPutDirectory, "Resources\\logout-24px.svg").Replace("file:\\", "")).Draw();
            this.bt_home.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.bt_catalouge.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.bt_logout.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.DialogResult = DialogResult.OK;
            this.viewedItemBtn = null;
            this.itemNum = 8;
            this.items = new item_box[itemNum];
            for (int i = 0; i < this.itemNum; ++i)
            {
                this.items[i] = new item_box();
                this.items[i].Dock = DockStyle.Fill;
                this.items[i].button1.Click += items_showDetails;
                this.items[i].IdBarang = i;
            }
            this.items[0].GambarBarang = Properties.Resources.battlecreek_coffee_roasters;
            this.items[0].NamaBarang = "Battlecreek Coffee";
            this.items[0].HargaBarang = 172000;
            this.items[0].JenisBarang = 2;

            this.items[1].GambarBarang = Properties.Resources.revolt;
            this.items[1].NamaBarang = "Nike Revolt";
            this.items[1].HargaBarang = 385000;
            this.items[1].JenisBarang = 1;

            this.items[2].GambarBarang = Properties.Resources.caroline_attwood;
            this.items[2].NamaBarang = "Chatruse Caroline Attwood";
            this.items[2].HargaBarang = 166000;
            this.items[2].JenisBarang = 4;

            this.items[3].GambarBarang = Properties.Resources.eniko_kis;
            this.items[3].NamaBarang = "Einko Kis Classic";
            this.items[3].HargaBarang = 1000000;
            this.items[3].JenisBarang = 0;

            this.items[4].GambarBarang = Properties.Resources.c_d_x_PDX_a;
            this.items[4].NamaBarang = "CDX Headphones";
            this.items[4].HargaBarang = 500000;
            this.items[4].JenisBarang = 0;

            this.items[5].GambarBarang = Properties.Resources.giorgio_trovato;
            this.items[5].NamaBarang = "Trovato ed. Raybans";
            this.items[5].HargaBarang = 700000;
            this.items[5].JenisBarang = 1;

            this.items[6].GambarBarang = Properties.Resources.kaleb_tapp;
            this.items[6].NamaBarang = "Jenuin Crimson Berry";
            this.items[6].HargaBarang = 140000;
            this.items[6].JenisBarang = 2;

            this.items[7].GambarBarang = Properties.Resources.jakob_owens;
            this.items[7].NamaBarang = "Jakob Owens Backpack";
            this.items[7].HargaBarang = 800000;
            this.items[7].JenisBarang = 1;

            foreach (Control item in items)
            {
                this.item_table.Controls.Add(item);
            }
        }

    }
}
