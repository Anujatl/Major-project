using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regression
{
    public delegate void ApplyChanges(object sender, Dictionary<string, int> e);
    public partial class frmWords : Form
    {
        public event ApplyChanges OnApplyChanges;
        protected virtual void OnApplyChangesRaise(Dictionary<string, int> e)
        {
            if (OnApplyChanges != null)
                OnApplyChanges(this, e);
        }

        Dictionary<string, int> wordDictionary;

        public frmWords(Dictionary<string, int> wordDictionary)
        {
            InitializeComponent();
            this.wordDictionary = wordDictionary;
        }
        public frmWords()
        {
            InitializeComponent();
        }

        private void frmWords_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, int> pair in wordDictionary)
            {
                ListViewItem item = new ListViewItem();
                item.Text = pair.Key;
                System.Windows.Forms.ListViewItem.ListViewSubItem subItem = new System.Windows.Forms.ListViewItem.ListViewSubItem();
                subItem.Text = pair.Value.ToString();
                item.SubItems.Add(subItem);

                listView1.Items.Add(item);
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                int itemToDelete = item.Index;
                string key = item.Text;

                listView1.Items[itemToDelete].Remove();

                wordDictionary.Remove(key);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnApplyChangesRaise(wordDictionary);
            this.Dispose();
        }
    }
}
