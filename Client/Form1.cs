using Client.AccountService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        private AccountService.AccountServiceClient _client; 
        public Form1()
        {
            _client = new AccountService.AccountServiceClient();
            InitializeComponent();
        }

        private void SearchByAccountNumber_Click(object sender, EventArgs e)
        {
            UserDto userDto =_client.GetByAccountNumber(Int32.Parse(AccountNumber.Text));
            UserName.Text = userDto.Name;
            Balance.Text =  userDto.Balance.ToString();
            ValidationDate.Text = userDto.ValidTillDate.ToString();
            Phone.Text = userDto.Phone;
            Notes.Text = userDto.Notes;
            ModificationDate.Text = userDto.ModificationDate.ToString();
        }
        
    }
}
