using FinancialTracker.Core.Context;
using FinancialTracker.Core.Entities;
using FinancialTracker.Repositories;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace FinancialTracker.WinUI
{
    public partial class Form1 : Form
    {
        private UserRepository userRepository;
        private TransactionRepository transactionRepository;
        public User currentUser;
        private FinancialTrackerContext financialTrackeContext;
        private TransactionCategoryRepository categoryRepository;
        private TransactionTypeRepository transactiontypeRepository;
        private PaymentTypeRepository paymenttypeRepository;
        private CurrencyRepository currencyRepository;
        private BindingList<Transaction> transactions; // �����������, ��� ��� �������� ������


        char operation = ' ';
        string num1 = "";
        string num2 = "";
        public Form1()
        {
            InitializeComponent();

            financialTrackeContext = new FinancialTrackerContext(); // ������� ������� �� ��� ��������
            userRepository = new UserRepository(financialTrackeContext);
            transactionRepository = new TransactionRepository(financialTrackeContext);
            categoryRepository = new TransactionCategoryRepository(financialTrackeContext);
            transactiontypeRepository = new TransactionTypeRepository(financialTrackeContext);
            paymenttypeRepository = new PaymentTypeRepository(financialTrackeContext);
            currencyRepository = new CurrencyRepository(financialTrackeContext);
            // ���������� ��������, ���� ���������� �� ����������������
            listBoxTransactions.Visible = false;
            LoadImageToPictureBox();
            transactions = new BindingList<Transaction>(); // ������������� ��������� ������
            listBoxTransactions.DataSource = transactions;
        }

        private void btnAuthenticate_Click(object sender, EventArgs e)
        {
            Authentication loginForm = new Authentication(userRepository, this);
            loginForm.ShowDialog();
        }
        public void LoadTransactions()
        {
            if (currentUser != null)
            {
                var transactions = transactionRepository.GetTransactionsWithDetailsByUserId(currentUser.Id_user);
                listBoxTransactions.DataSource = transactions;
                listBoxTransactions.DisplayMember = "ToString"; // �������, ��� ���������� ������ ��� ����� �� ����������� ��� �������

                // ����� ��������, ������� ���������� ����������������
                listBoxTransactions.Visible = true;
            }
            else
            {
                // ������� �������� �� ���������� ����, ���� ���������� �� ����������������
                listBoxTransactions.Items.Clear();
                listBoxTransactions.Visible = false;
            }
        }

        private void BtnAddTransaction_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAmount.Text) && !string.IsNullOrEmpty(txtDescription.Text))
            {
                double amount;
                if (double.TryParse(txtAmount.Text, out amount))
                {
                    Transaction newTransaction = new Transaction
                    {
                        Date = datePicker.Value,
                        Amount = amount,
                        Description = txtDescription.Text,
                        Currency = cboCurrency.SelectedItem as Currency,
                        PaymentType = cboPaymentType.SelectedItem as PaymentType,
                        TransactionCategory = cboCategory.SelectedItem as TransactionCategory,
                        TransactionType = cboTransactionType.SelectedItem as TransactionType
                    };

                    // ������� DataSource ����� ����������� ������ ��������
                    listBoxTransactions.DataSource = null;

                    // ��������� ������� �������� � Items
                    listBoxTransactions.Items.Add($"Date: {newTransaction.Date}, Amount: {newTransaction.Amount}, Description: {newTransaction.Description}, Currency: {newTransaction.Currency}, PaymentType: {newTransaction.PaymentType}, TransactionCategory: {newTransaction.TransactionCategory}, TransactionType: {newTransaction.TransactionType}");
                }
                else
                {
                    MessageBox.Show("Please enter a valid amount.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.");
            }
        }


        private void UpdateListBox()
        {
            listBoxTransactions.DataSource = null; // ������ �������� ������
            listBoxTransactions.Items.Clear(); // �������� �������� ������
            listBoxTransactions.DataSource = transactions; // ���������� transactions �� ������� ����� ��� listBoxTransactions
        }
        private void AddCurrency()
        {
            if (cboCurrency.Text == "")
            {
                MessageBox.Show("Empty data!");
                return;
            }

            // ��������� �������� � ��������� �������� cboPaymentType
            string currency = cboCurrency.Text;

            // ��������� ������ ��'���� PaymentType � ��������� ���������
            Currency newCurrency = new Currency { Title_currency = currency };

            // ��������� ������ PaymentType ����� ����������
            currencyRepository.Add(newCurrency);

            // ��������� ������ ���� ��������� ������ PaymentType
            UpdateListBox();
        }
        private void AddTransactionCategory()
        {
            if (cboCategory.Text == "")
            {
                MessageBox.Show("Empty data!");
                return;
            }

            // ��������� �������� � ��������� �������� cboPaymentType
            string category = cboCategory.Text;

            // ��������� ������ ��'���� PaymentType � ��������� ���������
            TransactionCategory newCategory = new TransactionCategory { Title_categories = category };

            // ��������� ������ PaymentType ����� ����������
            categoryRepository.Add(newCategory);

            // ��������� ������ ���� ��������� ������ PaymentType
            UpdateListBox();
        }
        private void AddTransactionType()
        {
            if (cboTransactionType.Text == "")
            {
                MessageBox.Show("Empty data!");
                return;
            }

            // ��������� �������� � ��������� �������� cboPaymentType
            string transactionType = cboTransactionType.Text;

            // ��������� ������ ��'���� PaymentType � ��������� ���������
            TransactionType newtransactionType = new TransactionType { Title_type = transactionType };

            // ��������� ������ PaymentType ����� ����������
            transactiontypeRepository.Add(newtransactionType);

            // ��������� ������ ���� ��������� ������ PaymentType
            UpdateListBox();
        }
        private void buttonAdd()
        {
            transactionRepository.Add(new Transaction
            {
                Date = datePicker.Value,
                Amount = double.Parse(txtAmount.Text),
                Description = txtDescription.Text,
                Currency = cboCurrency.SelectedItem as Currency,
                PaymentType = cboPaymentType.SelectedItem as PaymentType,
                TransactionCategory = cboCategory.SelectedItem as TransactionCategory,
                TransactionType = cboTransactionType.SelectedItem as TransactionType,

            });
            UpdateListBox();
        }










        private void LoadImageToPictureBox()
        {
            string imagePath = "C:\\Users\\admin\\Desktop\\C#\\�����.jpg"; // ������ �� ���� �� ������ ����������

            // ������������ ���������� � PictureBox
            pictureBox1.Image = Image.FromFile(imagePath);
            // ������� ������ PictureBox
            pictureBox1.Size = new Size(150, 150); // ������ � �������: ������, ������

            // ���� ������ ������������� ����������
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void button_0_Click(object sender, EventArgs e)
        {
            if (operation == ' ')
            {
                num1 += "0";
            }
            else
            {
                num2 += "0";
            }
            tb_show.Text = num1 + operation + num2;
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if (operation == ' ')
            {
                num1 += "1";
            }
            else
            {
                num2 += "1";
            }
            tb_show.Text = num1 + operation + num2;
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (operation == ' ')
            {
                num1 += "2";
            }
            else
            {
                num2 += "2";
            }
            tb_show.Text = num1 + operation + num2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (operation == ' ')
            {
                num1 += "3";
            }
            else
            {
                num2 += "3";
            }
            tb_show.Text = num1 + operation + num2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (operation == ' ')
            {
                num1 += "4";
            }
            else
            {
                num2 += "4";
            }
            tb_show.Text = num1 + operation + num2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (operation == ' ')
            {
                num1 += "5";
            }
            else
            {
                num2 += "5";
            }
            tb_show.Text = num1 + operation + num2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (operation == ' ')
            {
                num1 += "6";

            }
            else
            {
                num2 += "6";
            }
            tb_show.Text = num1 + operation + num2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (operation == ' ')
            {
                num1 += "7";
            }
            else
            {
                num2 += "7";
            }
            tb_show.Text = num1 + operation + num2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (operation == ' ')
            {
                num1 += "8";
            }
            else
            {
                num2 += "8";
            }
            tb_show.Text = num1 + operation + num2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (operation == ' ')
            {
                num1 += "9";
            }
            else
            {
                num2 += "9";
            }
            tb_show.Text = num1 + operation + num2;
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            double k = 0;
            if (num1 != "" && num2 == "" && double.TryParse(num1, out k))
                operation = '*';
            else
            {
                MessageBox.Show("Sth went wrong", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            tb_show.Text = num1 + operation + num2;
        }

        private void buttonDi_Click(object sender, EventArgs e)
        {
            double k = 0;
            if (num1 != "" && num2 == "" && double.TryParse(num1, out k))
                operation = '/';
            else
            {
                MessageBox.Show("Sth went wrong", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            tb_show.Text = num1 + operation + num2;
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            double k = 0;
            if (num1 != "" && num2 == "" && double.TryParse(num1, out k))
                operation = '-';
            else
            {
                MessageBox.Show("Sth went wrong", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            tb_show.Text = num1 + operation + num2;
        }

        private void buttonD_Click(object sender, EventArgs e)
        {

            double k = 0;
            if (num1 != "" && num2 == "" && double.TryParse(num1, out k))
                operation = '+';
            else
            {
                MessageBox.Show("Sth went wrong", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            tb_show.Text = num1 + operation + num2;
        }

        private void buttonDor_Click(object sender, EventArgs e)
        {
            if (operation == ' ' || num1 == "" || num2 == "")
            {
                MessageBox.Show("Sth went wrong", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            switch (operation)
            {
                case '+':
                    num1 = (Convert.ToDouble(num1) + Convert.ToDouble(num2)).ToString();
                    break;
                case '-':
                    num1 = (Convert.ToDouble(num1) - Convert.ToDouble(num2)).ToString();
                    break;
                case '*':
                    num1 = (Convert.ToDouble(num1) * Convert.ToDouble(num2)).ToString();
                    break;
                case '/':
                    num1 = (Convert.ToDouble(num1) / Convert.ToDouble(num2)).ToString();
                    break;
            }
            tb_show.Text = num1;
            operation = ' ';
            num2 = "";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            num1 = "";
            num2 = "";
            operation = ' ';
            tb_show.Text = "";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            if (operation == ' ')
            {
                num1 = "";
            }
            else
            {
                num2 = "";
            }
            tb_show.Text = num1 + operation + num2;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (operation == ' ')
            {
                if (num1.Length > 0)
                {
                    num1 = num1.Substring(0, num1.Length - 1);
                }
            }
            else
            {
                if (num2.Length > 0)
                {
                    num2 = num2.Substring(0, num2.Length - 1);
                }
            }
            tb_show.Text = num1 + operation + num2;
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (operation == ' ')
            {
                if (!num1.Contains("."))
                {
                    num1 += "0.";
                }
            }
            else
            {
                if (!num2.Contains("."))
                {
                    num2 += "0.";
                }
            }
            tb_show.Text = num1 + operation + num2;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxTransactions.SelectedItem is Transaction selectedTransaction)
            {
                transactionRepository.DeleteTransactionById(selectedTransaction.Id_transaction);
                UpdateListBox();
            }
            else
            {
                MessageBox.Show("Please select a transaction to delete.", "No Transaction Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxTransactions.SelectedIndex >= 0 && listBoxTransactions.SelectedIndex < transactions.Count)
            {
                // ��������� ���������� ������� �� ListBox
                int selectedIndex = listBoxTransactions.SelectedIndex;

                // �������� ���������� ������ �� ��������� ����������

                // ���������� �������� � ������ transactions �� ���������� �������
                transactions[selectedIndex].Date = datePicker.Value;
                transactions[selectedIndex].Amount = // ���������� �����
                                                     // �������� ������ �������� � ����������� �� ����� ������

                // ���������� ListBox ����� ���������
                transactions[selectedIndex].Amount = double.Parse(txtAmount.Text);
            }
            else
            {
                MessageBox.Show("Please select an item to edit.");
            }
        }
    }
}
    


