
namespace Presentation
{
    partial class StudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.GroupIdTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.AgeTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateBut = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.FindBut = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ChAgeTB = new System.Windows.Forms.TextBox();
            this.ChNameTB = new System.Windows.Forms.TextBox();
            this.ChGroupIdTB = new System.Windows.Forms.TextBox();
            this.ChangeBut = new System.Windows.Forms.Button();
            this.DeleteBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создать элемент:";
            // 
            // GroupIdTB
            // 
            this.GroupIdTB.Location = new System.Drawing.Point(163, 64);
            this.GroupIdTB.Name = "GroupIdTB";
            this.GroupIdTB.Size = new System.Drawing.Size(150, 31);
            this.GroupIdTB.TabIndex = 1;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(411, 64);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(150, 31);
            this.NameTB.TabIndex = 2;
            // 
            // AgeTB
            // 
            this.AgeTB.Location = new System.Drawing.Point(706, 64);
            this.AgeTB.Name = "AgeTB";
            this.AgeTB.Size = new System.Drawing.Size(150, 31);
            this.AgeTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер группы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Имя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(620, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Возраст:";
            // 
            // CreateBut
            // 
            this.CreateBut.Location = new System.Drawing.Point(971, 62);
            this.CreateBut.Name = "CreateBut";
            this.CreateBut.Size = new System.Drawing.Size(242, 34);
            this.CreateBut.TabIndex = 7;
            this.CreateBut.Text = "Создать ";
            this.CreateBut.UseVisualStyleBackColor = true;
            this.CreateBut.Click += new System.EventHandler(this.CreateBut_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Найти элемент:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "ID:";
            // 
            // IdTB
            // 
            this.IdTB.Location = new System.Drawing.Point(411, 144);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(150, 31);
            this.IdTB.TabIndex = 10;
            // 
            // FindBut
            // 
            this.FindBut.Location = new System.Drawing.Point(971, 138);
            this.FindBut.Name = "FindBut";
            this.FindBut.Size = new System.Drawing.Size(242, 34);
            this.FindBut.TabIndex = 11;
            this.FindBut.Text = "Найти";
            this.FindBut.UseVisualStyleBackColor = true;
            this.FindBut.Click += new System.EventHandler(this.FindBut_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(620, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Возраст:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(354, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Имя:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Номер группы:";
            // 
            // ChAgeTB
            // 
            this.ChAgeTB.Location = new System.Drawing.Point(706, 218);
            this.ChAgeTB.Name = "ChAgeTB";
            this.ChAgeTB.Size = new System.Drawing.Size(150, 31);
            this.ChAgeTB.TabIndex = 14;
            // 
            // ChNameTB
            // 
            this.ChNameTB.Location = new System.Drawing.Point(411, 218);
            this.ChNameTB.Name = "ChNameTB";
            this.ChNameTB.Size = new System.Drawing.Size(150, 31);
            this.ChNameTB.TabIndex = 13;
            // 
            // ChGroupIdTB
            // 
            this.ChGroupIdTB.Location = new System.Drawing.Point(163, 218);
            this.ChGroupIdTB.Name = "ChGroupIdTB";
            this.ChGroupIdTB.Size = new System.Drawing.Size(150, 31);
            this.ChGroupIdTB.TabIndex = 12;
            // 
            // ChangeBut
            // 
            this.ChangeBut.Location = new System.Drawing.Point(971, 212);
            this.ChangeBut.Name = "ChangeBut";
            this.ChangeBut.Size = new System.Drawing.Size(242, 34);
            this.ChangeBut.TabIndex = 18;
            this.ChangeBut.Text = "Изменить";
            this.ChangeBut.UseVisualStyleBackColor = true;
            this.ChangeBut.Click += new System.EventHandler(this.ChangeBut_Click);
            // 
            // DeleteBut
            // 
            this.DeleteBut.Location = new System.Drawing.Point(971, 278);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(242, 34);
            this.DeleteBut.TabIndex = 19;
            this.DeleteBut.Text = "Удалить";
            this.DeleteBut.UseVisualStyleBackColor = true;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 450);
            this.Controls.Add(this.DeleteBut);
            this.Controls.Add(this.ChangeBut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ChAgeTB);
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
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GroupIdTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox AgeTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CreateBut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.Button FindBut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ChAgeTB;
        private System.Windows.Forms.TextBox ChNameTB;
        private System.Windows.Forms.TextBox ChGroupIdTB;
        private System.Windows.Forms.Button ChangeBut;
        private System.Windows.Forms.Button DeleteBut;
    }
}