using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame {

    class Player {

        #region #フィールド#
        /// <summary>
        /// ライフポイント
        /// </summary>
        private int m_lifePoint;
        /// <summary>
        /// 手札
        /// </summary>
        private List<Card> m_hand;
        /// <summary>
        /// デッキ
        /// </summary>
        private List<Card> m_deck;
        #endregion

        public Player() {

        }

    }

}
