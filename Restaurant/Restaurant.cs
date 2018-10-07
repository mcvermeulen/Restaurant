using System;
using System.Collections.Generic;

namespace Restaurant
{
    public class Restaurant
    {
        private String name;
        private List<Cook> cooks;


        public Restaurant(String name)
        {
            this.name = name;
            cooks = new List<Cook>();
        }

        public void addCook(Cook cook)
        {
            cooks.Add(cook);
        }

        public void removeAllCooksWithPreparationType(String preparation)
        {
            cooks.RemoveAll((Cook cook) => cook.getPreparation().getName().Equals(preparation));
        }

        public void prepareCooks()
        {
            foreach (Cook c in cooks)
            {
                c.prepare();
            }
        }

        public void replaceExistingCookWithNewCook(Cook leavingCook, String name)
        {
            Cook newCook = new Cook(name, leavingCook.getPreparation());
            cooks.Add(newCook);
            cooks.Remove(leavingCook);
        }
    }
}
