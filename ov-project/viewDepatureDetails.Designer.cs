﻿namespace ov_project
{
    partial class viewDepatureDetails
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
            this.wbGoogleMaps = new System.Windows.Forms.Panel();
            this.gbDepatureData = new System.Windows.Forms.GroupBox();
            this.txtDepatureTime = new System.Windows.Forms.TextBox();
            this.txtDepatureDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTransportLine = new System.Windows.Forms.Label();
            this.gbTitel = new System.Windows.Forms.GroupBox();
            this.labelDepatureTo = new System.Windows.Forms.Label();
            this.labelDepatureFrom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbDepatureData.SuspendLayout();
            this.gbTitel.SuspendLayout();
            this.SuspendLayout();
            // 
            // wbGoogleMaps
            // 
            this.wbGoogleMaps.Location = new System.Drawing.Point(291, 93);
            this.wbGoogleMaps.Name = "wbGoogleMaps";
            this.wbGoogleMaps.Size = new System.Drawing.Size(1259, 670);
            this.wbGoogleMaps.TabIndex = 14;
            // 
            // gbDepatureData
            // 
            this.gbDepatureData.Controls.Add(this.txtDepatureTime);
            this.gbDepatureData.Controls.Add(this.txtDepatureDate);
            this.gbDepatureData.Controls.Add(this.label2);
            this.gbDepatureData.Controls.Add(this.label1);
            this.gbDepatureData.Location = new System.Drawing.Point(13, 93);
            this.gbDepatureData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDepatureData.Name = "gbDepatureData";
            this.gbDepatureData.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDepatureData.Size = new System.Drawing.Size(271, 670);
            this.gbDepatureData.TabIndex = 13;
            this.gbDepatureData.TabStop = false;
            this.gbDepatureData.Text = "Abfahrtdaten";
            // 
            // txtDepatureTime
            // 
            this.txtDepatureTime.Location = new System.Drawing.Point(92, 95);
            this.txtDepatureTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDepatureTime.Name = "txtDepatureTime";
            this.txtDepatureTime.Size = new System.Drawing.Size(148, 26);
            this.txtDepatureTime.TabIndex = 6;
            // 
            // txtDepatureDate
            // 
            this.txtDepatureDate.Location = new System.Drawing.Point(92, 41);
            this.txtDepatureDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDepatureDate.Name = "txtDepatureDate";
            this.txtDepatureDate.Size = new System.Drawing.Size(148, 26);
            this.txtDepatureDate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Abfahrt:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datum:";
            // 
            // labelTransportLine
            // 
            this.labelTransportLine.AutoSize = true;
            this.labelTransportLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransportLine.Location = new System.Drawing.Point(8, 12);
            this.labelTransportLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTransportLine.Name = "labelTransportLine";
            this.labelTransportLine.Size = new System.Drawing.Size(383, 47);
            this.labelTransportLine.TabIndex = 0;
            this.labelTransportLine.Text = "labelTransportLine";
            // 
            // gbTitel
            // 
            this.gbTitel.Controls.Add(this.label3);
            this.gbTitel.Controls.Add(this.labelDepatureFrom);
            this.gbTitel.Controls.Add(this.labelDepatureTo);
            this.gbTitel.Controls.Add(this.labelTransportLine);
            this.gbTitel.Location = new System.Drawing.Point(13, 14);
            this.gbTitel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTitel.Name = "gbTitel";
            this.gbTitel.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTitel.Size = new System.Drawing.Size(1537, 64);
            this.gbTitel.TabIndex = 12;
            this.gbTitel.TabStop = false;
            // 
            // labelDepatureTo
            // 
            this.labelDepatureTo.AutoSize = true;
            this.labelDepatureTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepatureTo.Location = new System.Drawing.Point(992, 21);
            this.labelDepatureTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDepatureTo.Name = "labelDepatureTo";
            this.labelDepatureTo.Size = new System.Drawing.Size(268, 37);
            this.labelDepatureTo.TabIndex = 1;
            this.labelDepatureTo.Text = "labelDepatureTo";
            // 
            // labelDepatureFrom
            // 
            this.labelDepatureFrom.AutoSize = true;
            this.labelDepatureFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepatureFrom.Location = new System.Drawing.Point(531, 21);
            this.labelDepatureFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDepatureFrom.Name = "labelDepatureFrom";
            this.labelDepatureFrom.Size = new System.Drawing.Size(308, 37);
            this.labelDepatureFrom.TabIndex = 3;
            this.labelDepatureFrom.Text = "labelDepatureFrom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(890, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "->";
            // 
            // viewDepatureDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 787);
            this.Controls.Add(this.wbGoogleMaps);
            this.Controls.Add(this.gbDepatureData);
            this.Controls.Add(this.gbTitel);
            this.Name = "viewDepatureDetails";
            this.Text = "Abfahrt-Details";
            this.Load += new System.EventHandler(this.setDepatureDetailsSettings);
            this.gbDepatureData.ResumeLayout(false);
            this.gbDepatureData.PerformLayout();
            this.gbTitel.ResumeLayout(false);
            this.gbTitel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel wbGoogleMaps;
        private System.Windows.Forms.GroupBox gbDepatureData;
        public System.Windows.Forms.TextBox txtDepatureTime;
        public System.Windows.Forms.TextBox txtDepatureDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelTransportLine;
        private System.Windows.Forms.GroupBox gbTitel;
        public System.Windows.Forms.Label labelDepatureTo;
        public System.Windows.Forms.Label labelDepatureFrom;
        public System.Windows.Forms.Label label3;
    }
}