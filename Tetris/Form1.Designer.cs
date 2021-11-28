
namespace Tetris
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_Game = new System.Windows.Forms.PictureBox();
            this.label_Score = new System.Windows.Forms.Label();
            this.label_Level = new System.Windows.Forms.Label();
            this.pictureBox_Next_Shape = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Game)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Next_Shape)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Game
            // 
            this.pictureBox_Game.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pictureBox_Game.Location = new System.Drawing.Point(46, 30);
            this.pictureBox_Game.Name = "pictureBox_Game";
            this.pictureBox_Game.Size = new System.Drawing.Size(478, 615);
            this.pictureBox_Game.TabIndex = 0;
            this.pictureBox_Game.TabStop = false;
            this.pictureBox_Game.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label_Score
            // 
            this.label_Score.AutoSize = true;
            this.label_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label_Score.Location = new System.Drawing.Point(611, 45);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(152, 39);
            this.label_Score.TabIndex = 1;
            this.label_Score.Text = "Score : 0";
            this.label_Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // label_Level
            // 
            this.label_Level.AutoSize = true;
            this.label_Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_Level.Location = new System.Drawing.Point(613, 96);
            this.label_Level.Name = "label_Level";
            this.label_Level.Size = new System.Drawing.Size(109, 29);
            this.label_Level.TabIndex = 2;
            this.label_Level.Text = "Level : 0";
            this.label_Level.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox_Next_Shape
            // 
            this.pictureBox_Next_Shape.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox_Next_Shape.Location = new System.Drawing.Point(618, 174);
            this.pictureBox_Next_Shape.Name = "pictureBox_Next_Shape";
            this.pictureBox_Next_Shape.Size = new System.Drawing.Size(206, 181);
            this.pictureBox_Next_Shape.TabIndex = 3;
            this.pictureBox_Next_Shape.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 797);
            this.Controls.Add(this.pictureBox_Next_Shape);
            this.Controls.Add(this.label_Level);
            this.Controls.Add(this.label_Score);
            this.Controls.Add(this.pictureBox_Game);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tetris";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Game)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Next_Shape)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Game;
        private System.Windows.Forms.Label label_Score;
        private System.Windows.Forms.Label label_Level;
        private System.Windows.Forms.PictureBox pictureBox_Next_Shape;
    }
}

