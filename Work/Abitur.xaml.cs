using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;

namespace Work
{
    /// <summary>
    /// Логика взаимодействия для Abitur.xaml
    /// </summary>
    public partial class Abitur : Window
    {
       
        string s = @"Data Source = DESKTOP-P6DOUN2\MSSQLSERVER02;Integrated Security = true;Initial Catalog=Work";


        public Abitur()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection(s);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Абитуриенты", connection);
            System.Data.DataTable dataTable = new System.Data.DataTable("Абитуриенты");
            adapter.Fill(dataTable);
            datagrid.ItemsSource = dataTable.DefaultView;
            connection.Close();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(s);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Деканат", connection);
            System.Data.DataTable dataTable = new System.Data.DataTable("Деканат");
            adapter.Fill(dataTable);
            datagrid.ItemsSource = dataTable.DefaultView;
            connection.Close();
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(s);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Здания", connection);
            System.Data.DataTable dataTable = new System.Data.DataTable("Здания");
            adapter.Fill(dataTable);

            datagrid.ItemsSource = dataTable.DefaultView;
            connection.Close();
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(s);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Отделения", connection);
            System.Data.DataTable dataTable = new System.Data.DataTable("Отделения");
            adapter.Fill(dataTable);

            datagrid.ItemsSource = dataTable.DefaultView;
            connection.Close();
        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(s);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Специальности", connection);
            System.Data.DataTable dataTable = new System.Data.DataTable("Специальности");
            adapter.Fill(dataTable);

            datagrid.ItemsSource = dataTable.DefaultView;
            connection.Close();
        }

        private void ComboBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(s);
            connection.Open(); 
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Абитуриенты", connection);
            System.Data.DataTable dataTable = new System.Data.DataTable("Абитуриенты");
            adapter.Fill(dataTable);

            datagrid.ItemsSource = dataTable.DefaultView;
            connection.Close();
        }


        private void datagrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            datagrid.Columns[0].Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
