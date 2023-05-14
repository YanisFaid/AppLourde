using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppLourde
{
    public partial class Form2 : Form
    {
        private MySqlConnection conn;
        private string server = "10.5.5.20";
        private string database = "projet_cantine";
        private string uid = "yanis";
        private string password = "yanis";
        private string classe;

        public Form2()
        {
            InitializeComponent();
            
        }

        /*private void label2_Click(object sender, EventArgs e)
        {

        }

        public void connexionBTN_Click(object sender, EventArgs e)
        {
            
            {
                
                }
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand($"SELECT * FROM admin WHERE identifiant='{idTXT}' AND password='{passwordTXT}'", conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count == 1)
                    {
                        Form2 form2 = new Form2(conn);
                        form2.Show();
                        this.Hide();
                        MessageBox.Show("Vous êtes connecté.");
                    }
                    else
                    {
                        MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur de connexion à la base de données : {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }
            public Form2(MySqlConnection conn)
        {
            InitializeComponent();
        }*/

        private void afficheBTN_Click(object sender, EventArgs e)
        {
            classe = "6eme";
            conn = new MySqlConnection($"Server='{server}';Port=3306;Database='{database}';Uid='{uid}';Pwd='{password}';");
            try
            {
                //conn = new MySqlConnection($"Server='{server}';Database='{database}';Uid='{uid}';Pwd='{password}';");
                conn.Open();
                String query = "SELECT * FROM 6eme";
                MySqlCommand cmd = new MySqlCommand(query, conn);
               
                /*MySqlDataAdapter da= new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;*/

                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de connexion à la base de données : {ex.Message}");
            }
            finally
            {
                conn.Close();
            }

        }

        private void cinqBTN_Click(object sender, EventArgs e)
        {
            classe = "5eme";
            try
            {
                conn.Open();
                String query = "Select * from 5eme";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de connexion à la base de données : {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void quatreBTN_Click(object sender, EventArgs e)
        {
            classe = "4eme";
            try
            {
                conn.Open();
                String query = "Select * from 4eme";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de connexion à la base de données : {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void troisBTN_Click(object sender, EventArgs e)
        {
            classe = "3eme";
            try
            {
                conn.Open();
                String query = "Select * from 3eme";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de connexion à la base de données : {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }


        private void modifBTN_Click(object sender, EventArgs e)
        {
            string mdp = passwordTXT + "#/ùzz";

            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(mdp));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("x2"));
                }
                mdp = sb.ToString();
                try
                {
                    conn.Open();
                    string query = "UPDATE " + listBOX.Text + " SET nom='" + nomTXT.Text + "', identifiant='" + idTXT.Text + "', sexe='" + sexeTXT.Text + "', password='" + mdp + "', mail='" + mailTXT.Text + "', description='" + descripTXT.Text + "' WHERE id=" + dataGridView1.SelectedCells[0].Value.ToString();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int i = cmd.ExecuteNonQuery();
                    if (i >= -1)
                    {
                        MessageBox.Show("Donnée modifiée avec succes!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur de connexion à la base de données : {ex.Message}");
                }
                finally
                {

                    conn.Close();
                    if (classe == "6eme")
                    {
                        this.afficheBTN_Click(sender, e);
                    }
                    else if (classe == "5eme")
                    {
                        this.cinqBTN_Click(sender, e);
                    }
                    else if (classe == "4eme")
                    {
                        this.quatreBTN_Click(sender, e);
                    }
                    else if (classe == "3eme")
                    {
                        this.troisBTN_Click(sender, e);
                    }
                }
            }
        }

        private void inserBTN_Click(object sender, EventArgs e)
        {
            string mdp = passwordTXT + "#/ùzz";

            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(mdp));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("x2"));
                }
                mdp = sb.ToString();
            }
            try
            {
                conn.Open();
                string query = "insert into "+listBOX.Text+"(nom, identifiant, sexe, password, description, mail) values('" + nomTXT.Text + "','" + idTXT.Text + "','" + sexeTXT.Text + "','" + mdp + "','" + descripTXT.Text + "','" + mailTXT.Text + "')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int i = cmd.ExecuteNonQuery();
                if (i >= -1)
                {
                    MessageBox.Show("Données insérées avec succes!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de connexion à la base de données : {ex.Message}");
            }
            finally
            {
                conn.Close();
                if (classe == "6eme")
                {
                    this.afficheBTN_Click(sender, e);
                }
                else if (classe == "5eme")
                {
                    this.cinqBTN_Click(sender, e);
                }
                else if (classe == "4eme")
                {
                    this.quatreBTN_Click(sender, e);
                }
                else if (classe == "3eme")
                {
                    this.troisBTN_Click(sender, e);
                }
            }

        }

        private void suppBTN_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM "+classe+" WHERE id=" + dataGridView1.SelectedCells[0].Value.ToString();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int i = cmd.ExecuteNonQuery();
                if (i >= -1)
                {
                    MessageBox.Show("Données supprimées avec succes!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de connexion à la base de données : {ex.Message}");
            }
            finally
            {

                conn.Close();
                if (classe == "6eme")
                {
                    this.afficheBTN_Click(sender, e);
                }
                else if (classe == "5eme")
                {
                    this.cinqBTN_Click(sender, e);
                }
                else if (classe == "4eme")
                {
                    this.quatreBTN_Click(sender, e);
                }
                else if (classe == "3eme")
                {
                    this.troisBTN_Click(sender, e);
                }
            }
        }

        /*private void afficherBTN_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String query = "Select * from "+listBOX.Text+"";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de connexion à la base de données : {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }*/

    }
}
