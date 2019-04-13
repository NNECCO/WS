using System.Drawing;

namespace CardGame {

    class Card {

        #region #フィールド#
        /// <summary>
        /// カード名
        /// </summary>
        private string m_name;
        /// <summary>
        /// ヒットポイント
        /// </summary>
        private int m_hp;
        /// <summary>
        /// 攻撃力
        /// </summary>
        private int m_atk;
        /// <summary>
        /// 防御力
        /// </summary>
        private int m_def;
        /// <summary>
        /// コスト
        /// </summary>
        private int m_cost;
        /// <summary>
        /// カードの説明文
        /// </summary>
        private string m_text;
        /// <summary>
        /// カードの絵柄
        /// </summary>
        private Image m_image;
        #endregion

        public Card(string name, int hp, int atk, int def, int cost, string text, Image image) {
            m_name = name;
            m_hp = hp;
            m_atk = atk;
            m_def = def;
            m_cost = cost;
            m_text = text;
            m_image = image;
        }

        /// <summary>
        /// 攻撃を受けた際のダメージ計算を行う
        /// </summary>
        public void CalcDamage(Card opponentCard) {
            m_hp -= opponentCard.m_atk * opponentCard.m_atk / m_def;
        }
    }
}
