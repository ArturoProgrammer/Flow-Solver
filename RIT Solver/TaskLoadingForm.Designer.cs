namespace Flow_Solver
{
    partial class TaskLoadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskLoadingForm));
            this.progressBarJobStatus = new System.Windows.Forms.ProgressBar();
            this.lblCaption = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.backgroundWorker_JobsToDo = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarJobStatus
            // 
            this.progressBarJobStatus.Location = new System.Drawing.Point(12, 77);
            this.progressBarJobStatus.Name = "progressBarJobStatus";
            this.progressBarJobStatus.Size = new System.Drawing.Size(565, 23);
            this.progressBarJobStatus.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarJobStatus.TabIndex = 1;
            // 
            // lblCaption
            // 
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(67, 36);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(424, 38);
            this.lblCaption.TabIndex = 40;
            this.lblCaption.Text = "Respalda la informacion de usuario en el programa para usarse en una instalacion " +
    "futura.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Flow_Solver.Properties.Resources.sand_clock;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(66, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(234, 24);
            this.lblTitle.TabIndex = 41;
            this.lblTitle.Text = "Exportar Configuracion";
            // 
            // backgroundWorker_JobsToDo
            // 
            this.backgroundWorker_JobsToDo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_JobsToDo_DoWork);
            this.backgroundWorker_JobsToDo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_JobsToDo_RunWorkerCompleted);
            // 
            // TaskLoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 123);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.progressBarJobStatus);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskLoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RIT Solver - Ejecutando tarea en progreso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskLoadingForm_FormClosing);
            this.Load += new System.EventHandler(this.TaskLoadingForm_Load);
            this.Shown += new System.EventHandler(this.TaskLoadingForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBarJobStatus;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Label lblTitle;
        private System.ComponentModel.BackgroundWorker backgroundWorker_JobsToDo;
    }
}