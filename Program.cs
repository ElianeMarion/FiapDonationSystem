namespace FiapDonationSystem
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string nome, telefone, email, senha, apelido;
			Console.WriteLine("FIAP Donation System!");
			//char letra = 'e';

			//Criar um menu
			Console.WriteLine("\n 1 - Registrar um novo usuário\n 2 - Logar\n 3 - Sair\n Digite a opção desejada: ");
			int opcao = Convert.ToInt32(Console.ReadLine());

			if(opcao == 1)  //registrar um novo usuario
			{
				Console.WriteLine("Digite seu nome: ");
				nome = Console.ReadLine();
				Console.WriteLine("Digite seu telefone: ");
				telefone = Console.ReadLine();
				Console.WriteLine("Digite seu email: ");
				email = Console.ReadLine();
				Console.WriteLine("Digite sua senha: ");
				senha = Console.ReadLine();
				Console.WriteLine("Digite seu apelido: ");
				apelido = Console.ReadLine();
			}
			else if(opcao == 2)//logar
			{
				//email cadastrado = "admin@fiap.com" senha cadastrada = "admin123
				Console.WriteLine("Digite seu email: ");
				string emailParaLogin = Console.ReadLine();
				Console.WriteLine("Digite sua senha: ");
				string senhaParaLogin = Console.ReadLine();
				if (emailParaLogin.Equals("admin@fiap.com.br"))
				{
					if (senhaParaLogin.Equals("admin123"))
						Console.WriteLine("Bem vindo ao sistema " + emailParaLogin);
					else
						Console.WriteLine("Usuario e/ou senha inválidos");
				}
				else
					Console.WriteLine("Usuario e/ou senha inválidos");

			}
			else
			{
				Console.WriteLine("Obrigada(o) por utilizar nosso sistema!");
			}

			



		}
	}
}