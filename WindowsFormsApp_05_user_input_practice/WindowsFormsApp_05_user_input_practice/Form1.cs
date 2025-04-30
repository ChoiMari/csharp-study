using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_05_user_input_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        //이벤트 리스너가 듣고 있다가 button_input 클릭 이벤트 발생 시 해당 코드 실행
        private void button_input_Click(object sender, EventArgs e)
        {

            bool userInput;
            bool result;

            // if문 실습에서 사용했던 동전 던지기 함수를 사용자 입력을 받아서 처리

            if (textBox_input.Text == "true" || textBox_input.Text == "True"
                              || trueButton.Checked == true)
            {
                userInput = true;

                result = CoinTossing(userInput);
                
                // textBox_result에 결과 출력
                if (result)
                {
                    textBox_result.Text = "동전 던지기 결과 : 승리!.!";
                }
                else
                {
                    textBox_result.Text = "동전 던지기 결과 : 패배 ㅜ.ㅠ";
                }
            }
            else if (textBox_input.Text == "false" || textBox_input.Text == "False"
                              || falseButton.Checked == true)
            {
                userInput = false;

                result = CoinTossing(userInput);

                // textBox_result에 결과 출력
                if (result)
                {
                    textBox_result.Text = "동전 던지기 결과 : 승리!.!";
                }
                else
                {
                    textBox_result.Text = "동전 던지기 결과 : 패배 ㅜ.ㅠ";
                }
            } 
            else if (textBox_input.Text == "" || trueButton.Checked == false
                        || falseButton.Checked == false) {
                textBox_result.Text = "error : 값을 입력/선택해주세요";
            }
            else {
                textBox_result.Text = "error : true 또는 false를 입력하세요.";
            }



        }

        // 동전 던지기 함수
        public bool CoinTossing(bool userInput) {
            
            // 동전 앞 면 = true = 1
            // 동전 뒷 면 = false = 0로 가정함.

            // Random(난수 생성 클래스) 객체 생성(random).
            Random random = new Random();

            // 생성한 난수를 0 또는 1값만 나오도록 처리
            int randomResult = random.Next() % 2;

            if ((randomResult == 1 && userInput == true) 
                || (randomResult == 0 && userInput == false)) {

                return true;

            }

            return false;
        }// 동전 던지기 함수 끝
    }
}
