using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour /*, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerClickHandler */
{
    private Target _TargetScript;

    public List<GameObject> targets;
    public TextMeshProUGUI scoreText;

    private int score = 0;
    private float spawnRate = 1.0f; // 1 second

    IEnumerator SpawnTarget()
    {
        while (true)
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
        StartCoroutine(SpawnTarget());
        UpdateScore(score);
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
