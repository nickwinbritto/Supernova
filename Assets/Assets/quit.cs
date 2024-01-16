using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class quit : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] AudioSource audioData;
    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void quitapp()
    {
        audioData.Play(0);
        Application.Quit();
    }
}
