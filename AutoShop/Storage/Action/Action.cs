using System;

namespace AutoShop.Storage.Action
{
    enum ActionType
    {
        CLEAR_CURRENT_USER,
        SET_CURRENT_USER,

        ADD_NEW_USER,
        EDIT_USER,
        DELETE_USER,

        ADD_NEW_SPARE,
        EDIT_SPARE,
        DELETE_SPARE,

        ADD_NEW_ORDER,
        EDIT_ORDER,
        DELETE_ORDER,
    }

    class Action
    {
        public Action(ActionType newType)
        {
            type = newType;
        }
        public Action(ActionType newType, IntPtr newData)
        {
            type = newType;
            data = newData;
        }

        public ActionType type;
        public IntPtr data;
    }
}
