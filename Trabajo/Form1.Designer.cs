namespace Trabajo
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Fondo = new System.Windows.Forms.Panel();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.Datos = new System.Windows.Forms.DataGridView();
            this.PlazoI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlazoF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Tasa = new System.Windows.Forms.TextBox();
            this.txt_PlazoF = new System.Windows.Forms.TextBox();
            this.txt_PlazoI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.Fondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorP)).BeginInit();
            this.SuspendLayout();
            // 
            // Fondo
            // 
            this.Fondo.Controls.Add(this.btn_Agregar);
            this.Fondo.Controls.Add(this.Datos);
            this.Fondo.Controls.Add(this.txt_Tasa);
            this.Fondo.Controls.Add(this.txt_PlazoF);
            this.Fondo.Controls.Add(this.txt_PlazoI);
            this.Fondo.Controls.Add(this.label3);
            this.Fondo.Controls.Add(this.label2);
            this.Fondo.Controls.Add(this.label1);
            this.Fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fondo.Location = new System.Drawing.Point(0, 0);
            this.Fondo.Name = "Fondo";
            this.Fondo.Size = new System.Drawing.Size(800, 450);
            this.Fondo.TabIndex = 0;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(536, 39);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 41);
            this.btn_Agregar.TabIndex = 7;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // Datos
            // 
            this.Datos.AllowUserToAddRows = false;
            this.Datos.AllowUserToDeleteRows = false;
            this.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlazoI,
            this.PlazoF,
            this.Tasa});
            this.Datos.Location = new System.Drawing.Point(73, 104);
            this.Datos.Name = "Datos";
            this.Datos.ReadOnly = true;
            this.Datos.Size = new System.Drawing.Size(427, 280);
            this.Datos.TabIndex = 6;
            // 
            // PlazoI
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlazoI.DefaultCellStyle = dataGridViewCellStyle2;
            this.PlazoI.HeaderText = "Plazo de Inicio";
            this.PlazoI.Name = "PlazoI";
            this.PlazoI.ReadOnly = true;
            // 
            // PlazoF
            // 
            this.PlazoF.HeaderText = "Plazo Final";
            this.PlazoF.Name = "PlazoF";
            this.PlazoF.ReadOnly = true;
            // 
            // Tasa
            // 
            this.Tasa.HeaderText = "Tasa";
            this.Tasa.Name = "Tasa";
            this.Tasa.ReadOnly = true;
            // 
            // txt_Tasa
            // 
            this.txt_Tasa.Location = new System.Drawing.Point(387, 60);
            this.txt_Tasa.Name = "txt_Tasa";
            this.txt_Tasa.Size = new System.Drawing.Size(113, 20);
            this.txt_Tasa.TabIndex = 5;
            this.txt_Tasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Solo_Decimal);
            // 
            // txt_PlazoF
            // 
            this.txt_PlazoF.Location = new System.Drawing.Point(230, 60);
            this.txt_PlazoF.Name = "txt_PlazoF";
            this.txt_PlazoF.Size = new System.Drawing.Size(113, 20);
            this.txt_PlazoF.TabIndex = 4;
            this.txt_PlazoF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Solo_Num);
            // 
            // txt_PlazoI
            // 
            this.txt_PlazoI.Location = new System.Drawing.Point(73, 60);
            this.txt_PlazoI.Name = "txt_PlazoI";
            this.txt_PlazoI.Size = new System.Drawing.Size(113, 20);
            this.txt_PlazoI.TabIndex = 3;
            this.txt_PlazoI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Solo_Num);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tasa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plazo Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plazo Inicial";
            // 
            // ErrorP
            // 
            this.ErrorP.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Fondo);
            this.Name = "Form1";
            this.Text = "Plazos de Certificados de Inversión";
            this.Fondo.ResumeLayout(false);
            this.Fondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Fondo;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.DataGridView Datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlazoI;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlazoF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasa;
        private System.Windows.Forms.TextBox txt_Tasa;
        private System.Windows.Forms.TextBox txt_PlazoF;
        private System.Windows.Forms.TextBox txt_PlazoI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ErrorP;
    }
}

