using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_11_class_upcasting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            //업캐스팅
            Animal animal1 = new Dog("강아지");
            Animal animal2 = new Cat("고양이");
            Animal animal3 = new Bird("새");

            // 호출 가능한 메서드 : 부모 클래스의 메서드만 가능
            animal1.Speak("강아지");
            animal2.Speak("고양이");
            animal3.Speak("새");

            // 다운캐스팅으로 호출 불가능했던 메서드 호출
            ((Dog)animal1).DogEat();
            ((Cat)animal2).CatEat();
            ((Bird)animal3).BirdEat();

        }
    }
}
