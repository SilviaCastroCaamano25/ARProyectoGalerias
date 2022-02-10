using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MageScript : MonoBehaviour
{
    public GameObject definedButton;
    public UnityEvent OnClick = new UnityEvent();
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        definedButton = this.gameObject;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit Hit;

        if (Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject)
            {
                //Debug.Log("Funciona");
                animator.SetTrigger("Look");
            }
        }
    }
}
