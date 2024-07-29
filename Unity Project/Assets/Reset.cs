using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class Reset : MonoBehaviour
{
    // Ваш метод OnTriggerEnter
    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, что в триггер вошел объект с тегом "Player"
        if (other.CompareTag("Player"))
        {
            // Перезапускаем текущую сцену
            RestartScene();
        }
    }

    // Метод для перезапуска текущей сцены
    private void RestartScene()
    {
        YandexGame.savesData.pop = 0;
		YandexGame.savesData.virus = 0;
		YandexGame.savesData.inject = 0;
		YandexGame.savesData.rainbow = 0;
		YandexGame.savesData.small = 0;
		YandexGame.savesData.big = 0;
		YandexGame.savesData.fly = 0;
		YandexGame.savesData.toilet = 0;
		YandexGame.savesData.besen = 0;
		YandexGame.savesData.fire = 0;
		YandexGame.savesData.baloon = 0;
		YandexGame.savesData.splun = 0;
		YandexGame.savesData.teleport = 0;
		YandexGame.savesData.transform = 0;
		YandexGame.savesData.dance = 0;
		YandexGame.savesData.flip = 0;
		YandexGame.SaveProgress();
		
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Перезапускаем текущую сцену
        SceneManager.LoadScene(currentSceneIndex);
    }
}