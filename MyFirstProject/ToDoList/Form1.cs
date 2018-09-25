using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ToDoList
{
    // Example 22-2. Supplying objects to a binding source
    public partial class Form1 : Form
    {
        private BindingList<ToDoEntry> entries = new BindingList<ToDoEntry>();

        public Form1()
        {
            InitializeComponent();
            titleText.DataBindings.Clear();// Clear collection before any bindings
            titleText.DataBindings.Add("Text", entriesSource, "Title", true, DataSourceUpdateMode.OnPropertyChanged);
            dueDatePicker.DataBindings.Clear(); // Clear collection before any bindings
            dueDatePicker.DataBindings.Add("Value", entriesSource, "DueDate", true, DataSourceUpdateMode.OnPropertyChanged);

            entriesSource.DataSource = entries;

            CreateNewItem();
        }

        private void CreateNewItem()
        {
            ToDoEntry newEntry = (ToDoEntry)entriesSource.AddNew();
            newEntry.Title = "New entry";
            newEntry.DueDate = DateTime.Now;
            entriesSource.ResetCurrentItem();
        }

        // Example 22-3. Handling changes
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

        // Example 22-4. Adding new list items when new to-do entries appear
        private void MakeListViewItemForNewEntry(int newItemIndex)
        {
            ListViewItem item = new ListViewItem();
            item.SubItems.Add("");
            entriesListView.Items.Insert(newItemIndex, item);
        }

        // Example 22-5. Making list view items reflect changes
        private void UpdateListViewItem(int itemIndex)
        {
            ListViewItem item = entriesListView.Items[itemIndex];
            ToDoEntry entry = entries[itemIndex];
            item.SubItems[0].Text = entry.Title;
            item.SubItems[1].Text = entry.DueDate.ToShortDateString();
        }

        // Example 22-6. Removing list view items for deleted entries
        private void RemoveListViewItem(int deletedItemIndex)
        {
            entriesListView.Items.RemoveAt(deletedItemIndex);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            CreateNewItem();
        }

        private void deleteButton_Click(object sender, EventArgs e)
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
