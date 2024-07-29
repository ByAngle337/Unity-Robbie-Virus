using UnityEngine;
using YG;

public class ActivateObject1 : MonoBehaviour
{
    public GameObject targetObject;
    public GameObject[] otherObjects;

    void Update()
    {
        // Проверка условия активации объекта
        if (YandexGame.savesData.virus == 0)
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
