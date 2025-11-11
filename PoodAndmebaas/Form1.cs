using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoodAndmebaas
{
    public partial class Form1 : Form
    {

        SqlConnection connection = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=|DataDirectory|\Tooded_DB.mdf;
            Integrated Security=True");


        SqlCommand command;
        SqlDataAdapter adapter_toode, adapter_kategooria;

        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void Hind_Click(object sender, EventArgs e)
        {
        }

        private void Lisa_Kat_btn_Click(object sender, EventArgs e)
        {
            bool on = false;
            foreach (var item in Kat_Box.Items)
            {
                if (item.ToString().Equals(Kat_Box.Text, StringComparison.OrdinalIgnoreCase))
                {
                    on = true;
                    break;
                }
            }

            if (on == false)
            {
                command = new SqlCommand("INSERT INTO Kategooriatabel (Kategooria_nimetus) VALUES (@kat)", connection);
                connection.Open();
                command.Parameters.AddWithValue("@kat", Kat_Box.Text.Trim());
                command.ExecuteNonQuery();
                connection.Close();
                Kat_Box.Items.Clear();
                NaitaKategooriad();
            }
            else
            {
                MessageBox.Show("Selline kategooria on juba olemas!");
            }
        }


        private void Kat_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lisa_btn_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void NaitaKategooriad()
        {
            connection.Open();
            adapter_kategooria = new SqlDataAdapter("SELECT Id,Kategooria_nimetus FROM kategooriatabel", connection);
            DataTable dt_kat = new DataTable();
            adapter_kategooria.Fill(dt_kat);
            foreach (DataRow item in dt_kat.Rows)
            {
                if (!Kat_Box.Items.Contains(item["Kategooria_nimetus"]))
                {
                    Kat_Box.Items.Add(item["Kategooria_nimetus"]);
                }
                else
                {
                    command = new SqlCommand("DELETE FROM Kategooriatabel WHERE id=@id", connection);
                    command.Parameters.AddWithValue("@id", item["id"]);
                }
            }
            connection.Close();
        }



        public void Kustuta_btn_Click()
        {
            if (Kat_Box.SelectedItem != null)
            {
                connection.Open();
                string kal_val = Kat_Box.SelectedItem.ToString();
                command = new SqlCommand("DELETE FROM Kategooriatabel WHERE Kategooria_nimetus=@kat", connection);
                command.Parameters.AddWithValue("@kat", kal_val);
                command.ExecuteNonQuery();
                connection.Close();
                Kat_Box.Items.Clear();
                NaitaKategooriad();
            }
        }

        SaveFileDialog save;
        OpenFileDialog open;
        string extension=null;
        public void otsi_fail_btn_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.InitialDirectory = @"C:\Users\opilane\Source\Repos\AndmebaasPood\PoodAndmebaas\Images";
            open.Multiselect = true;
            open.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|All files (*.*)|*.*";

            FileInfo open_info = new FileInfo(@"C:\Users\opilane\Source\Repos\AndmebaasPood\PoodAndmebaas\Images" + open.FileName);
            if (open.ShowDialog() == DialogResult.OK && Toode_txt.Text != null)
            {
                save = new SaveFileDialog();
                save.InitialDirectory = Path.GetFullPath(@"..\..Images");
                extension = Path.GetExtension(open.FileName);
                save.FileName = Toode_txt.Text + Path.GetExtension(open.FileName);
                save.Filter = "Images" + Path.GetExtension(open.FileName) + "|*" + Path.GetExtension(open.FileName);
                if (save.ShowDialog() == DialogResult.OK && Toode_txt.Text != null)
                {
                    File.Copy(open.FileName, save.FileName);
                    Toode_pb.Image = Image.FromFile(save.FileName);
                }
            }
        }
    }
}
