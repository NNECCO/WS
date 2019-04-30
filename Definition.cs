using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace CardGame {

    class Definition {

        #region###定数###

        #region##共通##
        /// <summary>
        /// ゲーム画面の幅
        /// </summary>
        public const int DISPLAY_WIDTH = 1200;
        /// <summary>
        /// ゲーム画面の高さ
        /// </summary>
        public const int DISPLAY_HEIGHT = 700;
        /// <summary>
        /// 改行コード
        /// </summary>
        private const string CRLF = "\r\n";
        #endregion

        #region##タイトル##
        /// <summary>
        /// タイトル画像のファイル名
        /// </summary>
        private const string NAME_IMAGE_TITLE = "タイトル仮.png";
        /// <summary>
        /// タイトル画面の背景画像の左上隅の描画位置(x座標)
        /// </summary>
        public const int TIT_BACK_IMG_LOCATION_X = 0;
        /// <summary>
        /// タイトル画面の背景画像の左上隅の描画位置(y座標)
        /// </summary>
        public const int TIT_BACK_IMG_LOCATION_Y = 0;

        /// <summary>
        /// バトルスタートボタンの左上隅の描画位置(x座標)
        /// </summary>
        public const int BTN_LOCATION_X = 425;
        /// <summary>
        /// バトルスタートボタンの左上隅の描画位置(y座標)
        /// </summary>
        public const int BTN_LOCATION_Y = 420;

        /// <summary>
        /// バトルスタートボタンの高さ
        /// </summary>
        public const int BTN_HEIGHT = 70;
        /// <summary>
        /// バトルスタートボタンの幅
        /// </summary>
        public const int BTN_WIDTH = 350;

        #endregion

        #region##バトル##
        /// <summary>
        /// バトル画面の背景画像のファイル名
        /// </summary>
        private const string NAME_IMAGE_BATTLE = "フィールド仮.png";
        /// <summary>
        /// バトル画面の背景画像の左上隅の描画位置(x座標)
        /// </summary>
        public const int BTL_BACK_IMG_LOCATION_X = 0;
        /// <summary>
        /// バトル画面の背景画像の左上隅の描画位置(y座標)
        /// </summary>
        public const int BTL_BACK_IMG_LOCATION_Y = 0;
        /// <summary>
        /// タイトル画面からバトル画面に遷移したときに流れるアニメーションのメッセージ
        /// </summary>
        public const string BTL_TXTBOX_DECK_CONSTRUCT_TEXT = "デッキ構築開始";
        /// <summary>
        /// タイトル画面からバトル画面に遷移したときに流れるtextBoxの幅
        /// </summary>
        public const int BTL_TXTBOX_DECK_CONSTRUCT_WIDTH = 300;
        /// <summary>
        /// タイトル画面からバトル画面に遷移したときに流れるtextBoxの高さ
        /// </summary>
        public const int BTL_TXTBOX_DECK_CONSTRUCT_HEIGHT = 80;
        /// <summary>
        /// タイトル画面からバトル画面に遷移したときに流れるtextBoxの初期x座標
        /// </summary>
        public const int BTL_TXTBOX_DECK_CONSTRUCT_X = -BTL_TXTBOX_DECK_CONSTRUCT_WIDTH;
        /// <summary>
        /// タイトル画面からバトル画面に遷移したときに流れるtextBoxのy座標
        /// </summary>
        public const int BTL_TXTBOX_DECK_CONSTRUCT_Y = (DISPLAY_HEIGHT - BTL_TXTBOX_DECK_CONSTRUCT_HEIGHT)/2;
        /// <summary>
        /// デッキの構成枚数
        /// </summary>
        public const int NUM_DECK = 10;
        /// <summary>
        /// デッキ構成時、当選したカードの当選確率を減らす値
        /// </summary>
        public const double PROBABILITY_SUBTRACT = 4.0;
        #region #カード#
        /// <summary>
        /// カードの高さ
        /// </summary>
        public const int CARD_HEIGHT = 148;
        /// <summary>
        /// カードの幅
        /// </summary>
        public const int CARD_WIDTH = 223;

        #region#いっぷく#
        private const string FILENAME_CARD1 = "ねこ.png";
        private const string NAME_CARD1 = "いっぷく";
        private const int HP_CARD1 = 100;
        private const int ATK_CARD1 = 40;
        private const int DEF_CARD1 = 20;
        private const int COST_CARD1 = 3;
        private const string TEXT_CARD1 = "煙草の煙。" + CRLF + "非常に強力で目にしみる。" + CRLF + "受動喫煙への罪悪感を抱いている。";
        #endregion

        #region#ぺんぎん#
        private const string FILENAME_CARD2 = "ぺんぎん.png";
        private const string NAME_CARD2 = "ぺれー帽";
        private const int HP_CARD2 = 80;
        private const int ATK_CARD2 = 30;
        private const int DEF_CARD2 = 40;
        private const int COST_CARD2 = 3;
        private const string TEXT_CARD2 = "ぺんぎん。";
        #endregion

        #region#Card#
        private const string FILENAME_CARD3 = "card3.png";
        private const string NAME_CARD3 = "card3";
        private const int HP_CARD3 = 100;
        private const int ATK_CARD3 = 100;
        private const int DEF_CARD3 = 100;
        private const int COST_CARD3 = 100;
        private const string TEXT_CARD3 = "card3";
        #endregion
        #region#Card#
        private const string FILENAME_CARD4 = "card4.png";
        private const string NAME_CARD4 = "card4";
        private const int HP_CARD4 = 100;
        private const int ATK_CARD4 = 100;
        private const int DEF_CARD4 = 100;
        private const int COST_CARD4 = 100;
        private const string TEXT_CARD4 = "card4";
        #endregion
        #region#Card#
        private const string FILENAME_CARD5 = "card5.png";
        private const string NAME_CARD5 = "card5";
        private const int HP_CARD5 = 100;
        private const int ATK_CARD5 = 100;
        private const int DEF_CARD5 = 100;
        private const int COST_CARD5 = 100;
        private const string TEXT_CARD5 = "card5";
        #endregion
        #region#Card#
        //private const string FILENAME_CARD = ".png";
        //private const string NAME_CARD = "";
        //private const int HP_CARD = ;
        //private const int ATK_CARD = ;
        //private const int DEF_CARD = ;
        //private const int COST_CARD = ;
        //private const string TEXT_CARD = "";
        #endregion
        #region#Card#
        //private const string FILENAME_CARD = ".png";
        //private const string NAME_CARD = "";
        //private const int HP_CARD = ;
        //private const int ATK_CARD = ;
        //private const int DEF_CARD = ;
        //private const int COST_CARD = ;
        //private const string TEXT_CARD = "";
        #endregion
        #region#Card#
        //private const string FILENAME_CARD = ".png";
        //private const string NAME_CARD = "";
        //private const int HP_CARD = ;
        //private const int ATK_CARD = ;
        //private const int DEF_CARD = ;
        //private const int COST_CARD = ;
        //private const string TEXT_CARD = "";
        #endregion
        #region#Card#
        //private const string FILENAME_CARD = ".png";
        //private const string NAME_CARD = "";
        //private const int HP_CARD = ;
        //private const int ATK_CARD = ;
        //private const int DEF_CARD = ;
        //private const int COST_CARD = ;
        //private const string TEXT_CARD = "";
        #endregion


        #endregion

        #endregion

        #endregion

        #region###プロパティ###
        /// <summary>
        /// タイトル画像
        /// </summary>
        public Image Image_Title { get; set; }
        /// <summary>
        /// バトルフィールド画像
        /// </summary>
        public Image Image_Battle { get; set; }
        /// <summary>
        /// カード管理用リスト
        /// </summary>
        public List<Card> List_Card { get; set; } = new List<Card>();
        /// <summary>
        /// デッキ構成時の各カードの当選確率
        /// </summary>
        public Dictionary<Card, double> Dict_Card_Hit_Probability { get; set; } = new Dictionary<Card, double>();
        
        #region##カード##
        /// <summary>
        /// 画像。いっぷく。
        /// </summary>
        public Image Image_Card1 { get; set; } = Image.FromFile(Global.UriOf(FILENAME_CARD1).LocalPath);
        /// <summary>
        /// カード。いっぷく。
        /// </summary>
        public Card Card1 { get; set; }

        /// <summary>
        /// 画像。ぺんぎん。
        /// </summary>
        public Image Image_Card2 { get; set; } = Image.FromFile(Global.UriOf(FILENAME_CARD2).LocalPath);
        /// <summary>
        /// カード。ぺんぎん。
        /// </summary>
        public Card Card2 { get; set; }

        public Image Image_Card3 { get; set; } = Image.FromFile(Global.UriOf(FILENAME_CARD3).LocalPath);
        public Card Card3 { get; set; }

        public Image Image_Card4 { get; set; } = Image.FromFile(Global.UriOf(FILENAME_CARD4).LocalPath);
        public Card Card4 { get; set; }
        
        public Image Image_Card5 { get; set; } = Image.FromFile(Global.UriOf(FILENAME_CARD5).LocalPath);
        public Card Card5 { get; set; }
        //public Image Image_Card { get; set; } = Image.FromFile(Global.UriOf(FILENAME_CARD)).LocalPath);
        //public Card Card { get; set; }
        //public Image Image_Card { get; set; } = Image.FromFile(Global.UriOf(FILENAME_CARD)).LocalPath);
        //public Card Card { get; set; }
        //public Image Image_Card { get; set; } = Image.FromFile(Global.UriOf(FILENAME_CARD)).LocalPath);
        //public Card Card { get; set; }
        //public Image Image_Card { get; set; } = Image.FromFile(Global.UriOf(FILENAME_CARD)).LocalPath);
        //public Card Card { get; set; }
        //public Image Image_Card { get; set; } = Image.FromFile(Global.UriOf(FILENAME_CARD)).LocalPath);
        //public Card Card { get; set; }
        //public Image Image_Card { get; set; } = Image.FromFile(Global.UriOf(FILENAME_CARD)).LocalPath);
        //public Card Card { get; set; }
        //public Image Image_Card { get; set; } = Image.FromFile(Global.UriOf(FILENAME_CARD)).LocalPath);
        //public Card Card { get; set; }
        //public Image Image_Card { get; set; } = Image.FromFile(Global.UriOf(FILENAME_CARD)).LocalPath);
        //public Card Card { get; set; }
        //public Image Image_Card { get; set; } = Image.FromFile(Global.UriOf(FILENAME_CARD)).LocalPath);
        //public Card Card { get; set; }

        #endregion

        #endregion

        /// <summary>
        /// コンストラクタ。タイトル画像、バトル画面背景画像を取得する
        /// </summary>
        public Definition() {
            #region#画像取得#
            //タイトル画像を取得
            Uri path_Image_Title = Global.UriOf(NAME_IMAGE_TITLE);
            Image_Title = Image.FromFile(path_Image_Title.LocalPath);

            //バトル背景画像を取得
            Uri path_Image_Battle = Global.UriOf(NAME_IMAGE_BATTLE);
            Image_Battle = Image.FromFile(path_Image_Battle.LocalPath);
            #endregion

            #region#カードの初期化#
            Card1 = new Card(NAME_CARD1, HP_CARD1, ATK_CARD1, DEF_CARD1, COST_CARD1, TEXT_CARD1, Image_Card1);
            Card2 = new Card(NAME_CARD2, HP_CARD2, ATK_CARD2, DEF_CARD2, COST_CARD2, TEXT_CARD2, Image_Card2);
            Card3 = new Card(NAME_CARD3, HP_CARD3, ATK_CARD3, DEF_CARD3, COST_CARD3, TEXT_CARD3, Image_Card3);
            Card4 = new Card(NAME_CARD4, HP_CARD4, ATK_CARD4, DEF_CARD4, COST_CARD4, TEXT_CARD4, Image_Card4);
            Card5 = new Card(NAME_CARD5, HP_CARD5, ATK_CARD5, DEF_CARD5, COST_CARD5, TEXT_CARD5, Image_Card5);
            //Card = new Card(NAME_CARD, HP_CARD, ATK_CARD, DEF_CARD, COST_CARD, TEXT_CARD, Image_Card);
            //Card = new Card(NAME_CARD, HP_CARD, ATK_CARD, DEF_CARD, COST_CARD, TEXT_CARD, Image_Card);
            //Card = new Card(NAME_CARD, HP_CARD, ATK_CARD, DEF_CARD, COST_CARD, TEXT_CARD, Image_Card);


            #endregion

            #region#カード管理リストへ追加#
            List_Card.Add(Card1);
            List_Card.Add(Card2);
            List_Card.Add(Card3);
            List_Card.Add(Card4);
            List_Card.Add(Card5);

            #endregion

        }

        /// <summary>
        /// 当選確率を各カードに持たせる
        /// </summary>
        public void InitDictCardHitProbability() {
            foreach (Card card in List_Card) {
                //1だと0になってしまうため1.0とする
                double hit = 1.0 / List_Card.Count;
                Dict_Card_Hit_Probability.Add(card, hit);
            }
        }

        /// <summary>
        /// カードの当選確率を計算する
        /// </summary>
        /// <param name="card"></param>
        public void CalcCardHitProbability(Card card) {
            //計算前の当選確率を保存しておく
            double beforeHitProbability = Dict_Card_Hit_Probability[card];
            //選ばれたカードの当選確率を下げる
            Dict_Card_Hit_Probability[card] = Dict_Card_Hit_Probability[card] / PROBABILITY_SUBTRACT;
            //他のカードの当選確率に加算する値を計算
            double plusProbability = (beforeHitProbability - Dict_Card_Hit_Probability[card]) / (NUM_DECK - 1);
            //他のカードの当選確率を上げる
            foreach (Card otherCard in List_Card) {
                if(otherCard != card)
                    Dict_Card_Hit_Probability[otherCard] += plusProbability;
            }
        }

        /// <summary>
        /// カードリストからカードをチョイス
        /// </summary>
        /// <returns></returns>
        public Card ChoiceCard() {
            //0～1の乱数を生成
            double hit = new Random().NextDouble();
            //hitに当てはまる範囲のカードを返す
            double tail = 0;
            double head;
            foreach(Card card in List_Card) {
                head = tail + Dict_Card_Hit_Probability[card];
                if (tail <= hit && hit < head) return card;
                tail = head;
            }
            //nullが返るようなら再考
            return null;
        }

    }
}
