using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atonom
{
    public partial class Form5 : Form
    {
        BaseEntities entity;
        public Form5()
        {
            entity = new BaseEntities();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show(); this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.Stars". При необходимости она может быть перемещена или удалена.
            this.starsTableAdapter.Fill(this.baseDataSet.Stars);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stars stars = new Stars();
            textBox1.Text= stars.Name;
            textBox2.Text = stars.constellation;
            textBox3.Text=stars.Type; 
            textBox4.Text=stars.Diameter.ToString(); 
            textBox5.Text=stars.Distance.ToString();
            textBox6.Text = stars.Light.ToString();
            entity.Stars.Add(stars);
            entity.SaveChanges();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
