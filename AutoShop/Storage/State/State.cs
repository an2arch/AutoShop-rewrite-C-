using AutoShop.Models;

namespace AutoShop.Storage.State
{
    class State
    {
        public State()
        {
            currentUser = null;
            accounts = new Account.AccountList();
            orders = new Order.OrderList();
            spares = new Spare.SpareList();
        }
        
        public State(State s)
        {
            currentUser = s.currentUser;
            accounts = s.accounts;
            orders = s.orders;
            spares = s.spares;
        }

        public Account currentUser;
        public Account.AccountList accounts = new Account.AccountList();
        public Order.OrderList orders = new Order.OrderList();
        public Spare.SpareList spares = new Spare.SpareList();
    }
}
