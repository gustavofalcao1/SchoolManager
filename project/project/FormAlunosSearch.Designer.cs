namespace project
{
    partial class FormAlunosSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlunosSearch));
            this.dataGridViewA1 = new System.Windows.Forms.DataGridView();
            this.labelTittleA1 = new System.Windows.Forms.Label();
            this.buttonSearchA1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewA1
            // 
            this.dataGridViewA1.AllowUserToAddRows = false;
            this.dataGridViewA1.AllowUserToDeleteRows = false;
            this.dataGridViewA1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewA1.Location = new System.Drawing.Point(0, 90);
            this.dataGridViewA1.Name = "dataGridViewA1";
            this.dataGridViewA1.ReadOnly = true;
            this.dataGridViewA1.Size = new System.Drawing.Size(869, 391);
            this.dataGridViewA1.TabIndex = 1;
            // 
            // labelTittleA1
            // 
            this.labelTittleA1.AutoSize = true;
            this.labelTittleA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittleA1.Location = new System.Drawing.Point(12, 26);
            this.labelTittleA1.Name = "labelTittleA1";
            this.labelTittleA1.Size = new System.Drawing.Size(253, 33);
            this.labelTittleA1.TabIndex = 2;
            this.labelTittleA1.Text = "Consultar Alunos";
            // 
            // buttonSearchA1
            // 
            this.buttonSearchA1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearchA1.BackgroundImage")));
            this.buttonSearchA1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearchA1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchA1.Location = new System.Drawing.Point(731, 12);
            this.buttonSearchA1.Name = "buttonSearchA1";
            this.buttonSearchA1.Size = new System.Drawing.Size(75, 72);
            this.buttonSearchA1.TabIndex = 0;
            this.buttonSearchA1.UseVisualStyleBackColor = true;
            this.buttonSearchA1.Click += new System.EventHandler(this.ButtonSearchA1_Click);
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
            // FormAlunosSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 506);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonSearchA1);
            this.Controls.Add(this.labelTittleA1);
            this.Controls.Add(this.dataGridViewA1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlunosSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor Escolar - Consulta Alunos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTittleA1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.DataGridView dataGridViewA1;
        public System.Windows.Forms.Button buttonSearchA1;
    }
}