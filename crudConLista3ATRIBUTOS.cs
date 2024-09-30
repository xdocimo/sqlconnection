using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static recuperanazi.Form1;

namespace recuperanazi
{
    public partial class Form1 : Form
    {

        public class Producto
        {
            public int Id { get; set; }
            public string Descripcion { get; set; }
            public decimal Precio { get; set; }
        }

        private List<Producto> productos = new List<Producto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            string descripcion = textBox2.Text;
            decimal precio = decimal.Parse(textBox3.Text);

            productos.Add(new Producto { Id = id, Descripcion = descripcion, Precio = precio });
            label4.Text = $"{descripcion} agregado exitosamente";

            limpiarCampos();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Producto producto in productos)
            {
                listBox1.Items.Add($"ID: {producto.Id}, Descripción: {producto.Descripcion}, Precio: {producto.Precio:C}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            Producto producto = productos.FirstOrDefault(p => p.Id == id);
            productos.Remove(producto);
            label4.Text = $"{producto} borrado exitosamente";


        }

        private void limpiarCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            Producto producto = productos.FirstOrDefault(p => p.Id == id);
            producto.Descripcion = textBox2.Text;
            producto.Precio = int.Parse(textBox3.Text);
            label4.Text = $"{id} modificado con éxito";
            limpiarCampos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            Producto producto = productos.FirstOrDefault(p => p.Id == id);
            textBox2.Text = producto.Descripcion;
            textBox3.Text = producto.Precio.ToString();
        }
    }
}
