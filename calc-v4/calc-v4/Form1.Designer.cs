namespace calc_v4
{
    partial class Form1
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.path_to_CSV = new System.Windows.Forms.TextBox();
            this.form_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.path_to_results = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.percent_profile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.percent_stage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.stage_duration = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ramp_up = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.first_ramp_up = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(400, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "Подтвердить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // path_to_CSV
            // 
            this.path_to_CSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.path_to_CSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.path_to_CSV.Location = new System.Drawing.Point(231, 118);
            this.path_to_CSV.Margin = new System.Windows.Forms.Padding(5);
            this.path_to_CSV.Name = "path_to_CSV";
            this.path_to_CSV.Size = new System.Drawing.Size(732, 27);
            this.path_to_CSV.TabIndex = 0;
            // 
            // form_name
            // 
            this.form_name.AutoSize = true;
            this.form_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_name.Location = new System.Drawing.Point(320, 37);
            this.form_name.Name = "form_name";
            this.form_name.Size = new System.Drawing.Size(314, 36);
            this.form_name.TabIndex = 1;
            this.form_name.Text = "Регистрация конфига";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(110, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Путь до csv:";
            // 
            // path_to_results
            // 
            this.path_to_results.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.path_to_results.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.path_to_results.Location = new System.Drawing.Point(231, 155);
            this.path_to_results.Margin = new System.Windows.Forms.Padding(5);
            this.path_to_results.Name = "path_to_results";
            this.path_to_results.Size = new System.Drawing.Size(732, 27);
            this.path_to_results.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Путь до результатов:";
            // 
            // percent_profile
            // 
            this.percent_profile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.percent_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percent_profile.Location = new System.Drawing.Point(231, 192);
            this.percent_profile.Margin = new System.Windows.Forms.Padding(5);
            this.percent_profile.Name = "percent_profile";
            this.percent_profile.Size = new System.Drawing.Size(732, 27);
            this.percent_profile.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(54, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Макс профиль (%):";
            // 
            // percent_stage
            // 
            this.percent_stage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.percent_stage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percent_stage.Location = new System.Drawing.Point(777, 266);
            this.percent_stage.Margin = new System.Windows.Forms.Padding(5);
            this.percent_stage.Name = "percent_stage";
            this.percent_stage.Size = new System.Drawing.Size(80, 27);
            this.percent_stage.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(589, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Размер ступени (%):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(38, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Время ступени (сек):";
            // 
            // stage_duration
            // 
            this.stage_duration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stage_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stage_duration.Location = new System.Drawing.Point(231, 266);
            this.stage_duration.Margin = new System.Windows.Forms.Padding(5);
            this.stage_duration.Name = "stage_duration";
            this.stage_duration.Size = new System.Drawing.Size(80, 27);
            this.stage_duration.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(340, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Ramp-up (сек):";
            // 
            // ramp_up
            // 
            this.ramp_up.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ramp_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ramp_up.Location = new System.Drawing.Point(475, 266);
            this.ramp_up.Margin = new System.Windows.Forms.Padding(5);
            this.ramp_up.Name = "ramp_up";
            this.ramp_up.Size = new System.Drawing.Size(80, 27);
            this.ramp_up.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(26, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Первый Ramp-up (сек):";
            // 
            // first_ramp_up
            // 
            this.first_ramp_up.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.first_ramp_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first_ramp_up.Location = new System.Drawing.Point(231, 229);
            this.first_ramp_up.Margin = new System.Windows.Forms.Padding(5);
            this.first_ramp_up.Name = "first_ramp_up";
            this.first_ramp_up.Size = new System.Drawing.Size(732, 27);
            this.first_ramp_up.TabIndex = 24;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Items.AddRange(new object[] { "Макс профиль (%) - профиль, который мы берем для макс перфа", "Время ступени (сек) - время стабилизации нагрузки на ступени", "Размер ступени (%) -  % от профиля, на который ступень поднимает нагрузку", "Путь до результатов, пример: C:\\files\\calc\\" });
            this.listBox1.Location = new System.Drawing.Point(144, 357);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(681, 119);
            this.listBox1.TabIndex = 26;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.first_ramp_up);
            this.Controls.Add(this.ramp_up);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.stage_duration);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.percent_stage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.percent_profile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.path_to_results);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.form_name);
            this.Controls.Add(this.path_to_CSV);
            this.Controls.Add(this.button1);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "calc-v4";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox path_to_CSV;
        private System.Windows.Forms.Label form_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox path_to_results;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox percent_profile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox percent_stage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox stage_duration;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ramp_up;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox first_ramp_up;
        private System.Windows.Forms.ListBox listBox1;
    }
}

