
namespace Presentation
{
    partial class GroupForm
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
            this.DeleteBut = new System.Windows.Forms.Button();
            this.ChangeBut = new System.Windows.Forms.Button();
            this.CreateBut = new System.Windows.Forms.Button();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SuccessLabel
            // 
            this.SuccessLabel.AutoSize = true;
            this.SuccessLabel.Location = new System.Drawing.Point(1431, 456);
            this.SuccessLabel.Name = "SuccessLabel";
            this.SuccessLabel.Size = new System.Drawing.Size(0, 25);
            this.SuccessLabel.TabIndex = 70;
            // 
            // DeleteBut
            // 
            this.DeleteBut.Location = new System.Drawing.Point(1312, 66);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(242, 34);
            this.DeleteBut.TabIndex = 69;
            this.DeleteBut.Text = "Удалить";
            this.DeleteBut.UseVisualStyleBackColor = true;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // ChangeBut
            // 
            this.ChangeBut.Location = new System.Drawing.Point(1312, 12);
            this.ChangeBut.Name = "ChangeBut";
            this.ChangeBut.Size = new System.Drawing.Size(242, 34);
            this.ChangeBut.TabIndex = 68;
            this.ChangeBut.Text = "Изменить";
            this.ChangeBut.UseVisualStyleBackColor = true;
            this.ChangeBut.Click += new System.EventHandler(this.ChangeBut_Click);
            // 
            // CreateBut
            // 
            this.CreateBut.Location = new System.Drawing.Point(887, 73);
            this.CreateBut.Name = "CreateBut";
            this.CreateBut.Size = new System.Drawing.Size(242, 34);
            this.CreateBut.TabIndex = 57;
            this.CreateBut.Text = "Создать ";
            this.CreateBut.UseVisualStyleBackColor = true;
            this.CreateBut.Click += new System.EventHandler(this.CreateBut_Click);
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(144, 75);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(150, 31);
            this.NameTB.TabIndex = 52;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(1204, 634);
            this.dataGridView.TabIndex = 71;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.NameTB);
            this.groupBox1.Controls.Add(this.CreateBut);
            this.groupBox1.Location = new System.Drawing.Point(12, 652);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1174, 166);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Группа";
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
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.SuccessLabel);
            this.Controls.Add(this.DeleteBut);
            this.Controls.Add(this.ChangeBut);
            this.Name = "GroupForm";
            this.Text = "GroupForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SuccessLabel;
        private System.Windows.Forms.Button DeleteBut;
        private System.Windows.Forms.Button ChangeBut;
        private System.Windows.Forms.Button CreateBut;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
    }
}