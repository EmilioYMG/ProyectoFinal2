
namespace ProyectoFinal2
{
    partial class frmAgregarCalif
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
            this.txtbApellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.rdbApe = new System.Windows.Forms.RadioButton();
            this.rdbNL = new System.Windows.Forms.RadioButton();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbNL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbCalif = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAcept = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbNombAct = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtbApellidos
            // 
            this.txtbApellidos.Location = new System.Drawing.Point(227, 69);
            this.txtbApellidos.Name = "txtbApellidos";
            this.txtbApellidos.Size = new System.Drawing.Size(152, 20);
            this.txtbApellidos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apellidos";
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Location = new System.Drawing.Point(158, 12);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(62, 17);
            this.rdbNombre.TabIndex = 2;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            this.rdbNombre.CheckedChanged += new System.EventHandler(this.rdbNombre_CheckedChanged);
            // 
            // rdbApe
            // 
            this.rdbApe.AutoSize = true;
            this.rdbApe.Location = new System.Drawing.Point(249, 12);
            this.rdbApe.Name = "rdbApe";
            this.rdbApe.Size = new System.Drawing.Size(67, 17);
            this.rdbApe.TabIndex = 2;
            this.rdbApe.TabStop = true;
            this.rdbApe.Text = "Apellidos";
            this.rdbApe.UseVisualStyleBackColor = true;
            this.rdbApe.CheckedChanged += new System.EventHandler(this.rdbApe_CheckedChanged);
            // 
            // rdbNL
            // 
            this.rdbNL.AutoSize = true;
            this.rdbNL.Location = new System.Drawing.Point(340, 12);
            this.rdbNL.Name = "rdbNL";
            this.rdbNL.Size = new System.Drawing.Size(98, 17);
            this.rdbNL.TabIndex = 2;
            this.rdbNL.TabStop = true;
            this.rdbNL.Text = "Número de lista";
            this.rdbNL.UseVisualStyleBackColor = true;
            this.rdbNL.CheckedChanged += new System.EventHandler(this.rdbNL_CheckedChanged);
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(227, 43);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(152, 20);
            this.txtbNombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // txtbNL
            // 
            this.txtbNL.Location = new System.Drawing.Point(227, 95);
            this.txtbNL.Name = "txtbNL";
            this.txtbNL.Size = new System.Drawing.Size(152, 20);
            this.txtbNL.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Número de Lista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre de la Actividad";
            // 
            // txtbCalif
            // 
            this.txtbCalif.Location = new System.Drawing.Point(227, 147);
            this.txtbCalif.Name = "txtbCalif";
            this.txtbCalif.Size = new System.Drawing.Size(152, 20);
            this.txtbCalif.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Calificación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Agregar por";
            // 
            // btnAcept
            // 
            this.btnAcept.Location = new System.Drawing.Point(276, 181);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Size = new System.Drawing.Size(75, 23);
            this.btnAcept.TabIndex = 3;
            this.btnAcept.Text = "Aceptar";
            this.btnAcept.UseVisualStyleBackColor = true;
            this.btnAcept.Click += new System.EventHandler(this.btnAcept_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(357, 181);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbNombAct
            // 
            this.cmbNombAct.FormattingEnabled = true;
            this.cmbNombAct.Location = new System.Drawing.Point(227, 120);
            this.cmbNombAct.Name = "cmbNombAct";
            this.cmbNombAct.Size = new System.Drawing.Size(152, 21);
            this.cmbNombAct.TabIndex = 4;
            // 
            // frmAgregarCalif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 215);
            this.Controls.Add(this.cmbNombAct);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAcept);
            this.Controls.Add(this.rdbNL);
            this.Controls.Add(this.rdbApe);
            this.Controls.Add(this.rdbNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.txtbCalif);
            this.Controls.Add(this.txtbNL);
            this.Controls.Add(this.txtbApellidos);
            this.Name = "frmAgregarCalif";
            this.Text = "AgregarCalif";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAgregarCalif_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbApellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.RadioButton rdbApe;
        private System.Windows.Forms.RadioButton rdbNL;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbNL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbCalif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAcept;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbNombAct;
    }
}