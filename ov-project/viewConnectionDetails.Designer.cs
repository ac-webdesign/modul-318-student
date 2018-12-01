﻿namespace ov_project
{
    partial class viewConnectionDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelStationFrom = new System.Windows.Forms.Label();
            this.labelStationTo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepatureDate = new System.Windows.Forms.TextBox();
            this.txtDepatureTime = new System.Windows.Forms.TextBox();
            this.txtDepatureDuration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbTitel = new System.Windows.Forms.GroupBox();
            this.gbConnectionData = new System.Windows.Forms.GroupBox();
            this.txtDepaturePlattform = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.wbGoogleMaps = new System.Windows.Forms.WebBrowser();
            this.gbTitel.SuspendLayout();
            this.gbConnectionData.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStationFrom
            // 
            this.labelStationFrom.AutoSize = true;
            this.labelStationFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStationFrom.Location = new System.Drawing.Point(35, 9);
            this.labelStationFrom.Name = "labelStationFrom";
            this.labelStationFrom.Size = new System.Drawing.Size(235, 31);
            this.labelStationFrom.TabIndex = 0;
            this.labelStationFrom.Text = "labelStationFrom";
            // 
            // labelStationTo
            // 
            this.labelStationTo.AutoSize = true;
            this.labelStationTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStationTo.Location = new System.Drawing.Point(484, 9);
            this.labelStationTo.Name = "labelStationTo";
            this.labelStationTo.Size = new System.Drawing.Size(202, 31);
            this.labelStationTo.TabIndex = 1;
            this.labelStationTo.Text = "labelStationTo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Abfahrt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dauer:";
            // 
            // txtDepatureDate
            // 
            this.txtDepatureDate.Location = new System.Drawing.Point(155, 45);
            this.txtDepatureDate.Name = "txtDepatureDate";
            this.txtDepatureDate.Size = new System.Drawing.Size(100, 20);
            this.txtDepatureDate.TabIndex = 5;
            // 
            // txtDepatureTime
            // 
            this.txtDepatureTime.Location = new System.Drawing.Point(347, 45);
            this.txtDepatureTime.Name = "txtDepatureTime";
            this.txtDepatureTime.Size = new System.Drawing.Size(100, 20);
            this.txtDepatureTime.TabIndex = 6;
            // 
            // txtDepatureDuration
            // 
            this.txtDepatureDuration.Location = new System.Drawing.Point(555, 45);
            this.txtDepatureDuration.Name = "txtDepatureDuration";
            this.txtDepatureDuration.Size = new System.Drawing.Size(100, 20);
            this.txtDepatureDuration.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(351, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "->";
            // 
            // gbTitel
            // 
            this.gbTitel.Controls.Add(this.label4);
            this.gbTitel.Controls.Add(this.labelStationTo);
            this.gbTitel.Controls.Add(this.labelStationFrom);
            this.gbTitel.Location = new System.Drawing.Point(12, 29);
            this.gbTitel.Name = "gbTitel";
            this.gbTitel.Size = new System.Drawing.Size(776, 43);
            this.gbTitel.TabIndex = 9;
            this.gbTitel.TabStop = false;
            // 
            // gbConnectionData
            // 
            this.gbConnectionData.Controls.Add(this.txtDepaturePlattform);
            this.gbConnectionData.Controls.Add(this.label5);
            this.gbConnectionData.Controls.Add(this.txtDepatureDuration);
            this.gbConnectionData.Controls.Add(this.txtDepatureTime);
            this.gbConnectionData.Controls.Add(this.txtDepatureDate);
            this.gbConnectionData.Controls.Add(this.label3);
            this.gbConnectionData.Controls.Add(this.label2);
            this.gbConnectionData.Controls.Add(this.label1);
            this.gbConnectionData.Location = new System.Drawing.Point(12, 101);
            this.gbConnectionData.Name = "gbConnectionData";
            this.gbConnectionData.Size = new System.Drawing.Size(776, 106);
            this.gbConnectionData.TabIndex = 10;
            this.gbConnectionData.TabStop = false;
            this.gbConnectionData.Text = "Verbindungsdaten";
            // 
            // txtDepaturePlattform
            // 
            this.txtDepaturePlattform.Location = new System.Drawing.Point(347, 71);
            this.txtDepaturePlattform.Name = "txtDepaturePlattform";
            this.txtDepaturePlattform.Size = new System.Drawing.Size(100, 20);
            this.txtDepaturePlattform.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gleis:";
            // 
            // wbGoogleMaps
            // 
            this.wbGoogleMaps.Location = new System.Drawing.Point(12, 213);
            this.wbGoogleMaps.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbGoogleMaps.Name = "wbGoogleMaps";
            this.wbGoogleMaps.Size = new System.Drawing.Size(776, 372);
            this.wbGoogleMaps.TabIndex = 11;
            // 
            // viewConnectionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 597);
            this.Controls.Add(this.wbGoogleMaps);
            this.Controls.Add(this.gbConnectionData);
            this.Controls.Add(this.gbTitel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "viewConnectionDetails";
            this.Text = "Verbindung Details";
            this.Load += new System.EventHandler(this.setFormSettings);
            this.gbTitel.ResumeLayout(false);
            this.gbTitel.PerformLayout();
            this.gbConnectionData.ResumeLayout(false);
            this.gbConnectionData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbTitel;
        private System.Windows.Forms.GroupBox gbConnectionData;
        public System.Windows.Forms.Label labelStationFrom;
        public System.Windows.Forms.Label labelStationTo;
        public System.Windows.Forms.TextBox txtDepatureDate;
        public System.Windows.Forms.TextBox txtDepatureTime;
        public System.Windows.Forms.TextBox txtDepatureDuration;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtDepaturePlattform;
        public System.Windows.Forms.WebBrowser wbGoogleMaps;
    }
}