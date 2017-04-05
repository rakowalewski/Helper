using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;



namespace Helper
{
    public partial class WszystkieApteki : Form
    {
        private BackgroundWorker _bw;
        //private int _liczba = 0;
        private DelegatAktualizacji _update;

        public WszystkieApteki()
        {
            InitializeComponent();

            dgvApteki.AutoGenerateColumns = true;
            _bw = new BackgroundWorker();
            _bw.DoWork += _bw_DoWork;
            _bw.RunWorkerAsync();
            _update = RefreshUI;
        } 

        public delegate void DelegatAktualizacji(List<Apteka> data);

        void _bw_DoWork(object sender, DoWorkEventArgs e)
        {
            //Thread.Sleep(3000);
            string connectionString = @"Data Source=(localDB)\v11.0;Initial Catalog=WWSI2015;Integrated Security=True";

            var query = @"SELECT * FROM Table_Apteki";
        
            var result = new List<Apteka>();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var cmd = new SqlCommand(query, connection))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var apteka = new Apteka();
                        apteka.SAP = reader["SAP"].ToString();
                        apteka.NazwaApteki = reader["NazwaApteki"].ToString();
                        apteka.Miejscowosc = reader["Miejscowosc"].ToString();
                        apteka.Adres = reader["Adres"].ToString();
                        apteka.ID_RH = reader["ID_RH"].ToString();
                        
                        result.Add(apteka);
                    }
                }
            }


            _update(result);
        }

        private void RefreshUI(List<Apteka> data)
        {
            //dgvApteki.DataSource = data; w ten sposob wyjatek !!!

            //tu jeszcze watek wczytywania danych
            dgvApteki.Invoke((MethodInvoker)delegate
            {
                //tu watek UI mozemy odswiezyc dane
                dgvApteki.DataSource = data;
            });
        }
    }
}
