using UnityEngine;
using UnityEngine.UI;
using YG;

public class Inject : MonoBehaviour
{
    public GameObject syri;
    public Button gui;
    public AudioSource soundEffect; // Добавлен компонент AudioSource

    private bool isSyriInVirus = false;

    void Update()
    {
        // Обновление происходит только тогда, когда isSyriInVirus равно true
        if (isSyriInVirus == true)
        {
            if (YandexGame.savesData.virus == 1)
            {
                // Обработка ввода клавиши "e" или кнопки GUI
                if (Input.GetKeyDown(KeyCode.F) || (gui != null && gui.onClick != null))
                {
                    YandexGame.savesData.small = 1;
                    YandexGame.savesData.virus = 0;
                    Debug.Log("Клавиша E или кнопка GUI нажата. YandexGame.savesData.virus установлено в 1.");

                    // Воспроизводим звук
                    if (soundEffect != null)
                    {
                        soundEffect.Play();
                    }
                }
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Проверяем, входит ли объект "syri" в коллайдер текущего объекта "virus"
        if (other.gameObject == syri)
        {
            // Если условие выполнено, устанавливаем флаг в true
            isSyriInVirus = true;
            Debug.Log("Объект 'syri' вошел в триггер объекта 'virus'. Флаг isSyriInVirus установлен в true.");
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Проверяем, выходит ли объект "syri" из триггера текущего объекта "virus"
        if (other.gameObject == syri)
        {
            // Если условие выполнено, устанавливаем флаг в false
            isSyriInVirus = false;
            Debug.Log("Объект 'syri' вышел из триггера объекта 'virus'. Флаг isSyriInVirus установлен в false.");
        }
    }
}
