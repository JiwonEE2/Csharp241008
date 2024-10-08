using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp241008
{
	// 가상함수 : 부모클래스의 함수 중 자식클래스에 의해 재정의할 수 있는 함수를 지정
	// 오버라이딩 : 부모클래스의 가상함수를 같은 함수이름과 같은 매개변수로 재정의하여 자식만의 반응을 구현
	internal class Polymorphism
	{
		class Skill
		{
			public virtual void Excute()  // 가상함수
			{
				Console.WriteLine("스킬 재사용 대기시간을 진행한다");
			}
		}
		class FireBall : Skill
		{
			public override void Excute() // 오버라이딩
			{
				base.Excute();  // 부모
				Console.WriteLine("화염구 발사");
			}
		}
		class Dash : Skill
		{
			public override void Excute()
			{
				base.Excute();
				Console.WriteLine("돌진 공격");
			}
		}
		class Player
		{
			Skill skill;
			public void SetSkill(Skill skill)
			{
				this.skill = skill;
			}
			public void UseSkill()
			{
				skill.Excute();
			}
		}
		static void Main(string[] args)
		{
			Player player = new Player();
			// 업캐스팅
			Skill fire = new FireBall();
			player.SetSkill(fire);
			player.UseSkill();
		}
	}
}