using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aniplay : MonoBehaviour
{
    private Animator manimator;
    void Start()
    {
        manimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void rotat()
    {
        manimator.SetTrigger("ATrigger");

    }
}
