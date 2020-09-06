using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public Button button;

    void Start()
    { 
        button.onClick.AddListener(TaskOnClick);
    }

    public void TaskOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
