namespace RIT_Solver
{
    partial class waybill_tracking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(waybill_tracking));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolWebReload = new System.Windows.Forms.ToolStripButton();
            this.toolWebLink = new System.Windows.Forms.ToolStripStatusLabel();
            this.webTrackingSystem = new CefSharp.WinForms.ChromiumWebBrowser();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolWebReload,
            this.toolWebLink});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolWebReload
            // 
            this.toolWebReload.Image = global::RIT_Solver.Properties.Resources.refresh;
            this.toolWebReload.Name = "toolWebReload";
            this.toolWebReload.Size = new System.Drawing.Size(73, 20);
            this.toolWebReload.Text = "Recargar";
            this.toolWebReload.Click += new System.EventHandler(this.toolWebReload_Click);
            // 
            // toolWebLink
            // 
            this.toolWebLink.Name = "toolWebLink";
            this.toolWebLink.Size = new System.Drawing.Size(118, 17);
            this.toolWebLink.Text = "toolStripStatusLabel1";
            // 
            // webTrackingSystem
            // 
            this.webTrackingSystem.ActivateBrowserOnCreation = false;
            this.webTrackingSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webTrackingSystem.Location = new System.Drawing.Point(0, 0);
            this.webTrackingSystem.Name = "webTrackingSystem";
            this.webTrackingSystem.Size = new System.Drawing.Size(800, 428);
            this.webTrackingSystem.TabIndex = 1;
            // 
            // waybill_tracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webTrackingSystem);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "waybill_tracking";
            this.Text = "Seguimiento de Guias";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.waybill_tracking_FormClosed);
            this.Load += new System.EventHandler(this.waybill_tracking_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolWebLink;
        private System.Windows.Forms.ToolStripButton toolWebReload;
        public CefSharp.WinForms.ChromiumWebBrowser webTrackingSystem;
    }
}