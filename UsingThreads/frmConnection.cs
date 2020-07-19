using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingThreads
{
    public partial class frmConnection : Form
    {
        public frmConnection()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLConnection._Connection = TestConnection();
            if (SQLConnection._Connection)
            {
                MessageBox.Show("Соединение с сервером установлено");
                this.Close();
            }
            else
            {
                MessageBox.Show("Соединение с сервером не установлено");
                return;
            }
        }
        private bool TestConnection()
        {
            this.Enabled = false;
            SQLConnection._DataSourse = tbDataSourse.Text;
            SQLConnection._InitialCatalog = tbInitialCatalog.Text;
            SQLConnection._IntegratedSecurity = chbIntegratedSecurity.Checked;
            Task<bool> TSQLC = Task.Run(() => SQLConnection.TestSQLCOnnection());
            TSQLC.Wait();
            this.Enabled = true;
            return TSQLC.Result;
        }
    }
}
