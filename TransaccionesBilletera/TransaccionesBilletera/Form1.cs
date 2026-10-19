using System;
using System.Windows.Forms;

namespace TransaccionesBilletera
{
    public partial class Form1 : Form
    {
        ListaOperaciones lista;
        PilaReversiones pila;

        public Form1()
        {
            InitializeComponent();

            lista = new ListaOperaciones();
            pila = new PilaReversiones();

            cmbTipo.Items.Add("Pago");
            cmbTipo.Items.Add("Transferencia");
            cmbTipo.Items.Add("Recarga");

            dgvOperaciones.Columns.Add("codigo", "Código");
            dgvOperaciones.Columns.Add("tipo", "Tipo");
            dgvOperaciones.Columns.Add("monto", "Monto");
            dgvOperaciones.Columns.Add("origen", "Origen");
            dgvOperaciones.Columns.Add("destino", "Destino");
            dgvOperaciones.Columns.Add("estado", "Estado");

            btnRegistrar.Click += btnRegistrar_Click;
            btnHistorial.Click += btnHistorial_Click;
            btnBuscar.Click += btnBuscar_Click;
            btnSolicitarReversion.Click += btnSolicitarReversion_Click;
            btnProcesarReversion.Click += btnProcesarReversion_Click;

            lblPendientes.Text = "0";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();
            string tipo = cmbTipo.Text;
            string origen = txtOrigen.Text.Trim();
            string destino = txtDestino.Text.Trim();
            double monto;

            if (codigo == "" || tipo == "" ||
                origen == "" || destino == "")
            {
                MessageBox.Show("Completa todos los campos.");
                return;
            }

            if (!double.TryParse(txtMonto.Text, out monto) ||
                monto <= 0)
            {
                MessageBox.Show("Ingresa un monto válido.");
                return;
            }

            if (lista.Buscar(codigo) != null)
            {
                MessageBox.Show("El código ya existe.");
                return;
            }

            string dato = codigo + "|" + tipo + "|" + monto +
                          "|" + origen + "|" + destino + "|Registrada";

            lista.Adicionar(dato);

            MostrarHistorial();

            MessageBox.Show("Operación registrada correctamente.");

            txtCodigo.Clear();
            txtMonto.Clear();
            txtOrigen.Clear();
            txtDestino.Clear();
            cmbTipo.SelectedIndex = -1;

            txtCodigo.Focus();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            MostrarHistorial();
        }

        private void MostrarHistorial()
        {
            dgvOperaciones.Rows.Clear();

            Nodo p = lista.inicio;

            while (p != null)
            {
                string[] datos = p.info.Split('|');

                dgvOperaciones.Rows.Add(
                    datos[0],
                    datos[1],
                    datos[2],
                    datos[3],
                    datos[4],
                    datos[5]
                );

                p = p.sgte;
            }

            lblPendientes.Text = pila.Contar().ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtBuscar.Text.Trim();
            string dato = lista.Buscar(codigo);

            if (dato == null)
            {
                lblResultado.Text = "Operación no encontrada.";
            }
            else
            {
                string[] datos = dato.Split('|');

                lblResultado.Text =
                    "Código: " + datos[0] +
                    " | Tipo: " + datos[1] +
                    " | Monto: S/ " + datos[2] +
                    " | Estado: " + datos[5];
            }
        }

        private void btnSolicitarReversion_Click(
            object sender, EventArgs e)
        {
            string codigo = txtCodigoReversion.Text.Trim();
            string dato = lista.Buscar(codigo);

            if (dato == null)
            {
                MessageBox.Show("La operación no existe.");
                return;
            }

            string[] datos = dato.Split('|');

            if (datos[5] != "Registrada")
            {
                MessageBox.Show(
                    "La operación no está disponible para reversión."
                );
                return;
            }

            pila.Apilar(codigo);

            datos[5] = "Pendiente de reversión";

            ActualizarOperacion(datos);

            MostrarHistorial();

            MessageBox.Show("Operación en cola de reversión.");
        }

        private void btnProcesarReversion_Click(
            object sender, EventArgs e)
        {
            if (pila.Vacia())
            {
                MessageBox.Show("No hay solicitudes pendientes.");
                return;
            }

            string codigo = pila.Desapilar();
            string dato = lista.Buscar(codigo);

            if (dato == null)
            {
                MessageBox.Show("No se encontró la operación.");
                return;
            }

            string[] datos = dato.Split('|');

            if (datos[5] == "Pendiente de reversión")
            {
                datos[5] = "Revertida";
                ActualizarOperacion(datos);
            }

            MostrarHistorial();

            MessageBox.Show("Se procesó la reversión de " + codigo);
        }

        private void ActualizarOperacion(string[] datos)
        {
            Nodo p = lista.inicio;

            while (p != null)
            {
                string[] actual = p.info.Split('|');

                if (actual[0] == datos[0])
                {
                    p.info = string.Join("|", datos);
                    return;
                }

                p = p.sgte;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnSolicitarReversion_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
