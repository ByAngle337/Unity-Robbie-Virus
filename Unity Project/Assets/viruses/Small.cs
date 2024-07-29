using UnityEngine;
using YG;

public class Small : MonoBehaviour
{
    private bool hasShrunk = false; // Флаг, чтобы отслеживать, было ли уже уменьшение

    // Ваш метод Update
    void Update()
    {
        // Проверка условия и флага
        if (YandexGame.savesData.small == 1 && !hasShrunk)
        {
            // Уменьшение размера текущего объекта в 2 раза
            Vector3 currentScale = transform.localScale;
            transform.localScale = new Vector3(currentScale.x / 2, currentScale.y / 2, currentScale.z / 2);

            // Установка флага, чтобы избежать повторного уменьшения
            hasShrunk = true;
        }
    }
}
