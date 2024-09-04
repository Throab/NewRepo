namespace Server.GUI
{
    partial class AddMoneyControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlRequestContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yêu cầu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlRequestContainer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 442);
            this.panel1.TabIndex = 1;
            // 
            // pnlRequestContainer
            // 
            this.pnlRequestContainer.AutoScroll = true;
            this.pnlRequestContainer.BackColor = System.Drawing.SystemColors.Control;
            this.pnlRequestContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlRequestContainer.Location = new System.Drawing.Point(57, 122);
            this.pnlRequestContainer.Name = "pnlRequestContainer";
            this.pnlRequestContainer.Size = new System.Drawing.Size(850, 300);
            this.pnlRequestContainer.TabIndex = 1;
            this.pnlRequestContainer.WrapContents = false;
            // 
            // AddMoneyControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddMoneyControl";
            this.Size = new System.Drawing.Size(965, 442);
            this.Load += new System.EventHandler(this.AddMoneyControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel pnlRequestContainer;
    }
}
