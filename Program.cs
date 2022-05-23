System.Console.WriteLine(DateTime.Now);
System.Console.WriteLine(DateTime.Now.Date);
System.Console.WriteLine(DateTime.Now.Day);
System.Console.WriteLine(DateTime.Now.Month);
System.Console.WriteLine(DateTime.Now.Year);
System.Console.WriteLine(DateTime.Now.Minute);
System.Console.WriteLine(DateTime.Now.Second);

System.Console.WriteLine(DateTime.Now.DayOfYear);
System.Console.WriteLine(DateTime.Now.DayOfWeek);

System.Console.WriteLine(DateTime.Now.ToLongDateString());
System.Console.WriteLine(DateTime.Now.ToShortDateString());
System.Console.WriteLine(DateTime.Now.ToLongTimeString());
System.Console.WriteLine(DateTime.Now.ToShortTimeString());

System.Console.WriteLine(DateTime.Now.AddDays(2));  //Gün ekelene bilir
System.Console.WriteLine(DateTime.Now.AddHours(3)); //Saat eklene birlir
System.Console.WriteLine(DateTime.Now.AddSeconds(50));  //Saniye eklene bilir
System.Console.WriteLine(DateTime.Now.AddMonths(2));     //Ay ekelene bilir
System.Console.WriteLine(DateTime.Now.AddYears(5));     //Yıl eklene bilir
System.Console.WriteLine(DateTime.Now.AddMilliseconds(30)); //Milli saniye eklene bilir

//DateTime Format
//Günler için
System.Console.WriteLine(DateTime.Now.ToString("dd"));  //23
System.Console.WriteLine(DateTime.Now.ToString("ddd")); //Mon
System.Console.WriteLine(DateTime.Now.ToString("dddd"));//Monday

//Aylar için
System.Console.WriteLine(DateTime.Now.ToString("MM"));  //05
System.Console.WriteLine(DateTime.Now.ToString("MMM")); //May
System.Console.WriteLine(DateTime.Now.ToString("MMMM"));    //May

//Yıllar için
System.Console.WriteLine(DateTime.Now.ToString("yy")); //22
System.Console.WriteLine(DateTime.Now.ToString("yyyy")); //2022

//Math Kütüphanesi
System.Console.WriteLine(Math.Abs(-5));
System.Console.WriteLine(Math.Sin(10));
System.Console.WriteLine(Math.Cos(10));
System.Console.WriteLine(Math.Tan(10));

//Yuvarlama İşlemleri
System.Console.WriteLine(Math.Ceiling(22.3)); //Celling yukarıya yuvarlar
System.Console.WriteLine(Math.Round(22.3));   //Round en yakın değere yuvarlar 22
System.Console.WriteLine(Math.Round(22.6));   // burada En yakın değer 23 
System.Console.WriteLine(Math.Floor(22.9));   //Aşağıya en küçük değere yuvarlar 22

System.Console.WriteLine(Math.Max(6,3));
System.Console.WriteLine(Math.Min(6,3));

System.Console.WriteLine(Math.Pow(6,2)); //6^2 
System.Console.WriteLine(Math.Sqrt(81)); //81 karekökü alır
System.Console.WriteLine(Math.Log(6));   //6'nın e tabanındeki logoritmik karşılğını getirir.  
System.Console.WriteLine(Math.Exp(0));    // e^0 verir.
System.Console.WriteLine(Math.Log10(3));  // 3 sayısının logoritme 10 tabanındeki karşılığı.