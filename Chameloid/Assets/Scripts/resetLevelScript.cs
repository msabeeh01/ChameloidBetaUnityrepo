using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class resetLevelScript : MonoBehaviour
{
    public void Restart(){
        SceneManager.LoadScene("SampleScene");
    }

    public void Quit(){
        Application.Quit();
    }


}
