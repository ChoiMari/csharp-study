using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_12_ref_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 실습. 값의 참조
            // 1. ref 키워드를 활용한 배열 채우기

            int size = 5;
            int[] refArray = new int[size];

            // 배열 생성 후, new로 생성된 배열을 ref로 메서드에 전달
            RefMethod(ref refArray);

            Console.WriteLine("\r\n========================\r\n");

            // 2. out 키워드를 활용한 배열 생성 및 채우기
            // 초기화 되지 않은 배열 변수를 out에 전달
            int[] outArray;
            int outSize;
            // 메서드의 두 번째 인자로 원하는 배열의 크기(int)를 함께 전달

            OutMethod(out outArray, out outSize);
        }

        public void RefMethod(ref int[] array) {
            // 메서드안에서 출력 용도로 foreach사용(foreach문에서 값을 바꿀려고 하면 안된다고.. readonly 형식? 이라서 그렇다고 함)
            // 값을 변경하고 싶을 땐 for문을 사용해야 한다고 함

            Console.Write("[ref] 배열 값: ");

            for (int i = 0;i < array.Length ;i++) {
                array[i] = i + 1;
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public void OutMethod(out int[] array, out int size) {
            // 메서드 내부에서 해당 크기만큼의 배열을 생성한 뒤,
            // 요소를 1부터 크기만큼 순서대로 채워 넣기(그리고 출력해보기)
            size = 3;
            array = new int[size];

            Console.Write("[out] 배열 값: ");

            for (int i = 0; i < array.Length ;i++ )
            {
                array[i] = i + 1;
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
