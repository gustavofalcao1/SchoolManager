namespace project
{
    partial class FormProfessorSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfessorSearch));
            this.dataGridViewP1 = new System.Windows.Forms.DataGridView();
            this.labelTittleP1 = new System.Windows.Forms.Label();
            this.buttonSearchP1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewP1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewP1
            // 
            this.dataGridViewP1.AllowUserToAddRows = false;
            this.dataGridViewP1.AllowUserToDeleteRows = false;
            this.dataGridViewP1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewP1.Location = new System.Drawing.Point(0, 90);
            this.dataGridViewP1.Name = "dataGridViewP1";
            this.dataGridViewP1.ReadOnly = true;
            this.dataGridViewP1.Size = new System.Drawing.Size(869, 391);
            this.dataGridViewP1.TabIndex = 1;
            // 
            // labelTittleP1
            // 
            this.labelTittleP1.AutoSize = true;
            this.labelTittleP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittleP1.Location = new System.Drawing.Point(12, 26);
            this.labelTittleP1.Name = "labelTittleP1";
            this.labelTittleP1.Size = new System.Drawing.Size(292, 33);
            this.labelTittleP1.TabIndex = 2;
            this.labelTittleP1.Text = "Consultar Professor";
            // 
            // buttonSearchP1
            // 
            this.buttonSearchP1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearchP1.BackgroundImage")));
            this.buttonSearchP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearchP1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchP1.Location = new System.Drawing.Point(731, 12);
            this.buttonSearchP1.Name = "buttonSearchP1";
            this.buttonSearchP1.Size = new System.Drawing.Size(75, 72);
            this.buttonSearchP1.TabIndex = 0;
            this.buttonSearchP1.UseVisualStyleBackColor = true;
            this.buttonSearchP1.Click += new System.EventHandler(this.ButtonSearchP1_Click);
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
            // FormProfessorSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 506);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonSearchP1);
            this.Controls.Add(this.labelTittleP1);
            this.Controls.Add(this.dataGridViewP1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProfessorSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor Escolar - Consulta Professor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewP1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewP1;
        private System.Windows.Forms.Label labelTittleP1;
        private System.Windows.Forms.Button buttonSearchP1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}