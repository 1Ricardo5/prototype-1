using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FollowPlayer : MonoBehaviour
{
   public GameObject player;
   private Vector3 offset = new Vector3(0, 4, 3);
   private Vector3 offset2 = new Vector3(0, 5, -10);
   
    bool Pov = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
      
      if(Input.GetKeyDown(KeyCode.V) && Pov == true)
      {
        Debug.Log("check2");
        transform.position = player.transform.position + offset;
        Pov = false;
      }

      else if (Input.GetKeyDown(KeyCode.V) && Pov == false)
      {
        Debug.Log("check");
        transform.position = player.transform.position + offset2;
        Pov = true;
      }
    }
   
    
    








}
