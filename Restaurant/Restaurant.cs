using System;
using System.Collections.Generic;

namespace Restaurant
{
    public class Restaurant
    {
        private readonly String name;
        private readonly List<Cook> cooks;


        public Restaurant(String name)
        {
            this.name = name;
            cooks = new List<Cook>();
        }

        public void AddCook(Cook cook)
        {
            cooks.Add(cook);
        }

        public void RemoveAllCooksWithPreparationType(String preparation)
        {
            cooks.RemoveAll((Cook cook) => cook.GetPreparation().GetName().Equals(preparation));
        }

        public void PrepareCooks()
        {
            foreach (Cook c in cooks)
            {
                c.Prepare();
            }
        }

        public void ReplaceExistingCookWithNewCook(Cook leavingCook, String name)
        {
            Cook newCook = new Cook(name, leavingCook.GetPreparation());
            cooks.Add(newCook);
            cooks.Remove(leavingCook);
        }
    }
}
