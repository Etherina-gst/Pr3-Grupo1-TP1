namespace TP1_GRUPO_1
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
            this.btnEjerUno = new System.Windows.Forms.Button();
            this.btnEjerDos = new System.Windows.Forms.Button();
            this.btnEjerTres = new System.Windows.Forms.Button();
            this.Integrantes1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEjerUno
            // 
            this.btnEjerUno.Location = new System.Drawing.Point(43, 92);
            this.btnEjerUno.Name = "btnEjerUno";
            this.btnEjerUno.Size = new System.Drawing.Size(109, 42);
            this.btnEjerUno.TabIndex = 0;
            this.btnEjerUno.Text = "EJERCICIO 1";
            this.btnEjerUno.UseVisualStyleBackColor = true;
            // 
            // btnEjerDos
            // 
            this.btnEjerDos.Location = new System.Drawing.Point(242, 92);
            this.btnEjerDos.Name = "btnEjerDos";
            this.btnEjerDos.Size = new System.Drawing.Size(111, 42);
            this.btnEjerDos.TabIndex = 1;
            this.btnEjerDos.Text = "EJERCICIO 2";
            this.btnEjerDos.UseVisualStyleBackColor = true;
            // 
            // btnEjerTres
            // 
            this.btnEjerTres.Location = new System.Drawing.Point(444, 92);
            this.btnEjerTres.Name = "btnEjerTres";
            this.btnEjerTres.Size = new System.Drawing.Size(104, 42);
            this.btnEjerTres.TabIndex = 2;
            this.btnEjerTres.Text = "EJERCICIO 3\r\n";
            this.btnEjerTres.UseVisualStyleBackColor = true;
            // 
            // Integrantes1
            // 
            this.Integrantes1.Location = new System.Drawing.Point(40, 170);
            this.Integrantes1.Name = "Integrantes1";
            this.Integrantes1.Size = new System.Drawing.Size(100, 23);
            this.Integrantes1.TabIndex = 3;
            this.Integrantes1.Text = "Integrantes:";
            this.Integrantes1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Integrantes1);
            this.Controls.Add(this.btnEjerTres);
            this.Controls.Add(this.btnEjerDos);
            this.Controls.Add(this.btnEjerUno);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEjerUno;
        private System.Windows.Forms.Button btnEjerDos;
        private System.Windows.Forms.Button btnEjerTres;
        private System.Windows.Forms.Label Integrantes1;
    }
}

