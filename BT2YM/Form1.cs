using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace BT2YM
{
    public partial class MainForm : Form
    {
        public List<string> TrekColors = new List<string>();
        public string FolderGPX;
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            KML YandexKML = new KML
            {
                Document = new Document
                {
                    Visibility = 1,
                    Name = new DescNameType { Content = txtName.Text },
                    Description = new DescNameType { Content = txtDescription.Text },
                    Folder = new Folder()
                }
            };
            foreach (CheckBox cb in this.Controls.OfType<CheckBox>())
                if (cb.Checked)
                {
                    string TransPercent = (int.Parse(lblTransPercent.Text.Substring(0,2)) / 25 * 64).ToString("X");
                    string abgr = TransPercent + 
                        cb.BackColor.B.ToString("X").PadLeft(2, '0') + 
                        cb.BackColor.G.ToString("X").PadLeft(2, '0') + 
                        cb.BackColor.R.ToString("X").PadLeft(2, '0');
                    TrekColors.Add(abgr);
                    YandexKML.AddLineStyle(abgr, abgr, 2);
                }
            if (TrekColors.Count == 0) return;
            string[] TrekColor = TrekColors.ToArray();
            int iLine = 0;
            foreach (object itemChecked in clbxFrom.CheckedItems)
            {
                YandexKML.AddLineString(
                    itemChecked.ToString().Replace(".gpx", ""), 
                    itemChecked.ToString().Replace(".gpx", ""), 
                    Path.Combine(FolderGPX, itemChecked.ToString()), 
                    "#"+ TrekColor[iLine % TrekColor.Length]);
                if (YandexKML.Document.Folder.Placemark[iLine].LineString.Coordinates.CT.Length > 1000)
                    YandexKML.CurveLine(iLine);
                iLine++;
                if (iLine > 30) break;
            }
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings()
            {
                CloseOutput = false,
                Encoding = Encoding.GetEncoding("utf-8"),
                OmitXmlDeclaration = true,
                Indent = true
            };
            using (XmlWriter xw = XmlWriter.Create(Path.Combine(Directory.GetCurrentDirectory(), String.Format("YM\\{0}.kml", txtName.Text)), xmlWriterSettings))
            {
                XmlSerializer s = new XmlSerializer(typeof(KML));
                s.Serialize(xw, YandexKML);
            }
            TrekColors.Clear();
        }

        private void btnSelectDir_Click(object sender, EventArgs e)
        {
            if (fbdFrom.ShowDialog() == DialogResult.OK)
                FolderGPX = fbdFrom.SelectedPath;
            string[] FromGPX = Directory.GetFiles(FolderGPX);
            clbxFrom.Items.AddRange(FromGPX.Select(fn => fn.Replace(FolderGPX + "\\", "")).ToArray());
            clbxFrom.CheckOnClick = true;
        }

        private void btnTransMinus_Click(object sender, EventArgs e)
        {
            if (lblTransPercent.Text!="10%")
                lblTransPercent.Text = String.Format("{0}%", int.Parse(lblTransPercent.Text.Substring(0, 2)) - 10);
        }

        private void btnTransPlus_Click(object sender, EventArgs e)
        {
            if (lblTransPercent.Text != "90%")
                lblTransPercent.Text = String.Format("{0}%", int.Parse(lblTransPercent.Text.Substring(0, 2)) + 10);
        }

        //  LightSalmon #FFA07A	    rgb(255,160,122)
        //	LightCoral  #F08080 	rgb(240,128,128)
        //  Chocolate	
        //  Firebrick  	#B22222 	rgb(178,34,34)
        //	Red         #FF0000 	rgb(255,0,0)
        //	DarkRed     #8B0000 	rgb(139,0,0)
        //	OrangeRed   #FF4500 	rgb(255,69,0)
        //  Gold 	    #FFD700 	rgb(255,215,0)
        //  Orange 	    #FFA500 	rgb(255,165,0)
        //  Khaki 	    #F0E68C 	rgb(240,230,140)
        //	Yellow 	    #FFFF00 	rgb(255,255,0)
        //	Lime 	    #00FF00 	rgb(0.255.0)
        //	Green 	    #008000 	rgb(0,128,0)
        //	DarkGreen 	#006400 	rgb(0,100,0)
        //	YellowGreen	#9ACD32 	rgb(154,205,50)
        //	SpringGreen	#00FF7F 	rgb(0,255,127)
        //	Olive 	    #808000 	rgb(128,128,0)
        //  Cyan 	    #00FFFF 	rgb(0,255,255)
        //	Aquamarine 	#7FFFD4 	rgb(127,255,212)
        //	DimGray 	
        //  CadetBlue 	#5F9EA0 	rgb(95,158,160)
        //	Teal 	    #008080 	rgb(0,128,128)
        //	DeepSkyBlue	#00BFFF 	rgb(0,191,255)
        //	SteelBlue 	#4682B4 	rgb(70,130,180)
        //	Blue 	    #0000FF 	rgb(0,0,255)
        //	Navy 	    #000080 	rgb(0,0,128)
        //	Magenta 	#FF00FF 	rgb(255,0,255)
        //	Purple 	    #800080 	rgb(128,0,128)
        //	Indigo 	    #4B0082 	rgb(75,0,130)
        //	Pink 	    #FFC0CB 	rgb(255,192,203)
        //	Gray 	    #808080 	rgb(128,128,128)
    }
}
