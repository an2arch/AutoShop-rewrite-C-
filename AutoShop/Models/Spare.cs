using System;
using System.ComponentModel;

namespace AutoShop.Models
{
    public class Spare
    {
        public Spare(string name, string type, uint amount)
        {
            m_id = currentSpareId++;
            m_name = name;
            m_type = type;
            m_amount = amount;
        }

        public Spare(uint id, string name, string type, uint amount)
        {
            m_id = id;
            m_name = name;
            m_type = type;
            m_amount = amount;
        }

        public class SpareList : BindingList<Spare> { };

        public static uint currentSpareId = 0;

        private uint m_id;
        private string m_name;
        private string m_type;
        private uint m_amount;

        public uint Id
        {
            get { return m_id;  }
            set { m_id = value; }
        }
        public string Name
        {
            get { return m_name;  }
            set { m_name = value; }
        }
        public string Type
        {
            get { return m_type;  }
            set { m_type = value; }
        }
        public uint Amount
        {
            get { return m_amount;  }
            set { m_amount = value; }
        }
    }
}
