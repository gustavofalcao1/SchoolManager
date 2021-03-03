namespace project
{
    partial class FormAlunosMod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlunosMod));
            this.dataGridViewA4 = new System.Windows.Forms.DataGridView();
            this.contextMenuStripA4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTittleA4 = new System.Windows.Forms.Label();
            this.buttonSearchA4 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelA4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA4)).BeginInit();
            this.contextMenuStripA4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewA4
            // 
            this.dataGridViewA4.AllowUserToAddRows = false;
            this.dataGridViewA4.AllowUserToDeleteRows = false;
            this.dataGridViewA4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewA4.ContextMenuStrip = this.contextMenuStripA4;
            this.dataGridViewA4.Location = new System.Drawing.Point(0, 90);
            this.dataGridViewA4.Name = "dataGridViewA4";
            this.dataGridViewA4.ReadOnly = true;
            this.dataGridViewA4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewA4.Size = new System.Drawing.Size(869, 391);
            this.dataGridViewA4.TabIndex = 1;
            // 
            // contextMenuStripA4
            // 
            this.contextMenuStripA4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem});
            this.contextMenuStripA4.Name = "contextMenuStripA4";
            this.contextMenuStripA4.Size = new System.Drawing.Size(126, 26);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.ModificarToolStripMenuItem_Click);
            // 
            // labelTittleA4
            // 
            this.labelTittleA4.AutoSize = true;
            this.labelTittleA4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittleA4.Location = new System.Drawing.Point(12, 26);
            this.labelTittleA4.Name = "labelTittleA4";
            this.labelTittleA4.Size = new System.Drawing.Size(247, 33);
            this.labelTittleA4.TabIndex = 2;
            this.labelTittleA4.Text = "Modificar Alunos";
            // 
            // buttonSearchA4
            // 
            this.buttonSearchA4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearchA4.BackgroundImage")));
            this.buttonSearchA4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearchA4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchA4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSearchA4.Location = new System.Drawing.Point(731, 12);
            this.buttonSearchA4.Name = "buttonSearchA4";
            this.buttonSearchA4.Size = new System.Drawing.Size(75, 72);
            this.buttonSearchA4.TabIndex = 0;
            this.buttonSearchA4.UseVisualStyleBackColor = true;
            this.buttonSearchA4.Click += new System.EventHandler(this.ButtonSearchA4_Click);
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
            // labelA4
            // 
            this.labelA4.AutoSize = true;
            this.labelA4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelA4.Location = new System.Drawing.Point(296, 55);
            this.labelA4.Name = "labelA4";
            this.labelA4.Size = new System.Drawing.Size(404, 18);
            this.labelA4.TabIndex = 8;
            this.labelA4.Text = "*Clique com direto do rato no cadastro que deseja modificar";
            // 
            // FormAlunosMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 506);
            this.Controls.Add(this.labelA4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonSearchA4);
            this.Controls.Add(this.labelTittleA4);
            this.Controls.Add(this.dataGridViewA4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlunosMod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor Escolar - Modificar Alunos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA4)).EndInit();
            this.contextMenuStripA4.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTittleA4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.DataGridView dataGridViewA4;
        public System.Windows.Forms.Button buttonSearchA4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripA4;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.Label labelA4;
    }
}