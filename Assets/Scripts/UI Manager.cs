using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject pasueMenu;
 public GameObject playButton;
 // Start is called before the first frame update
 public void callMyname()
 {
     Time.timeScale = 0;
     pasueMenu.SetActive(true);  
     playButton.SetActive(false);    
 }


 // Update is called once per frame
 void Update()
 {
     
 }
}
