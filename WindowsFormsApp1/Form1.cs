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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Personas' table. You can move, or remove it, as needed.
            
            //this.database1DataSet.Personas.AddPersonasRow(personaNueva);
            this.personasTableAdapter.Fill(this.database1DataSet.Personas);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            // Si esta todo ok, i tiene el valor entero y devuleve true, si no, devuelve false.
            int i = 0;
            bool result = int.TryParse(this.edadTextbox.Text, out i);
            if (result == false)
            {
                MessageBox.Show("La edad debe ser numerica", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // Agrega una fila nueva a la base
            this.personasTableAdapter.Insert(this.nameTextbox.Text, this.apellidoTextbox.Text, int.Parse(this.edadTextbox.Text));
            // Actualiza la tabla que se ve con lo que esta en la base
            this.personasTableAdapter.Fill(this.database1DataSet.Personas);
        }

        /**
         * Hay que ingresar todos los valores en los inputs (O se cargan automáticamente al hacer click en la tabla) 
         * Y luego apretar borrar, eso llama a esta funcion
         */
        private void botonBorrar_Click(object sender, EventArgs e)
        {
            int id = 0;
            // Si el id es null, tira error, si no, valida lo demas
            if (!string.IsNullOrWhiteSpace(this.idTextBox.Text))
            {
                bool res = int.TryParse(this.idTextBox.Text, out id);
                if (res == true)
                {
                    // Acá borra el registro, si todo está bien, devuelve un 1, si no, un 0.
                    int delete = this.personasTableAdapter.Delete(id, this.nameTextbox.Text, this.apellidoTextbox.Text, int.Parse(this.edadTextbox.Text));
                    // Si devolvió un 0, es que hubo error, entonces muestra el error.
                    if (delete == 0)
                    {
                        MessageBox.Show("Alguno de los datos no es correcto, verifique los datos y el ID e intente nuevamente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // Si no hubo error, refresca la tabla.
                    this.personasTableAdapter.Fill(this.database1DataSet.Personas);
                }
            }
            else
            {
                MessageBox.Show("El id es nulo, inserte uno e intente nuevamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*
private void botonBorrar_Click(object sender, EventArgs e)
{
   foreach(DataRowView row in this.dataGridView1.SelectedRows) {
       // ESTO TODAVIA NO ANDA D:
       string sval = (row.Row)["id"] as string;
       this.personasTableAdapter.Delete(int.Parse(sval), null, null, null);
       this.personasTableAdapter.Fill(this.database1DataSet.Personas);
   }
}

private void textBox1_TextChanged(object sender, EventArgs e)
{
   this.database1DataSet.Personas.
}*/
    }
}
