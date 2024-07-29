using UnityEngine;

public class RainbowColorChange : MonoBehaviour
{
    public float duration = 3.0f; // Время, за которое будет происходить изменение цвета
    public Gradient rainbowGradient; // Градиент цветов радуги

    private Light lightComponent; // Ссылка на компонент света

    void Start()
    {
        // Получаем компонент света
        lightComponent = GetComponent<Light>();
        if (lightComponent == null)
        {
            Debug.LogError("Компонент света не найден.");
        }
    }

    void Update()
    {
        if (lightComponent != null && rainbowGradient != null)
        {
            // Вычисляем, какой процент прошло от времени duration
            float t = Mathf.PingPong(Time.time / duration, 1.0f);

            // Интерполируем цвет с использованием градиента
            Color lerpedColor = rainbowGradient.Evaluate(t);

            // Применяем новый цвет к компоненту света
            lightComponent.color = lerpedColor;
        }
    }
}
