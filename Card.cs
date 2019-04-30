using System.Drawing;

namespace CardGame {

    class Card {

        #region###フィールド###
        /// <summary>
        /// カードの絵柄
        /// </summary>
        private Image m_image;
        #endregion

        #region###プロパティ###
        /// <summary>
        /// カード名
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// カードの説明文
        /// </summary>
        public string Text { get; }
        /// <summary>
        /// ヒットポイント
        /// </summary>
        public int Hp { get; set; }
        /// <summary>
        /// 攻撃力
        /// </summary>
        public int Atk { get; set; }
        /// <summary>
        /// 防御力
        /// </summary>
        public int Def { get; set; }
        /// <summary>
        /// コスト
        /// </summary>
        public int Cost { get; set; }
        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="name"></param>
        /// <param name="hp"></param>
        /// <param name="atk"></param>
        /// <param name="def"></param>
        /// <param name="cost"></param>
        /// <param name="text"></param>
        /// <param name="image"></param>
        public Card(string name, int hp, int atk, int def, int cost, string text, Image image) {
            Name = name;
            Hp = hp;
            Atk = atk;
            Def = def;
            Cost = cost;
            Text = text;
            m_image = image;
        }

        /// <summary>
        /// 攻撃を受けた際のダメージ計算を行う
        /// </summary>
        public void CalcDamage(Card opponentCard) {
            Hp -= opponentCard.Atk * opponentCard.Atk / Def;
        }
    }
}
