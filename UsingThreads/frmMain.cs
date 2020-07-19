using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingThreads
{
    public partial class frmMain : Form
    {
        Procedures proc = new Procedures();
        DataTable dtPersons;
        public frmMain()
        {
            InitializeComponent();
        }

        #region Настройки ивентов
        private void новоеПодключениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConnection frmConnection = new frmConnection();
            frmConnection.ShowDialog();
            tSSL.Text = SQLConnection._Connection ? $"Текущее соединение. Сервер: {SQLConnection._DataSourse} | База данных: {SQLConnection._InitialCatalog} " : "Текущее соединение. Нет подключения к серверу.";
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            tSSL.Text = SQLConnection._Connection ? $"Текущее соединение. Сервер: {SQLConnection._DataSourse} | База данных: {SQLConnection._InitialCatalog} " : "Текущее соединение. Нет подключения к серверу.";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (SQLConnection._Connection)
            {
                //ArrayList arrayList = new ArrayList();
                //arrayList.Add(dtpStart.Value);
                //arrayList.Add(dtpEnd.Value);
                //foreach (var item in arrayList)
                //{
                //    Console.WriteLine(item);
                //}
                GetAll();
                GetCount();
            }
            else
            {
                MessageBox.Show("Соединение с сервером не установлено.\nУстанвите подключение", "Нет соединения с сервером", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void GetCount()
        {
            if (dtPersons != null && dtPersons.Rows.Count > 0)
            {
                string statusCount = (int)cbStatus.SelectedValue == 0 ? dtPersons.Rows.Count.ToString() : dtPersons.DefaultView.ToTable().Select("IdStatus = '" + cbStatus.SelectedValue + "'").Length.ToString();
                lblStat.Text = $"Кол-во со статусом {cbStatus.Text}: {statusCount}; " +
                                $"Кол-во принятых: {dtPersons.DefaultView.ToTable().Select("date_employ is not null AND date_uneploy is null").Length}; " +
                                $"Кол-во уволенных: {dtPersons.DefaultView.ToTable().Select("date_uneploy is not null").Length}";
            }
        }
        private void cbDeps_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filtering();
        }
        private void cbStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filtering();
            GetCount();
        }
        private void cbPost_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filtering();
        }
        #endregion

        private void GetAll()
        {
            DoOnUIThread(delegate ()
            {
                this.Enabled = false;
            });
            //Task<DataTable> TP = Task.Run(() => proc.GetPersons(dtpStart.Value, dtpEnd.Value));
            Task<DataTable> TP = Task.Factory.StartNew(() => proc.GetPersons(dtpStart.Value, dtpEnd.Value));
            //TP.Start();
            TP.Wait();
            Task<DataTable> TS = Task.Run(() => proc.GetStatus());
            Task<DataTable> TD = Task.Run(() => proc.GetDeps());
            Task<DataTable> TPST = Task.Run(() => proc.GetPosts());
            Task.WaitAll(new[] { TP, TS, TD, TPST });
            DoOnUIThread(delegate ()
            {
                dtPersons = TP.Result;
                dataGridView1.DataSource = dtPersons;
                cbStatus.DataSource = TS.Result;
                cbStatus.ValueMember = "id";
                cbStatus.DisplayMember = "name";
                cbDeps.DataSource = TD.Result;
                cbDeps.ValueMember = "id";
                cbDeps.DisplayMember = "name";
                cbPost.DataSource = TPST.Result;
                cbPost.ValueMember = "id";
                cbPost.DisplayMember = "name";
                this.Enabled = true;
            });
        }
        private void DoOnUIThread(MethodInvoker dMI)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(dMI);
            }
            else
            {
                dMI();
            }
        }
        private void Filtering()
        {
            if (dtPersons != null && dtPersons.Rows.Count != 0)
            {
                string filter = "";
                if (filter.Length > 0 && (int)cbStatus.SelectedValue != 0)
                {
                    filter += " AND ";
                }
                if ((int)cbStatus.SelectedValue != 0)
                {
                    filter += "IdStatus = '" + cbStatus.SelectedValue + "'";
                }
                if (filter.Length > 0 && (int)cbDeps.SelectedValue != 0)
                {
                    filter += " AND ";
                }
                if ((int)cbDeps.SelectedValue != 0)
                {
                    filter += "IdDep = '" + cbDeps.SelectedValue + "'";
                }
                if (filter.Length > 0 && (int)cbPost.SelectedValue != 0)
                {
                    filter += " AND ";
                }
                if ((int)cbPost.SelectedValue != 0)
                {
                    filter += "IdPost = '" + cbPost.SelectedValue + "'";
                }
                if (filter.Length > 0 && tbFIO.Text.Length != 0)
                {
                    filter += " AND ";
                }
                if (tbFIO.Text.Length != 0)
                {
                    filter += "FIO like '%" + tbFIO.Text + "%'";
                }
                dtPersons.DefaultView.RowFilter = filter;
            }
        }

        private void сохранитьОтчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtPersons != null && dtPersons.Rows.Count != 0)
            {
                //Excel.Application report = new Excel.Application();
            }
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            tbFIO.Location = new Point(dataGridView1.Location.X, tbFIO.Location.Y);
            tbFIO.Size = new Size(FIO.Width, tbFIO.Height);
        }

        private void tbFIO_TextChanged(object sender, EventArgs e)
        {
            Filtering();
        }
    }
}
