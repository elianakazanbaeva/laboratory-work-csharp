# Казанбаева Элена ЛА-1 Лабораторная №1
# Задание 1
## Задача 1
### Текст задачи
Дробная часть.
Дана сигнатура метода: public double fraction (double x);
Необходимо реализовать метод таким образом, чтобы он возвращал только
дробную часть числа х. Подсказка: вещественное число может быть
преобразовано к целому путем отбрасывания дробной части.

### Алгоритм решения
Получить вещественное число x. Преобразовать его к целому типу — при этом дробная часть отбрасывается. Вычесть из исходного числа x полученное целое. Разность и есть дробная часть числа x. Вернуть результат.

### Тестирование
![](https://sun9-32.vkuserphoto.ru/s/v1/ig2/aPazYKTOQh_uGDceX5OA75Yswo2e-82_8dCZSbK4CTTduPpq-odRi7VI4tmTBfE_EeKenhdNoJsOpiRYQlQ5go4d.jpg?quality=95&as=32x12,48x18,72x27,108x40,160x59,240x89,307x114&from=bu&u=Ol3n4o0OLRWQFshColOdy5YORzqzufcDi7gNogS5pNk&cs=307x0)
![](https://sun9-69.vkuserphoto.ru/s/v1/ig2/QdEyexHrPHYkrb62WlQtnGKZtJMY-K48okpspd-kfAq2dqlw9SG5tGDBCHPqODHwHB-0K49TC1lYIErOc31lH_ID.jpg?quality=95&as=32x13,48x20,72x30,108x45,160x67,240x100,360x150,408x170&from=bu&u=I1y7DHvUy65IiKyipydBSp8s1OqYFZ4CXiSbBtnWAkY&cs=408x0)
## Задача 3
### Текст задачи
Букву в число. 
Дана сигнатура метода: public int charToNum (char x);
Метод принимает символ х, который представляет собой один из “0 1 2 3 4 5 6 7 8 9”. Необходимо реализовать метод таким образом, чтобы он преобразовывал символ в соответствующее число. Подсказка: код символа ‘0’ — это число 48.

### Алгоритм решения
Получить символ x. Вычислить разность между кодом символа x и кодом символа '0'. Присвоить полученное значение переменной result. Вернуть result.

### Тестирование
![](https://sun9-45.vkuserphoto.ru/s/v1/ig2/7cl6aWE3lDsOCajQYVrtjPRAxAyE71bu61zz9vx--n4NzDmugSg5yuv8y27f1GAYcCJk3dNV9Am5dunIhyHXYjDQ.jpg?quality=95&as=32x8,48x12,72x18,108x28,160x41,240x62,323x83&from=bu&u=FTRmI9kJpLzEixF3cMkAezV6c-8awh9F0qwchmmew-M&cs=323x0)
![](https://sun9-82.vkuserphoto.ru/s/v1/ig2/qr_lhViKT_L-pCDAj0rnijY5nQ_nSfOTGnQecBo00BUPEHX_g5uP1KFYs5ROrCp-TFRfzvmI4SmpRTQ69M69n1iK.jpg?quality=95&as=32x17,48x26,72x39,108x59,160x87,240x131,360x196,407x222&from=bu&u=eic7idvv2dAgiCd1iTIUxHWgfumaM1FHvxEp29lHXGQ&cs=407x0)

## Задача 5
### Текст задачи
Двузначное.
Дана сигнатура метода: public bool is2Digits (int x);
Необходимо реализовать метод таким образом, чтобы он принимал число x и возвращал true, если оно двузначное.

### Алгоритм решения
Получить целое число x. Проверить два условия одновременно: число больше 9 и число меньше 100. Если оба условия выполняются — вернуть true, иначе вернуть false.

### Тестирование
![](https://sun9-52.vkuserphoto.ru/s/v1/ig2/9dtUA6-bLNBAWhQ5-2ol8RVFkS-g0LZv-wqswCRnETCwhb_fO00l7t2bA42bUtemBPeBegi_rEhaJRR8PVMHz7rY.jpg?quality=95&as=32x12,48x17,72x26,108x39,160x58,240x87,299x109&from=bu&u=gjKHWY2N7T1RCAFtJ4ToEbMQgoFGRFZPKCX3VPYXXYs&cs=299x0)
![](https://sun9-1.vkuserphoto.ru/s/v1/ig2/EcUsh3CFhj8-klxNwLcQo5zDI5XbbXUUgWYe1-Pk1qx3GFYFvxcoeWiHNk2sIvddupGQONbl_123uN7gym8OJcHt.jpg?quality=95&as=32x12,48x17,72x26,108x39,160x58,240x87,314x114&from=bu&cs=314x0)
![](https://sun9-27.vkuserphoto.ru/s/v1/ig2/DvC71errVXataO4Gss5fNwybbm7QE_UOXoOOwpqVCxHmF62D_55iOpsL25FbTb66d54NpG7RB9nWTdrA6QFhF7Vf.jpg?quality=95&as=32x26,48x39,72x59,108x89,160x131,240x197,341x280&from=bu&cs=341x0)

## Задача 7
### Текст задачи
Диапазон.
Дана сигнатура метода: public bool isInRange (int a, int b, int num);
Метод принимает левую и правую границу (a и b) некоторого числового диапазона. Необходимо реализовать метод таким образом, чтобы он возвращал true, если num входит в указанный диапазон (включая границы). Обратите внимание, что отношение a и b заранее неизвестно (неясно кто из них больше, а кто меньше).

### Алгоритм решения
Получить два числа — границы диапазона. Получить третье число, которое нужно проверить. Сравнить между собой две границы. Определить, какая из них меньше, а какая больше. Проверить, что проверяемое число не меньше меньшей границы и не больше большей границы. Если оба условия выполняются, вернуть истину. Иначе вернуть ложь.

### Тестирование

![](https://sun9-78.vkuserphoto.ru/s/v1/ig2/V2VoFTiO3vb6LOUo32ObU_9ZyoImGJdd0EQwGHkzUBbDvrt9xNfs9YTNf--3xOWPFLqeVp-pJGlbN-cM1ZhM1yVB.jpg?quality=95&as=32x24,48x36,72x54,108x81,160x120,240x180,292x219&from=bu&u=h_TeNkEehA9MdUwAFMNlW6F_Kb8JlKhj28CHf4_JyQI&cs=292x0)

![](https://sun9-64.vkuserphoto.ru/s/v1/ig2/798tWx08XjJh7mFHblA6EVSpExqfvyrh0iBy0eM0Q0vusWIXyR4aGcPZGvzPoMbWCyP0tZx9tqpo1fGgKJqH-PI2.jpg?quality=95&as=32x24,48x36,72x55,108x82,160x122,240x182,292x222&from=bu&cs=292x0)
![](https://sun9-80.vkuserphoto.ru/s/v1/ig2/gmdN8jdPEcsawhrT-2cU-Mt0Z32NreV15ACsadUX-z4n9capA-qnO8U8y0IaeNTxEeujbUc40KeNCenLIRSKF7dd.jpg?quality=95&as=32x50,48x75,72x113,108x169,160x251,240x376,354x555&from=bu&cs=354x0)
## Задача 9
### Текст задачи
Равенство.
Дана сигнатура метода: public bool isEqual(int a, int b, int c);
Необходимо реализовать метод таким образом, чтобы он возвращал true, если
все три полученных методом числа равны

### Алгоритм решения
Получить три целых числа a, b, c. Сравнить первое число со вторым, а третье — с первым. Если оба сравнения истинны — все три числа равны, вернуть true. Иначе вернуть false.

### Тестирование
![](https://sun9-1.vkuserphoto.ru/s/v1/ig2/y6kRnn3sFGBeO_exROqnukrGbHKFu37LBnCZwdYkDOYqisKHCorUkPAOrGTY44tT6kQ_HzDAFYcxrRYExnd8GJu6.jpg?quality=95&as=32x25,48x38,72x57,108x85,160x127,240x190,288x228&from=bu&u=H4LWaiDs78K1doGzmqL8Lle-veIxddzPo39FoCBisv4&cs=288x0)
![](https://sun9-23.vkuserphoto.ru/s/v1/ig2/FceB-OT1CL2C6GdZz78cA61i4g_dS3pWSZfTbnRJHwrC9qsJQKVjEKFLZ6-TwxDCyB2BZltv_7WUH6GaDhT63_nN.jpg?quality=95&as=32x25,48x38,72x57,108x85,160x127,240x190,288x228&from=bu&cs=288x0)
![](https://sun9-36.vkuserphoto.ru/s/v1/ig2/brwg0eSQHGv3c9z8BnQ9NUiCHyLGK79Ui_0SrSZPQI_U4jX7y-iFtE8azhry56p69b708SQP8N12LEvMRCuQU5lY.jpg?quality=95&as=32x36,48x54,72x80,108x121,160x179,240x268,347x388&from=bu&cs=347x0)

# Задание 2

## Задача 1
### Текст задачи
Модуль числа.
Дана сигнатура метода: public int abs (int x);
Необходимо реализовать метод таким образом, чтобы он возвращал модуль
числа х (если оно было положительным, то таким и остается, если он было
отрицательным – то необходимо вернуть его без знака минус).

### Алгоритм решения
Получить целое число x. Проверить: если x меньше нуля, вернуть его с противоположным знаком (-x). Иначе вернуть x без изменений.

### Тестирование
![](https://sun9-8.vkuserphoto.ru/s/v1/ig2/iApViaJqn_Vl3xg0enypabBgu0_t5aTWJygRLpe-V-AzAkG27O_bHzYQJnM52iS2R62xAlplKGKaLMduaD-VCPgI.jpg?quality=95&as=32x15,48x22,72x33,108x49,160x73,230x105&from=bu&u=IspLxwSRfm6aTXExqIxY-ZtXYiwuoiz7hLaSgzTLF1w&cs=230x0)
![](https://sun9-51.vkuserphoto.ru/s/v1/ig2/jVEwUPMYY4Hp9FCQd_Ng2k_mntXqhJhnRs4SGzrwVu6ra6OiarWySyXFGcxZhg3T_XmIwwMpP0M-X80qojOA1TSV.jpg?quality=95&as=32x28,48x42,72x62,108x94,160x139,240x208,345x299&from=bu&cs=345x0)

## Задача 3
### Текст задачи
Тридцать пять.
Дана сигнатура метода: public bool is35 (int x);
Необходимо реализовать метод таким образом, чтобы он возвращал true, если
число x делится нацело на 3 или 5. При этом, если оно делится и на 3, и на 5, то
вернуть надо false. Подсказка: оператор % позволяет получить остаток от
деления.

### Алгоритм решения
Получить целое число x. Проверить: делится ли x на 3 без остатка и при этом не делится на 5 — тогда вернуть true. Иначе проверить обратное: не делится на 3, но делится на 5 — тоже вернуть true. Во всех остальных случаях вернуть false.

### Тестирование
![](https://sun9-80.vkuserphoto.ru/s/v1/ig2/Z5mi--v8H7cTOGBujQMJmEZ0DQSB-BsQFGXNjJA5jXysmDWGApG3poCWhpa8z5FCtBj66pxj8GVWp9toJjUooyfp.jpg?quality=95&as=32x29,48x43,72x64,108x97,160x143,240x215,296x265&from=bu&u=48rmWaOsDE6x7LyKXig3dNfMBZyrf3Yvi0SWPSkJNIg&cs=296x0)
![](https://sun9-34.vkuserphoto.ru/s/v1/ig2/9qnczyWzN_NjFJWyfSuHOFQqkVIIg1deAyAdZgyUxEy2DYrlVnBxmK_0fFO3Whb-euKPKJBwGYs8bWmW7Cm7q66L.jpg?quality=95&as=32x18,48x27,72x41,108x61,160x91,188x107&from=bu&cs=188x0)

## Задача 5
### Текст задачи
Тройной максимум.
Дана сигнатура метода: public int max3 (int x, int y, int z);
Необходимо реализовать метод таким образом, чтобы он возвращал
максимальное из трех полученных методом чисел. Подсказка: идеальное
решение включает всего две инструкции if и не содержит вложенных if.

### Алгоритм решения
Получить три целых числа x, y, z. Сравнить y с x: если y больше, заменить x значением y. Затем сравнить z с x: если z больше, заменить x значением z. В итоге в x окажется максимум. Вернуть x.

### Тестирование
![](https://sun9-84.vkuserphoto.ru/s/v1/ig2/YA_-17V80WpctUmXoW67wB2UfCq0AOZGapGj7EFeNA5MYVLAEVNxUmUBU5i_U6z9o9XCcddkAu0rrRMoh4-6c-qA.jpg?quality=95&as=32x41,48x62,72x93,108x140,160x207,240x310,298x385&from=bu&u=ucwwJlowEPHbe8xusnJjghe2kcyIwlaVgOaviGimMNU&cs=298x0)
![](https://sun9-5.vkuserphoto.ru/s/v1/ig2/ETunzf_YqUkjbgFIdnLEvuwPEG1QZPvPZEZ8ZiHFfX2a1UnKb0JSxWkYor7A5jERU-Ogg86XjQN8tEimrzWOMcLZ.jpg?quality=95&as=32x23,48x34,72x51,108x77,160x114,240x171,292x208&from=bu&cs=292x0)

## Задача 7
### Текст задачи
Двойная сумма.
Дана сигнатура метода: public int sum2 (int x, int y);
Необходимо реализовать метод таким образом, чтобы он возвращал сумму
чисел x и y. Однако, если сумма попадает в диапазон от 10 до 19, то надо вернуть
число 20.

### Алгоритм решения
Получить два целых числа x, y. Вычислить их сумму. Проверить: если сумма больше 9 и меньше 20 — вернуть число 20. Иначе вернуть саму сумму.

### Тестирование
![](https://sun9-27.vkuserphoto.ru/s/v1/ig2/ekFT8qJZ1EwZJkLmZqIFCec7zR7QbSRRH323VLezX8ywRxEhrQD9yDBwwySVmmUptAWb_oYQlkpqqYr4QRlytTAX.jpg?quality=95&as=32x34,48x51,72x77,108x116,160x171,240x257,299x320&from=bu&u=jnMTnmiatNdggTSJFCNOIcYB_NcWk5LH6XFvyQh0JyQ&cs=299x0)
![](https://sun9-51.vkuserphoto.ru/s/v1/ig2/rySzXtSMhrOH8_kwXoxueK0hsTNfNrxnFRwiMAEMW-NPiveHKcYb75Y6mG7YuH9BjjDLWxABG8KUq_5XTaTtmIT6.jpg?quality=95&as=32x32,48x48,72x71,108x107,160x159,235x233&from=bu&cs=235x0)

## Задача 9
### Текст задачи
День недели.
Дана сигнатура метода: public String day (int x);
Метод принимает число x, обозначающее день недели. Необходимо реализовать
метод таким образом, чтобы он возвращал строку, которая будет обозначать
текущий день недели, где 1- это понедельник, а 7 – воскресенье. Если число не
от 1 до 7 то верните текст “это не день недели”. Вместо if в данной задаче
используйте switch. 

### Алгоритм решения
Получить целое число x — номер дня недели. С помощью конструкции switch проверить значение: 1 → «понедельник», 2 → «вторник», …, 7 → «воскресенье». Если число не входит в 1..7 — вернуть «это не день недели».

### Тестирование
![](https://sun9-78.vkuserphoto.ru/s/v1/ig2/XDCnHs-vPJicUxTQ80ExB41xhNY8E3oEO33C0A1St-hOqdviImh49XqQJ0Od9nrZfPNbR4Pg_qZCpACqqGuhWaEf.jpg?quality=95&as=32x27,48x41,72x61,108x92,160x137,240x205,302x258&from=bu&u=7EnFFcQlJX0_vHH9gvY4OWBG8QYxNXOhHRxZedRluxw&cs=302x0)
![](https://sun9-1.vkuserphoto.ru/s/v1/ig2/Mqml1hoWHjyJ0coqv0qY-T8vEi82w8b-DTQoBOcfeQotnokWFSeSc4n92AqBSSbfCZEzLzqVdfHhPLJ644Iin8et.jpg?quality=95&as=32x15,48x22,72x33,108x50,160x74,228x106&from=bu&cs=228x0)


# Задание 3

## Задача 1
### Текст задачи
Числа подряд.
Дана сигнатура метода: public String listNums (int x);
Необходимо реализовать метод таким образом, чтобы он возвращал строку, в
которой будут записаны все числа от 0 до x (включительно).


### Алгоритм решения
Получить целое число x. Создать массив строк размером x. Счётчиком j пройти с 0 до x-1, а счётчиком i — от x вниз до 1. На каждой итерации записать в nums[j] число i и увеличить j. Объединить элементы массива через пробел с помощью string.Join и вернуть строку.

### Тестирование
![](https://sun9-38.vkuserphoto.ru/s/v1/ig2/TjBrvwEPOGDQ-88Jsi2QsDLT4ob_vLFQy51TQ59O1oAhIOHG6SiAsU5DujI8PxeexW0xvVyU9iBy65DvhrYLBqFt.jpg?quality=95&as=32x18,48x27,72x41,108x62,160x92,240x137,241x138&from=bu&u=4qIIz9OmsFUY0iHwtVe1VqwErU8pHsn21UszU3UhAz0&cs=241x0)
![](https://sun9-44.vkuserphoto.ru/s/v1/ig2/piMCoLol1w84i9OM0o41derSp37yACHQew8yV0DwWxgr1Lc6iLBsV-O_ZcJu46iDoDbazQE2btvjMNQA3dJQF7Ii.jpg?quality=95&as=32x28,48x41,72x62,108x93,160x138,240x207,331x286&from=bu&cs=331x0)
![](https://sun9-28.vkuserphoto.ru/s/v1/ig2/1UcEq_KDdoDhUBYCUhROv_WSpeHnmNTQ7QXCrgixa2Z0HQkzoRubwCrRNajPLC2HC1FRZr3x2ago6ad_BqHSvuE-.jpg?quality=95&as=32x16,48x24,72x36,108x54,160x80,240x120,251x125&from=bu&cs=251x0)

## Задача 3
### Текст задачи
Четные числа.
Дана сигнатура метода: public String chet (int x);
Необходимо реализовать метод таким образом, чтобы он возвращал строку, в
которой будут записаны все четные числа от 0 до x (включительно). Подсказа
для обеспечения качества кода: инструкцию if использовать не следует.

### Алгоритм решения
Получить целое число x. Создать пустую строку результата. В цикле от 0 до x с шагом 2 добавлять текущее значение и пробел в строку. Вернуть строку.

### Тестирование
![](https://sun9-46.vkuserphoto.ru/s/v1/ig2/3M_c_v9d38XCnWU7Bu6ccK5MOzRUkYTunSRch4_HTuQD7jMGZpebhQ0cecoBW69UxmtYUWQl9ZZBfOYbFYVftnhB.jpg?quality=95&as=32x28,48x42,72x63,108x94,160x139,240x209,319x278&from=bu&u=S0mTHQfalcGOVmYUuTjBYtyQsw_lAK_HB7yzsP8ZjTc&cs=319x0)

## Задача 5
### Текст задачи
Длина числа.
Дана сигнатура метода: public int numLen (long x);
Необходимо реализовать метод таким образом, чтобы он возвращал количество
знаков в числе x. 

### Алгоритм решения
Получить целое число x типа long. Преобразовать его в строку с помощью ToString(). Вернуть длину этой строки.

### Тестирование
![](https://sun9-53.vkuserphoto.ru/s/v1/ig2/RyNMBXF3dpqCa-NNtEhjooxeEVOHLL9F6qs4DARHElQoP_fTqYz87EOpEsW7IZ5Wt7S3HmdO9ckOLZRdN6nAr_wF.jpg?quality=95&as=32x27,48x40,72x60,108x90,160x134,240x201,321x269&from=bu&u=6exeoVFC6AogiRq4_4FsTx0sCo8c-Y2sfS07oFPb8YY&cs=321x0)
![](https://sun9-25.vkuserphoto.ru/s/v1/ig2/tufmI8hmyd2iPqEXFWMXf_2l89cA4ZChyNJq7fi4P6CJ_Jh6pXa6S3FsKfJ8ILlQc9mg2oV0FMuFrP5updFGrizz.jpg?quality=95&as=32x11,48x16,72x24,108x36,160x53,240x79,319x105&from=bu&cs=319x0)

## Задача 7
### Текст задачи
Квадрат.
Дана сигнатура метода: public void square (int x);
Необходимо реализовать метод таким образом, чтобы он выводил на экран
квадрат из символов ‘*’ размером х, у которого х символов в ряд и х символов в
высоту. 

### Алгоритм решения
Получить целое число x — сторону квадрата. Собрать строку из x символов '*'. Вывести эту строку x раз с помощью цикла — получится квадрат.

### Тестирование
![](https://sun9-25.vkuserphoto.ru/s/v1/ig2/jiXz9yKpPAxfZaS34v8sAuivNYQpmuy5RVk3uRt5qyiKEw2ZHEQwntQClEeEMAIIJO7ffIw3KmCWsvfSRLyzp1Dv.jpg?quality=95&as=32x22,48x33,72x50,108x75,160x111,240x167,360x250,381x265&from=bu&u=jbuw46qVJL_k5v20TKB6F-J1QD6eulAMKh1oiqhMaLk&cs=381x0)
![](https://sun9-72.vkuserphoto.ru/s/v1/ig2/QOESE5FRNGw2Zihr3fEHJH_50WS9vRKFkzJ8r8CjFiViN7lbSbUBoPQUMFIA97OkdK4JmzcDmKxo_R2fXclH0bp2.jpg?quality=95&as=32x45,48x67,72x101,108x151,160x224,227x318&from=bu&cs=227x0)

## Задача 9
### Текст задачи
Правый треугольник.
Дана сигнатура метода: public void rightTriangle (int x);
Необходимо реализовать метод таким образом, чтобы он выводил на экран
треугольник из символов ‘*’ у которого х символов в высоту, а количество
символов в ряду совпадает с номером строки, при этом треугольник выровнен
по правому краю. Подсказка: перед символами ‘*’ следует выводить
необходимое количество пробелов.

### Алгоритм решения
Получить целое число x — высоту треугольника. В цикле от 1 до x построить строку: сначала (x - i) пробелов, затем i звёздочек. Вывести каждую строку — получится прямоугольный треугольник.

### Тестирование
![](https://sun9-52.vkuserphoto.ru/s/v1/ig2/fJu-HuKDYc8V9PzPJ0rX1iAlNWx17iXEBeo107fDHUs_myXKUIIerlo3_fCxriQaOKgkbc8PhWgqtpt1syrFJrtS.jpg?quality=95&as=32x35,48x52,72x79,108x118,160x175,240x262,314x343&from=bu&u=hgspzwRcLWXaxEZF1x2pNPIiprobinBbFU6lXjjnlr0&cs=314x0)

# Задание 4

## Задача 1
### Текст задачи
Поиск первого значения.
Дана сигнатура метода: public int findFirst (int[] arr, int x);
Необходимо реализовать метод таким образом, чтобы он возвращал индекс
первого вхождения числа x в массив arr. Если число не входит в массив –
возвращается -1.
### Алгоритм решения
Получить массив целых чисел и искомое число x. Пройти по массиву слева направо. Если текущий элемент равен x — вернуть его индекс. Если цикл завершился и совпадений не было — вернуть -1.

### Тестирование
![](https://sun9-64.vkuserphoto.ru/s/v1/ig2/xPd6NaoTPxe8fe6IS4z6pLniMT4fH09IN-sAH0AY5jeMT8uU6KAHRlG8CQCohKUOXjYdjdqQMbP74KGW85eeo7av.jpg?quality=95&as=32x31,48x46,72x69,108x103,160x153,240x230,360x344,459x439&from=bu&u=Gbv-h3iUvftunLSaQ-9Bc15FN8n0fC9VvU5RgTuqyA8&cs=459x0)
![](https://sun9-52.vkuserphoto.ru/s/v1/ig2/fJu-HuKDYc8V9PzPJ0rX1iAlNWx17iXEBeo107fDHUs_myXKUIIerlo3_fCxriQaOKgkbc8PhWgqtpt1syrFJrtS.jpg?quality=95&as=32x35,48x52,72x79,108x118,160x175,240x262,314x343&from=bu&cs=314x0)

## Задача 3
### Текст задачи
Поиск максимального.
Дана сигнатура метода: public int maxAbs (int[] arr);
Необходимо реализовать метод таким образом, чтобы он возвращал
наибольшее по модулю (то есть без учета знака) значение массива arr.

### Алгоритм решения
Получить массив целых чисел. Завести переменную max_num = -1. Пройти по массиву: для каждого элемента взять его модуль, сравнить с текущим max_num и записать большее. Вернуть max_num.

### Тестирование
![](https://sun9-69.vkuserphoto.ru/s/v1/ig2/tX0-eJslJmXRJYbPPk8aSBHVNYpTCcmXeUMfaOF1z27u9QGqeBN6DlBwBI0tN8zKqWHX_8yZM6feXq3pcBdd77BC.jpg?quality=95&as=32x18,48x27,72x40,108x61,160x90,240x135,360x202,371x208&from=bu&u=TkxI5Nxw2W_O4aUctg2dn4EWQDGJIjNbqwV1-A6V678&cs=371x0)

## Задача 5
### Текст задачи
Добавление массива в массив.
Дана сигнатура метода: public int[] add (int[] arr, int[] ins, int pos);
Необходимо реализовать метод таким образом, чтобы он возвращал новый
массив, который будет содержать все элементы массива arr, однако в позицию
pos будут вставлены значения массива ins.

### Алгоритм решения
Получить два массива arr и ins, а также позицию pos. Если pos меньше 0 — сделать его 0. Если pos больше длины arr — сделать его длиной arr. Создать новый массив длиной arr.Length + ins.Length. Скопировать элементы arr до pos, затем вставить все элементы ins, затем скопировать оставшиеся элементы arr. Вернуть новый массив.

### Тестирование
![](https://sun9-7.vkuserphoto.ru/s/v1/ig2/vdeaCkwEVqvpSc69OXiDDPBWezU5UT20-nGeCuvMu1uq9RdMBNYmNbd6P30ctyzQPfMq1VZkg4rbRn1zd56QVXNq.jpg?quality=95&as=32x28,48x43,72x64,108x96,160x143,240x214,360x321,449x400&from=bu&u=LuxRRSuUQrt5KT_V-jVlnBEoMPZ0l6ZqiyqeewclGu0&cs=449x0)
![](https://sun9-50.vkuserphoto.ru/s/v1/ig2/lo-JvkP8-3EQbCNR6861B28KuJtmYymbnFwOYB5jByPviSD24RNdQkJfgVLfcZ-InYgr_tUwJfjrQzqKzdTUXuGA.jpg?quality=95&as=32x23,48x35,72x52,108x78,160x116,240x174,360x262,432x314&from=bu&cs=432x0)

## Задача 7
### Текст задачи
Возвратный реверс.
Дана сигнатура метода: public int[] reverseBack (int[] arr);
Необходимо реализовать метод таким образом, чтобы он возвращал новый
массив, в котором значения массива arr записаны задом наперед.

### Алгоритм решения
Получить массив. Пройти циклом до середины массива (arr.Length / 2). На каждой итерации поменять местами элемент i и элемент (arr.Length - 1 - i). Вернуть изменённый массив.

### Тестирование
![](https://sun9-25.vkuserphoto.ru/s/v1/ig2/rVRPLAqvQW4kfDR3fnuThOiBApPLxhOhbf6FefQ7e3j_QNFZTaPanHHEuA9f-eCBXU_8tvWO-J4K-_8aynpSvYcw.jpg?quality=95&as=32x19,48x29,72x44,108x65,160x97,240x145,360x218,480x291,482x292&from=bu&u=_TE9HP3V4XP05iL6uT4DP-Yny-synLrc4fcKtqYltFw&cs=482x0)

## Задача 9
### Текст задачи
Все вхождения.
Дана сигнатура метода: public int[] findAll (int[] arr, int x);
Необходимо реализовать метод таким образом, чтобы он возвращал новый
массив, в котором записаны индексы всех вхождений числа x в массив arr.

### Алгоритм решения
Получить массив и число x. Первым проходом посчитать, сколько раз x встречается в массиве. Создать массив индексов нужного размера. Вторым проходом записать в него индексы всех вхождений x. Вернуть массив индексов.

### Тестирование
![](https://sun9-11.vkuserphoto.ru/s/v1/ig2/p99ji2Jqw4RwYwXZf3v2IbPiZaBScdVcRUtCScJ2M84KldgJIR0T4rQlyqsS8OsKoJoBdtVQrx4PIA4rZIUOpSfC.jpg?quality=95&as=32x33,48x50,72x75,108x113,160x167,240x251,360x376,461x482&from=bu&u=LxeIToIm8hHUDpPpgYpjzFOVQq5cBE-ADOYR7rOTHuE&cs=461x0)


GitHub: https://github.com/elianakazanbaeva/laboratory-work-csharp
