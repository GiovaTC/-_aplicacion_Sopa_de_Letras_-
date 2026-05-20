namespace SopaLetrasOracle.Formularios
{
    partial class FrmSopa
    {
        /// <summary>
        /// Variable del diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar recursos usados.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados deben eliminarse; false en caso contrario.</param>
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
        /// Método requerido para admitir el Diseñador.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvSopa = new System.Windows.Forms.DataGridView();
            this.lstPalabras = new System.Windows.Forms.ListBox();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPalabras = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblResultadoTitulo = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvSopa)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvSopa
            // 
            this.dgvSopa.AllowUserToAddRows = false;
            this.dgvSopa.AllowUserToDeleteRows = false;
            this.dgvSopa.AllowUserToResizeColumns = false;
            this.dgvSopa.AllowUserToResizeRows = false;
            this.dgvSopa.BackgroundColor = System.Drawing.Color.White;
            this.dgvSopa.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSopa.Location = new System.Drawing.Point(25, 70);
            this.dgvSopa.MultiSelect = false;
            this.dgvSopa.Name = "dgvSopa";
            this.dgvSopa.ReadOnly = true;
            this.dgvSopa.RowHeadersWidth = 51;
            this.dgvSopa.RowTemplate.Height = 29;
            this.dgvSopa.Size = new System.Drawing.Size(520, 500);
            this.dgvSopa.TabIndex = 0;

            // 
            // lstPalabras
            // 
            this.lstPalabras.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point);
            this.lstPalabras.FormattingEnabled = true;
            this.lstPalabras.ItemHeight = 23;
            this.lstPalabras.Location = new System.Drawing.Point(580, 70);
            this.lstPalabras.Name = "lstPalabras";
            this.lstPalabras.Size = new System.Drawing.Size(250, 257);
            this.lstPalabras.TabIndex = 1;

            // 
            // txtPalabra
            // 
            this.txtPalabra.Font = new System.Drawing.Font(
                "Segoe UI",
                11F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point);
            this.txtPalabra.Location = new System.Drawing.Point(580, 380);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(250, 32);
            this.txtPalabra.TabIndex = 2;

            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point);
            this.btnVerificar.ForeColor = System.Drawing.Color.White;
            this.btnVerificar.Location = new System.Drawing.Point(580, 430);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(250, 45);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "Verificar Palabra";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click +=
                new System.EventHandler(this.btnVerificar_Click);

            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(580, 490);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(250, 45);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar Resultado";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click +=
                new System.EventHandler(this.btnGuardar_Click);

            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(580, 550);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(250, 45);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo Juego";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click +=
                new System.EventHandler(this.btnNuevo_Click);

            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font(
                "Segoe UI",
                18F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitulo.Location = new System.Drawing.Point(250, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(328, 41);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "SOPA DE LETRAS .NET";

            // 
            // lblPalabras
            // 
            this.lblPalabras.AutoSize = true;
            this.lblPalabras.Font = new System.Drawing.Font(
                "Segoe UI",
                11F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point);
            this.lblPalabras.Location = new System.Drawing.Point(580, 40);
            this.lblPalabras.Name = "lblPalabras";
            this.lblPalabras.Size = new System.Drawing.Size(183, 25);
            this.lblPalabras.TabIndex = 7;
            this.lblPalabras.Text = "Palabras a Buscar";

            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point);
            this.lblBuscar.Location = new System.Drawing.Point(580, 350);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(153, 23);
            this.lblBuscar.TabIndex = 8;
            this.lblBuscar.Text = "Ingresar Palabra";

            // 
            // lblResultadoTitulo
            // 
            this.lblResultadoTitulo.AutoSize = true;
            this.lblResultadoTitulo.Font = new System.Drawing.Font(
                "Segoe UI",
                11F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point);
            this.lblResultadoTitulo.Location = new System.Drawing.Point(580, 620);
            this.lblResultadoTitulo.Name = "lblResultadoTitulo";
            this.lblResultadoTitulo.Size = new System.Drawing.Size(112, 25);
            this.lblResultadoTitulo.TabIndex = 9;
            this.lblResultadoTitulo.Text = "Encontradas:";

            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font(
                "Segoe UI",
                14F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point);
            this.lblResultado.ForeColor = System.Drawing.Color.Red;
            this.lblResultado.Location = new System.Drawing.Point(710, 615);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(28, 32);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "0";

            // 
            // FrmSopa
            // 
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(870, 680);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblResultadoTitulo);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblPalabras);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtPalabra);
            this.Controls.Add(this.lstPalabras);
            this.Controls.Add(this.dgvSopa);
            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSopa";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sopa de Letras Oracle";

            ((System.ComponentModel.ISupportInitialize)(this.dgvSopa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSopa;
        private System.Windows.Forms.ListBox lstPalabras;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPalabras;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblResultadoTitulo;
        private System.Windows.Forms.Label lblResultado;
    }
}