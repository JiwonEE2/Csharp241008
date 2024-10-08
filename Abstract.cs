using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp241008
{
	internal class Abstract
	{
		/*
		[ 추상화 ]
		- 클래스를 정의할 때 구체화시킬 수 없는 기능을 추상적 표현으로 정의
		- 인스턴스화 할 수 없는 클래스이며 abstract 키워드를 사용하여 추상클래스 정의
		- 하나 이상의 추상함수를 포함하는 클래스
		- 클래스가 추상적인 표현을 정의하는 경우 자식에서 구체화시켜 구현할 것을 염두하고 추상화

		[ 추상함수와 가상함수 ]
		- 비슷한 역할(다형성)을 하지만 목적과 사용법이 다름
		- 가상함수는 기본구현을 포함. 자식클래스에서의 필요에 따라 오버라이딩 가능
		- 오버라이딩 하지 않으면 부모클래스의 기본 구현을 그대로 사용

		[ 추상함수 ]
		- 반드시 자식에서 오버라이딩 해야 함
		- 구현이 없고 자식클래스에서 구현
		- 다형성을 강제함
		*/
		abstract class Item // 추상클래스
		{
			public abstract void Use();

			// 일반 메서드 포함 가능
			public void Print() { }
		}
		class Potion : Item
		{
			public override void Use()
			{
				Console.WriteLine("포션 ~ 체력회복");
			}
		}
		abstract class Animal
		{
			// 무슨 동물이 어떻게 울것인가?
			public abstract void Cry();
		}
		class Cat : Animal
		{
			public override void Cry()
			{
				// 고양이는 야옹
			}
		}
		abstract class Shape
		{
			// 추상 : 일반 클래스에서 사용불가
			public abstract void Draw();
			// 가상
			public virtual void Show()
			{
				Console.WriteLine("Shape 출력");
			}
		}
		class Circle : Shape
		{
			// 추상함수
			public override void Draw()
			{

			}
			// 가상함수 재정의 -> 필요에 의해
			public override void Show()
			{
				Console.WriteLine("Circle 출력");
			}
		}
		static void Main(string[] args)
		{
			//Item item = new Item();	// 추상클래스는 인스턴스 생성 불가
			// 구체화한 자식에서는 인스턴스 생성 가능하며, 기능 사용 가능
			Item item = new Potion();
		}
	}
}