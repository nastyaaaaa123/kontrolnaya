# kontrolnaya
## Задача

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равно 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. Пример:

["hello", "2", "word", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> [ "-2"]

["Russia", "Denmark", "Kazan"] -> []

## Решение

1. Объявляем первый массив.
2. Создаём метод печати массива.
3. Объявляем второй массив с длиной первоначального массива.
4. Проверяем условия цикла, если в строке <= 3-х символов, то записывам строку в второй массив, если нет, то переходим к следуюшему элементу массива.
5. Выводим получившийся массив на печать.