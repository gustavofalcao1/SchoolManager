namespace project
{
    partial class FormProfessorDown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfessorDown));
            this.dataGridViewP2 = new System.Windows.Forms.DataGridView();
            this.labelTittleP2 = new System.Windows.Forms.Label();
            this.buttonSearchP2 = new System.Windows.Forms.Button();
            this.statusStripP2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelP2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonDownP2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewP2)).BeginInit();
            this.statusStripP2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewP2
            // 
            this.dataGridViewP2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewP2.Location = new System.Drawing.Point(0, 90);
            this.dataGridViewP2.Name = "dataGridViewP2";
            this.dataGridViewP2.Size = new System.Drawing.Size(869, 391);
            this.dataGridViewP2.TabIndex = 3;
            // 
            // labelTittleP2
            // 
            this.labelTittleP2.AutoSize = true;
            this.labelTittleP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittleP2.Location = new System.Drawing.Point(12, 26);
            this.labelTittleP2.Name = "labelTittleP2";
            this.labelTittleP2.Size = new System.Drawing.Size(374, 33);
            this.labelTittleP2.TabIndex = 2;
            this.labelTittleP2.Text = "Exportar Dados Professor";
            // 
            // buttonSearchP2
            // 
            this.buttonSearchP2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearchP2.BackgroundImage")));
            this.buttonSearchP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearchP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchP2.Location = new System.Drawing.Point(461, 12);
            this.buttonSearchP2.Name = "buttonSearchP2";
            this.buttonSearchP2.Size = new System.Drawing.Size(75, 72);
            this.buttonSearchP2.TabIndex = 1;
            this.buttonSearchP2.UseVisualStyleBackColor = true;
            this.buttonSearchP2.Click += new System.EventHandler(this.ButtonSearchP2_Click);
            // 
            // statusStripP2
            // 
            this.statusStripP2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelP2});
            this.statusStripP2.Location = new System.Drawing.Point(0, 484);
            this.statusStripP2.Name = "statusStripP2";
            this.statusStripP2.Size = new System.Drawing.Size(870, 22);
            this.statusStripP2.TabIndex = 6;
            this.statusStripP2.Text = "statusStripP2";
            // 
            // toolStripStatusLabelP2
            // 
            this.toolStripStatusLabelP2.Name = "toolStripStatusLabelP2";
            this.toolStripStatusLabelP2.Size = new System.Drawing.Size(192, 17);
            this.toolStripStatusLabelP2.Text = "Copyright © 2019 - Gustavo Falcão";
            this.toolStripStatusLabelP2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // buttonDownP2
            // 
            this.buttonDownP2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDownP2.BackgroundImage")));
            this.buttonDownP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDownP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDownP2.Location = new System.Drawing.Point(783, 12);
            this.buttonDownP2.Name = "buttonDownP2";
            this.buttonDownP2.Size = new System.Drawing.Size(75, 72);
            this.buttonDownP2.TabIndex = 2;
            this.buttonDownP2.UseVisualStyleBackColor = true;
            this.buttonDownP2.Click += new System.EventHandler(this.ButtonDownP2_Click);
            // 
            // FormProfessorDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 506);
            this.Controls.Add(this.statusStripP2);
            this.Controls.Add(this.buttonDownP2);
            this.Controls.Add(this.buttonSearchP2);
            this.Controls.Add(this.labelTittleP2);
            this.Controls.Add(this.dataGridViewP2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProfessorDown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor Escolar - Exportar Dados Professor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewP2)).EndInit();
            this.statusStripP2.ResumeLayout(false);
            this.statusStripP2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewP2;
        private System.Windows.Forms.Label labelTittleP2;
        private System.Windows.Forms.Button buttonSearchP2;
        private System.Windows.Forms.StatusStrip statusStripP2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelP2;
        private System.Windows.Forms.Button buttonDownP2;
    }
}