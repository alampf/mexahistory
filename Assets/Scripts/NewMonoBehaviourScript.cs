using System;
using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    [SerializeField] private GameObject a_gameObject;
    [SerializeField] private GameObject a_parent;
    [SerializeField] private GameObject a_target;
    [SerializeField] private GameObject a_source;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Tesoro"))
        {
            a_gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
