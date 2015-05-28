using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;


namespace ManagersNotepadAppication
{
    
    public enum MemoImportance
    {
        Low = 1,
        Medium = 2,
        High = 3,
        Critical = 4
    }

    [Serializable]
    class Memo
    {
        private DateTime m_lastUpdate = DateTime.Now;
        private string m_strMemoText = string.Empty;
        private MemoImportance m_importance = MemoImportance.Low;
        private string m_Subject = string.Empty;
        private WeakReference m_parent = new WeakReference(null);

        public DateTime LastUpdate
        {
            get { return m_lastUpdate; }
        }

        [Browsable(false)]       
        public string MemoText
        {
            get { return m_strMemoText; }
            set
            {
                m_strMemoText = value;
                m_lastUpdate = DateTime.Now;
            }
        }

        public MemoImportance Importance
        {
            get { return m_importance; }
            set 
            { 
                m_importance = value;
                m_lastUpdate = DateTime.Now; 
            }
        }

        public string Subject
        {
            get { return m_Subject; }
            set { m_Subject = value; }
        }

        [Browsable(false)]
        public Category Parent
        {
            get { return m_parent.Target as Category; }
            set { m_parent.Target = value; }
        }

    }
}
