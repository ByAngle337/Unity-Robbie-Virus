using UnityEngine;
using YG;
using System.Collections;

public class Fire : MonoBehaviour
{
    private bool hasfire = false; // Флаг, чтобы отслеживать, было ли уже уменьшение
    public GameObject fire; // Переменная для хранения объекта baloon1
	public AudioSource soundEffect;

    // Ваш метод Update
    void Update()
    {
        // Проверка условия и флага
        if (YandexGame.savesData.fire == 1 && !hasfire)
        {
            // Активация переменной геймобъекта
            fire.SetActive(true);

            // Плавное поднимание бесконечно вверх

            // Установка флага, чтобы избежать повторного уменьшения
            hasfire = true;
			
			if (soundEffect != null)
            {
                soundEffect.Play();
            }
        }
    }

    // Метод для плавного поднимания бесконечно вверх
}
