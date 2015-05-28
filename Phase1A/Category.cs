using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;


namespace ManagersNotepadAppication
{
    [Serializable]
    class Category
    {
        private List<Memo> m_memos = new List<Memo>();
        private List<Category> m_categories = new List<Category>();
        private string m_strName = string.Empty;
        private string m_description = string.Empty;
        private WeakReference m_parent = new WeakReference(null);

        public string Name
        {
            get { return m_strName; }
            set { m_strName = value; }
        }

        [Browsable(false)]
        public List<Memo> Memos
        {
            get { return m_memos; }
        }

        [Browsable(false)]
        public List<Category> Categories
        {
            get { return m_categories; }
        }

        [Browsable(false)]
        public string Description
        {
            get { return m_description; }
            set { m_description = value; }
        }

        [Browsable(false)]
        public Category Parent
        {
            get { return m_parent.Target as Category; }
            set { m_parent.Target = value;            }
        }
    }
}
