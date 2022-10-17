using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    private Touch touch; //hold info about finger touch : such as num of touches , touch position , ..
    private float speedModifier; //help not to move the cube too fast

    // Start is called before the first frame update
    void Start()
    {
        speedModifier = 0.01f; //cube will move a 100 times slower than it could
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0); //assigned to the first finger touch

            if(touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(
                    transform.position.x + touch.deltaPosition.x * speedModifier,
                    transform.position.y,
                    transform.position.z + touch.deltaPosition.y * speedModifier
                );
            }
        }
        
    }
}
