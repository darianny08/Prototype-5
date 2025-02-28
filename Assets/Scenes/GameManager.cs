using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    private float spawnRate = 1.0f;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;

    public bool isGameActive;

    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
        StartCoroutine(SpawnTarget());
        
        
    }


    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);

    }

   
    IEnumerator SpawnTarget()
    {

        while (isGameActive)
       {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }

    public void RestartGame();
    {
        SceneManager.LoadScene(SceneManager.GetActice().name);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
