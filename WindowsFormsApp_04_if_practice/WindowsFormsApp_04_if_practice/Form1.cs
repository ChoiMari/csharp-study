using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_04_if_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            // 동전 던지기(앞 면, 뒷 면) 함수를 작성

            // 입력 bool형 (앞 면이면 true, 뒷 면이면 false)
            bool input = true; // 입력 자료형
            bool result; // 출력 자료형

            result = CoinTossing(input); //동전 던지기 함수 호출
            if (result)
            {
                textBox1.Text = "승리";
            }
            else {
                textBox1.Text = "패배";
            }

        } //form1끝

        // 함수 선언
        public bool CoinTossing(bool input) { //C#에서 함수명은 파스칼 표기 권장
           
            // 난수 생성
            Random random = new Random();
            // 생성된 난수와 % 연산을 이용,
            // 연산 결과로 0 또는 1만 값이 나오도록 작성
            //  bool randomResult = (random.Next() % 2 == 1) ? true: false;

            int randomNum = random.Next();

            // textBox2에 출력해봄
            textBox2.Text = randomNum.ToString(); // 난수 출력

            int randomResult = randomNum % 2;
            // 0 또는 1이 나오게 처리함
            // randomResult가 짝수면 0, 홀수면 1

            // bool형을 int로 변환
            int inputResult = (input == true) ? 1 : 0; // 입력값을 int형으로 변환

            if (randomResult == inputResult) {
                return true;
            }
            else {
                return false;
            }



        }

    }
}
