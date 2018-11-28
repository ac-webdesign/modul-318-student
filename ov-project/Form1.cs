using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ov_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getStations(object sender, EventArgs e)
        {
            Transport transport = new Transport();
            Stations allStations =  transport.GetStations(1.ToString());
            // Stationen zu ComboBoxen stationForm & stationTo integrieren
           foreach (var station in allStations.StationList)
            {
                stationFrom.Items.Add(station.Name);
                stationTo.Items.Add(station.Name);
            }
        }
    }
}
