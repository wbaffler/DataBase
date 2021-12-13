
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
            this.AverageAgeLabel = new System.Windows.Forms.Label();
            this.AverageBut = new System.Windows.Forms.Button();
            this.DeleteBut = new System.Windows.Forms.Button();
            this.ChangeBut = new System.Windows.Forms.Button();
            this.CreateBut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AvgLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CreateBt = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.AverageBut.Location = new System.Drawing.Point(14, 64);
            this.AverageBut.Name = "AverageBut";
            this.AverageBut.Size = new System.Drawing.Size(318, 83);
            this.AverageBut.TabIndex = 46;
            this.AverageBut.Text = "Вывести средний возраст группы";
            this.AverageBut.UseVisualStyleBackColor = true;
            this.AverageBut.Click += new System.EventHandler(this.AverageBut_Click);
            // 
            // DeleteBut
            // 
            this.DeleteBut.Location = new System.Drawing.Point(1312, 66);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(242, 34);
            this.DeleteBut.TabIndex = 44;
            this.DeleteBut.Text = "Удалить";
            this.DeleteBut.UseVisualStyleBackColor = true;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // ChangeBut
            // 
            this.ChangeBut.Location = new System.Drawing.Point(1312, 12);
            this.ChangeBut.Name = "ChangeBut";
            this.ChangeBut.Size = new System.Drawing.Size(242, 34);
            this.ChangeBut.TabIndex = 43;
            this.ChangeBut.Text = "Изменить";
            this.ChangeBut.UseVisualStyleBackColor = true;
            this.ChangeBut.Click += new System.EventHandler(this.ChangeBut_Click);
            // 
            // CreateBut
            // 
            this.CreateBut.Location = new System.Drawing.Point(878, 746);
            this.CreateBut.Name = "CreateBut";
            this.CreateBut.Size = new System.Drawing.Size(242, 34);
            this.CreateBut.TabIndex = 32;
            this.CreateBut.Text = "Создать ";
            this.CreateBut.UseVisualStyleBackColor = true;
            //this.CreateBut.Click += new System.EventHandler(this.CreateBut_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(625, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "E-Mail:";
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(696, 74);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(150, 31);
            this.EmailTB.TabIndex = 28;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(144, 75);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(150, 31);
            this.NameTB.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AvgLabel);
            this.groupBox2.Controls.Add(this.AverageBut);
            this.groupBox2.Location = new System.Drawing.Point(1222, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 241);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Количество студентов в группе";
            // 
            // AvgLabel
            // 
            this.AvgLabel.AutoSize = true;
            this.AvgLabel.Location = new System.Drawing.Point(14, 180);
            this.AvgLabel.Name = "AvgLabel";
            this.AvgLabel.Size = new System.Drawing.Size(0, 25);
            this.AvgLabel.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GroupCB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CreateBt);
            this.groupBox1.Controls.Add(this.EmailTB);
            this.groupBox1.Controls.Add(this.NameTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 666);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1174, 166);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Студент";
            // 
            // GroupCB
            // 
            this.GroupCB.FormattingEnabled = true;
            this.GroupCB.Location = new System.Drawing.Point(407, 72);
            this.GroupCB.Name = "GroupCB";
            this.GroupCB.Size = new System.Drawing.Size(158, 33);
            this.GroupCB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Группа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Имя";
            // 
            // CreateBt
            // 
            this.CreateBt.Location = new System.Drawing.Point(894, 72);
            this.CreateBt.Name = "CreateBt";
            this.CreateBt.Size = new System.Drawing.Size(242, 34);
            this.CreateBt.TabIndex = 7;
            this.CreateBt.Text = "Создать ";
            this.CreateBt.UseVisualStyleBackColor = true;
            this.CreateBt.Click += new System.EventHandler(this.CreateBt_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(1204, 634);
            this.dataGridView.TabIndex = 49;
            // 
            // CuratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.AverageAgeLabel);
            this.Controls.Add(this.DeleteBut);
            this.Controls.Add(this.ChangeBut);
            this.Controls.Add(this.CreateBut);
            this.Name = "CuratorForm";
            this.Text = "CuratorForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AverageAgeLabel;
        private System.Windows.Forms.Button AverageBut;
        private System.Windows.Forms.Button DeleteBut;
        private System.Windows.Forms.Button ChangeBut;
        private System.Windows.Forms.Button CreateBut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label AvgLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox GroupCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CreateBt;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}