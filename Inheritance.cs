using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp241008
{
	/*
	[ 상속 ]
	- is-a 관계 : 부모클래스가 자식클래스를 포함하는 상위 개념일 경우 상속 관계가 적합
	*/
	internal class Inheritance
	{
		class Monster
		{
			protected string name;
			protected int hp;

			public void Move()
			{
				Console.WriteLine($"{name}이/가 움직입니다.");
			}
			public void TakeHit(int damage)
			{
				hp -= damage;
				Console.WriteLine($"{name}이/가 {damage}의 데미지를 받아 체력이 {hp}가 되었다.");
			}
		}
		// C++과 다르게 상속할 때 접근제한자 안붙음
		class Dragon : Monster
		{
			public Dragon()
			{
				name = "드래곤";
				hp = 100;
			}
			public void Breath()
			{
				Console.WriteLine($"{name}이/가 브레스를 뿜는다.");
			}
		}
		class Slime : Monster
		{
			public Slime()
			{
				name = "슬라임";
				hp = 10;
			}
			public void Split()
			{
				Console.WriteLine($"{name}이/가 분열한다.");
			}
		}
		class Hero
		{
			int damage = 3;
			public void Attack(Monster monster)
			{
				monster.TakeHit(damage);
			}
		}
		static void Main(string[] args)
		{
			Dragon dragon = new Dragon();
			Slime slime = new Slime();

			// 부모클래스 Monster를 상속한 자식클래스는 모두 부모클래스의 기능을 가지고 있다.
			dragon.Move();
			slime.Move();

			// 자식클래스는 부모클래스가 가지고 있는 기능에 + 자식만의 기능을 추가
			dragon.Breath();
			slime.Split();

			Hero hero = new Hero();
			hero.Attack(dragon);
			hero.Attack(slime);

			/*
			[ 업캐스팅과 다운캐스팅 ]
			- 주로 상속관계에서 부모클래스와 자식클래스 간의 형변환에 사용

			[ 업캐스팅 ]
			- 자식클래스는 부모클래스 자료형으로 묵시적 형변환 가능
			- 자식클래스 객체는 항상 부모클래스의 객체로 취급될 수 있기 때문에 별도의 캐스팅 연산자가 불필요

			< 특징 >
			1. 명시적 캐스팅없이 자동으로 이루어짐
			2. 부모클래스에서 정의된 멤버들만 접근 가능
			3. 자식클래스에서 추가된 기능은 접근 불가

			< 사용 이유 >
			- 다형성을 활용하여 부모클래스 타입을 사용해 자식클래스의 객체를 처리할 수 있게 해줌
			- 코드의 재사용성을 높이고 인터페이스나 추상클래스에서 자식클래스들을 통일된 방식으로 다루는 데 유용

			[ 다운캐스팅 ]
			- 부모클래스 어쩌구

			< 특징 >
			1. 명시적인 캐스팅 연산자 필요
			2. is 또는 as 연산자를 사용하여 캐스팅 전 타입을 확인하는 것이 좋다.

			< 사용 이유 >
			- 자식클래스에서만 제공하는 기능에 접근할 필요가 있을 때 사용
			*/

			// 업캐스팅(Dragon 객체를 Monster 객체로 변환)
			Monster monster = new Dragon();
			hero.Attack(monster);

			// 다운캐스팅
			Dragon dd = (Dragon)monster;

			// monster가 Dragon이기 때문에 불가능
			//Slime ss = (Slime)monster;

			// is를 활용한 다운 캐스팅
			// is : 객체가 특정한 타입인 지 확인 (형변환 가능한 지 확인)
			if (monster is Dragon)
			{
				Dragon isDragon = (Dragon)monster;  // 가능하면 변환
			}

			// as : 캐스팅 시도하고 실패하면 null 반환
			Dragon asDragon = monster as Dragon;
			if (asDragon != null)
			{
				asDragon.Move();
			}
		}
	}
}