using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_form1
{
    public partial class My_form : Form
    {
        public My_form()
        {
            InitializeComponent();
        }

        private void Run_button_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            double a = Convert.ToDouble(txtA.Text);          
            double h = Convert.ToDouble(txtH.Text);
            Triangle triangles = new Triangle(a, h);
            listView1.Items.Add("Сторона b:");
            listView1.Items.Add("Сторона h:");
            listView1.Items.Add("Основание:");
            listView1.Items.Add("Периметр:");
            listView1.Items.Add("Площадь:");
            listView1.Items.Add("Существует?:");
            listView1.Items.Add("Спецификатор:");
            listView1.Items[0].SubItems.Add($"{triangles.outputA()} cm");
            listView1.Items[1].SubItems.Add($"{triangles.outputH()} cm");

            if (triangles.GetSetAA > triangles.GetSetH)
            {
                listView1.Items[2].SubItems.Add($"{triangles.osnov()} cm");
                listView1.Items[5].SubItems.Add("Существует");
                pictureBox1.Image = Properties.Resources.Ravnobd;
            }
            else
            {
                listView1.Items[2].SubItems.Add("Высота больше чем бок. сторона");
                listView1.Items[5].SubItems.Add("Не существует");
                pictureBox1.Image = Properties.Resources.Trollface_non_free;
            }
            
            listView1.Items[3].SubItems.Add($"{Convert.ToString(triangles.area())} cm");
            listView1.Items[4].SubItems.Add($"{Convert.ToString(triangles.square())} cm");

            listView1.Items[6].SubItems.Add(triangles.TriangleType);
        }
    }
}
