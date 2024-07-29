using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    // Ваш метод Update
    void Update()
    {
        // Получаем позицию камеры
        Vector3 cameraPosition = Camera.main.transform.position;

        // "Поворачиваем" объект так, чтобы его лицевая часть была направлена к камере
        transform.LookAt(cameraPosition);

        // Зеркально отражаем объект по оси Z, чтобы он смотрел лицевой частью к камере
        transform.Rotate(0, 180, 0);
    }
}
