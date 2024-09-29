        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-2343MRH; Initial Catalog=TestDatabase; Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string sql = $"insert into empleados(documento,nombre,sueldo) values ('{textBox1.Text}', '{textBox2.Text}', {textBox3.Text})";
            SqlCommand comando = new SqlCommand(sql, conexion);
            comando.ExecuteNonQuery();
            label4.Text = $"{textBox1.Text}" + "registrado";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            conexion.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string sql = $"select nombre,sueldo from empleados where documento = '{textBox1.Text}'";
            SqlCommand comando = new SqlCommand(sql, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                textBox2.Text = registro["nombre"].ToString();
                textBox3.Text = registro["sueldo"].ToString();

            }
            conexion.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string sql = $"delete from empleados where documento='{textBox1.Text}'";
            SqlCommand comando = new SqlCommand(sql, conexion);
            int cant = comando.ExecuteNonQuery();
            if (cant > 0) {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                label4.Text = "Eliminado con exito";
            }
            else
            {
                label4.Text = "No existe ese dni.";
            }
            conexion.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string sql = $"update empleados set nombre='{textBox2.Text}', sueldo='{textBox3.Text}' where documento = '{textBox1.Text}'";
            SqlCommand comando = new SqlCommand (sql, conexion);
            int cant = comando.ExecuteNonQuery();
            if (cant > 0)
            {
                textBox2.Text = "";
                textBox3.Text = "";
                label4.Text = "Modificado con exito";
            }
            else
            {
                label4.Text = "No existe ese dni.";
            }
            conexion.Close();
        }
    }
}
