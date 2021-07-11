using AutoShop.Models;
using System.Text.Json.Serialization;

namespace AutoShop.Storage.State
{
    public class State
    {
        public State()
        {
            currentUser = null;
            accounts = new Account.AccountList();
            orders = new Order.OrderList();
            spares = new Spare.SpareList();
        }
        
        public State(State s) => 
            (currentUser, accounts, orders, spares) = 
                (s.currentUser, s.accounts, s.orders, s.spares);

        [JsonConstructor]
        public State(Account.AccountList Accounts, Order.OrderList Orders, Spare.SpareList Spares) => 
            (accounts, orders, spares) = 
                (Accounts, Orders, Spares);

        [JsonIgnore]
        public Account currentUser { get; set; } = null;

        [JsonPropertyName("Accounts")]
        public Account.AccountList accounts  { get; set; } = new Account.AccountList();
        [JsonPropertyName("Orders")]
        public Order.OrderList orders  { get; set; } = new Order.OrderList();
        [JsonPropertyName("Spares")]
        public Spare.SpareList spares  { get; set; } = new Spare.SpareList();
    }
}
