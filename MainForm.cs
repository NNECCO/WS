using System.Windows.Forms;

namespace CardGame {
    public partial class MainForm : Form {

        #region###フィールド###

        /// <summary>
        /// 定義クラス
        /// </summary>
        private Definition m_definition;

        #endregion

        /// <summary>
        /// コンストラクタ。タイトルコントロール、バトルコントロールをフォームに追加する。
        /// </summary>
        public MainForm() {
            InitializeComponent();
            //フォームの画面サイズを設定
            Size = new System.Drawing.Size(new System.Drawing.Point(Definition.DISPLAY_WIDTH, Definition.DISPLAY_HEIGHT));
            //タイトルコントロールをフォームに追加
            Controls.Add(Global.s_ctrTitle);
            //タイトルコントロールを表示
            Global.s_ctrTitle.Visible = true;
            Global.s_ctrTitle.Enabled = true;
            //バトルコントロールをフォームに追加
            Controls.Add(Global.s_ctrBattle);
            
        }
    }
}
