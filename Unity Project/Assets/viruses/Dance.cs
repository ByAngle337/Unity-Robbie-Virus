using UnityEngine;
using YG;

public class Dance : MonoBehaviour
{
    private bool hasChanged = false; // Флаг, чтобы отслеживать, были ли уже изменения

    // Ваш метод Update
    void Update()
    {
        // Проверка условия и флага
        if (YandexGame.savesData.dance == 1 && !hasChanged)
        {
            // Изменение размера текущего объекта для превращения в плоскость
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, 1);

            // Установка флага, чтобы избежать повторного изменения
            hasChanged = true;
        }
    }
}
