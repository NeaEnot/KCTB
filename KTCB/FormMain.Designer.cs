namespace KTCB
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonChoosPicture = new System.Windows.Forms.Button();
            this.buttonDeletePicture = new System.Windows.Forms.Button();
            this.buttonAnimal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 58);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(580, 497);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // buttonChoosPicture
            // 
            this.buttonChoosPicture.Location = new System.Drawing.Point(12, 12);
            this.buttonChoosPicture.Name = "buttonChoosPicture";
            this.buttonChoosPicture.Size = new System.Drawing.Size(202, 40);
            this.buttonChoosPicture.TabIndex = 1;
            this.buttonChoosPicture.Text = "Выбрать изображение ";
            this.buttonChoosPicture.UseVisualStyleBackColor = true;
            this.buttonChoosPicture.Click += new System.EventHandler(this.buttonChoosPicture_Click);
            // 
            // buttonDeletePicture
            // 
            this.buttonDeletePicture.Location = new System.Drawing.Point(220, 12);
            this.buttonDeletePicture.Name = "buttonDeletePicture";
            this.buttonDeletePicture.Size = new System.Drawing.Size(182, 40);
            this.buttonDeletePicture.TabIndex = 2;
            this.buttonDeletePicture.Text = "Сбросить изображение";
            this.buttonDeletePicture.UseVisualStyleBackColor = true;
            this.buttonDeletePicture.Click += new System.EventHandler(this.buttonDeletePicture_Click);
            // 
            // buttonAnimal
            // 
            this.buttonAnimal.Location = new System.Drawing.Point(408, 12);
            this.buttonAnimal.Name = "buttonAnimal";
            this.buttonAnimal.Size = new System.Drawing.Size(184, 40);
            this.buttonAnimal.TabIndex = 3;
            this.buttonAnimal.Text = "Определить животное ";
            this.buttonAnimal.UseVisualStyleBackColor = true;
            this.buttonAnimal.Click += new System.EventHandler(this.buttonAnimal_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 590);
            this.Controls.Add(this.buttonAnimal);
            this.Controls.Add(this.buttonDeletePicture);
            this.Controls.Add(this.buttonChoosPicture);
            this.Controls.Add(this.pictureBox);
            this.Name = "FormMain";
            this.Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonChoosPicture;
        private System.Windows.Forms.Button buttonDeletePicture;
        private System.Windows.Forms.Button buttonAnimal;
    }
}

