using Oracle.ManagedDataAccess.Client;
using SopaLetrasOracle.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SopaLetrasOracle.Formularios
{
    public partial class FrmSopa : Form
    {
        string[] palabras =
        {
            "ORACLE",
            "VISUAL",
            "STUDIO",
            "WINDOWS",
            "FORM",
            "DATABASE",
            "CODIGO",
            "NET",
            "CSharp",
            "PROGRAMACION",
            "JUEGO",
            "SOPA",
            "LETRAS",
            "SQL",
            "DESARROLLO"
        };

        char[,] matriz = new char[15, 15];

        int encontradas = 0;

        public FrmSopa()
        {
            InitializeComponent();

            GenerarSopa();
            MostrarSopa();
            CargarPalabras();
        }

        private void GenerarSopa()
        {
            Random rnd = new Random();

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    matriz[i, j] = Convert.ToChar(rnd.Next(65, 91));
                }
            }

            for (int p = 0; p < palabras.Length; p++)
            {
                string palabra = palabras[p].ToUpper();

                int fila = p;

                for (int c = 0; c < palabra.Length; c++)
                {
                    matriz[fila, c] = palabra[c];
                }
            }
        }

        private void MostrarSopa()
        {
            dgvSopa.ColumnCount = 15;
            dgvSopa.RowCount = 15;

            dgvSopa.RowHeadersVisible = false;

            for (int i = 0; i < 15; i++)
            {
                dgvSopa.Columns[i].Width = 30;
            }

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    dgvSopa.Rows[i].Cells[j].Value = matriz[i, j];
                }
            }
        }

        private void CargarPalabras()
        {
            lstPalabras.Items.Clear();

            foreach (string palabra in palabras)
            {
                lstPalabras.Items.Add(palabra);
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text.ToUpper();

            if (palabras.Contains(palabra))
            {
                encontradas++;

                lblResultado.Text =
                    "Palabra encontrada: " + encontradas;

                MessageBox.Show("Correcto");

                lstPalabras.Items.Remove(palabra);
            }
            else
            {
                MessageBox.Show("Palabra incorrecta");
            }

            txtPalabra.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ConexionOracle conexion = new ConexionOracle();

            using (OracleConnection cn = conexion.ObtenerConexion())
            {
                string sql =
                    @"INSERT INTO RESULTADOS_SOPA
                    (FECHA_JUEGO, PALABRAS_ENCONTRADAS, JUGADOR)
                    VALUES
                    (:fecha, :cantidad, :jugador)";

                OracleCommand cmd = new OracleCommand(sql, cn);

                cmd.Parameters.Add(":fecha", DateTime.Now);
                cmd.Parameters.Add(":cantidad", encontradas);
                cmd.Parameters.Add(":jugador", "Jugador1");

                cmd.ExecuteNonQuery();

                MessageBox.Show("Resultado guardado en Oracle");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            encontradas = 0;

            lblResultado.Text = "0";

            GenerarSopa();

            MostrarSopa();

            CargarPalabras();
        }
    }
}