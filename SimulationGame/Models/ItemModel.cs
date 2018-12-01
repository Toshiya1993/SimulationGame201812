using SimulationGame.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGame.Models
{
    /// <summary>
    /// 商品モデルクラス
    /// </summary>
    class ItemModel
    {
        /// <summary>
        /// 指定数の商品を作成
        /// </summary>
        /// <returns></returns>
        public List<ItemEntity> CreateItems(int itemCount)
        {
            var items = new List<ItemEntity>();

            for(int i=0; i< itemCount; i++)
            {
                int id;
                string name;
                long price;

                this.GenerationRandomItemStatus(out id, out name, out price);
                
                items.Add(this.Create(id, name, price));
            }

            return items;
        }

        /// <summary>
        /// 新規商品作成
        /// </summary>
        /// <param name="id">商品ID</param>
        /// <param name="price">値段</param>
        /// <returns>新規商品</returns>
        private ItemEntity Create(int id, string name, long price)
        {
            return new ItemEntity(id, name, price);
        }

        // HACK: このクラスにあるべき機能ではないが、いったんランダム生成をしたいため設置
        // TODO: 商品生成の機能が充実したら削除
        /// <summary>
        /// 商品情報をランダムに生成
        /// </summary>
        /// <param name="id">商品ID</param>
        /// <param name="name">商品名</param>
        /// <param name="price">値段</param>
        private void GenerationRandomItemStatus(out int id, out string name, out long price)
        {
            // 5種類の商品のうちランダムに1商品のステータスを返す
            var rnd = new Random(this.CreateRandomSeed());
            int itemNumber = rnd.Next(0, 4);

            switch (itemNumber)
            {
                case 0:
                    id = 1;
                    name = "雑草";
                    price = 1;
                    break;
                case 1:
                    id = 2;
                    name = "草鞋";
                    price = 100;
                    break;
                case 2:
                    id = 3;
                    name = "石ころ";
                    price = 5;
                    break;
                case 3:
                    id = 4;
                    name = "半纏";
                    price = 200;
                    break;
                case 4:
                    id = 5;
                    name = "アイドルのブロマイド";
                    price = 1000;
                    break;
                default:
                    id = 152;
                    name = "けつばん";
                    price = 65535;
                    break;
            }
        }

        // HACK: このクラスにあるべき機能ではないが、いったんランダム生成をしたいため設置
        // TODO: 商品生成の機能が充実したら削除
        /// <summary>
        /// ランダムな値を取得しシード値（int型）として返す
        /// </summary>
        /// <returns>シード値</returns>
        private int CreateRandomSeed()
        {
            var bs = new byte[4];

            // Int32サイズのバイト配列にランダムな値を設定する
            using (var rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
            {
                rng.GetBytes(bs);
            }

            return BitConverter.ToInt32(bs, 0);
        }
    }
}
