using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame {

    class Player {

        #region###フィールド###
        /// <summary>
        /// 手札
        /// </summary>
        public List<Card> m_hand;
        /// <summary>
        /// デッキ
        /// </summary>
        public List<Card> m_deck;
        
        #endregion

        #region###プロパティ###
        /// <summary>
        /// ライフポイント
        /// </summary>
        public int Life_Point { get; set; } = 15;
        #endregion

        public Player() {
            m_hand = new List<Card>();
            m_deck = new List<Card>();
        }

    }

}
