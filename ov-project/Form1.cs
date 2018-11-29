﻿using System;
using System.Windows.Forms;
using SwissTransport;

namespace ov_project
{
    public partial class ovForm : Form
    {
        Transport transport = new Transport();

        public ovForm()
        {
            InitializeComponent();
        }

        private void getData(object sender, EventArgs e)
        {
            // Standardbreite von Formular setzen
            ovForm form = (ovForm)sender;
            form.Width = 1000;
            form.Height = 600;

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
            }
        }

        private void setDefaultDepatureMonitorSettings()
        {
            // Liste und Stationsname deaktivieren
            labelStationName.Visible = false;
            listDepature.Visible = false;

            // Standardbreite für Spalten setzen
            depatureMonitorTable.Columns[0].Width = 300;
            depatureMonitorTable.Columns[1].Width = 300;
            depatureMonitorTable.Columns[2].Width = 300;

            // Abfahrtmonitor Zeit und Datum eintragen
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
                else if(searchStation.Name == "txtStationFrom")
                {
                    listAllStationsFrom.Items.Add(station.Name);
                    listAllStationsFrom.Visible = true;
                } else
                {
                    listDepature.Items.Add(station.Name);
                    listDepature.Visible = true;
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
            else if (selectedStation.Name == "listAllStationsFrom")
            {
                txtStationFrom.Text = selectedStation.SelectedItem.ToString();
                listAllStationsFrom.Visible = false;
            }
            else
            {
                txtDepature.Text = selectedStation.SelectedItem.ToString();
                labelStationName.Text = txtDepature.Text;
                labelStationName.Visible = true;
                listDepature.Visible = false;

                // Verbindungen zu depatureMonitorTable integrieren
                var allDepatureConnections = transport.GetStationBoard(listDepature.SelectedItem.ToString(), 1.ToString());
                foreach (var station in allDepatureConnections.Entries)
                {
                    var depatureTime = station.Stop.Departure.ToShortTimeString();
                    depatureMonitorTable.Rows.Add(station.Name, station.To, depatureTime);
                }
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
