using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace AppLourde
{
    public partial class Form1 : Form
    {
        private MySqlConnection conn;
        private string server = "10.5.5.20";
        private string database = "projet_cantine";
        private string uid = "yanis"; //"callmanager1";
        private string password = "yanis"; //"Cm1_007";
        public Form1()
        {
            InitializeComponent();
            mdpTXT.PasswordChar = '*';
            
    }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        public void connexionBTN_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection($"Server={server};Port=3306;Database={database};Uid={uid};Pwd={password};");
            {
                mdpTXT.PasswordChar = '*';
                string mdp = mdpTXT + "#/ùzz";
                
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
                //MessageBox.Show(mdp);
                
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand($"SELECT * FROM admin WHERE identifiant='"+identifiantTXT.Text+"' AND password='"+mdp+"'", conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count == 1)
                    {
                        Form2 form2 = new Form2();
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
        }

        private void identifiantTXT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
