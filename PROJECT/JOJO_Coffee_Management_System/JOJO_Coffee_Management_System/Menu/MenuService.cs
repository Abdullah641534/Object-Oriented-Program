using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOJO_Coffee_Management_System.Menu
{
    class MenuService
    {
        private MenuRepo _repo;
        private List<MenuModel> _menuItems;

        public MenuService(MenuRepo repo)
        {
            _repo = repo;
            _menuItems = _repo.LoadMenu();
        }

        public List<MenuModel> GetAllItems()
        {
            return _menuItems;
        }

        public MenuModel GetItemById(int id)
        {
            for (int i = 0; i < _menuItems.Count; i++)
            {
                if (_menuItems[i].Id == id)
                {
                    return _menuItems[i];
                }
            }
            return null;
        }

        public MenuModel SearchItem(string name)
        {
            for (int i = 0; i < _menuItems.Count; i++)
            {
                if (_menuItems[i].ItemName.ToLower() == name.ToLower())
                {
                    return _menuItems[i];
                }
            }
            return null;
        }

        public void AddItem(string name, int price)
        {
            int newId = _menuItems.Count + 1;
            MenuModel newItem = new MenuModel(newId, name, price);
            _menuItems.Add(newItem);
            _repo.SaveMenu(_menuItems);
        }

        public void UpdatePrice(int id, int newPrice)
        {
            MenuModel item = GetItemById(id);
            if (item != null)
            {
                item.Price = newPrice;
                _repo.SaveMenu(_menuItems);
            }
        }

        public void DeleteItem(int id)
        {
            MenuModel item = GetItemById(id);
            if (item != null)
            {
                _menuItems.Remove(item);
                for (int i = 0; i < _menuItems.Count; i++)
                {
                    _menuItems[i].Id = i + 1;
                }

                _repo.SaveMenu(_menuItems);
            }
        }

        public void ResetMenu()
        {
            _menuItems.Clear();
            _repo.SaveMenu(_menuItems);
        }
    }
}
