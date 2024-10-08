using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp241008
{
	/*
	[ 일반화(Generic) ]
	- 클래스 또는 함수가 코드에 의해 선언되고 인스턴스화 될 때까지 형식의 사용화? 들어줘 나의 디스코드
	- 기능을 구현한 뒤 자료형을 사용 당시에 지정하여 사용

	< 일반화 함수 >
	- 일반화는 자료형의 형식을 지정하지 않고 함수를 정의
	- 기능을 구현한 뒤 사용 당시에 자료형의 형식을 지정해서 사용

	[ 형식 매개변수 제약하기 ]
	- 일반화 자료형을 선언할 때 제약조건을 걸어줌으로써 사용당시 쓸 수 있는 자료형을 제한
	- 타입의 안정성을 높임
	*/
	internal class Generic
	{
		#region Generic
		// ref 변수의 참조를 이용하여 값을 수정할 수 있다.
		//public static void SwapValue<T>(ref T a, ref T b)
		//{
		//	T temp = a;
		//	a = b;
		//	b = temp;
		//}
		//public static void ArrayCopy<T>(T[] source, T[] output)
		//{
		//	for (int i = 0; i < source.Length; i++)
		//	{
		//		output[i] = source[i];
		//	}
		//}
		// 일반화 클래스
		class SafeArray<T>
		{
			private T[] array;
			// 배열의 크기를 인자로 받아서 초기화
			public SafeArray(int size)
			{
				array = new T[size];
			}
			public void Set(int index, T value)
			{
				// 유효하지 않은 인덱스라면
				if (index < 0 || index >= array.Length) return;
				array[index] = value;
			}
			public T Get(int index)
			{
				if (index < 0 || index >= array.Length)
				{
					// 제네릭 타입 T의 기본값을 의미. T가 int형 타입이라면 0을 리턴
					return default(T);
				}
				return array[index];
			}
		}
		#endregion

		#region 제약조건
		/*
		where T: struct {}	// struct로 제한(값형식)
		where T: class {}		// 클래스로 제한(참조형식)
		where T: new() {}		// 매개변수가 없는 생성자가 있는 자료형
		where T: 기반클래스 {}	// 파생클래스로 제한
		where T: 인터페이스 {}	// 인터페이스를 포함한 자료형만
		*/
		class StructT<T> where T : struct { } // T는 구조체만 사용
		class ClassT<T> where T : class { } // T는 클래스만 사용
		class NewT<T> where T : new() { } // T는 매개변수가 없는 생성자가 있는 자료형만 사용
		class ParentT<T> where T : Parent { } // T는 Parent 파생클래스만 사용
		class InterfaceT<T> where T : IComparable { } // T는 인터페이스를 포함한 자료형만 사용가능

		class Parent { }
		class Child : Parent { }

		void Test()
		{
			StructT<int> structT = new StructT<int>();  // 가능. int가 값형식이라서
																									//ClassT<int> classT = new ClassT<int>();	// 불가능. 참조형식이 아니라서

			InterfaceT<int> intT = new InterfaceT<int>(); // 가능. int는 IComparable을 인터페이스를 포함하므로
		}
		#endregion

		#region where T : struct
		public static void SwapValue<T>(ref T a, ref T b) where T : struct
		{
			T temp = a;
			a = b;
			b = temp;
		}
		public static void ArrayCopy<T>(T[] source, T[] output) where T : struct
		{
			for (int i = 0; i < source.Length; i++)
			{
				output[i] = source[i];
			}
		}

		public static T Bigger<T>(T left, T right) where T : IComparable<T>
		{
			if (left.CompareTo(right) > 0)
			{
				return left;
			}
			else
			{
				return right;
			}
		}
		#endregion

		static void Main(string[] args)
		{
			int x = 10;
			int y = 20;
			SwapValue(ref x, ref y);

			int[] iSrc = { 1, 2, 3, 4, 5 };
			int[] iDst = new int[iSrc.Length];
			ArrayCopy<int>(iSrc, iDst);

			string[] sSrc = { "ㅇㅇㅇ", "ㅁㅁㅁ", "ㅇㅇㅇ" };
			string[] sDrc = new string[sSrc.Length];

			//ArrayCopy<string>(sSrc, sDrc);
		}
	}
}