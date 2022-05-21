using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassParticle : MonoBehaviour
{

    private ParticleSystem grassParticle;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        grassParticle = GetComponent<ParticleSystem>();
        player = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = player.transform.position - new Vector3(0, 0.3f, .8f);
        transform.rotation = player.transform.rotation;
        if (Input.GetKeyDown(KeyCode.Space))
            grassParticle.Play();
    }

}
