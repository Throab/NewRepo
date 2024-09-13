namespace Server.GUI
{
    partial class RequestControl
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
            this.pnlRequestContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDetailContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRequestContainer
            // 
            this.pnlRequestContainer.AutoScroll = true;
            this.pnlRequestContainer.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlRequestContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlRequestContainer.Location = new System.Drawing.Point(3, 94);
            this.pnlRequestContainer.Name = "pnlRequestContainer";
            this.pnlRequestContainer.Size = new System.Drawing.Size(592, 345);
            this.pnlRequestContainer.TabIndex = 0;
            // 
            // pnlDetailContainer
            // 
            this.pnlDetailContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDetailContainer.Location = new System.Drawing.Point(601, 0);
            this.pnlDetailContainer.Name = "pnlDetailContainer";
            this.pnlDetailContainer.Size = new System.Drawing.Size(364, 442);
            this.pnlDetailContainer.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 68);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách đặt món";
            // 
            // RequestControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDetailContainer);
            this.Controls.Add(this.pnlRequestContainer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RequestControl";
            this.Size = new System.Drawing.Size(965, 442);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlRequestContainer;
        private System.Windows.Forms.Panel pnlDetailContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
