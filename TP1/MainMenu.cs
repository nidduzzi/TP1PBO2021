using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using Svg;
namespace TP1
{
    public partial class MainMenu : Form
    {
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
            // this.bt_catalouge.ImageAlign = ContentAlignment.MiddleLeft;

        }
    }
}
