using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_04_function_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            int[] result = Divide(9, 2);//함수 호출

            //TextBox에 출력
            textBox1.Text = "몫 : " + result[0].ToString() + "\r\n"; 
            textBox1.Text += "나머지 : " + result[1].ToString() + "\r\n"; 


        }

        // 실습. 함수
        // int형 숫자 두 개를 입력 받기
        public int[] Divide(int x, int y) {

            int[] result = new int[2];
            // 첫 번째 입력 값을 두 번째 입력 값으로 나눔
            // 나눠진 값은 배열의 첫 번째 요소에 저장
            result[0] = x / y; // 정수끼리 계산 = 정수로 나옴
            // 나머지 값은 배열의 두 번째 요소에 저장(%연산자 이용)
            result[1] = x % y;

            // 계산 된 배열을 반환
            return result;
        }
        
        
    }
}
