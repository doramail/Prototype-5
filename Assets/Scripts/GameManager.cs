using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour /*, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerClickHandler */
{
    public Button restartButton;
    public List<GameObject> targets;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public bool gameIsActive;

    private Target _TargetScript;
    private int score = 0;
    private float spawnRate = 1.0f; // 1 second

    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        gameIsActive = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    IEnumerator SpawnTarget()
    {
        while (gameIsActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score : " + score;
    }

    // Start is called before the first frame update
    void Start()
    {
        gameIsActive = true;
        UpdateScore(score);
        StartCoroutine(SpawnTarget());
    }

    // Update is called once per frame
    void Update()
    {

    }

    //void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    //{
    //    Destroy(gameObject);
    //}

    //void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    //{
    //    // throw new System.NotImplementedException();
    //    //print($"New InputSystem on mouse down called on {this.name}!");

    //}

    //void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    //{
    //    //throw new System.NotImplementedException();
    //    // print($"New InputSystem on mouse Exit called on {this.name}!");

    //}

    //void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    //{
    //    //throw new System.NotImplementedException();
    //    // print($"New InputSystem on mouse Enter called on {this.name}!");

    //}
}
