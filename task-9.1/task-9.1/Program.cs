
/*
 
 Klaviaturadan daxil edilen ededi yazili sekilde qaytaran proqram
234 -  iki yuz otuz dord
5678976 - bes milyon alti yuz yetmis sekkiz min doqquz yuz yetmis alti
 
 */



#region hell1

//Dictionary<char, string> Reqemler = new Dictionary<char, string>
//{
//    {'1', "bir" },
//    {'2', "iki" },
//    {'3', "üç" },
//    {'4', "dörd" },
//    {'5', "beş" },
//    {'6', "altı" },
//    {'7', "yeddi" },
//    {'8', "sekkiz" },
//    {'9', "doqquz" }
//};

//Dictionary<char, string> Onluqlar = new Dictionary<char, string>
//{
//    {'1', "on" },
//    {'2', "iyirmi"},
//    {'3', "otuz" },
//    {'4', "qırx" },
//    {'5', "elli" },
//    {'6', "altmış" },
//    {'7', "yetmiş" },
//    {'8', "seksen" },
//    {'9', "doxsan" }
//};

//List<string> Mertebeler = new List<string> 
//{ 
//    "",
//    "min", 
//    "milyon", 
//    "milyard",
//    "trilyon",
//    "kvadrilyon",
//    "kvintilyon"
//};



//Console.Write("Ededi daxil edin: ");
//string input = Console.ReadLine();
//string reverseInput = new string(input.Reverse().ToArray());

//int say = input.Length;

//List<string> oxunus = new List<string>();
//int n = 0;

//for (int i = 0; i < (say+2)/3; i++) 
//{
//    oxunus.Add(Mertebeler[i]);
//    if (n < reverseInput.Length && reverseInput[n] != '0')
//    {
//        oxunus.Add(Reqemler[reverseInput[n]]);
//    }
//    n++;
//    if (n < reverseInput.Length && reverseInput[n] != '0')
//    {
//        oxunus.Add(Onluqlar[reverseInput[n]]);
//    }
//    n++;
//    if (n < reverseInput.Length && reverseInput[n] != '0')
//    {
//        oxunus.Add("yuz");
//        if (reverseInput[n] != '1')
//        {
//            oxunus.Add(Reqemler[reverseInput[n]]);
//        }
//    }
//    n++;

//}


//oxunus.Reverse();
//Console.WriteLine(string.Join(" ", oxunus));

#endregion




#region hell2

//Dictionary<int, string> Reqemler = new Dictionary<int, string>
//{
//    {1, "bir" },
//    {2, "iki" },
//    {3, "üç" },
//    {4, "dörd" },
//    {5, "beş" },
//    {6, "altı" },
//    {7, "yeddi" },
//    {8, "sekkiz" },
//    {9, "doqquz" }
//};

//Dictionary<int, string> Onluqlar = new Dictionary<int, string>
//{
//    {1, "on" },
//    {2, "iyirmi"},
//    {3, "otuz" },
//    {4, "qırx" },
//    {5, "elli" },
//    {6, "altmış" },
//    {7, "yetmiş" },
//    {8, "seksen" },
//    {9, "doxsan" }
//};

//List<string> Mertebeler = new List<string>
//{
//    "",
//    "min",
//    "milyon",
//    "milyard",
//    "trilyon",
//    "kvadrilyon",
//    "kvintilyon"
//};


//Console.Write("Ededi daxil edin: ");
//string input = Console.ReadLine();

//List<string> oxunus = new List<string>();



//for (int i = 0; i < input.Length; i++)
//{

//    int reqem = Convert.ToInt32(input[i].ToString());
//    int dərəcə = input.Length - i - 1;

//    if (dərəcə % 3 == 0)
//    {
//        if (reqem != 0)
//        {
//            oxunus.Add(Reqemler[reqem]);
//            if (dərəcə / 3 > 0)
//            {
//                oxunus.Add(Mertebeler[dərəcə / 3]);
//            }
//        }
//    }


//    else if (dərəcə % 3 == 1)
//    {
//        if (reqem != 0)
//        {
//            oxunus.Add(Onluqlar[reqem]);
//        }
//    }


//    else if (dərəcə % 3 == 2)
//    {
//        if (reqem != 0)
//        {
//            if (reqem > 1)
//            {
//                oxunus.Add(Reqemler[reqem]);
//            }
//            oxunus.Add(Mertebeler[0]);
//        }
//    }
//}

//Console.WriteLine(string.Join(" ", oxunus));

#endregion