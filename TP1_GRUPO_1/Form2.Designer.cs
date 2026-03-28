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
            this.lblNombres.Location = new System.Drawing.Point(24, 24);
            this.lblNombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(154, 20);
            this.lblNombres.TabIndex = 0;
            this.lblNombres.Text = "Ingrese Nombre :";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(222, 24);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(400, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(702, 24);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(128, 32);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstNombresIngresados
            // 
            this.lstNombresIngresados.FormattingEnabled = true;
            this.lstNombresIngresados.ItemHeight = 16;
            this.lstNombresIngresados.Location = new System.Drawing.Point(24, 116);
            this.lstNombresIngresados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstNombresIngresados.Name = "lstNombresIngresados";
            this.lstNombresIngresados.Size = new System.Drawing.Size(296, 372);
            this.lstNombresIngresados.TabIndex = 3;
            // 
            // btnPasarUnNombre
            // 
            this.btnPasarUnNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarUnNombre.Location = new System.Drawing.Point(371, 207);
            this.btnPasarUnNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPasarUnNombre.Name = "btnPasarUnNombre";
            this.btnPasarUnNombre.Size = new System.Drawing.Size(100, 50);
            this.btnPasarUnNombre.TabIndex = 4;
            this.btnPasarUnNombre.Text = ">";
            this.btnPasarUnNombre.UseVisualStyleBackColor = true;
            this.btnPasarUnNombre.Click += new System.EventHandler(this.btnPasarUnNombre_Click);
            // 
            // btnPasarTodoslosNombres
            // 
            this.btnPasarTodoslosNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarTodoslosNombres.Location = new System.Drawing.Point(371, 347);
            this.btnPasarTodoslosNombres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPasarTodoslosNombres.Name = "btnPasarTodoslosNombres";
            this.btnPasarTodoslosNombres.Size = new System.Drawing.Size(100, 50);
            this.btnPasarTodoslosNombres.TabIndex = 5;
            this.btnPasarTodoslosNombres.Text = ">>";
            this.btnPasarTodoslosNombres.UseVisualStyleBackColor = true;
            this.btnPasarTodoslosNombres.Click += new System.EventHandler(this.btnPasarTodoslosNombres_Click);
            // 
            // lstNombresGuardados
            // 
            this.lstNombresGuardados.FormattingEnabled = true;
            this.lstNombresGuardados.ItemHeight = 16;
            this.lstNombresGuardados.Location = new System.Drawing.Point(532, 116);
            this.lstNombresGuardados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstNombresGuardados.Name = "lstNombresGuardados";
            this.lstNombresGuardados.Size = new System.Drawing.Size(296, 372);
            this.lstNombresGuardados.TabIndex = 6;
            // 
            // Formulario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 519);
            this.Controls.Add(this.lstNombresGuardados);
            this.Controls.Add(this.btnPasarTodoslosNombres);
            this.Controls.Add(this.btnPasarUnNombre);
            this.Controls.Add(this.lstNombresIngresados);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombres);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Formulario2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nombres";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Formulario2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstNombresIngresados;
        private System.Windows.Forms.Button btnPasarUnNombre;
        private System.Windows.Forms.Button btnPasarTodoslosNombres;
        private System.Windows.Forms.ListBox lstNombresGuardados;
    }
}