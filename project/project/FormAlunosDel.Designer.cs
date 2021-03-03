namespace project
{
    partial class FormAlunosDel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlunosDel));
            this.dataGridViewA5 = new System.Windows.Forms.DataGridView();
            this.contextMenuStripA5 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItemA5 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTittleA5 = new System.Windows.Forms.Label();
            this.buttonSearchA5 = new System.Windows.Forms.Button();
            this.statusStripA5 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelA5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelA5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA5)).BeginInit();
            this.contextMenuStripA5.SuspendLayout();
            this.statusStripA5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewA5
            // 
            this.dataGridViewA5.AllowUserToAddRows = false;
            this.dataGridViewA5.AllowUserToDeleteRows = false;
            this.dataGridViewA5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewA5.ContextMenuStrip = this.contextMenuStripA5;
            this.dataGridViewA5.Location = new System.Drawing.Point(0, 90);
            this.dataGridViewA5.Name = "dataGridViewA5";
            this.dataGridViewA5.ReadOnly = true;
            this.dataGridViewA5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewA5.Size = new System.Drawing.Size(869, 391);
            this.dataGridViewA5.TabIndex = 1;
            // 
            // contextMenuStripA5
            // 
            this.contextMenuStripA5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItemA5});
            this.contextMenuStripA5.Name = "contextMenuStripA5";
            this.contextMenuStripA5.Size = new System.Drawing.Size(112, 26);
            // 
            // modificarToolStripMenuItemA5
            // 
            this.modificarToolStripMenuItemA5.Name = "modificarToolStripMenuItemA5";
            this.modificarToolStripMenuItemA5.Size = new System.Drawing.Size(111, 22);
            this.modificarToolStripMenuItemA5.Text = "Deletar";
            this.modificarToolStripMenuItemA5.Click += new System.EventHandler(this.DeletarToolStripMenuItemA5_Click);
            // 
            // labelTittleA5
            // 
            this.labelTittleA5.AutoSize = true;
            this.labelTittleA5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittleA5.Location = new System.Drawing.Point(12, 26);
            this.labelTittleA5.Name = "labelTittleA5";
            this.labelTittleA5.Size = new System.Drawing.Size(220, 33);
            this.labelTittleA5.TabIndex = 2;
            this.labelTittleA5.Text = "Deletar Alunos";
            // 
            // buttonSearchA5
            // 
            this.buttonSearchA5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearchA5.BackgroundImage")));
            this.buttonSearchA5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearchA5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchA5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSearchA5.Location = new System.Drawing.Point(731, 12);
            this.buttonSearchA5.Name = "buttonSearchA5";
            this.buttonSearchA5.Size = new System.Drawing.Size(75, 72);
            this.buttonSearchA5.TabIndex = 0;
            this.buttonSearchA5.UseVisualStyleBackColor = true;
            this.buttonSearchA5.Click += new System.EventHandler(this.ButtonSearchA5_Click);
            // 
            // statusStripA5
            // 
            this.statusStripA5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelA5});
            this.statusStripA5.Location = new System.Drawing.Point(0, 484);
            this.statusStripA5.Name = "statusStripA5";
            this.statusStripA5.Size = new System.Drawing.Size(870, 22);
            this.statusStripA5.TabIndex = 6;
            this.statusStripA5.Text = "statusStripA5";
            // 
            // toolStripStatusLabelA5
            // 
            this.toolStripStatusLabelA5.Name = "toolStripStatusLabelA5";
            this.toolStripStatusLabelA5.Size = new System.Drawing.Size(192, 17);
            this.toolStripStatusLabelA5.Text = "Copyright © 2019 - Gustavo Falcão";
            this.toolStripStatusLabelA5.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // labelA5
            // 
            this.labelA5.AutoSize = true;
            this.labelA5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelA5.Location = new System.Drawing.Point(296, 55);
            this.labelA5.Name = "labelA5";
            this.labelA5.Size = new System.Drawing.Size(387, 18);
            this.labelA5.TabIndex = 8;
            this.labelA5.Text = "*Clique com direto do rato no cadastro que deseja deletar";
            // 
            // FormAlunosDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 506);
            this.Controls.Add(this.labelA5);
            this.Controls.Add(this.statusStripA5);
            this.Controls.Add(this.buttonSearchA5);
            this.Controls.Add(this.labelTittleA5);
            this.Controls.Add(this.dataGridViewA5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlunosDel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor Escolar - Deletar Alunos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA5)).EndInit();
            this.contextMenuStripA5.ResumeLayout(false);
            this.statusStripA5.ResumeLayout(false);
            this.statusStripA5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTittleA5;
        private System.Windows.Forms.StatusStrip statusStripA5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelA5;
        public System.Windows.Forms.DataGridView dataGridViewA5;
        public System.Windows.Forms.Button buttonSearchA5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripA5;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItemA5;
        private System.Windows.Forms.Label labelA5;
    }
}