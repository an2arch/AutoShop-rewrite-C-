using System;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace AutoShop.Models
{
    public class Spare
    {
        [JsonConstructor]
        public Spare(string Name, string Type, uint Amount)
        {
            m_id = currentSpareId++;
            m_name = Name;
            m_type = Type;
            m_amount = Amount;
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

        [JsonIgnore]
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
