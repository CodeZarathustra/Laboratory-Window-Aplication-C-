using CapaEntidades;
using CapaNegocioApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaDePresentacion
{
    public partial class Contenedor : Form
    {
        public Contenedor()
        {
            InitializeComponent();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {

        }

        private void Ingresar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void panel1CustomerField_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIDCliente_TextChanged(object sender, EventArgs e)
        {
            
        }

        // Change the access keyworld for test
        public void comboBoxSelectVista_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxSelectVista.SelectedIndex;
            if (index == 0)
            {
                tabControlContenedor.Visible = true;
                panel1CustomerField.Visible = false;
                labelTitulo.Visible = true;
                labelTitulo.Text = "GESTIONAR PRODUCTO";
            }
            else if (index == 1)
            {
                panel1CustomerField.Visible = true;
                tabControlContenedor.Visible = false;
                labelTitulo.Text = "INGRESAR NUEVO CLIENTE";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2NombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardarCliente_Click(object sender, EventArgs e)
        {
            //Crear un Objeto Customer para Asignar valores Ingresado en TextField
            String id = textBoxIDCliente.Text;
            String nombre = textBox2NombreCliente.Text;
            String direccion = textBox3DireccionCliente.Text;
            String celular = textBox4CelularCliente.Text;
            String email = textBox5EmailCliente.Text;
            //Se utiliza la clase de la capa de Entidad
            Customer customer = new Customer(id,nombre,direccion,celular,email);
            //Se instancia un objeto de la clase agragar cliente desde al capa
            //de negocios
            Agregar nuevoCliente = new Agregar();
            nuevoCliente.addCustomer(customer);

            //OcultarPanel
            panel1CustomerField.Visible = false;

            //Limpiar Datos 
            textBoxIDCliente.Clear();
            textBox2NombreCliente.Clear();
            textBox3DireccionCliente.Clear();
            textBox4CelularCliente.Clear();
            textBox5EmailCliente.Clear();



        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonGuardarNPro_Click(object sender, EventArgs e)
        {
            //Se accede a los cmapos ingresado en el textBox
            string codeProucto = textBox1CodigoIngr.Text;
            string  descriProduc= textBox2DescripcionIngr.Text;
            //If structure for convert an delimiter 
            string precioProd = textBox3ValorIngre.Text;
            Int64 valorPrecioConvertido;
            string cantidadPrdo = textBox4CantidadIngre.Text;
            int valorCantidadConver;
            if (Int64.TryParse(precioProd,out valorPrecioConvertido)&&int.TryParse(cantidadPrdo, out valorCantidadConver ))
            {
                Product producto = new Product(codeProucto,descriProduc,valorPrecioConvertido,valorCantidadConver);

                Agregar nuevoProducto = new Agregar();
                nuevoProducto.addProducto(producto);

                //Limpiar campos
                textBox1CodigoIngr.Clear();
                textBox2DescripcionIngr.Clear();
                textBox3ValorIngre.Clear();
                textBox4CantidadIngre.Clear();

            } else
            {
                //Mensage de error
                //textBox1CodigoIngr.Clear();
                //textBox2DescripcionIngr.Clear();
                textBox3ValorIngre.Text = "Error: Campos numericos*";
                textBox4CantidadIngre.Text = "Error: Campos numericos*";
                
            }
            
            
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBox1CodigoIngr.Clear();
            textBox2DescripcionIngr.Clear();
            textBox3ValorIngre.Clear();
            textBox4CantidadIngre.Clear();
        }
    }
}
