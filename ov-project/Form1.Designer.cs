﻿namespace ov_project
{
    partial class ovForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchBox = new System.Windows.Forms.GroupBox();
            this.txtConnectionTime = new System.Windows.Forms.TextBox();
            this.labelConnectionTime = new System.Windows.Forms.Label();
            this.labelConnectionDate = new System.Windows.Forms.Label();
            this.dpConnectionDate = new System.Windows.Forms.DateTimePicker();
            this.txtStationTo = new System.Windows.Forms.TextBox();
            this.listAllStationsTo = new System.Windows.Forms.ListBox();
            this.listAllStationsFrom = new System.Windows.Forms.ListBox();
            this.txtStationFrom = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.connectionsTable = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.TabControl();
            this.startPage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.depatureMonitorPage = new System.Windows.Forms.TabPage();
            this.depatureMonitorTable = new System.Windows.Forms.DataGridView();
            this.line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depatureMonitorBox = new System.Windows.Forms.GroupBox();
            this.listDepature = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDepature = new System.Windows.Forms.TextBox();
            this.labelDepatureDate = new System.Windows.Forms.Label();
            this.labelDepatureTime = new System.Windows.Forms.Label();
            this.labelStationName = new System.Windows.Forms.Label();
            this.searchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsTable)).BeginInit();
            this.Start.SuspendLayout();
            this.startPage.SuspendLayout();
            this.depatureMonitorPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depatureMonitorTable)).BeginInit();
            this.depatureMonitorBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Controls.Add(this.txtConnectionTime);
            this.searchBox.Controls.Add(this.labelConnectionTime);
            this.searchBox.Controls.Add(this.labelConnectionDate);
            this.searchBox.Controls.Add(this.dpConnectionDate);
            this.searchBox.Controls.Add(this.txtStationTo);
            this.searchBox.Controls.Add(this.listAllStationsTo);
            this.searchBox.Controls.Add(this.listAllStationsFrom);
            this.searchBox.Controls.Add(this.txtStationFrom);
            this.searchBox.Controls.Add(this.btnSearch);
            this.searchBox.Controls.Add(this.label2);
            this.searchBox.Controls.Add(this.label1);
            this.searchBox.Location = new System.Drawing.Point(4, 95);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBox.Name = "searchBox";
            this.searchBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBox.Size = new System.Drawing.Size(1416, 186);
            this.searchBox.TabIndex = 0;
            this.searchBox.TabStop = false;
            this.searchBox.Text = "Verbindungen suchen";
            // 
            // txtConnectionTime
            // 
            this.txtConnectionTime.Location = new System.Drawing.Point(762, 146);
            this.txtConnectionTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConnectionTime.Name = "txtConnectionTime";
            this.txtConnectionTime.Size = new System.Drawing.Size(60, 26);
            this.txtConnectionTime.TabIndex = 11;
            this.txtConnectionTime.Visible = false;
            // 
            // labelConnectionTime
            // 
            this.labelConnectionTime.AutoSize = true;
            this.labelConnectionTime.Location = new System.Drawing.Point(758, 125);
            this.labelConnectionTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConnectionTime.Name = "labelConnectionTime";
            this.labelConnectionTime.Size = new System.Drawing.Size(36, 20);
            this.labelConnectionTime.TabIndex = 10;
            this.labelConnectionTime.Text = "Zeit";
            this.labelConnectionTime.Visible = false;
            // 
            // labelConnectionDate
            // 
            this.labelConnectionDate.AutoSize = true;
            this.labelConnectionDate.Location = new System.Drawing.Point(579, 65);
            this.labelConnectionDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConnectionDate.Name = "labelConnectionDate";
            this.labelConnectionDate.Size = new System.Drawing.Size(57, 20);
            this.labelConnectionDate.TabIndex = 9;
            this.labelConnectionDate.Text = "Datum";
            this.labelConnectionDate.Visible = false;
            // 
            // dpConnectionDate
            // 
            this.dpConnectionDate.Location = new System.Drawing.Point(584, 89);
            this.dpConnectionDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpConnectionDate.Name = "dpConnectionDate";
            this.dpConnectionDate.Size = new System.Drawing.Size(308, 26);
            this.dpConnectionDate.TabIndex = 8;
            this.dpConnectionDate.Visible = false;
            // 
            // txtStationTo
            // 
            this.txtStationTo.Location = new System.Drawing.Point(333, 89);
            this.txtStationTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStationTo.Name = "txtStationTo";
            this.txtStationTo.Size = new System.Drawing.Size(224, 26);
            this.txtStationTo.TabIndex = 7;
            this.txtStationTo.TextChanged += new System.EventHandler(this.getAllStations);
            // 
            // listAllStationsTo
            // 
            this.listAllStationsTo.FormattingEnabled = true;
            this.listAllStationsTo.ItemHeight = 20;
            this.listAllStationsTo.Location = new System.Drawing.Point(333, 114);
            this.listAllStationsTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listAllStationsTo.Name = "listAllStationsTo";
            this.listAllStationsTo.Size = new System.Drawing.Size(224, 64);
            this.listAllStationsTo.TabIndex = 6;
            this.listAllStationsTo.Visible = false;
            this.listAllStationsTo.DoubleClick += new System.EventHandler(this.putToStation);
            // 
            // listAllStationsFrom
            // 
            this.listAllStationsFrom.FormattingEnabled = true;
            this.listAllStationsFrom.ItemHeight = 20;
            this.listAllStationsFrom.Location = new System.Drawing.Point(14, 114);
            this.listAllStationsFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listAllStationsFrom.Name = "listAllStationsFrom";
            this.listAllStationsFrom.Size = new System.Drawing.Size(224, 64);
            this.listAllStationsFrom.TabIndex = 5;
            this.listAllStationsFrom.Visible = false;
            this.listAllStationsFrom.DoubleClick += new System.EventHandler(this.putToStation);
            // 
            // txtStationFrom
            // 
            this.txtStationFrom.Location = new System.Drawing.Point(14, 88);
            this.txtStationFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStationFrom.Name = "txtStationFrom";
            this.txtStationFrom.Size = new System.Drawing.Size(224, 26);
            this.txtStationFrom.TabIndex = 4;
            this.txtStationFrom.TextChanged += new System.EventHandler(this.getAllStations);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(952, 89);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 31);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearchConnections_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nach";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Von";
            // 
            // connectionsTable
            // 
            this.connectionsTable.AllowUserToAddRows = false;
            this.connectionsTable.AllowUserToDeleteRows = false;
            this.connectionsTable.AllowUserToResizeColumns = false;
            this.connectionsTable.AllowUserToResizeRows = false;
            this.connectionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.connectionsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.time,
            this.connection,
            this.endStation,
            this.station,
            this.duration});
            this.connectionsTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.connectionsTable.Location = new System.Drawing.Point(4, 285);
            this.connectionsTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connectionsTable.Name = "connectionsTable";
            this.connectionsTable.ReadOnly = true;
            this.connectionsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.connectionsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.connectionsTable.Size = new System.Drawing.Size(1422, 488);
            this.connectionsTable.TabIndex = 1;
            this.connectionsTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showConnectionDetails);
            // 
            // date
            // 
            this.date.HeaderText = "Datum";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // time
            // 
            this.time.HeaderText = "Uhrzeit";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // connection
            // 
            this.connection.HeaderText = "Start";
            this.connection.Name = "connection";
            this.connection.ReadOnly = true;
            // 
            // endStation
            // 
            this.endStation.HeaderText = "Ziel";
            this.endStation.Name = "endStation";
            this.endStation.ReadOnly = true;
            // 
            // station
            // 
            this.station.HeaderText = "Gleis";
            this.station.Name = "station";
            this.station.ReadOnly = true;
            // 
            // duration
            // 
            this.duration.HeaderText = "Dauer";
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.Controls.Add(this.startPage);
            this.Start.Controls.Add(this.depatureMonitorPage);
            this.Start.Location = new System.Drawing.Point(12, 18);
            this.Start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Start.Name = "Start";
            this.Start.SelectedIndex = 0;
            this.Start.Size = new System.Drawing.Size(1432, 848);
            this.Start.TabIndex = 5;
            this.Start.SelectedIndexChanged += new System.EventHandler(this.setDepatureMonitorSettings);
            // 
            // startPage
            // 
            this.startPage.Controls.Add(this.label3);
            this.startPage.Controls.Add(this.searchBox);
            this.startPage.Controls.Add(this.connectionsTable);
            this.startPage.Location = new System.Drawing.Point(4, 29);
            this.startPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startPage.Name = "startPage";
            this.startPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startPage.Size = new System.Drawing.Size(1424, 815);
            this.startPage.TabIndex = 0;
            this.startPage.Text = "Start";
            this.startPage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(608, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Öv-App";
            // 
            // depatureMonitorPage
            // 
            this.depatureMonitorPage.Controls.Add(this.depatureMonitorTable);
            this.depatureMonitorPage.Controls.Add(this.depatureMonitorBox);
            this.depatureMonitorPage.Location = new System.Drawing.Point(4, 29);
            this.depatureMonitorPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depatureMonitorPage.Name = "depatureMonitorPage";
            this.depatureMonitorPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depatureMonitorPage.Size = new System.Drawing.Size(1424, 815);
            this.depatureMonitorPage.TabIndex = 1;
            this.depatureMonitorPage.Text = "Abfahrtmonitor";
            this.depatureMonitorPage.UseVisualStyleBackColor = true;
            // 
            // depatureMonitorTable
            // 
            this.depatureMonitorTable.AllowUserToAddRows = false;
            this.depatureMonitorTable.AllowUserToDeleteRows = false;
            this.depatureMonitorTable.AllowUserToResizeColumns = false;
            this.depatureMonitorTable.AllowUserToResizeRows = false;
            this.depatureMonitorTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depatureMonitorTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.line,
            this.fromTo,
            this.depature});
            this.depatureMonitorTable.Location = new System.Drawing.Point(0, 186);
            this.depatureMonitorTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depatureMonitorTable.Name = "depatureMonitorTable";
            this.depatureMonitorTable.ReadOnly = true;
            this.depatureMonitorTable.Size = new System.Drawing.Size(1420, 612);
            this.depatureMonitorTable.TabIndex = 5;
            this.depatureMonitorTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showDepatureDetails);
            // 
            // line
            // 
            this.line.HeaderText = "Linie";
            this.line.Name = "line";
            this.line.ReadOnly = true;
            // 
            // fromTo
            // 
            this.fromTo.HeaderText = "Ziel";
            this.fromTo.Name = "fromTo";
            this.fromTo.ReadOnly = true;
            // 
            // depature
            // 
            this.depature.HeaderText = "Abfahrt";
            this.depature.Name = "depature";
            this.depature.ReadOnly = true;
            // 
            // depatureMonitorBox
            // 
            this.depatureMonitorBox.Controls.Add(this.listDepature);
            this.depatureMonitorBox.Controls.Add(this.label4);
            this.depatureMonitorBox.Controls.Add(this.txtDepature);
            this.depatureMonitorBox.Controls.Add(this.labelDepatureDate);
            this.depatureMonitorBox.Controls.Add(this.labelDepatureTime);
            this.depatureMonitorBox.Controls.Add(this.labelStationName);
            this.depatureMonitorBox.Location = new System.Drawing.Point(0, 9);
            this.depatureMonitorBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depatureMonitorBox.Name = "depatureMonitorBox";
            this.depatureMonitorBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depatureMonitorBox.Size = new System.Drawing.Size(1420, 168);
            this.depatureMonitorBox.TabIndex = 4;
            this.depatureMonitorBox.TabStop = false;
            this.depatureMonitorBox.Text = "Abfahrtmonitor";
            // 
            // listDepature
            // 
            this.listDepature.FormattingEnabled = true;
            this.listDepature.ItemHeight = 20;
            this.listDepature.Location = new System.Drawing.Point(32, 112);
            this.listDepature.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listDepature.Name = "listDepature";
            this.listDepature.Size = new System.Drawing.Size(200, 44);
            this.listDepature.TabIndex = 6;
            this.listDepature.Visible = false;
            this.listDepature.DoubleClick += new System.EventHandler(this.putToStation);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Abfahrt";
            // 
            // txtDepature
            // 
            this.txtDepature.Location = new System.Drawing.Point(32, 88);
            this.txtDepature.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDepature.Name = "txtDepature";
            this.txtDepature.Size = new System.Drawing.Size(200, 26);
            this.txtDepature.TabIndex = 3;
            this.txtDepature.TextChanged += new System.EventHandler(this.getAllStations);
            // 
            // labelDepatureDate
            // 
            this.labelDepatureDate.AutoSize = true;
            this.labelDepatureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepatureDate.Location = new System.Drawing.Point(1234, 91);
            this.labelDepatureDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDepatureDate.Name = "labelDepatureDate";
            this.labelDepatureDate.Size = new System.Drawing.Size(120, 25);
            this.labelDepatureDate.TabIndex = 2;
            this.labelDepatureDate.Text = "20.08.2018";
            // 
            // labelDepatureTime
            // 
            this.labelDepatureTime.AutoSize = true;
            this.labelDepatureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepatureTime.Location = new System.Drawing.Point(855, 91);
            this.labelDepatureTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDepatureTime.Name = "labelDepatureTime";
            this.labelDepatureTime.Size = new System.Drawing.Size(67, 25);
            this.labelDepatureTime.TabIndex = 1;
            this.labelDepatureTime.Text = "00:01";
            // 
            // labelStationName
            // 
            this.labelStationName.AutoSize = true;
            this.labelStationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStationName.Location = new System.Drawing.Point(345, 82);
            this.labelStationName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStationName.Name = "labelStationName";
            this.labelStationName.Size = new System.Drawing.Size(205, 33);
            this.labelStationName.TabIndex = 0;
            this.labelStationName.Text = "Stationsname";
            this.labelStationName.Visible = false;
            // 
            // ovForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 885);
            this.Controls.Add(this.Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ovForm";
            this.Text = "OV-App";
            this.Load += new System.EventHandler(this.setFormSettings);
            this.searchBox.ResumeLayout(false);
            this.searchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsTable)).EndInit();
            this.Start.ResumeLayout(false);
            this.startPage.ResumeLayout(false);
            this.startPage.PerformLayout();
            this.depatureMonitorPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.depatureMonitorTable)).EndInit();
            this.depatureMonitorBox.ResumeLayout(false);
            this.depatureMonitorBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox searchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView connectionsTable;
        private System.Windows.Forms.ListBox listAllStationsFrom;
        private System.Windows.Forms.TextBox txtStationFrom;
        private System.Windows.Forms.ListBox listAllStationsTo;
        private System.Windows.Forms.TextBox txtStationTo;
        private System.Windows.Forms.TabControl Start;
        private System.Windows.Forms.TabPage startPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage depatureMonitorPage;
        private System.Windows.Forms.DataGridView depatureMonitorTable;
        private System.Windows.Forms.GroupBox depatureMonitorBox;
        private System.Windows.Forms.Label labelDepatureDate;
        private System.Windows.Forms.Label labelDepatureTime;
        private System.Windows.Forms.Label labelStationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn line;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn depature;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDepature;
        private System.Windows.Forms.ListBox listDepature;
        private System.Windows.Forms.Label labelConnectionDate;
        private System.Windows.Forms.DateTimePicker dpConnectionDate;
        private System.Windows.Forms.TextBox txtConnectionTime;
        private System.Windows.Forms.Label labelConnectionTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn connection;
        private System.Windows.Forms.DataGridViewTextBoxColumn endStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn station;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
    }
}

