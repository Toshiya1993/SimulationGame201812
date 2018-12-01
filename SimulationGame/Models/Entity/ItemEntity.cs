using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGame.Models.Entity
{
    /// <summary>
    /// 商品実体クラス
    /// </summary>
    class ItemEntity : ICloneable
    {
        /// <summary>商品ID</summary>
        public int Id { get; private set; }
        /// <summary>商品名</summary>
        public string Name { get; private set; }
        /// <summary>値段</summary>
        public long Price { get; private set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="id">商品ID</param>
        /// <param name="name">商品名</param>
        /// <param name="price">値段</param>
        public ItemEntity(int id, string name, long price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }

        /// <summary>
        /// クローン生成
        /// </summary>
        /// <returns>クローン</returns>
        public object Clone()
        {
            return new ItemEntity(Id, Name, Price);
        }
    }
}
