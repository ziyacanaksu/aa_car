using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DecreaseCount : MonoBehaviour
{
    [SerializeField] private float Level ;
    [SerializeField] private TMP_Text LevelPass;
    // Start is called before the first frame update
    void Start()
    {
        LevelPass.text = Level.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Level == 0){
            LoadSceneWithDelay("Level1to2", 3.0f);
        }
        if (Level == -1){
             LoadSceneWithDelay("MainMenu", 3.0f);
        }
        

        
    }
    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Finish")){
            Level -= 1;
            LevelPass.text = Level.ToString();

        }
    }
    IEnumerator LoadSceneAfterDelay(string sceneName, float delay)
{
    // Wait for the specified delay
    yield return new WaitForSeconds(delay);
    
    // Load the scene
    SceneManager.LoadScene(sceneName);
}

public void LoadSceneWithDelay(string sceneName, float delay)
{
    StartCoroutine(LoadSceneAfterDelay(sceneName, delay));
}
}
