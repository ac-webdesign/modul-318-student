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

        private void getData(object sender, EventArgs e)
        {
            // Abfahrtmonitor Zeit und Datum eintragen
            labelTime.Text = DateTime.Now.ToShortTimeString(); // TODO: Refresh every Time
            labelDate.Text = DateTime.Now.ToShortDateString();

        }

        private void getAllStations(object sender, EventArgs e)
        {
            TextBox searchStation = (TextBox)sender;
            Stations allStations = transport.GetStations(searchStation.Text);

            foreach (var station in allStations.StationList)
            {
                listAllStationsFrom.Items.Add(station.Name);
                listAllStationsTo.Items.Add(station.Name);
            }
        }

        // TODO: Rows-Add-String beenden
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var allConnections = transport.GetConnections(txtStationFrom.Text, txtStationFrom.Text);

            // Verbindungen zu connectionTable integrieren
            foreach (var connection in allConnections.ConnectionList)
            {
                var createConnectionText = txtStationFrom.Text + "->" + txtStationFrom.Text;
                connectionsTable.Rows.Add("", createConnectionText, "", DateTime.Now.ToString(connection.Duration));
            }
        }
    }
}
