using Client.AccountService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        private AccountServiceClient _client;
        private UserDto _userDto;

        public Form1()
        {
            _client = new AccountServiceClient();
            InitializeComponent();
        }

        private void SearchByAccountNumber_Click(object sender, EventArgs e)
        {
            int number = 0;
            if (AccountNumber.Text == String.Empty|| AccountNumber.Text.Length!=6 || !Int32.TryParse(AccountNumber.Text, out number))
            {
                ValidationMessage("You didn't enter the account number.");
                return;
            }
            UserDto userDto = _client.GetByAccountNumber(number);
            _userDto = userDto;           

            UserName.Text = _userDto.Name;
            Balance.Text = _userDto.Balance.ToString();
            ValidationDate.Text = _userDto.ValidTillDate.ToString("dd/mm/yyyy");
            Phone.Text = _userDto.Phone;
            Notes.Text = _userDto.Notes;
            ModificationDate.Text = _userDto.ModificationDate.ToString("dd/mm/yyyy");

            SaveChanges.Enabled = true;
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if (UserName.Text == String.Empty)
            {
                ValidationMessage("You didn't enter the name.");
                return;
            }
            if (Decimal.Parse(Balance.Text) < 0)
            {
                ValidationMessage("The balance can't be negative ");
                return;
            }
           
            _client.Update(new UserDto
            {
                UserId = _userDto.UserId,
                IncomeDate = _userDto.IncomeDate,
                Name = UserName.Text,              
                Balance = Decimal.Parse(Balance.Text),
                Phone = Phone.Text,
                Notes = Notes.Text
            });
        }

        private void ValidationMessage(string message)
        {
            string caption = "Wrong input";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }
    }
}
