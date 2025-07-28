using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> libretas = new List<int>();
        List<string> nombres = new List<string>();
        List<double> notas = new List<double>();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbLibreta.Text, out int libreta) &&
                double.TryParse(tbNota.Text, out double nota) &&
                !string.IsNullOrWhiteSpace(tbNombre.Text))

            { 
                libretas.Add(libreta);
                nombres.Add(tbNombre.Text);
                notas.Add(nota);
                
                MessageBox.Show("Alumno Registrado Correctamente");
                tbLibreta.Clear();
                tbNombre.Clear();
                tbNota.Clear();
            }

            else
            {
                MessageBox.Show("Datos invalidos");
            }
        }

        private void btnAlumnoMayoryMenorNota_Click(object sender, EventArgs e)
        {
            if (notas.Count == 0)
            {
                MessageBox.Show("No hay alumnos registrados.");
                return;
            }

            double maxnota = notas.Max();
            double minnota = notas.Min();
            int indiceMax = notas.IndexOf(maxnota);
            int indicexMin = notas.IndexOf(minnota);

            listBox1.Items.Clear();
            listBox1.Items.Add($"Mayor Nota: {nombres[indiceMax]} - {notas[indiceMax]}");
            listBox1.Items.Add($"Menor Nota: {nombres[indicexMin]} - {notas[indicexMin]}");
        }

        private void btnCantAlumnos_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add($"Cantidad total de alumnos: {nombres.Count}");
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            if (notas.Count == 0)
            {
                MessageBox.Show("No hay datos");
                return;
            }

            double promedio = notas.Average();
            listBox1.Items.Clear();
            listBox1.Items.Add($"Promedio notas: {promedio:F2}");
        }

        private void btnListaOrdenada_Click(object sender, EventArgs e)
        {
            var ordenados = libretas
                .Select((lib, i) => new { libretas = lib, nombre = nombres[i], Nota = notas[i] })
                .OrderBy(a => a.libretas)
                .ToList();

            listBox1.Items.Clear();
            foreach (var alumno in ordenados)
            {
                listBox1.Items.Add($"Libreta: {alumno.libretas} - {alumno.nombre} - Nota: {alumno.Nota}");
            }
        }

        private void btnListaOrdenadaPromedio_Click(object sender, EventArgs e)
        {
            if (notas.Count == 0)
            {
                MessageBox.Show("No hay datos");
                return;
            }

            double promedio = notas.Average();
            listBox1.Items.Clear();
            listBox1.Items.Add($"Promedio: {promedio:F2}");
            listBox1.Items.Add("Alumnos que superan el promedio:");

            for (int i = 0; i < notas.Count; i++)
            {
                if (notas[i] > promedio)
                {
                    listBox1.Items.Add($"{nombres[i]} - Nota: {notas[i]}");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbBuscarLibreta.Text, out int libretaBuscar))
            {
                int index = libretas.IndexOf(libretaBuscar);
                if (index != -1)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add($"Libreta: {libretas[index]} - Nombre: {nombres[index]} - Nota: {notas[index]}");
                }
                else
                {
                    MessageBox.Show("Libreta no encontrada.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido para la libreta.");
            }
        }
    }
}