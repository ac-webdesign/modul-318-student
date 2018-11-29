namespace ov_project
{
    partial class Form1
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
            this.txtStationTo = new System.Windows.Forms.TextBox();
            this.listAllStationsTo = new System.Windows.Forms.ListBox();
            this.listAllStationsFrom = new System.Windows.Forms.ListBox();
            this.txtStationFrom = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.connectionsTable = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.depatureMonitorPage = new System.Windows.Forms.TabPage();
            this.depatureMonitorTable = new System.Windows.Forms.DataGridView();
            this.line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depatureMonitorBox = new System.Windows.Forms.GroupBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelStationName = new System.Windows.Forms.Label();
            this.searchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsTable)).BeginInit();
            this.Start.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.depatureMonitorPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depatureMonitorTable)).BeginInit();
            this.depatureMonitorBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Controls.Add(this.txtStationTo);
            this.searchBox.Controls.Add(this.listAllStationsTo);
            this.searchBox.Controls.Add(this.listAllStationsFrom);
            this.searchBox.Controls.Add(this.txtStationFrom);
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
            // txtStationTo
            // 
            this.txtStationTo.Location = new System.Drawing.Point(222, 58);
            this.txtStationTo.Name = "txtStationTo";
            this.txtStationTo.Size = new System.Drawing.Size(151, 20);
            this.txtStationTo.TabIndex = 7;
            this.txtStationTo.TextChanged += new System.EventHandler(this.getAllStations);
            // 
            // listAllStationsTo
            // 
            this.listAllStationsTo.FormattingEnabled = true;
            this.listAllStationsTo.Location = new System.Drawing.Point(222, 74);
            this.listAllStationsTo.Name = "listAllStationsTo";
            this.listAllStationsTo.Size = new System.Drawing.Size(151, 43);
            this.listAllStationsTo.TabIndex = 6;
            this.listAllStationsTo.DoubleClick += new System.EventHandler(this.putToStation);
            // 
            // listAllStationsFrom
            // 
            this.listAllStationsFrom.FormattingEnabled = true;
            this.listAllStationsFrom.Location = new System.Drawing.Point(9, 74);
            this.listAllStationsFrom.Name = "listAllStationsFrom";
            this.listAllStationsFrom.Size = new System.Drawing.Size(151, 43);
            this.listAllStationsFrom.TabIndex = 5;
            this.listAllStationsFrom.DoubleClick += new System.EventHandler(this.putToStation);
            // 
            // txtStationFrom
            // 
            this.txtStationFrom.Location = new System.Drawing.Point(9, 57);
            this.txtStationFrom.Name = "txtStationFrom";
            this.txtStationFrom.Size = new System.Drawing.Size(151, 20);
            this.txtStationFrom.TabIndex = 4;
            this.txtStationFrom.TextChanged += new System.EventHandler(this.getAllStations);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(416, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 20);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 42);
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
            this.connectionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.connectionsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.connection,
            this.endStation,
            this.station,
            this.duration});
            this.connectionsTable.Location = new System.Drawing.Point(3, 185);
            this.connectionsTable.Name = "connectionsTable";
            this.connectionsTable.ReadOnly = true;
            this.connectionsTable.Size = new System.Drawing.Size(948, 317);
            this.connectionsTable.TabIndex = 1;
            // 
            // date
            // 
            this.date.HeaderText = "Datum";
            this.date.Name = "date";
            this.date.ReadOnly = true;
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
            this.Start.Controls.Add(this.tabPage1);
            this.Start.Controls.Add(this.depatureMonitorPage);
            this.Start.Location = new System.Drawing.Point(8, 12);
            this.Start.Name = "Start";
            this.Start.SelectedIndex = 0;
            this.Start.Size = new System.Drawing.Size(955, 551);
            this.Start.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.searchBox);
            this.tabPage1.Controls.Add(this.connectionsTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(947, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Start";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.depatureMonitorPage.Size = new System.Drawing.Size(947, 525);
            this.depatureMonitorPage.TabIndex = 1;
            this.depatureMonitorPage.Text = "Abfahrtmonitor";
            this.depatureMonitorPage.UseVisualStyleBackColor = true;
            // 
            // depatureMonitorTable
            // 
            this.depatureMonitorTable.AllowUserToAddRows = false;
            this.depatureMonitorTable.AllowUserToDeleteRows = false;
            this.depatureMonitorTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depatureMonitorTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.line,
            this.gleis,
            this.fromTo,
            this.depature});
            this.depatureMonitorTable.Location = new System.Drawing.Point(0, 121);
            this.depatureMonitorTable.Name = "depatureMonitorTable";
            this.depatureMonitorTable.ReadOnly = true;
            this.depatureMonitorTable.Size = new System.Drawing.Size(947, 398);
            this.depatureMonitorTable.TabIndex = 5;
            // 
            // line
            // 
            this.line.HeaderText = "Linie";
            this.line.Name = "line";
            this.line.ReadOnly = true;
            // 
            // gleis
            // 
            this.gleis.HeaderText = "Gleis";
            this.gleis.Name = "gleis";
            this.gleis.ReadOnly = true;
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
            this.depatureMonitorBox.Controls.Add(this.labelDate);
            this.depatureMonitorBox.Controls.Add(this.labelTime);
            this.depatureMonitorBox.Controls.Add(this.labelStationName);
            this.depatureMonitorBox.Location = new System.Drawing.Point(0, 6);
            this.depatureMonitorBox.Name = "depatureMonitorBox";
            this.depatureMonitorBox.Size = new System.Drawing.Size(947, 109);
            this.depatureMonitorBox.TabIndex = 4;
            this.depatureMonitorBox.TabStop = false;
            this.depatureMonitorBox.Text = "Abfahrtmonitor";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(821, 48);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(80, 16);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "20.08.2018";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(451, 48);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(44, 16);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "00:01";
            // 
            // labelStationName
            // 
            this.labelStationName.AutoSize = true;
            this.labelStationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStationName.Location = new System.Drawing.Point(6, 42);
            this.labelStationName.Name = "labelStationName";
            this.labelStationName.Size = new System.Drawing.Size(135, 24);
            this.labelStationName.TabIndex = 0;
            this.labelStationName.Text = "Stationsname";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 575);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.getData);
            this.searchBox.ResumeLayout(false);
            this.searchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsTable)).EndInit();
            this.Start.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage depatureMonitorPage;
        private System.Windows.Forms.DataGridView depatureMonitorTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn line;
        private System.Windows.Forms.DataGridViewTextBoxColumn gleis;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn depature;
        private System.Windows.Forms.GroupBox depatureMonitorBox;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelStationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn connection;
        private System.Windows.Forms.DataGridViewTextBoxColumn endStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn station;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
    }
}

