using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<string> dates = new List<string>();
        string maks;
        public Form1()
        {
            InitializeComponent();
        }
        private DataGridViewColumn createColumn(string columnName)
        {
            var column = new DataGridViewColumn();
            column.HeaderText = columnName;
            column.Width = 140;
            column.ReadOnly = true;
            column.Name = columnName;
            column.CellTemplate = new DataGridViewTextBoxCell();
            return column;
        }

        private void getTable_Click_1(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            GetData();
        }
        private void GetData()
        {
            try
            {
                DB db = new DB();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `store_stock`", db.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    viewTable(table, false);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Відсутнє підключення до серверу.", "Помилка");
            }
        }

        private void viewTable(DataTable table, bool viewFirstElement)
        {
            dataGridView.Rows.Clear();
            createColumnNames();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dataGridView.Rows.Add(
                    table.Rows[i][0].ToString(),
                    table.Rows[i][1].ToString(),
                    table.Rows[i][2].ToString(),
                    table.Rows[i][3].ToString(),
                    table.Rows[i][4].ToString(),
                    table.Rows[i][5].ToString()
                );
                if (viewFirstElement) return;
            }
        }
        private void createColumnNames()
        {
            dataGridView.Columns.Clear();
            string[] columnNames = new string[6] { "Інвентарний номер", "Найменування", "ПІБ відповідального", "Дата доставки", "Кiлькiсть товару", "Постачальник" };
            for (int i = 0; i < columnNames.Length; i++)
            {
                dataGridView.Columns.Add(createColumn(columnNames[i]));
            }
        }

        private void додатиЗаписToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            addItem.Visible = true;
            changeItem.Visible = false;
            ProductNumber.Clear();
            ProductName.Clear();
            fullName.Clear();
            Quantity.Clear();
        }

        private bool isValidValues()
        {
            int id;
            if (!int.TryParse(ProductNumber.Text, out id)
                || !int.TryParse(Quantity.Text, out id)
                || string.IsNullOrEmpty(ProductNumber.Text)
                || string.IsNullOrEmpty(fullName.Text))
            {
                return false;
            }
            return true;
        }
        private void addItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isValidValues())
                {
                    MessageBox.Show("Заповніть усі поля.", "Помилка");
                    return;
                }
                DB db = new DB();
                MySqlCommand commandAddAgent = new MySqlCommand("INSERT INTO `store_stock` (`ProductNumber`, `ProductName`, `fullName`, `DeliveryDate`, `Quantity`, `Provider`) VALUES (@ProductNumber, @ProductName, @fullName, @DeliveryDate, @Quantity, @Provider);", db.getConnection());
                commandAddAgent.Parameters.Add("@ProductNumber", MySqlDbType.Int32).Value = int.Parse(ProductNumber.Text);
                commandAddAgent.Parameters.Add("@ProductName", MySqlDbType.VarChar).Value = ProductName.Text;
                commandAddAgent.Parameters.Add("@fullName", MySqlDbType.VarChar).Value = fullName.Text;
                commandAddAgent.Parameters.Add("@DeliveryDate", MySqlDbType.DateTime).Value = DateTime.Parse(DeliveryDate.Text);
                commandAddAgent.Parameters.Add("@Quantity", MySqlDbType.Int32).Value = Int32.Parse(Quantity.Text);
                commandAddAgent.Parameters.Add("@Provider", MySqlDbType.VarChar).Value = Provider.Text;
                db.openConnection();
                try
                {
                    commandAddAgent.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Можливо був зазначений вже існуючий ID.", "Помилка");
                }

                db.closeConnection();
                GetData();
            }
            catch(Exception)
            {
                MessageBox.Show("Відсутнє підключення до серверу.");
            }
        }

        private void видалитиЗаписToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            datePanel.Visible = false;
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (!Int32.TryParse(deleteBox.Text, out id))
                {
                    MessageBox.Show("Заповніть поле.", "Помилка");
                    return;
                }
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("DELETE FROM `store_stock` WHERE `store_stock`.`ProductNumber` =@ProductNumber;", db.getConnection());
                command.Parameters.Add("@ProductNumber", MySqlDbType.Int32).Value = id;
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
                GetData();
            }
            catch(Exception)
            {
                MessageBox.Show("Відсутнє підключення до серверу.");
            }
        }

        private DataRowCollection getInventInfo(int ids)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `store_stock` WHERE `store_stock`.`ProductNumber` = @ProductNumber", db.getConnection());
            command.Parameters.Add("@ProductNumber", MySqlDbType.Int32).Value = ids;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table.Rows;
        }
        private void createFile(string date, DataRowCollection rows)
        {
            string fullFileName = date.Replace(':', '-');
            StreamWriter sw = new StreamWriter(@"C:\Users\Grem\OneDrive\Project\Информация\" + fullFileName + ".txt");
            for (int i = 0; i < rows.Count; i++)
            {
                if (rows[i][3].ToString() == date)
                {
                    sw.WriteLine(rows[i][0].ToString() + " "
                        + rows[i][1].ToString() + " "
                        + rows[i][2].ToString() + " "
                        + rows[i][3].ToString() + " "
                        + rows[i][4].ToString());
                }
            }
            sw.Close();
        }
        private void createReport()
        {
            dates.Clear();
            try
            {
                DB db = new DB();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `store_stock`", db.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);
                MessageBox.Show("Всі дані успішно збережені у файли.");
                if (table.Rows.Count > 0)
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        if (!dates.Contains(table.Rows[i][3].ToString()))
                        {
                            createFile(table.Rows[i][3].ToString(), table.Rows);
                            dates.Add(table.Rows[i][3].ToString());
                        }
                    }
            }
            catch (Exception)
            {
                MessageBox.Show("Вказано невірний шлях збереження або відсутнє підключення до серверу.", "Помилка");
                return;
            }
        }
        private void changeItem_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                int ids;
                if (!int.TryParse(ProductNumber.Text, out ids))
                {
                    MessageBox.Show("Заповніть поле.", "Помилка");
                    return;
                }
                MySqlCommand commandAddAgent = new MySqlCommand("UPDATE `store_stock` SET `ProductNumber` = @ProductNumber, `ProductName` = @ProductName, `fullName` = @fullName, `DeliveryDate` = @DeliveryDate, `Quantity` = @Quantity, `Provider` = @Provider WHERE `store_stock`.`ProductNumber` = @ProductNumber;", db.getConnection());
                commandAddAgent.Parameters.Add("@ProductNumber", MySqlDbType.Int32).Value = int.Parse(ProductNumber.Text);
                commandAddAgent.Parameters.Add("@ProductName", MySqlDbType.VarChar).Value = ProductName.Text;
                commandAddAgent.Parameters.Add("@fullName", MySqlDbType.VarChar).Value = fullName.Text;
                commandAddAgent.Parameters.Add("@DeliveryDate", MySqlDbType.DateTime).Value = DateTime.Parse(DeliveryDate.Text);
                commandAddAgent.Parameters.Add("@Quantity", MySqlDbType.Int32).Value = Int32.Parse(Quantity.Text);
                commandAddAgent.Parameters.Add("@Provider", MySqlDbType.VarChar).Value = Provider.Text;
                db.openConnection();
                if (commandAddAgent.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Дані успішно змінені.", "Успішна операція");
                }
                else
                {
                    MessageBox.Show("Можливо відсутнє підключення до серверу.", "Помилка");
                    this.Refresh();
                }

                db.closeConnection();
                GetData();
            }
            catch(Exception)
            {
                MessageBox.Show("Відсутнє підключення до серверу.");
            }
        }

        private void змiнитиЗаписToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            addItem.Visible = false;
            changeItem.Visible = true;
        }

        private void id_Leave(object sender, EventArgs e)
        {
            if (changeItem.Visible == true)
            {
                int ids;
                if (!int.TryParse(ProductNumber.Text, out ids))
                {
                    ProductNumber.Clear();
                    ProductName.Clear();
                    fullName.Clear();
                    Quantity.Clear();
                    MessageBox.Show("Вкажіть інвентарний номер для автозаповнення.", "Помилка");
                    return;
                }
                DataRowCollection invent = getInventInfo(ids);
                if (invent.Count == 0)
                {
                    ProductNumber.Clear();
                    ProductName.Clear();
                    fullName.Clear();
                    Quantity.Clear();
                    MessageBox.Show("Вказано неіснуючий інвентарний номер.", "Помилка");
                    return;
                }
                ProductNumber.Text = invent[0][0].ToString();
                ProductName.Text = invent[0][1].ToString();
                fullName.Text = invent[0][2].ToString();
                DeliveryDate.Text = invent[0][3].ToString();
                Quantity.Text = invent[0][4].ToString();
                Provider.Text = invent[0][5].ToString();
            }
        }

        private void вивестиЗаписиЗаДатоюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datePanel.Visible = true;
            labelEnd.Visible = false;
            end.Visible = false;
            panel3.Visible = false;
        }

        private void кількістьТоваруЗаВизначенимиДатамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datePanel.Visible = true;
            labelEnd.Visible = true;
            end.Visible = true;
            panel3.Visible = false;
        }

        private void dateBut_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            if (!labelEnd.Visible)
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `store_stock` WHERE `store_stock`.`DeliveryDate` = @dateStart", db.getConnection());
                command.Parameters.Add("@dateStart", MySqlDbType.Date).Value = DateTime.Parse(start.Value.ToString());
                viewParametrTable(command, false, false);
            }
            else
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `store_stock` WHERE `store_stock`.`DeliveryDate` between @dateStart and @dateEnd", db.getConnection());
                command.Parameters.Add("@dateStart", MySqlDbType.Date).Value = DateTime.Parse(start.Value.ToString());
                command.Parameters.Add("@dateEnd", MySqlDbType.Date).Value = DateTime.Parse(end.Value.ToString());
                viewParametrTable(command, true, false);
            }
        }

        private void viewParametrTable(MySqlCommand command, bool isCount, bool viewFirstElement)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    if (isCount)
                    {
                        viewTable(table, viewFirstElement);
                        datePanel.Visible = false;
                        return;
                    }
                    viewTable(table, viewFirstElement);
                    datePanel.Visible = false;
                }
                else
                {
                    MessageBox.Show("Такого товару не існує");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Відсутнє підключення до серверу.", "Помилка");
            }
        }
        private void ВивестиУфайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createReport();
        }
        private void search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM store_stock WHERE ProductName LIKE '%" + search.Text + "%'", db.getConnection());
                adapter.SelectCommand = command;
                if (search.Text != "")
                {
                    adapter.Fill(table);
                }
                else
                {
                    adapter.Fill(table);
                }
                if (table.Rows.Count > 0)
                {
                    viewTable(table, false);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Відсутнє підключення до серверу.", "Помилка");
            }
        }

        private void search2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM store_stock WHERE Provider LIKE '%" + search2.Text + "%'", db.getConnection());
                adapter.SelectCommand = command;
                if (search2.Text != "")
                {
                    adapter.Fill(table);
                }
                else
                {
                    adapter.Fill(table);
                }
                if (table.Rows.Count > 0)
                {
                    viewTable(table, false);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Відсутнє підключення до серверу.", "Помилка");
            }
        }
    }
}