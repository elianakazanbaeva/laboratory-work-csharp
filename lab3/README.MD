# Казанбаева Элена ЛА-1 Лабораторная №3

# Задание 1

### Текст задачи
Первый массив, размерностью n х m, заполняется данными, вводимыми с клавиатуры, так что
заполнение ведется по строкам от первых элементов строки к последним.
Второй массив, размерностью n х n, заполняется так: элементы, лежащие ниже главной
диагонали, являются случайными числами из интервала [-70; 150], а лежащие на главной
диагонали и выше, являются случайными числами из интервала [17; 170].
Третий массив, размерностью n х n, заполняется для произвольного n так же, как для n=5

### Алгоритм решения
Создан класс `Matrix` с приватным полем `_data`. Реализованы три конструктора для каждого типа заполнения. Для третьего массива написан вспомогательный метод `IsPrime` (проверка на простое число) и алгоритм заполнения ромба от краев к центру. Вывод матрицы реализован в переопределенном методе `ToString()`.

### Тестирование
![](https://sun9-49.vkuserphoto.ru/s/v1/ig2/HXWBsWkqQVL9nwhY2QMwO2fnM8eVEXAMhVacfirlwZNuulK6sXivKckKJo2i_PVt4zdDUZ31gDOFg_u4hGop0kly.jpg?quality=95&as=32x104,48x155,72x233,108x350,160x518,240x777,256x829&from=bu&cs=256x0)

# Задание 2

### Текст задачи
В двумерном массиве n х n выберите такую диагональ, параллельную главной, сума элементов которой была бы максимальной.

### Алгоритм решения
В класс `Matrix` добавлен метод `FindMaxDiagonalSum`. С помощью цикла перебираются все возможные смещения диагоналей относительно главной (от `-(n-1)` до `n-1`). Для каждой диагонали считается сумма, и если она больше максимальной найденной ранее, она запоминается.

### Тестирование
![](https://sun9-71.vkuserphoto.ru/s/v1/ig2/5BXu3tfuPr6S3rvMzEpg5sdKMU4H2DZx_jEK6KboL0gT-2fie2tDjnDJvw7qO9Wciegxtg4ejBIGT71UuO4JDfKm.jpg?quality=95&as=32x57,48x85,72x128,108x192,160x285,240x428,311x554&from=bu&cs=311x0)
![](https://sun9-6.vkuserphoto.ru/s/v1/ig2/H-nD3qWJhcGY1pThFq9_9DV8DgUOZQ-fRtPF3Z6g0IF3o7vDAaNiCP7ZUsziQn97xj0yLCkav4JMrvae9p1dvHk5.jpg?quality=95&as=32x51,48x76,72x115,108x172,160x255,240x382,317x505&from=bu&cs=317x0)
![](https://sun9-85.vkuserphoto.ru/s/v1/ig2/64bF5MD_LJE6qzyKOlBdcRGEY7qfdg0-SDO51uzE7IsLO8J5gtRjYaMsVZggFiOeGpBeAE46p7zYPMhtZwG8HaOT.jpg?quality=95&as=32x47,48x70,72x105,108x158,160x234,240x350,311x454&from=bu&cs=311x0)

# Задание 3

### Текст задачи
Посчитать значение матричного выражения A^T * B - C^T

### Алгоритм решения
В класс `Matrix` добавлены методы `Transpose` (транспонирование матрицы), `Multiply` (умножение матриц) и `Subtract` (вычитание матриц). В методе `Main` последовательно вызываются эти методы для получения результата.

### Тестирование
![](https://sun9-69.vkuserphoto.ru/s/v1/ig2/ny34vCWUY1DcuC-_51JFJ-X8V69mdBS5M1I2ibhRqp25yIholidpfOKN4co5T9quzcM9Cv2KKyrETTBzwebGZ85C.jpg?quality=95&as=32x97,48x146,72x218,108x328,160x485,240x728,276x837&from=bu&cs=276x0)
![](https://sun9-81.vkuserphoto.ru/s/v1/ig2/w9ERTqvvSRiYvsJ7wx1TM5cuj_VtVxx175gMr7cSn3jcEXarfCgO_I718UJOcQ0KiyYfSdXWH6LyfLpaUJKI6sPf.jpg?quality=95&as=32x21,48x32,72x48,108x71,160x106,240x158,360x238,480x317,515x340&from=bu&cs=515x0)
![](https://sun9-61.vkuserphoto.ru/s/v1/ig2/lJXcGUxC739HuG9yqdYQO-WweUnG6a5IXAgQ9uZmitq4qPT1on6DT8Cncd4THnk00odr6Qmq5rytv3ZRDHPc9brJ.jpg?quality=95&as=32x71,48x107,72x161,108x241,160x357,240x535,251x560&from=bu&cs=251x0)
![](https://sun9-39.vkuserphoto.ru/s/v1/ig2/MHddGp3-hAIOnuyxOzJFcPn8D-d8Db78zXYmN19mZxGaiUohGgPzS9MNNJ7ijdzMgkGk_rDgzsYIlMBptvk-qyIF.jpg?quality=95&as=32x27,48x41,72x61,108x92,160x136,240x203,360x305,420x356&from=bu&cs=420x0)
![](https://sun9-45.vkuserphoto.ru/s/v1/ig2/15SyoArR_JoVyC8dJzvLcVig7twZPVq7mdOSYkqDuW8SXKrSdJxKCHhI7jreMqeHEBVizxUBUKKm3mAft5IM47-L.jpg?quality=95&as=32x68,48x103,72x154,108x231,160x342,240x513,270x577&from=bu&cs=270x0)

# Задание 4

### Текст задачи
Из исходного файла получить новый файл, исключив повторные вхождения чисел.

### Алгоритм решения
В классе `FileTasks` реализован метод `FillBinaryFile` для генерации и записи случайных чисел. Метод `RemoveDuplicates` считывает массив чисел, проверяет каждое новое число на наличие в предыдущих элементах с помощью вложенного цикла, и записывает в новый файл только уникальные.

### Тестирование
![](https://sun9-54.vkuserphoto.ru/s/v1/ig2/TU12OwcrIB5ve7Gz5_zim6osWqG6bF79a7RJyOinYxdRrRVHpAM2F5IUW98sPCZ0YLw1NG6DC5X01_ne4TCLA9cy.jpg?quality=95&as=32x10,48x15,72x23,108x34,160x50,240x75,360x113,393x123&from=bu&cs=393x0)
![](https://sun9-52.vkuserphoto.ru/s/v1/ig2/i40lyQO6BS7gNSXm-JEYSRE7U7JaI1JXcwPzwY0AKRZMsmsRGPY7eZKyr7huTOlHV9hQQ4Xmx9ZtqHeSUlHBl7EO.jpg?quality=95&as=32x9,48x14,72x21,108x31,160x47,240x70,360x105,409x119&from=bu&cs=409x0)
![](https://sun9-45.vkuserphoto.ru/s/v1/ig2/xKjRI_Vi-DJQIBGCGwIijZir6BYq5TdkEYEPvC8TnRi_HPYGLA6ftrhyPUj4goPBcakebmjrwTxpywDJddnf0XI6.jpg?quality=95&as=32x10,48x15,72x23,108x35,160x51,240x77,353x113&from=bu&cs=353x0)

# Задание 5

### Текст задачи
Файл содержит сведения об игрушках: название игрушки, ее стоимость в рублях и возрастные границы (например, игрушка может предназначаться для детей от двух до пяти лет). Получить название игрушек, цена которых не превышает k руб. и которые подходят детям 5 лет.

### Алгоритм решения
Создана структура `Toy` с приватными полями и публичными свойствами. В классе `FileTasks` написан метод `FillXmlFile` для генерации тестовых данных и сохранения их через `XmlSerializer`. Метод `FindToys` десериализует файл и выводит подходящие игрушки.

### Тестирование
![](https://sun9-71.vkuserphoto.ru/s/v1/ig2/ZbZG8gGXjYfd7kRDx0ZtkoTh-rzdXmJBv-ndRxaPdpUfWFiu12qN9gItJJBsuz0blIvF89CYF7ASPMtg6S729FnW.jpg?quality=95&as=32x22,48x34,72x50,108x75,160x112,240x168,360x251,398x278&from=bu&cs=398x0)
![](https://sun9-81.vkuserphoto.ru/s/v1/ig2/uZjc0elEgKg7UFxbzKndvgE_qrsgWubMHRb6ivq_IQv6mL-TIZAXi3O7XcD0nf9P4b0z42SrI-9uwOp-lXiqzJDh.jpg?quality=95&as=32x34,48x51,72x77,108x116,160x171,240x257,360x386,480x514,540x579,640x686,720x772,822x881&from=bu&u=M7tQRIBC6TY-EVSdYLYDq8ecEZbqqlfCoWNdWIAGSz4&cs=822x0)

# Задание 6

### Текст задачи
Для заданного файла возвратить true, если он содержит заданное число b, и false в противном случае

### Алгоритм решения
В классе `FileTasks` создан метод `FillTextFile` для заполнения файла. Метод `ContainsNumber` открывает файл через `StreamReader`, считывает строки в цикле и проверяет на равенство с заданным числом `b`.

### Тестирование
![](https://sun9-50.vkuserphoto.ru/s/v1/ig2/cQ5M3awY4Fj7wEUfRhNSKWHFq7Q1noNev8AR0goCy-bm9V1egK1Q9mq1OwbxZFf9wDpehSmzcqCM_4cROzPLkBek.jpg?quality=95&as=32x9,48x14,72x21,108x31,160x46,240x70,360x105,458x133&from=bu&cs=458x0)
![](https://sun9-61.vkuserphoto.ru/s/v1/ig2/CAEfOP9JnMU4J2aZSQ7jXGNHeMm_1v83VU2_ulYVv0iY2fNTvumEnCF8snwJpdkrWgmXDstaILuh0OcOavSxw2UX.jpg?quality=95&as=32x131,48x196,72x294,108x442,133x544&from=bu&cs=133x0)
![](https://sun9-61.vkuserphoto.ru/s/v1/ig2/I5Nud_7gokS1fY-7W4EHpWx9sbGecpWULiOCYehpRlvMW4FNcEXVaI6HYAJjDe04wu2s_YLTDgawxNX316M1SDut.jpg?quality=95&as=32x9,48x14,72x21,108x31,160x46,240x70,360x104,435x126&from=bu&cs=435x0)
![](https://sun9-52.vkuserphoto.ru/s/v1/ig2/3vdem5cvV35DnJSwrUy1DBgK4IEPEMYn-DSBmoSYGkosJbOuFaN_p3QvMNoNRwkgh2hSwNwsWF7TKwgBa5GWc8XK.jpg?quality=95&as=32x133,48x199,72x298,108x447,134x555&from=bu&cs=134x0)

# Задание 7

### Текст задачи
Вычислить сумму элементов, которые кратны заданному числу k.

### Алгоритм решения
Файл заполняется методом `FillTextFileMultiple` (числа разделяются пробелами). В методе `SumMultiplesOfK` файл читается построчно, каждая строка разбивается методом `Split`, числа парсятся и проверяются на кратность `k`.

### Тестирование
![](https://sun9-80.vkuserphoto.ru/s/v1/ig2/xzySQchC8_1XP-VX2ZNyxdN3j0gZg_QPwRh3DQyjm5Lkd0vp15O3xXLFyGp4u6CKu9lQUekTtVb7qkYbWnn-fP1a.jpg?quality=95&as=32x15,48x23,72x35,108x52,160x77,240x115,360x173,480x231,540x259,640x307,689x331&from=bu&u=ZcXV-N401i2u-iQc8J40QHuPj7kXGKtoPk2TZYZeOns&cs=689x0)
![](https://sun9-6.vkuserphoto.ru/s/v1/ig2/VueAphprbGDPXnz0Flw5qqv38OVaOc-OO60-9k4kq3uTFCcNwtD11Y4NGu6nlnhC8Ij5wLtbdhmbk1Mv_fOh0Mdy.jpg?quality=95&as=32x74,48x111,72x166,108x250,145x335&from=bu&cs=145x0)

# Задание 8

### Текст задачи
Переписать в другой файл строки, в которых нет цифр.

### Алгоритм решения
Создан метод `FillTextFileWithText`, который записывает строки как с цифрами, так и без них. Метод `RewriteLinesWithoutDigits` читает исходный файл построчно, с помощью `char.IsDigit` проверяет каждый символ строки, и если цифр нет — записывает строку в новый файл.

### Тестирование
![](https://sun9-45.vkuserphoto.ru/s/v1/ig2/aeS5aTrQGMkldeGUy8SW92SMwZKmv8vXmU-1DduRdu4yQ3fpxC-4lYxWYcpasVkkeDLwqkCThYWpD-_uL3kxJRBL.jpg?quality=95&as=32x32,48x48,72x72,108x108,160x161,240x241,282x283&from=bu&u=LyAneeRyTBJblaV63hLRTPAc3EkxKyy2v2OTtRFBYIU&cs=282x0)
![](https://sun9-83.vkuserphoto.ru/s/v1/ig2/7hksUahm5Sb_PRvk9Rhw0UokC0Ra60hTeqOXMAeY2SYLhYNirfRRhZ49Yp5gkckAbHy_7YqWID9dQobf1rjL4PSS.jpg?quality=95&as=32x22,48x33,72x49,108x74,160x109,240x164,308x210&from=bu&cs=308x0)
![](https://sun9-2.vkuserphoto.ru/s/v1/ig2/TRroESjbtdh2yI7KTCgu2ydjG3TxdXOVJeG0x1mcSfcMW8ZwIO0jxKKEkOySDrXJz8abk1-gY07q6wBflWnp00X5.jpg?quality=95&as=32x20,48x29,72x44,108x66,160x98,240x147,287x176&from=bu&cs=287x0)
