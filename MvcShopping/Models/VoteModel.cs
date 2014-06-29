using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcShopping.Models
{
    public class VoteModel
    {
        public List<VoteItem> Items;
        public VoteModel()
        {
            this.Items = new List<VoteItem>();
        }
    }
    //投票のデータクラス
    public class VoteItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Item { get; set; }
        public string Comment { get; set; }
    }
}
