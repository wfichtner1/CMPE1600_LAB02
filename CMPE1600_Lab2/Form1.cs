﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace CMPE1600_Lab1
{
    public partial class Form1 : Form
    {
        //declares bookmark structure
        [Serializable] public struct Bookmarks //Structure to hold a bookmark as the title, and the url it represents
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

        //Attempts to read in bookmarks from
        //an xml file
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("Bookmarks.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xmlser = new XmlSerializer(typeof(List<Bookmarks>));
                bookmarkList = (List<Bookmarks>)xmlser.Deserialize(fs);                                                              
                fs.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "lab 2");
            }

            foreach (Bookmarks b in bookmarkList)
            {
                UI_BookmarkBox.Items.Add(b);
            }
        }

        //Clicking go button will take user to specified url and put url in combo box
        private void UI_GoButton_Click(object sender, EventArgs e)
        {
            try
            {                                
                UI_WebBrowser.Navigate(UI_AddressCombo.Text);
                
            }
            catch (Exception)
            {
                MessageBox.Show("Could not navigate to page. Check url.", "Lab2", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }

        }

        //When page is finished loading, adds current url to history list
        //unless url already exists within combo box
        private void UI_WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            bool dontAdd = false;
            UI_AddressCombo.Text = UI_WebBrowser.Url.ToString();
            if (UI_AddressCombo.Items.Count > 0)
            {
               foreach (string n in UI_AddressCombo.Items)
                {
                    if ((UI_WebBrowser.Url.ToString()) == n)
                    {
                        dontAdd = true;
                    }
                }
               if (dontAdd != true)
                {
                    UI_AddressCombo.Items.Add(UI_WebBrowser.Url.ToString());
                }
            }
            else
                UI_AddressCombo.Items.Add(UI_WebBrowser.Url.ToString());
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

        //Adds a bookmark
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

        //Clears all bookmarks from session
        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookmarkList.Clear();
            UI_BookmarkBox.Items.Clear();
        }

        //Clears history from address combo box
        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI_AddressCombo.Items.Clear();
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("Bookmarks.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xmlser = new XmlSerializer(typeof(List<Bookmarks>));

                xmlser.Serialize(fs, bookmarkList);

                fs.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lab 2");
            }
        }

        
    }
}
