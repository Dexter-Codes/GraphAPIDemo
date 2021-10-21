using System;
namespace GraphAPIDemo.Model
{
    public enum MenuItemType
    {
        Welcome,
        Calendar,
        NewEvent
    }

    public class NavMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
