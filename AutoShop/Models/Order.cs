using System;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace AutoShop.Models
{
    public class Order
    {
        [JsonConstructor]
        public Order(string Type, string Description, bool IsCompleted)
        {
            m_id = currentOrderId++;
            m_type = Type;
            m_description = Description;
            m_isCompleted = IsCompleted;
        }

        public Order(uint id, string type, string description, bool completed)
        {
            m_id = id;
            m_type = type;
            m_description = description;
            m_isCompleted = completed;
        }

        public class OrderList : BindingList<Order> {};

        public static uint currentOrderId = 0;

        private uint m_id;
        private string m_type;
        private string m_description;
        private bool m_isCompleted;

        [JsonIgnore]
        public uint Id
        {
            get { return m_id;  }
            set { m_id = value; }
        }
        public string Type
        {
            get { return m_type;  }
            set { m_type = value; }
        }
        public string Description
        {
            get { return m_description;  }
            set { m_description = value; }
        }
        public bool IsCompleted
        {
            get { return m_isCompleted;  }
            set { m_isCompleted = value; }
        }
    }
}
