namespace project
{
    partial class FormProfessorDel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfessorDel));
            this.dataGridViewP5 = new System.Windows.Forms.DataGridView();
            this.contextMenuStripP5 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItemP5 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTittleP5 = new System.Windows.Forms.Label();
            this.buttonSearchP5 = new System.Windows.Forms.Button();
            this.statusStripP5 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelP5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelP5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewP5)).BeginInit();
            this.contextMenuStripP5.SuspendLayout();
            this.statusStripP5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewP5
            // 
            this.dataGridViewP5.AllowUserToAddRows = false;
            this.dataGridViewP5.AllowUserToDeleteRows = false;
            this.dataGridViewP5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewP5.ContextMenuStrip = this.contextMenuStripP5;
            this.dataGridViewP5.Location = new System.Drawing.Point(0, 90);
            this.dataGridViewP5.Name = "dataGridViewP5";
            this.dataGridViewP5.ReadOnly = true;
            this.dataGridViewP5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewP5.Size = new System.Drawing.Size(869, 391);
            this.dataGridViewP5.TabIndex = 1;
            // 
            // contextMenuStripP5
            // 
            this.contextMenuStripP5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItemP5});
            this.contextMenuStripP5.Name = "contextMenuStripP5";
            this.contextMenuStripP5.Size = new System.Drawing.Size(112, 26);
            // 
            // modificarToolStripMenuItemP5
            // 
            this.modificarToolStripMenuItemP5.Name = "modificarToolStripMenuItemP5";
            this.modificarToolStripMenuItemP5.Size = new System.Drawing.Size(111, 22);
            this.modificarToolStripMenuItemP5.Text = "Deletar";
            this.modificarToolStripMenuItemP5.Click += new System.EventHandler(this.DeletarToolStripMenuItemP5_Click);
            // 
            // labelTittleP5
            // 
            this.labelTittleP5.AutoSize = true;
            this.labelTittleP5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittleP5.Location = new System.Drawing.Point(12, 26);
            this.labelTittleP5.Name = "labelTittleP5";
            this.labelTittleP5.Size = new System.Drawing.Size(259, 33);
            this.labelTittleP5.TabIndex = 2;
            this.labelTittleP5.Text = "Deletar Professor";
            // 
            // buttonSearchP5
            // 
            this.buttonSearchP5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearchP5.BackgroundImage")));
            this.buttonSearchP5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearchP5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchP5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSearchP5.Location = new System.Drawing.Point(731, 12);
            this.buttonSearchP5.Name = "buttonSearchP5";
            this.buttonSearchP5.Size = new System.Drawing.Size(75, 72);
            this.buttonSearchP5.TabIndex = 0;
            this.buttonSearchP5.UseVisualStyleBackColor = true;
            this.buttonSearchP5.Click += new System.EventHandler(this.ButtonSearchP5_Click);
            // 
            // statusStripP5
            // 
            this.statusStripP5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelP5});
            this.statusStripP5.Location = new System.Drawing.Point(0, 484);
            this.statusStripP5.Name = "statusStripP5";
            this.statusStripP5.Size = new System.Drawing.Size(870, 22);
            this.statusStripP5.TabIndex = 6;
            this.statusStripP5.Text = "statusStripP5";
            // 
            // toolStripStatusLabelP5
            // 
            this.toolStripStatusLabelP5.Name = "toolStripStatusLabelP5";
            this.toolStripStatusLabelP5.Size = new System.Drawing.Size(192, 17);
            this.toolStripStatusLabelP5.Text = "Copyright © 2019 - Gustavo Falcão";
            this.toolStripStatusLabelP5.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // labelP5
            // 
            this.labelP5.AutoSize = true;
            this.labelP5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelP5.Location = new System.Drawing.Point(296, 55);
            this.labelP5.Name = "labelP5";
            this.labelP5.Size = new System.Drawing.Size(387, 18);
            this.labelP5.TabIndex = 8;
            this.labelP5.Text = "*Clique com direto do rato no cadastro que deseja deletar";
            // 
            // FormProfessorDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 506);
            this.Controls.Add(this.labelP5);
            this.Controls.Add(this.statusStripP5);
            this.Controls.Add(this.buttonSearchP5);
            this.Controls.Add(this.labelTittleP5);
            this.Controls.Add(this.dataGridViewP5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProfessorDel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor Escolar - Deletar Professor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewP5)).EndInit();
            this.contextMenuStripP5.ResumeLayout(false);
            this.statusStripP5.ResumeLayout(false);
            this.statusStripP5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTittleP5;
        private System.Windows.Forms.StatusStrip statusStripP5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelP5;
        public System.Windows.Forms.DataGridView dataGridViewP5;
        public System.Windows.Forms.Button buttonSearchP5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripP5;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItemP5;
        private System.Windows.Forms.Label labelP5;
    }
}