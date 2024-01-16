using ClinicService.Data;
using System.Collections.Generic;

namespace ClinicDesctop
{
    public partial class Form1 : Form
    {
        delegate void MyDelegate(List<Client> clients);
        private List<Client> clients;
        public Form1()
        {
            InitializeComponent();
        }
        public void addListView(List<Client> clients)
        {
            ClinicServiceClient clinicClient = new ClinicServiceClient("http://localhost:5036/", new HttpClient());
            clients = clinicClient.ClientGetAllAsync().Result.ToList();
            listViewClients.Items.Clear();
            foreach (Client client in clients)
            {
                ListViewItem item = new ListViewItem();
                item.Text = client.ClientId.ToString();

                ListViewItem.ListViewSubItem subItem1 = new ListViewItem.ListViewSubItem();
                subItem1.Text = client.SurName;
                item.SubItems.Add(subItem1);

                ListViewItem.ListViewSubItem subItem2 = new ListViewItem.ListViewSubItem();
                subItem2.Text = client.FirstName;
                item.SubItems.Add(subItem2);

                ListViewItem.ListViewSubItem subItem3 = new ListViewItem.ListViewSubItem();
                subItem3.Text = client.Patronymic;
                item.SubItems.Add(subItem3);

                ListViewItem.ListViewSubItem subItem4 = new ListViewItem.ListViewSubItem();
                subItem4.Text = client.Document;
                item.SubItems.Add(subItem4);

                listViewClients.Items.Add(item);
            }

        }
        public void UpdateListView(List<Client> clients)
        {
            if (this.listViewClients.InvokeRequired)
                this.listViewClients.Invoke(new MyDelegate(UpdateListView), new List<Client>());
            else
            {
                addListView(clients);
            }
        }
        private void buttonLoadClients_Click(object sender, EventArgs e)
        {
            addListView(clients);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count == 0)
            {
                MessageBox.Show("Не выбрано ни одного элемента для удаления", "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            else if (MessageBox.Show("Хотите удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int removeId = int.Parse(listViewClients.SelectedItems[0].Text);
                ClinicServiceClient clinicClient = new ClinicServiceClient("http://localhost:5036/", new HttpClient());
                clinicClient.ClientDeleteAsync(removeId).Result.ToString();
                listViewClients.Items.RemoveAt(listViewClients.SelectedIndices[0]);
            }
        }
    }
}
