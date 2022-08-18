using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene(1 );
    }

    public void QuitButton()
    {
          Application.Quit();
    }

    public void QuitMenu()
    {
        SceneManager.LoadScene(0);
    }

}
