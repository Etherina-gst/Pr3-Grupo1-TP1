namespace TP1_GRUPO_1
{
    partial class Formulario4
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
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.gbEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rbSoltero = new System.Windows.Forms.RadioButton();
            this.rbCasado = new System.Windows.Forms.RadioButton();
            this.btMostrar = new System.Windows.Forms.Button();
            this.clbOficios = new System.Windows.Forms.CheckedListBox();
            this.gbSexo.SuspendLayout();
            this.gbEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbMasculino);
            this.gbSexo.Controls.Add(this.rbFemenino);
            this.gbSexo.Location = new System.Drawing.Point(9, 10);
            this.gbSexo.Margin = new System.Windows.Forms.Padding(2);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Padding = new System.Windows.Forms.Padding(2);
            this.gbSexo.Size = new System.Drawing.Size(150, 81);
            this.gbSexo.TabIndex = 0;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(10, 47);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(2);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 1;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Checked = true;
            this.rbFemenino.Location = new System.Drawing.Point(10, 23);
            this.rbFemenino.Margin = new System.Windows.Forms.Padding(2);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 0;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // gbEstadoCivil
            // 
            this.gbEstadoCivil.Controls.Add(this.rbSoltero);
            this.gbEstadoCivil.Controls.Add(this.rbCasado);
            this.gbEstadoCivil.Location = new System.Drawing.Point(221, 10);
            this.gbEstadoCivil.Margin = new System.Windows.Forms.Padding(2);
            this.gbEstadoCivil.Name = "gbEstadoCivil";
            this.gbEstadoCivil.Padding = new System.Windows.Forms.Padding(2);
            this.gbEstadoCivil.Size = new System.Drawing.Size(150, 81);
            this.gbEstadoCivil.TabIndex = 0;
            this.gbEstadoCivil.TabStop = false;
            this.gbEstadoCivil.Text = "Estado Civil";
            // 
            // rbSoltero
            // 
            this.rbSoltero.AutoSize = true;
            this.rbSoltero.Location = new System.Drawing.Point(10, 47);
            this.rbSoltero.Margin = new System.Windows.Forms.Padding(2);
            this.rbSoltero.Name = "rbSoltero";
            this.rbSoltero.Size = new System.Drawing.Size(69, 17);
            this.rbSoltero.TabIndex = 3;
            this.rbSoltero.Text = "Soltero/a";
            this.rbSoltero.UseVisualStyleBackColor = true;
            // 
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Checked = true;
            this.rbCasado.Location = new System.Drawing.Point(10, 24);
            this.rbCasado.Margin = new System.Windows.Forms.Padding(2);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(72, 17);
            this.rbCasado.TabIndex = 2;
            this.rbCasado.TabStop = true;
            this.rbCasado.Text = "Casado/a";
            this.rbCasado.UseVisualStyleBackColor = true;
            // 
            // btMostrar
            // 
            this.btMostrar.Location = new System.Drawing.Point(111, 213);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(152, 23);
            this.btMostrar.TabIndex = 1;
            this.btMostrar.Text = "button1";
            this.btMostrar.UseVisualStyleBackColor = true;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // clbOficios
            // 
            this.clbOficios.FormattingEnabled = true;
            this.clbOficios.Location = new System.Drawing.Point(124, 113);
            this.clbOficios.Name = "clbOficios";
            this.clbOficios.Size = new System.Drawing.Size(120, 94);
            this.clbOficios.TabIndex = 2;
            // 
            // Formulario4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 366);
            this.Controls.Add(this.clbOficios);
            this.Controls.Add(this.btMostrar);
            this.Controls.Add(this.gbEstadoCivil);
            this.Controls.Add(this.gbSexo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Formulario4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Formulario4_FormClosed);
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.gbEstadoCivil.ResumeLayout(false);
            this.gbEstadoCivil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.GroupBox gbEstadoCivil;
        private System.Windows.Forms.RadioButton rbSoltero;
        private System.Windows.Forms.RadioButton rbCasado;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.CheckedListBox clbOficios;
    }
}