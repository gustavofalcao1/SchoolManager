namespace project
{
    partial class FormAlunosDown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlunosDown));
            this.dataGridViewA2 = new System.Windows.Forms.DataGridView();
            this.labelTittleA2 = new System.Windows.Forms.Label();
            this.buttonSearchA2 = new System.Windows.Forms.Button();
            this.statusStripA2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelA2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonDownA2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA2)).BeginInit();
            this.statusStripA2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewA2
            // 
            this.dataGridViewA2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewA2.Location = new System.Drawing.Point(0, 90);
            this.dataGridViewA2.Name = "dataGridViewA2";
            this.dataGridViewA2.Size = new System.Drawing.Size(869, 391);
            this.dataGridViewA2.TabIndex = 3;
            // 
            // labelTittleA2
            // 
            this.labelTittleA2.AutoSize = true;
            this.labelTittleA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittleA2.Location = new System.Drawing.Point(12, 26);
            this.labelTittleA2.Name = "labelTittleA2";
            this.labelTittleA2.Size = new System.Drawing.Size(335, 33);
            this.labelTittleA2.TabIndex = 2;
            this.labelTittleA2.Text = "Exportar Dados Alunos";
            // 
            // buttonSearchA2
            // 
            this.buttonSearchA2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearchA2.BackgroundImage")));
            this.buttonSearchA2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearchA2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchA2.Location = new System.Drawing.Point(461, 12);
            this.buttonSearchA2.Name = "buttonSearchA2";
            this.buttonSearchA2.Size = new System.Drawing.Size(75, 72);
            this.buttonSearchA2.TabIndex = 0;
            this.buttonSearchA2.UseVisualStyleBackColor = true;
            this.buttonSearchA2.Click += new System.EventHandler(this.ButtonSearchA2_Click);
            // 
            // statusStripA2
            // 
            this.statusStripA2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelA2});
            this.statusStripA2.Location = new System.Drawing.Point(0, 484);
            this.statusStripA2.Name = "statusStripA2";
            this.statusStripA2.Size = new System.Drawing.Size(870, 22);
            this.statusStripA2.TabIndex = 6;
            this.statusStripA2.Text = "statusStripA2";
            // 
            // toolStripStatusLabelA2
            // 
            this.toolStripStatusLabelA2.Name = "toolStripStatusLabelA2";
            this.toolStripStatusLabelA2.Size = new System.Drawing.Size(192, 17);
            this.toolStripStatusLabelA2.Text = "Copyright © 2019 - Gustavo Falcão";
            this.toolStripStatusLabelA2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // buttonDownA2
            // 
            this.buttonDownA2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDownA2.BackgroundImage")));
            this.buttonDownA2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDownA2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDownA2.Location = new System.Drawing.Point(783, 12);
            this.buttonDownA2.Name = "buttonDownA2";
            this.buttonDownA2.Size = new System.Drawing.Size(75, 72);
            this.buttonDownA2.TabIndex = 1;
            this.buttonDownA2.UseVisualStyleBackColor = true;
            this.buttonDownA2.Click += new System.EventHandler(this.ButtonDownA2_Click);
            // 
            // FormAlunosDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 506);
            this.Controls.Add(this.statusStripA2);
            this.Controls.Add(this.buttonDownA2);
            this.Controls.Add(this.buttonSearchA2);
            this.Controls.Add(this.labelTittleA2);
            this.Controls.Add(this.dataGridViewA2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlunosDown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor Escolar - Exportar Dados Alunos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA2)).EndInit();
            this.statusStripA2.ResumeLayout(false);
            this.statusStripA2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewA2;
        private System.Windows.Forms.Label labelTittleA2;
        private System.Windows.Forms.Button buttonSearchA2;
        private System.Windows.Forms.StatusStrip statusStripA2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelA2;
        private System.Windows.Forms.Button buttonDownA2;
    }
}