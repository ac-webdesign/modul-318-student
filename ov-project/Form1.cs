﻿using System;
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

        private void setFormSettings(object sender, EventArgs e)
        {
            // Standardbreite von Formular setzen
            ovForm form = (ovForm)sender;
            form.Width = 1000;
            form.Height = 600;

            // Standardbreite für Spalten setzen
            connectionsTable.Columns[2].Width = 251;
            connectionsTable.Columns[3].Width = 251;
        }

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
                labelDepatureTime.Text = DateTime.Now.ToShortTimeString();
                labelDepatureDate.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void getAllStations(object sender, EventArgs e)
        {
            AutoCompleteStringCollection stationsStringCollection = new AutoCompleteStringCollection();

            TextBox txtSearchedStation = (TextBox)sender;

            //BUG Fixing Speicher-Zugriff, Error: "System.AccessViolationException"
            if (txtSearchedStation.Text.Length == 3)
            {
                if (String.IsNullOrEmpty(txtSearchedStation.Text))
                {
                    txtSearchedStation.BackColor = Color.Red;
                }
                else
                {
                    // Textbox-Farbe zurücksetzen
                    txtSearchedStation.BackColor = Color.White;

                    Transport transport = new Transport();
                    var allStationConnections = transport.GetStations(txtSearchedStation.Text).StationList;

                    foreach (var station in allStationConnections)
                    {
                        stationsStringCollection.Add(station.Name);
                    }

                    txtSearchedStation.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txtSearchedStation.AutoCompleteCustomSource = stationsStringCollection;
                }
            }
        }

        private void btnSearchConnections_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStationFrom.Text) || String.IsNullOrEmpty(txtStationTo.Text))
            {
                txtStationFrom.BackColor = Color.Red;
                txtStationTo.BackColor = Color.Red;
            } else if (txtStationFrom.Text == txtStationTo.Text)
            {
                stationToIsEqualStationFrom.SetError(txtStationTo, "Gleiche Station ausgewählt");
            } else { 
                Transport transport = new Transport();
                var allConnections = transport.GetConnections(txtStationFrom.Text, txtStationTo.Text).ConnectionList;

                // Clear Providers
                stationToIsEqualStationFrom.Clear();
                falseFromatProvider.Clear();

                try {
                    // Textboxen zu Datetime formatiert um diese filtern zu können
                    var connectionDepatureDate = Convert.ToDateTime(Convert.ToDateTime(dpConnectionDate.Text).ToShortDateString());
                    var connectionDepatureTime = Convert.ToDateTime(Convert.ToDateTime(txtConnectionTimeHour.Text + ":" + txtConnectionTimeMinute.Text).ToShortTimeString());
            

                    var filteredConnectionsByDateAndTime = allConnections
                    .Where(c =>
                        Convert.ToDateTime(Convert.ToDateTime(c.From.Departure).ToShortDateString()) >= connectionDepatureDate &&
                        Convert.ToDateTime(Convert.ToDateTime(c.From.Departure).ToShortTimeString()) >= connectionDepatureTime
                    );

                    // Falls keinen Verbindung gefunden. Warnung anzeigen
                    if (filteredConnectionsByDateAndTime.ToList().Count == 0)
                    {
                        MessageBox.Show("Bitte wählen Sie einen anderen Zeitpunkt", "Keine Verbindung gefunden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        connectionsTable.Rows.Clear();

                        // Verbindungen zu connectionTable integrieren
                        foreach (var connection in filteredConnectionsByDateAndTime)
                        {
                            var stationFormName = connection.From.Station.Name;
                            var stationToName = connection.To.Station.Name;
                            var depatureDate = Convert.ToDateTime(connection.From.Departure).ToShortDateString();
                            var depatureTime = Convert.ToDateTime(connection.From.Departure).ToShortTimeString();
                            var durationTime = connection.Duration.Replace('d', ' '); // TODO: Zeit besser formatieren
                            if (String.IsNullOrEmpty(connection.From.Platform))
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

        private void getDepatureConnections(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                    Transport transport = new Transport();
                    var allDepatureConnections = transport.GetStationBoard(txtDepatureFrom.Text).Entries;

                    // Label-Stationnsame anzeigen
                    labelStationName.Text = txtDepatureFrom.Text;
                    labelStationName.Visible = true;

                    depatureMonitorTable.Rows.Clear();

                    // Verbindungen zu depatureMonitorTable integrieren
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
            txtConnectionTimeHour.Text = DateTime.Now.Hour.ToString();
            txtConnectionTimeMinute.Text = Convert.ToDateTime(DateTime.Now.ToShortTimeString()).Minute.ToString();
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

            detailForm.ShowDialog();
        }
    }
}
