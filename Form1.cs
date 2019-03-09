using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmField : Form
    {
        #region #フィールド#
        /// <summary>
        /// デッキの枚数
        /// </summary>
        int deckNum = 30;
        /// <summary>
        /// 自分のターンの始まり
        /// </summary>
        DateTime myTrunStart;
        /// <summary>
        /// 自分のターンの終わり
        /// </summary>
        DateTime myTrunEnd;
        /// <summary>
        /// デッキを引いた時刻
        /// </summary>
        DateTime deckDrawTime;
        /// <summary>
        /// デッキを引いてから0.5s後
        /// </summary>
        DateTime deckDrawTimePlus05;
        /// <summary>
        /// 制限時間
        /// </summary>
        int timeLimit = 10;
        /// <summary>
        /// デッキからカードをドロー下か否か
        /// </summary>
        bool deck = false;
        #endregion

        public frmField()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmField_Load(object sender, EventArgs e)
        {
            /*自分のターンが来た場合*/
            myTrunStart = DateTime.Now; //現在時刻を取得(自分のターン開始時刻を取得)
            timerMyTrun.Enabled = true; //自分のターンの制限時間を計るタイマーを起動
            myTrunEnd = myTrunStart.AddSeconds(timeLimit); //自分のターン終了時刻を取得(制限時間を加算した時刻がターン終了時刻)
        }

        /// <summary>
        /// 自分のターンの制限時間を計るタイマー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerMyTrun_Tick(object sender, EventArgs e)
        {
            DateTime nowTime; //現在時刻を取得するための変数
            nowTime = DateTime.Now; //1秒間隔で現在時刻を取得
            timeLimit -= 1; //制限時間を1秒ごとに減らす
            lblTimeLimit.Text = timeLimit.ToString(); //制限時間を表示

            if (myTrunEnd <= nowTime) //現在時刻が自分のターン終了時刻を過ぎた場合
            {
                lblResult.Text = "You Lose..."; //自分は敗北
                lblResult.Visible = true; //敗北メッセージを表示
                timerMyTrun.Enabled = false; //タイマーを停止
            }
        }

        /// <summary>
        /// デッキがクリックされた場合の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblAddCard_Click(object sender, EventArgs e)
        {
            {
                if (deck == false) //デッキを引いていない場合
                {
                    deck = true; //デッキを引いたしるし
                    deckNum -= 1; //カードを1枚ドロー
                     //lblAddCard.Image = ""; //デッキの数が減ったイメージに入れ替え
                    deckDrawTime = DateTime.Now; //デッキを引いた時刻を取得
                    deckDrawTimePlus05 = deckDrawTime.AddSeconds(0.5); //デッキを引いてから0.5秒後
                    timerDrawCard.Enabled = true; //デッキが引かれた動きを表現するためのタイマーを起動
                }
            }
        }

        /// <summary>
        /// デッキからカードが引かれた動きを表現するためのタイマー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerDrawCard_Tick(object sender, EventArgs e)
        {
            if (lblAddCard.Top <= 550) //デッキドロー時のy座標がフォームからはみ出るまで
            {
                int addCardY = 20;//0.01秒ごとにy座標をどれだけずらすか
                lblAddCard.Top += addCardY; //y座標を下にずらす
            }
            DateTime nowTime; //現在時刻を取得するための変数
            nowTime = DateTime.Now; //0.01秒間隔で現在時刻を取得
            if (deckDrawTimePlus05 < DateTime.Now) //現在時刻がデッキを引いてから0.5秒後を過ぎた場合
            {
                //追加カードにランダムにイメージを表示
                lblMyCard5.Visible = true; //カード5を表示
                lblAddCard.Top = 391; //引いたカードをもとの場所に戻す
                timerDrawCard.Enabled = false; //タイマーを止める
            }
        }



        /// <summary>
        /// ターン終了ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblMyTrunEnd_Click(object sender, EventArgs e)
        {
            timerMyTrun.Enabled = false; //タイマーを停止
            timeLimit = 60; //制限時間を初期化
            //相手のターン
        }



        /*カード1がクリックされた場合*/
        //private void lblMyCard1_Click(object sender, EventArgs e)
        //{
        //    if (deck == 1 && lblMyCard4.Visible=true) //デッキを引き,追加カードが表示されている場合 
        //    {

        //    }

        //}
    }
}
