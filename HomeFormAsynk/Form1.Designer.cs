namespace HomeFormAsynk
{
    partial class asynk_Form
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_inputsite = new System.Windows.Forms.TextBox();
            this.addsite = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.site_list = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.req_res = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.delete_one_site = new System.Windows.Forms.Button();
            this.delete_list = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.initial_site_list = new System.Windows.Forms.Button();
            this.makerequest_button = new System.Windows.Forms.Button();
            this.button_manual = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.52817F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.87244F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.83514F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.67268F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.44886F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_inputsite, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.addsite, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.delete_one_site, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.delete_list, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.initial_site_list, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.makerequest_button, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_manual, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.439019F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.82652F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.26144F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.278867F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.535948F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.714597F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.30501F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(831, 459);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add site address";
            // 
            // textBox_inputsite
            // 
            this.textBox_inputsite.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_inputsite.Location = new System.Drawing.Point(3, 27);
            this.textBox_inputsite.Name = "textBox_inputsite";
            this.textBox_inputsite.Size = new System.Drawing.Size(147, 20);
            this.textBox_inputsite.TabIndex = 4;
            this.textBox_inputsite.Text = "http://www";
            // 
            // addsite
            // 
            this.addsite.Location = new System.Drawing.Point(3, 80);
            this.addsite.Name = "addsite";
            this.addsite.Size = new System.Drawing.Size(100, 23);
            this.addsite.TabIndex = 5;
            this.addsite.Text = "Add";
            this.addsite.UseVisualStyleBackColor = true;
            this.addsite.Click += new System.EventHandler(this.addsite_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.site_list,
            this.req_res});
            this.tableLayoutPanel1.SetColumnSpan(this.listView1, 2);
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(156, 27);
            this.listView1.Name = "listView1";
            this.tableLayoutPanel1.SetRowSpan(this.listView1, 2);
            this.listView1.Size = new System.Drawing.Size(430, 138);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.delete_one_site_Click);
            // 
            // site_list
            // 
            this.site_list.Text = "Site Address";
            this.site_list.Width = 337;
            // 
            // req_res
            // 
            this.req_res.Text = "Reques Res.";
            this.req_res.Width = 88;
            // 
            // delete_one_site
            // 
            this.delete_one_site.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.delete_one_site.Location = new System.Drawing.Point(370, 179);
            this.delete_one_site.Name = "delete_one_site";
            this.delete_one_site.Size = new System.Drawing.Size(216, 23);
            this.delete_one_site.TabIndex = 7;
            this.delete_one_site.Text = "Delete";
            this.delete_one_site.UseVisualStyleBackColor = true;
            this.delete_one_site.Click += new System.EventHandler(this.delete_one_site_Click);
            // 
            // delete_list
            // 
            this.delete_list.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.delete_list.Location = new System.Drawing.Point(156, 179);
            this.delete_list.Name = "delete_list";
            this.delete_list.Size = new System.Drawing.Size(208, 23);
            this.delete_list.TabIndex = 8;
            this.delete_list.Text = "Delete All";
            this.delete_list.UseVisualStyleBackColor = true;
            this.delete_list.Click += new System.EventHandler(this.delete_list_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sites List";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // initial_site_list
            // 
            this.initial_site_list.Dock = System.Windows.Forms.DockStyle.Top;
            this.initial_site_list.Location = new System.Drawing.Point(592, 27);
            this.initial_site_list.Name = "initial_site_list";
            this.initial_site_list.Size = new System.Drawing.Size(90, 23);
            this.initial_site_list.TabIndex = 9;
            this.initial_site_list.Text = "Initial List";
            this.initial_site_list.UseVisualStyleBackColor = true;
            this.initial_site_list.Click += new System.EventHandler(this.initial_site_list_Click);
            // 
            // makerequest_button
            // 
            this.makerequest_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.makerequest_button.Location = new System.Drawing.Point(592, 80);
            this.makerequest_button.Name = "makerequest_button";
            this.makerequest_button.Size = new System.Drawing.Size(90, 23);
            this.makerequest_button.TabIndex = 10;
            this.makerequest_button.Text = "Make request";
            this.makerequest_button.UseVisualStyleBackColor = true;
            this.makerequest_button.Click += new System.EventHandler(this.makerequest_button_Click);
            // 
            // button_manual
            // 
            this.button_manual.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_manual.Location = new System.Drawing.Point(753, 27);
            this.button_manual.Name = "button_manual";
            this.button_manual.Size = new System.Drawing.Size(75, 47);
            this.button_manual.TabIndex = 11;
            this.button_manual.Text = "Manual List";
            this.button_manual.UseVisualStyleBackColor = true;
            this.button_manual.Click += new System.EventHandler(this.button_manual_Click);
            // 
            // asynk_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 459);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "asynk_Form";
            this.Text = "AsynkForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_inputsite;
        private System.Windows.Forms.Button addsite;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader site_list;
        private System.Windows.Forms.Button delete_one_site;
        private System.Windows.Forms.Button delete_list;
        private System.Windows.Forms.Button initial_site_list;
        private System.Windows.Forms.Button makerequest_button;
        private System.Windows.Forms.ColumnHeader req_res;
        private System.Windows.Forms.Button button_manual;
    }
}

