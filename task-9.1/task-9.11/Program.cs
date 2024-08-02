// See https://aka.ms/new-console-template for more information




Dictionary<string, decimal> bank = new Dictionary<string, decimal>
        {
            {"Nihat Garibli", 1000m},
            {"client2", 10m},
            {"client3", 100m},
            {"client4", 45m}
        };

while (true)
{
    Console.Write("\nMüşterinin adını daxil edin (növbeden çıxmaq üçün 'exit' yazın): ");
    string clientName = Console.ReadLine();

    if (clientName.ToLower() == "exit")
    {
        break;
    }

    if (!bank.ContainsKey(clientName))
    {
        Console.WriteLine("Bu adda musteri yoxdur.");
        continue;
    }

    bool exit = false;
    while (!exit)
    {
        Console.WriteLine("\n1. Pul yatırmaq");
        Console.WriteLine("2. Pul çıxarmaq");
        Console.WriteLine("3. Balans yoxlamaq");
        Console.WriteLine("4. Novbeden çıxmaq");
        Console.Write("Emeliyyat seçin: ");

        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                Console.Write("Daxil edeceyiniz valyutani secin (AZN, EURO, USD): ");
                string valyuta = Console.ReadLine().ToLower();
                Console.Write("Yatırılacaq meblegi daxil edin: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal yatirilacaqPul))
                {
                    switch (valyuta)
                    {
                        case "usd":
                            yatirilacaqPul *= 1.70m;
                            break;
                        case "euro":
                            yatirilacaqPul *= 1.80m;
                            break;
                        case "azn":
                            break;
                        default:
                            Console.WriteLine("Yanlış valyuta. Yeniden cehd edin.");
                            continue;
                    }

                    bank[clientName] += yatirilacaqPul;
                    Console.WriteLine($"{yatirilacaqPul} AZN yatırıldı.");
                }
                else
                {
                    Console.WriteLine("Yanlış mebleğ. Yeniden cehd edin.");
                }
                break;

            case "2":
                Console.Write("Çıxarılacaq meblegi daxil edin: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal cixarilacaqPul))
                {
                    if (cixarilacaqPul <= bank[clientName])
                    {
                        bank[clientName] -= cixarilacaqPul;
                        Console.WriteLine($"{cixarilacaqPul} AZN çıxarıldı.");
                    }
                    else
                    {
                        Console.WriteLine($"Balans kifayet etmir.");
                    }
                }
                else
                {
                    Console.WriteLine("Yanlış mebleğ. Yeniden cehd edin.");
                }
                break;

            case "3":
                Console.WriteLine($"Cari balans: {bank[clientName]} AZN");
                break;

            case "4":
                exit = true;
                Console.WriteLine("Novbeden çıxıldı...");
                break;

            default:
                Console.WriteLine("Yanlış seçim. Yeniden cehd edin.");
                break;
        }
    }
}
