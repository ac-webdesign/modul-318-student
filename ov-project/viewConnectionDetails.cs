using System;
using CefSharp.WinForms; /* Dokumentation: https://github.com/cefsharp/CefSharp/tree/cefsharp/57 */
using System.Windows.Forms;

namespace ov_project
{
    public partial class viewConnectionDetails : Form
    {

        public viewConnectionDetails()
        {
            InitializeComponent();
        }

        private void setFormSettings(object sender, EventArgs e)
        {
            // Textboxen Readonly gemacht
            txtDepatureDate.ReadOnly = true;
            txtDepatureTime.ReadOnly = true;
            txtDepatureDuration.ReadOnly = true;

            // Falls keine Plattform existiert, wird diese unsichtbar
            if (String.IsNullOrWhiteSpace(txtDepaturePlattform.Text))
            {
                txtDepaturePlattform.Visible = false;
            }
            else
            {
                txtDepaturePlattform.ReadOnly = true;
            }

            // CefSharp Chrome Browser
            var googleMapsChrome = new ChromiumWebBrowser("www.google.com");

            // Google-Maps von Standort zu Panel hinzufügen
            var googleMapsLink = $"https://www.google.ch/maps/dir/{labelStationFrom.Text}/{labelStationTo.Text}";
            googleMapsChrome.Load(googleMapsLink);

            wbGoogleMaps.Controls.Add(googleMapsChrome);
        }
    }
}
