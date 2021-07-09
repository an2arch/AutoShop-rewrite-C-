using System;
using System.Runtime.InteropServices;
using System.Linq;
using AutoShop.Models;

namespace AutoShop.Storage
{
    class Storage
    {
        private static Storage instance;
        private State.State state = new State.State();

        private Storage() {
            Account admin = new Account("Admin", "admin", "admin", Account.LevelAccess.Admin);
            state.accounts.Add(admin);
        }

        public static Storage getStorage()
        {
            if (instance == null)
            {
                instance = new Storage();
            }
            return instance;
        }

        public State.State getState()
        {
            return state;
        }

        public State.State dispatch(Action.Action action)
        {
            state = _reduser(action);
            return state;
        }

        private State.State _reduser(Action.Action action)
        {
            State.State nextState = new State.State(state);

            switch(action.type)
            {
                case Action.ActionType.ADD_NEW_ORDER: {
                        GCHandle handle = (GCHandle) action.data;
                        Order newOrder = handle.Target as Order;
                        nextState.orders.Add(newOrder);
                    } break;
                case Action.ActionType.ADD_NEW_SPARE: {
                        GCHandle handle = (GCHandle) action.data;
                        Spare newSpare = handle.Target as Spare;
                        nextState.spares.Add(newSpare);
                    } break;
                case Action.ActionType.ADD_NEW_USER: {
                        GCHandle handle = (GCHandle) action.data;
                        Account newAccount = handle.Target as Account;
                        nextState.accounts.Add(newAccount);
                    } break;
                case Action.ActionType.CLEAR_CURRENT_USER:
                    nextState.currentUser = null;
                    break;
                case Action.ActionType.DELETE_ORDER: {
                    GCHandle handle = (GCHandle) action.data;
                    int id = (int) handle.Target;
                    nextState.orders.Remove(
                        nextState.orders.Single(
                            (Order order) => order.Id == id
                            )
                        );
                    }
                    break;
                case Action.ActionType.DELETE_SPARE: {
                    GCHandle handle = (GCHandle) action.data;
                    int id = (int) handle.Target;
                    nextState.spares.Remove(
                        nextState.spares.Single(
                            (Spare spare) => spare.Id == id
                            )
                        );
                    } break;
                case Action.ActionType.DELETE_USER: {
                    GCHandle handle = (GCHandle) action.data;
                    int id = (int) handle.Target;
                    nextState.accounts.Remove(
                        nextState.accounts.Single(
                            (Account account) => account.Id == id
                            )
                        );
                        
                    } break;
                case Action.ActionType.EDIT_ORDER:
                    for (int i = 0; i < nextState.orders.Count; ++i)
                    {
                        GCHandle handle = (GCHandle) action.data;
                        Order editOrder = handle.Target as Order;
                        if (nextState.orders[i].Id == editOrder.Id)
                        {
                            nextState.orders[i] = editOrder;
                            break;
                        }
                    }
                    break;
                case Action.ActionType.EDIT_SPARE:
                    for (int i = 0; i < nextState.spares.Count; ++i)
                    {
                        GCHandle handle = (GCHandle) action.data;
                        Spare editSpare = handle.Target as Spare;
                        if (nextState.spares[i].Id == editSpare.Id)
                        {
                            nextState.spares[i] = editSpare;
                            break;
                        }
                    }
                    break;
                case Action.ActionType.EDIT_USER:
                    for (int i = 0; i < nextState.accounts.Count; ++i)
                    {
                        GCHandle handle = (GCHandle) action.data;
                        Account editAccount = handle.Target as Account;
                        if (nextState.accounts[i].Id == editAccount.Id)
                        {
                            nextState.accounts[i] = editAccount;
                            break;
                        }
                    }
                    break;
                case Action.ActionType.SET_CURRENT_USER: {
                    GCHandle handle = (GCHandle) action.data;
                    nextState.currentUser = handle.Target as Account;
                    } break;
                default:
                    break;
            }

            return nextState;
        }
    }
}
