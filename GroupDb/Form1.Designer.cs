namespace GroupDb
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Add_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Remove_Button = new System.Windows.Forms.Button();
            this.Form_Edit = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.GroupEditBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameEditBox = new System.Windows.Forms.TextBox();
            this.NumberEditBox = new System.Windows.Forms.TextBox();
            this.EmailEditBox = new System.Windows.Forms.TextBox();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Form_Add = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.GroupBox = new System.Windows.Forms.TextBox();
            this.Submit_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupdbDataSet = new GroupDb.GroupdbDataSet();
            this.groupListDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tARpv19BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupdbDataSet1 = new GroupDb.GroupdbDataSet1();
            this.tARpv19TableAdapter = new GroupDb.GroupdbDataSet1TableAdapters.TARpv19TableAdapter();
            this.panel1.SuspendLayout();
            this.Form_Edit.SuspendLayout();
            this.Form_Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupListDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tARpv19BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupdbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.Color.Black;
            this.Add_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Add_Button.FlatAppearance.BorderSize = 0;
            this.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Button.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add_Button.Location = new System.Drawing.Point(0, 84);
            this.Add_Button.Margin = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(148, 36);
            this.Add_Button.TabIndex = 0;
            this.Add_Button.Text = "Add";
            this.Add_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.Remove_Button);
            this.panel1.Controls.Add(this.Form_Edit);
            this.panel1.Controls.Add(this.Edit_button);
            this.panel1.Controls.Add(this.Form_Add);
            this.panel1.Controls.Add(this.Add_Button);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 511);
            this.panel1.TabIndex = 1;
            // 
            // Remove_Button
            // 
            this.Remove_Button.BackColor = System.Drawing.Color.Black;
            this.Remove_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Remove_Button.FlatAppearance.BorderSize = 0;
            this.Remove_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove_Button.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.Remove_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Remove_Button.Location = new System.Drawing.Point(0, 660);
            this.Remove_Button.Margin = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(148, 36);
            this.Remove_Button.TabIndex = 3;
            this.Remove_Button.Text = "Remove";
            this.Remove_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Remove_Button.UseVisualStyleBackColor = false;
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // Form_Edit
            // 
            this.Form_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Form_Edit.Controls.Add(this.label7);
            this.Form_Edit.Controls.Add(this.GroupEditBox);
            this.Form_Edit.Controls.Add(this.button1);
            this.Form_Edit.Controls.Add(this.label4);
            this.Form_Edit.Controls.Add(this.label6);
            this.Form_Edit.Controls.Add(this.label5);
            this.Form_Edit.Controls.Add(this.NameEditBox);
            this.Form_Edit.Controls.Add(this.NumberEditBox);
            this.Form_Edit.Controls.Add(this.EmailEditBox);
            this.Form_Edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.Form_Edit.Location = new System.Drawing.Point(0, 406);
            this.Form_Edit.Name = "Form_Edit";
            this.Form_Edit.Size = new System.Drawing.Size(148, 254);
            this.Form_Edit.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 10.18868F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(8, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Group";
            // 
            // GroupEditBox
            // 
            this.GroupEditBox.Location = new System.Drawing.Point(8, 178);
            this.GroupEditBox.Name = "GroupEditBox";
            this.GroupEditBox.Size = new System.Drawing.Size(137, 20);
            this.GroupEditBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10.18868F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(8, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.18868F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(8, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10.18868F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(8, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10.18868F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(8, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Number";
            // 
            // NameEditBox
            // 
            this.NameEditBox.Location = new System.Drawing.Point(8, 37);
            this.NameEditBox.Name = "NameEditBox";
            this.NameEditBox.Size = new System.Drawing.Size(137, 20);
            this.NameEditBox.TabIndex = 10;
            // 
            // NumberEditBox
            // 
            this.NumberEditBox.Location = new System.Drawing.Point(8, 84);
            this.NumberEditBox.Name = "NumberEditBox";
            this.NumberEditBox.Size = new System.Drawing.Size(137, 20);
            this.NumberEditBox.TabIndex = 11;
            // 
            // EmailEditBox
            // 
            this.EmailEditBox.Location = new System.Drawing.Point(8, 131);
            this.EmailEditBox.Name = "EmailEditBox";
            this.EmailEditBox.Size = new System.Drawing.Size(137, 20);
            this.EmailEditBox.TabIndex = 12;
            // 
            // Edit_button
            // 
            this.Edit_button.BackColor = System.Drawing.Color.Black;
            this.Edit_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Edit_button.FlatAppearance.BorderSize = 0;
            this.Edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_button.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.Edit_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Edit_button.Location = new System.Drawing.Point(0, 370);
            this.Edit_button.Margin = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(148, 36);
            this.Edit_button.TabIndex = 4;
            this.Edit_button.Text = "Edit";
            this.Edit_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit_button.UseVisualStyleBackColor = false;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Form_Add
            // 
            this.Form_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Form_Add.Controls.Add(this.label8);
            this.Form_Add.Controls.Add(this.GroupBox);
            this.Form_Add.Controls.Add(this.Submit_Button);
            this.Form_Add.Controls.Add(this.label3);
            this.Form_Add.Controls.Add(this.label2);
            this.Form_Add.Controls.Add(this.label1);
            this.Form_Add.Controls.Add(this.EmailBox);
            this.Form_Add.Controls.Add(this.NumberBox);
            this.Form_Add.Controls.Add(this.NameBox);
            this.Form_Add.Dock = System.Windows.Forms.DockStyle.Top;
            this.Form_Add.Location = new System.Drawing.Point(0, 120);
            this.Form_Add.Name = "Form_Add";
            this.Form_Add.Size = new System.Drawing.Size(148, 250);
            this.Form_Add.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 10.18868F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(12, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Group";
            // 
            // GroupBox
            // 
            this.GroupBox.Location = new System.Drawing.Point(12, 173);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(137, 20);
            this.GroupBox.TabIndex = 10;
            // 
            // Submit_Button
            // 
            this.Submit_Button.BackColor = System.Drawing.Color.Gray;
            this.Submit_Button.FlatAppearance.BorderSize = 0;
            this.Submit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit_Button.Font = new System.Drawing.Font("Nirmala UI", 10.18868F);
            this.Submit_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Submit_Button.Location = new System.Drawing.Point(12, 199);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(137, 39);
            this.Submit_Button.TabIndex = 6;
            this.Submit_Button.Text = "Submit";
            this.Submit_Button.UseVisualStyleBackColor = false;
            this.Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.18868F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.18868F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.18868F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(12, 126);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(137, 20);
            this.EmailBox.TabIndex = 6;
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(12, 79);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(137, 20);
            this.NumberBox.TabIndex = 4;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(12, 32);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(137, 20);
            this.NameBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 84);
            this.panel2.TabIndex = 2;
            // 
            // groupdbDataSetBindingSource
            // 
            this.groupdbDataSetBindingSource.DataSource = this.groupdbDataSet;
            this.groupdbDataSetBindingSource.Position = 0;
            // 
            // groupdbDataSet
            // 
            this.groupdbDataSet.DataSetName = "GroupdbDataSet";
            this.groupdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(234, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 215);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // tARpv19BindingSource
            // 
            this.tARpv19BindingSource.DataMember = "TARpv19";
            this.tARpv19BindingSource.DataSource = this.groupdbDataSet1;
            // 
            // groupdbDataSet1
            // 
            this.groupdbDataSet1.DataSetName = "GroupdbDataSet1";
            this.groupdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tARpv19TableAdapter
            // 
            this.tARpv19TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(844, 511);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "      ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.Form_Edit.ResumeLayout(false);
            this.Form_Edit.PerformLayout();
            this.Form_Add.ResumeLayout(false);
            this.Form_Add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupListDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tARpv19BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupdbDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Remove_Button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.BindingSource groupListDataSetBindingSource;
        private System.Windows.Forms.Panel Form_Add;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.BindingSource groupdbDataSetBindingSource;
        private GroupdbDataSet groupdbDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GroupdbDataSet1 groupdbDataSet1;
        private System.Windows.Forms.BindingSource tARpv19BindingSource;
        private GroupdbDataSet1TableAdapters.TARpv19TableAdapter tARpv19TableAdapter;
        private System.Windows.Forms.Panel Form_Edit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameEditBox;
        private System.Windows.Forms.TextBox NumberEditBox;
        private System.Windows.Forms.TextBox EmailEditBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox GroupEditBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox GroupBox;
    }
}

