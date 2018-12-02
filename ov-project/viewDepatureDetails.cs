using System;
using CefSharp.WinForms; /* Dokumentation: https://github.com/cefsharp/CefSharp/tree/cefsharp/57 */
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

            // CefSharp Chrome Browser
            var googleMapsChrome = new ChromiumWebBrowser("www.google.com");

            // Google-Maps von Standort zu Panel hinzufügen
            var googleMapsLink = $"https://www.google.ch/maps/dir/{labelDepatureFrom.Text}/{labelDepatureTo.Text}";
            googleMapsChrome.Load(googleMapsLink);

            wbGoogleMaps.Controls.Add(googleMapsChrome);
        }
    }
}
