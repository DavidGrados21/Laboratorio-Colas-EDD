namespace prueba
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumColas = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNumElementos = new System.Windows.Forms.TextBox();
            this.txtColaFinal = new System.Windows.Forms.ListBox();
            this.btnUnify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de colas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de elementos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número:";
            // 
            // txtNumColas
            // 
            this.txtNumColas.Location = new System.Drawing.Point(30, 26);
            this.txtNumColas.Name = "txtNumColas";
            this.txtNumColas.Size = new System.Drawing.Size(169, 20);
            this.txtNumColas.TabIndex = 4;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(30, 193);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(169, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // txtNumElementos
            // 
            this.txtNumElementos.Location = new System.Drawing.Point(30, 88);
            this.txtNumElementos.Name = "txtNumElementos";
            this.txtNumElementos.Size = new System.Drawing.Size(169, 20);
            this.txtNumElementos.TabIndex = 6;
            // 
            // txtColaFinal
            // 
            this.txtColaFinal.FormattingEnabled = true;
            this.txtColaFinal.Location = new System.Drawing.Point(233, 15);
            this.txtColaFinal.Name = "txtColaFinal";
            this.txtColaFinal.Size = new System.Drawing.Size(244, 251);
            this.txtColaFinal.TabIndex = 7;
            // 
            // btnUnify
            // 
            this.btnUnify.Location = new System.Drawing.Point(135, 255);
            this.btnUnify.Name = "btnUnify";
            this.btnUnify.Size = new System.Drawing.Size(82, 23);
            this.btnUnify.TabIndex = 8;
            this.btnUnify.Text = "Unificar";
            this.btnUnify.UseVisualStyleBackColor = true;
            this.btnUnify.Click += new System.EventHandler(this.btnUnify_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 300);
            this.Controls.Add(this.btnUnify);
            this.Controls.Add(this.txtColaFinal);
            this.Controls.Add(this.txtNumElementos);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtNumColas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumColas;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtNumElementos;
        private System.Windows.Forms.ListBox txtColaFinal;
        private System.Windows.Forms.Button btnUnify;
    }
}

