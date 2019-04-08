using System.Drawing;

namespace CardGame {
    class Definition {

        #region #定数#

        #region #共通#
        /// <summary>
        /// ゲーム画面の幅
        /// </summary>
        public const int DISPLAY_WIDTH = 1200;
        /// <summary>
        /// ゲーム画面の高さ
        /// </summary>
        public const int DISPLAY_HEIGHT = 700;
        #endregion

        #region #タイトル#
        /// <summary>
        /// タイトル画像のフルパス
        /// </summary>
        private const string PATH_IMAGE_TITLE = @"C:\Users\shitu\source\repos\CardGame\Image\タイトル仮.png";

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

        #region #バトル#
        /// <summary>
        /// 背景画像の絶対パス
        /// </summary>
        private const string PATH_IMAGE_BATTLE = @"C:\Users\shitu\source\repos\CardGame\Image\フィールド仮.png";

        /// <summary>
        /// バトル画面の背景画像の左上隅の描画位置(x座標)
        /// </summary>
        public const int BTL_BACK_IMG_LOCATION_X = 0;
        /// <summary>
        /// バトル画面の背景画像の左上隅の描画位置(y座標)
        /// </summary>
        public const int BTL_BACK_IMG_LOCATION_Y = 0;

        public const string BTL_TXTBOX_DECK_CONSTRUCT_TEXT = "デッキ構築開始";
        public const int BTL_TXTBOX_DECK_CONSTRUCT_WIDTH = 300;
        public const int BTL_TXTBOX_DECK_CONSTRUCT_HEIGHT = 80;
        public const int BTL_TXTBOX_DECK_CONSTRUCT_X = -BTL_TXTBOX_DECK_CONSTRUCT_WIDTH;
        public const int BTL_TXTBOX_DECK_CONSTRUCT_Y = (DISPLAY_HEIGHT - BTL_TXTBOX_DECK_CONSTRUCT_HEIGHT)/2;

        /// <summary>
        /// カードの高さ
        /// </summary>
        public const int CARD_HEIGHT = 148;
        /// <summary>
        /// カードの幅
        /// </summary>
        public const int CARD_WIDTH = 223;
        //カードの定義もここで行う
        //const int MONS1_HP = 100;
        //new Card(MONS1_NAME, MONS1_HP, ...)というようにして、定義は固定値、カードの実体は変数で持てるようにする
        #endregion

        #endregion

        #region #プロパティ#
        /// <summary>
        /// タイトル画像
        /// </summary>
        public Image Image_Title { get; set; }
        /// <summary>
        /// バトルフィールド画像
        /// </summary>
        public Image Image_Battle { get; set; }

        
        #endregion

        public Definition() {
            Image_Title = Image.FromFile(PATH_IMAGE_TITLE);
            Image_Battle = Image.FromFile(PATH_IMAGE_BATTLE);
        }
    }
}
