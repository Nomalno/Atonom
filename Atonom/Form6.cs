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
    public partial class Form6 : Form
    {
        BaseEntities entities;
        public Form6()
        {
            entities = new BaseEntities();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show(); this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.CosmicBody". При необходимости она может быть перемещена или удалена.
            this.cosmicBodyTableAdapter.Fill(this.baseDataSet.CosmicBody);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CosmicBody cosm= new CosmicBody();
            textBox1.Text = cosm.Name;
            textBox2.Text = cosm.Weigth.ToString();
            textBox3.Text = cosm.radius.ToString();
            textBox4.Text = cosm.location;
            entities.CosmicBody.Add(cosm);
            entities.SaveChanges();
        }
    }
}
