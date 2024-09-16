using FinancialTracker.Core.Entities;
using FinancialTracker.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialTracker.WinUI
{
    public partial class Authentication : Form
    {
        private UserRepository userRepository;
        private Form1 form1;
        public Authentication(UserRepository userRepository, Form1 form1)
        {
            InitializeComponent();
            this.userRepository = userRepository;
            this.form1 = form1;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text; // Отримання значення електронної пошти з поля введення

            User user = userRepository.GetUserByUsername(username);
            if (user != null && user.Password == password && user.Email == email) // Перевірка ім'я, паролю і електронної пошти
            {
                form1.currentUser = user;
                form1.LoadTransactions();
                this.Close();
            }
            else
            {
                MessageBox.Show("Невірне ім'я користувача, пароль або електронна пошта!");
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text; // Отримання значення електронної пошти з поля введення

            User existingUser = userRepository.GetUserByUsername(username);
            if (existingUser != null)
            {
                MessageBox.Show("Користувач вже існує!");
                return;
            }

            User newUser = new User { Name = username, Password = password, Email = email }; // Додано електронну пошту
            userRepository.Add(newUser);

            form1.currentUser = newUser;
            form1.LoadTransactions();
            this.Close();
        }
    }
}
