using System;

namespace HW_MessageBoxLab
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip_time = new System.Windows.Forms.StatusStrip();
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_messange_text = new System.Windows.Forms.Label();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.lb_btn = new System.Windows.Forms.Label();
            this.cb_btn = new System.Windows.Forms.ComboBox();
            this.lb_icon = new System.Windows.Forms.Label();
            this.cb_icon = new System.Windows.Forms.ComboBox();
            this.btn_create_mesBox = new System.Windows.Forms.Button();
            this.gb_BackColorForm = new System.Windows.Forms.GroupBox();
            this.rb_defolt = new System.Windows.Forms.RadioButton();
            this.rb_green = new System.Windows.Forms.RadioButton();
            this.rb_blue = new System.Windows.Forms.RadioButton();
            this.rb_red = new System.Windows.Forms.RadioButton();
            this.chb_green = new System.Windows.Forms.CheckBox();
            this.chb_blue = new System.Windows.Forms.CheckBox();
            this.chb_red = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_dynamic_back_color = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gb_BackColorForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip_time
            // 
            this.statusStrip_time.Location = new System.Drawing.Point(0, 428);
            this.statusStrip_time.Name = "statusStrip_time";
            this.statusStrip_time.Size = new System.Drawing.Size(800, 22);
            this.statusStrip_time.TabIndex = 0;
            this.statusStrip_time.Text = "statusStrip1";
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_title.Location = new System.Drawing.Point(23, 13);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(214, 20);
            this.lb_title.TabIndex = 1;
            this.lb_title.Text = "Конструктор сообщений";
            // 
            // lb_messange_text
            // 
            this.lb_messange_text.AutoSize = true;
            this.lb_messange_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_messange_text.Location = new System.Drawing.Point(61, 69);
            this.lb_messange_text.Name = "lb_messange_text";
            this.lb_messange_text.Size = new System.Drawing.Size(107, 15);
            this.lb_messange_text.TabIndex = 2;
            this.lb_messange_text.Text = "Текст сообщения";
            // 
            // tb_message
            // 
            this.tb_message.Location = new System.Drawing.Point(174, 68);
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(248, 20);
            this.tb_message.TabIndex = 3;
            this.tb_message.Text = "введите текст сообщения";
            // 
            // lb_btn
            // 
            this.lb_btn.AutoSize = true;
            this.lb_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_btn.Location = new System.Drawing.Point(12, 107);
            this.lb_btn.Name = "lb_btn";
            this.lb_btn.Size = new System.Drawing.Size(156, 15);
            this.lb_btn.TabIndex = 2;
            this.lb_btn.Text = "Кнопки в окне сообщения";
            // 
            // cb_btn
            // 
            this.cb_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_btn.FormattingEnabled = true;
            this.cb_btn.Items.AddRange(new object[] {
            "OK",
            "OK и Отмена",
            "Да и Нет",
            "Да и Нет и Отмена",
            "Прервать и Повтор и Пропустить",
            "Повтор и Отмена"});
            this.cb_btn.Location = new System.Drawing.Point(174, 107);
            this.cb_btn.Name = "cb_btn";
            this.cb_btn.Size = new System.Drawing.Size(248, 21);
            this.cb_btn.TabIndex = 3;
            this.cb_btn.Text = "выберите кнопки окна сообщения";
            this.cb_btn.SelectedIndexChanged += new System.EventHandler(this.cb_btn_SelectedIndexChanged);
            // 
            // lb_icon
            // 
            this.lb_icon.AutoSize = true;
            this.lb_icon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_icon.Location = new System.Drawing.Point(12, 145);
            this.lb_icon.Name = "lb_icon";
            this.lb_icon.Size = new System.Drawing.Size(156, 15);
            this.lb_icon.TabIndex = 2;
            this.lb_icon.Text = "Иконка в окне сообщения";
            // 
            // cb_icon
            // 
            this.cb_icon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_icon.FormattingEnabled = true;
            this.cb_icon.Items.AddRange(new object[] {
            "Внимание",
            "Информация",
            "Стоп",
            "Ошибка",
            "Вопрос"});
            this.cb_icon.Location = new System.Drawing.Point(174, 144);
            this.cb_icon.Name = "cb_icon";
            this.cb_icon.Size = new System.Drawing.Size(248, 21);
            this.cb_icon.TabIndex = 3;
            this.cb_icon.Text = "выберите иконку окна сообщения";
            this.cb_icon.SelectedIndexChanged += new System.EventHandler(this.cb_icon_SelectedIndexChanged);
            // 
            // btn_create_mesBox
            // 
            this.btn_create_mesBox.BackColor = System.Drawing.Color.Lime;
            this.btn_create_mesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_create_mesBox.Location = new System.Drawing.Point(174, 193);
            this.btn_create_mesBox.Name = "btn_create_mesBox";
            this.btn_create_mesBox.Size = new System.Drawing.Size(248, 28);
            this.btn_create_mesBox.TabIndex = 4;
            this.btn_create_mesBox.Text = "Создать Message Box";
            this.btn_create_mesBox.UseVisualStyleBackColor = false;
            this.btn_create_mesBox.Click += new System.EventHandler(this.btn_create_mesBox_Click);
            // 
            // gb_BackColorForm
            // 
            this.gb_BackColorForm.BackColor = System.Drawing.SystemColors.Control;
            this.gb_BackColorForm.Controls.Add(this.rb_defolt);
            this.gb_BackColorForm.Controls.Add(this.rb_green);
            this.gb_BackColorForm.Controls.Add(this.rb_blue);
            this.gb_BackColorForm.Controls.Add(this.rb_red);
            this.gb_BackColorForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_BackColorForm.Location = new System.Drawing.Point(529, 69);
            this.gb_BackColorForm.Name = "gb_BackColorForm";
            this.gb_BackColorForm.Size = new System.Drawing.Size(200, 142);
            this.gb_BackColorForm.TabIndex = 5;
            this.gb_BackColorForm.TabStop = false;
            this.gb_BackColorForm.Text = "Изменить цвет фона формы";
            // 
            // rb_defolt
            // 
            this.rb_defolt.AutoSize = true;
            this.rb_defolt.Location = new System.Drawing.Point(21, 106);
            this.rb_defolt.Name = "rb_defolt";
            this.rb_defolt.Size = new System.Drawing.Size(103, 17);
            this.rb_defolt.TabIndex = 3;
            this.rb_defolt.TabStop = true;
            this.rb_defolt.Text = "Стандартный";
            this.rb_defolt.UseVisualStyleBackColor = true;
            this.rb_defolt.CheckedChanged += new System.EventHandler(this.rb_defolt_CheckedChanged);
            // 
            // rb_green
            // 
            this.rb_green.AutoSize = true;
            this.rb_green.Location = new System.Drawing.Point(21, 82);
            this.rb_green.Name = "rb_green";
            this.rb_green.Size = new System.Drawing.Size(77, 17);
            this.rb_green.TabIndex = 2;
            this.rb_green.TabStop = true;
            this.rb_green.Text = "Зеленый";
            this.rb_green.UseVisualStyleBackColor = true;
            this.rb_green.CheckedChanged += new System.EventHandler(this.rb_green_CheckedChanged);
            // 
            // rb_blue
            // 
            this.rb_blue.AutoSize = true;
            this.rb_blue.Location = new System.Drawing.Point(21, 59);
            this.rb_blue.Name = "rb_blue";
            this.rb_blue.Size = new System.Drawing.Size(61, 17);
            this.rb_blue.TabIndex = 1;
            this.rb_blue.TabStop = true;
            this.rb_blue.Text = "Синий";
            this.rb_blue.UseVisualStyleBackColor = true;
            this.rb_blue.CheckedChanged += new System.EventHandler(this.rb_blue_CheckedChanged);
            // 
            // rb_red
            // 
            this.rb_red.AutoSize = true;
            this.rb_red.Location = new System.Drawing.Point(21, 36);
            this.rb_red.Name = "rb_red";
            this.rb_red.Size = new System.Drawing.Size(77, 17);
            this.rb_red.TabIndex = 1;
            this.rb_red.TabStop = true;
            this.rb_red.Text = "Красный";
            this.rb_red.UseVisualStyleBackColor = true;
            this.rb_red.CheckedChanged += new System.EventHandler(this.rb_red_CheckedChanged);
            // 
            // chb_green
            // 
            this.chb_green.AutoSize = true;
            this.chb_green.Location = new System.Drawing.Point(6, 104);
            this.chb_green.Name = "chb_green";
            this.chb_green.Size = new System.Drawing.Size(78, 17);
            this.chb_green.TabIndex = 0;
            this.chb_green.Text = "Зеленый";
            this.chb_green.UseVisualStyleBackColor = true;
            this.chb_green.CheckedChanged += new System.EventHandler(this.chb_green_CheckedChanged);
            // 
            // chb_blue
            // 
            this.chb_blue.AutoSize = true;
            this.chb_blue.Location = new System.Drawing.Point(6, 81);
            this.chb_blue.Name = "chb_blue";
            this.chb_blue.Size = new System.Drawing.Size(62, 17);
            this.chb_blue.TabIndex = 0;
            this.chb_blue.Text = "Синий";
            this.chb_blue.UseVisualStyleBackColor = true;
            this.chb_blue.CheckedChanged += new System.EventHandler(this.chb_blue_CheckedChanged);
            // 
            // chb_red
            // 
            this.chb_red.AutoSize = true;
            this.chb_red.Location = new System.Drawing.Point(6, 58);
            this.chb_red.Name = "chb_red";
            this.chb_red.Size = new System.Drawing.Size(78, 17);
            this.chb_red.TabIndex = 0;
            this.chb_red.Text = "Красный";
            this.chb_red.UseVisualStyleBackColor = true;
            this.chb_red.CheckedChanged += new System.EventHandler(this.chb_red_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_dynamic_back_color);
            this.groupBox1.Controls.Add(this.chb_red);
            this.groupBox1.Controls.Add(this.chb_blue);
            this.groupBox1.Controls.Add(this.chb_green);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(529, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 127);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Динамическая смена фона Выбери цвета";
            // 
            // rb_dynamic_back_color
            // 
            this.rb_dynamic_back_color.AutoSize = true;
            this.rb_dynamic_back_color.Location = new System.Drawing.Point(7, 35);
            this.rb_dynamic_back_color.Name = "rb_dynamic_back_color";
            this.rb_dynamic_back_color.Size = new System.Drawing.Size(140, 17);
            this.rb_dynamic_back_color.TabIndex = 1;
            this.rb_dynamic_back_color.TabStop = true;
            this.rb_dynamic_back_color.Text = "Динамический фон";
            this.rb_dynamic_back_color.UseVisualStyleBackColor = true;
            this.rb_dynamic_back_color.CheckedChanged += new System.EventHandler(this.rb_dynamic_back_color_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_BackColorForm);
            this.Controls.Add(this.btn_create_mesBox);
            this.Controls.Add(this.cb_icon);
            this.Controls.Add(this.cb_btn);
            this.Controls.Add(this.tb_message);
            this.Controls.Add(this.lb_icon);
            this.Controls.Add(this.lb_btn);
            this.Controls.Add(this.lb_messange_text);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.statusStrip_time);
            this.Name = "Form1";
            this.Text = "Message constructor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_BackColorForm.ResumeLayout(false);
            this.gb_BackColorForm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip_time;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_messange_text;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.Label lb_btn;
        private System.Windows.Forms.ComboBox cb_btn;
        private System.Windows.Forms.Label lb_icon;
        private System.Windows.Forms.ComboBox cb_icon;
        private System.Windows.Forms.Button btn_create_mesBox;
        private System.Windows.Forms.GroupBox gb_BackColorForm;
        private System.Windows.Forms.RadioButton rb_red;
        private System.Windows.Forms.CheckBox chb_green;
        private System.Windows.Forms.CheckBox chb_blue;
        private System.Windows.Forms.CheckBox chb_red;
        private System.Windows.Forms.RadioButton rb_blue;
        private System.Windows.Forms.RadioButton rb_green;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_defolt;
        private System.Windows.Forms.RadioButton rb_dynamic_back_color;
        private System.Windows.Forms.Timer timer1;
    }
}

