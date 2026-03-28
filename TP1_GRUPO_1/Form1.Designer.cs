namespace TP1_GRUPO_1
{
    partial class Formulario1
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
            this.btnEjerUno = new System.Windows.Forms.Button();
            this.btnEjerDos = new System.Windows.Forms.Button();
            this.btnEjerTres = new System.Windows.Forms.Button();
            this.Integrantes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEjerUno
            // 
            this.btnEjerUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjerUno.Location = new System.Drawing.Point(12, 65);
            this.btnEjerUno.Margin = new System.Windows.Forms.Padding(4);
            this.btnEjerUno.Name = "btnEjerUno";
            this.btnEjerUno.Size = new System.Drawing.Size(150, 60);
            this.btnEjerUno.TabIndex = 0;
            this.btnEjerUno.Text = "EJERCICIO 1";
            this.btnEjerUno.UseVisualStyleBackColor = true;
            this.btnEjerUno.Click += new System.EventHandler(this.btnEjerUno_Click);
            // 
            // btnEjerDos
            // 
            this.btnEjerDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjerDos.Location = new System.Drawing.Point(214, 65);
            this.btnEjerDos.Margin = new System.Windows.Forms.Padding(4);
            this.btnEjerDos.Name = "btnEjerDos";
            this.btnEjerDos.Size = new System.Drawing.Size(150, 60);
            this.btnEjerDos.TabIndex = 1;
            this.btnEjerDos.Text = "EJERCICIO 2";
            this.btnEjerDos.UseVisualStyleBackColor = true;
            this.btnEjerDos.Click += new System.EventHandler(this.btnEjerDos_Click);
            // 
            // btnEjerTres
            // 
            this.btnEjerTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjerTres.Location = new System.Drawing.Point(416, 65);
            this.btnEjerTres.Margin = new System.Windows.Forms.Padding(4);
            this.btnEjerTres.Name = "btnEjerTres";
            this.btnEjerTres.Size = new System.Drawing.Size(150, 60);
            this.btnEjerTres.TabIndex = 2;
            this.btnEjerTres.Text = "EJERCICIO 3\r\n";
            this.btnEjerTres.UseVisualStyleBackColor = true;
            this.btnEjerTres.Click += new System.EventHandler(this.btnEjerTres_Click);
            // 
            // Integrantes
            // 
            this.Integrantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Integrantes.Location = new System.Drawing.Point(12, 182);
            this.Integrantes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Integrantes.Name = "Integrantes";
            this.Integrantes.Size = new System.Drawing.Size(432, 238);
            this.Integrantes.TabIndex = 3;
            this.Integrantes.Text = "Integrantes: \r\n\r\n    -Sena Torres Geremias Rafael\r\n    -Vazquez Fabricio\r\n    -Ro" +
    "bledo Candela\r\n    -Yucra Israel\r\n    -Picasso Gabriela Belen\r\n    -Moyano Nahue" +
    "l Juan";
            // 
            // Formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 443);
            this.Controls.Add(this.Integrantes);
            this.Controls.Add(this.btnEjerTres);
            this.Controls.Add(this.btnEjerDos);
            this.Controls.Add(this.btnEjerUno);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Formulario1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEjerUno;
        private System.Windows.Forms.Button btnEjerDos;
        private System.Windows.Forms.Button btnEjerTres;
        private System.Windows.Forms.Label Integrantes;
    }
}

