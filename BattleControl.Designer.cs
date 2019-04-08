namespace CardGame {
    partial class BattleControl {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleControl));
            this.Battle_pictureBox = new System.Windows.Forms.PictureBox();
            this.textBox_DeckConstruct = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Battle_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Battle_pictureBox
            // 
            this.Battle_pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Battle_pictureBox.BackgroundImage")));
            this.Battle_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.Battle_pictureBox.Name = "Battle_pictureBox";
            this.Battle_pictureBox.Size = new System.Drawing.Size(1200, 700);
            this.Battle_pictureBox.TabIndex = 0;
            this.Battle_pictureBox.TabStop = false;
            // 
            // textBox_DeckConstruct
            // 
            this.textBox_DeckConstruct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_DeckConstruct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_DeckConstruct.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox_DeckConstruct.Font = new System.Drawing.Font("Meiryo UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_DeckConstruct.Location = new System.Drawing.Point(189, 343);
            this.textBox_DeckConstruct.MaxLength = 20;
            this.textBox_DeckConstruct.Name = "textBox_DeckConstruct";
            this.textBox_DeckConstruct.ReadOnly = true;
            this.textBox_DeckConstruct.ShortcutsEnabled = false;
            this.textBox_DeckConstruct.Size = new System.Drawing.Size(300, 51);
            this.textBox_DeckConstruct.TabIndex = 1;
            this.textBox_DeckConstruct.TabStop = false;
            this.textBox_DeckConstruct.Text = "デッキ構築開始";
            this.textBox_DeckConstruct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_DeckConstruct.WordWrap = false;
            // 
            // BattleControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.textBox_DeckConstruct);
            this.Controls.Add(this.Battle_pictureBox);
            this.Enabled = false;
            this.Name = "BattleControl";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.BattleControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Battle_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Battle_pictureBox;
        private System.Windows.Forms.TextBox textBox_DeckConstruct;
    }
}
