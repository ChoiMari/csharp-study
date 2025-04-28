using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_03_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 배열 실습
            // 1. 각 반 마다 학생 수가 다를 때,
            // 재그드 배열을 활용하여 학생 이름 저장하고 출력하기
            // 반(줄) 만들기
            // 총 3개 반을 만듬
            // 1반 2명, 2반 3명, 3반 1명

            string[][] schoolClass = new string[3][];

            // 2. 학생 이름 넣기(각 반마다 다르게)
            schoolClass[0] = new string[2] { "가나다", "나다라" };
            schoolClass[1] = new string[3] { "홍길동", "임꺽정", "성춘향" };
            schoolClass[2] = new string[1] { "안눙이" };

            // 3. 학생 이름 출력하기
            // 모든 반, 모든 학생 이름을 textBox_print에 차례로 출력
            // 출력 예시
            // 1반 학생 목록:
            // - oo
            // - oo

            textBox1.Text += "1반 학생 목록 : \r\n";
            textBox1.Text += " - " + schoolClass[0][0] + "\r\n";
            textBox1.Text += " - " + schoolClass[0][1] + "\r\n";
            textBox1.Text += "2반 학생 목록 : \r\n"; 
            textBox1.Text += " - " + schoolClass[1][0] + "\r\n";
            textBox1.Text += " - " + schoolClass[1][1] + "\r\n";
            textBox1.Text += " - " + schoolClass[1][2] + "\r\n";
            textBox1.Text += "3반 학생 목록 : \r\n";
            textBox1.Text += " - " + schoolClass[2][0] + "\r\n";
        }
    }
}
