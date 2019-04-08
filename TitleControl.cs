using System.Windows.Forms;

namespace CardGame {
    public partial class TitleControl : UserControl {

        private Definition m_definition;

        public TitleControl() {
            InitializeComponent();
            /*Designerクラスでリテラル扱いされる値を変数で再定義*/
            //画面サイズを設定
            Size = new System.Drawing.Size(Definition.DISPLAY_WIDTH, Definition.DISPLAY_HEIGHT);
            //背景画像の位置とサイズ
            Title_pictureBox.Location = new System.Drawing.Point(Definition.TIT_BACK_IMG_LOCATION_X, Definition.TIT_BACK_IMG_LOCATION_Y);
            Title_pictureBox.Size = new System.Drawing.Size(Definition.DISPLAY_WIDTH, Definition.DISPLAY_HEIGHT);
            //バトルスタートボタンの位置とサイズ
            btn_battleStart.Location = new System.Drawing.Point(Definition.BTN_LOCATION_X, Definition.BTN_LOCATION_Y);
            btn_battleStart.Size = new System.Drawing.Size(Definition.BTN_WIDTH, Definition.BTN_HEIGHT);

            //ボタンの背景色を画像の背景色にする
            Title_pictureBox.Controls.Add(btn_battleStart);
            btn_battleStart.Top = btn_battleStart.Top - Title_pictureBox.Top;
            btn_battleStart.Left = btn_battleStart.Left - Title_pictureBox.Left;

            m_definition = new Definition();
        }

        private void Btn_battleStart_Click(object sender, System.EventArgs e) {
            //画面をTitleControlからBattleControlに変更する
            Visible = false;
            Enabled = false;
            MainForm.s_ctrBattle.Visible = true;
            MainForm.s_ctrBattle.Enabled = true;
            MainForm.s_ctrBattle.BattleStart();
        }
    }
}
