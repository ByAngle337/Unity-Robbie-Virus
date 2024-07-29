using UnityEngine;
using YG;

public class MoneyTransaction4 : MonoBehaviour

{
	public GameObject trigger;
    private void OnTriggerEnter(Collider other)
    {
        // Проверка столкновения с игроком (Player)
        if (other.CompareTag("Player"))
        {
            // Проверка наличия достаточного количества денег
            if (YandexGame.savesData.money >= 250)
            {
                // Уменьшение количества денег
                YandexGame.savesData.money -= 250;

                // Установка флага покупки
                YandexGame.savesData.buy5 = 1;
            }
            // Можно добавить else-ветвь, если нужно что-то выполнить, если денег недостаточно
        }
    }
    
    void Update()
    {
        if (YandexGame.savesData.buy5 == 1)
        {
			trigger.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
