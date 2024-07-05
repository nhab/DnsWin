using switchDns;

namespace DnsWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InterfacesListBox.DataSource = DnsUtils.GetInterface();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           List<string> l= DnsUtils.GetDNSs(InterfacesListBox.SelectedItems[0].ToString());
            DnsListBox.DataSource = l;
        }
    }
}
