using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseInputs : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public Target _targetScript;

    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        _targetScript.MouseInterScript();
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
