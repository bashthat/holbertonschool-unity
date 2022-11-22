using system.collections;
using system.collections.generic;
using unityengine;
using unityengine.scenemanager;

public class WinMenu : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Next()
    {
        SceneManager.LoadScene("Level2");
    }
    

}