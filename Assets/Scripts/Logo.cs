using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Logo : MonoBehaviour {

    private SpriteRenderer img;



    private float delay = 0.05f;
    private float tim = 0.5f;

    private int rdyAd = 3;
    // Use this for initialization
    void Start()
    {
       

        img = GetComponent<SpriteRenderer>();
        StartCoroutine(toMenu());
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > delay + tim)
        {
            img.color += new Color(1f, 1f, 1f, 0.055f);
            tim = Time.time;
        }


    }

    IEnumerator toMenu()
    {

        yield return new WaitForSeconds(1.65f);
        SceneManager.LoadScene(1);
    }
}
