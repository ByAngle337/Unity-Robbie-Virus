using UnityEngine;
using YG;
using System.Collections;

public class Baloon : MonoBehaviour
{
    private bool hasbaloon = false; // Флаг, чтобы отслеживать, было ли уже уменьшение
    public GameObject baloon1; // Переменная для хранения объекта baloon1

    // Ваш метод Update
    void Update()
    {
        // Проверка условия и флага
        if (YandexGame.savesData.baloon == 1 && !hasbaloon)
        {
            // Активация переменной геймобъекта
            baloon1.SetActive(true);

            // Плавное поднимание бесконечно вверх
            StartCoroutine(MoveBaloonUp());

            // Установка флага, чтобы избежать повторного уменьшения
            hasbaloon = true;
        }
    }

    // Метод для плавного поднимания бесконечно вверх
    IEnumerator MoveBaloonUp()
    {
        while (true)
        {
            // Изменение позиции по вертикали (поднимание вверх)
            transform.Translate(Vector3.up * Time.deltaTime);

            // Ждем один кадр
            yield return null;
        }
    }
}
