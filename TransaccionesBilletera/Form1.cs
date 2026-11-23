using System;
using System.Windows.Forms;

namespace TransaccionesBilletera
{
    public partial class Form1 : Form
    {
        ListaOperaciones lista;
        PilaReversiones pila;
        ColaTransferencias cola;
        ArbolOperaciones arbol;
        int contPago = 0;
        int contTransferencia = 0;
        int contDeposito = 0;

        public Form1()
        {
            InitializeComponent();

            lista = new ListaOperaciones();
            pila = new PilaReversiones();
            cola = new ColaTransferencias();
            arbol = new ArbolOperaciones();

            cmbTipo.Items.Add("Pago");
            cmbTipo.Items.Add("Transferencia");
            cmbTipo.Items.Add("Depósito");

            cmbRecorridos.Items.Add("<Seleccionar>");
            cmbRecorridos.Items.Add("PreOrden");
            cmbRecorridos.Items.Add("InOrden");
            cmbRecorridos.Items.Add("PosOrden");
            cmbRecorridos.SelectedIndex = 0;

            dgvOperaciones.Columns.Add("codigo", "Código");
            dgvOperaciones.Columns.Add("tipo", "Tipo");
            dgvOperaciones.Columns.Add("monto", "Monto");
            dgvOperaciones.Columns.Add("origen", "Cuenta origen");
            dgvOperaciones.Columns.Add("destino", "Cuenta destino");
            dgvOperaciones.Columns.Add("estado", "Estado");
            dgvOperaciones.Columns.Add("atencion", "Atención");
            dgvOperaciones.Columns.Add("fecha", "Fecha");
            dgvOperaciones.Columns.Add("hora", "Hora");

            dgvOperaciones.Columns["fecha"].Width = 105;
            dgvOperaciones.Columns["hora"].Width = 105;

            btnRegistrar.Click += btnRegistrar_Click;
            btnBuscar.Click += btnBuscar_Click;
            btnSolicitarReversion.Click += btnSolicitarReversion_Click;
            btnProcesarReversion.Click += btnProcesarReversion_Click;
            btnAtender.Click += btnAtender_Click;
            btnMostrarArbol.Click += btnMostrarArbol_Click;

            lblPendientes.Text = "0";
            lblCola.Text = "0";
        }

        private string GenerarCodigoPorTipo(string tipo)
        {
            if (tipo == "Pago")
            {
                contPago++;
                return "PG" + contPago.ToString("D3");
            }

            if (tipo == "Transferencia")
            {
                contTransferencia++;
                return "TF" + contTransferencia.ToString("D3");
            }

            contDeposito++;
            return "DP" + contDeposito.ToString("D3");
        }

        private bool EsCelularValido(string celular)
        {
            if (celular.Length != 9)
            {
                return false;
            }

            foreach (char c in celular)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string tipo = cmbTipo.Text;
            string origen = txtOrigen.Text.Trim();
            string destino = txtDestino.Text.Trim();
            double monto;

            if (tipo == "" || origen == "" || destino == "")
            {
                MessageBox.Show("Completa todos los campos para registrar la operación.");
                return;
            }

            if (!EsCelularValido(origen) || !EsCelularValido(destino))
            {
                MessageBox.Show("Ingresa números de celular válidos de 9 dígitos en origen y destino.");
                return;
            }

            if (!double.TryParse(txtMonto.Text, out monto) || monto <= 0)
            {
                MessageBox.Show("Ingresa un monto mayor a cero.");
                return;
            }

            string codigo = GenerarCodigoPorTipo(tipo);

            DateTime ahora = DateTime.Now;
            string fecha = ahora.ToString("dd/MM/yyyy");
            string hora = ahora.ToString("HH:mm:ss");

            // Todas las operaciones entran registradas y quedan en cola para su atención.
            string estado = "Registrado";
            string atencion = "En cola";

            string dato = codigo + "|" + tipo + "|" + monto +
                          "|" + origen + "|" + destino + "|" + estado +
                          "|" + atencion + "|" + fecha + "|" + hora;

            Nodo nodo = lista.Adicionar(dato);
            arbol.Insertar(codigo, nodo);
            cola.Adicionar(codigo);

            MostrarHistorial();
            MostrarCola();

            MessageBox.Show("Operación registrada con el código " + codigo + " y enviada a cola.");

            txtMonto.Clear();
            txtOrigen.Clear();
            txtDestino.Clear();
            cmbTipo.SelectedIndex = -1;

            txtOrigen.Focus();
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
                    datos[5],
                    datos[6],
                    datos[7],
                    datos[8]
                );

                p = p.sgte;
            }

            lblPendientes.Text = pila.Contar().ToString();
        }

        private void MostrarCola()
        {
            txtCola.Clear();

            Nodo p = cola.frente;

            while (p != null)
            {
                txtCola.AppendText(p.info + "  ");
                p = p.sgte;
            }

            lblCola.Text = cola.Contar().ToString();
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (cola.Vacia())
            {
                MessageBox.Show("No hay operaciones en cola.");
                return;
            }

            string codigo = cola.Atender();
            Nodo nodo = arbol.Buscar(codigo);

            if (nodo != null)
            {
                string[] datos = nodo.info.Split('|');
                datos[6] = "Atendido";
                nodo.info = string.Join("|", datos);
            }

            MostrarCola();
            MostrarHistorial();

            MessageBox.Show("Se atendió la operación " + codigo + ".");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtBuscar.Text.Trim();

            Nodo nodo = arbol.Buscar(codigo);
            int compArbol = arbol.comparaciones;

            lista.Buscar(codigo);
            int compLista = lista.comparaciones;

            if (nodo == null)
            {
                lblResultado.Text = "No se encontró ninguna operación con ese código.";
            }
            else
            {
                string[] datos = nodo.info.Split('|');

                lblResultado.Text =
                    "Código: " + datos[0] +
                    " | Tipo: " + datos[1] +
                    " | Monto: S/ " + datos[2] +
                    " | Estado: " + datos[5] +
                    " | Atención: " + datos[6] +
                    Environment.NewLine +
                    "Comparaciones -> Árbol: " + compArbol +
                    " | Lista: " + compLista;
            }
        }

        private void btnSolicitarReversion_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoReversion.Text.Trim();
            Nodo nodo = arbol.Buscar(codigo);

            if (nodo == null)
            {
                MessageBox.Show("No existe una operación con ese código.");
                return;
            }

            string[] datos = nodo.info.Split('|');

            if (datos[6] == "En cola")
            {
                MessageBox.Show("La operación aún está en cola (En cola); atiéndela antes de revertirla.");
                return;
            }

            if (datos[5] != "Registrado")
            {
                MessageBox.Show("Esta operación ya no se puede enviar a reversión.");
                return;
            }

            pila.Apilar(codigo);

            datos[5] = "Pendiente";
            nodo.info = string.Join("|", datos);

            MostrarHistorial();

            MessageBox.Show("La solicitud de reversión quedó pendiente.");
        }

        private void btnProcesarReversion_Click(object sender, EventArgs e)
        {
            if (pila.Vacia())
            {
                MessageBox.Show("No hay solicitudes de reversión pendientes.");
                return;
            }

            string codigo = pila.Desapilar();
            Nodo nodo = arbol.Buscar(codigo);

            if (nodo != null)
            {
                string[] datos = nodo.info.Split('|');
                datos[5] = "Anulado";
                nodo.info = string.Join("|", datos);
            }

            MostrarHistorial();

            MessageBox.Show("Se anuló la operación " + codigo + ".");
        }

        private void MostrarPreOrden(Nodo p)
        {
            if (p != null)
            {
                txtArbol.AppendText(p.codigo + "  ");
                MostrarPreOrden(p.izq);
                MostrarPreOrden(p.der);
            }
        }

        private void MostrarInOrden(Nodo p)
        {
            if (p != null)
            {
                MostrarInOrden(p.izq);
                txtArbol.AppendText(p.codigo + "  ");
                MostrarInOrden(p.der);
            }
        }

        private void MostrarPosOrden(Nodo p)
        {
            if (p != null)
            {
                MostrarPosOrden(p.izq);
                MostrarPosOrden(p.der);
                txtArbol.AppendText(p.codigo + "  ");
            }
        }

        private void btnMostrarArbol_Click(object sender, EventArgs e)
        {
            int pos = cmbRecorridos.SelectedIndex;

            txtArbol.Clear();

            switch (pos)
            {
                case 1:
                    MostrarPreOrden(arbol.raiz);
                    break;
                case 2:
                    MostrarInOrden(arbol.raiz);
                    break;
                case 3:
                    MostrarPosOrden(arbol.raiz);
                    break;
                default:
                    MessageBox.Show("Debe seleccionar uno de los recorridos.");
                    break;
            }
        }
    }
}