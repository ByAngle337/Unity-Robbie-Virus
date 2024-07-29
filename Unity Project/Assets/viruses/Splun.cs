using UnityEngine;
using YG;

public class Splun : MonoBehaviour
{
    private bool hasShrunk = false; // Флаг, чтобы отслеживать, было ли уже уменьшение

    // Ваш метод Update
    void Update()
    {
        // Проверка условия и флага
        if (YandexGame.savesData.splun == 1 && !hasShrunk)
        {
            // Уменьшение размера текущего объекта в 4 раза в плоскости XY
            transform.localScale = new Vector3(transform.localScale.x / 2, transform.localScale.y / 4, transform.localScale.z / 2);

            // Установка флага, чтобы избежать повторного уменьшения
            hasShrunk = true;
        }
    }
}

