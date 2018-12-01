using System;
using CefSharp.WinForms;
using System.Windows.Forms;

namespace ov_project
{
    public partial class viewDepatureDetails : Form
    {
        public viewDepatureDetails()
        {
            InitializeComponent();
        }

        private void setDepatureDetailsSettings(object sender, EventArgs e)
        {
            // Textboxen Readonly gemacht
            txtDepatureDate.ReadOnly = true;
            txtDepatureTime.ReadOnly = true;

            // CefSharp Chrome Browser integrieren
            var googleMapsChrome = new ChromiumWebBrowser("www.google.com");

            // Google-Maps erstellen
            var googleMapsLink = "https://www.google.ch/maps/dir/" + labelDepatureFrom.Text + labelDepatureTo.Text;
            googleMapsChrome.Load(googleMapsLink);

            wbGoogleMaps.Controls.Add(googleMapsChrome);
        }
    }
}
