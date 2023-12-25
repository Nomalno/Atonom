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
    public partial class Form4 : Form
    {
        BaseEntities entity;
        public Form4()
        {
            entity= new BaseEntities();
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.Planets". При необходимости она может быть перемещена или удалена.
            this.planetsTableAdapter.Fill(this.baseDataSet.Planets);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show(); this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Planets planets = new Planets();
            textBox1.Text = planets.Name;
            textBox2.Text = planets.Type;
            textBox3.Text = planets.Weight.ToString();
            textBox4.Text = planets.Size.ToString();
            textBox5.Text= planets.DistanceKM.ToString();
            textBox6.Text = planets.CircleTimeD.ToString();
            textBox7.Text = planets.Satellites.ToString();
            entity.Planets.Add(planets);
            entity.SaveChanges();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
