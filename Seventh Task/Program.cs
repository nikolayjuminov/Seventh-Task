using System.Diagnostics.Tracing;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.Write("Введите число для проверки: ");
		bool isParsed = int.TryParse(Console.ReadLine(), out int userEntered);
		if (isParsed == false)
		{
			Console.WriteLine("Введено некорректное значение, задача завершена...");
		}
		else
		{
			if (userEntered > Math.Pow(10, 9))
			{
				Console.WriteLine("Число слишком большое, задача завершена...");
			}
			else
			{
				if (userEntered < 0)
				{
					Console.WriteLine("Число отрицательное, задача завершена...");
				}
				else
				{
					bool result = Program.BodyTask(userEntered.ToString());
					if (result)
					{
						Console.WriteLine("YES");
					}
					else
					{
						Console.WriteLine("NO");
					}
				}

			}
		}

	}
	private static bool BodyTask(string userEntered)
	{
		for (int i = 0; i < userEntered.Length / 2; i++)
		{
			if (userEntered[i] != userEntered[userEntered.Length - 1 - i])
			{
				return false;
			}
		}
		return true;
	}
}