using UnityEngine;

public class RainbowColorChange1 : MonoBehaviour
{
    public float duration = 3.0f; // Время, за которое будет происходить изменение цвета
    public Gradient rainbowGradient; // Градиент цветов радуги

    private Renderer rendererComponent; // Ссылка на компонент отображения

    void Start()
    {
        // Получаем компонент отображения (Renderer)
        rendererComponent = GetComponent<Renderer>();
        if (rendererComponent == null)
        {
            Debug.LogError("Компонент отображения не найден.");
        }
    }

    void Update()
    {
        if (rendererComponent != null && rainbowGradient != null)
        {
            // Вычисляем, какой процент прошло от времени duration
            float t = Mathf.PingPong(Time.time / duration, 1.0f);

            // Интерполируем цвет с использованием градиента
            Color lerpedColor = rainbowGradient.Evaluate(t);

            // Применяем новый цвет к компоненту отображения
            rendererComponent.material.color = lerpedColor;
        }
    }
}
