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
            // Listen deaktivieren
            listAllStationsFrom.Visible = false;
            listAllStationsTo.Visible = false;

            // Standardbreite für Spalten setzen
            connectionsTable.Columns[1].Width = 300;
            connectionsTable.Columns[2].Width = 302;
        }

        // TODO: Catch-Errors
        private void getDepatureMonitorData(object sender, EventArgs e)
        {
            TabControl page = (TabControl)sender;

            // Abfrage, ob richtige Page ausgewählt worden ist
            if (page.SelectedTab.Name != "Start")
            {
                setDefaultDepatureMonitorSettings();

                var allDepatureConnections = transport.GetStationBoard(listAllStationsFrom.SelectedItem.ToString(), 1.ToString());

                // Verbindungen zu connectionTable integrieren
                foreach (var station in allDepatureConnections.Entries)
                {
                    var depatureTime = station.Stop.Departure.ToShortTimeString();
                    depatureMonitorTable.Rows.Add(station.Name, station.To, depatureTime);
                }
            }
        }

        private void setDefaultDepatureMonitorSettings()
        {
            // Standardbreite für Spalten setzen
            depatureMonitorTable.Columns[0].Width = 300;
            depatureMonitorTable.Columns[1].Width = 300;
            depatureMonitorTable.Columns[2].Width = 300;

            // Abfahrtmonitor Stationsname, Zeit und Datum eintragen
            labelStationName.Text = listAllStationsFrom.SelectedItem.ToString();
            labelTime.Text = DateTime.Now.ToShortTimeString(); // TODO: Refresh every Time
            labelDate.Text = DateTime.Now.ToShortDateString();
        }

        // BUG renew Station every keydown change
        // TODO: Catch-Errors
        private void getAllStations(object sender, EventArgs e)
        {
            TextBox searchStation = (TextBox)sender;
            Stations allStations = transport.GetStations(searchStation.Text);

            foreach (var station in allStations.StationList)
            {
                if (searchStation.Name == "txtStationTo")  // TODO: Bessere Bedienungen
                {
                    listAllStationsTo.Items.Add(station.Name);
                    listAllStationsTo.Visible = true;
                }
                else
                {
                    listAllStationsFrom.Items.Add(station.Name);
                    listAllStationsFrom.Visible = true;
                }
            }
        }

        private void putToStation(object sender, EventArgs e)
        {
            ListBox selectedStation = (ListBox)sender;
            // Falls txtStationForm leer, wird der angebene Text integriert
            if (selectedStation.Name == "listAllStationsTo")  // TODO: Bessere Bedienungen
            {
                txtStationTo.Text = selectedStation.SelectedItem.ToString();
                listAllStationsTo.Visible = false;
            }
            else
            {
                txtStationFrom.Text = selectedStation.SelectedItem.ToString();
                listAllStationsFrom.Visible = false;
            }
        }

        // Klick-Zähler des Button damit Rows beim zweiten Mal gecleart werden
        int btnSearchClickCounter = 0;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var allConnections = transport.GetConnections(listAllStationsFrom.SelectedItem.ToString(), listAllStationsTo.SelectedItem.ToString());
            btnSearchClickCounter++;

            // Verbindungen von connectionTable beim zweiten Click clearen
            if (btnSearchClickCounter >= 2)
            {
                connectionsTable.Rows.Clear();
            }

            // Verbindungen zu connectionTable integrieren
            foreach (var connection in allConnections.ConnectionList)
            {
                var stationFormName = connection.From.Station.Name;
                var stationToName = connection.To.Station.Name;
                var depatureDate = Convert.ToDateTime(connection.From.Departure).ToShortDateString();
                var durationTime = connection.Duration.Replace('d', ' '); // Zeit noch formatieren
                connectionsTable.Rows.Add(depatureDate, stationFormName, stationToName, connection.From.Platform, durationTime);
            }
        }
    }
}
