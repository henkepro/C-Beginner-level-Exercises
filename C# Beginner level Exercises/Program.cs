///Basics Exercises C# - Variabler
///

//Övning 1
/*
//1.Hälsa på användaren
//Skriv ett program som frågar efter användarens namn och printar ut en hälsning på konsolen.

///Konverterar ReadLine och lagras i userName some skrivs ut i consolen i efterhand.
Console.WriteLine("Hej, användare. Vad ska vi kalla dig?");
string userName = Console.ReadLine()!;

Console.WriteLine($"Hej {userName}!");
*/

//Övning 2
/*
//2. Multiplicera två tal
//Skriv ett program som ber användaren mata in två heltal. Skriv ut talen multiplicerade med varandra.

///Lagrar två separata ReadLines i x och printas ut.
Console.WriteLine("Hi user. Please enter two separate numbers");
double x = Int32.Parse(Console.ReadLine()) * Int32.Parse(Console.ReadLine());
Console.WriteLine(x);
*/

//Övning 3
/*
//3.Verifiera lösenord
//Skriv ett program som frågar användaren efter ett lösenord. Hitta på ett hemligt lösenord och spara det i en variabel.
//När användaren har skrivit in ett lösenord ska programmet jämföra med det sparade
//lösenordet och skriva ut om det var rätt eller inte. Använd en if-sats.

///Tar användarens input och lagrar i userEnterPassword och jämför sedan dess värde med userPassword för att kolla if satsen.
Console.WriteLine("Användarens lösenord");
string userEnterPassword = Console.ReadLine()!;
string userPassword = "password";
if(userEnterPassword == userPassword)
{
    Console.WriteLine("Rätt lösenord!");
}
else
{
    Console.WriteLine("Fel lösenord!");
}
*/

//Övning 4
/*
//4.Jämför tal
//Skriv ett program som frågar användaren efter ett tal. Det ska skriva ut om talet är mindre, större eller lika med 100.

///Tar in ett värde från användaren och dubbel kollat talet och om varken statements gäller så returnerar den mindre än 100.
///Problem kan uppstå om man skriver in en text dock.
Console.WriteLine("Användare, var vänligen skriv in ett tal");
double userNumber = Int32.Parse(Console.ReadLine());

if (userNumber > 100)
{
    Console.WriteLine("Ditt tal är större än 100");
}
else if(userNumber == 100)
{
    Console.WriteLine("Ditt tal är likamed 100");
}
else
{
    Console.WriteLine("Ditt tal är mindre än 100");
}
*/

//Övning 5
/*
//5. Dubblera och halvera tal
//Be användaren mata in ett tal. Skriv ut talet som är dubbelt, respektive hälften.

///Tar in ett tal, consolen knappar ut talet multiplicerat med 2 samt halverat med 2 i samma linje.
Console.WriteLine("Användare, var vänlig mata in ett tal");
double userNumber = Int32.Parse(Console.ReadLine());

Console.WriteLine($"Dubblerat= {userNumber * 2}\t" + $"Halverat= {userNumber / 2}");
*/

//Övning 6
/*
//6. Miniräknare
//Skriv ett program som först frågar efter ett tal, sedan frågar efter ett av
//följande tecken: +, -, *eller /.Därefter ska ytterligare ett tal efterfrågas.
//Programmet ska fungera som en simpel miniräknare. Om man t.ex matat in först 3, sedan *, och sist 5,
//så ska programmet skriva ut “3 * 5 = 15”.

///Tar in ett värde och kollar om det kan konverteras till double tal och returnerar true eller false
///Kollar 3 conditions innan den går vidare och sedan tar in ett ytterligare tal som läggs på det föregående talet sen breakar den ur switchen
Console.WriteLine("Var vänligen knappa in ett tal");
string userString = Console.ReadLine();
double userValue1;
double userValue2;
double newValue;

bool stringConvert = double.TryParse(userString, out userValue1);

if (stringConvert == true) {
    Console.WriteLine("+ , - eller / ?");
    string userAddition = Console.ReadLine();
    if(userAddition == "+" || userAddition == "-" || userAddition == "/")
    {
        Console.WriteLine("Knappa in ett till tal");
        userString = Console.ReadLine();
        stringConvert = double.TryParse(userString, out userValue2);
    switch (userAddition)
        {
            case "+":
                newValue = userValue1 + userValue2;
                Console.WriteLine(newValue);
                return;
            case "-":
                newValue = userValue1 - userValue2;
                Console.WriteLine(newValue);
                return;
            case "/":
                newValue = userValue1 / userValue2;
                Console.WriteLine(newValue);
                return;
            default:
                break;
        }
    }
}
*/

//Övning 7
/*
//7.Summa och medelvärde
//Skriv ett program som upprepade gånger frågar användaren efter ett tal
//ända till man skriver något som inte är ett tal (t.ex bara trycker enter).
//Efter varje inmatning ska summan av alla tal som matats in skrivas ut,
//innan nästa inmatning efterfrågas. Innan programmet avslutas ska man även skriva ut medelvärde av de inmatade talen.

///tar in ett värde kollar om det är ett tal och om det är så går man vidare till while loopen som fortfarande kollar true eller false.
///lägger på värdet av userValue till userResult samt "hemligt" räknar antal gånger man knappat in
///Loggar i konsolen userResult. I slutet när man hoppar ur while loopen så räknar den medelvärdet genom att ta userResult(Hela) delat på antal inputs userInputs
Console.WriteLine("Knappa in ett tal");
string userString = Console.ReadLine();
double userValue;
double userResult;
double userInputs = 0;

bool inputInfo = double.TryParse(userString, out userValue);
userResult = userValue;
userInputs++;
Console.WriteLine("--------------------");
Console.WriteLine("Ditt totala värde är: " + userResult);

while (inputInfo)
{
    Console.WriteLine("Knappa in ett till tal");
    userString = Console.ReadLine();
    inputInfo = double.TryParse(userString, out userValue);
    userResult += userValue;
    userInputs++;
    Console.WriteLine("--------------------");
    Console.WriteLine("Ditt totala värde är: " + userResult);
}
Console.WriteLine("Medelvärdet av ditt total värde är: " + userResult / userInputs);
*/

///Basics Exercises C# - Indexering av strängar och arrayer
///

//Övning 1
/*
//1.En bokstav på varje rad
//Be användaren mata in en sträng. Skriv ut varje tecken i strängen på en egen rad.


///Tar in ett sträng-värde och i for-loopen kollar den längden på strängen samt skriver den ut i console
///strängen av newString med [] som indikerar var någonstans på stringen. Ex index [0] = H på "hej" och [2] = j
string newString = Console.ReadLine();

for (int i = 0; i < newString.Length; i++)
{
    Console.WriteLine(newString[i]);
}
*/

//Övning 2
/*
//2. Siffror till text
//Skapa ett program med en array som innehåller strängarna “noll”, “ett”, “två”,
//“tre”, “fyra”, “fem”, “sex”, “sju”, “åtta”, “nio”.
//Be sedan användaren att mata in en siffra. Använd arrayen för att skriva ut siffrans ord. Ex. Inmatning “3” => “tre”.


//Extra utmaning 0, 1, 2:; Användaren kan mata in en sträng med fritt antal siffror,
//om man skriver in t.ex 432 så svarar programmet: “fyra - tre - två”.

///kollar antalet "strängar" i nyttNummer och konverterar "siffran" som stränger ger och sedan konverterar till
/// string från char och från char till int som sedan läggs till i "resultat". Samt ökar värde på index för varje "sträng"
/// If-satsen kollar om längden på strängen har nåtts genom att jämföra med index och om index == nyttNummer.Length
/// så innebär det att "slutet" av strängen har nåtts. Om inte så läggs ett " - " sträng in i slutet av varje string array.
string[] aNumber = new string[] { "noll", "ett", "två", "tre", "fyra" };
int[] aNumber2 = new int[] { 0, 1, 2 };
Console.WriteLine("Skriv ett nummer");
string nyttNummer = Console.ReadLine();
string resultat = "";
int index = 0;
bool numbers = int.TryParse(nyttNummer, out int nyaNumret);


if (numbers) {
    foreach (char s in nyttNummer)
    {
        // Omvandlar tecknet till ett heltal
        nyaNumret = int.Parse(s.ToString());
        // Lägg till motsvarande namn från arrayen
        resultat += aNumber[nyaNumret];
        index++;
        if (index != nyttNummer.Length)
        {
            resultat += " - ";
        }
    }
}
Console.WriteLine(resultat);


Console.WriteLine("");
Console.WriteLine("---------");


// Be användaren att mata in en sträng med siffror
Console.Write("Mata in en sträng med siffror: ");
string input = Console.ReadLine();

// Array som mappar siffror till deras svenska namn
string[] numberNames = { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };

// Skapa en lista för att lagra namnen på siffrorna
string result = "";

// Loop genom varje tecken i inmatningen
for (int i = 0; i < input.Length; i++)
{
    char digit = input[i];
    // Omvandlar tecknet till ett heltal

    int number = int.Parse(digit.ToString());

    result += numberNames[number];

    if (i < input.Length - 1)
    {
        result += " - ";
    }
}

// Skriv ut resultatet
Console.WriteLine(result);
Console.WriteLine(aNumber[nyaNumret]);
*/

//Övning 3
/*
//3.Baklänges
//Be användaren mata in en text. Skriv sedan ut texten baklänges.

///Loggar userText längd och sätter index samma som dess längd men -1 för att arrays börjar från 0 och strings börjar från 1
///Forloopen skriver ut från "där index indikerar, alltså sista siffran sedan loopas index ner stegvis.
/// int i kollar hur många gånger som loopen ska köras.
Console.WriteLine("Användare var vänligen knappa in en text.");
string userText = Console.ReadLine();
int index = 0;
index = userText.Length - 1;
for(int i = 0; i < userText.Length; i++)
{
    Console.Write(userText[index]);
    index--;

}
*/

//Övning 4
/*
//4. Dölj vokaler
//Be användaren mata in en text. Skriv ut texten med alla vokaler ersatta med *

//Exempel:

//Skriv något: Hejsan, jag heter Fredrik!
//H*js*n, j*g h*t*r Fr*dr*k!
//Extra utmaning: Skriv ut texten översatt till rövarspråket.


Console.WriteLine("Var vänlig knappa in en text");
string userText = Console.ReadLine();
string[] userStrings1 = new string[] {"a", "o", "u", "å", "e", "i", "y", "ä", "ö"};
bool isVokal = false;

// Kollar varje bokstav i userText
foreach (char v in userText)
{
    //For loop för av loopa igenom arrayen userStrings
   for (int i = 0; i < userStrings1.Length; i++)
    {
        //checkar Arrayens innehåll med "v" strängen samt ignorera upper/lowercase
        //Om true så skriver den "*" och sätter isVokal = true samt hoppar ur for-loopen så man inte går vidare till else
        //för då sätts isVokal till false igen.
        if (userStrings1[i] == v.ToString().ToLower())
        {
            Console.Write("*");
            isVokal = true;
            break;
        } 
        else
        {
            isVokal = false;
        }
    }
   //Kollar om isVokal är falskt om sant så skriver den ut "v" strängen
   if(isVokal == false)
    {
        Console.Write(v);
    }
}
*/

//Övning 5
/*
//5. Palindrom
//Ett palindrom är ett ord som blir samma framlänges som baklänges.
//Be användaren skriva in ett ord och ange sedan om det är ett palindrom eller inte.

//Exempel:

//Skriv ett ord: Kajak
//Kajak är ett palindrom.


Console.WriteLine("Skriv in ett ord");
string isPalindrom = Console.ReadLine();
int index = isPalindrom.Length - 1;
bool isKajak = false;

//Forloopen skriver isPalindrom strängen baklänges.
for (int i = 0; i < isPalindrom.Length; i++)
{ 
    Console.Write(isPalindrom[index]);
    index--;
}
Console.WriteLine("");

//Sätter index till sin föregående längd så vi får en loop som går baklänges.
//Om Loopen lyckas ta sig igenom alla bokstäver utan att "break;" så kommer isKajak bli true annars false.
index = isPalindrom.Length - 1;
foreach (char c in isPalindrom)
{
    if(c == isPalindrom[index])
    {
    index--;
    }else if(c != isPalindrom[index])
    {
        break;
        isKajak = false;
    }
    isKajak = true;
}
//Kollar om isKajak är true om sant då är det en palindrom.
if (isKajak)
{
    Console.WriteLine("Its a palindrom!");
}
*/

//Övning 6
/*
//6. Miniräknare
//Skapa en enkel miniräknare som kan hantera de fyra räknesätten med två operander.
//inmatningen nu ske på en rad (första talet, operator, andra talet).
//Ignorera inmatade mellanslag i strängen. Om man t.ex. matar in strängen "34 - 14",
//så ska programmet skriva ut "= 20".


Console.WriteLine("Mata in en uträkning (t.ex. 34 - 14):");
string userInput = Console.ReadLine();

// Remove all spaces from the input
userInput = userInput.Replace(" ", "");

// Variables to store the operands and operator
int operator1 = 0;
int operator2 = 0;
char operatorChar = ' ';
int result = 0;

// Find the operator and split the string into operators
for (int i = 0; i < userInput.Length; i++)
{
    if (userInput[i] == '+' || userInput[i] == '-' || userInput[i] == '*' || userInput[i] == '/')
    {
        operatorChar = userInput[i];
        operator1 = int.Parse(userInput.Substring(0, i)); //Substring extractar från 0 till i men inte i
        operator2 = int.Parse(userInput.Substring(i + 1)); //Substring extractar från i+1 alltså ett steg ifrån i och till slutet
        break;
    }
}

// Calculate the result based on the operator
switch (operatorChar)
{
    case '+':
        result = operator1 + operator2;
        break;
    case '-':
        result = operator1 - operator2;
        break;
    case '*':
        result = operator1 * operator2;
        break;
    case '/':
        if (operator2 != 0)
        {
            result = operator1 / operator2;
        }
        else
        {

        }
        break;
    default:
        Console.WriteLine("Ogiltig operator.");
        return;
}

// Output the result
Console.WriteLine($"= {result}");
*/

//Övning 7
/*
//7. Omvänd ordning
//Be användaren skriva in ett ord, sedan ett till, och ett till; tills man skrivit in 7 ord.
//Skriv sedan ut orden på skärmen i bakvänd ordning mot hur de matades in.
//Alltså ordet man skrev in sist, skrivs ut först.
string[] nyaOrd = new string[7];
int index = 0;
Console.WriteLine("Skriv in 7 ord");

//Lägger in värden i arrayen
for (int i = 0; i < 7; i++)
{
    nyaOrd[i] = Console.ReadLine();
}
index = nyaOrd.Length - 1;
//Skriver ut värden i arrayen, börjar ifrån högsta indexet och stegar ner med 1 varje gång
for (int j = 0; j < nyaOrd.Length; j++)
{
    Console.WriteLine(nyaOrd[index]);
    index--;
}
*/

//Övning 8
/*
//8. Fördröjd utskrift
//Skapa ett program som ber användaren att skriva in ett ord.
//Sedan ett till, och ett till i all evighet.
//Varje gång man skrivit in ett ord så ska programmet skriva ut det ord man skrev 10 inmatningar tidigare.
//Men om man inte skrivit in 10 ord än så kan den istället skriva just det: “Du har inte skrivit in 10 ord än.”

Console.WriteLine("Skriv in ett ord");
bool userTyping = true;
bool firstSentence = true;
int index = 10;
string savedString = "";
//För en evighets loop så kollar while loopen om userTyping är true, vilket den alltid är.
while (userTyping)
{
    index--;
    string nyttOrd = Console.ReadLine();
    //Kollar firstSentence om true så kommer den spara "nyttOrd" in i savedString sedan blir firstSentence false
    //och då kan loopen inte komma in igen förräns den blir true.
    if(firstSentence == true)
    {
        savedString = nyttOrd;
        firstSentence = false;
    }
    //Efter 10 loops så blir index == 0 true så återställs index till 10 och sätter firstSentence till true
    //samt skriver ut den sparade "strängen".
    if (index == 0)
    {
        index = 10;
        firstSentence = true;
        Console.WriteLine(savedString);
        Console.WriteLine("---------");
    }
    else
    {
        Console.WriteLine("Du har inte skrivit in 10 ord än.");
    }
}
*/

//Övning 9
/*
//9. Bokstavspyramid
//Skapa ett program som skriver ut första tecknet i "Hello World" på första raden, de 2 första tecknen på andra raden osv.

//Exempel:

//H
//He
//Hel
//...
//Hello Worl
//Hello World

//Console.WriteLine("Skriv ett ord");
int index = 0;
string nyttOrd = "Hejsan";
int i = 0;
int stringLength = nyttOrd.Length;
int letterIndex = 0;
index = nyttOrd.Length + 1;

while (stringLength > i)
{
    // kommer skriva första bokstaven
    Console.Write(nyttOrd[letterIndex]);
    index--;
    letterIndex++;
    // Basically när koden har "skrivit" klart sina stränger så ska
    // index == nyttOrd.Length - i vara samma värde och då kommer koden att ändra om index igen så att den loopar om
    // men med högre värde på i som gör att det "tar" längre tid att loopa in i if-satsen hence längre rad
    if (index == nyttOrd.Length - i)
    {
        index = nyttOrd.Length + 1;
        letterIndex = 0;
        i++;
        Console.WriteLine("");
    }
}

index = 0;
i = 0;


while (index <= nyttOrd.Length - i)
{
    if(index < nyttOrd.Length - i)
    {
        Console.Write(nyttOrd[index]);
        index++;
        
        //samma som föregående kod men tvärtom. Istället för att index sänks så ökas den istället.
        //Vilket leder till att "index" måste nå upp hela vägen innan den kan återställa sig själv
        //Och det leder till att hela raden skrivs eftersom i börjar på 0 och ökas endast inuti if-satsen
        if (index == nyttOrd.Length - i)
        {
            index = 0;
            i++;
            Console.WriteLine("");
        }
    } else
    {
        break;
    }
}

Console.WriteLine("End of line");
*/

//Övning 10
/*
//10. Färgade bokstäver
//Man kan byta färg som används för utskrift i console med hjälp av Console.ForegroundColor
//(t.ex Console.ForegroundColor = ConsoleColor.Red)

//Skapa ett program som ber användaren mata in en text. Be sedan användaren mata in en bokstav. '
//Skriv ut strängen som matades in; de bokstäver som är samma som den användaren valde ska skriva ut med röd färg,
//alla andra med grå..

//Exempel:

//Mata in en text: Hejsan hoppsan!
//Välj en bokstav: s
//Hejsan hoppsan!

//OBS! Färgkodning i markdown verkar inte visas på GitHub.
//Check ut och visa denna filen i visual studio eller visual studio code istället!
bool isRed = false;
Console.WriteLine("Mata in en text");
string vanligText = Console.ReadLine();

Console.WriteLine("Mata in en bokstav");
string rödBokstav = Console.ReadLine();

for(int i = 0; i < vanligText.Length; i++)
{
    //Loopen kollar igenom varje siffra ifrån vanligText och om texten matchar så skriver den ut den bokstaven
    //Och sätter isRed till false så att det inte blir dubbeltextat.
    for(int j = 0; j < rödBokstav.Length; j++)
    {
        if (rödBokstav[j] == vanligText[i])
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(rödBokstav);
            isRed = true;
        }
    }
    //För att undvika dubbeltextning. Är bokstaven inte röd så textas inget förutom ovan IF-sats
    if (isRed == false) 
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(vanligText[i]);
    }
    //I slutet av loopen så sätter den tillbaks isRed till false så den kan hoppa in i isRed igen
    isRed = false;
}
*/

//Övning 11
/*
//11. Start & Stop
//Be användaren mata in en text. Be sedan om ett startindex, och sedan om ett stopindex.
//Skriv ut hela texten, men alla tecken från startindex till stopindex ska vara röda.


Console.WriteLine("Mata in en text!");
string nyText = Console.ReadLine();
Console.WriteLine("Ett startindex");
int startIndex = Int32.Parse(Console.ReadLine());
Console.WriteLine("Ett stoppindex");
int slutIndex = Int32.Parse(Console.ReadLine());
startIndex = startIndex - 1;
bool typeIndex = true;

for(int i = 0; i < nyText.Length; i++)
{
    //Om i är större eller likamed startindex samt typeIndex är sant så kommer den att
    //Skriva ut en röd text och öka upp startIndex för att sedan kolla ifall startIndex blir samma som slutIndex
    //Om true så kommer den IF-satsen bli False vilket leder till att den skriver ut vanlig text istället.
    if (i >= startIndex && typeIndex == true)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(nyText[i]);
        startIndex++;
        if(startIndex == slutIndex)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            typeIndex = false;
        }
    }
    else
    {
        Console.Write(nyText[i]);
    }
}
*/

//Övning 12
/*
//12. Växla färg
//Be användaren mata in en text. Be sedan användaren mata in en bokstav.
//Skriv ut hela texten, rödmarkera från första stället den hittar bokstaven till
//andra stället den hittar bokstaven, från tredje stället till fjärde o.s.v.

Console.WriteLine("Mata in en text");
string nyString = Console.ReadLine();
Console.WriteLine("Mata in en bokstav");
string nyBokstav1 = Console.ReadLine();
Console.WriteLine("Mata in en bokstav");
string nyBokstav2 = Console.ReadLine();
bool nyBtrue = true;
int index = 0;

foreach(char c in nyString)
{
    //Checks the c string to nyBokstav and nyBtrue if its still true
    //If conditions are met sets color to red and types.
    if(c.ToString() == nyBokstav1 && nyBtrue)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(c);
        //To avoid "baba" and b to b to not stop at first letter index != 0 was needed.
        //Code checks within contact of first "letter" until char c hits the second letter and jumps out the if-statement.
        if (c.ToString() == nyBokstav2 && index != 0)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            nyBtrue = false;
        }
        index++;
    }
    else
    {
        Console.Write(c);
    }
}
*/

///Basics Exercises C# - Loopar
///

//Övning 1
/*
//1.Skriv talen 20 till 30
//Skriv en loop som skriver ut alla tal från 20 till 30.

//Exempel:

//20
//21...
//29
//30

//loopar från 20 till 30 men börjar på 20 och räknar upp 10 ggr samt lägger på 1 på index varje gång.
int index = 20;
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(index);
    index++;
}
*/

//Övning 2
/*
//2.Jämna tal
//Skriv en loop som skriver ut alla jämna tal från 0 till 30.

//Exempel:

//0
//2...
//28
//30

for (int i = 0; i <= 30; i++)
{
    //Om det är delbart med 2 och rest 0 så skriver den ut. Annars går den till else och printar inget men adderar upp i;
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
*/

//Övning 3
/*
//3.Var tredje "Hej"
//Skriv en loop som skriver ut tal från 0 till 30, men om talet är jämnt delbart med 3 skriv istället “Hej”

//Exempel:

//"Hej"
//1
//2
//"Hej"
//4...
//29
//"Hej"

for (int i = 0; i <= 30; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine("hej");
    } else
    {
        Console.WriteLine(i);
    }
}
*/

//Övning 4
/*
//4.Gångertabell
//Gör ett program som ber användaren mata in ett tal, skriv ut det
//talets “gångertabell” dvs, multiplikationer av talet med alla tal från 1 t.o.m. 10.

//Exempel:

//Skriv in ett tal: 4
//1 * 4 = 4
//2 * 4 = 8...
//10 * 4 = 40

Console.WriteLine("Mata in ett tal");
int nyttTal = Int32.Parse(Console.ReadLine());
int result = 0;

for (int i = 1; i <= 10; i++)
{
    result = nyttTal * i;
    Console.WriteLine(result);
}
*/

//Övning 5
/*
//5.Summa
//Summan av alla tal 1 till 4, är 10 (1+2+3+4). Gör ett program som räknar ut summan av alla tal 1 till 1000.

int index = 0;
int result = 0;
for (int i = 0; i < 1000; i++)
{
    result += i; 
}
Console.WriteLine(result);
*/

//Övning 6
/*
//6. Riskorn på shackbräde

//Antalet riskorn bestämdes enligt följande regel: ett korn skulle lämnas för första rutan på ett schackbräde,
//två korn för andra rutan, fyra för tredje, åtta för fjärde och så ändå till den sista rutan.

//Skriv ett program som hjälper kungen att beräkna antalet riskorn på vardera ruta.

//Exempel:

//Ruta 1: 1
//Ruta 2: 2
//Ruta 3: 4
//Ruta 4: 8
//Ruta 5: 16...
//Ruta 64: ???

Int128 result = 1;

for (int i = 1; i <= 64; i++)
{
    Console.WriteLine($"Ruta {i}:{result}");
    result *= 2;
}

*/

//Övning 7
/*
//7.Fylld box
//Gör ett program som ber användaren mata in höjd och bredd.
//Printa ut en “box” med bokstaven X på skärmen med den höjd och bredd som matats in.


Console.WriteLine("Skriv in Höjd");
int boxHöjd = int.Parse(Console.ReadLine());
Console.WriteLine("Skriv in Bredd");
int boxLängd = int.Parse(Console.ReadLine());
Console.WriteLine("");
for (int i = 0; i < boxHöjd; i++)
{
    for (int j = 0; j < boxLängd; j++)
    {
        Console.Write("X");
    }
    Console.WriteLine("");
}
*/

//Övning 8
/*
//8. Randig box
//Samma som uppgift 7, men för varannan kolumn skrivs bokstaven O istället för X.

Console.WriteLine("Skriv in Höjd");
int boxHöjd = int.Parse(Console.ReadLine());
Console.WriteLine("Skriv in Bredd");
int boxLängd = int.Parse(Console.ReadLine());
Console.WriteLine("");

for (int i = 0; i < boxHöjd; i++)
{
    for (int j = 0; j < boxLängd; j++)
    {
        if (j % 2 == 0)
        {
            Console.Write("X");
        }
        else
        {
            Console.Write("O");
        }
    }
    Console.WriteLine("");
}
*/

//Övning 9
/*
//9. Rutig box
//Samma som uppgift 8, men med ett schackrutemönster.

Console.WriteLine("Skriv in Höjd");
int boxHöjd = int.Parse(Console.ReadLine());
Console.WriteLine("Skriv in Bredd");
int boxLängd = int.Parse(Console.ReadLine());
Console.WriteLine("");
int index = 2;

for (int i = 0; i < boxHöjd; i++)
{
    if (index % 2 == 1)
    {
        for (int j = 0; j < boxLängd; j++)
        {
            if (j % 2 == 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
        }
    }
    if(index % 2 == 0)
    {
        for (int j = 0; j < boxLängd; j++)
        {
            if (j % 2 == 0)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
        }
    }
    index++;
    Console.WriteLine("");
}

*/

//Övning 10
/*
//10. Ihålig box
//Fråga efter bredd och höjd och skriv ut en “box” som inte är fylld.

Console.WriteLine("Skriv in Höjd");
int boxHöjd = int.Parse(Console.ReadLine());
Console.WriteLine("Skriv in Bredd");
int boxLängd = int.Parse(Console.ReadLine());
Console.WriteLine("");

int startPoint = 0;
int midPoint = 0;
int endPoint = boxHöjd;


for (int i = 0; i < boxHöjd; i++)
{
    for (int f = 0; f < boxLängd; f++)
    {
        if (startPoint == 0)
        {
             Console.Write("X");
        }
        else if (midPoint != 0 && midPoint != endPoint - 1)
        {
            if (f == 0 || f == boxLängd - 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write(" ");
            }
        }
        else if (endPoint != 0)
        {
                Console.Write("X");
        }
        startPoint++;
    }
    midPoint++;
    Console.WriteLine("");
}
*/

//Övning 11
/*
//11. Sifferpyramid
//Gör ett program som skriver “1” på första raden, “12” på nästa, sen “123”
//osv upp till rad 9 där det står “123456789”

string pyramidLength = "123456789";

for (int i = 0; i < pyramidLength.Length; i++)
{
        for (int loopValue = 0; loopValue <= i; loopValue++)
        {
            Console.Write(pyramidLength[loopValue]);
        }
    Console.WriteLine("");
}
*/

//Övning 12
/*
//12.Nio sifferpyramider
//Gör ett program som skriver ut “pyramider” som i uppgiften ovan, den första ska vara med en rad,
//följt av en pyramid med 2 rader, sen 3 rader etc. ända upp till 9 rader i den sista pyramiden.


string pyramidLength = "123456789";

for (int i = 0; i < pyramidLength.Length; i++)
{
    for (int loopAmount = 0; loopAmount <= i; loopAmount++) 
    {
        for (int loopValue = 0; loopValue <= loopAmount; loopValue++)
        {
            Console.Write(pyramidLength[loopValue]);
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}
*/

//Övning 13
/*
//13.Primtal
//Primtal är heltal större än 1 som inte går att jämnt dela med något annat heltal
//(förutom 1 eller talet själv, eftersom alla tal är delbara med
//sig själva och 1). De 5 första primtalen är 2, 3, 5, 7, 11. Skriv ett program som listar de första 20 primtalen.

bool isPrimtal = false;
for (int i = 2; i < 72; i++)
{

    if (i % 2 == 0 || i % 3 == 0 || i % 5 == 0 || i % 7 == 0 && isPrimtal == false)
    {
        if(i == 2 || i == 3 || i == 5 || i == 7)
        {
            isPrimtal = true;
            Console.WriteLine("prim" + i);
        }
    } 
    else
    {
        Console.WriteLine("prim" + i);
        isPrimtal = false;
    }
}
*/

//Övning 14
/*
//14. Spel - Gissa tal
//Gör ett gissa-spel som har ett hemligt nummer (lagrat i en variabel i koden) mellan 1 och 100.
//När spelet startar ombeds spelaren att gissa ett tal mellan 1-100.
//Gissar man för lågt skriver programmet ut att man gissat för lågt, och man får gissa igen.
//Gissar man för högt skriver programmet att man gissat för högt och man får gissa igen.
//Gissar man rätt så skriver programmet att
//man gissat rätt, samt antal gissningar som krävdes för att gissa rätt.

Random random = new Random();
int randomNumber = random.Next(1, 101);
int userAttempts = 0;
int userNumber = 0;

Console.WriteLine("Gissa ett tal mellan 1 och 100");

while (true)
{
    userNumber = int.Parse(Console.ReadLine());
    userAttempts++;
    if (userNumber < randomNumber)
    {
        Console.WriteLine("Too low, try again!");
    }
    else if (userNumber > randomNumber)
    {
        Console.WriteLine("Too high, try again!");
    }
    else 
    {
        Console.WriteLine("Right number! Yay");
        Console.WriteLine($"{userAttempts} attempts!");
        break;
    }
}
//Extrauppgift: Klassen “Random” i .NET kan användas för att sätta den
//hemliga variabeln till ett slumpmässigt tal 1-100. Googla “C# Random” och se om
//du får det att fungera så det blir olika tal varje gång man kör programmet.

///Gjorde det i övning 14.
*/

//Extra  14
/*
//Extrauppgift 2: Gör så att datorn själv (automatiskt) spelar spelet,
//och gissar tal. Skriv ut output precis som innan så man kan följa hur den spelat.
//Försök få den att lösa det så effektivt (så få drag) som möjligt.

Random random = new Random();
int randomNumber = random.Next(1, 101);
int userNumber = random.Next(1, 101);
int lowResult = 1;
int highResult = 101;
int userAttempts = 0;

Console.WriteLine("Gissa ett tal mellan 1 och 100");
Console.WriteLine($"is it {userNumber}?");
Console.WriteLine("");
while (true)
{
    userAttempts++;
    if (userNumber < randomNumber)
    {
        Console.WriteLine("Too low, try again!");
        lowResult = userNumber;
        userNumber = random.Next(lowResult + 1, highResult + 1);
    }
    else if (userNumber > randomNumber)
    {
        Console.WriteLine("Too high, try again!");
        highResult = userNumber;
        userNumber = random.Next(lowResult + 1, highResult + 1);
    }
    else
    {
        Console.WriteLine($"Right number was {userNumber}! Yay");
        Console.WriteLine($"{userAttempts} attempts!");
        break;
    }
    Console.WriteLine("");
    Console.WriteLine($"is it {userNumber}?");
    Console.WriteLine("");
}
*/

//Övning 15
/*
//15. Sten, sax, påse
//Skriv ett sten-sax-påse spel. Användaren skriver in “sten”, “sax” eller “påse”.
//Dators val slumpas med Random. Skriv sedan ut vad datorn valde, och vem som vann omgången.
//Lägg det hela i en loop så spelet fortsätter tills man matar in en tom sträng
//(trycker enter utan att skriva något). Skriv även ut poäng.
Random random = new Random();
Console.WriteLine("Skriv in \"sten\", \"sax\" eller \"påse\"");
string userInput = "";
int compInput = 0;
int pcResult = 0;
int plyResult = 0;

string[] rndString = new string[] {"sten", "sax", "påse"};
string compValue = rndString[compInput];
Console.WriteLine("");
while (true)
{
    userInput = Console.ReadLine();
    Console.WriteLine("");
    if (userInput != "")
    {
        compInput = random.Next(0, 3);
        if (rndString[compInput] == rndString[0] && userInput == rndString[2])
        {
            Console.WriteLine("Player won");
            plyResult++;
        }
        else if (rndString[compInput] == rndString[0] && userInput == rndString[1])
        {
            Console.WriteLine("Computer won");
            pcResult++;
        }
        else if (rndString[compInput] == rndString[1] && userInput == rndString[2])
        {
            Console.WriteLine("Computer won");
            pcResult++;
        }
        else if (rndString[compInput] == rndString[1] && userInput == rndString[0])
        {
            Console.WriteLine("Player won");
            plyResult++;
        }
        else if (rndString[compInput] == rndString[2] && userInput == rndString[1])
        {
            Console.WriteLine("Player won");
            plyResult++;
        }
        else if(rndString[compInput] == rndString[2] && userInput == rndString[0])
        {
            Console.WriteLine("Computer won");
            pcResult++;
        }
        else 
        {
            Console.WriteLine("Draw!");
        }
        Console.WriteLine($"Computer Choice: {rndString[compInput]}, Player Choice: {userInput}");
        Console.WriteLine($"Computer: {pcResult}, Player: {plyResult}");
    }
    else
    {
        break;
    }
}
*/

///Basics Exercises - Funktioner
///

//Övning 1
/*
//1.Slå ihop för- och efternamn - skriv ut
//Skriv en funktion som tar två parametrar: firstName och lastName.
//Funktionen ska skriva ut hela namnet på skärmen.
//Testa genom att anropa funktionen med ditt namn.

//Exempel:

//PrintName("Fredrik", "Johansson");
//Skriver ut: Fredrik Johansson

static void UserName(string firstName, string lastName)
{
    Console.WriteLine(firstName + " " + lastName);
}
UserName("Henrik", "Vu");
*/

//Övning 2
/*
//2. Slå ihop för- och efternamn - returnera
//Skriv om funktionen ovan så att den istället för att
//skriva ut namnet returnerar en string med hela namnet.
//Anropa funktionen och skriv ut returvärdet.


static string ReturnFullName(string firstName, string lastName)
{
    return $"{firstName} {lastName}";
}
string fullName = ReturnFullName("Henrik", "Vu");
Console.WriteLine(fullName.ToLower());

*/

//Övning 3
/*
//3. Kolla om stängen är längre än ett givet antal tecken.
//Skriv en funktion som tar in en sträng och ett heltal.
//Om längden på strängen är större än heltalet returnera true, annars false.

static void ComparisonCheck(string Text, int Number)
{
    bool isTrue;
    if (Text.Length > Number)
    {
        isTrue = true;
    }
    else
    {
        isTrue = false;
    }
    Console.WriteLine(isTrue);
}

ComparisonCheck("Henrik", 10);

*/

//Övning 4
/*
//4. Omvandla Celsius till Fahrenheit
//Skriv en funktion som översätter ett värde från Celsius till Fahrenheit.
//Både in-parameter och returvärde ska vara av datatyp double.

static double tempConvert(double tempCelsius)
{
    return tempCelsius + 80;
}
double tempFahrenheit = tempConvert(20);
Console.WriteLine(tempFahrenheit + "f");
*/

//övning 5
/*
//5. Lägg in bindesträck mellan tecken i en sträng
//Skriv en funktion som tar in en sträng och returnerar en '
//sträng med ett bindestreck mellan varje tecken. T.ex om man
//skickar in “Fredrik” , så returnerar den “F-r-e-d-r-i-k”

static string StyledName(string userName)
{
    string editedName = "";
    int index = 0;
    foreach (char c in userName)
    {
        index++;
        editedName += c;
        if (index < userName.Length)
        {
            editedName += "-";
        }
    }
    return editedName;
}

string editedName = StyledName("Henrik");
Console.WriteLine(editedName);
*/

//Övning 6
/*
//6. Egen version av String.Join();
//Skriv en egen funktion som fungerar på samma sätt som String.Join();

int[] ints = new int[] {1,2,3,4,5};
string result = String.Join(", ", ints);

Console.WriteLine(result);

static string inputStrings(string[] nameStrings)
{
    string result = "";
    for (int i = 0; i < nameStrings.Length; i++)
    {
        result += $"\"{nameStrings[i]}\"";
        if (i < nameStrings.Length - 1)
        {
            result += ", ";
        }
    }
    return result;
}
string[] names = new string[] {"Henrik", "Fredrik", "Kalle"};
string nameStrings = inputStrings(names);
Console.WriteLine(nameStrings);
*/

//Övning 7
/*
//7.Beräkna medelvärde av int-array
//Skriv en funktion som tar en int[] in, och returnerar medelvärdet som en double.

static double AverageValue(int[] values)
{
    double result = 0;
    for (int i = 0; i < values.Length; i++)
    {
        result += values[i];
    }
    return result / values.Length;
}
int[] values = new int[] {1,2,3,4,5,6};
double value = AverageValue(values);
Console.WriteLine(value);
*/

//Övning 8
/*
//8. Siffror till text
//Skriv en funktion som tar ett heltal in, och returnerar en string[] där
//varje element innehåller ordet för varje siffra i talet.

//Exempel:

//NumberToWords(6543);
//Returvärde: { "sex", "fem", "fyra", "tre"}

static string ReturnText(int number)
{
    string[] strings = new string[] { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };
    string Value = number.ToString();
    int index = 0;
    string result = "";
    foreach(var item in Value)
    {
        index = int.Parse(item.ToString());
        for(int j = 0; j < strings.Length; j++)
        {
            if (strings[index] == strings[j])
            {
                result += $"\"{strings[index]}\" ";
            }
        }
    }return result;
}
string result = ReturnText(235423);
Console.WriteLine(result);
*/

//Övning 9
/*
//9.Heltal till text
//Skriv en funktion som tar en ushort som parameter,
//och returnerar en sträng med numret utskrivet i ord.

//Exempel:

//IntegerToText(65430000);
//Returvärde: "six thousand five hundred forty three"

static string IntegerToText(int number)
{
    string[] strings1 = new string[] { "noll", "one", "two", "three", "four", "five", 
        "six", "seven", "eight", "nine" };
    string[] strings2 = new string[] { "noll", "ten", "twenty", "thirty", "fourty", "fifty",
        "sixty", "seventy", "eighty", "ninety" };
    string Value = number.ToString();
    int index = 0;
    int multiTal = Value.Length + 1;
    string result = "";
    for (int i = 0; i < Value.Length; i++)
    {
        foreach (char s in Value)
        {
            index = int.Parse(s.ToString());
            if (multiTal > 10)
            {
                result += $"{strings1[index]}billion and ";
            }
            else if (multiTal > 9)
            {
                result += $"{strings1[index]}hundred";
            }
            else if (multiTal > 8)
            {
                result += $"{strings2[index]}";
            }
            else if (multiTal > 7)
            {
                result += $"{strings1[index]}million and ";
            }
            else if (multiTal > 6)
            {
                result += $"{strings1[index]}hundred";
            }
            else if (multiTal > 5)
            {
                result += $"{strings2[index]}";
            }
            else if (multiTal > 4)
            {
                result += $"{strings1[index]}thousand and ";
            }
            else if (multiTal > 3)
            {
                result += $"{strings1[index]}hundred";
            }
            else if (multiTal > 2)
            {
                result += $"{strings2[index]}";
            }
            else if (multiTal > 1)
            {
                result += $"{strings1[index]}";
            }
            multiTal--;
        }
    }
    return result;
}

string toText = IntegerToText(1234523);
Console.WriteLine(toText);

*/

//Övning 10
/*
//10.Hitta index för alla förekomster av ett givet tecken.
//Skapa funktionen int[] IndexesOf(string text, char c) som söker
//igenom strängen text och returnerar en int[] med index till alla förekomster av c i text.

//Exempel:

//IndexesOf("Hello World!", 'o');
//Returvärde: { 4, 7}

static int[] IndexesOf(string text, char c)
{
    int count = 0;
    foreach (var arraySize in text)
    {
        if (c == arraySize)
        {
            count++;
        }
    }
    int[] array = new int[count];
    int textIndex = 0;
    int arrayIndex = 0;
    foreach (char v in text)
    {
        if (c == v)
        {   
            array[arrayIndex] = textIndex;
            arrayIndex++;
        }
        textIndex++;
    }
    return array;
}

int[] array = IndexesOf("hejx hxj", 'x');
string result = String.Join(", ", array);
Console.WriteLine(result);
*/

//Övning 11
/*
//11.Kasta tärning
//Skriv en funktion ThrowDice() som returnerar ett
//slumpmässigt heltal 1-6. Skriv en annan funktion ThrowMultipleDice(int n) som
//returnerar resultatet av att man slagit n tärningar.

static int ThrowDice()
{
    Random random = new Random();
    int randomDice = random.Next(1, 7);
    return randomDice;
}

static int ThrowMultipleDice(int n)
{
    int result = 0;
    for (int i = 0; i < n; i++)
    {
        result += ThrowDice();
    }
    return result;
}

int oneValue = ThrowDice();
int multiValue =ThrowMultipleDice(5);
Console.WriteLine(oneValue);
Console.WriteLine(multiValue);

*/

//Övning 11 extra
/*
//Extra utmaning: Lägg till en frivillig(optional) int på båda funktionerna,
//där man kan ange antal sidor på tärningen (default 6).

static int ThrowDice(int b = 7)
{
    Random random = new Random();
    int result = 0;
    result = random.Next(1, b);
    return result;
}

static int ThrowMultipleDice(int n, int b = 7)
{
    int diceSides = b;
    int result = 0;
    for (int i = 0; i < n; i++)
    {
        result += ThrowDice(b);
    }
    return result;
}

int oneValue = ThrowDice();
int multiValue = ThrowMultipleDice(5, 20);
Console.WriteLine(oneValue);
Console.WriteLine(multiValue);

//Tips: Kolla exempelkoden för Random.Next() för att få ut slumpmässiga heltal.
*/

//Övning 12
/*
//12. Rita en box
//Skriv en funktion DrawBox(int width, int height).
//När man anropar funktionen ska den skriva ut en rektangel där de yttre tecknen
//består av ‘#’ och de inre av ‘-’.

//Exempel: DrawBox(7, 4);

//#######
//#-----#
//#-----#
//#######

static void DrawBox(int width, int height)
{
    int index = 0;
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++) 
        {
            if (i == 0 || i == height - 1)
            {
                Console.Write("#");
            }
            else if (j != 0 && j != height - 1)
            {
                Console.Write("-");
            }
            else
            {
                Console.Write("#");
            }
        }
        Console.WriteLine("");
        index = 0;
    }
}
DrawBox(10, 10);
*/

//Övning 12 - Extrauppgift
/*
//Extrauppgift: Uppdatera funktionen och lägg till parametrar
//left och top(för positionen på översta vänstra hörnet av boxen.
//Skriv en loop som printar ut rektanglar med random storlek och position på skärmen.

static void DrawBox(int width, int height, int left, int top)
{
    int lessThanWidth = width;

    Console.SetCursorPosition(left, top);
    for (int i = 1; i <= height; i++)
    {
        for (int j = 0; j <= width; j++)
        {
            Console.Write("#");
        }
        width--;
        Console.WriteLine("");
        Console.SetCursorPosition(left + i, top - i);
    }
}

Random random = new Random();
int width = random.Next(10, 25);
int left = random.Next(5, 40);
int top = random.Next(15, 25);
DrawBox(width, 5, left, top);
DrawBox(width, 5, left, top);
*/

//Övning 13
/*
//13. Flytta runt ett @ med piltangenterna.
//Låt oss skriva början till ett enkelt spel:

//Använd DrawBox-funktionen i föregående uppgift för att rita en box på skärmen.
//Placera sedan ett @ i mitten av boxen. Om man använder piltangenterna ska man kunna
//flytta runt @. När den kommer till kanten av boxen så ska den inte kunna gå längre åt det hållet.

//Tips: För att flytta @ behöver du skriva ‘-’ på dess tidigare position och ‘@’ på den nya positionen.
//Spara bredd och höjd på boxen så du vet när den ska stanna.

//Tips: Kolla upp Console.ReadKey(); och Console.KeyAvailable;

static void DrawBox(int width, int height)
{
    int maxWidth = width / 2;
    int userWidth = width / 2;
    int userHeight = height / 2;
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write("#");
        }
        Console.WriteLine("");
    }
    while(Console.KeyAvailable == false)
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        Console.SetCursorPosition(userWidth, userHeight); //10        //10     //
        if      (keyInfo.Key == ConsoleKey.LeftArrow && userWidth != userWidth / 2)
        {
            Console.Write("#");
            userWidth--;
            Console.SetCursorPosition(userWidth, userHeight);
            Console.Write("@");
        }
        else if (keyInfo.Key == ConsoleKey.RightArrow && userWidth != width-1)
        {
            Console.Write("#");
            userWidth++;
            Console.SetCursorPosition(userWidth, userHeight);
            Console.Write("@");
        }
        else if (keyInfo.Key == ConsoleKey.UpArrow && userHeight != userHeight / 2)
        {
            Console.Write("#");
            userHeight--;
            Console.SetCursorPosition(userWidth, userHeight);
            Console.Write("@");
        }
        else if (keyInfo.Key == ConsoleKey.DownArrow && userHeight != height-1)
        {
            Console.Write("#");
            userHeight++;
            Console.SetCursorPosition(userWidth, userHeight);
            Console.Write("@");
        }
    }
}
DrawBox(20, 15);
*/

//Övning 14

//14.Masken
//Skriv om DrawBox() så den istället returnerar en 2D-array av char med tecknen
//som den tidigare skrev ut på displayen. Man ska också kunna mata in en
//tredje parameter för antal slumpade ‘#’.
//Om man anger t.ex 5 så ska 5 stycken extra ‘#’ slumpas ut på random ställen inne i boxen.

//Skriv sedan en annan funktion som tar och ritar ut arrayen på skärmen.
//Fixa så man kan flytta runt @ med piltangenterna.
//Jämför positionen mot arrayen och gör så man inte kan gå på någon '#'.
/*
static char[] DrawBox(int width, int height, int randomObjekt)
{
    int maxWidth = width / 2;
    int userWidth = width / 2;
    int userHeight = height / 2;
    char[] result = new char[width * height];
    for (int i = 0; i < height * width; i++)
    {
        for (int j = 0; j < width * height; j++)
        {
            result[j] = 'x';
        }
        result[i] = '\n';
    }
    while (Console.KeyAvailable == false)
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        Console.SetCursorPosition(userWidth, userHeight); //10        //10     //
        if (keyInfo.Key == ConsoleKey.LeftArrow && userWidth != userWidth / 2)
        {
            Console.Write("#");
            userWidth--;
            Console.SetCursorPosition(userWidth, userHeight);
            Console.Write("@");
        }
        else if (keyInfo.Key == ConsoleKey.RightArrow && userWidth != width - 1)
        {
            Console.Write("#");
            userWidth++;
            Console.SetCursorPosition(userWidth, userHeight);
            Console.Write("@");
        }
        else if (keyInfo.Key == ConsoleKey.UpArrow && userHeight != userHeight / 2)
        {
            Console.Write("#");
            userHeight--;
            Console.SetCursorPosition(userWidth, userHeight);
            Console.Write("@");
        }
        else if (keyInfo.Key == ConsoleKey.DownArrow && userHeight != height - 1)
        {
            Console.Write("#");
            userHeight++;
            Console.SetCursorPosition(userWidth, userHeight);
            Console.Write("@");
        }
    }
    return result;
}
char[] toArray = DrawBox(5, 5, 5);

static void PrintBox(char[] arrayBox)
{
    for (int i = 0; i < arrayBox.Length; i++)
    {
        Console.Write(arrayBox);
    }
}

PrintBox(toArray);

//Test char.GetNumericValue(c) -> int

string[] isArray = new string[] {"asads", "sasafasf", "dfgdfsd", "fwewfwef" };
string rnStrings = "0123";
foreach (char c in rnStrings)
{
    int b = (int)char.GetNumericValue(c);
    Console.WriteLine(isArray[b]);

    Console.WriteLine(isArray[(int)char.GetNumericValue(c)]);
}

*/


//Extra utmaning: Gör en "orm" av '@'.
//När man flyttar positionen på @ så följer (t.ex) 5 andra @ efter i samma spår som man förflyttat sig.

//Extra utmaning 2: I det klassiska spelet "masken" (snake) förflyttar sig en mask i jämna
//tidsintervall i den riktning spelaren senast angav med piltangenterna.
//Någonstans på banan finns ett äpple masken ska äta.
//Det gäller för spelaren att ta sig dit utan att krocka med något hinder, eller sin egen svans.
//När man tar äpplet blir masken längre och ett nytt äpple dyker upp på slumpvis vald plats på banan.

//Implementera din egen version av spelet. Försök dela in koden i lämpliga funktioner.

//Förslag: När du fått en första version av spelet att fungera,
//lägg till flera banor genom att hårdkoda in olika banlayout i olika 2D-arrayer.
//När man tagit ett visst antal äpplen på en bana så kommer man vidare till nästa.



///Project Euler Challenges



//Övning 1 - Multiples of 3 or 5



//Övning 8 - Largest Product in a series

string abc = "" +
"73167176531330624919225119674426574742355349194934" +
"96983520312774506326239578318016984801869478851843" +
"85861560789112949495459501737958331952853208805511" +
"12540698747158523863050715693290963295227443043557" +
"66896648950445244523161731856403098711121722383113" +
"62229893423380308135336276614282806444486645238749" +
"30358907296290491560440772390713810515859307960866" +
"70172427121883998797908792274921901699720888093776" +
"65727333001053367881220235421809751254540594752243" +
"52584907711670556013604839586446706324415722155397" +
"53697817977846174064955149290862569321978468622482" +
"83972241375657056057490261407972968652414535100474" +
"82166370484403199890008895243450658541227588666881" +
"16427171479924442928230863465674813919123162824586" +
"17866458359124566529476545682848912883142607690042" +
"24219022671055626321111109370544217506941658960408" +
"07198403850962455444362981230987879927244284909188" +
"84580156166097919133875499200524063689912560717606" +
"05886116467109405077541002256983155200055935729725" +
"71636269561882670428252483600823257530420752963450";
int arrayIndex = 0;
int loopIndex = 0;
int stringIndex = 0;
int intNum = 0;
long result1 = 1;
long result2 = 1;
long totalResult = 1;
string tempStrings = "";
string stringResult = "";

foreach (char c in abc)
{
    arrayIndex++;
}
int[] numArray = new int[arrayIndex];
arrayIndex = 0;
foreach (char c in abc)
{
    intNum = int.Parse(c.ToString());
    numArray[arrayIndex] = intNum;
    arrayIndex++;
}

for (int i = 1; loopIndex < abc.Length; i++)
{
    if (numArray[loopIndex] != 0)
    {
        result1 = result1 * numArray[loopIndex];
        tempStrings += numArray[loopIndex].ToString() + ",";
        loopIndex++;
    }
    else
    {
        tempStrings += numArray[loopIndex].ToString() + ",";
        loopIndex++;
    }

    if (i == 13)
    {
        i = 0;
        result2 = result1;
        if (totalResult < result2)
        {
            stringResult = tempStrings;
            totalResult = result2;
            Console.WriteLine(totalResult);
            Console.WriteLine(stringResult);
        }
        tempStrings = "";
        result1 = 1;
        stringIndex++;
        loopIndex = stringIndex;
    }
}
Console.WriteLine("");
Console.WriteLine(totalResult);
Console.WriteLine(stringResult);