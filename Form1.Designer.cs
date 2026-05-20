namespace SopaLetrasOracle
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Nombre = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            dgvSopa = new DataGridView();
            lstPalabras = new ListBox();
            txtPalabra = new TextBox();
            btnVerificar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            lblResultado = new Label();
            Nombre.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSopa).BeginInit();
            SuspendLayout();
            // 
            // Nombre
            // 
            Nombre.Controls.Add(tabPage1);
            Nombre.Controls.Add(tabPage2);
            Nombre.Location = new Point(1, 54);
            Nombre.Name = "Nombre";
            Nombre.SelectedIndex = 0;
            Nombre.Size = new Size(459, 384);
            Nombre.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(192, 72);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblResultado);
            tabPage2.Controls.Add(btnNuevo);
            tabPage2.Controls.Add(btnGuardar);
            tabPage2.Controls.Add(btnVerificar);
            tabPage2.Controls.Add(txtPalabra);
            tabPage2.Controls.Add(lstPalabras);
            tabPage2.Controls.Add(dgvSopa);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(451, 356);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvSopa
            // 
            dgvSopa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSopa.Location = new Point(33, 26);
            dgvSopa.Name = "dgvSopa";
            dgvSopa.Size = new Size(377, 304);
            dgvSopa.TabIndex = 0;
            // 
            // lstPalabras
            // 
            lstPalabras.FormattingEnabled = true;
            lstPalabras.ItemHeight = 15;
            lstPalabras.Location = new Point(55, 42);
            lstPalabras.Name = "lstPalabras";
            lstPalabras.Size = new Size(122, 154);
            lstPalabras.TabIndex = 1;
            // 
            // txtPalabra
            // 
            txtPalabra.Location = new Point(55, 208);
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(277, 23);
            txtPalabra.TabIndex = 2;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(56, 249);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(75, 23);
            btnVerificar.TabIndex = 3;
            btnVerificar.Text = "VERIFICAR";
            btnVerificar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(162, 249);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(257, 249);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 5;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.Location = new Point(56, 285);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(276, 26);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Nombre);
            Name = "Form1";
            Text = "Form1";
            Nombre.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSopa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Nombre;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvSopa;
        private ListBox lstPalabras;
        private TextBox txtPalabra;
        private Button btnVerificar;
        private Button btnGuardar;
        private Button btnNuevo;
        private Label lblResultado;
    }
}
