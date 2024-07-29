using UnityEngine;
using YG;

public class Reset1 : MonoBehaviour
{
    // Ваш метод OnTriggerEnter
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
			if (YandexGame.savesData.language == "ru")
			{
				// Открываем ссылку в браузере
				OpenLinkInBrowser("https://yandex.ru/games/developer?name=AngleStudio");
			}
			
			if (YandexGame.savesData.language == "en")
			{
				// Открываем ссылку в браузере
				OpenLinkInBrowser("https://yandex.com/games/developer?name=AngleStudio");
			}
			
			if (YandexGame.savesData.language == "tr")
			{
				// Открываем ссылку в браузере
				OpenLinkInBrowser("https://yandex.com.tr/games/developer?name=AngleStudio");
			}
        }
    }

    // Метод для открытия ссылки в браузере
    private void OpenLinkInBrowser(string url)
    {
            // Открываем ссылку в браузере
        Application.OpenURL(url);
    }
}
