public class Program
{   
    static void Main(string[] args)
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nAngiv dit password!");
            Console.ForegroundColor = ConsoleColor.Blue;

            char[] chars = Console.ReadLine().ToCharArray(); //Tag passworded og lig det i et array

            bool uppercaseChecker = UppcaseChecker(chars); //Kør uppercaseChecker
            bool lowercaseChecker = LowercaseChecker(chars); //Kør lowercaseChecker
            bool numberChecker = NumberChecker(chars); //Kør numberChecker
            bool specialChecker = SpecialChecker(chars); //Kør specialChecker

            PasswordChecker(LenghtChecker(chars), uppercaseChecker, lowercaseChecker, numberChecker, specialChecker); //Kør passwordchecker, hvordan er længden, er der upper- lowercase, numbers og special charakters

            if (!uppercaseChecker || !lowercaseChecker || !numberChecker || !specialChecker) 
            //Hvis uppercase eller lowercase eller numbers eller special charackters er FALSK
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("PASSWORD IKKE STÆRKT NOK"); //Password er ikke stærkt nok
            }
            else //Hvis uppercase og lowercase og numbers og special charackters er SANDT
            {
                if (ContinuousNumberChecker(chars) || ContinuousLetterChecker(chars)) //Hvis ContinuousNumberChecker eller ContinuousLetterChecker er SANDT
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("PASSWORD SVAGT"); //Password er svagt
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("PASSWORD GOOD"); //Ellers er password goodt
                }
            }
        }
    }

    static void PasswordChecker(int lenghtchecker, bool uppcasechecker, bool lowercasechecker, bool numberchecker, bool specialchecker)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        switch (lenghtchecker) //For værdierne fra lenghtchecker
        {
            case 1: //Hvis lenghtchecker er 1, er password for kort <12
                Console.WriteLine("Dit password er for kort! Det skal minimum være på 12 karakterer");
                break;
            case 2: //Hvis lenghtchecker er 2, er password for langt >64
                Console.WriteLine("Dit password er for langt! Det må maks være på 64 karakterer");
                break;
        }

        if (!uppcasechecker) //Hvis uppcasechecker er FALSE, WriteLine "Fejl uppercase"
        {
            Console.WriteLine("Fejl uppercase!");
        }

        if (!lowercasechecker) //Hvis lowercasechecker er FALSE, WriteLine "Fejl lowercase"
        {
            Console.WriteLine("Fejl lowercase!");
        }

        if (!numberchecker) //Hvis numberchecker er FALSE, WriteLine "Fejl tal"
        {
            Console.WriteLine("Fejl tal!");
        }

        if (!specialchecker) //Hvis specialchecker er FALSE, WriteLine "Fejl speciel character"
        {
            Console.WriteLine("Fejl speciel character!");
        }
    }

    static bool ContinuousNumberChecker(char[] chars) //Checker om de 4 næste chars er numre og om de 3 (2,3,4) er forløbende til nr 1
    {
        for (int i = 0; i < chars.Length-3; i++)
        {
            if (char.IsDigit(chars[i]) && char.IsDigit(chars[i+1]) && char.IsDigit(chars[i+2]) && char.IsDigit(chars[i+3]))
                //Hvis char i er et nummer og char i +1 er et nummer og char i +2 er et nummer og char i+3 er et nummer
            {
                if (chars[i+1] == chars[i] && chars[i+2] == chars[i] && chars[i+3] == chars[i])
                    //Hvis chars i+1 = chars i og chars i+2 = chars i og chars i+3 = chars i retuner true
                {
                    return true;
                }
            }
        } //ellers retuner false
        return false;
    }

    static bool ContinuousLetterChecker(char[] chars) //Checker om de 4 næste chars er ligmed nr 1
    {
        for (int i = 0; i < chars.Length - 3; i++)
        {
            if (chars[i + 1] == chars[i] && chars[i + 2] == chars[i + 1] && chars[i + 3] == chars[i + 2])
            //Hvis chars i +1 = chars i && og chars i +2 = chars i +1 og chars i +3 = chars i +2 retuner true
            {
                return true;
            }
        } //Ellers retuner false
        return false;
    }

    static byte LenghtChecker(char[] chars) //Checker om længden af chars
    {
        int length = chars.Length;

        if (length <12) //Hvis længden af chars er mindre end 12 retuner 1
        {
            return 1;
        }
        else if (length >64) //Hvis længden af chars er størrer end 64 retuner 2
            {
            return 2;
        }
        else //Hvis værken længden af chars er <12 eller >64 retuner 3
        {
            return 3;
        }
    }

    static bool UppcaseChecker(char[] chars) //Checker om der er uppercase med
    {
        int c = 0;
        for (int i = 0; i < chars.Length; i++) //Kører for hver char i arryaet
        {
            if (char.IsUpper(chars[i])) //Hvis charen er uppercase (.IsUpper) + c med 1
            {
                c++;
            }
        }
        if (c > 0 && c < chars.Length) //Hvis c er > 0 og c er < end længenden af chars retuner true
        {
            return true;
        }
        return false;
    }

    static bool LowercaseChecker(char[] chars) //Checker om der er lowercase med
        {
        int c = 0;
        for (int i = 0; i < chars.Length; i++) //Kører for hver char i arryaet
            {
            if (char.IsLower(chars[i])) //Hvis charen er lowercase (.IsLower) + c med 1
                {
                c++;
            }
        }
        if (c > 0 && c < chars.Length) //Hvis c er > 0 og c er < end længenden af chars retuner true
            {
            return true;
        }
        return false;
    }

    static bool NumberChecker(char[] chars) //Checker om der er numre med
        {
        int c = 0;
        for (int i = 0; i < chars.Length; i++) //Kører for hver char i arryaet
            {
            if (char.IsDigit(chars[i])) //Hvis charen er et nummer (.IsDigit) + c med 1
                {
                c++;
            }
        }
        if (c > 0 && c < chars.Length) //Hvis c er > 0 og c er < end længenden af chars retuner true
            {
            return true;
        }
        return false;
    }

    static bool SpecialChecker(char[] chars) //Checker om der er specelle tegn med
        {
        int c = 0;
        for (int i = 0; i < chars.Length; i++) //Kører for hver char i arryaet
            {
            if (char.IsLetterOrDigit(chars[i])) //Hvis charen er et bogstav eller nummer (.IsLetterOrDigit) + c med 1
                {
                c++;
            }
        }
        if (c > 0 && c < chars.Length) //Hvis c er > 0 og c er < end længenden af chars retuner true
        {
            return true;
        }
        return false;
    }
}

