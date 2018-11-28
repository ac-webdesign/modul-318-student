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
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stationTo = new System.Windows.Forms.ComboBox();
            this.stationFrom = new System.Windows.Forms.ComboBox();
            this.connectionsTable = new System.Windows.Forms.DataGridView();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depatureMonitor = new System.Windows.Forms.GroupBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelStationname = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.searchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsTable)).BeginInit();
            this.depatureMonitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Controls.Add(this.btnSearch);
            this.searchBox.Controls.Add(this.label2);
            this.searchBox.Controls.Add(this.label1);
            this.searchBox.Controls.Add(this.stationTo);
            this.searchBox.Controls.Add(this.stationFrom);
            this.searchBox.Location = new System.Drawing.Point(12, 68);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(415, 112);
            this.searchBox.TabIndex = 0;
            this.searchBox.TabStop = false;
            this.searchBox.Text = "Verbindungen suchen";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(340, 58);
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
            this.label2.Location = new System.Drawing.Point(178, 39);
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
            // stationTo
            // 
            this.stationTo.FormattingEnabled = true;
            this.stationTo.Location = new System.Drawing.Point(166, 57);
            this.stationTo.Name = "stationTo";
            this.stationTo.Size = new System.Drawing.Size(143, 21);
            this.stationTo.TabIndex = 1;
            // 
            // stationFrom
            // 
            this.stationFrom.FormattingEnabled = true;
            this.stationFrom.Location = new System.Drawing.Point(0, 55);
            this.stationFrom.Name = "stationFrom";
            this.stationFrom.Size = new System.Drawing.Size(143, 21);
            this.stationFrom.TabIndex = 0;
            // 
            // connectionsTable
            // 
            this.connectionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.connectionsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time,
            this.connection,
            this.station,
            this.duration});
            this.connectionsTable.Location = new System.Drawing.Point(12, 177);
            this.connectionsTable.Name = "connectionsTable";
            this.connectionsTable.Size = new System.Drawing.Size(416, 299);
            this.connectionsTable.TabIndex = 1;
            // 
            // time
            // 
            this.time.HeaderText = "Zeit";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // connection
            // 
            this.connection.HeaderText = "Verbindungen";
            this.connection.Name = "connection";
            this.connection.ReadOnly = true;
            // 
            // station
            // 
            this.station.HeaderText = "Gleis";
            this.station.Name = "station";
            // 
            // duration
            // 
            this.duration.HeaderText = "Dauer";
            this.duration.Name = "duration";
            // 
            // depatureMonitor
            // 
            this.depatureMonitor.Controls.Add(this.labelDate);
            this.depatureMonitor.Controls.Add(this.labelTime);
            this.depatureMonitor.Controls.Add(this.labelStationname);
            this.depatureMonitor.Location = new System.Drawing.Point(433, 68);
            this.depatureMonitor.Name = "depatureMonitor";
            this.depatureMonitor.Size = new System.Drawing.Size(437, 112);
            this.depatureMonitor.TabIndex = 2;
            this.depatureMonitor.TabStop = false;
            this.depatureMonitor.Text = "Abfahrtmonitor";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(351, 56);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(80, 16);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "20.08.2018";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(230, 56);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(44, 16);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "00:01";
            // 
            // labelStationname
            // 
            this.labelStationname.AutoSize = true;
            this.labelStationname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStationname.Location = new System.Drawing.Point(6, 50);
            this.labelStationname.Name = "labelStationname";
            this.labelStationname.Size = new System.Drawing.Size(135, 24);
            this.labelStationname.TabIndex = 0;
            this.labelStationname.Text = "Stationsname";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.line,
            this.gleis,
            this.fromTo,
            this.depature});
            this.dataGridView1.Location = new System.Drawing.Point(433, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 299);
            this.dataGridView1.TabIndex = 3;
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Öv-App";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 509);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.depatureMonitor);
            this.Controls.Add(this.connectionsTable);
            this.Controls.Add(this.searchBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.getStations);
            this.searchBox.ResumeLayout(false);
            this.searchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsTable)).EndInit();
            this.depatureMonitor.ResumeLayout(false);
            this.depatureMonitor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox searchBox;
        private System.Windows.Forms.ComboBox stationTo;
        private System.Windows.Forms.ComboBox stationFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView connectionsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn connection;
        private System.Windows.Forms.DataGridViewTextBoxColumn station;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.GroupBox depatureMonitor;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelStationname;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn line;
        private System.Windows.Forms.DataGridViewTextBoxColumn gleis;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn depature;
        private System.Windows.Forms.Label label3;
    }
}

