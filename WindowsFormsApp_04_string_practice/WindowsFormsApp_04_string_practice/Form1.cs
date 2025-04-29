using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_04_string_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 실습. 문자열 및 배열
            // 문자열 관련 함수의 사용법을 직접 검색하여 아래 기능을 작성
            // 10칸 크기의 문자열 배열을 생성
            string[] str = new string[10];

            // 배열의 각 요소에 문자열 관련 함수를 하나씩 적용하여 결과값을 저장
            str[0] = "동해 물과 백두산이".IndexOf("백두산").ToString();
            str[1] = "토요일에 먹는 토마토".LastIndexOf("토").ToString();
            str[2] = "질서 있는 퇴장".Contains("퇴").ToString();
            str[3] = "그 사람의 그림자는 그랬다.".Replace("그", "이");
            str[4] = "삼성 갤럭시".Insert(2, "애플");
            str[5] = "오늘은 왠지 더 배고프다".Remove(7, 1);
            
            string[] words = "이름,나이,전화번호".Split(',');
            str[6] = words[0];
            str[7] = words[1];
            str[8] = words[2];

            str[9] = "우리 나라 만세".Substring(3, 2);

            //배열의 모든 요소를 TextBox에 출력
            textBox1.Text = str[0] + "\r\n";
            textBox1.Text += str[1] + "\r\n";
            textBox1.Text += str[2] + "\r\n";
            textBox1.Text += str[3] + "\r\n";
            textBox1.Text += str[4] + "\r\n";
            textBox1.Text += str[5] + "\r\n";
            textBox1.Text += str[6] + "\r\n";
            textBox1.Text += str[7] + "\r\n";
            textBox1.Text += str[8] + "\r\n";
            textBox1.Text += str[9] + "\r\n";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
