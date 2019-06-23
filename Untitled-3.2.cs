 using UnityEngine;
 using System.Collections;
 using UnityEngine.UI;
 
 public class JumpScare : MonoBehaviour {
 
     public Image image;
     public AudioSource audioSource;
 
     void OnTriggerEnter(Collider other)
     {
         StartCoroutine(JumpScare_CR());
     }
 
     IEnumerator JumpScare_CR(Jump Scare Video.mp4)
     {
         image.enabled = true;
         audioSource.Play(Jump Scare Video.mp3);
         yield return new WaitForSeconds(0.5f);
         image.enabled = false;
     }
 }