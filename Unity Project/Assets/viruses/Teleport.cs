using UnityEngine;
using YG;
using System.Collections;

public class Teleport : MonoBehaviour
{
    private bool hasteleport = false; // Флаг, чтобы отслеживать, было ли уже уменьшение
    private float teleportCooldown = 2f; // Время задержки между телепортациями
    private float initialRadius; // Изначальный радиус для случайного изменения позиции
    private Vector3 initialPosition; // Изначальная позиция объекта

    void Start()
    {
        // Сохраняем начальную позицию и радиус
        initialPosition = transform.position;
        initialRadius = 3f; // Можете установить свое значение по умолчанию
    }

    // Ваш метод Update
    void Update()
    {
        // Проверка условия и флага
        if (YandexGame.savesData.teleport == 1 && !hasteleport)
        {
            // Активация переменной геймобъекта
            StartCoroutine(TeleportCoroutine());

            // Установка флага, чтобы избежать повторного уменьшения
            hasteleport = true;
        }
    }

    // Метод для плавного поднимания бесконечно вверх

    // Корутина для телепортации с заданным интервалом
    private IEnumerator TeleportCoroutine()
    {
        while (true)
        {
            // Генерация случайной позиции в изначальной позиции с использованием изначального радиуса
            Vector3 randomPosition = initialPosition + Random.insideUnitSphere * initialRadius;

            // Установка новой позиции
            transform.position = new Vector3(randomPosition.x, transform.position.y, randomPosition.z);

            // Ждем указанное время перед следующей телепортацией
            yield return new WaitForSeconds(teleportCooldown);
        }
    }
}
