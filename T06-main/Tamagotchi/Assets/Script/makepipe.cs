using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makepipe : MonoBehaviour
{
    public GameObject pipe;
    float timer = 0;
    public float timediff;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(pipe);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timediff)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(3.7f, Random.Range(-4.0f, -3.0f), 0);
            timer = 0;
            Destroy(newpipe, 5.0f);
        }
       
    }
}
