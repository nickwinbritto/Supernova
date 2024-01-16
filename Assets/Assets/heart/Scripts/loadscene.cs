using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(AudioSource))]
public class loadscene : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AudioSource aud;
    void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void loadnext()
    {

        StartCoroutine(Example());

    }
    IEnumerator Example()
    {
        aud.Play(0);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("CAM");
    }
}
