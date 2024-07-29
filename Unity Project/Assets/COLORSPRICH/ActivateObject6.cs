using UnityEngine;
using YG;

public class ActivateObject6 : MonoBehaviour
{
    public GameObject targetObject;
    public GameObject[] otherObjects;

    void Update()
    {
        // Проверка условия активации объекта
        if (YandexGame.savesData.virus == 6)
        {
            // Активация целевого объекта
            targetObject.SetActive(true);

            // Деактивация остальных объектов
            foreach (GameObject obj in otherObjects)
            {
                obj.SetActive(false);
            }
        }
    }
}
