// Класс для редактирования коллекции строк для автозаполнения.

using MapViewer.Misc;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MapViewer.Helpers
{
    internal class SearchBarFunctions
    {
        // Создание новой коллекции. Берёт названия сущностей в качестве подсказок.
        public AutoCompleteStringCollection GetNewList(List<MarkerInfo> items)
        {
            AutoCompleteStringCollection newList = new AutoCompleteStringCollection();
            if (items is null) throw new NullReferenceException("Список предметов не может быть null.");
            foreach (var item in items)
            {
                newList.Add(item.Name);
            }
            return newList;
        }

        // Добавляет в конец коллекции номер 1 элементы коллекции номер 2 и возвращает получившийся набор.
        public AutoCompleteStringCollection AppendLists(AutoCompleteStringCollection list1, AutoCompleteStringCollection list2)
        {
            if (list1 is null || list2 is null) throw new NullReferenceException("Коллекция не может быть null.");
            foreach (string item in list2)
            {
                list1.Add(item);
            }
            return list1;
        }

        /* Удаление элементов, начиная с параметра-индекса (элемент на его месте тоже удалится),
         * и до самого конца. Возвращает получившийся набор.
         */
        public AutoCompleteStringCollection RemoveRange(AutoCompleteStringCollection list, int startingIndex)
        {
            if (list is null) throw new NullReferenceException("Коллекция не может быть null.");
            if (startingIndex < 0) throw new IndexOutOfRangeException("Индекс начала отсчёта не может быть отрицательным.");
            if (list.Count < startingIndex) throw new IndexOutOfRangeException("Индекс начала отсчёта выходит за пределы коллекции.");
            while (startingIndex < list.Count)
            { 
                list.RemoveAt(startingIndex);
            }
            return list;
        }

        /* Удаление определённого количества элементов, начиная с параметра-индекса
         * (элемент на его месте тоже удалится). Возвращает получившийся набор.
         */
        public AutoCompleteStringCollection RemoveRange(AutoCompleteStringCollection list, int startingIndex, int numberOfItems)
        {
            if (list is null) throw new NullReferenceException("Коллекция не может быть null.");
            if (startingIndex < 0) throw new IndexOutOfRangeException("Индекс начала отсчёта не может быть отрицательным.");
            if (numberOfItems < 0) throw new IndexOutOfRangeException("Количество строк для удаления не может быть отрицательным.");
            if (list.Count < startingIndex + numberOfItems) throw new Exception("В коллекции недостаточно строк для удаления по таким параметрам.");
            for (int i = 0; i < numberOfItems; i++)
            {
                list.RemoveAt(startingIndex);
            }
            return list;
        }
    }
}
