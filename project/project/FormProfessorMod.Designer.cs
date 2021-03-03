namespace project
{
    partial class FormProfessorMod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfessorMod));
            this.dataGridViewP4 = new System.Windows.Forms.DataGridView();
            this.contextMenuStripP4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTittleP4 = new System.Windows.Forms.Label();
            this.buttonSearchP4 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelP4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewP4)).BeginInit();
            this.contextMenuStripP4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewP4
            // 
            this.dataGridViewP4.AllowUserToAddRows = false;
            this.dataGridViewP4.AllowUserToDeleteRows = false;
            this.dataGridViewP4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewP4.ContextMenuStrip = this.contextMenuStripP4;
            this.dataGridViewP4.Location = new System.Drawing.Point(0, 90);
            this.dataGridViewP4.Name = "dataGridViewP4";
            this.dataGridViewP4.ReadOnly = true;
            this.dataGridViewP4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewP4.Size = new System.Drawing.Size(869, 391);
            this.dataGridViewP4.TabIndex = 1;
            // 
            // contextMenuStripP4
            // 
            this.contextMenuStripP4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem});
            this.contextMenuStripP4.Name = "contextMenuStripP4";
            this.contextMenuStripP4.Size = new System.Drawing.Size(126, 26);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.ModificarToolStripMenuItemP4_Click);
            // 
            // labelTittleP4
            // 
            this.labelTittleP4.AutoSize = true;
            this.labelTittleP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittleP4.Location = new System.Drawing.Point(12, 26);
            this.labelTittleP4.Name = "labelTittleP4";
            this.labelTittleP4.Size = new System.Drawing.Size(286, 33);
            this.labelTittleP4.TabIndex = 2;
            this.labelTittleP4.Text = "Modificar Professor";
            // 
            // buttonSearchP4
            // 
            this.buttonSearchP4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearchP4.BackgroundImage")));
            this.buttonSearchP4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearchP4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchP4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSearchP4.Location = new System.Drawing.Point(731, 12);
            this.buttonSearchP4.Name = "buttonSearchP4";
            this.buttonSearchP4.Size = new System.Drawing.Size(75, 72);
            this.buttonSearchP4.TabIndex = 0;
            this.buttonSearchP4.UseVisualStyleBackColor = true;
            this.buttonSearchP4.Click += new System.EventHandler(this.ButtonSearchP4_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(870, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(192, 17);
            this.toolStripStatusLabel1.Text = "Copyright © 2019 - Gustavo Falcão";
            this.toolStripStatusLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // labelP4
            // 
            this.labelP4.AutoSize = true;
            this.labelP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelP4.Location = new System.Drawing.Point(296, 55);
            this.labelP4.Name = "labelP4";
            this.labelP4.Size = new System.Drawing.Size(404, 18);
            this.labelP4.TabIndex = 8;
            this.labelP4.Text = "*Clique com direto do rato no cadastro que deseja modificar";
            // 
            // FormProfessorMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 506);
            this.Controls.Add(this.labelP4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonSearchP4);
            this.Controls.Add(this.labelTittleP4);
            this.Controls.Add(this.dataGridViewP4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProfessorMod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor Escolar - Modificar Professor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewP4)).EndInit();
            this.contextMenuStripP4.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTittleP4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.DataGridView dataGridViewP4;
        public System.Windows.Forms.Button buttonSearchP4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripP4;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.Label labelP4;
    }
}