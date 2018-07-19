namespace RocCue
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pannelLast = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.lastWhat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lastCue = new System.Windows.Forms.Label();
            this.pannelCurrent = new System.Windows.Forms.Panel();
            this.currentWhat = new System.Windows.Forms.Label();
            this.currentCue = new System.Windows.Forms.Label();
            this.pannelNext = new System.Windows.Forms.Panel();
            this.nextWhat = new System.Windows.Forms.Label();
            this.nextCue = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.pannelLast.SuspendLayout();
            this.pannelCurrent.SuspendLayout();
            this.pannelNext.SuspendLayout();
            this.SuspendLayout();
            // 
            // pannelLast
            // 
            this.pannelLast.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pannelLast.Controls.Add(this.Title);
            this.pannelLast.Controls.Add(this.lastWhat);
            this.pannelLast.Controls.Add(this.label1);
            this.pannelLast.Controls.Add(this.lastCue);
            this.pannelLast.Location = new System.Drawing.Point(23, 81);
            this.pannelLast.Name = "pannelLast";
            this.pannelLast.Size = new System.Drawing.Size(1254, 250);
            this.pannelLast.TabIndex = 4;
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(100, 23);
            this.Title.TabIndex = 0;
            // 
            // lastWhat
            // 
            this.lastWhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lastWhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastWhat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lastWhat.Location = new System.Drawing.Point(637, 2);
            this.lastWhat.Margin = new System.Windows.Forms.Padding(2);
            this.lastWhat.Name = "lastWhat";
            this.lastWhat.Size = new System.Drawing.Size(615, 246);
            this.lastWhat.TabIndex = 2;
            this.lastWhat.Text = "OldWhat";
            this.lastWhat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(778, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lastCue
            // 
            this.lastCue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastCue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lastCue.Location = new System.Drawing.Point(2, 2);
            this.lastCue.Margin = new System.Windows.Forms.Padding(2);
            this.lastCue.Name = "lastCue";
            this.lastCue.Size = new System.Drawing.Size(615, 246);
            this.lastCue.TabIndex = 0;
            this.lastCue.Text = "OldCue";
            this.lastCue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pannelCurrent
            // 
            this.pannelCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pannelCurrent.Controls.Add(this.currentWhat);
            this.pannelCurrent.Controls.Add(this.currentCue);
            this.pannelCurrent.Location = new System.Drawing.Point(23, 341);
            this.pannelCurrent.Name = "pannelCurrent";
            this.pannelCurrent.Size = new System.Drawing.Size(1254, 250);
            this.pannelCurrent.TabIndex = 5;
            // 
            // currentWhat
            // 
            this.currentWhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentWhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentWhat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.currentWhat.Location = new System.Drawing.Point(637, 2);
            this.currentWhat.Margin = new System.Windows.Forms.Padding(2);
            this.currentWhat.Name = "currentWhat";
            this.currentWhat.Size = new System.Drawing.Size(615, 246);
            this.currentWhat.TabIndex = 3;
            this.currentWhat.Text = "CurrentWhat";
            this.currentWhat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentCue
            // 
            this.currentCue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentCue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.currentCue.Location = new System.Drawing.Point(2, 2);
            this.currentCue.Margin = new System.Windows.Forms.Padding(2);
            this.currentCue.Name = "currentCue";
            this.currentCue.Size = new System.Drawing.Size(615, 246);
            this.currentCue.TabIndex = 3;
            this.currentCue.Text = "CurrentCue";
            this.currentCue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pannelNext
            // 
            this.pannelNext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pannelNext.Controls.Add(this.nextWhat);
            this.pannelNext.Controls.Add(this.nextCue);
            this.pannelNext.Location = new System.Drawing.Point(23, 607);
            this.pannelNext.Name = "pannelNext";
            this.pannelNext.Size = new System.Drawing.Size(1254, 250);
            this.pannelNext.TabIndex = 5;
            // 
            // nextWhat
            // 
            this.nextWhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextWhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextWhat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nextWhat.Location = new System.Drawing.Point(637, 2);
            this.nextWhat.Margin = new System.Windows.Forms.Padding(2);
            this.nextWhat.Name = "nextWhat";
            this.nextWhat.Size = new System.Drawing.Size(615, 246);
            this.nextWhat.TabIndex = 5;
            this.nextWhat.Text = "NextWhat";
            this.nextWhat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextCue
            // 
            this.nextCue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nextCue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextCue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nextCue.Location = new System.Drawing.Point(2, 2);
            this.nextCue.Margin = new System.Windows.Forms.Padding(2);
            this.nextCue.Name = "nextCue";
            this.nextCue.Size = new System.Drawing.Size(615, 246);
            this.nextCue.TabIndex = 4;
            this.nextCue.Text = "NextCue";
            this.nextCue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TitleLabel.Location = new System.Drawing.Point(23, 24);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(1252, 65);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "RocCue";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1300, 880);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.pannelNext);
            this.Controls.Add(this.pannelCurrent);
            this.Controls.Add(this.pannelLast);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RocCue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pannelLast.ResumeLayout(false);
            this.pannelLast.PerformLayout();
            this.pannelCurrent.ResumeLayout(false);
            this.pannelNext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pannelLast;
        private System.Windows.Forms.Panel pannelCurrent;
        private System.Windows.Forms.Panel pannelNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lastCue;
        private System.Windows.Forms.Label lastWhat;
        private System.Windows.Forms.Label currentWhat;
        private System.Windows.Forms.Label currentCue;
        private System.Windows.Forms.Label nextWhat;
        private System.Windows.Forms.Label nextCue;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label TitleLabel;
    }
}

