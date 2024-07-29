using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;
    public AudioSource audioSource; // Теперь эта переменная публичная

    // Синглтон
    public static AudioManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<AudioManager>();

                if (instance == null)
                {
                    instance = new GameObject("AudioManager").AddComponent<AudioManager>();
                    instance.audioSource = instance.gameObject.AddComponent<AudioSource>();
                    DontDestroyOnLoad(instance.gameObject);
                }
            }

            return instance;
        }
    }

    // Флаг для отслеживания того, был ли AudioManager уже инициализирован в текущей сцене
    private static bool isInitialized = false;

    void Awake()
    {
        // Проверяем, был ли AudioManager уже инициализирован в текущей сцене
        if (isInitialized)
        {
            Destroy(gameObject);
            return;
        }

        // Если объект создается первый раз в текущей сцене, сохраняем его в DontDestroyOnLoad
        DontDestroyOnLoad(gameObject);

        // Устанавливаем флаг инициализации в true
        isInitialized = true;
    }

    // Метод для воспроизведения звука
    public void PlaySound(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }
}
