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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ovForm));
            this.searchBox = new System.Windows.Forms.GroupBox();
            this.dpConnectionTime = new System.Windows.Forms.DateTimePicker();
            this.btnLocationOfStationFrom = new System.Windows.Forms.Button();
            this.btnLocationImages = new System.Windows.Forms.ImageList(this.components);
            this.btnLocationOfStationTo = new System.Windows.Forms.Button();
            this.listStationTo = new System.Windows.Forms.ListBox();
            this.listStationFrom = new System.Windows.Forms.ListBox();
            this.txtStationTo = new System.Windows.Forms.TextBox();
            this.txtStationFrom = new System.Windows.Forms.TextBox();
            this.labelConnectionTime = new System.Windows.Forms.Label();
            this.labelConnectionDate = new System.Windows.Forms.Label();
            this.dpConnectionDate = new System.Windows.Forms.DateTimePicker();
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
            this.listDepatureFrom = new System.Windows.Forms.ListBox();
            this.txtDepatureFrom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDepatureDate = new System.Windows.Forms.Label();
            this.labelDepatureTime = new System.Windows.Forms.Label();
            this.labelStationName = new System.Windows.Forms.Label();
            this.stationToIsEqualStationFrom = new System.Windows.Forms.ErrorProvider(this.components);
            this.falseFromatProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.searchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsTable)).BeginInit();
            this.Start.SuspendLayout();
            this.startPage.SuspendLayout();
            this.depatureMonitorPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depatureMonitorTable)).BeginInit();
            this.depatureMonitorBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationToIsEqualStationFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falseFromatProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Controls.Add(this.dpConnectionTime);
            this.searchBox.Controls.Add(this.btnLocationOfStationFrom);
            this.searchBox.Controls.Add(this.btnLocationOfStationTo);
            this.searchBox.Controls.Add(this.listStationTo);
            this.searchBox.Controls.Add(this.listStationFrom);
            this.searchBox.Controls.Add(this.txtStationTo);
            this.searchBox.Controls.Add(this.txtStationFrom);
            this.searchBox.Controls.Add(this.labelConnectionTime);
            this.searchBox.Controls.Add(this.labelConnectionDate);
            this.searchBox.Controls.Add(this.dpConnectionDate);
            this.searchBox.Controls.Add(this.btnSearch);
            this.searchBox.Controls.Add(this.label2);
            this.searchBox.Controls.Add(this.label1);
            this.searchBox.Location = new System.Drawing.Point(3, 62);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(944, 121);
            this.searchBox.TabIndex = 0;
            this.searchBox.TabStop = false;
            this.searchBox.Text = "Verbindungen suchen";
            // 
            // dpConnectionTime
            // 
            this.dpConnectionTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dpConnectionTime.Location = new System.Drawing.Point(536, 91);
            this.dpConnectionTime.Name = "dpConnectionTime";
            this.dpConnectionTime.ShowUpDown = true;
            this.dpConnectionTime.Size = new System.Drawing.Size(106, 20);
            this.dpConnectionTime.TabIndex = 20;
            this.dpConnectionTime.Visible = false;
            // 
            // btnLocationOfStationFrom
            // 
            this.btnLocationOfStationFrom.ImageIndex = 0;
            this.btnLocationOfStationFrom.ImageList = this.btnLocationImages;
            this.btnLocationOfStationFrom.Location = new System.Drawing.Point(166, 55);
            this.btnLocationOfStationFrom.Name = "btnLocationOfStationFrom";
            this.btnLocationOfStationFrom.Size = new System.Drawing.Size(30, 33);
            this.btnLocationOfStationFrom.TabIndex = 19;
            this.btnLocationOfStationFrom.UseVisualStyleBackColor = true;
            this.btnLocationOfStationFrom.Visible = false;
            this.btnLocationOfStationFrom.Click += new System.EventHandler(this.btnLocationOfStation_Click);
            // 
            // btnLocationImages
            // 
            this.btnLocationImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("btnLocationImages.ImageStream")));
            this.btnLocationImages.TransparentColor = System.Drawing.Color.Transparent;
            this.btnLocationImages.Images.SetKeyName(0, "google-location-icon-16.ico");
            // 
            // btnLocationOfStationTo
            // 
            this.btnLocationOfStationTo.ImageIndex = 0;
            this.btnLocationOfStationTo.ImageList = this.btnLocationImages;
            this.btnLocationOfStationTo.Location = new System.Drawing.Point(370, 55);
            this.btnLocationOfStationTo.Name = "btnLocationOfStationTo";
            this.btnLocationOfStationTo.Size = new System.Drawing.Size(30, 33);
            this.btnLocationOfStationTo.TabIndex = 18;
            this.btnLocationOfStationTo.UseVisualStyleBackColor = true;
            this.btnLocationOfStationTo.Visible = false;
            this.btnLocationOfStationTo.Click += new System.EventHandler(this.btnLocationOfStation_Click);
            // 
            // listStationTo
            // 
            this.listStationTo.FormattingEnabled = true;
            this.listStationTo.Location = new System.Drawing.Point(213, 74);
            this.listStationTo.Name = "listStationTo";
            this.listStationTo.Size = new System.Drawing.Size(151, 43);
            this.listStationTo.TabIndex = 16;
            this.listStationTo.Visible = false;
            this.listStationTo.DoubleClick += new System.EventHandler(this.putSelectedStationToCorrectTextbox);
            // 
            // listStationFrom
            // 
            this.listStationFrom.FormattingEnabled = true;
            this.listStationFrom.Location = new System.Drawing.Point(9, 74);
            this.listStationFrom.Name = "listStationFrom";
            this.listStationFrom.Size = new System.Drawing.Size(151, 43);
            this.listStationFrom.TabIndex = 15;
            this.listStationFrom.Visible = false;
            this.listStationFrom.DoubleClick += new System.EventHandler(this.putSelectedStationToCorrectTextbox);
            // 
            // txtStationTo
            // 
            this.txtStationTo.Location = new System.Drawing.Point(213, 55);
            this.txtStationTo.Name = "txtStationTo";
            this.txtStationTo.Size = new System.Drawing.Size(151, 20);
            this.txtStationTo.TabIndex = 13;
            this.txtStationTo.TextChanged += new System.EventHandler(this.getAllStations);
            this.txtStationTo.Leave += new System.EventHandler(this.showDateAndTimeOption);
            // 
            // txtStationFrom
            // 
            this.txtStationFrom.Location = new System.Drawing.Point(9, 55);
            this.txtStationFrom.Name = "txtStationFrom";
            this.txtStationFrom.Size = new System.Drawing.Size(151, 20);
            this.txtStationFrom.TabIndex = 12;
            this.txtStationFrom.TextChanged += new System.EventHandler(this.getAllStations);
            this.txtStationFrom.Leave += new System.EventHandler(this.showDateAndTimeOption);
            // 
            // labelConnectionTime
            // 
            this.labelConnectionTime.AutoSize = true;
            this.labelConnectionTime.Location = new System.Drawing.Point(533, 75);
            this.labelConnectionTime.Name = "labelConnectionTime";
            this.labelConnectionTime.Size = new System.Drawing.Size(65, 13);
            this.labelConnectionTime.TabIndex = 10;
            this.labelConnectionTime.Text = "Zeit (hh:mm)";
            this.labelConnectionTime.Visible = false;
            // 
            // labelConnectionDate
            // 
            this.labelConnectionDate.AutoSize = true;
            this.labelConnectionDate.Location = new System.Drawing.Point(432, 39);
            this.labelConnectionDate.Name = "labelConnectionDate";
            this.labelConnectionDate.Size = new System.Drawing.Size(38, 13);
            this.labelConnectionDate.TabIndex = 9;
            this.labelConnectionDate.Text = "Datum";
            this.labelConnectionDate.Visible = false;
            // 
            // dpConnectionDate
            // 
            this.dpConnectionDate.Location = new System.Drawing.Point(435, 55);
            this.dpConnectionDate.Name = "dpConnectionDate";
            this.dpConnectionDate.Size = new System.Drawing.Size(207, 20);
            this.dpConnectionDate.TabIndex = 8;
            this.dpConnectionDate.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(681, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 20);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearchConnections_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nach";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
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
            this.connectionsTable.Location = new System.Drawing.Point(3, 185);
            this.connectionsTable.Name = "connectionsTable";
            this.connectionsTable.ReadOnly = true;
            this.connectionsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.connectionsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.connectionsTable.Size = new System.Drawing.Size(948, 317);
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
            this.connection.Width = 252;
            // 
            // endStation
            // 
            this.endStation.HeaderText = "Ziel";
            this.endStation.Name = "endStation";
            this.endStation.ReadOnly = true;
            this.endStation.Width = 252;
            // 
            // station
            // 
            this.station.HeaderText = "Gleis";
            this.station.Name = "station";
            this.station.ReadOnly = true;
            // 
            // duration
            // 
            this.duration.HeaderText = "Reisedauer";
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
            this.Start.Location = new System.Drawing.Point(8, 12);
            this.Start.Name = "Start";
            this.Start.SelectedIndex = 0;
            this.Start.Size = new System.Drawing.Size(964, 537);
            this.Start.TabIndex = 5;
            this.Start.SelectedIndexChanged += new System.EventHandler(this.setDepatureMonitorSettings);
            // 
            // startPage
            // 
            this.startPage.Controls.Add(this.label3);
            this.startPage.Controls.Add(this.searchBox);
            this.startPage.Controls.Add(this.connectionsTable);
            this.startPage.Location = new System.Drawing.Point(4, 22);
            this.startPage.Name = "startPage";
            this.startPage.Padding = new System.Windows.Forms.Padding(3);
            this.startPage.Size = new System.Drawing.Size(956, 511);
            this.startPage.TabIndex = 0;
            this.startPage.Text = "Start";
            this.startPage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Öv-App";
            // 
            // depatureMonitorPage
            // 
            this.depatureMonitorPage.Controls.Add(this.depatureMonitorTable);
            this.depatureMonitorPage.Controls.Add(this.depatureMonitorBox);
            this.depatureMonitorPage.Location = new System.Drawing.Point(4, 22);
            this.depatureMonitorPage.Name = "depatureMonitorPage";
            this.depatureMonitorPage.Padding = new System.Windows.Forms.Padding(3);
            this.depatureMonitorPage.Size = new System.Drawing.Size(956, 511);
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
            this.depatureMonitorTable.Location = new System.Drawing.Point(0, 134);
            this.depatureMonitorTable.Name = "depatureMonitorTable";
            this.depatureMonitorTable.ReadOnly = true;
            this.depatureMonitorTable.Size = new System.Drawing.Size(947, 385);
            this.depatureMonitorTable.TabIndex = 5;
            this.depatureMonitorTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showDepatureDetails);
            // 
            // line
            // 
            this.line.HeaderText = "Linie";
            this.line.Name = "line";
            this.line.ReadOnly = true;
            this.line.Width = 300;
            // 
            // fromTo
            // 
            this.fromTo.HeaderText = "Ziel";
            this.fromTo.Name = "fromTo";
            this.fromTo.ReadOnly = true;
            this.fromTo.Width = 302;
            // 
            // depature
            // 
            this.depature.HeaderText = "Abfahrt";
            this.depature.Name = "depature";
            this.depature.ReadOnly = true;
            this.depature.Width = 302;
            // 
            // depatureMonitorBox
            // 
            this.depatureMonitorBox.Controls.Add(this.listDepatureFrom);
            this.depatureMonitorBox.Controls.Add(this.txtDepatureFrom);
            this.depatureMonitorBox.Controls.Add(this.label4);
            this.depatureMonitorBox.Controls.Add(this.labelDepatureDate);
            this.depatureMonitorBox.Controls.Add(this.labelDepatureTime);
            this.depatureMonitorBox.Controls.Add(this.labelStationName);
            this.depatureMonitorBox.Location = new System.Drawing.Point(0, 6);
            this.depatureMonitorBox.Name = "depatureMonitorBox";
            this.depatureMonitorBox.Size = new System.Drawing.Size(947, 131);
            this.depatureMonitorBox.TabIndex = 4;
            this.depatureMonitorBox.TabStop = false;
            this.depatureMonitorBox.Text = "Abfahrtmonitor";
            // 
            // listDepatureFrom
            // 
            this.listDepatureFrom.FormattingEnabled = true;
            this.listDepatureFrom.Location = new System.Drawing.Point(21, 66);
            this.listDepatureFrom.Name = "listDepatureFrom";
            this.listDepatureFrom.Size = new System.Drawing.Size(151, 56);
            this.listDepatureFrom.TabIndex = 16;
            this.listDepatureFrom.Visible = false;
            this.listDepatureFrom.DoubleClick += new System.EventHandler(this.putSelectedStationToCorrectTextbox);
            // 
            // txtDepatureFrom
            // 
            this.txtDepatureFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDepatureFrom.Location = new System.Drawing.Point(21, 49);
            this.txtDepatureFrom.Name = "txtDepatureFrom";
            this.txtDepatureFrom.Size = new System.Drawing.Size(151, 20);
            this.txtDepatureFrom.TabIndex = 14;
            this.txtDepatureFrom.TextChanged += new System.EventHandler(this.getAllStations);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Abfahrt";
            // 
            // labelDepatureDate
            // 
            this.labelDepatureDate.AutoSize = true;
            this.labelDepatureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepatureDate.Location = new System.Drawing.Point(823, 55);
            this.labelDepatureDate.Name = "labelDepatureDate";
            this.labelDepatureDate.Size = new System.Drawing.Size(80, 16);
            this.labelDepatureDate.TabIndex = 2;
            this.labelDepatureDate.Text = "20.08.2018";
            // 
            // labelDepatureTime
            // 
            this.labelDepatureTime.AutoSize = true;
            this.labelDepatureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepatureTime.Location = new System.Drawing.Point(645, 55);
            this.labelDepatureTime.Name = "labelDepatureTime";
            this.labelDepatureTime.Size = new System.Drawing.Size(44, 16);
            this.labelDepatureTime.TabIndex = 1;
            this.labelDepatureTime.Text = "00:01";
            // 
            // labelStationName
            // 
            this.labelStationName.AutoSize = true;
            this.labelStationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStationName.Location = new System.Drawing.Point(202, 49);
            this.labelStationName.Name = "labelStationName";
            this.labelStationName.Size = new System.Drawing.Size(135, 24);
            this.labelStationName.TabIndex = 0;
            this.labelStationName.Text = "Stationsname";
            this.labelStationName.Visible = false;
            // 
            // stationToIsEqualStationFrom
            // 
            this.stationToIsEqualStationFrom.ContainerControl = this;
            // 
            // falseFromatProvider
            // 
            this.falseFromatProvider.ContainerControl = this;
            // 
            // ovForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "ovForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "OV-App";
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
            ((System.ComponentModel.ISupportInitialize)(this.stationToIsEqualStationFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falseFromatProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox searchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabControl Start;
        private System.Windows.Forms.TabPage startPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage depatureMonitorPage;
        private System.Windows.Forms.GroupBox depatureMonitorBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelConnectionDate;
        private System.Windows.Forms.DateTimePicker dpConnectionDate;
        private System.Windows.Forms.Label labelConnectionTime;
        private System.Windows.Forms.TextBox txtStationFrom;
        private System.Windows.Forms.TextBox txtStationTo;
        private System.Windows.Forms.TextBox txtDepatureFrom;
        private System.Windows.Forms.ErrorProvider stationToIsEqualStationFrom;
        public System.Windows.Forms.DataGridView connectionsTable;
        public System.Windows.Forms.Label labelDepatureDate;
        public System.Windows.Forms.Label labelDepatureTime;
        public System.Windows.Forms.Label labelStationName;
        public System.Windows.Forms.DataGridView depatureMonitorTable;
        private System.Windows.Forms.ErrorProvider falseFromatProvider;
        private System.Windows.Forms.ListBox listStationTo;
        private System.Windows.Forms.ListBox listStationFrom;
        private System.Windows.Forms.ListBox listDepatureFrom;
        private System.Windows.Forms.ImageList btnLocationImages;
        private System.Windows.Forms.Button btnLocationOfStationFrom;
        private System.Windows.Forms.Button btnLocationOfStationTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn connection;
        private System.Windows.Forms.DataGridViewTextBoxColumn endStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn station;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn line;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn depature;
        private System.Windows.Forms.DateTimePicker dpConnectionTime;
    }
}

