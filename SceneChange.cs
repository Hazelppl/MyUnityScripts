using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public int changeNum;
    public Image changeScene;
    // Start is called before the first frame update
    public void OnClick()
    {
        SceneManager.LoadScene(changeNum);
    }
    public void closeGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
