namespace CardGame {
    partial class TitleControl {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleControl));
            this.Title_pictureBox = new System.Windows.Forms.PictureBox();
            this.btn_battleStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Title_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Title_pictureBox
            // 
            this.Title_pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Title_pictureBox.BackgroundImage")));
            this.Title_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.Title_pictureBox.Name = "Title_pictureBox";
            this.Title_pictureBox.Size = new System.Drawing.Size(1200, 700);
            this.Title_pictureBox.TabIndex = 0;
            this.Title_pictureBox.TabStop = false;
            // 
            // btn_battleStart
            // 
            this.btn_battleStart.BackColor = System.Drawing.Color.Transparent;
            this.btn_battleStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_battleStart.Font = new System.Drawing.Font("MS UI Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_battleStart.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_battleStart.Location = new System.Drawing.Point(377, 399);
            this.btn_battleStart.Name = "btn_battleStart";
            this.btn_battleStart.Size = new System.Drawing.Size(448, 66);
            this.btn_battleStart.TabIndex = 2;
            this.btn_battleStart.Text = "バトルスタート";
            this.btn_battleStart.UseVisualStyleBackColor = false;
            this.btn_battleStart.Click += new System.EventHandler(this.Btn_battleStart_Click);
            // 
            // TitleControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btn_battleStart);
            this.Controls.Add(this.Title_pictureBox);
            this.Name = "TitleControl";
            this.Size = new System.Drawing.Size(1200, 700);
            ((System.ComponentModel.ISupportInitialize)(this.Title_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Title_pictureBox;
        private System.Windows.Forms.Button btn_battleStart;
    }
}
