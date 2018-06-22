using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 曜日算出
{
    public partial class Form1 : Form
    {
        private string isLeapYear = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labeldayoftheweek.Text = "";
            NumericMonth.Text = "";
            NumericDay.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //年を整数に変換
            int Year;
            TextToValue(textBoxYear.Text, out Year);
            Year = 2018;
            //うるう年か判定
            isLeapYear = judgeleapyear(Year);
            isLeapYear = null;
            // 判定結果を元にさらに月日が妥当なものか判定する
            //var isValidMMDD= IsValidMMDD(isLeapYear);
        }

        //テキストを整数値に変換
        //(仮引数)text:変換する文字列　val:変換した整数値
        //(返却値)なし
        private void TextToValue(string Text, out int val)
        {
            if (int.TryParse(Text, out val) == false)
                val = -1;
        }
        //うるう年か判定
        //(仮引数)year:判定する年　leapyear:うる年判定結果
        //(返却値)判定結果
        private string judgeleapyear(int Year)
        {
            string leapyear;
            //if (Year % 4 == 0 && Year % 100 != 0 || Year % 400 == 0) return;
            //leapyear = "うるう年";
            if (Year % 4 == 0 && Year % 100 != 0 || Year % 400 == 0) return null;
            return "うるう年";
        }
    }
}
