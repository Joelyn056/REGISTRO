using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegistroDeLibros.Entidades;

namespace RegistroDeLibros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Descripcion LlenaClase()
        {
            Descripcion libro = new Descripcion();
            libro.LibroId = (int)numericUpDown1.Value;
            libro.Descripcion = textBox1.Text;
            libro.Sigla = textBox2.Text;
            //libro.TipoId = comboBox2.SelectedItem.ToString();

            return libro;
        }

        private void button1_Click(object sender, EventArgs e) //Guardar
        {
            bool paso = false;
            //Determinar si es guardar o modificar
            if(numericUpDown1.Value == 0)       
                paso = BLL.LibroBLL.Guardar(LlenaClase());
                          
            else
                paso = BLL.LibroBLL.Editar(LlenaClase());

            //Informando si guardo
            if (paso)
                MessageBox.Show("Gruardado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                MessageBox.Show("No se puedo guardar!!", "fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            bool paso = false;
            try
            {
                Contexto.contexto = new Contexto();
                 if(Contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch(Exception)
            {
                throw;
            }
            return paso;

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(numericUpDown1.Value);

            if(BLL.LibroBLL.Eliminar(id))
               MessageBox.Show("Elimidado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                MessageBox.Show("No Se Pudo Eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
