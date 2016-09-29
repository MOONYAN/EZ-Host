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
            this._serverIPLabel = new System.Windows.Forms.Label();
            this._itemDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._qrPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._itemDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._qrPictureBox)).BeginInit();
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
            // _itemDataGridView
            // 
            this._itemDataGridView.AllowUserToAddRows = false;
            this._itemDataGridView.AllowUserToDeleteRows = false;
            this._itemDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._itemDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._itemDataGridView.EnableHeadersVisualStyles = false;
            this._itemDataGridView.Location = new System.Drawing.Point(3, 128);
            this._itemDataGridView.Name = "_itemDataGridView";
            this._itemDataGridView.RowHeadersVisible = false;
            this._itemDataGridView.RowTemplate.Height = 24;
            this._itemDataGridView.Size = new System.Drawing.Size(361, 339);
            this._itemDataGridView.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this._serverIPLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._itemDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._qrPictureBox, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.2F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(734, 470);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // _qrPictureBox
            // 
            this._qrPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._qrPictureBox.Location = new System.Drawing.Point(370, 128);
            this._qrPictureBox.Name = "_qrPictureBox";
            this._qrPictureBox.Size = new System.Drawing.Size(361, 339);
            this._qrPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._qrPictureBox.TabIndex = 2;
            this._qrPictureBox.TabStop = false;
            // 
            // EzHostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 470);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EzHostForm";
            this.Text = "EzHostForm";
            this.Load += new System.EventHandler(this.EzHostForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._itemDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._qrPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _serverIPLabel;
        private System.Windows.Forms.DataGridView _itemDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox _qrPictureBox;
    }
}