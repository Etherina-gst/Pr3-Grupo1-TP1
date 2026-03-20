namespace TP1_GRUPO_1
{
    partial class Formulario2
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
            this.lblNombres = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstNombresIngresados = new System.Windows.Forms.ListBox();
            this.btnPasarUnNombre = new System.Windows.Forms.Button();
            this.btnPasarTodoslosNombres = new System.Windows.Forms.Button();
            this.lstNombresGuardados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(78, 23);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(133, 17);
            this.lblNombres.TabIndex = 0;
            this.lblNombres.Text = "Ingrese Nombre :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(250, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(303, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(593, 25);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstNombresIngresados
            // 
            this.lstNombresIngresados.FormattingEnabled = true;
            this.lstNombresIngresados.Location = new System.Drawing.Point(81, 78);
            this.lstNombresIngresados.Name = "lstNombresIngresados";
            this.lstNombresIngresados.Size = new System.Drawing.Size(223, 199);
            this.lstNombresIngresados.TabIndex = 3;
            // 
            // btnPasarUnNombre
            // 
            this.btnPasarUnNombre.Location = new System.Drawing.Point(368, 137);
            this.btnPasarUnNombre.Name = "btnPasarUnNombre";
            this.btnPasarUnNombre.Size = new System.Drawing.Size(75, 23);
            this.btnPasarUnNombre.TabIndex = 4;
            this.btnPasarUnNombre.Text = ">";
            this.btnPasarUnNombre.UseVisualStyleBackColor = true;
            this.btnPasarUnNombre.Click += new System.EventHandler(this.btnPasarUnNombre_Click);
            // 
            // btnPasarTodoslosNombres
            // 
            this.btnPasarTodoslosNombres.Location = new System.Drawing.Point(368, 185);
            this.btnPasarTodoslosNombres.Name = "btnPasarTodoslosNombres";
            this.btnPasarTodoslosNombres.Size = new System.Drawing.Size(75, 23);
            this.btnPasarTodoslosNombres.TabIndex = 5;
            this.btnPasarTodoslosNombres.Text = ">>";
            this.btnPasarTodoslosNombres.UseVisualStyleBackColor = true;
            // 
            // lstNombresGuardados
            // 
            this.lstNombresGuardados.FormattingEnabled = true;
            this.lstNombresGuardados.Location = new System.Drawing.Point(508, 78);
            this.lstNombresGuardados.Name = "lstNombresGuardados";
            this.lstNombresGuardados.Size = new System.Drawing.Size(223, 199);
            this.lstNombresGuardados.TabIndex = 6;
            // 
            // Formulario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstNombresGuardados);
            this.Controls.Add(this.btnPasarTodoslosNombres);
            this.Controls.Add(this.btnPasarUnNombre);
            this.Controls.Add(this.lstNombresIngresados);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombres);
            this.Name = "Formulario2";
            this.Text = "Nombres";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Formulario2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstNombresIngresados;
        private System.Windows.Forms.Button btnPasarUnNombre;
        private System.Windows.Forms.Button btnPasarTodoslosNombres;
        private System.Windows.Forms.ListBox lstNombresGuardados;
    }
}