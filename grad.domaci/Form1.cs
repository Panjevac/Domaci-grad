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

namespace grad.domaci
{
    public partial class Form1 : Form
    {
        string conectionstring = "Data source= DESKTOP-1LGKA15\\MSSQLSERVER08; initial catalog= bazagrada; Integrated security= true";
        public int red = 0;
        DataTable ucenik1 = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }
        private void Funkcija()
        {
            if (ucenik1.Rows.Count == 0)
            {
                txt_id.Text = "";
                //cbox_tip.Text = "";
                txt_naziv.Text = "";
                //txt_polica.Text = "";
                //txt_opis.Text = "";
                txt_brstanovnika.Text = "";
                txt_povrsina.Text = "";
                //txt_rok.Text = "";
                txt_drzava.Text = "";

                btn_sledeci.Enabled = false;
                btn_prethodni.Enabled = false;
                btn_kraj.Enabled = false;
                btn_pocetak.Enabled = false;
            }
            else
            {
                txt_id.Text = ucenik1.Rows[red]["id"].ToString();
                //cbox_tip.Text = ucenik1.Rows[red]["tip"].ToString();                      //prva rows[0] znaci 0 vrsta, a rows[0][1] nam je ovde isto sto i rows[0][ime] jer smo u adapteru naveli ime na drugom mestu
                txt_naziv.Text = ucenik1.Rows[red]["naziv"].ToString();
                //txt_opis.Text = ucenik1.Rows[red]["opis"].ToString();
                //txt_polica.Text = ucenik1.Rows[red]["polica"].ToString();
                txt_povrsina.Text = ucenik1.Rows[red]["povrsina"].ToString();
                txt_brstanovnika.Text = ucenik1.Rows[red]["brstanovnika"].ToString();
                txt_drzava.Text = ucenik1.Rows[red]["drzava"].ToString();
                //txt_rok.Text = ucenik1.Rows[red]["rok"].ToString();
                //cbox_neotvoreno.Text = ucenik1.Rows[red]["neotvoreno"].ToString();


                if (red == ucenik1.Rows.Count - 1)
                {
                    btn_sledeci.Enabled = false;
                    btn_kraj.Enabled = false;
                }
                else
                {
                    btn_sledeci.Enabled = true;
                    btn_kraj.Enabled = true;
                }

                if (red == 0)
                {
                    btn_prethodni.Enabled = false;
                    btn_pocetak.Enabled = false;                          // moze i btn_previous.enabled=(red!=0);
                }
                else
                {
                    btn_prethodni.Enabled = true;
                    btn_pocetak.Enabled = true;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            SqlConnection veza = new SqlConnection(conectionstring);

            SqlDataAdapter adapter = new SqlDataAdapter("select id, naziv,  brstanovnika, povrsina, drzava  from grad order by id", veza);
            adapter.Fill(ucenik1);

            //MessageBox.Show(ucenik.Rows.Count.ToString());

            Funkcija();


        }



        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            string privremeno = "insert into grad ( id,naziv, brstanovnika, povrsina, drzava) values ( '" + txt_id.Text + "','" + txt_naziv.Text + "','" + txt_brstanovnika.Text + "','" + txt_povrsina.Text + "','" + txt_drzava.Text + "')";
            //MessageBox.Show(privremeno);

            SqlConnection veza = new SqlConnection(conectionstring);
            SqlCommand naredba = new SqlCommand(privremeno, veza);

            veza.Open();
            naredba.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter adapter = new SqlDataAdapter("select id, naziv,  brstanovnika, povrsina, drzava  from grad order by id", veza);
            ucenik1.Clear();
            adapter.Fill(ucenik1);
            red = ucenik1.Rows.Count - 1;
            Funkcija();
        }

        private void btn_izmeni_Click(object sender, EventArgs e)
        {
            string pomocni = "update grad set id='" + txt_id.Text + "', naziv='" + txt_naziv.Text + "', brstanovnika='" + txt_brstanovnika.Text + "', povrsina='" + txt_povrsina.Text + "', drzava='" + txt_drzava.Text + "' where id=" + txt_id.Text;

            SqlConnection veza = new SqlConnection(conectionstring);
            SqlCommand naredba = new SqlCommand(pomocni, veza);

            veza.Open();
            naredba.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter adapter = new SqlDataAdapter("select id, naziv,  brstanovnika, povrsina, drzava  from grad order by id", veza);
            ucenik1.Clear();
            adapter.Fill(ucenik1);
            Funkcija();
        }

        private void btn_izbrisi_Click(object sender, EventArgs e)
        {
            string pomocni = "delete from grad where id=" + txt_id.Text;

            SqlConnection veza = new SqlConnection(conectionstring);
            SqlCommand naredba = new SqlCommand(pomocni, veza);

            veza.Open();
            naredba.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter adapter = new SqlDataAdapter("select id, naziv,  brstanovnika, povrsina, drzava  from grad order by id", veza);
            ucenik1.Clear();
            adapter.Fill(ucenik1);
            if (red > ucenik1.Rows.Count - 1)
            {
                red = ucenik1.Rows.Count - 1;
            }
            Funkcija();
        }

        private void btn_sledeci_Click(object sender, EventArgs e)
        {
            red++;
            Funkcija();
        }

        private void btn_prethodni_Click(object sender, EventArgs e)
        {
            red--;
            Funkcija();
        }

        private void btn_kraj_Click(object sender, EventArgs e)
        {
            red = ucenik1.Rows.Count - 1;
            Funkcija();
        }

        private void btn_pocetak_Click(object sender, EventArgs e)
        {
            red = 0;
            Funkcija();
        }
    }
}
