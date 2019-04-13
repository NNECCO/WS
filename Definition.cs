using System;
using System.Drawing;
using System.IO;

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
        /// <summary>
        /// 実行ファイルからImageフォルダまでの相対パス
        /// </summary>
        private const string RELATIVE_PATH_IMAGE = @"..\..\";
        /// <summary>
        /// 画像を保存するフォルダ名
        /// </summary>
        private const string DIRECTORY_IMAGE = @"Image\";
        #endregion

        #region #タイトル#
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

        #region #バトル#
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

        #region #カード#
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
            //実行ファイルまでのパス
            string path_Exe = System.Reflection.Assembly.GetExecutingAssembly().Location;
            
            //実行ファイルからタイトル画像までのパス
            string relative_Path_Image_Title = RELATIVE_PATH_IMAGE + DIRECTORY_IMAGE + NAME_IMAGE_TITLE;
            //実行ファイルがあるパスを基準とするタイトル画像までのパス
            Uri path_Image_Title = new Uri(new Uri(path_Exe), relative_Path_Image_Title);
            //パスから画像を取得
            Image_Title = Image.FromFile(path_Image_Title.LocalPath);

            //実行ファイルからバトル画面の背景画像までのパス
            string relative_Path_Image_Battle = RELATIVE_PATH_IMAGE + DIRECTORY_IMAGE + NAME_IMAGE_BATTLE;
            //実行ファイルがあるパスを基準とするバトル背景画像までのパス
            Uri path_Image_Battle = new Uri(new Uri(path_Exe), relative_Path_Image_Battle);
            //パスから画像を取得
            Image_Battle = Image.FromFile(path_Image_Battle.LocalPath);
        }
    }
}
