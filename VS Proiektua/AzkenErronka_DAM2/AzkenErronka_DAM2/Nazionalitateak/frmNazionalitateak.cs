using AzkenErronka_DAM2.Artistak;
using AzkenErronka_DAM2.Klaseak;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzkenErronka_DAM2.Nazionalitateak
{
    public partial class frmNazionalitateak : Form
    {

        #region "DECLARACIONES"
        SqlConnection con;
        Nazionalitatea clsNazionalitatea = new Nazionalitatea();

        public String nazionalitate_kodea = "";
        public String nazionalitate_izena = "";

        frmNazionalitateak owner_form = null;
        SqlDataReader reader;
        #endregion

        public frmNazionalitateak()
        {
            InitializeComponent();
            this.owner_form = owner_form;
        }

        private void frmNazionalitateak_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LENOVO_ADRI\\SQLEXPRESS;Initial Catalog=MusikaBilduma;Integrated Security=True");
            con.Open();

            String parametro = " where IdNazioa != '-?' ";


            SqlDataReader reader = clsNazionalitatea.getNazionalitateak(con, parametro);

            DataTable dt_nazioak = new DataTable();
            dt_nazioak.Load(reader);

            dgNazionalitateak.DataSource = dt_nazioak;


            //datagridview-aren zutabeak eta itxura aldatu
            itxura_aldatu();




            DataGridViewRow initial_row = dgNazionalitateak.Rows[1];
            string id_nazioa = Convert.ToString(initial_row.Cells["IdNazioa"].Value);
            string izena_nazioa = Convert.ToString(initial_row.Cells["NazioaIzena"].Value);

            dgNazionalitateak.Refresh();
            dgNazionalitateak.Rows[0].Selected = true;
            //con.Close();
        }


        private void itxura_aldatu()
        {
            //IdNaziua
            this.dgNazionalitateak.Columns["IdNazioa"].Visible = true;
            this.dgNazionalitateak.Columns["IdNazioa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgNazionalitateak.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgNazionalitateak.Columns[0].HeaderText = "Kodea";
            this.dgNazionalitateak.Columns[0].Width = 100;

            //NazioaIzena
            this.dgNazionalitateak.Columns["NazioaIzena"].Visible = true;
            this.dgNazionalitateak.Columns["NazioaIzena"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgNazionalitateak.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgNazionalitateak.Columns[1].HeaderText = "Deskribapena";
            this.dgNazionalitateak.Columns[1].Width = 375;

            
        }

        private void dgNazionalitateak_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dgNazionalitateak.Rows[index].Selected = true;

            DataGridViewRow selectedRow = dgNazionalitateak.Rows[index];
            string nazioa_kod_str = Convert.ToString(selectedRow.Cells["IdNazioa"].Value);
            string nazioa_izena_str = Convert.ToString(selectedRow.Cells["NazioaIzena"].Value);


        }

        private void dgNazionalitateak_DoubleClick(object sender, EventArgs e)
        {
            int index = this.dgNazionalitateak.CurrentRow.Index;
            DataGridViewRow selectedRow = dgNazionalitateak.Rows[index];

            string nazioa_kod_str = Convert.ToString(selectedRow.Cells["IdNazioa"].Value);
            string nazioa_izena_str = Convert.ToString(selectedRow.Cells["NazioaIzena"].Value);

            nazionalitate_kodea = nazioa_kod_str;
            nazionalitate_izena = nazioa_izena_str;

            this.Close();
        }

        private void txtBilatu_TextChanged(object sender, EventArgs e)
        {
            String parametro = " where IdNazioa != '-?' " + " and NazioaIzena LIKE '%" + this.txtBilatu.Text.Trim() + "%'";


            reader = clsNazionalitatea.getNazionalitateak(con, parametro);

            DataTable dt_nazioak = new DataTable();
            dt_nazioak.Load(reader);

            dgNazionalitateak.DataSource = dt_nazioak;
            dgNazionalitateak.Refresh();
            //con.Close();
        }
    }
}
