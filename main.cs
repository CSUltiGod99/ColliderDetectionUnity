// CS - Unity - Create a Collider Detection:

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCollider : MonoBehaviour
{
     public Light mainLight;
     public Light detectionLight; // this will be used to define each object by 
  // the colour of the Light

     public GameObject enemySetTarget;
     public GameObject enemyAdditTarget_1;
     public Transform enemyTargetLocation;
     public Vector3 enemyTargPosition;

    void Update()
    {
  
      if(collision.tag == "Enemy1")
      {
          // this code will show what you if the tag is equal to 'Enemy1'
          Debug.Log("collision hit Enemy1");
      }   //

      if(true)
      {
          Destroy(SetTarget);
      }

      if(collision.tag == "Enemy")
      {
          
      }
      
      if(enemyTargetPosition.z > 0)
      {
          Destroy(enemyAdditTarget_1);
      }
}
