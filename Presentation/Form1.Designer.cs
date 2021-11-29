
namespace Presentation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.StudentBut = new System.Windows.Forms.Button();
            this.GroupBut = new System.Windows.Forms.Button();
            this.CuratorBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберете сущность:";
            // 
            // StudentBut
            // 
            this.StudentBut.Location = new System.Drawing.Point(12, 78);
            this.StudentBut.Name = "StudentBut";
            this.StudentBut.Size = new System.Drawing.Size(158, 60);
            this.StudentBut.TabIndex = 1;
            this.StudentBut.Text = "Студент";
            this.StudentBut.UseVisualStyleBackColor = true;
            this.StudentBut.Click += new System.EventHandler(this.StudentBut_Click);
            // 
            // GroupBut
            // 
            this.GroupBut.Location = new System.Drawing.Point(12, 157);
            this.GroupBut.Name = "GroupBut";
            this.GroupBut.Size = new System.Drawing.Size(158, 60);
            this.GroupBut.TabIndex = 2;
            this.GroupBut.Text = "Группа";
            this.GroupBut.UseVisualStyleBackColor = true;
            // 
            // CuratorBut
            // 
            this.CuratorBut.Location = new System.Drawing.Point(12, 241);
            this.CuratorBut.Name = "CuratorBut";
            this.CuratorBut.Size = new System.Drawing.Size(158, 60);
            this.CuratorBut.TabIndex = 3;
            this.CuratorBut.Text = "Куратор";
            this.CuratorBut.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(205, 352);
            this.Controls.Add(this.CuratorBut);
            this.Controls.Add(this.GroupBut);
            this.Controls.Add(this.StudentBut);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StudentBut;
        private System.Windows.Forms.Button GroupBut;
        private System.Windows.Forms.Button CuratorBut;
    }
}

