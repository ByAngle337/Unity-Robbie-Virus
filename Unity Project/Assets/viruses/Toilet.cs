using UnityEngine;
using YG;
using System.Collections;

public class Toilet : MonoBehaviour
{
    public float maxSize = 5f; // Максимальный размер объекта
    public float growthRate = 1f; // Скорость роста объекта
    public AudioSource soundEffect;
    public GameObject Ball1;
    public GameObject Ball2;
    public GameObject Ball3;

    private bool isPopped = false; // Флаг, чтобы отслеживать, лопнул ли уже объект

    void Update()
    {
        // Проверка условия раздувания
        if (YandexGame.savesData.toilet == 1 && !isPopped)
        {
            PopBalloon(); // Вызываем метод для лопания объекта
        }
    }

    void PopBalloon()
    {
        // Воспроизводим звук лопания

        // Задаем размеры по осям X, Y и Z равными 0

        // Запускаем корутину для изменения размера и активации объектов Ball через 4 секунды
        StartCoroutine(ChangeBallsAfterDelay(1f));

        // Устанавливаем флаг, чтобы избежать повторного вызова лопания
        isPopped = true;
    }

    IEnumerator ChangeBallsAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        // Изменяем размер объектов Ball1 и Ball2
        ChangeBallSize(Ball1);
        ChangeBallSize(Ball2);

        // Активируем объект Ball3
        ActivateBall(Ball3);

        // Воспроизводим звук лопания
        if (soundEffect != null)
        {
            soundEffect.Play();
        }
    }

    void ChangeBallSize(GameObject ball)
    {
        // Изменяем размер объекта Ball
        if (ball != null)
        {
            // Например, устанавливаем размер по осям X, Y и Z равным 0
            ball.transform.localScale = Vector3.zero;
        }
    }

    void ActivateBall(GameObject ball)
    {
        // Активируем объект Ball
        if (ball != null)
        {
            ball.SetActive(true);
        }
    }
}
