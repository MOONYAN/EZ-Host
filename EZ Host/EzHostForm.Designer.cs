namespace EZ_Host
{
    partial class EzHostForm
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
            this.components = new System.ComponentModel.Container();
            this._serverIPLabel = new System.Windows.Forms.Label();
            this._clientDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._qrPictureBox = new System.Windows.Forms.PictureBox();
            this._rfidDataGridView = new System.Windows.Forms.DataGridView();
            this._openPortButton = new System.Windows.Forms.Button();
            this._portComboBox = new System.Windows.Forms.ComboBox();
            this._serialPort = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._clientDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._qrPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._rfidDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _serverIPLabel
            // 
            this._serverIPLabel.AutoSize = true;
            this._serverIPLabel.Location = new System.Drawing.Point(3, 0);
            this._serverIPLabel.Name = "_serverIPLabel";
            this._serverIPLabel.Size = new System.Drawing.Size(48, 12);
            this._serverIPLabel.TabIndex = 0;
            this._serverIPLabel.Text = "Server IP";
            // 
            // _clientDataGridView
            // 
            this._clientDataGridView.AllowUserToAddRows = false;
            this._clientDataGridView.AllowUserToDeleteRows = false;
            this._clientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._clientDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._clientDataGridView.EnableHeadersVisualStyles = false;
            this._clientDataGridView.Location = new System.Drawing.Point(162, 3);
            this._clientDataGridView.Name = "_clientDataGridView";
            this._clientDataGridView.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this._clientDataGridView, 2);
            this._clientDataGridView.RowTemplate.Height = 24;
            this._clientDataGridView.Size = new System.Drawing.Size(633, 250);
            this._clientDataGridView.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.92481F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.07519F));
            this.tableLayoutPanel1.Controls.Add(this._openPortButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._portComboBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this._serverIPLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._qrPictureBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._clientDataGridView, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._rfidDataGridView, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(798, 512);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // _qrPictureBox
            // 
            this._qrPictureBox.Location = new System.Drawing.Point(3, 131);
            this._qrPictureBox.Name = "_qrPictureBox";
            this._qrPictureBox.Size = new System.Drawing.Size(153, 122);
            this._qrPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._qrPictureBox.TabIndex = 2;
            this._qrPictureBox.TabStop = false;
            // 
            // _rfidDataGridView
            // 
            this._rfidDataGridView.AllowUserToAddRows = false;
            this._rfidDataGridView.AllowUserToDeleteRows = false;
            this._rfidDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._rfidDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._rfidDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rfidDataGridView.EnableHeadersVisualStyles = false;
            this._rfidDataGridView.Location = new System.Drawing.Point(162, 259);
            this._rfidDataGridView.Name = "_rfidDataGridView";
            this._rfidDataGridView.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this._rfidDataGridView, 2);
            this._rfidDataGridView.RowTemplate.Height = 24;
            this._rfidDataGridView.Size = new System.Drawing.Size(633, 250);
            this._rfidDataGridView.TabIndex = 3;
            // 
            // _openPortButton
            // 
            this._openPortButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._openPortButton.Location = new System.Drawing.Point(3, 358);
            this._openPortButton.Name = "_openPortButton";
            this._openPortButton.Size = new System.Drawing.Size(153, 23);
            this._openPortButton.TabIndex = 5;
            this._openPortButton.Text = "Open Port";
            this._openPortButton.UseVisualStyleBackColor = true;
            this._openPortButton.Click += new System.EventHandler(this._openPortButton_Click);
            // 
            // _portComboBox
            // 
            this._portComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._portComboBox.FormattingEnabled = true;
            this._portComboBox.Location = new System.Drawing.Point(3, 489);
            this._portComboBox.Name = "_portComboBox";
            this._portComboBox.Size = new System.Drawing.Size(153, 20);
            this._portComboBox.TabIndex = 4;
            // 
            // _serialPort
            // 
            this._serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this._serialPort_DataReceived);
            // 
            // EzHostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 512);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EzHostForm";
            this.Text = "EzHostForm";
            this.Load += new System.EventHandler(this.EzHostForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._clientDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._qrPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._rfidDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _serverIPLabel;
        private System.Windows.Forms.DataGridView _clientDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox _qrPictureBox;
        private System.Windows.Forms.DataGridView _rfidDataGridView;
        private System.Windows.Forms.Button _openPortButton;
        private System.Windows.Forms.ComboBox _portComboBox;
        private System.IO.Ports.SerialPort _serialPort;
    }
}