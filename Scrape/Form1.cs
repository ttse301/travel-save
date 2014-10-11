using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void waitforload(int multiply)
        {
            for (int i = 0; i < 100000*multiply; i++ )
            {
                Application.DoEvents();
            }
        }

        HtmlElement chooseStation(bool second)
        {
            HtmlElementCollection stations = webBrowser1.Document.GetElementsByTagName("ul");

            textBox1.Text = stations.Count.ToString();

            HtmlElement stationselect = null;

            foreach (HtmlElement station in stations)
            {
                if (station.Children.Count > 20 && second == true)
                {
                    return station;
                }
                else if (station.Children.Count > 20 && second == false)
                {
                    second = !second;
                }
            }
            return null;
        }

        void click_station(string stationame, HtmlElement stationselect, Action scrape)
        {
            foreach (HtmlElement station in stationselect.Children)
            {
                station.Focus();
                station.InvokeMember("click");
                station.InvokeMember("mousedown");

                if (scrape != null)
                {
                    scrape();
                }

                if (station.InnerText == stationame)
                {
                    station.Focus();
                    textBox1.AppendText(station.InnerText);
                    station.InvokeMember("click");
                    waitforload(1);
                    break;
                }
            }
        }

        void click_submit()
        {
            webBrowser1.Document.GetElementById("frmFareCalculator:calculate").InvokeMember("click");
        }

        void scrapeData()
        {
            HtmlElement table_1 = webBrowser1.Document.GetElementById("frmFareCalculator:farelist:tbody_element");
            
            foreach (HtmlElement element in table_1.Children)
            {
                if (element.FirstChild.InnerText != "Return" && element.FirstChild.InnerText != "Off-peak return")
                {
                    
                }
            }

        }

        private void Go_Click(object sender, EventArgs e)
        {

            //string departure = "Hurstville";
            string arrival = "Central";

            webBrowser1.Document.GetElementById("txtArrive").Focus();
            webBrowser1.Document.GetElementById("txtArrive").InvokeMember("load");
            waitforload(2);
            //from here a new element will be created so reload is needed

            HtmlElement stationselect = chooseStation(true);
            click_station(arrival, stationselect, null);

            webBrowser1.Document.GetElementById("txtDeparture").Focus();
            webBrowser1.Document.GetElementById("txtDeparture").InvokeMember("load");
            waitforload(2);
            //from here a new element will .be created so reload is needed

            stationselect = chooseStation(false);
            waitforload(1);
            click_station("", stationselect, null);

            click_submit();

            waitforload(3);

            List<Train_Station> 

            scrapeData();

        }

    }
}
