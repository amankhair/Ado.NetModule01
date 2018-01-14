using System.Data.SqlClient;
using System.Windows;

namespace AdoNetModule01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string connectionString = "";
        //string connStringOledb = "";


        public MainWindow()
        {
            InitializeComponent();

            //connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            connectionString = @"Data Source=DESKTOP-CJP4DOA;Initial Catalog=MCS;Integrated Security=True";
        }

        private void ConnectToServerButton_OnClick(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                ConnectMessage.Text += "Подключение открыто: " + conn.ConnectionString + "\n\n";
                ConnectMessage.Text += "Подключение БД: " + conn.Database + "\n\n";
                ConnectMessage.Text += "Серввер подключения: " + conn.DataSource + "\n\n";
                ConnectMessage.Text += "Версия сервера: " + conn.ServerVersion + "\n\n";
                ConnectMessage.Text += "Состояние сервера: " + conn.State + "\n\n";
                ConnectMessage.Text += "Время ожидания: " + conn.ConnectionTimeout + "\n\n";
            }
        }

        private void ConnectToServer_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
