using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace ManagersNotepadAppication
{
    public partial class NotePadForm : Form
    {
        private const string InitCategoryName = "<Category>";
        private const string InitMemoSubject = "<Memo>";

        private static bool isSaved = true;

        public NotePadForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream stream = null;

            try
            {
                stream = new FileStream(@"manager_notes.dat", FileMode.Open, FileAccess.ReadWrite);
                BinaryFormatter serialize = new BinaryFormatter();

                //If there is data in the file, deserialize the data
                //If deserialize fails, an exception is thrown
                Category c = (Category)serialize.Deserialize(stream);
                int index = 0;

                foreach (Memo m in c.Memos)
                {
                    hierarchicalTree.Nodes[index].Tag = c;
                    hierarchicalTree.Nodes[index].Text = m.Subject;
                    index++;
                }

                hierarchicalTree.Nodes[0].Tag = c;
                hierarchicalTree.Nodes[0].Text = c.Name;
                stream.Flush();
                stream.Close();
            }

            //If there is no data in the file, serialize the data
            catch (Exception)
            { 
                if (stream != null)
                    stream.Close();
                //create initial root category
                hierarchicalTree.Nodes[0].Tag = new Category() { Name = "Main" };
                hierarchicalTree.Nodes[0].Text = "Main";
                serializeData();
            }
            Category rootCategory = hierarchicalTree.Nodes[0].Tag as Category;
            
            //Builds the tree view from the serialized data
            repopHierarchicalView(rootCategory, hierarchicalTree.Nodes[0]);

            hierarchicalTree.SelectedNode = hierarchicalTree.Nodes[0];
            hierarchicalTree.ExpandAll();

            toolStripDeleteMessage.Visible = false;
            toolStripDeleteCategory.Visible = false;

            fontComboBox.ComboBox.DisplayMember = "Name";

            InstalledFontCollection installedFonts = new InstalledFontCollection();
            foreach (FontFamily family in installedFonts.Families)
            {
                //if (family.Name == "Aharoni")
                //    fontComboBox.Items.Remove(family.Name);
                //fontComboBox.Items.Add(family);
            }

            propertyGrid1.ToolbarVisible = false;
            propertyGrid1.HelpVisible = false;
            //fontComboBox.SelectedIndex = 0;
            sizeComboBox.SelectedIndex = 2;
        }



        private void repopHierarchicalView(Category category, TreeNode node)
        {
            //while category Memos is not null, find each memo and add to the treenode collection
            foreach (Memo m in category.Memos)
            {
                TreeNode currentMemoNode = node.Nodes.Add(m.Subject);
                currentMemoNode.Tag = m;
            }

            //while category Categories is not null, find each Category and add to the treenode collection
            foreach (Category childCategory in category.Categories)
            {
                TreeNode currentCategoryNode = node.Nodes.Add(childCategory.Name);
                currentCategoryNode.Tag = childCategory;

                repopHierarchicalView(childCategory, currentCategoryNode);
            }
            //isSaved is set to true again because everything repopulated has been saved
            //so no real changes have been made until text_change event is called
            isSaved = true;
        }

        private void hierarchicalTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //whatever node is selected, the selected node's properties are displayed
            //by the property grid
            propertyGrid1.SelectedObject = e.Node.Tag;

            //===============================================================
            //Visible properties are set depending on what node is clicked on
            //===============================================================
            toolStripAddMessage.Visible = true;
            toolStripAddCategory.Visible = true;
            toolStripDeleteMessage.Visible = true;
            toolStripDeleteCategory.Visible = true;

            if (e.Node.Tag is Category)
            {
                toolStripDeleteMessage.Visible = false;

                if (e.Node.Tag.Equals(hierarchicalTree.Nodes[0].Tag))
                    toolStripDeleteCategory.Visible = false;
                Category cat = e.Node.Tag as Category;
                textEditor.Rtf = cat.Description;

            }
            else if (e.Node.Tag is Memo)
            {
                toolStripAddMessage.Visible = false;
                toolStripDeleteCategory.Visible = false;
                toolStripAddCategory.Visible = false;
                Memo mem = e.Node.Tag as Memo;
                textEditor.Rtf = mem.MemoText;
            }

        }

        private void hierarchicalTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // If the left or right mouse is clicked we 
            // have to make sure that the node get selected
            // because a simple right click will only display
            // the context menu and if the node has not already
            // been selected then the context menu event handler
            // might act on the the wrong node.
            hierarchicalTree.SelectedNode = e.Node;
        }

        private void toolStripAddCategory_Click(object sender, EventArgs e)
        {
            toolStripDeleteCategory.Visible = true;
            TreeNode currentNode = hierarchicalTree.SelectedNode;

            if (currentNode.Tag is Category)
            {
                Category currentCategory = currentNode.Tag as Category;
                Category newCategory = new Category();

                //Initialize the category Name field with a string
                newCategory.Name = InitCategoryName;
                currentCategory.Categories.Add(newCategory);
                newCategory.Parent = currentCategory;

                //Add a tree node to the TreeNode collection
                TreeNode newNode = currentNode.Nodes.Add(newCategory.Name);
                
                //set a new category to the node's tag
                newNode.Tag = newCategory;
                currentNode.Expand();
                hierarchicalTree.SelectedNode = newNode;
                newNode.BeginEdit();

                serializeData();
            }
        }

        private void toolStripAddMessage_Click(object sender, EventArgs e)
        {
            toolStripDeleteMessage.Visible = true;
            TreeNode currentNode = hierarchicalTree.SelectedNode;

            Category currentCategory = currentNode.Tag as Category;
            Memo newMemo = new Memo();

            //Initialize the memo Subject field with a string
            newMemo.Subject = InitMemoSubject;
            currentCategory.Memos.Add(newMemo);
            newMemo.Parent = currentCategory;

            //Add a tree node to the TreeNode collection
            TreeNode newNode = currentNode.Nodes.Add(newMemo.Subject);

            //set new memo to the node's tag
            newNode.Tag = newMemo;
            currentNode.Expand();
            hierarchicalTree.SelectedNode = newNode;
            newNode.BeginEdit();

        }

        private void toolStripDeleteCategory_Click(object sender, EventArgs e)
        {
            TreeNode currentNode = hierarchicalTree.SelectedNode;
            Category currentCategory = currentNode.Tag as Category;

            TreeNode parentNode = currentNode.Parent;
            Category parentCategory = parentNode.Tag as Category;

            //Delete current Category selected from the Category list
            parentCategory.Categories.Remove(currentCategory);

            //Delete the current selected node from the TreeNode collection
            currentNode.Remove();
        }

        private void toolStripDeleteMessage_Click(object sender, EventArgs e)
        {

            if (textEditor.Rtf.Length > 0)
            {
                DialogResult deleteNode = MessageBox.Show("Are you sure you want to delete" + hierarchicalTree.SelectedNode.Text,
                "Delete Message?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult.No == deleteNode)
                    return;
            }   

            TreeNode currentNode = hierarchicalTree.SelectedNode;
            Memo currentMemo = currentNode.Tag as Memo;


            TreeNode parentNode = currentNode.Parent;
            Category parentMemo = parentNode.Tag as Category;

            //Delete memo clicked on from the Memos list
            parentMemo.Memos.Remove(currentMemo);

            //Delete the node from the treenode collection
            currentNode.Remove();
            serializeData();
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            TreeNode currentNode = hierarchicalTree.SelectedNode;

            if (currentNode.Tag is Category)
            {
                Category currentCategory = currentNode.Tag as Category;
                currentNode.Text = currentCategory.Name;
                
            }
            if (currentNode.Tag is Memo)
            {
                Memo currentMemo = currentNode.Tag as Memo;
                currentNode.Text = currentMemo.Subject;
            }

            propertyGrid1.Refresh();
            serializeData();
        }

        private void serializeData()
        {
            //every time a node is added, the file is overwritten yet keeps the previous written objects
            FileStream stream = new FileStream(@"manager_notes.dat", FileMode.Create, FileAccess.ReadWrite);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, hierarchicalTree.Nodes[0].Tag);

            stream.Flush();
            stream.Close();
        }

        private void selectFont(int index)
        {
            float fontSize = default(float);

            // If a font size is not selected 
            // then get the font size from the
            // current selected area on the editor
            if (sizeComboBox.SelectedIndex != -1)
                fontSize = float.Parse(sizeComboBox.SelectedItem.ToString());
            else
                fontSize = textEditor.SelectionFont.Size;

            FontFamily fontFam = (FontFamily)fontComboBox.Items[index];

            // This protocol allows us to have nothing
            // selected but still start a new font or 
            // font size from the current editing point
            // <begin protocol>
            int nOriginalSelectionLength = textEditor.SelectionLength;
            int nOriginalSelectionStart = textEditor.SelectionStart;
            if (nOriginalSelectionLength == 0)
                textEditor.SelectionLength = 1;

            textEditor.SelectionFont = new Font(fontFam.Name, fontSize);

            if (0 < nOriginalSelectionStart)
                textEditor.SelectionStart = nOriginalSelectionStart - 1;
            // <end protocol>

        }

        private void selectSize(int index)
        {
            String selectedFont = fontComboBox.SelectedItem.ToString();
            switch (index)
            {
                case 0:
                    textEditor.SelectionFont = new Font(selectedFont, 8);
                    break;
                case 1:
                    textEditor.SelectionFont = new Font(selectedFont, 9);
                    break;
                case 2:
                    textEditor.SelectionFont = new Font(selectedFont, 10);
                    break;
                case 3:
                    textEditor.SelectionFont = new Font(selectedFont, 11);
                    break;
                case 4:
                    textEditor.SelectionFont = new Font(selectedFont, 12);
                    break;
                case 5:
                    textEditor.SelectionFont = new Font(selectedFont, 14);
                    break;
                case 6:
                    textEditor.SelectionFont = new Font(selectedFont, 16);
                    break;
                case 7:
                    textEditor.SelectionFont = new Font(selectedFont, 18);
                    break;
                case 8:
                    textEditor.SelectionFont = new Font(selectedFont, 20);
                    break;
                case 9:
                    textEditor.SelectionFont = new Font(selectedFont, 22);
                    break;
                case 10:
                    textEditor.SelectionFont = new Font(selectedFont, 24);
                    break;
                case 11:
                    textEditor.SelectionFont = new Font(selectedFont, 26);
                    break;
                case 12:
                    textEditor.SelectionFont = new Font(selectedFont, 28);
                    break;
                case 13:
                    textEditor.SelectionFont = new Font(selectedFont, 36);
                    break;
                case 14:
                    textEditor.SelectionFont = new Font(selectedFont, 48);
                    break;
                case 15:
                    textEditor.SelectionFont = new Font(selectedFont, 72);
                    break;
                default:
                    break;
            }
        }

        private void fontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sizeComboBox.SelectedIndex != -1)
                sizeComboBox.SelectedIndex = 0;

            this.selectFont(fontComboBox.SelectedIndex);
        }

        private void sizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selectSize(sizeComboBox.SelectedIndex);
        }

        #region Tool Strip Buttons
        private void boldButton_Click(object sender, EventArgs e)
        {
            Bitmap map = ManagersNotepadAppication.Properties.Resources.ToolStripItalic;
            Console.WriteLine(map.Size.Width);
            Console.WriteLine(map.Size.Height);

            if (textEditor.SelectionLength > 0)
            {
                if (!textEditor.SelectionFont.Bold)
                    textEditor.SelectionFont = new Font(new Font(fontComboBox.SelectedItem.ToString(),
                        float.Parse(sizeComboBox.SelectedItem.ToString())), FontStyle.Bold);
                else
                    textEditor.SelectionFont = new Font(new Font(fontComboBox.SelectedItem.ToString(),
                        float.Parse(sizeComboBox.SelectedItem.ToString())), FontStyle.Regular);
            }
        }

        private void italicButton_Click(object sender, EventArgs e)
        {
            if (!textEditor.SelectionFont.Italic)
                textEditor.SelectionFont = new Font(new Font(fontComboBox.SelectedItem.ToString(),
                    float.Parse(sizeComboBox.SelectedItem.ToString())), FontStyle.Italic);
            else
                textEditor.SelectionFont = new Font(new Font(fontComboBox.SelectedItem.ToString(),
                    float.Parse(sizeComboBox.SelectedItem.ToString())), FontStyle.Regular );
        }

        private void underlineButton_Click(object sender, EventArgs e)
        {
            if (!textEditor.SelectionFont.Underline)
                textEditor.SelectionFont = new Font(new Font(fontComboBox.SelectedItem.ToString(),
                    float.Parse(sizeComboBox.SelectedItem.ToString())), FontStyle.Underline);
            else
                textEditor.SelectionFont = new Font(new Font(fontComboBox.SelectedItem.ToString(),
                    float.Parse(sizeComboBox.SelectedItem.ToString())), FontStyle.Regular);
        }

        private void bulletsButton_Click(object sender, EventArgs e)
        {
            textEditor.SelectionBullet = true;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            serializeData();
            isSaved = true;
        }

        private void alignLeftButton_Click(object sender, EventArgs e)
        {
            textEditor.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void alignCenterButton_Click(object sender, EventArgs e)
        {
            textEditor.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void alignRightButton_Click(object sender, EventArgs e)
        {
            textEditor.SelectionAlignment = HorizontalAlignment.Right;
        }
#endregion

        private void textEditor_TextChanged(object sender, EventArgs e)
        {
            isSaved = false;

            TreeNode currentNode = hierarchicalTree.SelectedNode;
            if (currentNode == null)
            {
                isSaved = true; 
                return;
            }
            if (currentNode.Tag is Category)
            {
                Category cat = currentNode.Tag as Category;
                cat.Description = textEditor.Rtf;             
            }
            if (currentNode.Tag is Memo)
            {   
                Memo mem = currentNode.Tag as Memo;
                mem.MemoText = textEditor.Rtf;
            }
        }
       

        private void hierarchicalTree_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Node.Tag is Category)
            {
                ((Category)e.Node.Tag).Name = e.Label;
                propertyGrid1.Refresh();
            }
            else if (e.Node.Tag is Memo)
            {
                ((Memo)e.Node.Tag).Subject = e.Label;
                propertyGrid1.Refresh();
            }
        }
        #region Drag and Drop
        private void hierarchicalTree_ItemDrag(object sender, ItemDragEventArgs e)
        {
            Console.WriteLine("ItemDrag");
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void hierarchicalTree_DragEnter(object sender, DragEventArgs e)
        {
            Console.WriteLine("DragEnter");
            e.Effect = DragDropEffects.Move;
        }

        private void hierarchicalTree_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;

            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false))
            {
                Point pt = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));
                TreeNode DestinationNode = ((TreeView)sender).GetNodeAt(pt);
                NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");
                if (!(DestinationNode.Tag is Memo && NewNode.Tag is Memo))
                {
                    if (!(DestinationNode.Parent == NewNode))
                    {
                        Category parent = null;

                        if (NewNode.Tag is Memo)
                        {
                            Memo theMemo = NewNode.Tag as Memo;
                            parent = theMemo.Parent;
                            Category targetParent = DestinationNode.Tag as Category;
                            targetParent.Memos.Add(theMemo);
                            theMemo.Parent = targetParent;
                            parent.Memos.Remove(theMemo);
                        }
                        else if (NewNode.Tag is Category)
                        {
                            Category theCategory = NewNode.Tag as Category;
                            parent = theCategory.Parent;
                            Category targetParent = DestinationNode.Tag as Category;
                            targetParent.Categories.Add(theCategory);
                            theCategory.Parent = targetParent;
                            parent.Categories.Remove(theCategory);
                        }
                        
                        // Save the new structure
                        serializeData();

                        DestinationNode.Nodes.Add((TreeNode)NewNode.Clone());
                        DestinationNode.Expand();
                        //Remove Original Node
                        NewNode.Remove();
                    }
                }
            }

        }
        #endregion

        #region Font color handlers

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripDropDownItem item = sender as ToolStripDropDownItem;
            if (item.Text == "Black")
                textEditor.SelectionColor = Color.Black;
        }

        private void maroonMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.SelectionColor = Color.Maroon;
        }

        private void greenMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.SelectionColor = Color.Green;
        }

        private void oliveMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.SelectionColor = Color.Olive;
        }

        private void navyMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.SelectionColor = Color.Navy;
        }

        private void purpleMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.SelectionColor = Color.Purple;
        }

        private void tealMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.SelectionColor = Color.Teal;
        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.SelectionColor = Color.Gray;
        }

        private void redMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.SelectionColor = Color.Red;
        }

        private void limeMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.SelectionColor = Color.Lime;
        }

        private void yellowMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.SelectionColor = Color.Yellow;
        }

        private void blueMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.SelectionColor = Color.Blue;
        }

        private void fuchshiaMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.SelectionColor = Color.Fuchsia;
        }

        private void aquaMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.SelectionColor = Color.Aqua;
        }

        private void whiteMenuItem_Click(object sender, EventArgs e)
        {
            textEditor.SelectionColor = Color.White;
        }

        #endregion


        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(hierarchicalTree.SelectedNode.Tag);
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            Clipboard.GetData("TreeNode");
            Clipboard.Clear();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSaved)
            {
                //DialogResult msg = MessageBox.Show("Do you want to save the changes to " + this.Text + "?", "Save changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                
                //if (msg == DialogResult.Yes)
                //    serializeData();
                //else if (msg == DialogResult.Cancel)
                //    e.Cancel = true;
            }
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            helpToolStripButton.Visible = false;
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            newToolStripButton.Visible = false;
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openToolStripButton.Visible = false;
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void hierarchicalTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            hierarchicalTree.LabelEdit = true;

            TreeNode currentNode = hierarchicalTree.SelectedNode;

            if (!currentNode.IsEditing)
            {
                currentNode.BeginEdit();
            }

        }
  



   

       
    }
}
