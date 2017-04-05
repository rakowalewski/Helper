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
    public partial class Search_one : Form
    {
        public Search_one()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
           var connectionString = @"Data Source=(localDB)\v11.0;Initial Catalog=WWSI2015;Integrated Security=True";
           using (var con=new SqlConnection(connectionString))
           {
               con.Open();
               string dupa = SAPTextBox.Text;
               string query = "Select * From Table_Apteki Where SAP=@txtSAP";
               var result = new List<Apteka>();
               using (SqlCommand cmd = new SqlCommand(query, con))
               {
                   cmd.Parameters.AddWithValue("@txtSAP", dupa);
                   var reader = cmd.ExecuteReader();
                   while (reader.Read())
                   {
                       var apteka = new Apteka();
                       apteka.SAP = reader["SAP"].ToString();
                       apteka.NazwaApteki = reader["NazwaApteki"].ToString();
                       apteka.Miejscowosc = reader["Miejscowosc"].ToString();
                       apteka.Adres = reader["Adres"].ToString();
                       apteka.ID_RH = reader["ID_RH"].ToString();
                      
                       //apteka.Numer = Convert.ToInt32(reader[""]);
                       result.Add(apteka);// przypisuje całą zawartość kontenera do result
                   }
               }

               dataGridView1.DataSource = result;
   
           }
        }
    }

    public class Apteka  // kontener na zawartość pojedynczego wiersza
    {
        public string SAP { get; set; }
        public string NazwaApteki { get; set; }
        public string Miejscowosc { get; set; }
        public string Adres { get; set; }
        public string ID_RH { get; set; }
  
    }
}
