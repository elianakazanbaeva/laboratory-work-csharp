<img width="252" height="387" alt="image" src="https://github.com/user-attachments/assets/97492f50-5925-48e3-a7d3-e64031fa1327" /># Казанбаева Элена ЛА-1 Лабораторная №5

## Задание 1

### Текст задачи
Реализовать чтение базы данных «Европейские футбольные клубы» из
Excel-файла LR5-var5.xls. База состоит из трёх листов: «Страны»,
«Клубы», «Достижения».

### Алгоритм решения
Для работы с Excel используется библиотека NPOI, которая читает
форматы .xls (HSSFWorkbook) и .xlsx (XSSFWorkbook) без установленного
Excel. Тип книги выбирается по расширению файла. Листы читаются по
порядку: лист 0 — страны, лист 1 — клубы, лист 2 — достижения.
Каждая строка обходится, заголовки и пустые ячейки пропускаются:
строка считается записью только если в первой колонке стоит число.
Значения ячеек извлекаются через вспомогательные методы GetInt и
GetString, которые обрабатывают пустые ячейки и текстовые числа.
Вся логика чтения инкапсулирована в классе Database, а ошибки ввода
(неверный путь, отсутствие файла, нет доступа) перехватываются через
try-catch и выводятся пользователю. Сложность O(n), где n — общее
число строк во всех листах.

### Тестирование
![](https://sun9-61.vkuserphoto.ru/s/v1/ig2/XBZfUnlXbFEwIcGi05RoJbzV4NvaTlJ_iE17dIzG0EzG0u1SHpvDjjhqw4fLSjnRHerC0zHJy6WchbWn1_EWAxb3.jpg?quality=95&as=32x140,48x209,72x314,108x471,160x698,176x768&from=bu&u=8ml458TgXOjkTw61esyRz6MYTqDh_7CY5oxt3vJOFPc&cs=176x0)
![](https://sun9-15.vkuserphoto.ru/s/v1/ig2/Qz-q3AG_UGYrBU0dclBJViWRJ25MYpBDd9CQ3QvJgBySVFb8Pv9X2b4WfbyPslTqDSCFgfJs6gr8G7u9_UNC3Zco.jpg?quality=95&as=32x19,48x29,72x43,108x65,160x96,240x144,360x216,480x287,511x306&from=bu&cs=511x0)
![](https://sun9-50.vkuserphoto.ru/s/v1/ig2/w4tlwu53ra-_Khx_22TECJ2xOnPpepFqWMTfV2ZE4ckrP03esQPBT--deeU62ab6yLcfeBJ4sPewcmo7gYWa0LcD.jpg?quality=95&as=32x8,48x13,72x19,108x28,160x42,240x63,360x94,480x125,540x141,640x167,720x188,1031x269&from=bu&cs=1031x0)
![](https://sun9-54.vkuserphoto.ru/s/v1/ig2/dWDaLjq9Z_1x-M-2KjWnrpkk6jbieMjbI8B0VXNjdXjua4crxVk-xDGLwWiaMpDmgNYO7ZUSNH1lSMYOBXhayx2g.jpg?quality=95&as=32x16,48x24,72x35,108x53,160x78,240x118,360x176,480x235,490x240&from=bu&cs=490x0)

## Задание 2

### Текст задачи
Реализовать просмотр базы данных, удаление элементов по ключу,
добавление элементов и сохранение изменений обратно в Excel-файл.

### Алгоритм решения
Просмотр выводит все три таблицы через переопределённый метод
ToString каждого класса. Удаление выполняется по ID с помощью
LINQ-метода FirstOrDefault с лямбда-предикатом: найденный элемент
удаляется из списка, если поиск не удался — выводится сообщение.
Добавление запрашивает значения полей через InputHelper с проверкой
типа и диапазона. Сохранение создаёт новую книгу NPOI, записывает
три листа с заголовками и всеми строками из списков, затем сохраняет
файл потоком. Весь функционал вынесен в методы класса Database, а
меню с выбором пункта и выходом по команде exit реализовано в классе
Menu. Обработка ошибок ввода и файлового доступа централизована в
InputHelper.

### Тестирование
![](https://sun9-56.vkuserphoto.ru/s/v1/ig2/kOJTSGVCz5wZnCAcAhRDq3pvw0M8POA_8dnScYXYLF8MMQ0xH7WOIuKxumvvN3BpAcYUbbslASet22YoBrKGXYy5.jpg?quality=95&as=32x49,48x74,72x111,108x166,160x246,240x369,252x387&from=bu&cs=252x0)
![](https://sun9-46.vkuserphoto.ru/s/v1/ig2/0i_1bzA_u9HUsycen1uFsulYtSp3r4cqjQpu9Gs2_FXN7ZZZTXGLUxg3o6GyVvhB-HDOPIExOdzvEh_6V7FOQ0td.jpg?quality=95&as=32x37,48x56,72x83,108x125,160x185,240x278,276x320&from=bu&cs=276x0)
![](https://sun9-38.vkuserphoto.ru/s/v1/ig2/mH8OEpKqzASX1E7w2eRVcXvRHsDVjYcC4WC8etbYBz3P6kVdSLIXnLhyrlmjbJNFsWnSJmuSqBGSED_uI4bwcoHq.jpg?quality=95&as=32x63,48x95,72x142,108x213,160x315,240x473,311x613&from=bu&cs=311x0)
![](https://sun9-45.vkuserphoto.ru/s/v1/ig2/o_b7Jw9X-fhYN6ezGxsvdwlV1365iZrbY-ittAmelKCqSl7be6C4tFLYHpzmJFwSvfWjaWl2IaIeAAgQVFH_tUC-m_Hnbw.jpg?quality=95&as=32x36,48x54,72x81,108x122,160x180,240x270,263x296&from=bu&cs=263x0)
![](https://sun9-72.vkuserphoto.ru/s/v1/ig2/plJQ7N1Q6m5PBV2wkUBvKEbqHR082uizLBislBiW6LQDgPgOS2XgLHFbynVKIVMYrFylhsynBt4ld_hLrB3O1yAj.jpg?quality=95&as=32x20,48x30,72x45,108x67,160x99,240x149,260x161&from=bu&cs=260x0)
![](https://sun9-54.vkuserphoto.ru/s/v1/ig2/NrBDHkSRi1ASisE1SN1gJjyZV6BGto0J1IwAbobvilsgR3ncVOyoxfY9Y4guQ0WUhfYIALBui2zHufN091CIhtWZ.jpg?quality=95&as=32x15,48x23,72x34,108x51,160x75,240x113,360x169,371x174&from=bu&cs=371x0)
![](https://sun9-83.vkuserphoto.ru/s/v1/ig2/ycxb7QY9oAkefCy7IJG0wBFslviHgvak6PFxJzBgUQTMQwjHP2MOxuScMRBpZ32Q_S1bWttfdD8-6Uwt-l-M0gqy.jpg?quality=95&as=32x41,48x61,72x92,108x137,160x204,240x306,271x345&from=bu&cs=271x0)
![](https://sun9-54.vkuserphoto.ru/s/v1/ig2/j8RhEnrxsysKwog34ljC5WvAooLNgQft32KSvA5qg-Zz5RcQBMMtdhZ-JNVMyq8N0llXjetmJExylC294yF2eK2I.jpg?quality=95&as=32x14,48x21,72x32,108x48,160x71,240x106,360x159,480x212,540x239,577x255&from=bu&cs=577x0)
![](https://sun9-15.vkuserphoto.ru/s/v1/ig2/Qz-q3AG_UGYrBU0dclBJViWRJ25MYpBDd9CQ3QvJgBySVFb8Pv9X2b4WfbyPslTqDSCFgfJs6gr8G7u9_UNC3Zco.jpg?quality=95&as=32x19,48x29,72x43,108x65,160x96,240x144,360x216,480x287,511x306&from=bu&cs=511x0)
![](https://sun9-50.vkuserphoto.ru/s/v1/ig2/w4tlwu53ra-_Khx_22TECJ2xOnPpepFqWMTfV2ZE4ckrP03esQPBT--deeU62ab6yLcfeBJ4sPewcmo7gYWa0LcD.jpg?quality=95&as=32x8,48x13,72x19,108x28,160x42,240x63,360x94,480x125,540x141,640x167,720x188,1031x269&from=bu&cs=1031x0)

## Задание 3

### Текст задачи
LINQ-запрос с обращением к одной таблице и возвратом одного значения:
определить количество клубов, которые хотя бы раз выигрывали Лигу
Чемпионов (поле «ЛЧ» больше нуля).

### Алгоритм решения
Запрос выполняется над коллекцией достижений с помощью метода
расширения Count и лямбда-предиката a => a.ChampionsLeague > 0.
Промежуточные коллекции не создаются, выполняется один проход по
списку. Временная сложность O(n), дополнительная память O(1).
Результат — единственное целое число.

### Тестирование
![](https://sun9-45.vkuserphoto.ru/s/v1/ig2/REY59XtadqhPBN-0eBmfCwfQsphJHH-eBsXM_BA7IwC8k3O206gDSjzS9Iv68GmO9zPIq3qyHLL3A2fypreTSVlk.jpg?quality=95&as=32x18,48x27,72x40,108x61,160x90,201x113&from=bu&u=cNfCqaWuNfiLCAU1ybhEPd2VwDDFpK_Li1cjowpOFcY&cs=201x0)
![](https://sun9-4.vkuserphoto.ru/s/v1/ig2/LPFMwXJx6U5zb2bpTAGfwr-jI97dCWyGRM7ZwyxGgkeCaFvSjyWkKL12U_0iLQwpaZLMO89yP4Nl8A7H3VjwcMeJ.jpg?quality=95&as=32x12,48x18,72x28,108x41,160x61,211x81&from=bu&cs=211x0)

## Задание 4

### Текст задачи
LINQ-запрос с обращением к двум таблицам и возвратом одного значения:
определить клубы, которые побеждали в чемпионате страны, но ни разу
не выигрывали национальный кубок. Из таких клубов выбрать клуб с
наибольшим числом золотых медалей, а при равенстве — с наибольшим ID
страны. В ответе вывести ID страны.

### Алгоритм решения
Выполняется внутреннее соединение таблиц «Клубы» и «Достижения» по
идентификатору клуба (join club.Id equals ach.ClubId). Фильтр
where ach.Cup == 0 оставляет только клубы без кубков, а where
ach.Gold > 0 — только чемпионов. Сортировка orderby ach.Gold
descending, club.CountryId descending ставит нужный клуб первым.
Метод FirstOrDefault извлекает одну запись и её CountryId.
Сложность O(n log n) из-за сортировки.

### Тестирование
![](https://sun9-56.vkuserphoto.ru/s/v1/ig2/kOJTSGVCz5wZnCAcAhRDq3pvw0M8POA_8dnScYXYLF8MMQ0xH7WOIuKxumvvN3BpAcYUbbslASet22YoBrKGXYy5.jpg?quality=95&as=32x49,48x74,72x111,108x166,160x246,240x369,252x387&from=bu&cs=252x0)
![](https://sun9-46.vkuserphoto.ru/s/v1/ig2/0i_1bzA_u9HUsycen1uFsulYtSp3r4cqjQpu9Gs2_FXN7ZZZTXGLUxg3o6GyVvhB-HDOPIExOdzvEh_6V7FOQ0td.jpg?quality=95&as=32x37,48x56,72x83,108x125,160x185,240x278,276x320&from=bu&cs=276x0)

## Задание 5

### Текст задачи
LINQ-запрос с обращением к трём таблицам и возвратом перечня:
вывести все клубы, выигрывавшие Лигу Чемпионов, с названием страны и
количеством побед.

### Алгоритм решения
Цепочка из трёх соединений: клубы соединяются со странами по
CountryId, затем с достижениями по ClubId. Условие where
ach.ChampionsLeague > 0 отбирает победителей турнира. Через select
new формируется анонимный тип с полями Club, Country, Wins.
Сортировка orderby по убыванию числа побед. Результат выводится
перечнем в консоли. Сложность O(n log n).

### Тестирование

![]()
![]()

## Задание 6

### Текст задачи
LINQ-запрос с обращением к трём таблицам и возвратом перечня:
вывести страны, чьи клубы имеют хотя бы один еврокубковый трофей
(сумма побед в ЛЧ, ЛЕ, КОК и ЛК строго больше нуля).

### Алгоритм решения
Соединяются три таблицы: страны, клубы и достижения. В условии where
вычисляется арифметическая сумма полей ChampionsLeague,
EuropaLeague, CupWinners и ConferenceLeague, и проверяется, что она
больше нуля. Так как у одной страны может быть несколько таких
клубов, применяется Distinct для удаления дубликатов названий, а
затем OrderBy для сортировки в алфавитном порядке. Сложность
O(n log n) с учётом сортировки и хеширования в Distinct.

### Тестирование
![]()
![]()
