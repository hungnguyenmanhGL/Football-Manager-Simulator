using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    [SerializeField]
    List<Animator> animatorList = new List<Animator>(); 



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayAnimationOnTrigger(int pos)
    {
        if (pos >= animatorList.Count)
        {
            Debug.Log("Out of range.");
            return;
        }
        else
        {
            animatorList[pos].SetBool("Play", true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        int pos = Random.Range(0, animatorList.Count);
        //Debug.Log(pos);
        PlayAnimationOnTrigger(pos);
    }
}
