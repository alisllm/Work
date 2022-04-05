 using System;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Data;
using Work.MyDataSet1TableAdapters;

namespace Work
{
    /// <summary>
    /// Логика взаимодействия для Study.xaml
    /// </summary>
    public partial class Study : Window
    {
        string s = @"Data Source = DESKTOP-P6DOUN2\MSSQLSERVER02;Integrated Security = true;Initial Catalog=Work";
        MyDataSet1 tableDataSet;

        АбитуриентыTableAdapter АбитуриентыTableAdapter;
        ЗданияTableAdapter ЗданияTableAdapter;
        ДеканатTableAdapter ДеканатTableAdapter;
        ОбщежитиеTableAdapter ОбщежитиеTableAdapter;
        РасписаниеTableAdapter РасписаниеTableAdapter;
        ГруппыTableAdapter ГруппыTableAdapter;
        ОтделенияTableAdapter ОтделенияTableAdapter;
        СтудентыTableAdapter СтудентыTableAdapter;
        СпециальностиTableAdapter СпециальностиTableAdapter;
        public Study()
        {
            InitializeComponent();
        }
        
        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            Obnova();
            obnovaOtdel();
            text2.Visibility = Visibility.Hidden;
            text3.Visibility = Visibility.Hidden;
            text4.Visibility = Visibility.Hidden;
            text5.Visibility = Visibility.Hidden;
            combo1.Margin = new Thickness(626, 174, 0, 0);
            combo2.Margin = new Thickness(626, 203, 0, 0);

            СпециальностиTableAdapter = new СпециальностиTableAdapter();
            tableDataSet = new MyDataSet1();
            new СпециальностиTableAdapter().Fill(tableDataSet.Специальности);
            combo1.ItemsSource = tableDataSet.Специальности;
            combo1.DisplayMemberPath = "Наименование";
            combo1.SelectedValuePath = "Наименование";

            ГруппыTableAdapter = new ГруппыTableAdapter();
            new ГруппыTableAdapter().Fill(tableDataSet.Группы);
            combo2.ItemsSource = tableDataSet.Группы;
            combo2.DisplayMemberPath = "Группа";
            combo2.SelectedValuePath = "Группа";
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            Obnova();
            obnovaSpec();
            text2.Visibility = Visibility.Hidden;
            text3.Visibility = Visibility.Hidden;
            text4.Visibility = Visibility.Hidden;
            text5.Visibility = Visibility.Hidden;
            combo1.Visibility = Visibility.Hidden;
            combo2.Visibility = Visibility.Hidden;
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            Obnova();
            obnovaAbitur();
            СпециальностиTableAdapter = new СпециальностиTableAdapter();
            tableDataSet = new MyDataSet1();
            new СпециальностиTableAdapter().Fill(tableDataSet.Специальности);
            combo1.ItemsSource = tableDataSet.Специальности;
            combo1.DisplayMemberPath = "Наименование";
            combo1.SelectedValuePath = "Наименование";
            combo2.Visibility = Visibility.Hidden; text5.Visibility = Visibility.Hidden;
            text4.Margin = new Thickness(626, 257, 47.333, 0);

        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            Obnova();
            obnovaStud();
            tableDataSet = new MyDataSet1();
            ГруппыTableAdapter = new ГруппыTableAdapter();
            new ГруппыTableAdapter().Fill(tableDataSet.Группы);
            combo1.ItemsSource = tableDataSet.Группы;
            combo1.DisplayMemberPath = "Группа";
            combo1.SelectedValuePath = "Группа";

            ОтделенияTableAdapter = new ОтделенияTableAdapter();
            tableDataSet = new MyDataSet1();
            new ОтделенияTableAdapter().Fill(tableDataSet.Отделения);
            combo2.ItemsSource = tableDataSet.Отделения;
            combo2.DisplayMemberPath = "Отделение";
            combo2.SelectedValuePath = "Отделение";
            text4.Visibility = Visibility.Hidden;
            combo3.Visibility = Visibility.Visible;
            combo2.Margin = new Thickness(626, 257, 0, 0);

            tableDataSet = new MyDataSet1();
            СпециальностиTableAdapter = new СпециальностиTableAdapter();
            new СпециальностиTableAdapter().Fill(tableDataSet.Специальности);
            combo3.ItemsSource = tableDataSet.Специальности;
            combo3.DisplayMemberPath = "Наименование";
            combo3.SelectedValuePath = "Наименование";

            text4.Visibility = Visibility.Hidden; combo3.Visibility = Visibility.Visible;

            
        }

        private void ComboBoxItem_Selected_4(object sender, RoutedEventArgs e) 
        {
            Obnova();
            obnovaRasp();        
            tableDataSet = new MyDataSet1();
            ГруппыTableAdapter = new ГруппыTableAdapter();
            new ГруппыTableAdapter().Fill(tableDataSet.Группы);
            combo1.ItemsSource = tableDataSet.Группы;
            combo1.DisplayMemberPath = "Группа";
            combo1.SelectedValuePath = "Группа";

            ЗданияTableAdapter = new ЗданияTableAdapter();
            tableDataSet = new MyDataSet1();
            new ЗданияTableAdapter().Fill(tableDataSet.Здания);
            combo2.ItemsSource = tableDataSet.Здания;
            combo2.DisplayMemberPath = "Адрес";
            combo2.SelectedValuePath = "Адрес";
            data.Visibility = Visibility.Visible;
            text1.Visibility = Visibility.Hidden; text2.Visibility = Visibility.Hidden; text5.Visibility = Visibility.Hidden;

        }
        private void ComboBoxItem_Selected_5(object sender, RoutedEventArgs e)
        {
            Obnova();
            obnovaGroup();
            combo2.Visibility = Visibility.Hidden; combo1.Visibility = Visibility.Hidden;
            text3.Visibility = Visibility.Hidden; text4.Visibility = Visibility.Hidden; text5.Visibility = Visibility.Hidden;
        }
        private void ComboBoxItem_Selected_6(object sender, RoutedEventArgs e)
        {
            Obnova();
            obnovaObsh();
            СпециальностиTableAdapter = new СпециальностиTableAdapter();
            tableDataSet = new MyDataSet1();
            new СпециальностиTableAdapter().Fill(tableDataSet.Специальности);
            combo1.ItemsSource = tableDataSet.Специальности;
            combo1.DisplayMemberPath = "Наименование";
            combo1.SelectedValuePath = "Наименование";

            tableDataSet = new MyDataSet1();
            ГруппыTableAdapter = new ГруппыTableAdapter();
            new ГруппыTableAdapter().Fill(tableDataSet.Группы);
            combo2.ItemsSource = tableDataSet.Группы;
            combo2.DisplayMemberPath = "Группа";
            combo2.SelectedValuePath = "Группа";
            text5.Visibility = Visibility.Hidden;
        }
       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tableDataSet = new MyDataSet1();
                if (combo.Text == "Абитуриенты")
                {
                    АбитуриентыTableAdapter = new АбитуриентыTableAdapter();
                    АбитуриентыTableAdapter.AddАбитуриенты(text1.Text, text2.Text, text3.Text, combo1.Text, text4.Text);
                    АбитуриентыTableAdapter.Fill(tableDataSet.Абитуриенты);
                    obnovaAbitur();
                }
                if (combo.Text == "Отделения")
                {
                    ОтделенияTableAdapter = new ОтделенияTableAdapter();
                    ОтделенияTableAdapter.InsertОтделения(text1.Text, combo1.Text, combo2.Text);
                    ОтделенияTableAdapter.Fill(tableDataSet.Отделения);
                    obnovaOtdel();
                }
                if (combo.Text == "Специальности")
                {
                    СпециальностиTableAdapter = new СпециальностиTableAdapter();
                    СпециальностиTableAdapter.InsertСпециальности(text1.Text);
                    СпециальностиTableAdapter.Fill(tableDataSet.Специальности);
                    obnovaSpec();
                }
                if (combo.Text == "Студенты")
                {
                    СтудентыTableAdapter = new СтудентыTableAdapter();
                    СтудентыTableAdapter.InsertСтуденты(text1.Text, text2.Text, text3.Text, combo1.Text, combo2.Text, combo3.Text, Convert.ToInt32(text5.Text));
                    СтудентыTableAdapter.Fill(tableDataSet.Студенты);
                    obnovaStud();
                }
                if (combo.Text == "Расписание")
                {
                    РасписаниеTableAdapter = new РасписаниеTableAdapter();
                    РасписаниеTableAdapter.InsertRaspis(data.Text, Convert.ToInt32(text3.Text), combo1.Text, combo2.Text, text4.Text);
                    РасписаниеTableAdapter.Fill(tableDataSet.Расписание);
                    obnovaRasp();
                }
                if (combo.Text == "Группы")
                {
                    ГруппыTableAdapter = new ГруппыTableAdapter();
                    ГруппыTableAdapter.InsertГруппы(text1.Text, Convert.ToInt32(text2.Text));
                    ГруппыTableAdapter.Fill(tableDataSet.Группы);
                    obnovaGroup();
                }
                if (combo.Text == "Общежитие")
                {
                    ОбщежитиеTableAdapter = new ОбщежитиеTableAdapter();
                    ОбщежитиеTableAdapter.InsertОбщежитие(text1.Text, text2.Text, text3.Text, combo1.Text, combo2.Text, Convert.ToInt32(text4.Text));
                    ОбщежитиеTableAdapter.Fill(tableDataSet.Общежитие);
                    obnovaObsh();
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                tableDataSet = new MyDataSet1();
                if (combo.Text == "Общежитие")
                {
                    DataRowView selectedDataRow = (DataRowView)datagrid.SelectedItem;
                    ОбщежитиеTableAdapter = new ОбщежитиеTableAdapter();
                    ОбщежитиеTableAdapter.DeleteОбщежитие(Convert.ToInt32(selectedDataRow.Row.ItemArray[0]));
                    ОбщежитиеTableAdapter.Fill(tableDataSet.Общежитие);
                    obnovaObsh();
                }
                if (combo.Text == "Группы")
                {
                    DataRowView selectedDataRow = (DataRowView)datagrid.SelectedItem;
                    ГруппыTableAdapter = new ГруппыTableAdapter();
                    ГруппыTableAdapter.DeleteГруппы(Convert.ToInt32(selectedDataRow.Row.ItemArray[0]));
                    ГруппыTableAdapter.Fill(tableDataSet.Группы);
                    obnovaGroup();
                }
                if (combo.Text == "Расписание")
                {
                    РасписаниеTableAdapter = new РасписаниеTableAdapter();
                    РасписаниеTableAdapter.DeleteRaspis();
                    РасписаниеTableAdapter.Fill(tableDataSet.Расписание);
                    obnovaRasp();
                }
                if (combo.Text == "Студенты")
                {
                    DataRowView selectedDataRow = (DataRowView)datagrid.SelectedItem;
                    СтудентыTableAdapter = new СтудентыTableAdapter();
                    СтудентыTableAdapter.DeleteStudent(Convert.ToInt32(selectedDataRow.Row.ItemArray[0]));
                    СтудентыTableAdapter.Fill(tableDataSet.Студенты);
                    obnovaStud();
                }
                if (combo.Text == "Специальности")
                {
                    DataRowView selectedDataRow = (DataRowView)datagrid.SelectedItem;
                    СпециальностиTableAdapter = new СпециальностиTableAdapter();
                    СпециальностиTableAdapter.DeleteСпециальности(Convert.ToInt32(selectedDataRow.Row.ItemArray[0]));
                    СпециальностиTableAdapter.Fill(tableDataSet.Специальности);
                    obnovaSpec();
                }
                if (combo.Text == "Отделения")
                {
                    DataRowView selectedDataRow = (DataRowView)datagrid.SelectedItem;
                    ОтделенияTableAdapter = new ОтделенияTableAdapter();
                    ОтделенияTableAdapter.DeleteOtdelenia(Convert.ToInt32(selectedDataRow.Row.ItemArray[0]));
                    ОтделенияTableAdapter.Fill(tableDataSet.Отделения);
                    obnovaOtdel();
                }
                if (combo.Text == "Абитуриенты")
                {
                    DataRowView selectedDataRow = (DataRowView)datagrid.SelectedItem;
                    АбитуриентыTableAdapter = new АбитуриентыTableAdapter();
                    АбитуриентыTableAdapter.DeleteАбитуриенты(Convert.ToInt32(selectedDataRow.Row.ItemArray[0]));
                    АбитуриентыTableAdapter.Fill(tableDataSet.Абитуриенты);
                    obnovaAbitur();
                }
            }
            catch { MessageBox.Show("Выберите строчку"); }
        }
        private void datagrid_LoadingRow_1(object sender, DataGridRowEventArgs e)
        {
            datagrid.Columns[0].Visibility = Visibility.Hidden;
            if (combo.Text == "Расписание")
                datagrid.Columns[0].Visibility = Visibility.Visible;
        }
        public void obnovaObsh()
        {
            SqlConnection connection = new SqlConnection(s);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Общежитие", connection);
            System.Data.DataTable dataTable = new System.Data.DataTable("Общежитие");
            adapter.Fill(dataTable);
            datagrid.ItemsSource = dataTable.DefaultView;
            connection.Close();
            text1.ToolTip = ("Имя");
            text2.ToolTip = ("Фамилия");
            text3.ToolTip = ("Отчество");
            combo1.ToolTip = ("Специальность");
            combo1.ToolTip = ("Группа");
            text4.ToolTip = ("Курс");
        }
        public void obnovaGroup()
        {
            SqlConnection connection = new SqlConnection(s);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Группы", connection);
            System.Data.DataTable dataTable = new System.Data.DataTable("Группы");
            adapter.Fill(dataTable);
            datagrid.ItemsSource = dataTable.DefaultView;
            connection.Close();
            text1.ToolTip = ("Группа");
            text2.ToolTip = ("Количество студентов");
        }
        public void obnovaRasp()
        {
            SqlConnection connection = new SqlConnection(s);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Расписание", connection);
            System.Data.DataTable dataTable = new System.Data.DataTable("Расписание");
            adapter.Fill(dataTable);
            datagrid.ItemsSource = dataTable.DefaultView;
            connection.Close();
            text3.ToolTip = ("Кабинет");
            combo1.ToolTip = ("Группа");
            combo1.ToolTip = ("Здание");
            text4.ToolTip = ("Пара");
        }
        public void obnovaStud()
        {
            SqlConnection connection = new SqlConnection(s);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Студенты", connection);
            System.Data.DataTable dataTable = new System.Data.DataTable("Студенты");
            adapter.Fill(dataTable);
            datagrid.ItemsSource = dataTable.DefaultView;
            connection.Close();
            text1.ToolTip = ("Имя");
            text2.ToolTip = ("Фамилия");
            text3.ToolTip = ("Отчество");
            combo3.ToolTip = ("Специальность");
            combo1.ToolTip = ("Группа");
            combo2.ToolTip = ("Отделение");
            text5.ToolTip = ("Курс");
        }
        public void obnovaSpec()
        {
            SqlConnection connection = new SqlConnection(s);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Специальности", connection);
            System.Data.DataTable dataTable = new System.Data.DataTable("Специальности");
            adapter.Fill(dataTable);
            datagrid.ItemsSource = dataTable.DefaultView;
            connection.Close();
            text1.ToolTip = ("Специальности");
        }
        public void obnovaOtdel()
        {
            SqlConnection connection = new SqlConnection(s);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Отделения", connection);
            System.Data.DataTable dataTable = new System.Data.DataTable("Отделения");
            adapter.Fill(dataTable);
            datagrid.ItemsSource = dataTable.DefaultView;
            connection.Close();
            text3.ToolTip = ("Отделение");
            combo1.ToolTip = ("Специальности");
            combo1.ToolTip = ("Группа");
        }
        public void obnovaAbitur()
        {
            SqlConnection connection = new SqlConnection(s);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Абитуриенты", connection);
            System.Data.DataTable dataTable = new System.Data.DataTable("Абитуриенты");
            adapter.Fill(dataTable);
            datagrid.ItemsSource = dataTable.DefaultView;
            connection.Close();
            text1.ToolTip = ("Имя");
            text2.ToolTip = ("Фамилия");
            text3.ToolTip = ("Отчество");
            combo1.ToolTip = ("Специальность");
            text4.ToolTip = ("Балл Атестата");
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                tableDataSet = new MyDataSet1();
                if (combo.Text == "Абитуриенты")
                {
                    DataRowView selectedDataRow = (DataRowView)datagrid.SelectedItem;
                    АбитуриентыTableAdapter = new АбитуриентыTableAdapter();
                    if (selectedDataRow != null)
                    {
                        АбитуриентыTableAdapter.UpdateАбитуриенты(text1.Text, text2.Text, text3.Text, combo1.Text, text4.Text, (Convert.ToInt32(selectedDataRow.Row.ItemArray[0])));
                        АбитуриентыTableAdapter.Fill(tableDataSet.Абитуриенты);
                        obnovaAbitur();
                    }
                }
                if (combo.Text == "Общежитие")
                {

                    DataRowView selectedDataRow = (DataRowView)datagrid.SelectedItem;
                    ОбщежитиеTableAdapter = new ОбщежитиеTableAdapter();
                    if (selectedDataRow != null)
                    {
                        ОбщежитиеTableAdapter.UpdateObshaga(text1.Text, text2.Text, text3.Text, combo1.Text, combo2.Text, Convert.ToInt32(text4.Text), (Convert.ToInt32(selectedDataRow.Row.ItemArray[0])));
                        ОбщежитиеTableAdapter.Fill(tableDataSet.Общежитие);
                        obnovaObsh();
                    }
                }
                if (combo.Text == "Группы")
                {
                    DataRowView selectedDataRow = (DataRowView)datagrid.SelectedItem;
                    ГруппыTableAdapter = new ГруппыTableAdapter();
                    if (selectedDataRow != null)
                    {
                        ГруппыTableAdapter.UpdateGroup(text1.Text, Convert.ToInt32(text2.Text), Convert.ToInt32(selectedDataRow.Row.ItemArray[0]));
                        ГруппыTableAdapter.Fill(tableDataSet.Группы);
                        obnovaGroup();
                    }
                }
                if (combo.Text == "Расписание")
                {
                    DataRowView selectedDataRow = (DataRowView)datagrid.SelectedItem;
                    РасписаниеTableAdapter = new РасписаниеTableAdapter();
                    if (selectedDataRow != null)
                    {
                        РасписаниеTableAdapter.UpdateRaspis(data.Text, Convert.ToInt32(text3.Text), combo1.Text, combo2.Text, text4.Text, Convert.ToInt32(selectedDataRow.Row.ItemArray[0]));
                        РасписаниеTableAdapter.Fill(tableDataSet.Расписание);
                        obnovaRasp();
                    }
                }
                if (combo.Text == "Студенты")
                {
                    DataRowView selectedDataRow = (DataRowView)datagrid.SelectedItem;
                    СтудентыTableAdapter = new СтудентыTableAdapter();
                    if (selectedDataRow != null)
                    {
                        СтудентыTableAdapter.UpdateStudents(text1.Text, text2.Text, text3.Text, combo1.Text, combo2.Text, combo3.Text, Convert.ToInt32(text5.Text), Convert.ToInt32(selectedDataRow.Row.ItemArray[0]));
                        СтудентыTableAdapter.Fill(tableDataSet.Студенты);
                        obnovaStud();
                    }
                }
                if (combo.Text == "Специальности")
                {
                    DataRowView selectedDataRow = (DataRowView)datagrid.SelectedItem;
                    СпециальностиTableAdapter = new СпециальностиTableAdapter();
                    СпециальностиTableAdapter.UpdateSpecialnost(text1.Text, Convert.ToInt32(selectedDataRow.Row.ItemArray[0]));
                    СпециальностиTableAdapter.Fill(tableDataSet.Специальности);
                    obnovaSpec();
                }
                if (combo.Text == "Отделения")
                {
                    DataRowView selectedDataRow = (DataRowView)datagrid.SelectedItem;
                    ОтделенияTableAdapter = new ОтделенияTableAdapter();
                    ОтделенияTableAdapter.UpdateOtdelen(text1.Text, combo1.Text, combo2.Text, Convert.ToInt32(selectedDataRow.Row.ItemArray[0]));
                    ОтделенияTableAdapter.Fill(tableDataSet.Отделения);
                    obnovaOtdel();
                }
            }
            catch { MessageBox.Show("Выберите строчку"); }
        }
        public void Obnova()
        {
            text1.Visibility = Visibility.Visible; text2.Visibility = Visibility.Visible; text3.Visibility = Visibility.Visible; text4.Visibility = Visibility.Visible; text5.Visibility = Visibility.Visible;
            combo1.Visibility = Visibility.Visible; combo2.Visibility = Visibility.Visible; data.Visibility = Visibility.Hidden; combo3.Visibility = Visibility.Hidden;
            text1.Margin = new Thickness(626, 147, 47.333, 0);  text2.Margin = new Thickness(626, 174, 47.333, 0);text3.Margin = new Thickness(626, 203, 47.333, 0);text4.Margin = new Thickness(626, 284, 47.333, 0);text5.Margin = new Thickness(626, 312, 47.333, 0);
            combo1.Margin = new Thickness(626, 232, 47.333, 0); combo2.Margin = new Thickness(626, 257, 47.333, 0);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }

        private void datagrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            try
            {
                if (combo.Text == "Специальности")
                {
                    DataRowView selectedDataRow = (DataRowView)datagrid.SelectedItem;
                    if (selectedDataRow != null)
                    {
                        text1.Text = selectedDataRow.Row.ItemArray[1].ToString();
                    }
                }
                if (combo.Text == "Отделения")
                {
                    DataRowView selectedDataRow = (DataRowView)datagrid.SelectedItem;
                    if (selectedDataRow != null)
                    {
                        text1.Text = selectedDataRow.Row.ItemArray[1].ToString();
                        combo1.Text = selectedDataRow.Row.ItemArray[2].ToString();
                        combo2.Text = selectedDataRow.Row.ItemArray[3].ToString();
                    }
                }
                if (combo.Text == "Абитуриенты")
                {
                    DataRowView selectedDataRow = (DataRowView)datagrid.SelectedItem;
                    if (selectedDataRow != null)
                    {
                        text1.Text = selectedDataRow.Row.ItemArray[1].ToString();
                        text2.Text = selectedDataRow.Row.ItemArray[2].ToString();
                        text3.Text = selectedDataRow.Row.ItemArray[3].ToString();
                        combo1.Text = selectedDataRow.Row.ItemArray[4].ToString();
                        text4.Text = selectedDataRow.Row.ItemArray[5].ToString();
                    }
                }
                if (combo.Text == "Студенты")
                {
                    DataRowView selectedDataRow = (DataRowView)datagrid.SelectedItem;
                    if (selectedDataRow != null)
                    {
                        text1.Text = selectedDataRow.Row.ItemArray[1].ToString();
                        text2.Text = selectedDataRow.Row.ItemArray[2].ToString();
                        text3.Text = selectedDataRow.Row.ItemArray[3].ToString();
                        combo1.Text = selectedDataRow.Row.ItemArray[4].ToString();
                        combo2.Text = selectedDataRow.Row.ItemArray[5].ToString();
                        combo3.Text = selectedDataRow.Row.ItemArray[6].ToString();
                        text5.Text = selectedDataRow.Row.ItemArray[7].ToString();
                    }
                }
                if (combo.Text == "Расписание")
                {
                    DataRowView selectedDataRow = (DataRowView)datagrid.SelectedItem;
                    if (selectedDataRow != null)
                    {
                        data.Text = selectedDataRow.Row.ItemArray[1].ToString();
                        text3.Text = selectedDataRow.Row.ItemArray[2].ToString();
                        combo1.Text = selectedDataRow.Row.ItemArray[3].ToString();
                        combo2.Text = selectedDataRow.Row.ItemArray[4].ToString();
                        text4.Text = selectedDataRow.Row.ItemArray[5].ToString();
                    }
                }
                if (combo.Text == "Группы")
                {
                    DataRowView selectedDataRow = (DataRowView)datagrid.SelectedItem;
                    if (selectedDataRow != null)
                    {
                        text1.Text = selectedDataRow.Row.ItemArray[1].ToString();
                        text2.Text = selectedDataRow.Row.ItemArray[2].ToString();
                    }
                }
                if (combo.Text == "Общежитие")
                {
                    DataRowView selectedDataRow = (DataRowView)datagrid.SelectedItem;
                    if (selectedDataRow != null)
                    {
                        text1.Text = selectedDataRow.Row.ItemArray[1].ToString();
                        text2.Text = selectedDataRow.Row.ItemArray[2].ToString();
                        text3.Text = selectedDataRow.Row.ItemArray[3].ToString();
                        combo1.Text = selectedDataRow.Row.ItemArray[4].ToString();
                        combo2.Text = selectedDataRow.Row.ItemArray[5].ToString();
                        combo3.Text = selectedDataRow.Row.ItemArray[6].ToString();
                        text5.Text = selectedDataRow.Row.ItemArray[7].ToString();
                    }
                }
            }
            catch { }
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
            if (combo.Text != "Группы")
            {
                foreach (char c in text2.Text)
                    if (c > '0' && c < '9')
                    {
                        text2.Text = "";
                    }
            }
        }

        private void text3_TextChanged(object sender, TextChangedEventArgs e)
        {
            foreach (char c in text3.Text)
                if ((c > 'a' && c < 'z') || (c > 'A' && c < 'Z'))
                {
                    text3.Text = "";
                }
            if (combo.Text == "Расписание")
            {
                foreach (char c in text3.Text)
                    if ((c > 'а' && c < 'я') || (c > 'А' && c < 'Я'))
                    {
                        text3.Text = "";
                    }
            }
            else
            {
                foreach (char c in text3.Text)
                    if (c > '0' && c < '9')
                    {
                        text3.Text = "";
                    }
            }
        }

        private void text4_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        private void text5_TextChanged(object sender, TextChangedEventArgs e)
        {
                        
        }

    }
}
