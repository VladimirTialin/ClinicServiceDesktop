using ClinicService.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ClinicDesctop
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 _form1)
        {
            InitializeComponent();
            form1 = _form1;
            Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            ClinicServiceClient clinicClient = new ClinicServiceClient("http://localhost:5036/", new HttpClient());
            CreateClientRequest newClient = new CreateClientRequest();
            newClient.SurName = SureName.Text;
            newClient.FirstName = FirstName.Text;
            newClient.Patronymic = Partonic.Text;
            newClient.Document = Document.Text;
            newClient.Birthday = new DateTime(2015, 7, 20);
            clinicClient.ClientCreateAsync(newClient).Result.ToString();
            List<Client> clients = clinicClient.ClientGetAllAsync().Result.ToList();
            form1.UpdateListView(clients);
            Close();
        }

    }
}
