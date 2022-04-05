using System;
using System.Windows;
using System.Data.SqlClient;

namespace Work
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string conString = @"Data Source = DESKTOP-P6DOUN2\MSSQLSERVER02;Integrated Security = true;Initial Catalog=Work";
            SqlConnection connection = new SqlConnection(conString);
            try
            {
                connection.Open();
                String query = "SELECT IDAutoriz FROM Авторизация WHERE Логин = @Логин AND Пароль = @Пароль";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@Логин", combo.Text);
                sqlCommand.Parameters.AddWithValue("@Пароль", pass.Password);
                int ID = Convert.ToInt32(sqlCommand.ExecuteScalar());
                if (ID == 1)
                {
                    Boss abitur = new Boss();
                    abitur.Show();
                    this.Close();
                }
                else if (ID == 2)
                {
                    Study study = new Study();
                    study.Show();
                    this.Close();
                }
                else if (ID == 3)
                {
                    Abitur abitur = new Abitur();
                    abitur.Show();
                    this.Close();
                }
                else if (ID==4)
                {
                    Student student = new Student();
                    student.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Логин или пароль неправилен");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();

            }
        }

        
    }
}
