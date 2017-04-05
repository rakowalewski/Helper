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
using System.IO;
using System.Drawing.Drawing2D;
using System.Threading;


namespace Helper
{
    public partial class Form1 : Form
    {
        private float _rotate;
        private bool _isLoading = true;
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;

            this.panel1.Paint += Panel1_Paint; 
        }

        void Form1_Load(object sender, EventArgs e)
        {
            var bw = new BackgroundWorker();
            bw.DoWork += _bw_DoWork;
            bw.RunWorkerAsync();
        }

        public void ZalogujButton_Click(object sender, EventArgs e)
        {
              _isLoading = false;

            //(new Glowneokno()).Show();
            //return;

            var connectionString = @"Data Source=(localDB)\v11.0;Initial Catalog=WWSI2015;Integrated Security=True";  //Łączenie do bazy danych
            Glowneokno d = new Glowneokno();
            Form1 f = new Form1();

            this.Visible = false;
            (new Glowneokno()).Show();
            /*   using (var con = new SqlConnection(connectionString))    //Otwarte połączenie z baza
               {
                   con.Open();
                   string txtUser = UserTextBox.Text;
                   string txtPasswd = HasloTextBox.Text;

                   string query = "SELECT * FROM Users WHERE Login=@user AND Haslo=@paswd";
                   SqlCommand cmd = new SqlCommand(query, con);
                   cmd.Parameters.Add(new SqlParameter("@user", txtUser));
                   cmd.Parameters.Add(new SqlParameter("@paswd", txtPasswd));


                   SqlDataReader dr = cmd.ExecuteReader();
                   if (dr.HasRows == true)
                   {
                       _isLoading = false;
                       this.Visible = false;
                       (new Glowneokno()).Show();
                   }
                   else
                   {
                       MessageBox.Show("Invalid Login");
                   }

               }*/
        }

        private void _bw_DoWork(object sender, DoWorkEventArgs e)
        {
            while (_isLoading)
            {
                if (_rotate >= 360)
                    _rotate = 0;

                panel1.Invoke(new MethodInvoker(() => panel1.Refresh()));
                Thread.Sleep(10);
                _rotate++;
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            RotateRectangle(e.Graphics, new Rectangle(10, 10, 30, 30), _rotate);

            RotateRectangle(e.Graphics, new Rectangle(60, 60, 30, 30), _rotate);
        }
        
        private void RotateRectangle(Graphics g, Rectangle r, float angle)
        {
            using (var m = new Matrix())
            {
                m.RotateAt(angle, new PointF(r.Left + (r.Width / 2),
                                          r.Top + (r.Height / 2)));
                g.Transform = m;
                g.DrawRectangle(Pens.Black, r);
                g.ResetTransform();
            }
        }
    }
}










