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
            /*
            // No me esta andando, pero deberia tirar un cartel si no era un numero
            try
            {
                // Intenta hacer de cuenta que era un numero
                int.Parse(this.edadTextbox.Text);
            }
            catch {
                // Avisa con un mensaje
                MessageBox.Show("BOLUDO", "La edad tiene que ser un número! JEROPARDI!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // Sale del metodo sin devolver nada, porque el metodo es void
                return;
            }*/

            // Agrega una fila nueva a la base
            this.personasTableAdapter.Insert(this.nameTextbox.Text, this.apellidoTextbox.Text, int.Parse(this.edadTextbox.Text));
            // Actualiza la tabla que se ve con lo que esta en la base
            this.personasTableAdapter.Fill(this.database1DataSet.Personas);
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
