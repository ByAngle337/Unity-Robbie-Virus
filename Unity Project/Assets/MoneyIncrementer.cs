using UnityEngine;
using YG;
using System.Collections;

public class MoneyIncrementer : MonoBehaviour
{
    void Start()
    {
        // Запускаем корутину для увеличения денег каждую секунду
        StartCoroutine(IncrementMoney());
    }

    IEnumerator IncrementMoney()
    {
        while (true)
        {
            // Проверяем, существует ли объект YandexGame и у него есть ли переменная savesData
            if (YandexGame.savesData != null)
            {
                // Увеличиваем значение переменной money на единицу
                YandexGame.savesData.money += 1;
				YandexGame.SaveProgress();

                // Ждем одну секунду перед следующим увеличением
                yield return new WaitForSeconds(1f);
            }
            else
            {
                // Если объект YandexGame или переменная savesData отсутствует, выводим сообщение об ошибке и выходим из цикла
                Debug.LogError("Error: YandexGame or savesData not found");
                yield break;
            }
        }
    }
}
