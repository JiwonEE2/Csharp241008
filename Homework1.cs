/*
	과제 1
	- 공격, 방어, 움직임 등등 인터페이스를 만들고
	- 특정 캐릭터(3개)가 상속을 받는다.
	ㄴ 각각의 캐릭터들이 행동을 수행하는 결과를 출력

	과제 2. 클래스를 활용하여 대전 게임 만들기(프로퍼티 활용)
	
	과제 3. 추상클래스와 인터페이스 차이
	과제 4. 업 vs 다운 캐스팅
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp241008
{
	public interface IAttack
	{
		void Attack();
	}
	public interface IDefense
	{
		void Defense();
	}
	public interface IMove
	{
		void Move();
	}
	public class Player : IAttack, IDefense, IMove
	{
		public void Attack()
		{
			Console.WriteLine("플레이어가 공격한다");
		}
		public void Defense()
		{
			Console.WriteLine("플레이어가 방어한다");
		}
		public void Move()
		{
			Console.WriteLine("플레이어가 움직인다");
		}
	}
	public class Monster : IAttack, IDefense, IMove
	{
		public void Attack()
		{
			Console.WriteLine("몬스터가 공격한다");
		}
		public void Defense()
		{
			Console.WriteLine("몬스터가 방어한다");
		}
		public void Move()
		{
			Console.WriteLine("몬스터가 움직인다");
		}
	}
	public class NPC : IAttack, IDefense, IMove
	{
		public void Attack()
		{
			Console.WriteLine("NPC가 공격한다");
		}
		public void Defense()
		{
			Console.WriteLine("NPC가 방어한다");
		}
		public void Move()
		{
			Console.WriteLine("NPC가 움직인다");
		}
	}
	internal class Homework1
	{
		static void Main(string[] args)
		{
			Player player = new Player();
			player.Attack();
			player.Defense();
			player.Move();

			Monster monster = new Monster();
			monster.Attack();
			monster.Defense();
			monster.Move();

			NPC npc = new NPC();
			npc.Attack();
			npc.Defense();
			npc.Move();
		}
	}
}