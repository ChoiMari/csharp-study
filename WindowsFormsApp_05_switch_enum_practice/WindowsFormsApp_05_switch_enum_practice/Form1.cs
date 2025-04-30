using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_05_switch_enum_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //enum 선언
        enum Weekday { 
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
            Error = 999
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox_input.Text.Length > 0)
            {
                // 사용자에게 받은 입력 값을 input에 저장
                string input = textBox_input.Text;
                
                // enum 객체 생성
                Weekday weekday;
                // string타입의 입력값을 enum타입으로 변환함
                // weekday = (Weekday)Enum.Parse(typeof(Weekday), input);
                // 변환할 수 없을 경우 예외처리 필요
                //-> 오류

                switch (input) {
                    case "월요일":
                        weekday = Weekday.Monday;
                        break;
                    case "화요일":
                        weekday = Weekday.Tuesday;
                        break;
                    case "수요일":
                        weekday = Weekday.Wednesday;
                        break;
                    case "목요일":
                        weekday = Weekday.Thursday;
                        break;
                    case "금요일":
                        weekday = Weekday.Friday;
                        break;
                    case "토요일":
                        weekday = Weekday.Saturday;
                        break;
                    case "일요일":
                        weekday = Weekday.Sunday;
                        break;
                    default:
                        weekday = Weekday.Error;
                        textBox_result.Text = "error : 잘못된 입력입니다.\r\n 요일을 입력해주세요.\r\n 입력 예) 일요일";
                        break; 
                }

                switch (weekday) {

                    case Weekday.Monday:
                        textBox_result.Text = "월요일 힘들어요..자고 싶어요..";
                        break;
                    case Weekday.Tuesday:
                        textBox_result.Text = "화요일 힘들어요..자고 싶어요..";
                        break;
                    case Weekday.Wednesday:
                        textBox_result.Text = "수요일 힘들어요..자고 싶어요..";
                        break;
                    case Weekday.Thursday:
                        textBox_result.Text = "목요일 힘들어요..자고 싶어요..";
                        break;
                    case Weekday.Friday:
                        textBox_result.Text = "드디어!! 금요일..";
                        break;
                    case Weekday.Saturday:
                        textBox_result.Text = "토요일 , 집에서 쿨쿨";
                        break;
                    case Weekday.Sunday:
                        textBox_result.Text = "일요일 : 교회에 가요!";
                        break;
                    default:
                        textBox_result.Text = "error : 잘못된 입력입니다.\r\n 요일을 입력해주세요.\r\n 입력 예) 일요일";
                        break;
                }
            }
            else {  // 사용자 입력이 없는 경우 실행
                textBox_result.Text = "요일을 입력하십시오.";
            }
        }
    }
}
