using System.Data.SqlClient;
using System.Windows;

namespace Work
{
    /// <summary>
    /// Логика взаимодействия для Student.xaml
    /// </summary>
    public partial class Student : Window
    {
        public Student()
        {
            InitializeComponent();
        }
        string s = @"Data Source = DESKTOP-P6DOUN2\MSSQLSERVER02;Integrated Security = true;Initial Catalog=Work";
        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(s);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Расписание", connection);
            System.Data.DataTable dataTable = new System.Data.DataTable("Расписание");
            adapter.Fill(dataTable);
            datagrid.ItemsSource = dataTable.DefaultView;
            connection.Close();
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(s);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Деканат", connection);
            System.Data.DataTable dataTable = new System.Data.DataTable("Деканат");
            adapter.Fill(dataTable);
            datagrid.ItemsSource = dataTable.DefaultView;
            connection.Close();
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(s);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Здания", connection);
            System.Data.DataTable dataTable = new System.Data.DataTable("Здания");
            adapter.Fill(dataTable);

            datagrid.ItemsSource = dataTable.DefaultView;
            connection.Close();
        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(s);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Отделения", connection);
            System.Data.DataTable dataTable = new System.Data.DataTable("Отделения");
            adapter.Fill(dataTable);

            datagrid.ItemsSource = dataTable.DefaultView;
            connection.Close();
        }

        private void ComboBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(s);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Специальности", connection);
            System.Data.DataTable dataTable = new System.Data.DataTable("Специальности");
            adapter.Fill(dataTable);

            datagrid.ItemsSource = dataTable.DefaultView;
            connection.Close();
        }

        private void datagrid_LoadingRow(object sender, System.Windows.Controls.DataGridRowEventArgs e)
        {
            datagrid.Columns[0].Visibility = Visibility.Hidden;
            if (combo.Text == "Расписание")
                datagrid.Columns[0].Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
