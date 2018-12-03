using System;
using CefSharp.WinForms; /* Dokumentation: https://github.com/cefsharp/CefSharp/tree/cefsharp/57 */
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics;
using System.Net.Mail;

namespace ov_project
{
    public partial class viewConnectionDetails : Form
    {
        ovForm ovForm = Application.OpenForms.OfType<ovForm>().ElementAt<ovForm>(0);
        int nextRowIndex = 0;

        public viewConnectionDetails()
        {
            InitializeComponent();
        }

        private void setFormSettings(object sender, EventArgs e)
        {
            // Textboxen Readonly
            txtDepatureDate.ReadOnly = true;
            txtDepatureTime.ReadOnly = true;
            txtDepatureDuration.ReadOnly = true;

            // Aktueller Index des connections-Table row
            nextRowIndex = ovForm.connectionsTable.CurrentCell.RowIndex;
            isLastRowOrFirstRow(nextRowIndex);


            // Falls keine Plattform existiert, wird diese unsichtbar
            if (txtDepaturePlattform.Text == "Kein Gleis gefunden")
            {
                labelDepaturePlattform.Visible = false;
                txtDepaturePlattform.Visible = false;
            }
            else
            {
                txtDepaturePlattform.ReadOnly = true;
            }

            createGoogleChromeMap();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            nextRowIndex++;

            updateFormFields(nextRowIndex);
            isLastRowOrFirstRow(nextRowIndex);

            createGoogleChromeMap();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            nextRowIndex--;

            updateFormFields(nextRowIndex);
            isLastRowOrFirstRow(nextRowIndex);

            createGoogleChromeMap();
        }

        private void updateFormFields(int index)
        {
            labelStationFrom.Text = ovForm.connectionsTable.Rows[index].Cells[2].Value.ToString();
            labelStationTo.Text = ovForm.connectionsTable.Rows[index].Cells[3].Value.ToString();
            txtDepatureDate.Text = ovForm.connectionsTable.Rows[index].Cells[0].Value.ToString();
            txtDepatureTime.Text = ovForm.connectionsTable.Rows[index].Cells[1].Value.ToString();
            txtDepatureDuration.Text = ovForm.connectionsTable.Rows[index].Cells[5].Value.ToString();

            // Falls kein Gleis existiert, wird ein Wert zugeweisen, damit kein Error passiert
            if (txtDepaturePlattform.Text == "Kein Gleis gefunden")
            {
                labelDepaturePlattform.Visible = false;
                txtDepaturePlattform.Visible = false;
            }
            else
            {
                labelDepaturePlattform.Visible = true;
                txtDepaturePlattform.Text = ovForm.connectionsTable.Rows[index].Cells[4].Value.ToString();
            }
        } 

        private void isLastRowOrFirstRow(int index)
        {
            // Icons für Buttons geben
            btnNext.Text = char.ConvertFromUtf32(0x2192); // right Arrorw
            btnPrev.Text = char.ConvertFromUtf32(0x2190); // left Arrow

            // Buttons bei ersten oder letzten Element unsichtbar machen
            var isLastRow = ovForm.connectionsTable.Rows.Count -1;
            var isFirstRow = ovForm.connectionsTable.Rows[0].Index;

            if (index == isLastRow)
            {
                btnNext.Visible = false;
            } else if (index == isFirstRow)
            {
                btnPrev.Visible = false;
            } else
            {
                btnNext.Visible = true;
                btnPrev.Visible = true;
            }
        }

        private void createGoogleChromeMap()
        {
            wbGoogleMaps.Controls.Clear();

            // CefSharp Chrome Browser
            var googleMapsChrome = new ChromiumWebBrowser("www.google.com");

            // Google-Maps von Standort zu Panel hinzufügen
            var googleMapsLink = $"https://www.google.ch/maps/dir/{labelStationFrom.Text}/{labelStationTo.Text}";
            googleMapsChrome.Load(googleMapsLink);

            wbGoogleMaps.Controls.Add(googleMapsChrome);
        }

        private void btnSendToMail_Click(object sender, EventArgs e)
        {
            // Daten per Email versenden/öffnen
            createAndOpenMail();
        }

        private void createAndOpenMail()
        {
            var formData = getFormData();

            // Mail erstellen
            var mailMessage = new MailMessage();
            mailMessage.Subject = "Ihr Betreff";

            var newLine = "%0D%0A";

            mailMessage.Body =
                "Start: " + formData[0] + newLine +
                 "Ziel: " + formData[1] + newLine +
                "Datum: " + formData[2] + newLine +
                "Abfahrt: " + formData[3] + newLine +
                "Dauer: " + formData[4] + newLine +
                "Gleis: " + formData[5] + newLine +
                "Link zu Google-Map: " + formData[6];

            // Mail öffnen
            Process.Start(@"mailto:?subject=" + mailMessage.Subject + "&body=" + mailMessage.Body);
        }

        private string[] getFormData()
        {
            // Formular-Daten abrufen
            String[] formData = new String[] {
                labelStationFrom.Text,
                labelStationTo.Text,
                txtDepatureDate.Text,
                txtDepatureTime.Text,
                txtDepatureDuration.Text,
                txtDepaturePlattform.Text,
                $"https://www.google.ch/maps/dir/{labelStationFrom.Text}/{labelStationTo.Text}"
            };

            return formData;
        }
    }
}
