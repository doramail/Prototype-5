using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseInputs : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerClickHandler
{
    private GameManager _fromGameManagerScript;

    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        Destroy(gameObject);
        _fromGameManagerScript.UpdateScore(5);
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        // throw new System.NotImplementedException();
        //print($"New InputSystem on mouse down called on {this.name}!");

    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        // print($"New InputSystem on mouse Exit called on {this.name}!");

    }

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        // print($"New InputSystem on mouse Enter called on {this.name}!");

    }

    // Start is called before the first frame update
    void Start()
    {
        _fromGameManagerScript = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
