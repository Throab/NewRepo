namespace Server.GUI
{
    partial class ClientHomePageUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tplClient = new System.Windows.Forms.TableLayoutPanel();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblGroupClient = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tplClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tplClient
            // 
            this.tplClient.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tplClient.ColumnCount = 3;
            this.tplClient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tplClient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tplClient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.tplClient.Controls.Add(this.lblClientName, 0, 0);
            this.tplClient.Controls.Add(this.lblGroupClient, 1, 0);
            this.tplClient.Controls.Add(this.lblStatus, 2, 0);
            this.tplClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tplClient.Location = new System.Drawing.Point(0, 0);
            this.tplClient.Name = "tplClient";
            this.tplClient.RowCount = 1;
            this.tplClient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplClient.Size = new System.Drawing.Size(492, 36);
            this.tplClient.TabIndex = 0;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClientName.Location = new System.Drawing.Point(4, 1);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(144, 34);
            this.lblClientName.TabIndex = 0;
            this.lblClientName.Text = "MAY1";
            this.lblClientName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGroupClient
            // 
            this.lblGroupClient.AutoSize = true;
            this.lblGroupClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGroupClient.Location = new System.Drawing.Point(155, 1);
            this.lblGroupClient.Name = "lblGroupClient";
            this.lblGroupClient.Size = new System.Drawing.Size(144, 34);
            this.lblGroupClient.TabIndex = 1;
            this.lblGroupClient.Text = "basic";
            this.lblGroupClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGroupClient.Click += new System.EventHandler(this.lblGroupClient_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Location = new System.Drawing.Point(306, 1);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(186, 34);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "DISCONNECTED";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientHomePageUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tplClient);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ClientHomePageUserControl";
            this.Size = new System.Drawing.Size(492, 36);
            this.tplClient.ResumeLayout(false);
            this.tplClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tplClient;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblGroupClient;
        private System.Windows.Forms.Label lblStatus;
    }
}
