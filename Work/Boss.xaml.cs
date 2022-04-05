using System;
using System.Windows;
using System.Windows.Controls;
using Work.MyDataSet1TableAdapters;
using System.Data.SqlClient;
using System.Data;

namespace Work
{
    /// <summary>
    /// Логика взаимодействия для Boss.xaml
    /// </summary>
    public partial class Boss : Window
    {
        string s = @"Data Source = DESKTOP-P6DOUN2\MSSQLSERVER02;Integrated Security = true;Initial Catalog=Work";
        MyDataSet1 tableDataSet;
        ЗданияTableAdapter ЗданияTableAdapter;
        ДеканатTableAdapter ДеканатTableAdapter;
        СотрудникиTableAdapter СотрудникиTableAdapter;
        public Boss()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            if (combo.Text == "Деканат")
            {
                ДеканатTableAdapter = new ДеканатTableAdapter();
                ДеканатTableAdapter.InsertQuery(text1.Text, text2.Text, text3.Text, combo1.Text, text4.Text, text5.Text);
                ДеканатTableAdapter.Fill(tableDataSet.Деканат);
                obnovaDekan();
            }
            if (combo.Text == "Сотрудники")
            {
                СотрудникиTableAdapter = new СотрудникиTableAdapter();
               СотрудникиTableAdapter.InsertСотрудники(text1.Text, text2.Text, text3.Text,combo1.Text, Convert.ToInt32(text4.Text), text5.Text);
                СотрудникиTableAdapter.Fill(tableDataSet.Сотрудники);
                obnovaZdanie();
            }
        }
        public void obnovaZdanie()
        {
            SqlConnection connection = new SqlConnection(s);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Сотрудники", connection);
            System.Data.DataTable dataTable = new System.Data.DataTable("Сотрудники");
            adapter.Fill(dataTable);
            datagrid.ItemsSource = dataTable.DefaultView;
            connection.Close();
        }
        public void obnovaDekan()
        {
            SqlConnection connection = new SqlConnection(s);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Деканат", connection);
            System.Data.DataTable dataTable = new System.Data.DataTable("Деканат");
            adapter.Fill(dataTable);
            datagrid.ItemsSource = dataTable.DefaultView;
            connection.Close();
        }
        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            obnovaDekan();
            ЗданияTableAdapter = new ЗданияTableAdapter();
            tableDataSet = new MyDataSet1();
            new ЗданияTableAdapter().Fill(tableDataSet.Здания);
            combo1.ItemsSource = tableDataSet.Здания;
            combo1.DisplayMemberPath = "Адрес";
            combo1.SelectedValuePath = "Адрес";
        }
        private void ComboBoxItem_Selected_7(object sender, RoutedEventArgs e)
        {
            obnovaZdanie();
            tableDataSet = new MyDataSet1();
            new ЗданияTableAdapter().Fill(tableDataSet.Здания);
            combo1.ItemsSource = tableDataSet.Здания;
            combo1.DisplayMemberPath = "Адрес";
            combo1.SelectedValuePath = "Адрес";
        }        
      
        private void datagrid_LoadingRow_1(object sender, DataGridRowEventArgs e)
        {
            datagrid.Columns[0].Visibility = Visibility.Hidden;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
                if (combo.Text == "Деканат")
                {
                  DataRowView selectedDataRow = (DataRowView)datagrid.SelectedItem;
                    ДеканатTableAdapter = new ДеканатTableAdapter();
                    ДеканатTableAdapter.DeleteДеканат(Convert.ToInt32(selectedDataRow.Row.ItemArray[0]));
                    ДеканатTableAdapter.Fill(tableDataSet.Деканат);
                obnovaDekan();
            }
            if (combo.Text == "Сотрудники")
            {
                DataRowView selectedDataRow = (DataRowView)datagrid.SelectedItem;
                СотрудникиTableAdapter = new СотрудникиTableAdapter();
                СотрудникиTableAdapter.DeleteSotrudniki(Convert.ToInt32(selectedDataRow.Row.ItemArray[0]));
                СотрудникиTableAdapter.Fill(tableDataSet.Сотрудники);
                obnovaZdanie();
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            tableDataSet = new MyDataSet1();
            if (combo.Text == "Деканат")
            {
                DataRowView selectedDataRow = (DataRowView)datagrid.SelectedItem;
                ДеканатTableAdapter = new ДеканатTableAdapter();
                ДеканатTableAdapter.UpdateДеканат(text1.Text, text2.Text, text3.Text, combo1.Text, text4.Text,text5.Text, (Convert.ToInt32(selectedDataRow.Row.ItemArray[0])));
                ДеканатTableAdapter.Fill(tableDataSet.Деканат);
                obnovaDekan();
            }
            if (combo.Text == "Сотрудники")
            {
                DataRowView selectedDataRow = (DataRowView)datagrid.SelectedItem;
                СотрудникиTableAdapter.UpdateSotrud(text1.Text, text2.Text, text3.Text, combo1.Text,Convert.ToInt32(text4.Text), text5.Text, (Convert.ToInt32(selectedDataRow.Row.ItemArray[0])));
                СотрудникиTableAdapter.Fill(tableDataSet.Сотрудники);
                obnovaZdanie();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void datagrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (combo.Text == "Деканат")
            {
                DataRowView selectedDataRow = (DataRowView)datagrid.SelectedItem;
                if (selectedDataRow != null)
                {
                    text1.Text = selectedDataRow.Row.ItemArray[1].ToString();
                    text2.Text = selectedDataRow.Row.ItemArray[2].ToString();
                    text3.Text = selectedDataRow.Row.ItemArray[3].ToString();
                    combo1.Text = selectedDataRow.Row.ItemArray[4].ToString();
                    text4.Text = selectedDataRow.Row.ItemArray[5].ToString();
                    text5.Text = selectedDataRow.Row.ItemArray[6].ToString();
                }
            }
            if (combo.Text == "Сотрудники")
            {
                DataRowView selectedDataRow = (DataRowView)datagrid.SelectedItem;
                if (selectedDataRow != null)
                {
                    text1.Text = selectedDataRow.Row.ItemArray[1].ToString();
                    text2.Text = selectedDataRow.Row.ItemArray[2].ToString();
                    text3.Text = selectedDataRow.Row.ItemArray[3].ToString();
                    combo1.Text = selectedDataRow.Row.ItemArray[4].ToString();
                    text4.Text = selectedDataRow.Row.ItemArray[5].ToString();
                    text5.Text = selectedDataRow.Row.ItemArray[6].ToString();
                }
            }
        }

        private void text1_TextChanged(object sender, TextChangedEventArgs e)
        {
            foreach (char c in text1.Text)
                if ((c > 'a' && c < 'z') || (c > 'A' && c < 'Z'))
                {
                    text1.Text = "";
                }
            foreach (char c in text1.Text)
                if (c > '0' && c < '9')
                {
                    text1.Text = "";
                }
        }

        private void text2_TextChanged(object sender, TextChangedEventArgs e)
        {
            foreach (char c in text2.Text)
                if ((c > 'a' && c < 'z') || (c > 'A' && c < 'Z'))
                {
                    text2.Text = "";
                }
            foreach (char c in text2.Text)
                if (c > '0' && c < '9')
                {
                    text2.Text = "";
                }
        }

        private void text3_TextChanged(object sender, TextChangedEventArgs e)
        {
            foreach (char c in text3.Text)
                if ((c > 'a' && c < 'z') || (c > 'A' && c < 'Z'))
                {
                    text3.Text = "";
                }
            foreach (char c in text3.Text)
                if (c > '0' && c < '9')
                {
                    text3.Text = "";
                }
        }

        private void text4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (combo.Text == "Сотрудники")
            {
                foreach (char c in text3.Text)
                    if (c > '0' && c < '9')
                    {
                        text3.Text = "";
                    }
            }
            
        }

        private void text5_TextChanged(object sender, TextChangedEventArgs e)
        {
            foreach (char c in text3.Text)
                if (c > '0' && c < '9')
                {
                    text3.Text = "";
                }
        }
    }
}
