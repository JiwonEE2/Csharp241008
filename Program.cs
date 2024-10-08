namespace Csharp241008
{
	class Driver
	{
		public string name;
		public Driver(string name)
		{
			this.name = name;
		}
		public void Ride(Vehicle vehicle)
		{
			Console.WriteLine($"{this.name}이 {vehicle.name}을 운전함");
		}
	}
	class Vehicle
	{
		public string name;
		public int speed;

		public Vehicle(string name, int speed = 0)
		{
			this.name = name;
			this.speed = speed;
		}
		public void Move()
		{
			speed += 10;
			Console.WriteLine($"{name}의 속도가 {speed}이다");
		}
	}
	internal class Program
	{
		/*
		[ 객체지향의 4대 특징 ]
		1. 캡슐화 : 객체를 상태와 기능으로 묶는다. 객체의 내부 상태와 기능을 숨기고 허용한 상태와 기능만을 액세스를 허용
		2. 상속 : 부모 클래스의 모든 기능을 가지는 자식 클래스를 만든다.
		3. 다형성 : 부모 클래스의 함수를 자식 클래스에서 재정의하여 자식 클래스의 다른 반응을 구현
		4. 추상화 : 관련 특성 및 엔티티의 상호작용을 클래스를 모델링하여 시스템의 추상적 표현을 정의
		*/
		static void Main(string[] args)
		{
			Driver d = new Driver("경일이");
			Vehicle bike = new Vehicle("ㅋㅋ", 10);

			d.Ride(bike);	// 드라이버라는 객체가 Ride라는 기능으로 오토바이 객체와 상호작용
		}
	}
}