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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._clientGroupBox = new System.Windows.Forms.GroupBox();
            this._clientDataGridView = new System.Windows.Forms.DataGridView();
            this._rfidGroupBox = new System.Windows.Forms.GroupBox();
            this._rfidTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._rfidDataGridView = new System.Windows.Forms.DataGridView();
            this._openPortButton = new System.Windows.Forms.Button();
            this._portComboBox = new System.Windows.Forms.ComboBox();
            this._serverGroupBox = new System.Windows.Forms.GroupBox();
            this._qrPictureBox = new System.Windows.Forms.PictureBox();
            this._stateLabel = new System.Windows.Forms.Label();
            this._serialPort = new System.IO.Ports.SerialPort(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this._clientGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._clientDataGridView)).BeginInit();
            this._rfidGroupBox.SuspendLayout();
            this._rfidTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._rfidDataGridView)).BeginInit();
            this._serverGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._qrPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this._clientGroupBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._rfidGroupBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this._serverGroupBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._stateLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(521, 404);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // _clientGroupBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this._clientGroupBox, 2);
            this._clientGroupBox.Controls.Add(this._clientDataGridView);
            this._clientGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._clientGroupBox.Location = new System.Drawing.Point(3, 244);
            this._clientGroupBox.Name = "_clientGroupBox";
            this._clientGroupBox.Size = new System.Drawing.Size(515, 157);
            this._clientGroupBox.TabIndex = 10;
            this._clientGroupBox.TabStop = false;
            this._clientGroupBox.Text = "Client Data";
            // 
            // _clientDataGridView
            // 
            this._clientDataGridView.AllowUserToAddRows = false;
            this._clientDataGridView.AllowUserToDeleteRows = false;
            this._clientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._clientDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._clientDataGridView.EnableHeadersVisualStyles = false;
            this._clientDataGridView.Location = new System.Drawing.Point(3, 18);
            this._clientDataGridView.Name = "_clientDataGridView";
            this._clientDataGridView.RowHeadersVisible = false;
            this._clientDataGridView.RowTemplate.Height = 24;
            this._clientDataGridView.Size = new System.Drawing.Size(509, 136);
            this._clientDataGridView.TabIndex = 2;
            // 
            // _rfidGroupBox
            // 
            this._rfidGroupBox.Controls.Add(this._rfidTableLayoutPanel);
            this._rfidGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rfidGroupBox.Location = new System.Drawing.Point(159, 83);
            this._rfidGroupBox.Name = "_rfidGroupBox";
            this._rfidGroupBox.Size = new System.Drawing.Size(359, 155);
            this._rfidGroupBox.TabIndex = 9;
            this._rfidGroupBox.TabStop = false;
            this._rfidGroupBox.Text = "RFID Reader";
            // 
            // _rfidTableLayoutPanel
            // 
            this._rfidTableLayoutPanel.ColumnCount = 2;
            this._rfidTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._rfidTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this._rfidTableLayoutPanel.Controls.Add(this._rfidDataGridView, 1, 0);
            this._rfidTableLayoutPanel.Controls.Add(this._openPortButton, 0, 1);
            this._rfidTableLayoutPanel.Controls.Add(this._portComboBox, 0, 0);
            this._rfidTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rfidTableLayoutPanel.Location = new System.Drawing.Point(3, 18);
            this._rfidTableLayoutPanel.Name = "_rfidTableLayoutPanel";
            this._rfidTableLayoutPanel.RowCount = 2;
            this._rfidTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._rfidTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._rfidTableLayoutPanel.Size = new System.Drawing.Size(353, 134);
            this._rfidTableLayoutPanel.TabIndex = 0;
            // 
            // _rfidDataGridView
            // 
            this._rfidDataGridView.AllowUserToAddRows = false;
            this._rfidDataGridView.AllowUserToDeleteRows = false;
            this._rfidDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._rfidDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._rfidDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rfidDataGridView.EnableHeadersVisualStyles = false;
            this._rfidDataGridView.Location = new System.Drawing.Point(108, 3);
            this._rfidDataGridView.Name = "_rfidDataGridView";
            this._rfidDataGridView.RowHeadersVisible = false;
            this._rfidTableLayoutPanel.SetRowSpan(this._rfidDataGridView, 2);
            this._rfidDataGridView.RowTemplate.Height = 24;
            this._rfidDataGridView.Size = new System.Drawing.Size(242, 128);
            this._rfidDataGridView.TabIndex = 7;
            // 
            // _openPortButton
            // 
            this._openPortButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._openPortButton.Location = new System.Drawing.Point(3, 108);
            this._openPortButton.Name = "_openPortButton";
            this._openPortButton.Size = new System.Drawing.Size(99, 23);
            this._openPortButton.TabIndex = 6;
            this._openPortButton.Text = "Open Port";
            this._openPortButton.UseVisualStyleBackColor = true;
            this._openPortButton.Click += new System.EventHandler(this._openPortButton_Click);
            // 
            // _portComboBox
            // 
            this._portComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._portComboBox.FormattingEnabled = true;
            this._portComboBox.Location = new System.Drawing.Point(3, 44);
            this._portComboBox.Name = "_portComboBox";
            this._portComboBox.Size = new System.Drawing.Size(99, 20);
            this._portComboBox.TabIndex = 5;
            // 
            // _serverGroupBox
            // 
            this._serverGroupBox.Controls.Add(this._qrPictureBox);
            this._serverGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._serverGroupBox.Location = new System.Drawing.Point(3, 83);
            this._serverGroupBox.Name = "_serverGroupBox";
            this._serverGroupBox.Size = new System.Drawing.Size(150, 155);
            this._serverGroupBox.TabIndex = 8;
            this._serverGroupBox.TabStop = false;
            this._serverGroupBox.Text = "Server IP";
            // 
            // _qrPictureBox
            // 
            this._qrPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._qrPictureBox.Location = new System.Drawing.Point(3, 18);
            this._qrPictureBox.Name = "_qrPictureBox";
            this._qrPictureBox.Size = new System.Drawing.Size(144, 134);
            this._qrPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._qrPictureBox.TabIndex = 3;
            this._qrPictureBox.TabStop = false;
            // 
            // _stateLabel
            // 
            this._stateLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this._stateLabel, 2);
            this._stateLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._stateLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._stateLabel.Location = new System.Drawing.Point(3, 0);
            this._stateLabel.Name = "_stateLabel";
            this._stateLabel.Size = new System.Drawing.Size(515, 24);
            this._stateLabel.TabIndex = 7;
            this._stateLabel.Text = "Default State";
            this._stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _serialPort
            // 
            this._serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this._serialPort_DataReceived);
            // 
            // EzHostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 404);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EzHostForm";
            this.Text = "EzHostForm";
            this.Load += new System.EventHandler(this.EzHostForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this._clientGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._clientDataGridView)).EndInit();
            this._rfidGroupBox.ResumeLayout(false);
            this._rfidTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._rfidDataGridView)).EndInit();
            this._serverGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._qrPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.IO.Ports.SerialPort _serialPort;
        private System.Windows.Forms.GroupBox _clientGroupBox;
        private System.Windows.Forms.DataGridView _clientDataGridView;
        private System.Windows.Forms.GroupBox _rfidGroupBox;
        private System.Windows.Forms.TableLayoutPanel _rfidTableLayoutPanel;
        private System.Windows.Forms.DataGridView _rfidDataGridView;
        private System.Windows.Forms.Button _openPortButton;
        private System.Windows.Forms.ComboBox _portComboBox;
        private System.Windows.Forms.GroupBox _serverGroupBox;
        private System.Windows.Forms.PictureBox _qrPictureBox;
        private System.Windows.Forms.Label _stateLabel;
    }
}