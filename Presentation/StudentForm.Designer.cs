
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
            this.CreateBut = new System.Windows.Forms.Button();
            this.ChangeBut = new System.Windows.Forms.Button();
            this.DeleteBut = new System.Windows.Forms.Button();
            this.NumberInGroupBut = new System.Windows.Forms.Button();
            this.CuratorNameBut = new System.Windows.Forms.Button();
            this.NumInGroupLabel = new System.Windows.Forms.Label();
            this.CuratorNameLabel = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AgeTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NumInGroupLabel1 = new System.Windows.Forms.Label();
            this.CuratorNameLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateBut
            // 
            this.CreateBut.Location = new System.Drawing.Point(894, 72);
            this.CreateBut.Name = "CreateBut";
            this.CreateBut.Size = new System.Drawing.Size(242, 34);
            this.CreateBut.TabIndex = 7;
            this.CreateBut.Text = "Создать ";
            this.CreateBut.UseVisualStyleBackColor = true;
            this.CreateBut.Click += new System.EventHandler(this.CreateBut_Click);
            // 
            // ChangeBut
            // 
            this.ChangeBut.Location = new System.Drawing.Point(1312, 12);
            this.ChangeBut.Name = "ChangeBut";
            this.ChangeBut.Size = new System.Drawing.Size(242, 34);
            this.ChangeBut.TabIndex = 18;
            this.ChangeBut.Text = "Изменить";
            this.ChangeBut.UseVisualStyleBackColor = true;
            this.ChangeBut.Click += new System.EventHandler(this.ChangeBut_Click);
            // 
            // DeleteBut
            // 
            this.DeleteBut.Location = new System.Drawing.Point(1312, 66);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(242, 34);
            this.DeleteBut.TabIndex = 19;
            this.DeleteBut.Text = "Удалить";
            this.DeleteBut.UseVisualStyleBackColor = true;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // NumberInGroupBut
            // 
            this.NumberInGroupBut.Location = new System.Drawing.Point(14, 63);
            this.NumberInGroupBut.Name = "NumberInGroupBut";
            this.NumberInGroupBut.Size = new System.Drawing.Size(318, 83);
            this.NumberInGroupBut.TabIndex = 20;
            this.NumberInGroupBut.Text = "Подсчитать студентов в группе";
            this.NumberInGroupBut.UseVisualStyleBackColor = true;
            this.NumberInGroupBut.Click += new System.EventHandler(this.NumberInGroupBut_Click);
            // 
            // CuratorNameBut
            // 
            this.CuratorNameBut.Location = new System.Drawing.Point(14, 60);
            this.CuratorNameBut.Name = "CuratorNameBut";
            this.CuratorNameBut.Size = new System.Drawing.Size(318, 83);
            this.CuratorNameBut.TabIndex = 21;
            this.CuratorNameBut.Text = "Вывести имя куратора";
            this.CuratorNameBut.UseVisualStyleBackColor = true;
            this.CuratorNameBut.Click += new System.EventHandler(this.CuratorNameBut_Click);
            // 
            // NumInGroupLabel
            // 
            this.NumInGroupLabel.AutoSize = true;
            this.NumInGroupLabel.Location = new System.Drawing.Point(48, 464);
            this.NumInGroupLabel.Name = "NumInGroupLabel";
            this.NumInGroupLabel.Size = new System.Drawing.Size(0, 25);
            this.NumInGroupLabel.TabIndex = 22;
            // 
            // CuratorNameLabel
            // 
            this.CuratorNameLabel.AutoSize = true;
            this.CuratorNameLabel.Location = new System.Drawing.Point(431, 464);
            this.CuratorNameLabel.Name = "CuratorNameLabel";
            this.CuratorNameLabel.Size = new System.Drawing.Size(0, 25);
            this.CuratorNameLabel.TabIndex = 23;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(1204, 634);
            this.dataGridView.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GroupCB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AgeTB);
            this.groupBox1.Controls.Add(this.NameTB);
            this.groupBox1.Controls.Add(this.CreateBut);
            this.groupBox1.Location = new System.Drawing.Point(12, 666);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1174, 166);
            this.groupBox1.TabIndex = 26;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Возраст";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя";
            // 
            // AgeTB
            // 
            this.AgeTB.Location = new System.Drawing.Point(696, 74);
            this.AgeTB.Name = "AgeTB";
            this.AgeTB.Size = new System.Drawing.Size(150, 31);
            this.AgeTB.TabIndex = 2;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(144, 74);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(150, 31);
            this.NameTB.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NumInGroupLabel1);
            this.groupBox2.Controls.Add(this.NumberInGroupBut);
            this.groupBox2.Location = new System.Drawing.Point(1222, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 241);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Количество студентов в группе";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CuratorNameLabel1);
            this.groupBox3.Controls.Add(this.CuratorNameBut);
            this.groupBox3.Location = new System.Drawing.Point(1222, 405);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 241);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Куратор группы";
            // 
            // NumInGroupLabel1
            // 
            this.NumInGroupLabel1.AutoSize = true;
            this.NumInGroupLabel1.Location = new System.Drawing.Point(14, 180);
            this.NumInGroupLabel1.Name = "NumInGroupLabel1";
            this.NumInGroupLabel1.Size = new System.Drawing.Size(0, 25);
            this.NumInGroupLabel1.TabIndex = 21;
            // 
            // CuratorNameLabel1
            // 
            this.CuratorNameLabel1.AutoSize = true;
            this.CuratorNameLabel1.Location = new System.Drawing.Point(14, 176);
            this.CuratorNameLabel1.Name = "CuratorNameLabel1";
            this.CuratorNameLabel1.Size = new System.Drawing.Size(0, 25);
            this.CuratorNameLabel1.TabIndex = 22;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.CuratorNameLabel);
            this.Controls.Add(this.NumInGroupLabel);
            this.Controls.Add(this.DeleteBut);
            this.Controls.Add(this.ChangeBut);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateBut;
        private System.Windows.Forms.Button ChangeBut;
        private System.Windows.Forms.Button DeleteBut;
        private System.Windows.Forms.Button NumberInGroupBut;
        private System.Windows.Forms.Button CuratorNameBut;
        private System.Windows.Forms.Label NumInGroupLabel;
        private System.Windows.Forms.Label CuratorNameLabel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox AgeTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GroupCB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label NumInGroupLabel1;
        private System.Windows.Forms.Label CuratorNameLabel1;
    }
}