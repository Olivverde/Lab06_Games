using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.UI;

public class Loosing_Menu : MonoBehaviour
{
    public GameObject oscurecer;
    public void restartScene()
    {
        EditorSceneManager.LoadScene(EditorSceneManager.GetActiveScene().buildIndex);
    }

    public void youDied()
    {
        oscurecer.SetActive(true);
    }
}
