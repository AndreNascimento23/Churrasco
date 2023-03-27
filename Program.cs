Console.Clear();
            double carneA = .400; double carneC = .200;
            double acompanhamento = .200;
            double cerveja = 2.0; 
            double refrigerante = .500;
            double agua = .400;

Console.WriteLine("--- Churrasco ---\n");

Console.Write("Adultos (que consomem bebidas alcoólicas).......: ");
    int adulto = Convert.ToInt32(Console.ReadLine());
Console.Write("Adultos (que não consomem bebidas alcoólicas)...: ");
    int adulto2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Crianças........................................: ");
    int crianca = Convert.ToInt32(Console.ReadLine());

    int pessoasA = adulto + adulto2;
   
    decimal carneT; 
    carneT = (decimal)carneA * (decimal)pessoasA;

    int pessoasT = pessoasA + crianca;


    decimal carneTC;
    carneTC = (decimal)crianca * (decimal)carneC;

    decimal totalC = carneT + carneTC;

Console.WriteLine();
Console.WriteLine($"Carne.............: {totalC}kg");
Console.WriteLine($"Acompanhamentos...: {pessoasT * (decimal)acompanhamento}kg");
Console.WriteLine($"Cerveja...........: {adulto * cerveja}l");
Console.WriteLine($"Refrigerante......: {(adulto2 + crianca) * refrigerante}l");
Console.WriteLine($"Água..............: {pessoasT * (decimal)agua}l");





