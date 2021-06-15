using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Founctions
    {
        private List<Costs> costsArray;
        public void AddNewExp(string date, string expOrRev, string category, decimal amount)
        {
            Costs tmpCost = new Costs(date, expOrRev, category, amount);
            if (tmpCost.Date != "0")
                costsArray.Add(tmpCost);
        }

        public void ShowExpInCat()
        {

        }

        public void SearchCosts(string s)
        {

        }

        public void DeleteDatas(int n)
        {

        }

        public void SortDate()
        {

        }

        public void NormalizeDescrip()
        {

        }
    }
}
