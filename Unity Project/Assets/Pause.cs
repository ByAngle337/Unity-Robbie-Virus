using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Список игровых объектов, на которые не должно влиять изменение времени

    // Пауза времени
    public void OnPause()
    { 
        Time.timeScale = 0f;
		

        // Устанавливаем для всех объектов, кроме исключенных, флаг isPaused в true
    }
    
    // Снятие паузы времени
    public void NoPause()
    { 
        Time.timeScale = 1f;

        // Устанавливаем для всех объектов, кроме исключенных, флаг isPaused в false
    
    }
}
