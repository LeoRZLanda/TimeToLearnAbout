using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Contacts : Form
    {

        private BusinessLogicLayer businessLogicLayer;

        public Contacts()
        {
            InitializeComponent();
            businessLogicLayer = new BusinessLogicLayer();
        }


        #region EVENTS


        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenContactDetailsDialog();
        }

        private void Contacts_Load(object sender, EventArgs e)
        {
            PopulateContacts();
        }

        private void GridViewContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)GridViewContacts.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "Edit")
            {
                ContactsDetails contactsDetails = new ContactsDetails();
                contactsDetails.LoadContact(new Contact
                {
                    Id = int.Parse((GridViewContacts.Rows[e.RowIndex].Cells[0].Value.ToString())),
                    FirstName = GridViewContacts.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    LastName = GridViewContacts.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Phone = GridViewContacts.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Address = GridViewContacts.Rows[e.RowIndex].Cells[4].Value.ToString()
                });
                contactsDetails.ShowDialog(this);
            }

            else if (cell.Value.ToString() == "Delete")
            {
                DeleteContact(int.Parse((GridViewContacts.Rows[e.RowIndex].Cells[0].Value.ToString())));
                PopulateContacts();
            }
        }

        #endregion

        #region PRIVATE METHODS

        private void OpenContactDetailsDialog() {
            ContactsDetails contactsDetails = new ContactsDetails();
            contactsDetails.ShowDialog(this);
        }


        private void DeleteContact(int Id)
        {
            businessLogicLayer.DeleteContact(Id);
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            PopulateContacts(txtSearch.Text);
            txtSearch.Text = string.Empty;
        }
        #endregion

        #region PUBLIC METHODS

        public void PopulateContacts(string searchText = null)
        {
            List<Contact> contacts = businessLogicLayer.GetContacts(searchText);
            gridContacts.DataSource = contacts;
        }

        #endregion
    }
}
