using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ContactUsWF_App
{
    public partial class Form1 : Form
    {
        //Supplying objects to a binding source
        private BindingList<ContactUs> entries = new BindingList<ContactUs>();

        public Form1()
        {
            InitializeComponent();

            nameText.DataBindings.Clear();// Clear collection before any bindings
            nameText.DataBindings.Add("Text", entriesSource, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            phoneNumber.DataBindings.Clear();// Clear collection before any bindings
            phoneNumber.DataBindings.Add("Text", entriesSource, "PhoneNumber", true, DataSourceUpdateMode.OnPropertyChanged);
            emailText.DataBindings.Clear();// Clear collection before any bindings
            emailText.DataBindings.Add("Text", entriesSource, "Email", true, DataSourceUpdateMode.OnPropertyChanged);
            subjectText.DataBindings.Clear();// Clear collection before any bindings
            subjectText.DataBindings.Add("Text", entriesSource, "Subject", true, DataSourceUpdateMode.OnPropertyChanged);
            countryText.DataBindings.Clear();// Clear collection before any bindings
            countryText.DataBindings.Add("Text", entriesSource, "Country", true, DataSourceUpdateMode.OnPropertyChanged);
            descriptionText.DataBindings.Clear();// Clear collection before any bindings
            descriptionText.DataBindings.Add("Text", entriesSource, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
            //dueDatePicker.DataBindings.Add("Value", entriesSource, "DueDate", true, DataSourceUpdateMode.OnPropertyChanged);

            entriesSource.DataSource = entries;

            CreateNewItem();
        }
        //Controls

        private void CreateNewItem()
        {
            ContactUs newEntry = (ContactUs)entriesSource.AddNew();
            newEntry.Name = "New name";
            newEntry.PhoneNumber = "New phone Number";
            newEntry.Email = "New email";
            newEntry.Subject = "New subject";
            newEntry.Description = "New message";
            newEntry.Country = "New country";
            entriesSource.ResetCurrentItem();
            //newEntry.DueDate = DateTime.Now;
        }

        //Handling changes
        private void entriesSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.ItemAdded:
                    MakeListViewItemForNewEntry(e.NewIndex);
                    break;
                case ListChangedType.ItemDeleted:
                    RemoveListViewItem(e.NewIndex);
                    break;
                case ListChangedType.ItemChanged:
                    UpdateListViewItem(e.NewIndex);
                    break;
            }
        }

        //Adding new list items when new to-do entries appear
        private void MakeListViewItemForNewEntry(int newItemIndex)
        {
            ListViewItem item = new ListViewItem(); //New ListViewItem create 1 column by default
            item.SubItems.Add(""); // We added 5 more columns by repeating item.SubItems.Add(""); because we have 6 columns to view
            item.SubItems.Add("");
            item.SubItems.Add("");
            item.SubItems.Add("");
            item.SubItems.Add("");
            entriesListView.Items.Insert(newItemIndex, item);
        }

        //Making list view items reflect changes
        private void UpdateListViewItem(int itemIndex)
        {
            ListViewItem item = entriesListView.Items[itemIndex];
            ContactUs entry = entries[itemIndex];
            
            item.SubItems[0].Text = entry.Name;
            item.SubItems[1].Text = entry.PhoneNumber;
            item.SubItems[2].Text = entry.Email;
            item.SubItems[3].Text = entry.Subject;
            item.SubItems[4].Text = entry.Description;
            item.SubItems[5].Text = entry.Country;
            
            //item.SubItems[1].Text = entry.DueDate.ToShortDateString();
        }

        //Removing list view items for deleted entries
        private void RemoveListViewItem(int deletedItemIndex)
        {
            entriesListView.Items.RemoveAt(deletedItemIndex);
        }

        private void newItemButton_Click(object sender, EventArgs e)
        {
            CreateNewItem();
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            if (entriesListView.SelectedIndices.Count != 0)
            {
                int entryIndex = entriesListView.SelectedIndices[0];
                entriesSource.RemoveAt(entryIndex);
            }
        }

        private void entriesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (entriesListView.SelectedIndices.Count != 0)
            {
                int entryIndex = entriesListView.SelectedIndices[0];
                entriesSource.Position = entryIndex;
            }
        }
    }
}
