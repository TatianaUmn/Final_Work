## Задача

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

_**Примеры:**_

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

***

## Текстовое описание решения задачи

1. На старте выполнения алгоритма задаем первоначальный массив.
2. Объявляем второй массив такого же размера, как первый.
3. Создаем метод, в котором объявляем переменную *pos* = 0.
4. Далее проходим по циклу, соразмерному длине заданного первоначально массива.
5. На каждой итерации цикла проверяем условие, при котором длина каждого последующего элемента массива меньше или равна 3.
6. Если условие выполняется, то элементу финального массива, стоящего на позиции *pos*, присваивается значение i-го элемента первоначального массива.
7. Переменная *pos* увеличивается на 1.
8. Если условие, указанное в цикле, не выполняется, переходим к следующей итерации цикла.
9. После проверки всех элементов первоначального массива, формируется финальный массив.
10. Выводим финальный массив на печать, для чего используем соответствующий метод.
***

### **Комментарий к выполнению итоговой работы**:
* Блок-схема основной содержательной части алгоритма расположена в файле _schema.drawio.png_ ;
* Программа, решающая поставленную задачу, находится в файле _Task_.