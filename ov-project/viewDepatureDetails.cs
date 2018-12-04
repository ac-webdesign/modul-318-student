using System;
using CefSharp.WinForms; /* Dokumentation: https://github.com/cefsharp/CefSharp/tree/cefsharp/57 */
using System.Windows.Forms;
using System.Linq;
using System.Net.Mail;
using System.Diagnostics;

namespace ov_project
{
    public partial class viewDepatureDetails : Form
    {
        // Aktuelles offenes Formular
        ovForm ovForm = Application.OpenForms.OfType<ovForm>().ElementAt<ovForm>(0);

        int nextRowIndex = 0; 

        public viewDepatureDetails()
        {
            InitializeComponent();
        }

        private void setDepatureDetailsSettings(object sender, EventArgs e)
        {
            // Aktueller Index des connections-Table row
            nextRowIndex = ovForm.depatureMonitorTable.CurrentCell.RowIndex;
            isLastRowOrFirstRow(nextRowIndex);

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
            labelTransportLine.Text = ovForm.depatureMonitorTable.Rows[index].Cells[0].Value.ToString();
            labelDepatureFrom.Text = ovForm.labelStationName.Text;
            labelDepatureTo.Text = ovForm.depatureMonitorTable.Rows[index].Cells[1].Value.ToString();
            txtDepatureDate.Text = ovForm.labelDepatureDate.Text;
            txtDepatureTime.Text = ovForm.depatureMonitorTable.CurrentRow.Cells[2].Value.ToString();
        }

        private void isLastRowOrFirstRow(int index)
        {
            // Icons für Buttons geben
            btnNext.Text = char.ConvertFromUtf32(0x2192); // right Arrorw
            btnPrev.Text = char.ConvertFromUtf32(0x2190); // left Arrow

            // Buttons bei ersten oder letzten Element unsichtbar machen
            var isLastRow = ovForm.depatureMonitorTable.Rows.Count - 1;
            var isFirstRow = ovForm.depatureMonitorTable.Rows[0].Index;

            if (index == isLastRow)
            {
                btnNext.Visible = false;
            }
            else if (index == isFirstRow)
            {
                btnPrev.Visible = false;
            }
            else
            {
                btnNext.Visible = true;
                btnPrev.Visible = true;
            }
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
                "Linie: " + formData[0] + newLine +
                 "Start: " + formData[1] + newLine +
                "Ziel: " + formData[2] + newLine +
                "Datum: " + formData[3] + newLine +
                "Abfahrt: " + formData[4] + newLine +
                "Link zu Google-Map: " + formData[5];

            // Mail öffnen
            Process.Start(@"mailto:?subject=" + mailMessage.Subject + "&body=" + mailMessage.Body);
        }

        private string[] getFormData()
        {
            String[] formData = new String[] {
                labelTransportLine.Text,
                labelDepatureFrom.Text,
                labelDepatureTo.Text,
                txtDepatureDate.Text,
                txtDepatureTime.Text,
                $"https://www.google.ch/maps/dir/{labelDepatureFrom.Text}/{labelDepatureTo.Text}"
            };

            return formData;
        }


        private void createGoogleChromeMap()
        {
            wbGoogleMaps.Controls.Clear();

            // CefSharp Chrome Browser
            var googleMapsChrome = new ChromiumWebBrowser("www.google.com");

            // Google-Maps von Standort zu Panel hinzufügen
            var googleMapsLink = $"https://www.google.ch/maps/dir/{labelDepatureFrom.Text}/{labelDepatureTo.Text}";
            googleMapsChrome.Load(googleMapsLink);

            wbGoogleMaps.Controls.Add(googleMapsChrome);
        }
    }
}
