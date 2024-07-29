using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject[] mobileOnlyObjects;
    private bool isPaused = false;
    private bool isMobile = false;

    private void Start()
    {
        Application.targetFrameRate = 60;
        isMobile = Application.isMobilePlatform;

        if (!isMobile)
        {
            Cursor.lockState = CursorLockMode.Locked;
            for (int i = 0; i < mobileOnlyObjects.Length; i++)
            {
                Destroy(mobileOnlyObjects[i]);
                mobileOnlyObjects[i] = null;
            }
        }
    }

    public void QuitToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
