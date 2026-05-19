# -_aplicacion_Sopa_de_Letras_- :.
Aplicacion Sopa de Letras:

<img width="1024" height="1024" alt="image" src="https://github.com/user-attachments/assets/82cfed38-4e3b-4477-ab2b-98dce17d9850" />  

```
Visual Studio 2022 + C# + Windows Forms + Oracle 19c.

Proyecto completo tipo escritorio desarrollado con Windows Forms y Oracle 19c, que permite generar automáticamente una sopa de letras con 15 palabras ocultas, validar coincidencias y registrar resultados en base de datos .

Características del Proyecto:
Interfaz gráfica en Windows Forms
Generación automática de sopa de letras
15 palabras ocultas
Validación de palabras encontradas
Registro de partidas en Oracle 19c
Arquitectura básica por capas
Compatible con Visual Studio 2022

Tecnologias Utilizadas:
Visual Studio 2022
C#
.NET Framework / .NET
Windows Forms
Oracle 19c
Oracle ManagedDataAccess
SQL
Programación Orientada a Objetos

Funcionalidades:
✔ Generar sopa de letras automática
✔ Mostrar lista de 15 palabras
✔ Buscar palabras en tablero
✔ Registrar fecha y resultado en Oracle 19c
✔ Mostrar cantidad de palabras encontradas
✔ Reiniciar juego

Estructura del Proyecto
SopaLetrasOracle/
│
├── Conexion/
│   └── ConexionOracle.cs
│
├── Modelos/
│   └── ResultadoJuego.cs
│
├── Formularios/
│   └── FrmSopa.cs
│
├── Program.cs
└── App.config

Paso 1 — Crear Base de Datos Oracle 19c
Tabla Oracle
CREATE TABLE RESULTADOS_SOPA (
    ID NUMBER GENERATED ALWAYS AS IDENTITY,
    FECHA_JUEGO DATE,
    PALABRAS_ENCONTRADAS NUMBER,
    JUGADOR VARCHAR2(100)
);

Paso 2 — Crear Proyecto en Visual Studio
Crear proyecto
Abrir Visual Studio 2022
Crear nuevo proyecto
Seleccionar:
Windows Forms App (.NET Framework)
Nombre del proyecto:
SopaLetrasOracle.

Paso 3 — Instalar Paquete Oracle
NuGet
Install-Package Oracle.ManagedDataAccess

Paso 4 — Clase de Conexión Oracle
ConexionOracle.cs
using Oracle.ManagedDataAccess.Client;

namespace SopaLetrasOracle.Conexion
{
    public class ConexionOracle
    {
        private string conexion =
            "DATA SOURCE=localhost:1521/XEPDB1;USER ID=SYSTEM;PASSWORD=123456";

        public OracleConnection ObtenerConexion()
        {
            OracleConnection cn = new OracleConnection(conexion);
            cn.Open();
            return cn;
        }
    }
}

Paso 5 — Modelo ResultadoJuego
ResultadoJuego.cs
namespace SopaLetrasOracle.Modelos
{
    public class ResultadoJuego
    {
        public int PalabrasEncontradas { get; set; }

        public string Jugador { get; set; }
    }
}

Paso 6 — Diseño del Formulario
Formulario FrmSopa
Agregar los siguientes controles:
Control	Nombre
DataGridView	dgvSopa
ListBox	lstPalabras
TextBox	txtPalabra
Button	btnVerificar
Button	btnGuardar
Button	btnNuevo
Label	lblResultado

Paso 7 — Código Completo del Formulario
FrmSopa.cs
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

Paso 8 — Program.cs
using System;
using System.Windows.Forms;
using SopaLetrasOracle.Formularios;

namespace SopaLetrasOracle
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FrmSopa());
        }
    }
}

Resultado Final:
La aplicacion permitira:
Generar automáticamente la sopa de letras
Buscar 15 palabras
Validar coincidencias
Mostrar progreso del jugador
Guardar resultados en Oracle 19c.

Mejoras Futuras
Seleccion de letras con mouse
Cronómetro
Niveles de dificultad
Puntajes
Ranking de jugadores
Colores dinámicos
Música de fondo
Generación horizontal y vertical
Exportar resultados PDF

Ejemplo de Palabras:
ORACLE
VISUAL
STUDIO
WINDOWS
FORM
DATABASE
CODIGO
NET
CSHARP
PROGRAMACION
JUEGO
SOPA
LETRAS
SQL
DESARROLLO

Requisitos:
Visual Studio 2022
Oracle Database 19c
.NET Framework
Oracle ManagedDataAccess
Windows 10 / Windows 11 .
:. . / .  
