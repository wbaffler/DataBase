
namespace Presentation
{
    partial class CuratorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuccessLabel = new System.Windows.Forms.Label();
            this.AverageAgeLabel = new System.Windows.Forms.Label();
            this.AverageBut = new System.Windows.Forms.Button();
            this.DeleteBut = new System.Windows.Forms.Button();
            this.ChangeBut = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ChEmailTB = new System.Windows.Forms.TextBox();
            this.ChNameTB = new System.Windows.Forms.TextBox();
            this.ChGroupIdTB = new System.Windows.Forms.TextBox();
            this.FindBut = new System.Windows.Forms.Button();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CreateBut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AgeTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.GroupIdTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SuccessLabel
            // 
            this.SuccessLabel.AutoSize = true;
            this.SuccessLabel.Location = new System.Drawing.Point(195, 36);
            this.SuccessLabel.Name = "SuccessLabel";
            this.SuccessLabel.Size = new System.Drawing.Size(0, 25);
            this.SuccessLabel.TabIndex = 49;
            // 
            // AverageAgeLabel
            // 
            this.AverageAgeLabel.AutoSize = true;
            this.AverageAgeLabel.Location = new System.Drawing.Point(35, 564);
            this.AverageAgeLabel.Name = "AverageAgeLabel";
            this.AverageAgeLabel.Size = new System.Drawing.Size(0, 25);
            this.AverageAgeLabel.TabIndex = 48;
            // 
            // AverageBut
            // 
            this.AverageBut.Location = new System.Drawing.Point(35, 448);
            this.AverageBut.Name = "AverageBut";
            this.AverageBut.Size = new System.Drawing.Size(318, 83);
            this.AverageBut.TabIndex = 46;
            this.AverageBut.Text = "Вывести средний возраст группы";
            this.AverageBut.UseVisualStyleBackColor = true;
            this.AverageBut.Click += new System.EventHandler(this.AverageBut_Click);
            // 
            // DeleteBut
            // 
            this.DeleteBut.Location = new System.Drawing.Point(987, 380);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(242, 34);
            this.DeleteBut.TabIndex = 44;
            this.DeleteBut.Text = "Удалить";
            this.DeleteBut.UseVisualStyleBackColor = true;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // ChangeBut
            // 
            this.ChangeBut.Location = new System.Drawing.Point(987, 314);
            this.ChangeBut.Name = "ChangeBut";
            this.ChangeBut.Size = new System.Drawing.Size(242, 34);
            this.ChangeBut.TabIndex = 43;
            this.ChangeBut.Text = "Изменить";
            this.ChangeBut.UseVisualStyleBackColor = true;
            this.ChangeBut.Click += new System.EventHandler(this.ChangeBut_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(636, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 42;
            this.label7.Text = "Возраст:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 25);
            this.label8.TabIndex = 41;
            this.label8.Text = "Имя:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 25);
            this.label9.TabIndex = 40;
            this.label9.Text = "Номер группы:";
            // 
            // ChAgeTB
            // 
            this.ChEmailTB.Location = new System.Drawing.Point(722, 320);
            this.ChEmailTB.Name = "ChAgeTB";
            this.ChEmailTB.Size = new System.Drawing.Size(150, 31);
            this.ChEmailTB.TabIndex = 39;
            // 
            // ChNameTB
            // 
            this.ChNameTB.Location = new System.Drawing.Point(427, 320);
            this.ChNameTB.Name = "ChNameTB";
            this.ChNameTB.Size = new System.Drawing.Size(150, 31);
            this.ChNameTB.TabIndex = 38;
            // 
            // ChGroupIdTB
            // 
            this.ChGroupIdTB.Location = new System.Drawing.Point(179, 320);
            this.ChGroupIdTB.Name = "ChGroupIdTB";
            this.ChGroupIdTB.Size = new System.Drawing.Size(150, 31);
            this.ChGroupIdTB.TabIndex = 37;
            // 
            // FindBut
            // 
            this.FindBut.Location = new System.Drawing.Point(416, 244);
            this.FindBut.Name = "FindBut";
            this.FindBut.Size = new System.Drawing.Size(242, 34);
            this.FindBut.TabIndex = 36;
            this.FindBut.Text = "Найти";
            this.FindBut.UseVisualStyleBackColor = true;
            this.FindBut.Click += new System.EventHandler(this.FindBut_Click);
            // 
            // IdTB
            // 
            this.IdTB.Location = new System.Drawing.Point(246, 246);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(150, 31);
            this.IdTB.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Найти элемент:";
            // 
            // CreateBut
            // 
            this.CreateBut.Location = new System.Drawing.Point(987, 85);
            this.CreateBut.Name = "CreateBut";
            this.CreateBut.Size = new System.Drawing.Size(242, 34);
            this.CreateBut.TabIndex = 32;
            this.CreateBut.Text = "Создать ";
            this.CreateBut.UseVisualStyleBackColor = true;
            this.CreateBut.Click += new System.EventHandler(this.CreateBut_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "E-Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Номер группы:";
            // 
            // AgeTB
            // 
            this.AgeTB.Location = new System.Drawing.Point(722, 87);
            this.AgeTB.Name = "AgeTB";
            this.AgeTB.Size = new System.Drawing.Size(150, 31);
            this.AgeTB.TabIndex = 28;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(427, 87);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(150, 31);
            this.NameTB.TabIndex = 27;
            // 
            // GroupIdTB
            // 
            this.GroupIdTB.Location = new System.Drawing.Point(179, 87);
            this.GroupIdTB.Name = "GroupIdTB";
            this.GroupIdTB.Size = new System.Drawing.Size(150, 31);
            this.GroupIdTB.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Создать элемент:";
            // 
            // CuratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 684);
            this.Controls.Add(this.SuccessLabel);
            this.Controls.Add(this.AverageAgeLabel);
            this.Controls.Add(this.AverageBut);
            this.Controls.Add(this.DeleteBut);
            this.Controls.Add(this.ChangeBut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ChEmailTB);
            this.Controls.Add(this.ChNameTB);
            this.Controls.Add(this.ChGroupIdTB);
            this.Controls.Add(this.FindBut);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CreateBut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AgeTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.GroupIdTB);
            this.Controls.Add(this.label1);
            this.Name = "CuratorForm";
            this.Text = "CuratorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SuccessLabel;
        private System.Windows.Forms.Label AverageAgeLabel;
        private System.Windows.Forms.Button AverageBut;
        private System.Windows.Forms.Button DeleteBut;
        private System.Windows.Forms.Button ChangeBut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ChEmailTB;
        private System.Windows.Forms.TextBox ChNameTB;
        private System.Windows.Forms.TextBox ChGroupIdTB;
        private System.Windows.Forms.Button FindBut;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CreateBut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AgeTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox GroupIdTB;
        private System.Windows.Forms.Label label1;
    }
}