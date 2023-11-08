namespace ProjetoQueimadura
{
    partial class FormMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.buttonAlimentos = new System.Windows.Forms.Button();
            this.btnfontes = new System.Windows.Forms.Button();
            this.btnPrimeirosSocorros = new System.Windows.Forms.Button();
            this.btnCuidados = new System.Windows.Forms.Button();
            this.btnMedicamentos = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreditos = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAlimentos
            // 
            this.buttonAlimentos.AutoSize = true;
            this.buttonAlimentos.BackColor = System.Drawing.Color.LightCoral;
            this.buttonAlimentos.FlatAppearance.BorderSize = 0;
            this.buttonAlimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlimentos.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlimentos.Location = new System.Drawing.Point(905, 496);
            this.buttonAlimentos.Name = "buttonAlimentos";
            this.buttonAlimentos.Size = new System.Drawing.Size(175, 66);
            this.buttonAlimentos.TabIndex = 2;
            this.buttonAlimentos.Text = "Alimentos";
            this.buttonAlimentos.UseVisualStyleBackColor = false;
            // 
            // btnfontes
            // 
            this.btnfontes.BackColor = System.Drawing.Color.LightCoral;
            this.btnfontes.FlatAppearance.BorderSize = 0;
            this.btnfontes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfontes.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfontes.Location = new System.Drawing.Point(195, 913);
            this.btnfontes.Name = "btnfontes";
            this.btnfontes.Size = new System.Drawing.Size(111, 51);
            this.btnfontes.TabIndex = 6;
            this.btnfontes.Text = "Fontes";
            this.btnfontes.UseVisualStyleBackColor = false;
            // 
            // btnPrimeirosSocorros
            // 
            this.btnPrimeirosSocorros.BackColor = System.Drawing.Color.LightCoral;
            this.btnPrimeirosSocorros.FlatAppearance.BorderSize = 0;
            this.btnPrimeirosSocorros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimeirosSocorros.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeirosSocorros.Location = new System.Drawing.Point(905, 393);
            this.btnPrimeirosSocorros.Name = "btnPrimeirosSocorros";
            this.btnPrimeirosSocorros.Size = new System.Drawing.Size(175, 66);
            this.btnPrimeirosSocorros.TabIndex = 1;
            this.btnPrimeirosSocorros.Text = "Primeiros Socorros";
            this.btnPrimeirosSocorros.UseVisualStyleBackColor = false;
            this.btnPrimeirosSocorros.Click += new System.EventHandler(this.btnPrimeirosSocorros_Click);
            // 
            // btnCuidados
            // 
            this.btnCuidados.AutoSize = true;
            this.btnCuidados.BackColor = System.Drawing.Color.LightCoral;
            this.btnCuidados.FlatAppearance.BorderSize = 0;
            this.btnCuidados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuidados.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuidados.Location = new System.Drawing.Point(905, 599);
            this.btnCuidados.Name = "btnCuidados";
            this.btnCuidados.Size = new System.Drawing.Size(175, 66);
            this.btnCuidados.TabIndex = 3;
            this.btnCuidados.Text = "Cuidados";
            this.btnCuidados.UseVisualStyleBackColor = false;
            // 
            // btnMedicamentos
            // 
            this.btnMedicamentos.BackColor = System.Drawing.Color.LightCoral;
            this.btnMedicamentos.FlatAppearance.BorderSize = 0;
            this.btnMedicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicamentos.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicamentos.Location = new System.Drawing.Point(905, 710);
            this.btnMedicamentos.Name = "btnMedicamentos";
            this.btnMedicamentos.Size = new System.Drawing.Size(175, 66);
            this.btnMedicamentos.TabIndex = 4;
            this.btnMedicamentos.Text = "Medicamentos";
            this.btnMedicamentos.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightCoral;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(905, 816);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(175, 66);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Sair";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreditos
            // 
            this.btnCreditos.BackColor = System.Drawing.Color.LightCoral;
            this.btnCreditos.FlatAppearance.BorderSize = 0;
            this.btnCreditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreditos.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditos.Location = new System.Drawing.Point(332, 913);
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Size = new System.Drawing.Size(111, 51);
            this.btnCreditos.TabIndex = 7;
            this.btnCreditos.Text = "Créditos";
            this.btnCreditos.UseVisualStyleBackColor = false;
            // 
            // logo
            // 
            this.logo.ErrorImage = null;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.InitialImage = null;
            this.logo.Location = new System.Drawing.Point(581, 43);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(779, 288);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 13;
            this.logo.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1490, 1008);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnCreditos);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMedicamentos);
            this.Controls.Add(this.btnCuidados);
            this.Controls.Add(this.btnPrimeirosSocorros);
            this.Controls.Add(this.btnfontes);
            this.Controls.Add(this.buttonAlimentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAlimentos;
        private System.Windows.Forms.Button btnfontes;
        private System.Windows.Forms.Button btnPrimeirosSocorros;
        private System.Windows.Forms.Button btnCuidados;
        private System.Windows.Forms.Button btnMedicamentos;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCreditos;
        private System.Windows.Forms.PictureBox logo;
    }
}

