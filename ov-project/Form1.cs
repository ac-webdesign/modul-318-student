using System;
using System.Windows.Forms;
using SwissTransport;

namespace ov_project
{
    public partial class ovForm : Form
    {
        Transport transport = new Transport();

        // Zähler damit Rows beim zweiten Mal gecleart werden
        int counter = 0;


        public ovForm()
        {
            InitializeComponent();
        }

        private void setFormSettings(object sender, EventArgs e)
        {
            // Standardbreite von Formular setzen
            ovForm form = (ovForm)sender;
            form.Width = 1000;
            form.Height = 600;

            // Standardbreite für Spalten setzen
            connectionsTable.Columns[2].Width = 300;
            connectionsTable.Columns[3].Width = 302;
        }

        // TODO: Catch-Errors
        private void setDepatureMonitorSettings(object sender, EventArgs e)
        {
            TabControl page = (TabControl)sender;

            // Abfrage, ob richtige Page ausgewählt worden ist
            if (page.SelectedTab.Name != "Start")
            {
                // Standardbreite für Spalten setzen
                depatureMonitorTable.Columns[0].Width = 300;
                depatureMonitorTable.Columns[1].Width = 300;
                depatureMonitorTable.Columns[2].Width = 300;

                // Abfahrtmonitor Zeit und Datum eintragen
                labelTime.Text = DateTime.Now.ToShortTimeString(); // TODO: Refresh every Time
                labelDate.Text = DateTime.Now.ToShortDateString();
            }
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
                showDepatureDateAndTimeOption();
            }
            else if (selectedStation.Name == "listAllStationsFrom")
            {
                txtStationFrom.Text = selectedStation.SelectedItem.ToString();
                listAllStationsFrom.Visible = false;
                showDepatureDateAndTimeOption();
            }
            else
            {
                txtDepature.Text = selectedStation.SelectedItem.ToString();
                labelStationName.Text = txtDepature.Text;
                labelStationName.Visible = true;
                listDepature.Visible = false;

                counter++;

                // Verbindungen von depatureMonitor beim zweiten Click clearen
                if (counter >= 2)
                {
                    depatureMonitorTable.Rows.Clear();
                }


                // Verbindungen zu depatureMonitorTable integrieren
                var allDepatureConnections = transport.GetStationBoard(listDepature.SelectedItem.ToString());

                foreach (var station in allDepatureConnections.Entries)
                {
                    var depatureTime = station.Stop.Departure.ToShortTimeString();
                    depatureMonitorTable.Rows.Add(station.Name, station.To, depatureTime);
                }
            }
        }

        private void showDepatureDateAndTimeOption()
        {
            labelDepatureDate.Visible = true;
            dpDepatureDate.Visible = true;
            labelDepatureTime.Visible = true;
            txtDepatureTime.Text = DateTime.Now.ToShortTimeString();
            txtDepatureTime.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var allConnections = transport.GetConnections(listAllStationsFrom.SelectedItem.ToString(), listAllStationsTo.SelectedItem.ToString()).ConnectionList;

            counter++;

            // Verbindungen von connectionTable beim zweiten Click clearen
            if (counter >= 2)
            {
                connectionsTable.Rows.Clear();
            }

            // Verbindungen zu connectionTable integrieren
            foreach (var connection in allConnections)
            {
                var stationFormName = connection.From.Station.Name;
                var stationToName = connection.To.Station.Name;
                var depatureDate = Convert.ToDateTime(connection.From.Departure).ToShortDateString();
                var depatureTime = Convert.ToDateTime(connection.From.Departure).ToShortTimeString();
                var durationTime = connection.Duration.Replace('d', ' '); // Zeit noch formatieren
                connectionsTable.Rows.Add(depatureDate, depatureTime, stationFormName, stationToName, connection.From.Platform, durationTime);
            }
        }

        private void showConnectionDetails(object sender, DataGridViewCellEventArgs e)
        {
            viewConnectionDetails detailForm = new viewConnectionDetails();

            // Daten von Column zu ConnectionDetailForm hinzugefügt
            detailForm.labelStationFrom.Text = connectionsTable.CurrentRow.Cells[2].Value.ToString();
            detailForm.labelStationTo.Text = connectionsTable.CurrentRow.Cells[3].Value.ToString();
            detailForm.txtDepatureDate.Text = connectionsTable.CurrentRow.Cells[0].Value.ToString();
            detailForm.txtDepatureTime.Text = connectionsTable.CurrentRow.Cells[1].Value.ToString();
            detailForm.txtDepatureDuration.Text = connectionsTable.CurrentRow.Cells[5].Value.ToString();
            detailForm.txtDepaturePlattform.Text = connectionsTable.CurrentRow.Cells[4].Value.ToString();

            detailForm.ShowDialog();
        }
    }
}
