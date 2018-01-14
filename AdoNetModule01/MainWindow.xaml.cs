using System.Data.OleDb;
using System.Windows;

namespace AdoNetModule01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string connectionString = "";

        string connStringOledb = "";


        public MainWindow()
        {
            InitializeComponent();

            //connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            //connectionString = @"Data Source=AMANKELDI-PC;Initial Catalog=MCS;Integrated Security=True";

            //connStringOledb = ConfigurationManager.ConnectionStrings["OleDbConnection"].ConnectionString;
            connStringOledb = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\accessDb_00.mdb";
        }

        private void ConnectToServerButton_OnClick(object sender, RoutedEventArgs e)
        {

            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    conn.Open();
            //    ConnectMessage.Text += "Подключение открыто: " + conn.ConnectionString + "\n\n";
            //    ConnectMessage.Text += "Подключение БД: " + conn.Database + "\n\n";
            //    ConnectMessage.Text += "Серввер подключения: " + conn.DataSource + "\n\n";
            //    ConnectMessage.Text += "Версия сервера: " + conn.ServerVersion + "\n\n";
            //    ConnectMessage.Text += "Состояние сервера: " + conn.State + "\n\n";
            //    ConnectMessage.Text += "Время ожидания: " + conn.ConnectionTimeout + "\n\n";
            //}
        }

        private void ConnectToServer_OnClick(object sender, RoutedEventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connStringOledb))
            {
                conn.Open();
                ConnMessage.Text += "Подключение открыто: " + conn.ConnectionString + "\n\n";
                ConnMessage.Text += "Подключение БД: " + conn.Database + "\n\n";
                ConnMessage.Text += "Серввер подключения: " + conn.DataSource + "\n\n";
                ConnMessage.Text += "Версия сервера: " + conn.ServerVersion + "\n\n";
                ConnMessage.Text += "Состояние сервера: " + conn.State + "\n\n";
                ConnMessage.Text += "Время ожидания: " + conn.ConnectionTimeout + "\n\n";
            }
        }
    }
}
