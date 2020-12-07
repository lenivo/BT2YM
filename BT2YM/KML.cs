using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Globalization;
using System.Xml.Serialization;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

namespace BT2YM
{
    [Serializable]
    [XmlRootAttribute("kml", Namespace = "http://www.opengis.net/kml/2.2")]
    public class KML
    {
        public Document Document;
        public KML() 
        {
        }
        public void AddLineStyle(string LineId, string LineColor, int LineWidth)
        {
            Document.Style.Add(new Style { Id = LineId, LineStyle = new LineStyle { Color = LineColor, Width = LineWidth }});
        }
        public void AddLineString(string PM_Name, string PM_Desc, string GPX_File, string LineStyleUrl)
        {
            Document.Folder.Placemark.Add(new Placemark
            {
                Name = new DescNameType {Content = PM_Name},
                Description = new DescNameType {Content = PM_Desc},
                LineString = new LineString {Coordinates = new Coords {CT = KML_Coords(GPX_File)}},
                StyleURL = LineStyleUrl
            });
        }
        public CoordTime[] KML_Coords(string GPX_File)
        {
            XmlDocument xDocGPX = new XmlDocument();
            xDocGPX.Load(GPX_File);
            XmlNodeList xnlNodeList = xDocGPX.GetElementsByTagName("rtept");
            if (xnlNodeList.Count == 0)
                xnlNodeList = xDocGPX.GetElementsByTagName("trkpt");
            if (xnlNodeList.Count == 0)
                return null;
            CoordTime[] KML_Coords = new CoordTime[xnlNodeList.Count];
            int i = 0;
            foreach (XmlNode xnPoint in xnlNodeList)
            {
                NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
                CoordTime nCoords = new CoordTime
                {
                    lat = double.Parse(xnPoint.Attributes["lat"].Value, nfi),
                    lon = double.Parse(xnPoint.Attributes["lon"].Value, nfi),
                    time = xnPoint.ChildNodes.Count > 0 ? DateTime.Parse(xnPoint.ChildNodes[0].InnerText) : DateTime.Parse("0001.01.01")
                };
                KML_Coords[i] = nCoords;
                    i++;
            }
            return KML_Coords;
        }
        public void CurveLine(int NumLine)
        {
            CoordTime[] OldCT = Document.Folder.Placemark[NumLine].LineString.Coordinates.CT;
            int Q1000 = 1 + OldCT.Length / 1000;
            CoordTime[] NewCT = new CoordTime[1 + OldCT.Length / Q1000];
            for (int i = 0; i < NewCT.Length-1; i++)
                NewCT[i] = OldCT[i * Q1000];
            NewCT[NewCT.Length-1] = OldCT[OldCT.Length-1];
            Document.Folder.Placemark[NumLine].LineString.Coordinates.CT = NewCT;
        }
    }
    public class Document
    {
        [XmlElement("visibility")]
        public int Visibility;
        [XmlElement]
        public List<Style> Style = new List<Style>();
        [XmlElement("name")]
        public DescNameType Name { get; set; }
        [XmlElement("description")]
        public DescNameType Description { get; set; }
        public StyleMap StyleMap;
        public Folder Folder;
    }
    public class DescNameType
    {
        [XmlIgnore]
        public string Content { get; set; }

        [XmlText]
        public XmlNode[] CDataContent
        {
            get
            {
                if (Content != null)
                {
                    var dummy = new XmlDocument();
                    return new XmlNode[] { dummy.CreateCDataSection(Content) };
                }
                else
                    return null;
            }
            set
            {
                if (value == null)
                {
                    Content = null;
                    return;
                }

                if (value.Length != 1)
                {
                    throw new InvalidOperationException(
                        String.Format(
                            "Invalid array length {0}", value.Length));
                }
                var node0 = value[0];
                if (node0 == null)
                {
                    throw new InvalidOperationException(
                        String.Format(
                            "Invalid node type {0}", node0.NodeType));
                }
                Content = node0.Value;
            }
        }
    }
    public class Folder
    {
        [XmlElement]
        public List<Placemark> Placemark=new List<Placemark>();
    }
    public class Style
    {
        [XmlAttribute("id")]
        public string Id;
        [XmlElement("IconStyle", IsNullable = false)]
        public IconStyle IconStyle;
        [XmlElement("LineStyle", IsNullable = false)]
        public LineStyle LineStyle;
        [XmlElement("PolyStyle", IsNullable = false)]
        public PolyStyle PolyStyle;
    }
    public class IconStyle
    {
        public Icon Icon;
    }
    public class Icon
    {
        [XmlElement("href")]
        public string Href;
    }
    public class LineStyle
    {
        [XmlElement("color")]
        public string Color;
        [XmlElement("width")]
        public int Width;
    }
    public class PolyStyle
    {
        [XmlElement("color")]
        public string Color;
        [XmlElement("fill")]
        public int Fill;
        [XmlElement("outline")]
        public int Outline;
    }
    public class StyleMap
    {
        [XmlAttribute("id")]
        public string Id;
        public Pair Pair;
    }
    public class Pair
    {
        public string Key;
        public string styleUrl;
    }
    public class Placemark
    {
        [XmlElement("name")]
        public DescNameType Name { get; set; }
        [XmlElement("description")]
        public DescNameType Description { get; set; }
        [XmlElement("styleUrl", IsNullable = false)]
        public string StyleURL;
        [XmlElement("LineString", IsNullable = false)]
        public LineString LineString;
        [XmlElement("Point", IsNullable = false)]
        public Point Point;
        [XmlElement("Polygon", IsNullable = false)]
        public Polygon Polygon;
    }
    public class LineString
    {
        [XmlElement("coordinates")]
        public Coords Coordinates;
    }
    public class Point
    {
        [XmlElement("coordinates")]
        public Coords Coordinates;
    }
    public class Polygon
    {
        [XmlElement("outerBoundaryIs")]
        public OuterBoundaryIs OuterBoundaryIs;
    }
    public class OuterBoundaryIs
    {
        [XmlElement("LinearRing")]
        public LinearRing LinearRing;
    }
    public class LinearRing
    {
        [XmlElement("coordinates")]
        public Coords Coordinates;
    }
    public class Coords
    {
        [XmlIgnore]
        public CoordTime[] CT { get; set; }
        [XmlText]
        public string coords
        {
            get
            {
                NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
                return string.Join(" ", CT.Select(c=>c.lon.ToString(nfi) + "," + c.lat.ToString(nfi)));
            }
            set
            {
                string[] LatLon = value.Split(' ').ToArray();
                CT = new CoordTime[LatLon.Length];
                for(int i=0; i<LatLon.Length; i++)
                {
                    NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
                    CoordTime nCoords = new CoordTime
                    {
                        lat = double.Parse(LatLon[i].Split(',')[0], nfi),
                        lon = double.Parse(LatLon[i].Split(',')[1], nfi)
                    };
                    //nCoords.time = DateTime.Parse(xnTrkpt.ChildNodes[0].InnerText);
                    CT[i]=nCoords;
                }
            }
        }
    }
    public class CoordTime
    {
        public double lat { get; set; }
        public double lon { get; set; }
        public DateTime time { get; set; }
    }

}
