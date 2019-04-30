using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame {

    /// <summary>
    /// 共通クラス。静的なオブジェクトや関数を管理する
    /// </summary>
    class Global {

        #region###定数###
        /// <summary>
        /// 実行ファイルからImageフォルダまでの相対パス
        /// </summary>
        private const string RELATIVE_PATH_IMAGE = @"..\..\";
        /// <summary>
        /// 画像を保存するフォルダ名
        /// </summary>
        private const string DIRECTORY_IMAGE = @"Image\";

        #endregion

        #region###STATIC###
        /// <summary>
        /// タイトルのユーザコントロール
        /// </summary>
        public static TitleControl s_ctrTitle = new TitleControl();
        /// <summary>
        /// バトル画面のユーザコントロール
        /// </summary>
        public static BattleControl s_ctrBattle = new BattleControl();
        #endregion

        /// <summary>
        /// ファイルまでのパスを返す
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static Uri UriOf(string fileName) {
            //実行ファイルまでのパス
            string path_Exe = System.Reflection.Assembly.GetExecutingAssembly().Location;
            //実行ファイルから対象ファイルまでのパス
            string relative_Path2File = RELATIVE_PATH_IMAGE + DIRECTORY_IMAGE + fileName;
            //実行ファイルがあるパスを基準とする対象ファイルまでのパス
            return new Uri(new Uri(path_Exe), relative_Path2File);
        }



    }
}
