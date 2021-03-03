namespace project
{
    partial class FormAlunosAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlunosAdd));
            this.groupBoxA1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerA1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxIndA1 = new System.Windows.Forms.TextBox();
            this.textBoxPaisA1 = new System.Windows.Forms.TextBox();
            this.textBoxNomeA1 = new System.Windows.Forms.TextBox();
            this.comboBoxCursoA1 = new System.Windows.Forms.ComboBox();
            this.comboBoxCiviA1 = new System.Windows.Forms.ComboBox();
            this.checkBoxSimA1 = new System.Windows.Forms.CheckBox();
            this.checkBoxSfA1 = new System.Windows.Forms.CheckBox();
            this.checkBoxSmA1 = new System.Windows.Forms.CheckBox();
            this.labelCursoA1 = new System.Windows.Forms.Label();
            this.labelIndA1 = new System.Windows.Forms.Label();
            this.labelDefA1 = new System.Windows.Forms.Label();
            this.labelPaisA1 = new System.Windows.Forms.Label();
            this.labelNasciA1 = new System.Windows.Forms.Label();
            this.labelCivilA1 = new System.Windows.Forms.Label();
            this.labelSexoA1 = new System.Windows.Forms.Label();
            this.labelNameA1 = new System.Windows.Forms.Label();
            this.buttonCheckA1 = new System.Windows.Forms.Button();
            this.labelTittleA1 = new System.Windows.Forms.Label();
            this.statusStripA1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelA1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxA1.SuspendLayout();
            this.statusStripA1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxA1
            // 
            this.groupBoxA1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxA1.Controls.Add(this.dateTimePickerA1);
            this.groupBoxA1.Controls.Add(this.textBoxIndA1);
            this.groupBoxA1.Controls.Add(this.textBoxPaisA1);
            this.groupBoxA1.Controls.Add(this.textBoxNomeA1);
            this.groupBoxA1.Controls.Add(this.comboBoxCursoA1);
            this.groupBoxA1.Controls.Add(this.comboBoxCiviA1);
            this.groupBoxA1.Controls.Add(this.checkBoxSimA1);
            this.groupBoxA1.Controls.Add(this.checkBoxSfA1);
            this.groupBoxA1.Controls.Add(this.checkBoxSmA1);
            this.groupBoxA1.Controls.Add(this.labelCursoA1);
            this.groupBoxA1.Controls.Add(this.labelIndA1);
            this.groupBoxA1.Controls.Add(this.labelDefA1);
            this.groupBoxA1.Controls.Add(this.labelPaisA1);
            this.groupBoxA1.Controls.Add(this.labelNasciA1);
            this.groupBoxA1.Controls.Add(this.labelCivilA1);
            this.groupBoxA1.Controls.Add(this.labelSexoA1);
            this.groupBoxA1.Controls.Add(this.labelNameA1);
            this.groupBoxA1.Controls.Add(this.buttonCheckA1);
            this.groupBoxA1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxA1.Location = new System.Drawing.Point(12, 36);
            this.groupBoxA1.Name = "groupBoxA1";
            this.groupBoxA1.Size = new System.Drawing.Size(846, 443);
            this.groupBoxA1.TabIndex = 0;
            this.groupBoxA1.TabStop = false;
            // 
            // dateTimePickerA1
            // 
            this.dateTimePickerA1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerA1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerA1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerA1.Location = new System.Drawing.Point(199, 167);
            this.dateTimePickerA1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerA1.Name = "dateTimePickerA1";
            this.dateTimePickerA1.Size = new System.Drawing.Size(147, 31);
            this.dateTimePickerA1.TabIndex = 4;
            this.dateTimePickerA1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerA1.ValueChanged += new System.EventHandler(this.DateTimePickerA1_ValueChanged);
            // 
            // textBoxIndA1
            // 
            this.textBoxIndA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIndA1.Location = new System.Drawing.Point(199, 307);
            this.textBoxIndA1.MaxLength = 255;
            this.textBoxIndA1.Name = "textBoxIndA1";
            this.textBoxIndA1.Size = new System.Drawing.Size(201, 31);
            this.textBoxIndA1.TabIndex = 7;
            this.textBoxIndA1.TextChanged += new System.EventHandler(this.TextBoxIndA1_TextChanged);
            // 
            // textBoxPaisA1
            // 
            this.textBoxPaisA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPaisA1.Location = new System.Drawing.Point(199, 215);
            this.textBoxPaisA1.MaxLength = 255;
            this.textBoxPaisA1.Name = "textBoxPaisA1";
            this.textBoxPaisA1.Size = new System.Drawing.Size(157, 31);
            this.textBoxPaisA1.TabIndex = 5;
            this.textBoxPaisA1.TextChanged += new System.EventHandler(this.TextBoxPaisA1_TextChanged);
            // 
            // textBoxNomeA1
            // 
            this.textBoxNomeA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeA1.Location = new System.Drawing.Point(199, 31);
            this.textBoxNomeA1.MaxLength = 255;
            this.textBoxNomeA1.Name = "textBoxNomeA1";
            this.textBoxNomeA1.Size = new System.Drawing.Size(444, 31);
            this.textBoxNomeA1.TabIndex = 0;
            this.textBoxNomeA1.TextChanged += new System.EventHandler(this.TextBoxNomeA1_TextChanged);
            // 
            // comboBoxCursoA1
            // 
            this.comboBoxCursoA1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCursoA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCursoA1.FormattingEnabled = true;
            this.comboBoxCursoA1.Items.AddRange(new object[] {
            "Desenvolvimento Web",
            "Desenvolvimento para Jogos",
            "Redes e Sistemas Informáticos"});
            this.comboBoxCursoA1.Location = new System.Drawing.Point(199, 353);
            this.comboBoxCursoA1.Name = "comboBoxCursoA1";
            this.comboBoxCursoA1.Size = new System.Drawing.Size(333, 33);
            this.comboBoxCursoA1.TabIndex = 8;
            this.comboBoxCursoA1.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCursoA1_SelectedIndexChanged);
            // 
            // comboBoxCiviA1
            // 
            this.comboBoxCiviA1.AutoCompleteCustomSource.AddRange(new string[] {
            "Casado(a)",
            "Divorciado(a)",
            "Separado(a) judicialmente",
            "Solteiro(a)",
            "União de facto",
            "Viúvo(a)"});
            this.comboBoxCiviA1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCiviA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCiviA1.FormattingEnabled = true;
            this.comboBoxCiviA1.Items.AddRange(new object[] {
            "Casado(a)",
            "Divorciado(a)",
            "Separado(a) judicialmente",
            "Solteiro(a)",
            "União de facto",
            "Viúvo(a)"});
            this.comboBoxCiviA1.Location = new System.Drawing.Point(199, 123);
            this.comboBoxCiviA1.Name = "comboBoxCiviA1";
            this.comboBoxCiviA1.Size = new System.Drawing.Size(201, 33);
            this.comboBoxCiviA1.TabIndex = 3;
            this.comboBoxCiviA1.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCiviA1_SelectedIndexChanged);
            // 
            // checkBoxSimA1
            // 
            this.checkBoxSimA1.AutoSize = true;
            this.checkBoxSimA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSimA1.Location = new System.Drawing.Point(199, 264);
            this.checkBoxSimA1.Name = "checkBoxSimA1";
            this.checkBoxSimA1.Size = new System.Drawing.Size(61, 28);
            this.checkBoxSimA1.TabIndex = 6;
            this.checkBoxSimA1.Text = "Sim";
            this.checkBoxSimA1.UseVisualStyleBackColor = true;
            this.checkBoxSimA1.CheckedChanged += new System.EventHandler(this.CheckBoxSimA1_CheckedChanged);
            // 
            // checkBoxSfA1
            // 
            this.checkBoxSfA1.AutoSize = true;
            this.checkBoxSfA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSfA1.Location = new System.Drawing.Point(334, 80);
            this.checkBoxSfA1.Name = "checkBoxSfA1";
            this.checkBoxSfA1.Size = new System.Drawing.Size(109, 28);
            this.checkBoxSfA1.TabIndex = 2;
            this.checkBoxSfA1.Text = "Feminino";
            this.checkBoxSfA1.UseVisualStyleBackColor = true;
            this.checkBoxSfA1.CheckedChanged += new System.EventHandler(this.CheckBoxSfA1_CheckedChanged);
            // 
            // checkBoxSmA1
            // 
            this.checkBoxSmA1.AutoSize = true;
            this.checkBoxSmA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSmA1.Location = new System.Drawing.Point(199, 79);
            this.checkBoxSmA1.Name = "checkBoxSmA1";
            this.checkBoxSmA1.Size = new System.Drawing.Size(129, 29);
            this.checkBoxSmA1.TabIndex = 1;
            this.checkBoxSmA1.Text = "Masculino";
            this.checkBoxSmA1.UseVisualStyleBackColor = true;
            this.checkBoxSmA1.CheckedChanged += new System.EventHandler(this.CheckBoxSmA1_CheckedChanged);
            // 
            // labelCursoA1
            // 
            this.labelCursoA1.AutoSize = true;
            this.labelCursoA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCursoA1.Location = new System.Drawing.Point(124, 356);
            this.labelCursoA1.Name = "labelCursoA1";
            this.labelCursoA1.Size = new System.Drawing.Size(69, 25);
            this.labelCursoA1.TabIndex = 1;
            this.labelCursoA1.Text = "Curso";
            this.labelCursoA1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelIndA1
            // 
            this.labelIndA1.AutoSize = true;
            this.labelIndA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndA1.Location = new System.Drawing.Point(48, 310);
            this.labelIndA1.Name = "labelIndA1";
            this.labelIndA1.Size = new System.Drawing.Size(145, 25);
            this.labelIndA1.TabIndex = 1;
            this.labelIndA1.Text = "Indentificação";
            this.labelIndA1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDefA1
            // 
            this.labelDefA1.AutoSize = true;
            this.labelDefA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefA1.Location = new System.Drawing.Point(75, 264);
            this.labelDefA1.Name = "labelDefA1";
            this.labelDefA1.Size = new System.Drawing.Size(118, 25);
            this.labelDefA1.TabIndex = 1;
            this.labelDefA1.Text = "Deficiência";
            this.labelDefA1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPaisA1
            // 
            this.labelPaisA1.AutoSize = true;
            this.labelPaisA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaisA1.Location = new System.Drawing.Point(44, 218);
            this.labelPaisA1.Name = "labelPaisA1";
            this.labelPaisA1.Size = new System.Drawing.Size(149, 25);
            this.labelPaisA1.TabIndex = 1;
            this.labelPaisA1.Text = "Nacionalidade";
            this.labelPaisA1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNasciA1
            // 
            this.labelNasciA1.AutoSize = true;
            this.labelNasciA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNasciA1.Location = new System.Drawing.Point(68, 172);
            this.labelNasciA1.Name = "labelNasciA1";
            this.labelNasciA1.Size = new System.Drawing.Size(125, 25);
            this.labelNasciA1.TabIndex = 1;
            this.labelNasciA1.Text = "Nascimento";
            this.labelNasciA1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCivilA1
            // 
            this.labelCivilA1.AutoSize = true;
            this.labelCivilA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCivilA1.Location = new System.Drawing.Point(67, 126);
            this.labelCivilA1.Name = "labelCivilA1";
            this.labelCivilA1.Size = new System.Drawing.Size(126, 25);
            this.labelCivilA1.TabIndex = 1;
            this.labelCivilA1.Text = "Estado Civil";
            this.labelCivilA1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSexoA1
            // 
            this.labelSexoA1.AutoSize = true;
            this.labelSexoA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexoA1.Location = new System.Drawing.Point(132, 80);
            this.labelSexoA1.Name = "labelSexoA1";
            this.labelSexoA1.Size = new System.Drawing.Size(61, 25);
            this.labelSexoA1.TabIndex = 1;
            this.labelSexoA1.Text = "Sexo";
            this.labelSexoA1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNameA1
            // 
            this.labelNameA1.AutoSize = true;
            this.labelNameA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameA1.Location = new System.Drawing.Point(125, 34);
            this.labelNameA1.Name = "labelNameA1";
            this.labelNameA1.Size = new System.Drawing.Size(68, 25);
            this.labelNameA1.TabIndex = 1;
            this.labelNameA1.Text = "Nome";
            this.labelNameA1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonCheckA1
            // 
            this.buttonCheckA1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCheckA1.BackgroundImage")));
            this.buttonCheckA1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCheckA1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheckA1.Location = new System.Drawing.Point(758, 355);
            this.buttonCheckA1.Name = "buttonCheckA1";
            this.buttonCheckA1.Size = new System.Drawing.Size(82, 82);
            this.buttonCheckA1.TabIndex = 9;
            this.buttonCheckA1.UseVisualStyleBackColor = true;
            this.buttonCheckA1.Click += new System.EventHandler(this.ButtonCheckA1_Click);
            // 
            // labelTittleA1
            // 
            this.labelTittleA1.AutoSize = true;
            this.labelTittleA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittleA1.Location = new System.Drawing.Point(12, 5);
            this.labelTittleA1.Name = "labelTittleA1";
            this.labelTittleA1.Size = new System.Drawing.Size(288, 33);
            this.labelTittleA1.TabIndex = 1;
            this.labelTittleA1.Text = "Cadastro de Alunos";
            // 
            // statusStripA1
            // 
            this.statusStripA1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelA1});
            this.statusStripA1.Location = new System.Drawing.Point(0, 484);
            this.statusStripA1.Name = "statusStripA1";
            this.statusStripA1.Size = new System.Drawing.Size(870, 22);
            this.statusStripA1.TabIndex = 6;
            this.statusStripA1.Text = "statusStripA1";
            // 
            // toolStripStatusLabelA1
            // 
            this.toolStripStatusLabelA1.Name = "toolStripStatusLabelA1";
            this.toolStripStatusLabelA1.Size = new System.Drawing.Size(192, 17);
            this.toolStripStatusLabelA1.Text = "Copyright © 2019 - Gustavo Falcão";
            this.toolStripStatusLabelA1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // FormAlunosAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 506);
            this.Controls.Add(this.statusStripA1);
            this.Controls.Add(this.labelTittleA1);
            this.Controls.Add(this.groupBoxA1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlunosAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor Escolar - Cadastro Alunos";
            this.groupBoxA1.ResumeLayout(false);
            this.groupBoxA1.PerformLayout();
            this.statusStripA1.ResumeLayout(false);
            this.statusStripA1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxA1;
        private System.Windows.Forms.Button buttonCheckA1;
        private System.Windows.Forms.Label labelTittleA1;
        private System.Windows.Forms.CheckBox checkBoxSfA1;
        private System.Windows.Forms.CheckBox checkBoxSmA1;
        private System.Windows.Forms.Label labelCursoA1;
        private System.Windows.Forms.Label labelIndA1;
        private System.Windows.Forms.Label labelDefA1;
        private System.Windows.Forms.Label labelPaisA1;
        private System.Windows.Forms.Label labelNasciA1;
        private System.Windows.Forms.Label labelCivilA1;
        private System.Windows.Forms.Label labelSexoA1;
        private System.Windows.Forms.Label labelNameA1;
        private System.Windows.Forms.ComboBox comboBoxCiviA1;
        private System.Windows.Forms.TextBox textBoxPaisA1;
        private System.Windows.Forms.TextBox textBoxNomeA1;
        private System.Windows.Forms.CheckBox checkBoxSimA1;
        private System.Windows.Forms.TextBox textBoxIndA1;
        private System.Windows.Forms.DateTimePicker dateTimePickerA1;
        private System.Windows.Forms.ComboBox comboBoxCursoA1;
        private System.Windows.Forms.StatusStrip statusStripA1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelA1;
    }
}