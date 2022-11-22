using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUI : MonoBehaviour
{
    public GameObject panel;
     public void OnTriggerEnter(Collider col) 
     { 
        if (col.tag == "Player") 
     { 
        Destroy(col.gameObject); panel.SetActive(true);
      } 
      }
      }
