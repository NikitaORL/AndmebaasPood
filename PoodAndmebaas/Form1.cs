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
            NaitaKategooriad(); 
            NaitaAndmed();     
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

        int Id;
        private void Lisa_btn_Click(object sender, EventArgs e)
        {
            if (Toode_txt.Text.Trim() != string.Empty && Kogus_txt.Text.Trim() != string.Empty && Hind_txt.Text.Trim() != string.Empty && Kat_Box.SelectedItem != null)
            {
                try
                {
                    connection.Open();
                    command = new SqlCommand("SELECT Id FROM Kategooriatabel WHERE Kategooria_nimetus=@kat", connection);
                    command.Parameters.AddWithValue("@kat", Kat_Box.Text);
                    command.ExecuteNonQuery();
                    Id = Convert.ToInt32(command.ExecuteScalar());
                    command = new SqlCommand("INSERT INTO Toodetabel (Toodenimetus,Kogus,Hind,Pilt,Bpilt,Kategooriad)" +
                        "VALUES (@toode,@kogus,@hind,@pilt,@Bpilt,@kat)", connection);
                    command.Parameters.AddWithValue("@toode", Toode_txt.Text);
                    command.Parameters.AddWithValue("@kogus", Kogus_txt.Text);
                    command.Parameters.AddWithValue("@hind", Hind_txt.Text);
                    extension = Path.GetExtension(open.FileName); //.jpg-png
                    command.Parameters.AddWithValue("@pilt", Toode_txt.Text + extension);
                    imageData = File.ReadAllBytes(open.FileName);
                    command.Parameters.AddWithValue("@Bpilt", imageData);
                    command.Parameters.AddWithValue("@kat", Id);
                    command.ExecuteNonQuery();
                    connection.Close();
                    NaitaAndmed();
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmebaasiga viga!");
                }
            }
            else
            {
                MessageBox.Show("Viga!");
            }
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
        string extension = null;
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
        public void NaitaAndmed()
        {
            connection.Open();
            DataTable dt_toode = new DataTable();
            adapter_toode = new SqlDataAdapter(
                "SELECT Toodetabel.Id, Toodetabel.Toodenimetus, Toodetabel.Kogus, " +
                "Toodetabel.Hind, Toodetabel.Pilt, Toodetabel.Bpilt, " +
                "Kategooriatabel.Kategooria_nimetus AS Kategooria_nimetus " +
                "FROM Toodetabel INNER JOIN Kategooriatabel ON Toodetabel.Kategooriad = Kategooriatabel.Id",
                connection
            );
            adapter_toode.Fill(dt_toode);

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dt_toode;

            
            DataGridViewComboBoxColumn combo_kat = new DataGridViewComboBoxColumn();
            combo_kat.HeaderText = "Kategooria";
            combo_kat.DataPropertyName = "Kategooria_nimetus";

            HashSet<string> keys = new HashSet<string>();
            foreach (DataRow item in dt_toode.Rows)
            {
                string kat_n = item["Kategooria_nimetus"].ToString();
                if (!keys.Contains(kat_n)) 
                {
                    keys.Add(kat_n);
                    combo_kat.Items.Add(kat_n);
                }
            }

            dataGridView1.Columns.Add(combo_kat);

           
            Toode_pb.Image = Image.FromFile(Path.Combine(Path.GetFullPath(@"..\..\Images"), "sealiha.jpg"));

            connection.Close();
        }

        Form popupForm;

        byte[] imageData;
        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.ColumnIndex ==4)
            {
                imageData = dataGridView1.Rows[e.RowIndex].Cells["Bpilt"].Value as byte[];
                if (imageData != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(ms);
                        Loopilt(image, e.RowIndex);
                    }
                }
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (popupForm != null && !popupForm.IsDisposed)
            {
                popupForm.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Puhasta_Click(object sender, EventArgs e)
        {
            Toode_txt.Text = "";
            Kogus_txt.Text = "";
            Hind_txt.Text = "";

            using (FileStream fs = new FileStream(Path.Combine(Path.GetFullPath(@"..\..\Images"), "kana.jpg"), FileMode.Open, FileAccess.Read))
            {
                Toode_pb.Image = Image.FromStream(fs);
            }
        }

        private void Kustuta_Click(object sender, EventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
            MessageBox.Show(Id.ToString());
            if (Id != 0)
            {
                command = new SqlCommand("DELETE Toodetabel WHERE Id=@id", connection);
                connection.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.ExecuteNonQuery();
                connection.Close();

                NaitaAndmed();

                MessageBox.Show("Andmed tabelist Tooded on kustutatud");
            }
            else 
            {
                MessageBox.Show("Viga Tooded tabelist andmete kustutamisega");
            }
        }

        private void Uuenda_btn_Click(object sender, EventArgs e)
        {
            if (Toode_txt.Text != "" && Kogus_txt.Text != "" && Hind_txt.Text != "" && Toode_pb.Image != null)
            {
                command = new SqlCommand("UPDATE Toodetabel SET Toodenimetus=@toode, Kogus=@kogus," +
                  "Hind=@hind, Pilt=@pilt WHERE Id=@id", connection);
                connection.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.Parameters.AddWithValue("@toode", Toode_txt.Text);
                command.Parameters.AddWithValue("@kogus", Kogus_txt.Text);
                command.Parameters.AddWithValue("@hind", Hind_txt.Text.Replace(",", "."));
                string pilt = dataGridView1.SelectedRows[0].Cells["Pilt"].Value.ToString();
                string file_pilt = Toode_txt.Text + extension; //kontroll
                command.Parameters.AddWithValue("@pilt", file_pilt);
                command.ExecuteNonQuery();
                connection.Close();
                NaitaAndmed();
                MessageBox.Show("Andmed uuendatud!");
            }
            else
            {
                MessageBox.Show("Viga!");
            }
        }

        List<string> fail_list;
        PictureBox pictureBox;
        int kat_Id;
        TabControl kategooriad;
        private void Pood_Click(object sender, EventArgs e)
        {
            Size = new Size(1350, 600);
            kategooriad = new TabControl();
            kategooriad.Name = "Kategooriad";
            kategooriad.Width = 450;
            kategooriad.Height = Height;
            kategooriad.Location = new System.Drawing.Point(900, 0);
            connection.Open();
            adapter_kategooria = new SqlDataAdapter("SELECT id, Kategooria_nimetus FROM Kategooriatabel,", connection);
            DataTable dt_kat = new DataTable();
            adapter_kategooria.Fill(dt_kat);
            ImageList iconList = new ImageList();
            iconList.ColorDepth = ColorDepth.Depth32Bit;
            iconList.ImageSize = new Size(25, 25);
            int i = 0;
            foreach (DataRow nimetus in dt_kat.Rows)
            {
                kategooriad.TabPages.Add((string)nimetus["Kategooria_nimetus"]);
                kategooriad.TabPages[i].ImageIndex = i;
                i++;
                kat_Id = (int)nimetus["Id"];
                fail_list = Failid_KatId(kat_Id);
                int r = 0;
                int c = 0;
            }
            foreach (var fail in fail_list)
            {
                pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(@"..\..\Images" + fail);
                pictureBox.Width = pictureBox.Height = 100;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Location = new System.Drawing.Point(c, r);
                c = c + 100 + 2; //järgmise kasti position (liigume paremale)
                kategooriad.TabPages[i - 1].Controls.Add(pictureBox);
            }
            kategooriad.ImageList = iconList;
            connection.Close();
            this.Controls.Add(kategooriad);
        }

        //Document document;

        private void Loopilt(Image image, int r)
        {
            popupForm = new Form();
            popupForm.FormBorderStyle = FormBorderStyle.None;
            popupForm.StartPosition = FormStartPosition.Manual;
            popupForm.Size = new Size(200, 200);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = image;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            popupForm.Controls.Add(pictureBox);

            System.Drawing.Rectangle cellRectangle = dataGridView1.GetCellDisplayRectangle(4, r, true);
            System.Drawing.Point popupLocation = dataGridView1.PointToClient(cellRectangle.Location);

            popupForm.Location = new System.Drawing.Point(popupLocation.X + cellRectangle.Width, popupLocation.Y);
            popupForm.Show();
        }     
    }
}
