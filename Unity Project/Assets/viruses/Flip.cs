using UnityEngine;
using YG;

public class Flip : MonoBehaviour
{
    private bool hasFlipped = false; // Флаг, чтобы отслеживать, был ли уже переворот

    void Update()
    {
        // Проверка условия и флага
        if (YandexGame.savesData.flip == 1 && !hasFlipped)
        {
            // Поворот объекта на 180 градусов по оси X (вниз)
            transform.rotation *= Quaternion.Euler(-90f, 0f, 0f);

            // Поднятие объекта на 2 единицы вверх относительно текущего положения

            // Установка флага, чтобы избежать повторного переворота
            hasFlipped = true;
        }
    }
}
