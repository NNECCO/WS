using System.Windows.Forms;

namespace CardGame {
    public partial class MainForm : Form {

        #region #フィールド#

        /// <summary>
        /// 定義クラス
        /// </summary>
        private Definition m_definition;

        #endregion

        #region #STATIC#
        /// <summary>
        /// タイトルのユーザコントロール
        /// </summary>
        public static TitleControl s_ctrTitle = new TitleControl();
        /// <summary>
        /// バトル画面のユーザコントロール
        /// </summary>
        public static BattleControl s_ctrBattle = new BattleControl();
        #endregion


        public MainForm() {
            InitializeComponent();
            //フォームの画面サイズを設定
            Size = new System.Drawing.Size(new System.Drawing.Point(Definition.DISPLAY_WIDTH, Definition.DISPLAY_HEIGHT));
            //m_definition = new Definition();
            //タイトルコントルールをフォームに追加
            Controls.Add(s_ctrTitle);
            //タイトルコントロールを表示
            s_ctrTitle.Visible = true;
            s_ctrTitle.Enabled = true;
            //バトルコントロールをフォームに追加
            Controls.Add(s_ctrBattle);
            
        }
    }
}
