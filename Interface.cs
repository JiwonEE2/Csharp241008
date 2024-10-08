using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp241008
{
	/*
	** 중요 ** 추상클래스와 인터페이스 차이 !!
	
	[ 인터페이스(interface) ]
	- 추상클래스와 동일한 부분은 다형성을 지원
	- 다중상속 가능
	- 생성자 불가
	- 접근지정자 public. private는 불가
	- 구현강제(선언된 모든 메서드)
	- public
	- 인스턴스 생성 불가
	*/
	public abstract class AClass
	{
		int a;  // 멤버변수
		// 생성자
		AClass()
		{
			a = 10;
		}
	}
	public interface IClass	// I는 관례. I(nterface)
	{
		//int a;	// 멤버변수 불가
		//IClass() { }	// 생성자 불가
		public void Print();	// 정의만?
		public void Test()
		{
			// 인터페이스의 목적에 위배된다. 가능은 하다. 원형만 선언하고 활용하는 게 주목적
			Console.WriteLine("ddd");
		}
	}
	//class Test : IClass
	//{

	//}
	public interface IEnterable
	{
		void Enter();	// 인터페이스의 함수는 정의만 선언하고 직접 구현하지 않는다.
	}
	public interface IOpenable
	{
		void Open();
	}
	// 인터페이스는 다중 상속 허용
	public class Door : IEnterable, IOpenable
	{
		public void Enter() { }
		public void Open() { }
	}
	// 인터페이스를 이용하여 기능을 구현할 경우
	// 클래스의 상속관계와 무관하게 행동의 가능여부로 상호작용 가능
	// 상속을 하면 무조건 구현해야 하고, 상속했던 클래스의 멤버함수를 다른클래스에서 상속 없이 사용할 수 있다.
	public class Player
	{
		public void Enter(IEnterable enterable)
		{
			Console.WriteLine("플레이어가 들어가기를 시도한다");
			enterable.Enter();
		}
	}
	internal class Interface
	{
		static void Main(string[] args)
		{
			//IOpenable i = new IOpenable();	// 인스턴스 생성 불가
		}
	}
}