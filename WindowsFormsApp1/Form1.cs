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

            // Todo esto se resueve con un :
            // Si esta todo ok, i tiene el valor entero y devuleve true, si no, devuelve false.
            int i = 0;
            bool result = int.TryParse(this.edadTextbox.Text, out i);
            if (result == false)
            {
                MessageBox.Show("BOLUDO", "La edad tiene que ser un número! JEROPARDI!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // Agrega una fila nueva a la base
            this.personasTableAdapter.Insert(this.nameTextbox.Text, this.apellidoTextbox.Text, int.Parse(this.edadTextbox.Text));
            // Actualiza la tabla que se ve con lo que esta en la base
            this.personasTableAdapter.Fill(this.database1DataSet.Personas);
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.idTextBox.Text)) {
                Console.WriteLine("Todo bien");

            }
         Console.WriteLine("El id no es numerico o no existe");
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
