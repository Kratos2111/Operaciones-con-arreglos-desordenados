namespace Operaciones_con_arreglos_desordenados
{
    partial class Ejercicio1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio1));
            this.DataEjercicio1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.Carnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataEjercicio1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataEjercicio1
            // 
            this.DataEjercicio1.AllowUserToAddRows = false;
            this.DataEjercicio1.AllowUserToDeleteRows = false;
            this.DataEjercicio1.AllowUserToResizeColumns = false;
            this.DataEjercicio1.AllowUserToResizeRows = false;
            this.DataEjercicio1.BackgroundColor = System.Drawing.Color.White;
            this.DataEjercicio1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataEjercicio1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Carnet,
            this.Nombre,
            this.IP,
            this.IIP,
            this.SIST,
            this.PROY,
            this.NF});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataEjercicio1.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataEjercicio1.Location = new System.Drawing.Point(24, 61);
            this.DataEjercicio1.Name = "DataEjercicio1";
            this.DataEjercicio1.RowHeadersVisible = false;
            this.DataEjercicio1.Size = new System.Drawing.Size(534, 189);
            this.DataEjercicio1.TabIndex = 0;
            this.DataEjercicio1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataEjercicio1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.btnMod);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Location = new System.Drawing.Point(597, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 189);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(115, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registro de Estudiantes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(37, 18);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(78, 27);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(37, 60);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(78, 27);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.btnMod.ForeColor = System.Drawing.Color.White;
            this.btnMod.Location = new System.Drawing.Point(37, 104);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(78, 27);
            this.btnMod.TabIndex = 2;
            this.btnMod.Text = "Nota";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Location = new System.Drawing.Point(37, 146);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(78, 28);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "Informacion";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // Carnet
            // 
            this.Carnet.HeaderText = "Carnet";
            this.Carnet.Name = "Carnet";
            this.Carnet.Width = 80;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 180;
            // 
            // IP
            // 
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            this.IP.Width = 50;
            // 
            // IIP
            // 
            this.IIP.HeaderText = "IIP";
            this.IIP.Name = "IIP";
            this.IIP.Width = 50;
            // 
            // SIST
            // 
            this.SIST.HeaderText = "SIST";
            this.SIST.Name = "SIST";
            this.SIST.Width = 50;
            // 
            // PROY
            // 
            this.PROY.HeaderText = "PROY";
            this.PROY.Name = "PROY";
            this.PROY.Width = 50;
            // 
            // NF
            // 
            this.NF.HeaderText = "NF";
            this.NF.Name = "NF";
            this.NF.Width = 50;
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(758, 316);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataEjercicio1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ejercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio1";
            this.Activated += new System.EventHandler(this.Ejercicio1_Activated);
            this.Load += new System.EventHandler(this.Ejercicio1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataEjercicio1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataEjercicio1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn IIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIST;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROY;
        private System.Windows.Forms.DataGridViewTextBoxColumn NF;
    }
}