using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_13_Exception
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //실습. 예외처리 - 회원가입 닉네임 검사
            // 사용자가 입력한 닉네임을 검사하는 프로그램 작성
            // 특정 조건을 만족하지 않으면 예외(throw)를 발생시키고,
            // 예외에 따라 맞춤 메세지 출력하기

            // 요구 사항
            // 1. 사용자로부터 닉네임을 한 줄 입력 받기
            // 2. 다음 조건을 검사하여, 해당하지 않을 경우 직접 예외 발샐 시키기
            string nickname = "";


            while (true) {
                try
                {
                    Console.Write("닉네임 : ");
                    nickname = Console.ReadLine().Trim();

                    if (nickname.Trim() == "" || nickname == null
                        || nickname.Trim().Length < 3 || nickname == "admin")
                    {
                        throw new Exception("\r\n닉네임 조건에 맞지 않아 개발자가 의도적으로 일으킨 예외 입니다. catch문에서 예외를 받아서 처리함\r\n");
                    }

                    Console.WriteLine("\r\n닉네임이 정상 등록 되었습니다.\r\n");
                    Console.WriteLine("프로그램을 종료합니다.\r\n");
                    break;
                }
                catch (Exception ex)
                {
                    if (nickname.Trim() == "" || nickname == null)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("닉네임을 입력해주세요.\r\n");
                    }
                    else if (nickname.Trim().Length < 3)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("닉네임은 2글자 이상이어야 합니다.\r\n");
                    }
                    else if (nickname.Trim() == "admin")
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("닉네임에 'admin'은 포함할 수 없습니다.\r\n");
                    }
                    else
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("입력하신 닉네임은 사용이 불가 합니다. 다시 입력해 주세요.\r\n");
                    }
                }
                finally
                {
                    Console.WriteLine("\r\n=======================================\r\n");
                }


            }

        }
    }
}
