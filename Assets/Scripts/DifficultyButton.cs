using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    public int difficulty;

    private GameManager _gameManagerScript;
    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        _gameManagerScript = GameObject.Find("Game Manager").GetComponent<GameManager>();
        button.onClick.AddListener(SetDifficulty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetDifficulty()
    {
        // Debug.Log(gameObject.name + " was clicked");
        _gameManagerScript.StartGame(difficulty);
    }
}
