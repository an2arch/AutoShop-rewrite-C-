using System;
using System.Runtime.InteropServices;
using System.Linq;

using AutoShop.Storage.Action;
using AutoShop.Storage.State;
using AutoShop.Models;

namespace AutoShop.Utility
{
    static public class AccountUtility {
        static private Storage.Storage storage = Storage.Storage.getStorage();
        public static bool Auth(string login, string password)
        {
            foreach (Account account in storage.getState().accounts)
            {
                if (account.Login == login && account.Password == password)
                {
                    GCHandle handle = GCHandle.Alloc(account);
                    IntPtr accPtr = (IntPtr) handle;
                    storage.dispatch(new Storage.Action.Action(
                        ActionType.SET_CURRENT_USER,
                        accPtr
                        ));
                    handle.Free();
                    return true;
                }
            }
            return false;
        }

        public static bool Register(string name, string login, string password)
        {
            foreach (Account account in storage.getState().accounts)
            {
                if (account.Login == login)
                {
                    return false;
                }
            }

            Account newAccount = new Account(name, login, password, Account.LevelAccess.Employee);
            GCHandle handle = GCHandle.Alloc(newAccount);
            IntPtr accPtr = (IntPtr) handle;

            storage.dispatch(new Storage.Action.Action(
                ActionType.ADD_NEW_USER,
                accPtr
                ));
            storage.dispatch(new Storage.Action.Action(
                ActionType.SET_CURRENT_USER,
                accPtr
                ));
            handle.Free();

            return true;
        }
        
        public static bool addAccountToStorage(string name, 
                                               string login, 
                                               string password, 
                                               Account.LevelAccess access)
        {
            foreach (Account acc in storage.getState().accounts)
            {
                if (acc.Login == login)
                {
                    return false;
                }
            }

            Account account = new Account(name, login, password, access);
            GCHandle handle = GCHandle.Alloc(account);
            IntPtr accPtr = (IntPtr) handle;
            storage.dispatch(new Storage.Action.Action(
                ActionType.ADD_NEW_USER,
                accPtr
                ));
            handle.Free();
            return true;
        }

        public static bool editAccountInStorage(uint id, 
                                                string name, 
                                                string login, 
                                                string password, 
                                                Account.LevelAccess access)
        {
            if (!storage.getState().accounts.Any((Account account) => account.Id == id))
            {
                return false;
            }

            Account editAccount = new Account(id, name, login, password, access);

            GCHandle handle = GCHandle.Alloc(editAccount);
            IntPtr accPtr = (IntPtr) handle;

            storage.dispatch(new Storage.Action.Action(
                ActionType.EDIT_USER,
                accPtr
                ));

            handle.Free();

            return true;
        }

        public static void deleteAccountFromStorage(int id)
        {
            GCHandle handle = GCHandle.Alloc(id);
            IntPtr idPtr = (IntPtr) handle;
            storage.dispatch(new Storage.Action.Action(
                ActionType.DELETE_USER,
                idPtr
                ));
            handle.Free();
        }
    }

    static public class OrderUtility
    {
        static private Storage.Storage storage = Storage.Storage.getStorage();

        static public void addOrderToStorage(string type, string description)
        {
            Order newOrder = new Order(type, description, false);
            GCHandle handle = GCHandle.Alloc(newOrder);
            IntPtr orderPtr = (IntPtr) handle;
            storage.dispatch(new Storage.Action.Action(
                ActionType.ADD_NEW_ORDER,
                orderPtr
                ));
            handle.Free();
        }

        static public void editOrderInStorage(uint id, string type, string description, bool completed)
        {
            Order editOrder = new Order(id, type, description, completed);
            GCHandle handle = GCHandle.Alloc(editOrder);
            IntPtr orderPtr = (IntPtr) handle;
            storage.dispatch(new Storage.Action.Action(
                ActionType.EDIT_ORDER,
                orderPtr
                ));
            handle.Free();
        }

        static public void completeOrder(uint id)
        {
            var orders = storage.getState().orders;
            Order orderToComplete = orders.Single((Order order) => order.Id == id);
            orderToComplete.IsCompleted = true;
        }

        static public void deleteOrderFromStorage(int id)
        {
            GCHandle handle = GCHandle.Alloc(id);
            IntPtr idPtr = (IntPtr) handle;
            storage.dispatch(new Storage.Action.Action(
                ActionType.DELETE_ORDER,
                idPtr
                ));
            handle.Free();
        }
    }

    static public class SpareUtility
    {
        static private Storage.Storage storage = Storage.Storage.getStorage();

        static public void addSpareToStorage(string name, string type, uint amount)
        {
            Spare newSpare = new Spare(name, type, amount);
            GCHandle handle = GCHandle.Alloc(newSpare);
            IntPtr sparePtr = (IntPtr) handle;

            storage.dispatch(new Storage.Action.Action(
                ActionType.ADD_NEW_SPARE,
                sparePtr
                ));

            handle.Free();
        }

        static public void editSpareToStorage(uint id, string name, string type, uint amount)
        {
            Spare editSpare = new Spare(id, name, type, amount);
            GCHandle handle = GCHandle.Alloc(editSpare);
            IntPtr sparePtr = (IntPtr) handle;
            storage.dispatch(new Storage.Action.Action(
                ActionType.EDIT_SPARE,
                sparePtr
                ));
            handle.Free();
        }

        static public void deleteSpareFromStorage(int id)
        {
            GCHandle handle = GCHandle.Alloc(id);
            IntPtr idPtr = (IntPtr) handle;
            storage.dispatch(new Storage.Action.Action(
                ActionType.DELETE_SPARE,
                idPtr
                ));
            handle.Free();
        }
    }
}
