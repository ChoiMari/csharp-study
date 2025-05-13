using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_11_class_upcasting
{
    public class Animal // 부모 클래스
    {
        // 속성
        public string Name { get; set; }
        // 이렇게 선언하면 string name; 필드 선언 필요 없음
        // 눈에 보이지 않지만 자동으로 만들어주기 때문에

        // 아규먼트가 있는 생성자
        public Animal(string name)
        {
            this.Name = name;
            Console.WriteLine("Animal(동물) 클래스는 부모 클래스 : 객체 생성 \r\n");
        }

        // 메서드 정의
        public void Speak(string name)
        {
            Console.WriteLine($"{name} : 동물이 소리를 냅니다.\r\n");
        }
    }

        // 자식 클래스(Animal클래스를 상속 받음)
        public class Dog : Animal
        {

            // 매개변수가 있는 생성자
            public Dog(string name) : base(name) { }

            // 고유의 메서드 정의
            public void DogEat()
            {
                Console.WriteLine("강아지가 밥을 먹습니다.\r\n");
            }

        }
        public class Cat : Animal
        {
            // 매개변수가 있는 생성자
            public Cat(string name) : base(name) { }

            // 고유의 메서드 정의
            public void CatEat()
            {
                Console.WriteLine("고양이가 밥을 먹습니다.\r\n");
            }
        }
        public class Bird : Animal
        {
            // 매개변수가 있는 생성자
            public Bird(string name) : base(name) { }

            // 고유의 메서드 정의
            public void BirdEat()
            {
                Console.WriteLine("새가 밥을 먹습니다.\r\n");
            }
        }
    
}
