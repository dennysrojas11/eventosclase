using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalir_MouseEnter(object sender, EventArgs e)
        {
            labelMensaje.Text = "El mouse ingresó";
        }

        private void buttonSalir_MouseLeave(object sender, EventArgs e)
        {
            labelMensaje.Text = "El mouse se alejó";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxVacio.AllowDrop = true; 
        }

        private void pictureBoxLleno1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxLleno1.DoDragDrop(pictureBoxLleno1.Image, DragDropEffects.Copy);
        }

        private void pictureBoxLleno2_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxLleno2.DoDragDrop(pictureBoxLleno2.Image, DragDropEffects.Copy);
        }

        private void pictureBoxVacio_DragDrop(object sender, DragEventArgs e)
        {
            pictureBoxVacio.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pictureBoxLleno1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxLleno1.DoDragDrop(pictureBoxLleno1.Image, DragDropEffects.Copy);
        }

        private void pictureBoxLleno2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxLleno2.DoDragDrop(pictureBoxLleno2.Image, DragDropEffects.Copy);
        }

        private void pictureBoxLleno1_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void pictureBoxVacio_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
    }
}
