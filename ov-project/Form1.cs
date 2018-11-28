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
        Transport transport = new Transport();

        public Form1()
        {
            InitializeComponent();
        }

        // TODO: Filterung & Alle Stationen bekommen
        private void getStations(object sender, EventArgs e)
        {
            Stations allStations = transport.GetStations(1.ToString());
            // Stationen zu ComboBoxen stationForm & stationTo integrieren
            foreach (var station in allStations.StationList)
            {
                stationFrom.Items.Add(station.Name);
                stationTo.Items.Add(station.Name);
            }
        }

        // TODO: Rows-Add-String beenden
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var allConnections = transport.GetConnections(stationFrom.SelectedItem.ToString(), stationTo.SelectedItem.ToString());
            // Verbindungen zu connectionTable integrieren
            foreach (var connection in allConnections.ConnectionList)
            {
                var createConnectionText = stationFrom.SelectedItem.ToString() + "->" + stationTo.SelectedItem.ToString();
                connectionsTable.Rows.Add("", createConnectionText, "", DateTime.Now.ToString(connection.Duration));
            }
        }
    }
}
