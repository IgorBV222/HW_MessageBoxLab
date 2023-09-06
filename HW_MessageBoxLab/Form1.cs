using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_MessageBoxLab
{
    public partial class Form1 : Form
    {
        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        ToolStripLabel infoLabel;
        List<Color> _colors = new List<Color>();
        Timer timer;


        MessageBoxButtons _buttons;
        MessageBoxIcon _icon;
        public Form1()
        {
            InitializeComponent();
            infoLabel = new ToolStripLabel();
            infoLabel.Text = "Текущие дата и время:";
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();

            statusStrip_time.Items.Add(infoLabel);
            statusStrip_time.Items.Add(dateLabel);
            statusStrip_time.Items.Add(timeLabel);

            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();

            timer1 = new Timer() { Interval = 5000 };   
            timer1.Tick += timer1_Tick;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var dt = DateTime.Now.ToString("HH:mm:ss");
            Text += $"  Старт в {dt}";
        }

        private void btn_create_mesBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tb_message.Text, "Message", _buttons, _icon);
        }
        private void SelectedButtons(string item)
        {
            switch (item)
            {
                case "OK": _buttons = MessageBoxButtons.OK; break;
                case "OK и Отмена": _buttons = MessageBoxButtons.OKCancel; break;
                case "Да и Нет": _buttons = MessageBoxButtons.YesNo; break;
                case "Да и Нет и Отмена": _buttons = MessageBoxButtons.YesNoCancel; break;
                case "Прервать и Повтор и Пропустить": _buttons = MessageBoxButtons.AbortRetryIgnore; break;
                case "Повтор и Отмена": _buttons = MessageBoxButtons.RetryCancel; break; 
                default: _buttons = MessageBoxButtons.OK; break;
            }
        }
        private void cb_btn_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedButtons(cb_btn.SelectedItem.ToString());
        }
        private void SelectedIcon(string item)
        {
            switch (item)
            {
                case "Внимание": _icon = MessageBoxIcon.Warning; break;
                case "Стоп": _icon = MessageBoxIcon.Stop; break;
                case "Вопрос": _icon = MessageBoxIcon.Question; break;
                case "Информация": _icon = MessageBoxIcon.Information; break;
                case "Ошибка": _icon = MessageBoxIcon.Error; break;
                default: _icon = MessageBoxIcon.None; break;
            }
        }  
        private void cb_icon_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIcon(cb_icon.SelectedItem.ToString());
        }
        private void chb_red_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_red.Checked)
            {
                //this.BackColor = Color.Red;
                //chb_red.Enabled = true;
                _colors.Add(Color.Red);

            }
            //else
            //{
            //    this.BackColor = SystemColors.Control;
            //    chb_red.Checked = false;
            //}      
        }
        private void chb_blue_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_blue.Checked)
            {
                //this.BackColor = Color.Blue;
                //chb_blue.Enabled = true;
                _colors.Add(Color.Blue);
            }
            //else
            //{
            //    this.BackColor = SystemColors.Control;
            //    chb_blue.Checked = false;
            //}
        }

        private void chb_green_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_green.Checked)
            {
                //this.BackColor = Color.Green;
                //chb_green.Enabled = true;
                _colors.Add(Color.Green);
            }
            //else
            //{
            //    this.BackColor = SystemColors.Control;
            //    chb_green.Checked = false;
            //}
        }
        
        private void rb_red_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;   
            rb_red.Enabled = true;
        }

        private void rb_blue_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            rb_blue.Enabled = true;
        }

        private void rb_green_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            rb_green.Enabled = true;
        }

        private void rb_defolt_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }

        private void rb_dynamic_back_color_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_dynamic_back_color.Checked)
            {
                if (timer1.Enabled == true)
                {
                    timer1.Stop();
                }
                else
                {
                    timer1.Start();
                }
            }           
        }    
        private void timer1_Tick(object sender, EventArgs e)
        {            
            if (_colors.Count != 0)
            {
                for (int i = 0; i < _colors.Count; i++)
                {
                    this.BackColor = _colors[i];                    
                }
            }
        }    
    }
}
