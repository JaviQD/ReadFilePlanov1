namespace ReadFilePlano_Form
{
    partial class Lector_ArchivosPlanos
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
            this.etiPrefijo = new System.Windows.Forms.Label();
            this.etiTotal = new System.Windows.Forms.Label();
            this.etiImpuesto = new System.Windows.Forms.Label();
            this.etiTotalImpuesto = new System.Windows.Forms.Label();
            this.etiMes = new System.Windows.Forms.Label();
            this.etiPagado = new System.Windows.Forms.Label();
            this.txtPrefijo = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtTotalImpuesto = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.brnLimpiar = new System.Windows.Forms.Button();
            this.txtPagado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // etiPrefijo
            // 
            this.etiPrefijo.AutoSize = true;
            this.etiPrefijo.BackColor = System.Drawing.SystemColors.Control;
            this.etiPrefijo.Location = new System.Drawing.Point(21, 31);
            this.etiPrefijo.Name = "etiPrefijo";
            this.etiPrefijo.Size = new System.Drawing.Size(61, 20);
            this.etiPrefijo.TabIndex = 0;
            this.etiPrefijo.Text = "Prefijo: ";
            // 
            // etiTotal
            // 
            this.etiTotal.AutoSize = true;
            this.etiTotal.Location = new System.Drawing.Point(21, 80);
            this.etiTotal.Name = "etiTotal";
            this.etiTotal.Size = new System.Drawing.Size(52, 20);
            this.etiTotal.TabIndex = 1;
            this.etiTotal.Text = "Total: ";
            // 
            // etiImpuesto
            // 
            this.etiImpuesto.AutoSize = true;
            this.etiImpuesto.Location = new System.Drawing.Point(21, 134);
            this.etiImpuesto.Name = "etiImpuesto";
            this.etiImpuesto.Size = new System.Drawing.Size(84, 20);
            this.etiImpuesto.TabIndex = 2;
            this.etiImpuesto.Text = "Impuesto: ";
            // 
            // etiTotalImpuesto
            // 
            this.etiTotalImpuesto.AutoSize = true;
            this.etiTotalImpuesto.Location = new System.Drawing.Point(21, 189);
            this.etiTotalImpuesto.Name = "etiTotalImpuesto";
            this.etiTotalImpuesto.Size = new System.Drawing.Size(145, 20);
            this.etiTotalImpuesto.TabIndex = 3;
            this.etiTotalImpuesto.Text = "Total con Impuesto";
            // 
            // etiMes
            // 
            this.etiMes.AutoSize = true;
            this.etiMes.Location = new System.Drawing.Point(21, 260);
            this.etiMes.Name = "etiMes";
            this.etiMes.Size = new System.Drawing.Size(47, 20);
            this.etiMes.TabIndex = 4;
            this.etiMes.Text = "Mes: ";
            // 
            // etiPagado
            // 
            this.etiPagado.AutoSize = true;
            this.etiPagado.Location = new System.Drawing.Point(21, 338);
            this.etiPagado.Name = "etiPagado";
            this.etiPagado.Size = new System.Drawing.Size(72, 20);
            this.etiPagado.TabIndex = 5;
            this.etiPagado.Text = "Pagado: ";
            // 
            // txtPrefijo
            // 
            this.txtPrefijo.Location = new System.Drawing.Point(180, 25);
            this.txtPrefijo.Name = "txtPrefijo";
            this.txtPrefijo.Size = new System.Drawing.Size(196, 26);
            this.txtPrefijo.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(180, 74);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(196, 26);
            this.txtTotal.TabIndex = 7;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(180, 128);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(196, 26);
            this.txtImpuesto.TabIndex = 8;
            // 
            // txtTotalImpuesto
            // 
            this.txtTotalImpuesto.Location = new System.Drawing.Point(180, 183);
            this.txtTotalImpuesto.Name = "txtTotalImpuesto";
            this.txtTotalImpuesto.Size = new System.Drawing.Size(196, 26);
            this.txtTotalImpuesto.TabIndex = 9;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(180, 260);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(196, 26);
            this.txtMes.TabIndex = 10;
            // 
            // Grilla
            // 
            this.Grilla.AllowUserToAddRows = false;
            this.Grilla.AllowUserToDeleteRows = false;
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Location = new System.Drawing.Point(467, 25);
            this.Grilla.Name = "Grilla";
            this.Grilla.ReadOnly = true;
            this.Grilla.RowHeadersWidth = 62;
            this.Grilla.RowTemplate.Height = 28;
            this.Grilla.Size = new System.Drawing.Size(767, 516);
            this.Grilla.TabIndex = 12;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(25, 504);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 37);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // brnLimpiar
            // 
            this.brnLimpiar.Location = new System.Drawing.Point(252, 504);
            this.brnLimpiar.Name = "brnLimpiar";
            this.brnLimpiar.Size = new System.Drawing.Size(124, 37);
            this.brnLimpiar.TabIndex = 14;
            this.brnLimpiar.Text = "Limpiar";
            this.brnLimpiar.UseVisualStyleBackColor = true;
            this.brnLimpiar.Click += new System.EventHandler(this.brnLimpiar_Click);
            // 
            // txtPagado
            // 
            this.txtPagado.Location = new System.Drawing.Point(180, 338);
            this.txtPagado.Name = "txtPagado";
            this.txtPagado.Size = new System.Drawing.Size(196, 26);
            this.txtPagado.TabIndex = 15;
            // 
            // Lector_ArchivosPlanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1279, 605);
            this.Controls.Add(this.txtPagado);
            this.Controls.Add(this.brnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.Grilla);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtTotalImpuesto);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPrefijo);
            this.Controls.Add(this.etiPagado);
            this.Controls.Add(this.etiMes);
            this.Controls.Add(this.etiTotalImpuesto);
            this.Controls.Add(this.etiImpuesto);
            this.Controls.Add(this.etiTotal);
            this.Controls.Add(this.etiPrefijo);
            this.Name = "Lector_ArchivosPlanos";
            this.Text = "Lector Archivos Planos";
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etiPrefijo;
        private System.Windows.Forms.Label etiTotal;
        private System.Windows.Forms.Label etiImpuesto;
        private System.Windows.Forms.Label etiTotalImpuesto;
        private System.Windows.Forms.Label etiMes;
        private System.Windows.Forms.Label etiPagado;
        private System.Windows.Forms.TextBox txtPrefijo;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtTotalImpuesto;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button brnLimpiar;
        private System.Windows.Forms.TextBox txtPagado;
    }
}

