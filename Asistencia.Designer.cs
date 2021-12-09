
namespace ProyectoFinal2
{
    partial class Asistencia
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAsistencia = new System.Windows.Forms.DataGridView();
            this.ColNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAsistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFalta = new System.Windows.Forms.Button();
            this.btnAsistio = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(64, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha";
            // 
            // dgvAsistencia
            // 
            this.dgvAsistencia.AllowUserToAddRows = false;
            this.dgvAsistencia.AllowUserToDeleteRows = false;
            this.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNL,
            this.ColNombre,
            this.ColApellidos,
            this.ColAsistencia});
            this.dgvAsistencia.Location = new System.Drawing.Point(15, 176);
            this.dgvAsistencia.Name = "dgvAsistencia";
            this.dgvAsistencia.Size = new System.Drawing.Size(649, 262);
            this.dgvAsistencia.TabIndex = 3;
            // 
            // ColNL
            // 
            this.ColNL.HeaderText = "#Lista";
            this.ColNL.Name = "ColNL";
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.Name = "ColNombre";
            // 
            // ColApellidos
            // 
            this.ColApellidos.HeaderText = "Apellidos";
            this.ColApellidos.Name = "ColApellidos";
            // 
            // ColAsistencia
            // 
            this.ColAsistencia.HeaderText = "Asistencia";
            this.ColAsistencia.Name = "ColAsistencia";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(140, 86);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(303, 20);
            this.txtbNombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtbApellidos
            // 
            this.txtbApellidos.Location = new System.Drawing.Point(140, 112);
            this.txtbApellidos.Name = "txtbApellidos";
            this.txtbApellidos.Size = new System.Drawing.Size(303, 20);
            this.txtbApellidos.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // btnFalta
            // 
            this.btnFalta.Location = new System.Drawing.Point(480, 115);
            this.btnFalta.Name = "btnFalta";
            this.btnFalta.Size = new System.Drawing.Size(75, 23);
            this.btnFalta.TabIndex = 5;
            this.btnFalta.Text = "No asisitió";
            this.btnFalta.UseVisualStyleBackColor = true;
            this.btnFalta.Click += new System.EventHandler(this.btnFalta_Click);
            // 
            // btnAsistio
            // 
            this.btnAsistio.Location = new System.Drawing.Point(480, 82);
            this.btnAsistio.Name = "btnAsistio";
            this.btnAsistio.Size = new System.Drawing.Size(75, 23);
            this.btnAsistio.TabIndex = 5;
            this.btnAsistio.Text = "Asistió";
            this.btnAsistio.UseVisualStyleBackColor = true;
            this.btnAsistio.Click += new System.EventHandler(this.btnAsistio_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(670, 395);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(118, 43);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(670, 317);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(118, 43);
            this.btnComenzar.TabIndex = 5;
            this.btnComenzar.Text = "Comenzar/Siguiente";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAsistio);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnFalta);
            this.Controls.Add(this.txtbApellidos);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAsistencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Asistencia";
            this.Text = "Asistencia";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAsistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAsistencia;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFalta;
        private System.Windows.Forms.Button btnAsistio;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnComenzar;
    }
}