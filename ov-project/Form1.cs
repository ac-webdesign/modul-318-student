using System;
using System.Linq;
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
                labelDepatureTime.Text = DateTime.Now.ToShortTimeString(); // TODO: Refresh every Time
                labelDepatureDate.Text = DateTime.Now.ToShortDateString();
            }
        }

        // TODO: BUG Fixing Speicher System.AccessViolationException"
        private void getAllStations(object sender, EventArgs e)
        {
            // In String Collection integriert damit Bug "System.AccessViolationException" gefixt wird
            AutoCompleteStringCollection stationsCollection = new AutoCompleteStringCollection();

            TextBox searchStation = (TextBox)sender;
            var allStations = transport.GetStations(searchStation.Text).StationList;

            stationsCollection.Clear();

            foreach (var station in allStations)
            {
              stationsCollection.Add(station.Name);
            }

            searchStation.AutoCompleteSource = AutoCompleteSource.CustomSource;
            searchStation.AutoCompleteCustomSource = stationsCollection;
        }

        // TODO: Try catch und Fehlerhandling
        private void btnSearchConnections_Click(object sender, EventArgs e)
        {
            var allConnections = transport.GetConnections(txtStationFrom.Text, txtStationTo.Text).ConnectionList;
            var connectionDepatureDate = Convert.ToDateTime(Convert.ToDateTime(dpConnectionDate.Text).ToShortDateString());
            var connectionDepatureTime = Convert.ToDateTime(Convert.ToDateTime(txtConnectionTime.Text).ToShortTimeString());

            var filteredConnectionsByDateAndTime = allConnections
            .Where(c =>
                Convert.ToDateTime(Convert.ToDateTime(c.From.Departure).ToShortDateString()) >= connectionDepatureDate &&
                Convert.ToDateTime(Convert.ToDateTime(c.From.Departure).ToShortTimeString()) >= connectionDepatureTime
             );

            counter++;

            // Verbindungen von connectionTable beim zweiten Click clearen
            if (counter >= 2)
            {
                connectionsTable.Rows.Clear();
            }

            // Verbindungen zu connectionTable integrieren
            foreach (var connection in filteredConnectionsByDateAndTime)
            {
                var stationFormName = connection.From.Station.Name;
                var stationToName = connection.To.Station.Name;
                var depatureDate = Convert.ToDateTime(connection.From.Departure).ToShortDateString();
                var depatureTime = Convert.ToDateTime(connection.From.Departure).ToShortTimeString();
                var durationTime = connection.Duration.Replace('d', ' '); // Zeit noch formatieren
                connectionsTable.Rows.Add(depatureDate, depatureTime, stationFormName, stationToName, connection.From.Platform, durationTime);
            }
        }

        private void getDepatureConnections(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Verbindungen zu depatureMonitorTable integrieren
                var allDepatureConnections = transport.GetStationBoard(txtDepatureFrom.Text).Entries;

                labelStationName.Text = txtDepatureFrom.Text;
                labelStationName.Visible = true;

                counter++;

                // Verbindungen von depatureMonitor beim zweiten Click clearen
                if (counter >= 2)
                {
                    depatureMonitorTable.Rows.Clear();
                }

                foreach (var station in allDepatureConnections)
                {
                    var depatureTime = station.Stop.Departure.ToShortTimeString();
                    depatureMonitorTable.Rows.Add(station.Name, station.To, depatureTime);
                }
            }
        }

        private void showDateAndTimeOption(object sender, EventArgs e)
        {
            labelConnectionDate.Visible = true;
            dpConnectionDate.Visible = true;
            labelConnectionTime.Visible = true;
            txtConnectionTime.Text = DateTime.Now.ToShortTimeString();
            txtConnectionTime.Visible = true;
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

        private void showDepatureDetails(object sender, DataGridViewCellEventArgs e)
        {
            viewDepatureDetails detailForm = new viewDepatureDetails();

            // Daten von Column zu DepatureDetailsForm hinzugefügt
            detailForm.labelTransportLine.Text = depatureMonitorTable.CurrentRow.Cells[0].Value.ToString();
            detailForm.labelDepatureFrom.Text = labelStationName.Text;
            detailForm.labelDepatureTo.Text = depatureMonitorTable.CurrentRow.Cells[1].Value.ToString();
            detailForm.txtDepatureDate.Text = labelDepatureDate.Text;
            detailForm.txtDepatureTime.Text = depatureMonitorTable.CurrentRow.Cells[2].Value.ToString();

            detailForm.ShowDialog();
        }
    }
}
