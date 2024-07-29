
namespace YG
{
    [System.Serializable]
    public class SavesYG
    {
        // "Технические сохранения" для работы плагина (Не удалять)
        public int idSave;
        public bool isFirstSession = true;
        public string language = "ru";
        public bool promptDone;

        // Тестовые сохранения для демо сцены
        public string newPlayerName = "Hello!";
        public bool[] openLevels = new bool[3];

        
		/////////////////////////////////////
		public int buy1;
		public int buy2;
		public int buy3;
		public int buy4;
		public int buy5;
		public int buy6;
		public int buy7;

        public int inject;
		public int virus;
		public int money;
		
		public int pop;
		public int rainbow;
		public int small;
		public int big;
		public int fly;
		public int toilet;
		public int besen;
		public int baloon;
		public int fire;
		public int teleport;
		public int splun;
		public int transform;
		public int plosko;
		public int dance;
		public int flip;

        // Поля (сохранения) можно удалять и создавать новые. При обновлении игры сохранения ломаться не должны


        // Вы можете выполнить какие то действия при загрузке сохранений
        public SavesYG()
        {
            // Допустим, задать значения по умолчанию для отдельных элементов массива

            openLevels[1] = true;
        }
    }
}
