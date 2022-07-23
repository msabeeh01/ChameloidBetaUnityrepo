using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionScript : MonoBehaviour
{
    [SerializeField] private float transitionTime = 3;
    // Start is called before the first frame update
    void Update() {
        LoadNextLevel();
    }

    public void LoadNextLevel(){
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelindex){
        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelindex);
    }
}
