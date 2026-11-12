# Казанбаева Элена ЛА-1 Лабораторная №4

## Задание 1

### Текст задачи
Составить программу, которая удаляет из списка L все элементы с указанным значением

### Алгоритм решения
Список заполняется пользователем с клавиатуры с проверкой ввода. Для удаления элементов используется обход списка с конца. Это позволяет избежать смещения индексов и обеспечивает оптимальную сложность O(n). Запрещенные конструкции (LINQ, лямбда-выражения) не используются.

### Тестирование
![](https://sun9-68.vkuserphoto.ru/s/v1/ig2/fr3vb3c6Y6b2tYjAearsDNK786o1uKKIsyTjOLjl7t66sR4YawaqKatI1Rh1ArJtNKODIzPfwaApzy9faluZAH92.jpg?quality=95&as=32x16,48x24,72x36,108x54,160x80,240x119,360x179,480x239,540x269,577x287&from=bu&u=CFuBvvumgPJkW0Fev0EPW9vYC9u0_4SDWKPPCa_SOM0&cs=577x0)
![](https://sun9-71.vkuserphoto.ru/s/v1/ig2/ae7r9VHIFn_Wqp39dBW6X1dv3JbrmwmRhkae67oM7jje1-z7Ef2PXc-nmRqNqqfTU5V28fTOXQW3VxfLZhILjra8.jpg?quality=95&as=32x34,48x51,72x76,108x114,160x169,240x254,360x381,480x508,540x571,573x606&from=bu&u=Bwq3HdEQzkMwzJaKLdw6WgULriTnbkD6fHvTlQnTXeM&cs=573x0)

## Задание 2

### Текст задачи
 В списке L переставить в обратном порядке все элементы между первым и последним
вхождениями элемента E, если E входит в L не менее двух раз.

### Алгоритм решения
Сначала выполняется поиск первого вхождения элемента E (проходом слева направо) и последнего вхождения (проходом справа налево). Если найдено менее двух вхождений, выводится соответствующее сообщение. Если вхождений достаточно, элементы между найденными индексами переставляются с помощью двух указателей. Время работы O(n).

### Тестирование
![](https://sun9-6.vkuserphoto.ru/s/v1/ig2/hkcgk35omtshkEfy3eFJbl5OE99AZoRQ6Gtm25UXsB0vjwr6LcSizo6H3m68UBRghbX5Lqly5bMUTP6d4Y7ZkDXI.jpg?quality=95&as=32x14,48x21,72x31,108x47,160x69,240x104,360x156,480x208,540x234,640x277,720x312,758x328&from=bu&u=VuQzSu8obi7WTuYAeBGHQwexQbe6OIfG5eLpCikm2M0&cs=758x0)
![](https://sun9-64.vkuserphoto.ru/s/v1/ig2/VYZE1QCCDRNj8N_iCnRIoaQHptovDrEtXPnadBf0sIVG3xq-ommaNnHdpWgk-Mv96hvB6bccPY_tCVzeXUZ2gFYB.jpg?quality=95&as=32x21,48x32,72x48,108x72,160x106,240x159,360x239,480x318,540x358,640x424,720x478,772x512&from=bu&u=zjroJRySAUGjj2s3RU0NwtJ2QrSmzW6IHH__wkL1hA0&cs=772x0)

## Задание 3

### Текст задачи
Есть перечень фильмов. Определить для каждого фильма, какие из них посмотрели все n
зрителей, какие — некоторые из зрителей, и какие — никто из зрителей.

### Алгоритм решения
Пользователь вводит список фильмов и информацию о просмотрах каждым зрителем. Для каждого фильма ведется счетчик просмотров. Чтобы избежать дублирования (если один зритель посмотрел фильм несколько раз), используется булев массив `watchedByViewer` для каждого зрителя. Фильмы распределяются по трем категориям в зависимости от итогового счетчика.

### Тестирование
![](https://sun9-62.vkuserphoto.ru/s/v1/ig2/bjzMNnDS14K0AZtAHPFMdI_B0IR965x6kq1-yUPjuiViFA8p9BHldxbCR58osvgfjxj-6Aq2uu5Tja99NPEPULRR.jpg?quality=95&as=32x30,48x45,72x67,108x101,160x149,240x224,360x335,480x447,527x491&from=bu&u=7749YMqh77q6hOlodCxTLPU5fLziDACW7R4oAmo92dA&cs=527x0)
![](https://sun9-7.vkuserphoto.ru/s/v1/ig2/JTh3pMPlvjbmEoQ-3ueqNkrRH77KxE1qYjtI1mahC9H9C8SqBmXDjfA6kA0AidHk_9TwKefZ9Mux5fgMg3ZEFVrr.jpg?quality=95&as=32x43,48x64,72x96,108x144,160x214,240x321,360x481,480x641,540x721,563x752&from=bu&u=7ZtyB2iulZ56jmoDllE0_qlqK9eeVvPahHhcD1kkwB8&cs=563x0)

## Задание 4

### Текст задачи
Файл содержит текст на русском языке. Напечатать в алфавитном порядке все звонкие
согласные буквы, которые входят более чем в одно слово

### Алгоритм решения
В качестве множества звонких согласных используется строка `"бвгджзйлмнр"`, буквы в которой уже отсортированы по алфавиту. Текст разбивается на слова. Для каждого слова выявляются уникальные звонкие согласные (с помощью булева массива) и увеличивается их общий счетчик. В конце выводятся буквы, счетчик которых больше 1. Обработка ошибок чтения файла вынесена в `InputHelper`.

### Тестирование
![](https://sun9-50.vkuserphoto.ru/s/v1/ig2/_7Q3_udFYi6IzICS_rUN6zZC4nh9HxaiMAHr_eH2zO5KM8BMInHQ70JwJTpW44VF76LTHDLr7pHx6LIpWx8LhzxX.jpg?quality=95&as=32x5,48x8,72x12,108x18,160x26,240x40,360x59,480x79,540x89,640x105,686x113&from=bu&u=U38gZVeZg02A0gPAJ2fjPnq-cZ2TEahaguKwDNk-74w&cs=686x0)
![](https://sun9-56.vkuserphoto.ru/s/v1/ig2/nSUUtQRTm_ct7eaUxA9P9j-z0prwc1AOSBNenrhAZjyL7fwjfgrQVIF9d11R7eg-SsyMm3nGP70irbdktX9CvjHM.jpg?quality=95&as=32x11,48x16,72x24,108x36,160x53,240x80,360x120,480x160,540x180,640x213,720x240,802x267&from=bu&u=Hglv81f94IsaVXFHttLKC38udlr3uBgI3hjm45viu5s&cs=802x0)
![](https://sun9-8.vkuserphoto.ru/s/v1/ig2/gMw_Rmz43VEnoV4NZjPLkfs-oQh6E9K0nTua7WfBQniktUOpROLINmK_gDnD7gnEq-9DQ8ECK523l67bOOMzeDeP.jpg?quality=95&as=32x4,48x6,72x10,108x14,160x21,240x32,360x48,480x64,540x72,640x85,720x95,792x105&from=bu&u=I48xEsUyhrHH_hFO3j5PdnNl-oyCgBRexsFicBzV79A&cs=792x0)
![](https://sun9-50.vkuserphoto.ru/s/v1/ig2/eSvbhs_fqwKdQT9Lexw0un4dDFI3bhvBP61U4yeer3drnFqWV4xR9Q_nJL0eDFAE4fd-E_x0x7j-DyF5f6d4PCC6.jpg?quality=95&as=32x9,48x14,72x21,108x32,160x47,240x71,312x92&from=bu&u=OjNUJY_FzEXpbsLbN5PnZ_Oe3KYkN_Pd5bFWCgP1CG4&cs=312x0)
![](https://sun9-15.vkuserphoto.ru/s/v1/ig2/9mdKnUnQi3G3w6TcxO7ocFlcY2UgYc2dVCfqijkBBgXWD0NgjNWS1Wm2V4l3M2_fju7lfEOKxhOsrWxilKIbzIol.jpg?quality=95&as=32x7,48x11,72x16,108x24,158x35&from=bu&u=KDx2yiKjyQdlfjr2yw2UUI59dFNjQo_OIEeAAkbcb1o&cs=158x0)

## Задание 5

### Текст задачи
На вход программе подаются сведения о телефонах всех сотрудников некоторого учреждения. В
первой строке сообщается количество сотрудников N, каждая из следующих N строк имеет
следующий формат:
<Фамилия><Инициалы><телефон>
где <Фамилия> – строка, состоящая не более чем из 20 символов, <Инициалы> - строка, состоящая
не более чем из 4-х символов (буква, точка, буква, точка), <телефон> – семизначный номер, 3-я и
4, я, а также 5-я и 6-я цифры которого разделены символом «–». <Фамилия> и <Инициалы>, а
также <Инициалы> и <телефон> разделены одним пробелом. Пример входной строки:
Иванов П.С. 555-66-77
Сотрудники одного подразделения имеют один и тот же номер телефона. Номера телефонов в
учреждении отличаются только двумя последними цифрами. Требуется написать эффективную
программу, которая будет выводить на экран информацию, сколько в среднем сотрудников
работает в одном подразделении данного учреждения.

### Алгоритм решения
Исходные данные хранятся в файле. Заполнение файла организовано отдельным методом `FillPhonesFile` с проверкой формата каждой строки. При чтении файла используется массив `bool[100]` для учета уникальных подразделений (по двум последним цифрам телефона). Это позволяет достичь сложности O(n) по времени и O(1) по дополнительной памяти. Вычисляется среднее путем деления общего числа сотрудников на количество уникальных подразделений.

### Тестирование
![](https://sun9-9.vkuserphoto.ru/s/v1/ig2/0WjHJg0_7O_jdB0aLexNcNya9JiZr1vUbRzeSo1cNeD5-uYeFcl6Oi-ntdia_SJi-TOzqB2sli3zg5rrmFmQNx2X.jpg?quality=95&as=32x11,48x16,72x24,108x36,160x54,240x81,360x121,480x162,540x182,640x215,720x242,722x243&from=bu&u=OLwok0qdk3OJSUp_4AftYBzmNBdBpifUlHhMyIAy3QU&cs=722x0)
![](https://sun9-69.vkuserphoto.ru/s/v1/ig2/P6B15VdhO1eAx43Sapp-Zn9qCNFg_yGuO3aBYVsyyftFwFvgQ4a0gBRAseKSsmiw1lzHmWMgJteupO2cLgp1uQzF.jpg?quality=95&as=32x21,48x32,72x47,108x71,160x105,240x158,360x237,480x316,540x356,640x422,720x475,913x602&from=bu&u=6F6Dyx9uszWmyjpovcPnjDONVyDUidNHqvfGUfa0XUw&cs=913x0)

## Задание 6

### Текст задачи
Определить, попадает ли заданное число
в отрезок. Результат должен быть типа
bool.

### Алгоритм решения
Класс содержит приватные поля `_x` и `_y` (координаты начала и конца). Свойства `X` и `Y` реализованы без использования автосвойств. Созданы три конструктора: по умолчанию, с параметрами и копирования. Переопределен метод `ToString()`. Метод `Contains()` возвращает `true`, если число попадает в отрезок (с учетом того, что `x` может быть больше `y`).

### Тестирование
![](https://sun9-70.vkuserphoto.ru/s/v1/ig2/AvBYSSoPM7oq6lxdPV4fKNujuFWmzQ4hCjKd2j8Pzr9GTmUbiWhIbaTOZ2Lbt1YzOhO7B9s38xiMo-cbSucfG8vI.jpg?quality=95&as=32x24,48x36,72x54,108x81,160x121,240x181,360x272,407x307&from=bu&u=zoshGQ4JhUs-9rXNuugku6O4Y0_ebNfGDD7DQSYLaSE&cs=407x0)
![](https://sun9-2.vkuserphoto.ru/s/v1/ig2/-MELXjC7FqU7S5fsIjlpAapWayojsZ3W1ch4BgbUzlIXb5_cFhZdLceXkUKNX_LNb2FjGenu6HsyQkTJlth8XqXJ.jpg?quality=95&as=32x33,48x50,72x75,108x113,160x167,240x251,360x376,407x425&from=bu&u=DL61JJocAeu3mpx__OhUhnT78ghQmXgcT0SkocGbiF0&cs=407x0)

## Задание 7

### Текст задачи
Унарные операции:
! - вычислить длину отрезка, результат должен быть типа double;
++ увеличить координаты границ отрезка на 1.
Операции приведения типа:
int (явная) – результатом является целая часть координаты х;
double (неявная) – результатом является координата y.
Бинарные операции:
+int d, целое число (лево- и правосторонняя операция, координаты границ
увеличиваются на число d);
< LineSegment, целое число – результат равен true, если целое число
попадает в заданный отрезок и false–в противном случае.

### Алгоритм решения
Все операторы перегружены в соответствии с заданием. Оператор `!` возвращает `Math.Abs(_y - _x)`. Оператор `++` мутирует текущий объект. Оператор `+` возвращает новый объект. Так как перегружен оператор `<`, обязательно потребовалась перегрузка парного оператора `>` для избежания ошибки компиляции (реализован как отрицание `<`).

### Тестирование
![](https://sun9-83.vkuserphoto.ru/s/v1/ig2/x9AjOmw2zBJ_wDWxpp-qCyh4G2iyuWiA8PK7oD6219EmjiFgatxRjwZ-DYk7BOfvRbV2OqV5Vuy1Eh4hL71MDo2Q.jpg?quality=95&as=32x30,48x45,72x68,108x102,160x152,240x227,360x341,457x433&from=bu&u=6zL_xMYjWGSMcKFHi9_177SaocxfSkgPg8qPX8Mxo4w&cs=457x0)
![](https://sun9-63.vkuserphoto.ru/s/v1/ig2/bAMTXvcgdriginlplmOMVNX45eKMCpAxSdXWQa-VPla8OUvvYS-ASHQNeYDLvk5ZcuDi1Ywe8xBtoHi0oLNQYw6u.jpg?quality=95&as=32x35,48x53,72x79,108x118,160x175,240x263,360x394,480x526,495x542&from=bu&u=lSz7Ze3kUOwk7U7TGcT78_GihCNdZU8JGGkyerIKSPg&cs=495x0)
