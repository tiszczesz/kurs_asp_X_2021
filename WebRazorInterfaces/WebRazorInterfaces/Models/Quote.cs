using System;
using System.Collections;
using System.Collections.Generic;
using WebRazorInterfaces.Abstraction;

namespace WebRazorInterfaces.Models {
    public class Quote {
        public IList<DataAbstract> MyQuoties;

        public Quote(IList<DataAbstract> quoties) {
            MyQuoties = quoties;
        }

        public string RandomQuote() {
            DataAbstract myquote = MyQuoties[new Random().Next(MyQuoties.Count)];
            return myquote.GetName();
        }
    }
}