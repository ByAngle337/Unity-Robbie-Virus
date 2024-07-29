using UnityEngine;
using YG;

public class Transform111 : MonoBehaviour
{
    private bool hasChanged = false; // Флаг, чтобы отслеживать, были ли уже изменения

    public GameObject sus1;
    public GameObject sus2;
    public GameObject sus3;
    public GameObject sus4;

    // Сохранение начальных размеров
    private Vector3 initialScaleSus1;
    private Vector3 initialScaleSus2;
    private Vector3 initialScaleSus3;
    private Vector3 initialScaleSus4;

    // Задайте диапазон для изменения размеров
    public float scaleChangeRange = 1f;

    void Start()
    {
        // Сохранение начальных размеров
        initialScaleSus1 = sus1.transform.localScale;
        initialScaleSus2 = sus2.transform.localScale;
        initialScaleSus3 = sus3.transform.localScale;
        initialScaleSus4 = sus4.transform.localScale;
    }

    // Ваш метод Update
    void Update()
    {
        // Проверка условия и флага
        if (YandexGame.savesData.transform == 1 && !hasChanged)
        {
            // Изменение размеров для каждого объекта

            // sus1
            sus1.transform.localScale = new Vector3(
                initialScaleSus1.x * Random.Range(1f - scaleChangeRange, 1f + scaleChangeRange),
                initialScaleSus1.y * Random.Range(1f - scaleChangeRange, 1f + scaleChangeRange),
                initialScaleSus1.z * Random.Range(1f - scaleChangeRange, 1f + scaleChangeRange));

            // sus2
            sus2.transform.localScale = new Vector3(
                initialScaleSus2.x * Random.Range(1f - scaleChangeRange, 1f + scaleChangeRange),
                initialScaleSus2.y * Random.Range(1f - scaleChangeRange, 1f + scaleChangeRange),
                initialScaleSus2.z * Random.Range(1f - scaleChangeRange, 1f + scaleChangeRange));

            // sus3
            sus3.transform.localScale = new Vector3(
                initialScaleSus3.x * Random.Range(1f - scaleChangeRange, 1f + scaleChangeRange),
                initialScaleSus3.y * Random.Range(1f - scaleChangeRange, 1f + scaleChangeRange),
                initialScaleSus3.z * Random.Range(1f - scaleChangeRange, 1f + scaleChangeRange));

            // sus4
            sus4.transform.localScale = new Vector3(
                initialScaleSus4.x * Random.Range(1f - scaleChangeRange, 1f + scaleChangeRange),
                initialScaleSus4.y * Random.Range(1f - scaleChangeRange, 1f + scaleChangeRange),
                initialScaleSus4.z * Random.Range(1f - scaleChangeRange, 1f + scaleChangeRange));

            // Установка флага, чтобы избежать повторного изменения
            hasChanged = true;
        }
    }
}
