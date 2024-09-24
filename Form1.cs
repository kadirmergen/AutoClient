using System.Data;
using System.Data.SqlClient;

namespace AutoClient
{
    public partial class Form1 : Form
    {
        SqlConnection _connection = new SqlConnection(@"Data Source=KADIRMERGEN;Initial Catalog=ProjectsDB;Integrated Security=True;Encrypt=False");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowDatas();
            textBoxCustomerId.Text = "0";
        }

        private void ShowDatas()
        {
            try
            {
                string sqlQuery = "SELECT CustomerId, FirstName, LastName, MonthlyIncome, EligibleForLoan, Address FROM Customers";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, _connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not reach to Database\n", ex.ToString());
            }
            finally
            {
                if (_connection != null)
                    _connection.Close();
            }
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosenRow = dataGridView1.SelectedCells[0].RowIndex;

            textBoxCustomerId.Text = dataGridView1.Rows[choosenRow].Cells[0].Value.ToString();
            textBoxFirstName.Text = dataGridView1.Rows[choosenRow].Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridView1.Rows[choosenRow].Cells[2].Value.ToString();
            textBoxMonthlyIncome.Text = dataGridView1.Rows[choosenRow].Cells[3].Value.ToString();
            textBoxAddress.Text = dataGridView1.Rows[choosenRow].Cells[5].Value.ToString();

            //textBoxEligibleForLoan.Text = dataGridView1.Rows[choosenRow].Cells[4].Value.ToString();

            string text = dataGridView1.Rows[choosenRow].Cells[4].Value.ToString();

            if (text.Equals("True"))
            {
                textBoxEligibleForLoan.Text = "Yes";
            }
            else
            {
                textBoxEligibleForLoan.Text = "No";
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _connection.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Customers (FirstName, LastName, MonthlyIncome, EligibleForLoan, Address) " +
                                                        "VALUES (@P1, @P2, @P3, @P4, @P5)", _connection);
                if (Convert.ToInt32(textBoxMonthlyIncome.Text) >= 25000)
                {
                    sqlCommand.Parameters.AddWithValue("@P4", 1);
                }
                else
                {
                    sqlCommand.Parameters.AddWithValue("@P4", 0);

                }
                sqlCommand.Parameters.AddWithValue("@P1", textBoxFirstName.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxLastName.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBoxMonthlyIncome.Text);
                sqlCommand.Parameters.AddWithValue("@P5", textBoxAddress.Text);
                sqlCommand.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Mistake has been found when you try to enter data\n" + ex.ToString());
            }
            finally
            {
                if (_connection != null)
                    _connection.Close();

            }
            ShowDatas();
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxMonthlyIncome.Clear();
            textBoxEligibleForLoan.Clear();
            textBoxAddress.Clear();
            textBoxCustomerId.Text = "0";
        }

        private void buttonForClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void buttonForDelete_Click(object sender, EventArgs e)
        {
            if (textBoxCustomerId.Text.Equals("0"))
            {
                MessageBox.Show("Please select a customer");
            }
            else
            {
                try
                {
                    _connection.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE from Customers where CustomerId = @P1", _connection);
                    sqlCommand.Parameters.AddWithValue("@P1", textBoxCustomerId.Text);
                    sqlCommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    if (_connection != null)
                        _connection.Close();

                }

            }
            ShowDatas();
            ClearTextBoxes();
        }

        private void buttonForUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxCustomerId.Text.Equals("0"))
            {
                MessageBox.Show("Please select a customer");
            }
            else
            {
                try
                {
                    _connection.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE Customers SET FirstName = @P2, LastName = @P3, " +
                                            "MonthlyIncome = @P4, EligibleForLoan = @P5, Address = @P6 Where CustomerId =@P1", _connection);
                    if (Convert.ToInt32(textBoxMonthlyIncome.Text) >= 25000)
                    {
                        sqlCommand.Parameters.AddWithValue("@P5", 1);
                    }
                    else
                    {
                        sqlCommand.Parameters.AddWithValue("@P5", 0);

                    }
                    sqlCommand.Parameters.AddWithValue("@P1", textBoxCustomerId.Text);
                    sqlCommand.Parameters.AddWithValue("@P2", textBoxFirstName.Text);
                    sqlCommand.Parameters.AddWithValue("@P3", textBoxLastName.Text);
                    sqlCommand.Parameters.AddWithValue("@P4", textBoxMonthlyIncome.Text);
                    sqlCommand.Parameters.AddWithValue("@P6", textBoxAddress.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There is an error occured while connect to database\n", ex.Message);
                }
                finally
                {
                    if (_connection != null)
                        _connection.Close();

                }
                ShowDatas();
                ClearTextBoxes();
            }

        }

        private void buttonForSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlQuery = " SELECT * FROM Customers WHERE FirstName LIKE '" + textBoxFirstName.Text + "%'" +
                    " AND LastName LIKE '" + textBoxLastName.Text + "%'" + " AND Address LIKE '" + textBoxAddress.Text + "%'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlQuery, _connection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable;
                }
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error occured while connect to database\n", ex.Message);
            }
            finally
            {
                if (_connection != null)
                    _connection.Close();
            }
        }

        private void buttonForAllDatas_Click(object sender, EventArgs e)
        {
            ShowDatas();
        }

        private void buttonForFilterByIncome_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlQuery = " SELECT * FROM Customers WHERE MonthlyIncome = " + textBoxMonthlyIncome.Text;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlQuery, _connection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable;
                }
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error occured while connect to database\n", ex.Message);
            }
            finally
            {
                if (_connection != null)
                    _connection.Close();
            }
        }
    }
}
