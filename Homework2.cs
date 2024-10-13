/*
[ 과제 2]
클래스를 활용하여 대전 게임 만들기(프로퍼티 활용)
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp241008
{
	class Unit
	{
		public string name { get; set; }
		public int hp { get; set; }
		public int att { get; set; }
		public void Attack(Unit other)
		{
			this.hp -= other.att;
			Console.WriteLine("============================================");
			Console.WriteLine();
			Console.WriteLine($"{this.name}이 {other.name}를 공격했습니다.");
			Console.WriteLine($"{other.name}이 {this.att}의 데미지를 입어 체력이 {other.hp}가 되었습니다.");
			Console.WriteLine();
		}
	}
	internal class Homework2
	{
		static void Main(string[] args)
		{
			Unit player = new Unit();
			Unit monster = new Unit();

			Console.Write("플레이어의 이름을 입력하세요 : ");
			player.name = Console.ReadLine();
			Console.Write("플레이어의 체력을 입력하세요 : ");
			player.hp = int.Parse(Console.ReadLine());
			Console.Write("플레이어의 공격력을 입력하세요 : ");
			player.att = int.Parse(Console.ReadLine());

			Console.Write("몬스터의 이름을 입력하세요 : ");
			monster.name = Console.ReadLine();
			Console.Write("몬스터의 체력을 입력하세요 : ");
			monster.hp = int.Parse(Console.ReadLine());
			Console.Write("몬스터의 공격력을 입력하세요 : ");
			monster.att = int.Parse(Console.ReadLine());

			while (true)
			{
				if (player.hp <= 0)
				{
					Console.WriteLine($"{monster.name}이 이겼습니다.");
					break;
				}
				else if (monster.hp <= 0)
				{
					Console.WriteLine($"{player.name}이 이겼습니다.");
					break;
				}
				player.Attack(monster);
				if (player.hp <= 0)
				{
					Console.WriteLine($"{monster.name}이 이겼습니다.");
					break;
				}
				else if (monster.hp <= 0)
				{
					Console.WriteLine($"{player.name}이 이겼습니다.");
					break;
				}
				monster.Attack(player);
			}
		}
	}
}