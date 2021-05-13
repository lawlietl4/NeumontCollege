using Database.DataSet1TableAdapters;
using System;
using System.Data;
using System.Linq;
using System.Windows;

namespace Database
{
    public partial class LoginWindow : Window
    {
        public string username;
        private string Username
        {
            get{ return username; }
            set => username = value;
        }
        public string password;
        public string Password
        {
            get { return password; }
            set => password = value;
        }
        DataSet1 dataSet = new();
        UsersTableAdapter userTableAdapter = new();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            userTableAdapter.Fill(dataSet.Users);
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var query = from user in dataSet.Users
                        where (user.Name == txtName.Text)
                        where (user.Password == txtPassword.Text)
                        select user;
            if (query.Count() > 0)
            {
                MainWindow mainWindow = new();
                mainWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("User does not exist!");
                txtName.Clear();
                txtPassword.Clear();
            }
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            DataSet1.UsersRow row = (DataSet1.UsersRow)dataSet.Users.NewRow();
            row.Name = txtName.Text;
            row.Password = txtPassword.Text;
            dataSet.Users.AddUsersRow(row);
            userTableAdapter.Update(dataSet);
            MessageBox.Show("User Registered!");
            txtName.Clear();
            txtPassword.Clear();
        }
    }
}
