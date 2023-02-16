using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEjercicioMarceprimerparcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int LadoA, LadoB, LadoC, Perimetro;
        double Area, p;
        string TipodeTriangulo;
        private void SalirButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Desea salir del Formulario?", "Confirmar Selección", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            Application.Exit();
        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            TriangulosDataGridView.Rows.Clear();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            LadoATextBox.Clear();
            LadoBTextBox.Clear();
            LadoCTextBox.Clear();
            LadoATextBox.Focus();
            ErrorProvider.Clear();
        }

        private void ConfirmarButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                LadoA = int.Parse(LadoATextBox.Text);
                LadoB = int.Parse(LadoBTextBox.Text);
                LadoC = int.Parse(LadoCTextBox.Text);
                if (ConfirmarTriangulo())
                {
                    p = ObtenerSemiperimetro(LadoA, LadoB, LadoC);
                    Perimetro = ObtenerPerimetro(LadoA, LadoB, LadoC);
                    Area = ObtenerArea(LadoA, LadoB, LadoC, p);
                    TipodeTriangulo = ObtenerTriangulo(LadoA, LadoB, LadoC);
                    var r = ConstruiFila();
                    SetearFila(r,LadoA, LadoB, LadoC, Perimetro, Area, TipodeTriangulo);
                    AgregarFila(r);
                    LimpiarCampos();
                }
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            TriangulosDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, int ladoA, int ladoB, int ladoC, int perimetro, double area, string tipodeTriangulo)
        {
            r.Cells[colLadoA.Index].Value = ladoA.ToString();
            r.Cells[colLadoB.Index].Value = ladoB.ToString();
            r.Cells[colLadoC.Index].Value = ladoC.ToString();
            r.Cells[colPerimetro.Index].Value = perimetro.ToString();
            r.Cells[colSuperficie.Index].Value = area.ToString("N2");
            r.Cells[colTipo.Index].Value = tipodeTriangulo;
        }

        private DataGridViewRow ConstruiFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(TriangulosDataGridView);
            return r;
        }

        private string ObtenerTriangulo(int ladoA, int ladoB, int ladoC)
        {
            string tipo;
            if (Math.Pow(ladoA, 2) > Math.Pow(ladoB, 2) + Math.Pow(ladoC, 2) || Math.Pow(ladoB, 2) > Math.Pow(ladoA, 2) + Math.Pow(ladoC, 2) || Math.Pow(ladoC, 2) > Math.Pow(ladoB, 2) + Math.Pow(ladoA, 2))
            {
                tipo = "Obtusángulo";
            }
            else
            {
                if (Math.Pow(ladoA, 2) == Math.Pow(ladoB, 2) + Math.Pow(ladoC, 2) || Math.Pow(ladoB, 2) == Math.Pow(ladoA, 2) + Math.Pow(ladoC, 2) || Math.Pow(ladoC, 2) == Math.Pow(ladoB, 2) + Math.Pow(ladoA, 2))
                {
                    tipo = "Rectángulo";
                }
                else
                {
                    tipo =  "Acutángulo";
                }
            }
            return tipo;
        }

        private double ObtenerArea(int ladoA, int ladoB, int ladoC, double p)
        {
            return Math.Sqrt((p * (p - ladoA) * (p - ladoB) * (p - ladoC)));
        }

        private int ObtenerPerimetro(int ladoA, int ladoB, int ladoC)
        {
            return ladoA + ladoB + ladoC;
        }

        private double ObtenerSemiperimetro(int ladoA, int ladoB, int ladoC)
        {
            return (ladoA + ladoB + ladoC) / 2;
        }

        private bool ConfirmarTriangulo()
        {
            bool valido = true;
            if(!(LadoA+LadoB>LadoC && LadoA+LadoC>LadoB && LadoB + LadoC > LadoA))
            {
                valido = false;
                MessageBox.Show("Los datos ingresados NO conforman un triángulo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return valido;
        }

        private bool ValidarDatos()
        {
            ErrorProvider.Clear();
            bool valido = true;
            if(!int.TryParse(LadoATextBox.Text,out LadoA))
            {
                valido = false;
                ErrorProvider.SetError(LadoATextBox, "El dato ha ingresar debe ser un número");
            }
            else
            {
                if (LadoA <= 0)
                {
                    valido = false;
                    ErrorProvider.SetError(LadoATextBox, "El número ha ingresar debe ser positivo");
                }
            }
            if(!int.TryParse(LadoBTextBox.Text,out LadoB))
            {
                valido = false;
                ErrorProvider.SetError(LadoBTextBox, "El dato ha ingresar debe ser un número");
            }
            else
            {
                if (LadoB <= 0)
                {
                    valido = false;
                    ErrorProvider.SetError(LadoBTextBox, "El número debe ser positivo");
                }
            }
            if(!int.TryParse(LadoCTextBox.Text, out LadoC))
            {
                valido = false;
                ErrorProvider.SetError(LadoCTextBox, "El dato ha ingresar debe ser un número");
            }
            else
            {
                if (LadoC <= 0)
                {
                    valido = false;
                    ErrorProvider.SetError(LadoCTextBox, "El número debe ser positivo");
                }
            }
            return valido;
        }
    }
}
