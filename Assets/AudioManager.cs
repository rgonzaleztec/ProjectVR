using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource1;
    public AudioSource audioSource2;
    public AudioSource audioSource3;
    public Animator animator1;
    public Animator animator2;
    public Animator animator3;

    public void Start(){   
        CallMethodsSequentially();
        
    }

    public void CallMethodsSequentially()
    {
        StartCoroutine(CallMethods());
    }

    IEnumerator CallMethods()
    {
        PlayAnimation1();
        yield return new WaitForSeconds(5f);
        PlayAnimation2();
        yield return new WaitForSeconds(5f);
        PlayAnimation3();
    }

    public void PlayAnimation1()
    {
        audioSource1.Play();
        animator1.SetBool("Enter", true);
        
       
    }
        public void PlayAnimation2()
    {
        audioSource2.Play();
        animator2.SetBool("Enter", true);
    }
        public void PlayAnimation3()
    {
        audioSource3.Play();
        animator3.SetBool("Enter", true);
    }
}
    


