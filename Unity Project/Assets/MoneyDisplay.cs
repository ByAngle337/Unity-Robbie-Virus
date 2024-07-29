using UnityEngine;
using TMPro;
using YG;

public class MoneyDisplay : MonoBehaviour
{
    public TextMeshProUGUI moneyText;

    void Update()
    {
        // Проверяем, существует ли объект YandexGame и у него есть ли переменная savesData
        if (YandexGame.savesData != null)
        {
            // Получаем значение переменной money и отображаем его в тексте
            moneyText.text = YandexGame.savesData.money.ToString();
        }
        else
        {
            // Если объект YandexGame или переменная savesData отсутствует, выводим сообщение об ошибке
            moneyText.text = "Error: YandexGame or savesData not found";
        }
    }
}
