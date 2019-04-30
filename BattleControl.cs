using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame {
    public partial class BattleControl : UserControl {

        #region###フィールド###
        /// <summary>
        /// 定義クラス
        /// </summary>
        private Definition m_definition;
        /// <summary>
        /// 操作プレイヤー
        /// </summary>
        private Player m_playerMe;
        /// <summary>
        /// 相手プレイヤー
        /// </summary>
        private Player m_playerYou;

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public BattleControl() {
            InitializeComponent();
            /*Designerクラスでリテラル扱いされる値を変数で再定義*/
            //画面サイズ
            Size = new Size(Definition.DISPLAY_WIDTH, Definition.DISPLAY_HEIGHT);
            //背景画像の位置
            Battle_pictureBox.Location = new Point(Definition.BTL_BACK_IMG_LOCATION_X, Definition.BTL_BACK_IMG_LOCATION_Y);
            //背景画像のサイズ
            Battle_pictureBox.Size = new Size(Definition.DISPLAY_WIDTH, Definition.DISPLAY_HEIGHT);

            m_definition = new Definition();

            //プレイヤーMeとYouを初期化
            m_playerMe = new Player();
            m_playerYou = new Player();

        }

        /// <summary>
        /// 背景画像の透明度を下げ、デッキ構築開始textboxを配置する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BattleControl_Load(object sender, System.EventArgs e) {
            //背景画像の透明度を下げる
            float alpha = 0.1f;
            TransParentBackGroundImage(alpha);
            //デッキ構築開始textBoxを配置
            textBox_DeckConstruct.Location = new Point(Definition.BTL_TXTBOX_DECK_CONSTRUCT_X, Definition.BTL_TXTBOX_DECK_CONSTRUCT_Y);
        }

        /// <summary>
        /// タイトル画面でバトルスタートボタンを押下すると呼ばれる
        /// </summary>
        public async void BattleStart() {
            //デッキ構築開始メッセージを画面中央、左から右に走らせる
            await Task.Run(() => AnimateDeckConstructTextBox());
            //デッキを構築する
            //ConstructDeck(m_playerMe.m_deck);
            //仮のデッキ構築メソッド
            TemporaryConstructDeck(m_playerMe.m_deck);
            //デバッグ
            foreach (Card card in m_playerMe.m_deck) {
                Debug.WriteLine(string.Format("{0}", card.Name));
            }
            //ConstructDeck(m_playerYou.m_deck);

        }

        /// <summary>
        /// デッキを構築する
        /// </summary>
        /// <param name="deck"></param>
        private void ConstructDeck(List<Card> deck) {
            //各カードの当選確率を初期化
            m_definition.InitDictCardHitProbability();           
            //デッキの枚数が規定値になるまで繰り返す
            do {
                //カードリストから１種を選択
                Card card = m_definition.ChoiceCard();
                //deckに追加する
                deck.Add(card);
                //deckの枚数がDECKNUMならば終了
                if (Definition.NUM_DECK <= deck.Count) break; 
                //リストの当選確率を計算する
                m_definition.CalcCardHitProbability(card);
            } while (true);
        }

        void TemporaryConstructDeck(List<Card> deck) {
            //NUM_DECKになるまでList_Cardからカードを順番でデッキに加える
            bool complete = false;
            do {
                foreach (Card card in m_definition.List_Card) {
                    deck.Add(card);
                    if (Definition.NUM_DECK <= deck.Count) {
                        complete = true;
                        break;
                    }
                }
            } while (!complete);
        }

        /// <summary>
        /// デッキ構築開始メッセージを画面中央、左から右に走らせる
        /// </summary>
        private void AnimateDeckConstructTextBox() {
            //加速度
            int acceleration = 50;
            //処理間隔
            int msec = 50;
            //減速場所
            int decelerationLocation = (Definition.DISPLAY_WIDTH - textBox_DeckConstruct.Width) / 2;
            //減速実行フラグ
            bool flgDecelerate = true;
            //加減速率
            int decelerationRatio = 10;
            //加速場所
            int accelerationLocation = (Definition.DISPLAY_WIDTH + textBox_DeckConstruct.Width) / 2;
            //加速実行フラグ
            bool flgAccelerate = true;
            //textBoxのLocationの値を変えるにはPoint型を利用する
            Point point = new Point(textBox_DeckConstruct.Location.X, textBox_DeckConstruct.Location.Y);

            //左から右に移動するアニメーション
            do {
                //画面中央で減速、その後加速
                if (decelerationLocation <= point.X && flgDecelerate) {
                    acceleration /= decelerationRatio;
                    flgDecelerate = !flgDecelerate;
                }
                if (accelerationLocation <= point.X && flgAccelerate) {
                    acceleration *= decelerationRatio;
                    flgAccelerate = !flgAccelerate;
                }
                point.X += acceleration;
                //textBoxを生成したスレッドとは別のスレッドからtextBoxを操作するためInvokeを利用
                Invoke((MethodInvoker)delegate { textBox_DeckConstruct.Location = point; });

                Thread.Sleep(50);

                //デッキ構築開始textboxが画面外に出たら終了
            } while (textBox_DeckConstruct.Location.X < Definition.DISPLAY_WIDTH);
            
            //背景画像の透明度を戻す
            float alpha = 1.0f;
            TransParentBackGroundImage(alpha);
        }

        /// <summary>
        /// 背景画像を透明化する
        /// </summary>
        /// <param name="alpha"></param>
        private void TransParentBackGroundImage(float alpha) {
            Bitmap bitmap = new Bitmap(Definition.DISPLAY_WIDTH, Definition.DISPLAY_HEIGHT);
            Graphics g = Graphics.FromImage(bitmap);
            //ColorMatrixで透明度を設定
            System.Drawing.Imaging.ColorMatrix colorMatrix = new System.Drawing.Imaging.ColorMatrix();
            colorMatrix.Matrix00 = 1;     //Red
            colorMatrix.Matrix11 = 1;     //Green
            colorMatrix.Matrix22 = 1;     //Blue
            colorMatrix.Matrix33 = alpha; //Alpha
            colorMatrix.Matrix44 = 1;     //常に1
            //
            System.Drawing.Imaging.ImageAttributes imageAttributes = new System.Drawing.Imaging.ImageAttributes();
            //ColorMatrixを設定する
            imageAttributes.SetColorMatrix(colorMatrix);
            //何故かDraw
            g.DrawImage(m_definition.Image_Battle,
                        new Rectangle(0, 0, m_definition.Image_Battle.Width, m_definition.Image_Battle.Height),
                        0, 0, m_definition.Image_Battle.Width, m_definition.Image_Battle.Height,
                        GraphicsUnit.Pixel, imageAttributes);
            //m_definition.Image_Battle.Dispose();
            g.Dispose();
            //バトルコントロール背景に画像を適用
            Battle_pictureBox.BackgroundImage = bitmap;
        }
    }
}
