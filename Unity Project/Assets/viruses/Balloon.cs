using UnityEngine;
using YG;
using System.Collections;

public class Balloon : MonoBehaviour
{
    public float maxSize = 5f; // Максимальный размер объекта
    public float growthRate = 1f; // Скорость роста объекта
    public AudioSource soundEffect;
    public GameObject Ball;

    private bool isPopped = false; // Флаг, чтобы отслеживать, лопнул ли уже объект

    void Update()
    {
        // Проверка условия раздувания
        if (YandexGame.savesData.pop == 1 && !isPopped)
        {
            // Увеличение размера объекта
            transform.localScale += Vector3.one * growthRate * Time.deltaTime;

            // Проверка условия лопания
            if (transform.localScale.magnitude >= maxSize)
            {
                PopBalloon(); // Вызываем метод для лопания объекта
            }
        }
    }

    void PopBalloon()
    {
        // Воспроизводим звук лопания

        // Задаем размеры по осям X и Y равными 0

        // Запускаем корутину для изменения размера объекта Ball через 4 секунды
        StartCoroutine(ChangeBallSizeAfterDelay(1f));

        // Устанавливаем флаг, чтобы избежать повторного вызова лопания
        isPopped = true;
    }

    IEnumerator ChangeBallSizeAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        // Изменяем размер объекта Ball
        if (Ball != null)
        {
			if (soundEffect != null)
            {
                soundEffect.Play();
            }
            // Например, устанавливаем размер по осям X и Y равным 2
            Ball.transform.localScale = new Vector3(0f, 0f, 0.88f);
        }
    }
}
