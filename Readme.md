## Задача

Из имеющегося массива строк сформировать массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив задается на старте выполнения алгоритма.

------------------
## Решение
1. Массив-результат `ResultArray` инициализируется с вызовом метода `CountNewArray`, определяющего число его элементов.
2. Основная часть решения реализуется в методе `CreateNewArray`, которому в качестве аргументов передается исходный массив `stringArray` и массив-результат `ResultArray`. 
В процессе выполнения метода массив-результат заполняется теми элементами исходного массива, которые удовлетворяют заданному условию.
3. Метод `PrintArray` необходим для вывода на экран исходного массива и массива-результата

