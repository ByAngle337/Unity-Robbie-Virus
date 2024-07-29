using UnityEngine;
using YG;

public class ActivateObject : MonoBehaviour
{
	public GameObject none;
    public GameObject virus1;
    public GameObject virus2;
    public GameObject virus3;
	public GameObject virus4;
    public GameObject virus5;
    public GameObject virus6;
	public GameObject virus7;
    public GameObject virus8;
    public GameObject virus9;
	public GameObject virus10;
	public GameObject virus11;
	public GameObject virus12;
	public GameObject virus13;
    public GameObject virus14;
    public GameObject virus15;
	public GameObject virus16;
	public GameObject virus17;
	public GameObject virus18;

    void Update()
    {
        // Проверка условия активации объектов
        if (YandexGame.savesData.virus == 1)
        {
            // Активация целевого объекта virus1
            virus1.SetActive(true);

            // Деактивация остальных объектов virus2 и virus3
			none.SetActive(false);
            virus2.SetActive(false);
            virus3.SetActive(false);
			virus4.SetActive(false);
            virus5.SetActive(false);
			virus6.SetActive(false);
            virus7.SetActive(false);
			virus8.SetActive(false);
            virus9.SetActive(false);
			virus10.SetActive(false);
			virus11.SetActive(false);
            virus12.SetActive(false);
			virus13.SetActive(false);
			virus14.SetActive(false);
            virus15.SetActive(false);
			virus16.SetActive(false);
			virus17.SetActive(false);
            virus18.SetActive(false);
        }
		
		if (YandexGame.savesData.virus == 0)
        {
            // Активация целевого объекта virus1
            none.SetActive(true);

            // Деактивация остальных объектов virus2 и virus3
			virus1.SetActive(false);
            virus2.SetActive(false);
            virus3.SetActive(false);
			virus4.SetActive(false);
            virus5.SetActive(false);
			virus6.SetActive(false);
            virus7.SetActive(false);
			virus8.SetActive(false);
            virus9.SetActive(false);
			virus10.SetActive(false);
			virus11.SetActive(false);
            virus12.SetActive(false);
			virus13.SetActive(false);
			virus14.SetActive(false);
            virus15.SetActive(false);
			virus16.SetActive(false);
			virus17.SetActive(false);
            virus18.SetActive(false);
        }
		
		if (YandexGame.savesData.virus == 2)
        {
            // Активация целевого объекта virus1
            virus2.SetActive(true);

            // Деактивация остальных объектов virus2 и virus3
			none.SetActive(false);
            virus1.SetActive(false);
            virus3.SetActive(false);
			virus4.SetActive(false);
            virus5.SetActive(false);
			virus6.SetActive(false);
            virus7.SetActive(false);
			virus8.SetActive(false);
            virus9.SetActive(false);
			virus10.SetActive(false);
			virus11.SetActive(false);
            virus12.SetActive(false);
			virus13.SetActive(false);
			virus14.SetActive(false);
            virus15.SetActive(false);
			virus16.SetActive(false);
			virus17.SetActive(false);
            virus18.SetActive(false);
        }
		
		if (YandexGame.savesData.virus == 3)
        {
            // Активация целевого объекта virus1
            virus3.SetActive(true);

            // Деактивация остальных объектов virus2 и virus3
			none.SetActive(false);
            virus1.SetActive(false);
            virus2.SetActive(false);
			virus4.SetActive(false);
            virus5.SetActive(false);
			virus6.SetActive(false);
            virus7.SetActive(false);
			virus8.SetActive(false);
            virus9.SetActive(false);
			virus10.SetActive(false);
			virus11.SetActive(false);
            virus12.SetActive(false);
			virus13.SetActive(false);
			virus14.SetActive(false);
            virus15.SetActive(false);
			virus16.SetActive(false);
			virus17.SetActive(false);
            virus18.SetActive(false);
        }
		
		if (YandexGame.savesData.virus == 4)
        {
            // Активация целевого объекта virus1
            virus4.SetActive(true);

            // Деактивация остальных объектов virus2 и virus3
			none.SetActive(false);
            virus1.SetActive(false);
            virus2.SetActive(false);
			virus3.SetActive(false);
            virus5.SetActive(false);
			virus6.SetActive(false);
            virus7.SetActive(false);
			virus8.SetActive(false);
            virus9.SetActive(false);
			virus10.SetActive(false);
			virus11.SetActive(false);
            virus12.SetActive(false);
			virus13.SetActive(false);
			virus14.SetActive(false);
            virus15.SetActive(false);
			virus16.SetActive(false);
			virus17.SetActive(false);
            virus18.SetActive(false);
        }
		
		if (YandexGame.savesData.virus == 5)
        {
            // Активация целевого объекта virus1
            virus5.SetActive(true);

            // Деактивация остальных объектов virus2 и virus3
			none.SetActive(false);
            virus1.SetActive(false);
            virus2.SetActive(false);
			virus3.SetActive(false);
            virus4.SetActive(false);
			virus6.SetActive(false);
            virus7.SetActive(false);
			virus8.SetActive(false);
            virus9.SetActive(false);
			virus10.SetActive(false);
			virus11.SetActive(false);
            virus12.SetActive(false);
			virus13.SetActive(false);
			virus14.SetActive(false);
            virus15.SetActive(false);
			virus16.SetActive(false);
			virus17.SetActive(false);
            virus18.SetActive(false);
        }
		
		if (YandexGame.savesData.virus == 6)
        {
            // Активация целевого объекта virus1
            virus6.SetActive(true);

            // Деактивация остальных объектов virus2 и virus3
			none.SetActive(false);
            virus1.SetActive(false);
            virus2.SetActive(false);
			virus3.SetActive(false);
            virus4.SetActive(false);
			virus5.SetActive(false);
            virus7.SetActive(false);
			virus8.SetActive(false);
            virus9.SetActive(false);
			virus10.SetActive(false);
			virus11.SetActive(false);
            virus12.SetActive(false);
			virus13.SetActive(false);
			virus14.SetActive(false);
            virus15.SetActive(false);
			virus16.SetActive(false);
			virus17.SetActive(false);
            virus18.SetActive(false);
        }
		
		if (YandexGame.savesData.virus == 7)
        {
            // Активация целевого объекта virus1
            virus7.SetActive(true);

            // Деактивация остальных объектов virus2 и virus3
			none.SetActive(false);
            virus1.SetActive(false);
            virus2.SetActive(false);
			virus3.SetActive(false);
            virus4.SetActive(false);
			virus5.SetActive(false);
            virus6.SetActive(false);
			virus8.SetActive(false);
            virus9.SetActive(false);
			virus10.SetActive(false);
			virus11.SetActive(false);
            virus12.SetActive(false);
			virus13.SetActive(false);
			virus14.SetActive(false);
            virus15.SetActive(false);
			virus16.SetActive(false);
			virus17.SetActive(false);
            virus18.SetActive(false);
        }
		
		if (YandexGame.savesData.virus == 8)
        {
            // Активация целевого объекта virus1
            virus8.SetActive(true);

            // Деактивация остальных объектов virus2 и virus3
			none.SetActive(false);
            virus1.SetActive(false);
            virus2.SetActive(false);
			virus3.SetActive(false);
            virus4.SetActive(false);
			virus5.SetActive(false);
            virus6.SetActive(false);
			virus7.SetActive(false);
            virus9.SetActive(false);
			virus10.SetActive(false);
			virus11.SetActive(false);
            virus12.SetActive(false);
			virus13.SetActive(false);
			virus14.SetActive(false);
            virus15.SetActive(false);
			virus16.SetActive(false);
			virus17.SetActive(false);
            virus18.SetActive(false);
        }
		
		if (YandexGame.savesData.virus == 9)
        {
            // Активация целевого объекта virus1
            virus9.SetActive(true);

            // Деактивация остальных объектов virus2 и virus3
			none.SetActive(false);
            virus1.SetActive(false);
            virus2.SetActive(false);
			virus3.SetActive(false);
            virus4.SetActive(false);
			virus5.SetActive(false);
            virus6.SetActive(false);
			virus7.SetActive(false);
            virus8.SetActive(false);
			virus10.SetActive(false);
			virus11.SetActive(false);
            virus12.SetActive(false);
			virus13.SetActive(false);
			virus14.SetActive(false);
            virus15.SetActive(false);
			virus16.SetActive(false);
			virus17.SetActive(false);
            virus18.SetActive(false);
        }
		
		if (YandexGame.savesData.virus == 10)
        {
            // Активация целевого объекта virus1
            virus10.SetActive(true);

            // Деактивация остальных объектов virus2 и virus3
			none.SetActive(false);
            virus1.SetActive(false);
            virus2.SetActive(false);
			virus3.SetActive(false);
            virus4.SetActive(false);
			virus5.SetActive(false);
            virus6.SetActive(false);
			virus7.SetActive(false);
            virus8.SetActive(false);
			virus9.SetActive(false);
			virus11.SetActive(false);
            virus12.SetActive(false);
			virus13.SetActive(false);
			virus14.SetActive(false);
            virus15.SetActive(false);
			virus16.SetActive(false);
			virus17.SetActive(false);
            virus18.SetActive(false);
        }
		
		if (YandexGame.savesData.virus == 11)
        {
            // Активация целевого объекта virus1
            virus11.SetActive(true);

            // Деактивация остальных объектов virus2 и virus3
			none.SetActive(false);
            virus1.SetActive(false);
            virus2.SetActive(false);
			virus3.SetActive(false);
            virus4.SetActive(false);
			virus5.SetActive(false);
            virus6.SetActive(false);
			virus7.SetActive(false);
            virus8.SetActive(false);
			virus9.SetActive(false);
			virus10.SetActive(false);
            virus12.SetActive(false);
			virus13.SetActive(false);
			virus14.SetActive(false);
            virus15.SetActive(false);
			virus16.SetActive(false);
			virus17.SetActive(false);
            virus18.SetActive(false);
        }
		
		if (YandexGame.savesData.virus == 12)
        {
            // Активация целевого объекта virus1
            virus12.SetActive(true);

            // Деактивация остальных объектов virus2 и virus3
			none.SetActive(false);
            virus1.SetActive(false);
            virus2.SetActive(false);
			virus3.SetActive(false);
            virus4.SetActive(false);
			virus5.SetActive(false);
            virus6.SetActive(false);
			virus7.SetActive(false);
            virus8.SetActive(false);
			virus9.SetActive(false);
			virus10.SetActive(false);
            virus11.SetActive(false);
			virus13.SetActive(false);
			virus14.SetActive(false);
            virus15.SetActive(false);
			virus16.SetActive(false);
			virus17.SetActive(false);
            virus18.SetActive(false);
        }
		
		if (YandexGame.savesData.virus == 13)
        {
            // Активация целевого объекта virus1
            virus13.SetActive(true);

            // Деактивация остальных объектов virus2 и virus3
			none.SetActive(false);
            virus1.SetActive(false);
            virus2.SetActive(false);
			virus3.SetActive(false);
            virus4.SetActive(false);
			virus5.SetActive(false);
            virus6.SetActive(false);
			virus7.SetActive(false);
            virus8.SetActive(false);
			virus9.SetActive(false);
			virus10.SetActive(false);
            virus11.SetActive(false);
			virus12.SetActive(false);
			virus14.SetActive(false);
            virus15.SetActive(false);
			virus16.SetActive(false);
			virus17.SetActive(false);
            virus18.SetActive(false);
        }
		
		if (YandexGame.savesData.virus == 14)
        {
            // Активация целевого объекта virus1
            virus14.SetActive(true);

            // Деактивация остальных объектов virus2 и virus3
			none.SetActive(false);
            virus1.SetActive(false);
            virus2.SetActive(false);
			virus3.SetActive(false);
            virus4.SetActive(false);
			virus5.SetActive(false);
            virus6.SetActive(false);
			virus7.SetActive(false);
            virus8.SetActive(false);
			virus9.SetActive(false);
			virus10.SetActive(false);
            virus11.SetActive(false);
			virus12.SetActive(false);
			virus13.SetActive(false);
            virus15.SetActive(false);
			virus16.SetActive(false);
			virus17.SetActive(false);
            virus18.SetActive(false);
        }
		
		if (YandexGame.savesData.virus == 15)
        {
            // Активация целевого объекта virus1
            virus15.SetActive(true);

            // Деактивация остальных объектов virus2 и virus3
			none.SetActive(false);
            virus1.SetActive(false);
            virus2.SetActive(false);
			virus3.SetActive(false);
            virus4.SetActive(false);
			virus5.SetActive(false);
            virus6.SetActive(false);
			virus7.SetActive(false);
            virus8.SetActive(false);
			virus9.SetActive(false);
			virus10.SetActive(false);
            virus11.SetActive(false);
			virus12.SetActive(false);
			virus13.SetActive(false);
            virus14.SetActive(false);
			virus16.SetActive(false);
			virus17.SetActive(false);
            virus18.SetActive(false);
        }
		
		if (YandexGame.savesData.virus == 16)
        {
            // Активация целевого объекта virus1
            virus16.SetActive(true);

            // Деактивация остальных объектов virus2 и virus3
			none.SetActive(false);
            virus1.SetActive(false);
            virus2.SetActive(false);
			virus3.SetActive(false);
            virus4.SetActive(false);
			virus5.SetActive(false);
            virus6.SetActive(false);
			virus7.SetActive(false);
            virus8.SetActive(false);
			virus9.SetActive(false);
			virus10.SetActive(false);
            virus11.SetActive(false);
			virus12.SetActive(false);
			virus13.SetActive(false);
            virus14.SetActive(false);
			virus15.SetActive(false);
			virus17.SetActive(false);
            virus18.SetActive(false);
        }
		
		if (YandexGame.savesData.virus == 17)
        {
            // Активация целевого объекта virus1
            virus17.SetActive(true);

            // Деактивация остальных объектов virus2 и virus3
			none.SetActive(false);
            virus1.SetActive(false);
            virus2.SetActive(false);
			virus3.SetActive(false);
            virus4.SetActive(false);
			virus5.SetActive(false);
            virus6.SetActive(false);
			virus7.SetActive(false);
            virus8.SetActive(false);
			virus9.SetActive(false);
			virus10.SetActive(false);
            virus11.SetActive(false);
			virus12.SetActive(false);
			virus13.SetActive(false);
            virus14.SetActive(false);
			virus15.SetActive(false);
			virus16.SetActive(false);
            virus18.SetActive(false);
        }
		
		if (YandexGame.savesData.virus == 18)
        {
            // Активация целевого объекта virus1
            virus18.SetActive(true);

            // Деактивация остальных объектов virus2 и virus3
			none.SetActive(false);
            virus1.SetActive(false);
            virus2.SetActive(false);
			virus3.SetActive(false);
            virus4.SetActive(false);
			virus5.SetActive(false);
            virus6.SetActive(false);
			virus7.SetActive(false);
            virus8.SetActive(false);
			virus9.SetActive(false);
			virus10.SetActive(false);
            virus11.SetActive(false);
			virus12.SetActive(false);
			virus13.SetActive(false);
            virus14.SetActive(false);
			virus15.SetActive(false);
			virus16.SetActive(false);
            virus17.SetActive(false);
        }
    }
}
