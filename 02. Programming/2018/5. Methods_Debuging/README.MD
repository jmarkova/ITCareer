# Методи и Дебъгване
## Методи
### 1. Празна касова бележка
Създайте метод, който отпечатва празна касова бележка. Методът трябва да извиква три  други метода: един за отпечатване на хедъра, един за основната част на бележката и един за футъра. 

Пример:
```
CASH RECEIPT                  
------------------------------
Charged to____________________
Received by___________________
------------------------------
© SoftUni                     
```

Подсказки:
- Първо създайте метод без параметри за отпечатването на хедъра. Дефиницията му започва със static void. Дайте му смислено име, например "PrintReceiptHeader" и напишете кода, който ще изпълнява този метод
- Направете същото и за същинската част и футъра на касовата бележка
- Създайте метод, който ще извиква тези три метода в правилния ред. И на него дайте смислено и описателно име, примерно "PrintReceipt" и напишете неговия програмен код
- За отпечатване на "©" използвайте Уникод-а "\u00A9"
- Извиквайте методът PrintReceipt от main метода
 
### 2. Знак на цяло число
Създайте метод, отпечатващ знака на цяло число n.

Пример:

| Вход | Изход                      |
| ---- | -------------------------- |
| 2    | The number 2 is positive.  |
| -5   | The number -5 is negative. |
| 0    | The number 0 is zero.      |

Подсказки:
- Създайте метод с описателно име като "PrintSign". Методът трябва да получава един параметър  от тип int
- Изградете и тялото на метода, като обработите трите случая
- Ако числото е по-голямо от нула
- Ако числото е по-малко от нула
- И ако числото е равно на нула
- Извикайте новосъздадения метод от метода main
 
### 3. Отпечатване на триъгълник
Създайте метод за отпечатване на триъгълници.

Примери:

| Вход | Изход   |
| ---- | ------- |
| 3    | 1       |
|      | 1 2     |
|      | 1 2 3   |
|      | 1 2     |
|      | 1       |
| 4    | 1       |
|      | 1 2     |
|      | 1 2 3   |
|      | 1 2 3 4 |
|      | 1 2 3   |
|      | 1 2     |
|      | 1       |

Подсказки:
- След като прочетете входните данни
- Започнете със създаването на метод за отпечатване на един ред от дадено число start до дадено число end. Изберете му смислено име, което описва неговото предназначение
- Помислете как може да го използвате, за да намерите решение на задачата
- След като анализирате заданието, би трябвало да стигнете до извода, че ви трябват два цикъла
- В първия цикъл може да отпечатате горната половина от триъгълника без средния ред
- След това отпечатваме средния ред
- Накрая отпечатваме и останалото от триъгълника
 
### 4. Изчертаване на запълнен квадрат
Изчертайте на конзолата запълнен квадрат с дължина на страната n.

Пример:

| Вход | Изход    |
| ---- | -------- |
| 4    | -------- |
|      | -\/\/\/- |
|      | -\/\/\/- |
|      | -------- |

Подсказки:
- Прочетете входните данни
- Създайте метод, който ще печати най-горния и най-долния ред (тъй като те са еднакви). Не забравяйте да му дадете описателно име и като параметър да му подадете някаква дължина
- Вместо цикъл може да използвате командата "new string", която създава нов текст, съставен от символ, повторен определен брой пъти
- Сега създайте метод, който ще отпечатва средните редове. Е, ясно е, ще го наречете предполагам "PrintMiddleRow"
- Използвайте методите, които току-що създадохте, за изчертаването на квадрата
 
### 5. Конвертор за температури
Създайте метод, който конвертира температура от Фаренхайт в Целзий. Форматирайте резултата до втория десетичен знак.
Използвайте формулата: (fahrenheit - 32) * 5 / 9.

Примери:

| Вход | Изход  |
| ---- | ------ |
| 95   | 35.00  |
| 33.8 | 1.00   |
| -40  | -40.00 |

Подсказки:
- Прочетете входните данни
- Създайте метод, който връща стойност от тип double
- Извикайте метода в main и запишете върнатата стойност в нова променлива
 
### 6. Пресмятане на лице на триъгълник 
Създайте метод, който изчислява и връща лицето на триъгълник по дадени основа и височина.

Пример:

| Вход | Изход |
| ---- | ----- |
| 3    | 6     |
| 4    |       |

Подсказки:
- Първо прочетете входните данни
- После създайте метод, но този път вместо да пишете "static void" преди името му, напишете "static double", така че да го накараме да върне стойност от тип double
- Извикайте метода в main и съхранете върната стойност в нова променлива
 
### 7. Повдигане на степен
Създайте метод, който пресмята и връща стойността на число, повдигнато на указана степен.

Примери:

| Вход | Изход |
| ---- | ----- |
| 2    | 256   |
| 8    |       |
| 3    | 81    |
| 4    |       |

Подсказки:
- Както обикновено, прочетете входните данни
- Създайте метод, който ще има два параметъра - числото и степента, и ще връща резултат от тип double
- Отпечатайте резултата

### 8. По-голямата от две стойности
Имате подадени като входни данни две стойности от един и същи тип. Стойностите може да са от тип int, char или string. Създайте метод GetMax() който връща по-голямата от двете стойности. 

Примери:

| Вход  | Изход |
| ----- | ----- |
| 2     |       |
| 16    | 16    |
| a     |       |
| z     | z     |
| Ivan  |       |
| Todor | Todor |

Подсказки:
- За тази задача ще трябва да създадете три метода с едно и също име и с различни сигнатури
- Създайте метод, който ще сравнява цели числа
- Създайте втори метод със същото име, който ще сравнява символи. Следвайте логиката на предния метод
- И накрая създайте метод за сравняване на низове. Той ще е малко по-различен, тъй като низовете не може да бъдат сравнявани с операторите > и < 
- Трябва да използвате метода "CompareTo()", който връща целочислена стойност (положителна ако сравняваният обект е по-голям, отрицателна, ако е по-малък и нула, ако двата са равни)
- Последната стъпка е да прочетете входните данни, да използвате променливи от подходящ тип и да извикате GetMax() от вашия Main():
 
## Дебъгване
### 9. Умножаване на четни по нечетни
Създайте програма, която прочита цяло число и умножава сумата на всичките му нечетни цифри по сумата на всичките му четни цифри.

Примери:

| Вход   | Изход | Коментари                                                                                                                                           |
| ------ | ----- | --------------------------------------------------------------------------------------------------------------------------------------------------- |
| 12345  | 54    | 12345 има 2 четни цифри (2 и 4). Сумата им е 6. Също така числото има 3 нечетни цифри (1, 3 и 5). Сумата им е 9. Умножаваме 6 по 9 и получаваме 54. |
| -12345 | 54    |                                                                                                                                                     |

Подсказки:
- Създайте метод с име, описващо предназначението му (например GetMultipleOfEvensAndOdds). Той трябва да има един целочислен параметър и целочислена връщана стойност. Този метод ще извиква два други метода
- Създайте два други метода, всеки от които ще сумира четните или нечетните цифри
- Опишете логиката за сумиране на четни цифри
- Направете същото за метода, който ще сумира нечетните цифри
- Като тествате решението, може да забележите, че то не работи за отрицателни числа. Проследете изпълнението на програмата стъпка по стъпка и поправете грешката (идейка: може да използвате Math.Abs())

### 10. Почивни дни между две дати
Имате задачата да откриете и поправите грешките във вече написан програмен код, като използвате дебъгера на Visual Studio. За целта трябва да проследите изпълнението на програмата, за да откриете тези редове от кода ѝ, които пораждат неправилен или неочакван резултат.

Разполагате с програма (т.е. със съществуващ програмен код) който се опитва да преброи неработните дни между две дати подадени във формат ден.месец.година (например между 1.05.2015 и 15.05.2015 има 5 неработни дни - съботи и недели).

Примери:

| Вход       | Изход | Коментари                                                     |
| ---------- | ----- | ------------------------------------------------------------- |
| 1.05.2016  | 5     | Има 5 неработни дни (съботи и недели) в този период:          |
| 15.05.2016 |       | 1-May-2016, 7-May-2016, 8-May-2016, 14-May-2016, 15-May-2016  |
| 1.5.2016   | 1     | Само 1 неработен ден: 1.05.2016 (неделя)                      |
| 2.5.2016   |       |                                                               |
| 15.5.2020  | 0     | Втората дата е преди първата. Няма дати в този диапазон.      |
| 10.5.2020  |       |                                                               |
| 22.2.2020  | 4     | По две съботи и недели:                                       |
| 1.3.2020   |       | 22.02.2020 и 23.02.2020, 29.02.2020 и 1.03.2020               |

Неработещия програмен код HolidaysBetweenTwoDates.cs изглежда така:
```
using System;
using System.Globalization;
class HolidaysBetweenTwoDates
{
    static void Main()
    {
        var startDate = DateTime.ParseExact(Console.ReadLine(), "dd.m.yyyy", CultureInfo.InvariantCulture);
        var endDate = DateTime.ParseExact(Console.ReadLine(), "dd.m.yyyy", CultureInfo.InvariantCulture);
        var holidaysCount = 0;
        for (var date = startDate; date <= endDate; date.AddDays(1))
        if (date.DayOfWeek == DayOfWeek.Saturday && date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
        Console.WriteLine(holidaysCount);
    }
}
```
Подсказкa:
- Има 4 грешки в кода. Трябва да използвате дебъгера за да ги откриете и поправите. След като сте готови, изпратете поправеният от вас код в платформата.

### 11. Price Change Alert
Имате за задача да преработите готов код, който работи без грешки, но не е форматиран както трябва. 
Предоставената ви програма следи цените на стоки и дава информация за значимостта на всяка промяна в цената. 
Според това, доколко е съществена, има четири типа промени: без промяна (цената е същата като предишната), малка (разлика под прага на значимост), цената расте и цената намалява. 

Вход:
- На първия ред получавате N - броят на цените
- На втория ред получавате прага на значимост
- На следващите N реда, получавате цените

Изход:
- Не отпечатвате нищо за първата цена
- Ако няма разлика от предишната цена, съобщението е: "NO CHANGE: {текуща цена}"
- При малка разлика: "MINOR CHANGE: {предишна цена} to {текуща цена} ({разлика}%)"
- При голяма разлика: "PRICE UP: {предишна цена} to {текуща цена} ({разлика}%)" or "PRICE DOWN: {предишна цена} to {текуща цена} ({разлика}%)"

Процентите трябва да са закръглени до втория знак след десетичната точка.

Примери:

| Вход | Изход                          |
| ---- | ------------------------------ |
| 3    | PRICE UP: 10 to 11 (10.00%)    |
| 0.1  | MINOR CHANGE: 11 to 12 (9.09%) |
| 10   |                                |
| 11   |                                |
| 12   |                                |
| 3    | NO CHANGE: 10                  |
| 0.1  | PRICE UP: 10 to 12 (20.00%)    |
| 10   |                                |
| 10   |                                |
| 12   |                                |
