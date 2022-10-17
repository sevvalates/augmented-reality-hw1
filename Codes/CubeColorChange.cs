using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColorChange : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.touchCount>0 && Input.touches[0].phase == TouchPhase.Began)
        {
            
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;
 
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "box")
                {
                    Color newColor =new Color(255, 0, 0);
                    hit.collider.GetComponent<MeshRenderer>().material.color = newColor; 
                }
            }
 
        }
        //Win();
    }
/*
    public void Win(){
        bool areAllObjectsRed = GameObject.FindGameObjectsWithTag("box")
                               .Select(a => a.GetComponent<MeshRenderer>())
                               .All(a => a.color == "red");
        if(areAllObjectsRed){
            GameObject.FindGameObjectsWithTag("winText").SetActive(true);
        }
    }
*/
}
