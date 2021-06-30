using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prokachka
{
    public partial class Form1 : Form
    {
        //скиллы
        private int war = 0;
        private int buying = 0; 
        private int goverment = 0;
        //деньги
        int money = 10000;
        //очки для улучшения
        int upgradeOchki = 5;

        private void button1_Click(object sender, EventArgs e)
        {
            Prockachka(ref goverment);
            spellLevel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prockachka(ref buying);
            spellLevel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Prockachka(ref war);
            spellLevel();
        }

        public Form1()
        {
            InitializeComponent();
            spellLevel();

            label4.Text += upgradeOchki;
            label5.Text = "Деньги: " + money;
        }

        public void spellLevel()
        {
            label1.Text = "Правопарядок: " + goverment;
            label2.Text = "Торговля: " + buying;
            label3.Text = "Военное дело: " + war;
        }

        public void Prockachka(ref int upgradeSpell)
        {
            if(upgradeOchki > 0)
            {
                upgradeOchki--;
                upgradeSpell++;
                label4.Text ="Очки: " + upgradeOchki;
            }
        }//улучшение способности

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (goverment == 1)
                money = money + 50;

            if (goverment == 2)
                money = money + 100;

            if (goverment == 3)
                money = money + 200;

            if(goverment == 4)
                money = money + 400;

            if(goverment == 5)
                money = money + 500;

            label5.Text = "Деньги: " + money;
        }//если прокачиваешь правительство

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip gover = new ToolTip();
            gover.SetToolTip(button1, "Правопарядок 0: Абсолютная анархия" +
                "\nПравопарядок 1: Зачатки законов" +
                "\nПравопарядок 2: Люди не бьют полицейских платиковыми стаканчиками"+
                "\nПравопарядок 3: Воровство отныне вне закона"+
                "\nПравопарядок 4: Коррупция? Нет, не слышали"+
                "\nПравопарядок 5: А не слишком ли строго?");

            ToolTip buy = new ToolTip();
            buy.SetToolTip(button2, "Торговля 0: Что ты дашь за эта шкура?" +
                "\nТорговля 1: Красивая бусинка, за неё возьму твой топр" +
                "\nТорговля 2: Эти кристаллики блестят" +
                "\nТорговля 3: Куплю тебя со всеми потрахами" +
                "\nТорговля 4: Деньги наше всё" +
                "\nТорговля 5: Деньги есть деньги");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (goverment == 5)
                button1.Enabled = false;
        }
    }
}
