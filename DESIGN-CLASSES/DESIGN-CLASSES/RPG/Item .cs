using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGN_CLASSES.RPG
{
    public class Item
    {
        public enum typeIthem { Меч = 1, Щит , Дубина};
        private typeIthem _items;
      
        double mass { get; set; }
        int gold { get; set; }

        public typeIthem Weapon(int item)
        {
            this._items = (typeIthem)item;
            return _items;
        }
    }
}
