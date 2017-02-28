using Client.AccountService;
using System;
using System.ServiceModel;
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

            if (AccountNumber.Text == String.Empty || AccountNumber.Text.Length != 5 || !Int32.TryParse(AccountNumber.Text, out number))
            {
                ValidationMessage("You didn't enter the account number.");
                return;
            }

            try
            {
                DisableControls();

                UserDto userDto = _client.GetByAccountNumber(number);
                if (userDto == null)
                {
                    MessageBox.Show("Client account not found");
                    EnableControls();
                    return;
                }
                _userDto = userDto;

                UserName.Text = _userDto.Name;
                Balance.Text = _userDto.Balance.ToString();
                ValidationDate.Text = _userDto.ValidTillDate.ToString("dd/MM/yyyy");
                Phone.Text = _userDto.Phone;
                Notes.Text = _userDto.Notes;
                ModificationDate.Text = _userDto.ModificationDate.ToString("dd/MM/yyyy");
                MonthlyFeeDate.Text = _userDto.MonthlyFeeDate.ToString("dd/MM/yyyy");

                SaveChanges.Enabled = true;
            }
            catch (FaultException ex)
            {
                ErrorMessage(ex.Message);
            }
            catch (EndpointNotFoundException ex)
            {
                ErrorMessage(ex.Message);
            }
            finally
            {
                EnableControls();
            }
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if (UserName.Text == String.Empty)
            {
                ValidationMessage("You didn't enter the name.");
                return;
            }

            try
            {
                DisableControls();

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
            catch (FaultException ex)
            {
                ErrorMessage(ex.Message);
            }
            finally
            {
                EnableControls();
            }
        }

        private void ValidationMessage(string message)
        {
            MessageBox.Show(message, "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void ErrorMessage(string message)
        {
            MessageBox.Show(message, "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EnableControls()
        {
            UserName.Enabled = true;
            Phone.Enabled = true;
            Balance.Enabled = true;
            Notes.Enabled = true;
        }

        private void DisableControls()
        {
            UserName.Enabled = false;
            Phone.Enabled = false;
            Balance.Enabled = false;
            Notes.Enabled = false;
        }
    }
}
