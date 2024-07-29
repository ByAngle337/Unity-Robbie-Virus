using UnityEngine;
using YG;
using System.Collections;

public class Besen : MonoBehaviour
{
    public AudioSource soundEffect;
    public GameObject sopli;
    public Renderer rendererToChange; // Присвойте ваш Renderer, который нужно изменять
    private bool isBesen = false; // Флаг, чтобы отслеживать, лопнул ли уже объект
    private Vector3 initialPosition; // Начальное положение объекта
    private Color targetColor = Color.magenta; // Целевой цвет (фиолетовый)

    void Start()
    {
        // Сохраняем начальное положение
        initialPosition = transform.position;
    }

    void Update()
    {
        // Проверка условия раздувания
        if (YandexGame.savesData.besen == 1 && !isBesen)
        {
            StartCoroutine(DrunkBesen()); // Вызываем корутину для эффекта бесконечного дрожания
        }
    }

    IEnumerator DrunkBesen()
    {
        isBesen = true;

        Material materialToChange = rendererToChange.material; // Получаем материал из рендерера
        Color startColor = materialToChange.color; // Начальный цвет материала

        while (true)
        {
            // Используем Sin функцию для создания эффекта дрожания
            float time = Time.time * 50f; // Увеличиваем множитель для увеличения скорости дрожания
            float amplitude = 0.02f; // Амплитуда дрожания
            sopli.SetActive(true);

            // Дрожание по осям X и Z относительно начального положения
            float newPositionX = initialPosition.x + Mathf.Sin(time) * amplitude;
            float newPositionZ = initialPosition.z + Mathf.Cos(time) * amplitude;

            // Применяем изменение по осям X и Z
            transform.localPosition = new Vector3(newPositionX, transform.localPosition.y, newPositionZ);

            // Рандомное вращение с маленькой амплитудой
            float rotationSpeed = Random.Range(10f, 20f); // Рандомная скорость вращения
            float rotationAmplitude = 16f; // Маленькая амплитуда вращения
            transform.Rotate(Vector3.up, Mathf.Sin(time) * rotationAmplitude * rotationSpeed * Time.deltaTime);

            // Интерполируем цвет материала к целевому цвету
            float lerpFactor = 0.5f; // Фактор интерполяции, можно настроить
            Color lerpedColor = Color.Lerp(startColor, targetColor, lerpFactor * Time.deltaTime);
            materialToChange.SetColor("_Color", lerpedColor);

            yield return null;
        }
    }

    // Добавим метод для возврата к начальному положению
    public void ResetBesen()
    {
        isBesen = false;
        transform.position = initialPosition;
        transform.rotation = Quaternion.identity;

        // Сбрасываем цвет материала
        rendererToChange.material.color = Color.white; // Исходный цвет, можно также сохранить его в начале
    }
}