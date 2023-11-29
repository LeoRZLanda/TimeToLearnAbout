using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class ContactsDetails : Form
    {

        private BusinessLogicLayer _businessLogicLayer;
        private Contact _contact;
        public ContactsDetails()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
            _contact = new Contact();
        }

        #region EVENTS

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveContact();
            this.Close();
            ((Contacts)this.Owner).PopulateContacts();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        #region PRIVATE METHODS

        private void saveContact()
        {
            Contact contact = new Contact();
            contact.FirstName = txtFirstName.Text;
            contact.LastName = txtLastName.Text; ;
            contact.Phone = txtPhone.Text;
            contact.Address = txtAddress.Text;

            contact.Id = _contact != null ? _contact.Id : 0;

            _businessLogicLayer.SaveContact(contact);
        }

        private void ClearForm()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }

        #endregion

        #region PUBLIC METHODS

        public void LoadContact(Contact contact)
        {
            _contact = contact;
            if (_contact != null)
            {

                ClearForm();

                txtFirstName.Text = contact.FirstName;
                txtLastName.Text = contact.LastName;
                txtPhone.Text = contact.Phone;
                txtAddress.Text = contact.Address;
            }
        }

        #endregion

    }
}
