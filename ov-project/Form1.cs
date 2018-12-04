using System;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using SwissTransport;

namespace ov_project
{
    public partial class ovForm : Form
    {
        public ovForm()
        {
            InitializeComponent();
        }

        private void setDepatureMonitorSettings(object sender, EventArgs e)
        {
            TabControl page = (TabControl)sender;

            // Abfrage, ob richtige Page ausgewählt worden ist
            if (page.SelectedTab.Name != "Start")
            {
                // Abfahrtmonitor Zeit und Datum eintragen
                labelDepatureTime.Text = DateTime.Now.ToShortTimeString();
                labelDepatureDate.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void getAllStations(object sender, EventArgs e)
        {
            TextBox txtSearchedStation = (TextBox)sender;
            if (txtSearchedStation.Name == txtStationFrom.Name)
            {
                getStationsByCorrectTextbox(txtSearchedStation, listStationFrom);
            }
            if (txtSearchedStation.Name == txtStationTo.Name)
            {
                getStationsByCorrectTextbox(txtSearchedStation, listStationTo);
            }
            if (txtSearchedStation.Name == txtDepatureFrom.Name)
            {
                getStationsByCorrectTextbox(txtSearchedStation, listDepatureFrom);
            }
        }

        private void getStationsByCorrectTextbox(TextBox txtStationInput, ListBox list)
        {
            if (String.IsNullOrEmpty(txtStationInput.Text))
            {
                txtStationInput.BackColor = Color.Red;
            }
            else
            {
                // Liste anzeigen und cleearen
                list.Visible = true;
                list.Items.Clear();

                // Textbox-Farbe zurücksetzen
                txtStationInput.BackColor = Color.White;

                // Stationen anzeigen
                Transport transport = new Transport();
                var allStationConnections = transport.GetStations(txtStationInput.Text).StationList;

                foreach (var station in allStationConnections)
                {
                    list.Items.Add(station.Name);
                }
            }
        }

        private void putSelectedStationToCorrectTextbox(object sender, EventArgs e)
        {
            ListBox selectedListBox = (ListBox)sender;
            if (selectedListBox.Name == listStationFrom.Name)
            {
                putToTextbox(txtStationFrom, selectedListBox);
                btnLocationOfStationFrom.Visible = true;
            }
            else if (selectedListBox.Name == listStationTo.Name)
            {
                putToTextbox(txtStationTo, selectedListBox);
                btnLocationOfStationTo.Visible = true;
            }
            else
            {
                putToTextbox(txtDepatureFrom, selectedListBox);
                getDepatureConnections();
            }
        }

        private void putToTextbox(TextBox textBox, ListBox selectedListBox)
        {
            textBox.Text = selectedListBox.SelectedItem.ToString();
            selectedListBox.Visible = false;
        }

        private void btnSearchConnections_Click(object sender, EventArgs e)
        {
            // Clear Providers
            stationToIsEqualStationFrom.Clear();
            falseFromatProvider.Clear();

            if (String.IsNullOrEmpty(txtStationFrom.Text) || String.IsNullOrEmpty(txtStationTo.Text))
            {
                txtStationFrom.BackColor = Color.Red;
                txtStationTo.BackColor = Color.Red;
            } else if (txtStationFrom.Text == txtStationTo.Text)
            {
                stationToIsEqualStationFrom.SetError(txtStationTo, "Gleiche Station ausgewählt");
            } else if (listStationFrom.Visible == true || listStationTo.Visible == true)
            {
                MessageBox.Show("Bitte wählen Sie eine Station/en", "Keine Station/en ausgewählt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                try
                {
                    // Zeit und Datum formatieren
                    var connectionDepatureDate = Convert.ToDateTime(dpConnectionDate.Text).ToShortDateString();
                    var connectionDepatureTime = Convert.ToDateTime(txtConnectionTimeHour.Text + ":" + txtConnectionTimeMinute.Text).ToShortTimeString();

                   // Verbindung mit bestimmter Zeit und Datum 
                    Transport transport = new Transport();
                    var allConnections = transport.GetConnections(txtStationFrom.Text, txtStationTo.Text, connectionDepatureDate, connectionDepatureTime).ConnectionList;

                    // Falls keinen Verbindung gefunden. Warnung anzeigen
                    if (allConnections.ToList().Count == 0)
                    {
                        MessageBox.Show("Bitte wählen Sie einen anderen Zeitpunkt", "Keine Verbindung gefunden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        connectionsTable.Rows.Clear();

                        // Verbindungen zu connectionTable integrieren
                        foreach (var connection in allConnections)
                        {
                            var stationFormName = connection.From.Station.Name;
                            var stationToName = connection.To.Station.Name;
                            var depatureDate = Convert.ToDateTime(connection.From.Departure).ToShortDateString();
                            var depatureTime = Convert.ToDateTime(connection.From.Departure).ToShortTimeString();
                            var durationTime = connection.Duration.Replace("d", "").Replace("0", ""); // BUG-Fix: Damit Zeit nicht mit komischen "dd" angezeigt werden
                            if (String.IsNullOrEmpty(connection.From.Platform)) // Wert wird dem leeren Gleisen zugewiesen
                            {
                                connection.From.Platform = "Kein Gleis gefunden";
                            }
                            connectionsTable.Rows.Add(depatureDate, depatureTime, stationFormName, stationToName, connection.From.Platform, durationTime);
                        }
                    }
                }
                catch (FormatException)
                {
                    falseFromatProvider.SetError(labelConnectionTime, "Bitte nur Zahlen verwenden");
                }
            }
        }

        private void getDepatureConnections()
        {
           // Tabelle cleearen
           depatureMonitorTable.Rows.Clear();

           // Label-Stationnsame anzeigen
           labelStationName.Text = txtDepatureFrom.Text;
           labelStationName.Visible = true;

            Transport transport = new Transport();
            var allDepatureConnections = transport.GetStationBoard(txtDepatureFrom.Text).Entries;

            // Verbindungen zu depatureMonitorTable integrieren
            foreach (var depatureLine in allDepatureConnections)
           {
                var depatureTime = depatureLine.Stop.Departure.ToShortTimeString();
                depatureMonitorTable.Rows.Add(depatureLine.Name, depatureLine.To, depatureTime);
           }
        }

        private void showDateAndTimeOption(object sender, EventArgs e)
        {
            labelConnectionDate.Visible = true;
            dpConnectionDate.Visible = true;
            labelConnectionTime.Visible = true;
            txtConnectionTimeHour.Text = DateTime.Now.Hour.ToString();
            txtConnectionTimeMinute.Text = DateTime.Now.Minute.ToString();
            txtConnectionTimeHour.Visible = true;
            txtConnectionTimeMinute.Visible = true;
        }

        private void showConnectionDetails(object sender, DataGridViewCellEventArgs e)
        {
            viewConnectionDetails detailForm = new viewConnectionDetails();

            // Daten von Row zu ConnectionDetailForm übertragen
            detailForm.labelStationFrom.Text = connectionsTable.CurrentRow.Cells[2].Value.ToString();
            detailForm.labelStationTo.Text = connectionsTable.CurrentRow.Cells[3].Value.ToString();
            detailForm.txtDepatureDate.Text = connectionsTable.CurrentRow.Cells[0].Value.ToString();
            detailForm.txtDepatureTime.Text = connectionsTable.CurrentRow.Cells[1].Value.ToString();
            detailForm.txtDepatureDuration.Text = connectionsTable.CurrentRow.Cells[5].Value.ToString();
            detailForm.txtDepaturePlattform.Text = connectionsTable.CurrentRow.Cells[4].Value.ToString();

            // Formular anzeigen
            detailForm.ShowDialog();
        }

        private void showDepatureDetails(object sender, DataGridViewCellEventArgs e)
        {
            viewDepatureDetails detailForm = new viewDepatureDetails();

            // Daten von Row zu DepatureDetailsForm übertragen
            detailForm.labelTransportLine.Text = depatureMonitorTable.CurrentRow.Cells[0].Value.ToString();
            detailForm.labelDepatureFrom.Text = labelStationName.Text;
            detailForm.labelDepatureTo.Text = depatureMonitorTable.CurrentRow.Cells[1].Value.ToString();
            detailForm.txtDepatureDate.Text = labelDepatureDate.Text;
            detailForm.txtDepatureTime.Text = depatureMonitorTable.CurrentRow.Cells[2].Value.ToString();

            // Formular anzeigen
            detailForm.ShowDialog();
        }

        private void btnLocationOfStation_Click(object sender, EventArgs e)
        {
            Button actuallyButton = (Button) sender;
            if (actuallyButton.Name == btnLocationOfStationFrom.Name)
            {
                getLocationOfStation(actuallyButton, txtStationFrom);
            } else
            {
                getLocationOfStation(actuallyButton, txtStationTo);
            }
        }

        private void getLocationOfStation(Button button, TextBox station)
        {
            string googleMapLocationOfStationLink = $"maps/dir/Mein%20Standort/{station.Text}";
            System.Diagnostics.Process.Start($"http://google.com/{googleMapLocationOfStationLink}/");
            button.Visible = false;
        }
    }
}
