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

namespace Helper
{
    public partial class dodajApteka : Form
    {
        public dodajApteka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Przycisk Dodaj nową apteke do bazy
        {
            //Konfiguracja połączenia do bazy danych
            string connectionString = @"Data Source=(localDB)\v11.0;Initial Catalog=WWSI2015;Integrated Security=True";

            //zapytanie do bazy
            string query = @"INSERT INTO Table_Apteki (SAP, NazwaApteki, Miejscowosc, Adres, ID_RH, NumerApteki) VALUES (@SAP, @Nazwa, @Miejscowosc, @Adres, @RH, @NumerApteki)";

            //Utworzenie połączenia i komendy
            using (SqlConnection cn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {


                cmd.Parameters.Add("@SAP", SqlDbType.NChar).Value = SapTextBox.Text;
                cmd.Parameters.Add("@Nazwa", SqlDbType.NChar).Value = NazwaAptekiTextBox.Text;
                cmd.Parameters.Add("@Miejscowosc", SqlDbType.NChar).Value = MiejscowoscTextBox.Text;
                cmd.Parameters.Add("@Adres", SqlDbType.NChar).Value = AdresTextBox.Text;
                cmd.Parameters.Add("@RH", SqlDbType.NChar).Value = RhTextBox.Text;
                cmd.Parameters.Add("@NumerApteki", SqlDbType.NChar).Value = TelefonTextBox.Text;


                //Otwarcie połączenia, wykonanie INSERT, zamknięcie połączenia
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Apteka zostala dodana");


                // Czyszczenie formularza
                SapTextBox.Text = String.Empty;
                NazwaAptekiTextBox.Text = String.Empty;
                MiejscowoscTextBox.Text = String.Empty;
                AdresTextBox.Text = String.Empty;
                RhTextBox.Text = String.Empty;
                TelefonTextBox.Text = String.Empty;
                ProgramTextBox.Text = String.Empty;
            }



        }

        public class Foo
        {
            public string Name { get; set; }
            public DateTime Date { get; set; }
        }
    }
}
