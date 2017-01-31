using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPE1600_Lab1
{
    public partial class Form1 : Form
    {
        //declares bookmark structure
        public struct Bookmarks
        {
            public string _bookmarkTitle;
            public string _URL;

            public Bookmarks(string bookmark, string url)
            {
                _bookmarkTitle = bookmark;
                _URL = url;
            }
            public override string ToString()
            {
                return string.Format((string)_bookmarkTitle);
            }
        } //End of bookmark structure construction

        //Global Variables       
        List<Bookmarks> bookmarkList = new List<Bookmarks>(); //List that holds the bookmark structures
        public Form1()
        {
            InitializeComponent();
        }
        //Clicking go button will take user to specified url and put url in combo box
        private void UI_GoButton_Click(object sender, EventArgs e)
        {
            try
            {                
                UI_AddressCombo.Items.Add(UI_AddressCombo.Text);
                UI_WebBrowser.Navigate(UI_AddressCombo.Text);               
            }
            catch (Exception)
            {
                MessageBox.Show("Could not navigate to page. Check url.", "Lab2", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        //Sends browser to last page
        private void UI_BackButton_Click(object sender, EventArgs e)
        {
            UI_WebBrowser.GoBack();
        }

        //Sends browser forward through visited pages
        private void UI_ForwardButton_Click(object sender, EventArgs e)
        {
            UI_WebBrowser.GoForward();
        }

        //Adds a bookamrk
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookmark();
        }        

        //Sends brower to selected bookmark url
        private void UI_BookmarkBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = UI_BookmarkBox.SelectedIndex;
            Bookmarks temp = bookmarkList[index];
            UI_WebBrowser.Navigate(temp._URL);
        }

        //Deleted selected bookmark
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteBookmark();
        }
        
        //Method that creates a struct for new bookmark,
        //adds it to a list, and copies that list to the
        //bookmark box.  
        private void AddBookmark()
        {
            bookmarkList.Add(new CMPE1600_Lab1.Form1.Bookmarks(UI_AddBookmarkBox.Text, UI_AddressCombo.Text));

            UI_BookmarkBox.Items.Clear();

            foreach (Bookmarks b in bookmarkList)
            {
                UI_BookmarkBox.Items.Add(b);
            }
        }

        //Removes the selected bookmark from
        //the bookmark list, then recopies
        //the list to the bookmark box.
        private void DeleteBookmark()
        {
            int index = UI_BookmarkBox.SelectedIndex;

            bookmarkList.Remove(bookmarkList[index]);

            UI_BookmarkBox.Items.Clear();

            foreach (Bookmarks b in bookmarkList)
            {
                UI_BookmarkBox.Items.Add(b);
            }
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookmarkList.Clear();
            UI_BookmarkBox.Items.Clear();
        }
    }
}
