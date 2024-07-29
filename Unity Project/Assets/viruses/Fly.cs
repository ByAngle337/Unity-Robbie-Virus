using UnityEngine;
using YG;

public class Fly : MonoBehaviour
{
    private bool hasFly = false; // Флаг, чтобы отслеживать, было ли уже уменьшение
    public GameObject targetObject; // Переменная для хранения объекта, за которым следим
    public float stoppingDistance = 3f; // Расстояние, на котором объект должен остановиться
    public float rotationSpeed = 5f; // Скорость поворота
    public float hoverHeight = 5f; // Целевая высота парения
    public float hoverSpeed = 2f; // Скорость изменения высоты

    // Ваш метод Update
    void Update()
    {
        // Проверка условия и флага
        if (YandexGame.savesData.fly == 1 && !hasFly && targetObject != null)
        {
            // Здесь вы можете добавить код для уменьшения размера, если это необходимо

            // Установка флага, чтобы избежать повторного выполнения
            hasFly = true;
        }

        // Проверка, что targetObject не является null
        if (hasFly && targetObject != null)
        {
            // Получаем направление к целевому объекту
            Vector3 directionToTarget = targetObject.transform.position - transform.position;
            directionToTarget.y = 0f; // Обнуляем y, чтобы двигаться только по x и z
            directionToTarget.Normalize();

            // Задаем скорость движения в направлении целевого объекта
            float speed = 8f; // Устанавливаем желаемую скорость

            // Поворачиваем объект в сторону целевого объекта
            Quaternion targetRotation = Quaternion.LookRotation(directionToTarget);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // Проверяем дистанцию до целевого объекта
            float distanceToTarget = Vector3.Distance(new Vector3(transform.position.x, 0f, transform.position.z),
                                                      new Vector3(targetObject.transform.position.x, 0f, targetObject.transform.position.z));

            // Если дистанция больше stoppingDistance, продолжаем движение
            if (distanceToTarget > stoppingDistance)
            {
                // Плавное перемещение объекта только по x и z
                Vector3 newPosition = transform.position + new Vector3(directionToTarget.x, 0f, directionToTarget.z) * speed * Time.deltaTime;
                float newY = Mathf.Lerp(transform.position.y, hoverHeight, hoverSpeed * Time.deltaTime);
                transform.position = new Vector3(newPosition.x, newY, newPosition.z);
            }
            else
            {
                // Останавливаем объект, так как он находится на нужном расстоянии
                // Можно добавить здесь код для выполнения других действий
            }
        }
    }
}
